Public Class Criminal

    Private SuccessSubject As String
    Private FailureSubject As String
    Public Property ScheduleConfig As String
    Public Property DS As DS_Kron
    Public Property Schedule As DS_Kron.ScheduleRow
    Public Property Task As DS_Kron.ScheduleTaskRow

    Sub Execute()
        Console.WriteLine(Now.ToString & " Starting Task:" & Schedule.Name & ", " & Task.TaskRow.Name)

        SuccessSubject = "ExecuKron\Sucessful Task\" & Schedule.Name & "\" & Task.TaskRow.Name
        FailureSubject = "ExecuKron\Failed Task\" & Schedule.Name & "\" & Task.TaskRow.Name

        Dim p As New Process
        p.EnableRaisingEvents = True
        AddHandler p.ErrorDataReceived, AddressOf p_ErrorDataReceived
        AddHandler p.Exited, AddressOf p_Exited


        'Dim std_out As StreamReader = Nothing
        'Dim std_err As StreamReader = Nothing
        'Dim std_in As StreamWriter = Nothing

        'Dim StartInfo As New ProcessStartInfo("cmd")
        Dim StartInfo As New ProcessStartInfo(Task.TaskRow.Command)
        Dim FO As New IO.FileInfo(Task.TaskRow.Command)
        If FO.Exists Then
            StartInfo.WorkingDirectory = FO.Directory.FullName
        End If


        'StartInfo.UseShellExecute = False
        'StartInfo.RedirectStandardError = True
        'StartInfo.RedirectStandardOutput = True
        'StartInfo.RedirectStandardInput = True
        Try
            Task.LastStartTime = Now
            p.StartInfo = StartInfo
            p.Start()

            'std_out = p.StandardOutput()
            'std_err = p.StandardError()
            'std_in = p.StandardInput


            Console.WriteLine(Now.ToString & " Started PID: " & p.Id & " " & Task.TaskRow.Command)
            'Dim FO As New IO.FileInfo(Task.TaskRow.Command)
            'If FO.Exists Then
            'Dim DIR = "CD " & FO.Directory.FullName
            'std_in.WriteLine(DIR)
            'std_in.WriteLine(FO.Name)
            'Else
            'std_in.WriteLine(Task.TaskRow.Command)
            'End If

            'std_in.WriteLine("exit")
            'Task.LastOutput = std_out.ReadToEnd
            'Task.LastError = std_err.ReadToEnd
            p.WaitForExit()
            Try
                Task.LastExitCode = p.ExitCode
            Catch ex As Exception
                Console.WriteLine("Error Getting Exit code for PID: " & p.Id & " " & ex.Message)
            End Try



            'If p.ExitCode = 0 Then
            '    Console.WriteLine(Now.ToString & " Finished: No Errors")
            '    If Task.TaskRow.SuccessNotify Then
            '        'SendLogEmail("ExecuKron\Sucessful Task\" & Schedule.Name & "\" & Task.TaskRow.Name, std_out.ReadToEnd)
            '        SendLogEmail(SuccessSubject, "")
            '    End If
            'Else
            '    Console.WriteLine(Now.ToString & " Finished: Exit Code:" & p.ExitCode)
            '    If Task.TaskRow.FailNotify Then
            '        SendLogEmail(FailureSubject, "")
            '        'SendLogEmail("ExecuKron\Failed Task\" & Schedule.Name & "\" & Task.TaskRow.Name, std_out.ReadToEnd)
            '    End If
            'End If
        Catch ex As Exception
            'If std_err Is Nothing Then
            'Console.WriteLine(Now.ToString & " Task: " & ex.Message)
            'Else
            Console.WriteLine(Now.ToString & " Task: " & ex.Message & vbCrLf & Task.LastError)
            If Task.TaskRow.FailNotify Then
                'SendLogEmail("ExecuKron\Failed Task\" & Schedule.Name & "\" & Task.TaskRow.Name, std_out.ReadToEnd)
                SendLogEmail("ExecuKron\Failed Task\" & Schedule.Name & "\" & Task.TaskRow.Name, "")
            End If
            'End If

        Finally


            Task.LastEndTime = Now 'p.ExitTime
            Task.Running = False
            DS.WriteXml(ScheduleConfig)

            'std_err.Close()
            'std_err.Dispose()
            'std_out.Close()
            'std_out.Dispose()
            p.Close()
            p.Dispose()
        End Try
    End Sub

    Sub SendLogEmail(Subject As String, Body As String)
        Dim S As Net.Mail.SmtpClient
        Dim M As Net.Mail.MailMessage
        Try
            M = New Net.Mail.MailMessage("reports@flmiami.com", "administrator@flmiami.com")
            M.Subject = Subject
            M.IsBodyHtml = True
            M.BodyEncoding = System.Text.Encoding.ASCII
            M.Body = <BODY style="font-family:Lucidia Console; font-size:small; background-color:white; color:black;"><PRE><%= Body %></PRE></BODY>.ToString
            S = New Net.Mail.SmtpClient("openmail")
            S.Send(M)
        Catch ex As Exception
            Console.WriteLine("Error Sending email: " & ex.Message)
        Finally
            M.Dispose()
            S.Dispose()
        End Try


    End Sub

    Private Sub p_ErrorDataReceived(sender As Object, e As System.Diagnostics.DataReceivedEventArgs)
        Dim p As Process = sender
        Try
            Console.WriteLine(Now.ToString & " PID:" & p.Id & " had an error:" & vbCrLf & e.Data)

            If Task.TaskRow.FailNotify Then
                Dim EmailMessage = Now.ToString & " PID:" & p.Id & " had an error:" & vbCrLf & e.Data
                SendLogEmail(FailureSubject, "Command:" & p.StartInfo.FileName & vbCrLf & "Error Details:" & vbCrLf & e.Data)
            End If
        Catch ex As Exception
            Console.WriteLine("Error Getting error data for PID: " & p.Id & " " & ex.Message)
        End Try


    End Sub

    Private Sub p_Exited(sender As Object, e As System.EventArgs)
        Dim p As Process = sender
        Try
            Console.WriteLine(Now.ToString & " PID:" & p.Id & " has exited.")
            If p.ExitCode = 0 Then
                If Task.TaskRow.SuccessNotify Then
                    SendLogEmail(SuccessSubject, "Command: " & p.StartInfo.FileName)
                End If
            End If
        Catch ex As Exception
            Console.WriteLine("Error Getting Exit code for PID: " & p.Id & " " & ex.Message)
        End Try

    End Sub
End Class
