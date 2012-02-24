Imports System.Threading.Tasks

Module Module1

    Public Service As New Executioner

    Sub Main()
        Dim T As New Task(AddressOf Service.Start)
        T.Start()

        If My.Application.CommandLineArgs.Count > 0 AndAlso My.Application.CommandLineArgs.Item(0) = "CONFIGURE" Then
            Dim F As New ScheduleForm
            F.ShowDialog()
        End If

InfiniteLoop:
        Threading.Thread.Sleep(1000)
        GoTo InfiniteLoop

    End Sub

End Module
