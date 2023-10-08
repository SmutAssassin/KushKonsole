Imports System.Diagnostics

Public Class Form1
    Private process As Process
    Private output As String

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True ' Suppress the Enter key press to prevent a new line in the TextBox
            ExecuteCommand(TextBox1.Text)
            TextBox1.Clear()
        End If
    End Sub

    Private Sub ExecuteCommand(command As String)
        process = New Process()
        Dim startInfo As New ProcessStartInfo()

        startInfo.FileName = "cmd.exe" ' Use the command prompt
        startInfo.Arguments = "/K " & command ' Keep the console window open after executing the command
        startInfo.RedirectStandardOutput = True
        startInfo.RedirectStandardInput = True
        startInfo.UseShellExecute = False
        startInfo.CreateNoWindow = True

        process.StartInfo = startInfo

        ' Subscribe to the OutputDataReceived event using AddHandler
        AddHandler process.OutputDataReceived, AddressOf Process_OutputDataReceived

        process.Start()
        process.BeginOutputReadLine()
    End Sub

    Private Sub Process_OutputDataReceived(sender As Object, e As DataReceivedEventArgs)
        If Not String.IsNullOrEmpty(e.Data) Then
            output &= e.Data & vbCrLf
            RichTextBox1.Text = output
        End If
    End Sub
End Class
