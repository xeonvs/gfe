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
	class Program
	{
		private const string SVN_DIRECTORY_NAME = ".svn";
		private const string SVN_ENTRIES_FILE_NAME = "entries";
		private const string XPATH_REVISION = @"ns:wc-entries/ns:entry/@revision";
		private const string REPLACE_MARK = "$WCREV$";
		private const string SEPARATE_LINE = "----------------------------------------------";
		private const string PROGRAM_INFO = "\n\rSvnRevision read the Subversion status of all files in a working folder. Then the highest revision number found is used to replace all occurences of $WCREV$ in template and save it, if made changes in revision number\n\r";
		private const string ARGUMENT_INFO = "Need three arguments: <path to working folder> <path to template> <path to dest>.";

		[STAThread]
		static int Main(string[] args)
		{
			try
			{

				Console.WriteLine(PROGRAM_INFO);

				if (args.Length != 3)
					throw new ArgumentException(ARGUMENT_INFO);

				string workingFolder = args[0];
				string templatePath = args[1];
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
				Console.WriteLine(e.ToString());
				Console.WriteLine(SEPARATE_LINE);
				return 1; //  од ошибки дл€ студии
			}
		}

		private static void ProcessTemplate(string templatePath, string destinationPath, int revision)
		{
			Encoding encoding = Encoding.Default; 
			string template = string.Empty;
			string destination = string.Empty;

			using (StreamReader templateStream = new StreamReader(templatePath, encoding, true))
			{
				template = templateStream.ReadToEnd();                                                
				encoding = templateStream.CurrentEncoding;
			}

			template = template.Replace(REPLACE_MARK, revision.ToString(CultureInfo.InvariantCulture));

			if (File.Exists(destinationPath))
			{
				using(StreamReader destinationStream = new StreamReader(destinationPath, encoding))
					destination = destinationStream.ReadToEnd();
			}

			if (string.Compare(template, destination, false, CultureInfo.InvariantCulture) == 0)
				return;

			using (StreamWriter writer = new StreamWriter(destinationPath, false, encoding))
				writer.Write(template);
		}

		private static int FindRevision(DirectoryInfo directoryInfo, int maxRevision)
		{
			int revision = 0;
			foreach (DirectoryInfo subDir in directoryInfo.GetDirectories())
			{
				if (string.Compare(subDir.Name, SVN_DIRECTORY_NAME, true, CultureInfo.InvariantCulture) == 0)
					revision = GetRevision(subDir, maxRevision);
				else
					revision = FindRevision(subDir, maxRevision);

				if (revision > maxRevision)
					maxRevision = revision;
			}

			return maxRevision;
		}

		private static int GetRevision(DirectoryInfo dir, int maxRevision)
		{
			string filePath = Path.Combine(dir.FullName, SVN_ENTRIES_FILE_NAME);

			if (!File.Exists(filePath))
				return maxRevision;

			using (FileStream entriesFile = File.OpenRead(filePath))
			{
				using (StreamReader reader = new StreamReader(entriesFile))
				{
					XPathDocument doc = new XPathDocument(reader);
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
							int revision = int.Parse(iterator.Current.Value, NumberStyles.Integer, CultureInfo.InvariantCulture);
							if (revision > maxRevision)
								maxRevision = revision;
						}
						catch (FormatException)
						{
                            
						}
					}
				}
			}

			return maxRevision;
		}
	}
}
