Imports System.IO

Public Class Executioner
    WithEvents Timer As New Timers.Timer(1000 * 60)
    Public Property ScheduleConfig = "Schedule.xml"

    Sub Start()
        Console.Title = "ExecuKron Event Log"
        Console.WriteLine(Now.ToString & " ExecuKron Started.")
        Timer.Start()
    End Sub


    Private Sub Timer_Elapsed(sender As Object, e As System.Timers.ElapsedEventArgs) Handles Timer.Elapsed
        Console.WriteLine(Now.ToString & " Tick")
        If Not My.Computer.FileSystem.FileExists(ScheduleConfig) Then Exit Sub

        Dim DS As New DS_Kron
        DS.ReadXml(ScheduleConfig)

        Dim CurrentTime = Now
        Dim SchedulesToRun = (From x In DS.Schedule
                             Where x.Minutes.Contains(CurrentTime.Minute) AndAlso
                             x.Hours.Contains(CurrentTime.Hour) AndAlso
                             x.DaysOfMonth.Contains(CurrentTime.Day) AndAlso
                             x.DaysOfWeek.Contains(CurrentTime.DayOfWeek) AndAlso
                             x.Months.Contains(CurrentTime.Month)
                             ).ToList

        For Each Schedule In SchedulesToRun
            For Each Task In Schedule.GetScheduleTaskRows
                Dim Criminal As New Criminal With {.ScheduleConfig = ScheduleConfig, .DS = DS, .Schedule = Schedule, .Task = Task}
                'Criminal.Execute()
                Dim T As New Threading.Tasks.Task(AddressOf Criminal.Execute)
                T.RunSynchronously()
            Next
        Next
    End Sub




   
End Class
