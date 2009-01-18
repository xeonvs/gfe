Option Strict Off
Option Explicit On

Imports Microsoft.Win32

Module Registry
	
    Public Sub WriteRegistry(ByVal ParentKey As RegistryKey, ByVal SubKey As String, _
       ByVal ValueName As String, ByVal Value As Object)

        Dim Key As RegistryKey

        Try
            'Open the registry key.
            Key = ParentKey.OpenSubKey(SubKey, True)
            If Key Is Nothing Then 'if the key doesn't exist.
                Key = ParentKey.CreateSubKey(SubKey)
            End If

            'Set the value.
            Key.SetValue(ValueName, Value)
#If DEBUG Then
            Console.WriteLine("Value:{0} for {1} is successfully written.", Value, ValueName)
#End If
        Catch e As Exception
#If DEBUG Then
            Console.WriteLine("Error occurs in WriteRegistry" & e.Message)
#End If
        End Try
    End Sub

    Public Sub ReadRegistry(ByVal ParentKey As RegistryKey, ByVal SubKey As String, _
        ByVal ValueName As String, ByRef Value As Object, ByVal DefaultValue As Object)

        Dim Key As RegistryKey

        Try
            'Open the registry key.
            Key = ParentKey.OpenSubKey(SubKey, True)
            If Key Is Nothing Then 'if the key doesn't exist
                Value = DefaultValue
                Throw New Exception("The registry key doesn't exist")
            End If

            'Get the value.
            Value = Key.GetValue(ValueName, DefaultValue)

            Console.WriteLine("Value:{0} for {1} is successfully retrieved.", Value, ValueName)
        Catch e As Exception
            Console.WriteLine("Error occurs in ReadRegistry" & e.Message)
        End Try

    End Sub
End Module