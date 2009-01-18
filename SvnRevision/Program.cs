using System;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.XPath;

namespace SvnRevision
{
	/// <summary>
	///  «амена SubWCRev.exe, см. сообщение
	///  http://gzip.rsdn.ru/forum/Message.aspx?mid=871939&only=1
	///  
	///  »де€: просканировать скрытые папки .svn в рабочей копии репозитори€, воспользоватьс€
	///  служебным файлом entries в формате XML и вытащить из него атрибут revision и выдать
	///  его максимальное значение. «атем просканировать шаблон и заменить вхождени€ $WCREV$ на
	///  номер ревизии, и сохранить полученное, только если были изменени€.
	/// </summary>
	internal class Program
	{
		private const string ARGUMENT_INFO =
			"Need three arguments: <path to working folder> <path to template> <path to dest>.";

		private const string PROGRAM_INFO =
			"\n\rSvnRevision read the Subversion status of all files in a working folder. Then the highest revision number found is used to replace all occurences of $WCREV$ in template and save it, if made changes in revision number\n\r";

		private const string REPLACE_MARK = "$WCREV$";

		private const string SEPARATE_LINE =
			"----------------------------------------------";

		private const string SVN_ASP_DOT_NET_HACK                = "SVN_ASP_DOT_NET_HACK";
		private const string SVN_DIRECTORY_NAME_ASP_DOT_NET_HACK = "_svn";
		private const string SVN_DIRECTORY_NAME_COMMON           = ".svn";
		
		private const string SVN_ENTRIES_FILE_NAME               = "entries";
		private const string SVN_FORMAT_FILE_NAME                = "format";
		private const string XPATH_REVISION                      = @"ns:wc-entries/ns:entry/@revision";
		
		private static readonly string SVN_DIRECTORY_NAME =
			Environment.GetEnvironmentVariable(SVN_ASP_DOT_NET_HACK) != null
				? SVN_DIRECTORY_NAME_ASP_DOT_NET_HACK
				: SVN_DIRECTORY_NAME_COMMON;

		[STAThread]
		private static int Main(string[] args)
		{
			try
			{
				Console.WriteLine(PROGRAM_INFO);

				if (args.Length != 3)
					throw new ArgumentException(ARGUMENT_INFO);

				string workingFolder   = args[0];
				string templatePath    = args[1];
				string destinationPath = args[2];
				
				if (!Directory.Exists(workingFolder))
					throw new DirectoryNotFoundException();

				if (!File.Exists(templatePath))
					throw new FileNotFoundException(string.Empty, templatePath);

				int revision = FindRevision(new DirectoryInfo(workingFolder), 0);
				Console.WriteLine("Current Revision is {0}", revision);

				ProcessTemplate(templatePath, destinationPath, revision);

				return 0;
			}
			catch (Exception e)
			{
				Console.WriteLine(SEPARATE_LINE);
				Console.WriteLine(e);
				Console.WriteLine(SEPARATE_LINE);

				return 1; //  од ошибки дл€ студии
			}
		}

		private static void ProcessTemplate(string templatePath, 
			string destinationPath, int revision)
		{
			Encoding encoding  = Encoding.Default;
			string destination = string.Empty;

			string template;

			using (StreamReader templateStream =
				new StreamReader(templatePath, encoding, true))
			{
				template = templateStream.ReadToEnd();
				encoding = templateStream.CurrentEncoding;
			}

			template = template.Replace(REPLACE_MARK,
				revision.ToString(CultureInfo.InvariantCulture));

			if (File.Exists(destinationPath))
				destination = File.ReadAllText(destinationPath, encoding);


			if (string.Equals(template, destination, StringComparison.InvariantCulture))
				return;

			File.WriteAllText(destinationPath, template, encoding);
		}

		private static int FindRevision(DirectoryInfo directoryInfo, int maxRevision)
		{
			RevisionGetter revisionGetter = null;

			foreach (DirectoryInfo subDir in directoryInfo.GetDirectories())
			{
				int revision = 0;

				if (string.Equals(subDir.Name, SVN_DIRECTORY_NAME,
					StringComparison.InvariantCultureIgnoreCase))
				{
					if ((revisionGetter ?? (revisionGetter = GetRevisionGetter(subDir))) != null)
						revision = revisionGetter(subDir, maxRevision);
				}
				else
					revision = FindRevision(subDir, maxRevision);

				if (revision > maxRevision)
					maxRevision = revision;
			}

			return maxRevision;
		}

		private static RevisionGetter GetRevisionGetter(DirectoryInfo directoryInfo)
		{
			if (directoryInfo == null)
				throw new ArgumentNullException("directoryInfo");

			string filePath = Path.Combine(directoryInfo.FullName, SVN_FORMAT_FILE_NAME);

			if (File.Exists(filePath))
			{
				string version = File.ReadAllText(filePath, Encoding.ASCII);

				switch (version.TrimEnd())
				{
					case "4": return GetRevisionVer4;
					case "8":
					case "9": return GetRevisionVer8;
				}
			}

			return delegate { return 0; };
		}

		private static int GetRevisionVer4(DirectoryInfo dir, int maxRevision)
		{
			string filePath = Path.Combine(dir.FullName, SVN_ENTRIES_FILE_NAME);

			if (!File.Exists(filePath))
				return maxRevision;

			using (StreamReader reader = new StreamReader(filePath))
			{
				XPathDocument  doc = new XPathDocument(reader);
				XPathNavigator nav = doc.CreateNavigator();

				XmlNamespaceManager manager = new XmlNamespaceManager(nav.NameTable);
				manager.AddNamespace("ns", "svn:");

				XPathExpression expr = nav.Compile(XPATH_REVISION);
				expr.SetContext(manager);

				XPathNodeIterator iterator = nav.Select(expr);

				while (iterator.MoveNext())
				{
					try
					{
						int revision = int.Parse(iterator.Current.Value,
							NumberStyles.Integer, CultureInfo.InvariantCulture);

						if (revision > maxRevision)
							maxRevision = revision;
					}
					catch (FormatException)
					{
					}
				}
			}

			return maxRevision;
		}

		private static int GetRevisionVer8(DirectoryInfo dir, int maxRevision)
		{
			string filePath = Path.Combine(dir.FullName, SVN_ENTRIES_FILE_NAME);

			if (!File.Exists(filePath))
				return maxRevision;

			try
			{
				using (StreamReader sr = new StreamReader(filePath))
				{
					int lineCounter = 0;

					string line;
					while ((line = sr.ReadLine()) != null)
					{
						if (lineCounter == 3)
						{
							int revision = int.Parse(line, 
								NumberStyles.Integer, CultureInfo.InvariantCulture);

							if (revision > maxRevision)
								maxRevision = revision;

							break;
						}

						lineCounter++;
					}
				}
			}
			catch (FormatException)
			{
			}

			return maxRevision;
		}

		#region Nested type: RevisionGetter

		private delegate int RevisionGetter(DirectoryInfo dir, int maxRevision);

		#endregion
	}
}