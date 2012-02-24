Partial Class ScheduleForm
    Public Property ScheduleConfig = "Schedule.xml"

    Private Sub btn_Save_Click(sender As System.Object, e As System.EventArgs) Handles btn_Save.Click

        If My.Computer.FileSystem.FileExists(ScheduleConfig) Then
            Dim BackupConfig = String.Format("Schedule.{0}.{1}.{2}-{3}.{4}.{5}.xml",
                                             {Now.Year, Now.Month, Now.Day, Now.Hour, Now.Minute, Now.Second})
            My.Computer.FileSystem.MoveFile(ScheduleConfig, BackupConfig, True)
        End If

        Me.Validate()
        Me.ScheduleTasksDataGridView.EndEdit()
        Me.TasksDataGridView.EndEdit()
        Me.SchedulesDataGridView.EndEdit()
        DS_Kron.WriteXml(ScheduleConfig)
        MsgBox("Saved Sucessfully.", MsgBoxStyle.Information, "Schedules Saved")
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        l_daysOfWeek.Items.Clear()
        l_daysOfWeek.Items.AddRange([Enum].GetNames(GetType(DayOfWeek)))

        If My.Computer.FileSystem.FileExists(ScheduleConfig) Then
            Me.DS_Kron.ReadXml(ScheduleConfig)
        End If
    End Sub

    Public Property Loadingsizes As Boolean = False

    Private Sub ScheduleBindingSource_CurrentChanged(sender As System.Object, e As System.EventArgs) Handles ScheduleBindingSource.CurrentChanged
        ScheduleDetailsGroup.Enabled = Not ScheduleBindingSource.Current Is Nothing
        Dim Schedule As DS_Kron.ScheduleRow = ScheduleBindingSource.Current.row

        If Schedule.IsMonthsNull Then Exit Sub

        Loadingsizes = True
        l_Months.ClearSelected()
        For Each Item In Schedule.Months
            l_Months.SetSelected(Item - 1, True)
        Next

        l_daysOfMonth.ClearSelected()
        For Each Item In Schedule.DaysOfMonth
            l_daysOfMonth.SetSelected(Item - 1, True)
        Next

        l_daysOfWeek.ClearSelected()
        For Each Item In Schedule.DaysOfWeek
            l_daysOfWeek.SetSelected(Item, True)
        Next

        l_Hours1.ClearSelected()
        'l_Hours2.ClearSelected()
        For Each Item In Schedule.Hours
            If Item = 0 Then
                'l_Hours2.SetSelected(l_Hours2.FindStringExact("00"), True)
            Else

                Dim ItemIndex = l_Hours1.FindStringExact(Item)
                If ItemIndex > -1 Then
                    l_Hours1.SetSelected(Item - 1, True)
                Else
                    'Dim ItemIndex2 = l_Hours2.FindStringExact(Item)
                    'If ItemIndex2 > -1 Then
                    'l_Hours2.SetSelected(ItemIndex2, True)
                    'End If
                End If

            End If
        Next

        l_Minutes1.ClearSelected()
        l_Minutes2.ClearSelected()
        For Each Item In Schedule.Minutes
            If Item = 0 Then
                l_Minutes2.SetSelected(l_Minutes2.FindStringExact("00"), True)
            Else

                Dim ItemIndex = l_Minutes1.FindStringExact(Item)
                If ItemIndex > -1 Then
                    l_Minutes1.SetSelected(Item - 1, True)
                Else
                    Dim ItemIndex2 = l_Minutes2.FindStringExact(Item)
                    If ItemIndex2 > -1 Then
                        l_Minutes2.SetSelected(ItemIndex2, True)
                    End If
                End If

            End If
        Next

        Loadingsizes = False

    End Sub

    Private Sub l_daysOfMonth_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles l_daysOfMonth.SelectedIndexChanged
        If ScheduleBindingSource.Current Is Nothing Or Loadingsizes Then Exit Sub
        Dim Schedule As DS_Kron.ScheduleRow = ScheduleBindingSource.Current.row
        Schedule.DaysOfMonth = (From x In l_daysOfMonth.SelectedItems Select CInt(x)).ToArray
    End Sub

    Private Sub l_Months_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles l_Months.SelectedIndexChanged
        If ScheduleBindingSource.Current Is Nothing Or Loadingsizes Then Exit Sub
        Dim Schedule As DS_Kron.ScheduleRow = ScheduleBindingSource.Current.row
        Schedule.Months = (From x In l_Months.SelectedItems Select CInt(x)).ToArray
    End Sub

    Private Sub l_daysOfWeek_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles l_daysOfWeek.SelectedIndexChanged
        If ScheduleBindingSource.Current Is Nothing Or Loadingsizes Then Exit Sub
        Dim Schedule As DS_Kron.ScheduleRow = ScheduleBindingSource.Current.row
        Schedule.DaysOfWeek = (From x In l_daysOfWeek.SelectedIndices Select CInt(x)).ToArray
    End Sub

    Private Sub l_Hours1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles l_Hours1.SelectedIndexChanged
        If ScheduleBindingSource.Current Is Nothing Or Loadingsizes Then Exit Sub
        Dim Schedule As DS_Kron.ScheduleRow = ScheduleBindingSource.Current.row
        Dim Hours As New List(Of Integer)
        Hours.AddRange((From x In l_Hours1.SelectedItems Select CInt(x)).ToArray)
        'Hours.AddRange((From x In l_Hours2.SelectedItems Select CInt(x)).ToArray)
        Schedule.Hours = Hours.ToArray
    End Sub

    Private Sub l_Minutes1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles l_Minutes2.SelectedIndexChanged, l_Minutes1.SelectedIndexChanged
        If ScheduleBindingSource.Current Is Nothing Or Loadingsizes Then Exit Sub
        Dim Schedule As DS_Kron.ScheduleRow = ScheduleBindingSource.Current.row
        Dim Mins As New List(Of Integer)
        Mins.AddRange((From x In l_Minutes1.SelectedItems Select CInt(x)).ToArray)
        Mins.AddRange((From x In l_Minutes2.SelectedItems Select CInt(x)).ToArray)
        Schedule.Minutes = Mins.ToArray
    End Sub

    Private Sub SchedulesDataGridView_UserAddedRow(sender As System.Object, e As System.Windows.Forms.DataGridViewRowEventArgs) Handles SchedulesDataGridView.UserAddedRow

        For i As Integer = 0 To l_Months.Items.Count - 1
            l_Months.SetSelected(i, True)
        Next

        For i As Integer = 0 To l_daysOfMonth.Items.Count - 1
            l_daysOfMonth.SetSelected(i, True)
        Next

        For i As Integer = 0 To l_daysOfWeek.Items.Count - 1
            l_daysOfWeek.SetSelected(i, True)
        Next

        For i As Integer = 0 To l_Hours1.Items.Count - 1
            l_Hours1.SetSelected(i, True)
        Next

        'For i As Integer = 0 To l_Hours2.Items.Count - 1
        'l_Hours2.SetSelected(i, True)
        'Next

        For i As Integer = 0 To l_Minutes1.Items.Count - 1
            l_Minutes1.SetSelected(i, True)
        Next

        For i As Integer = 0 To l_Minutes2.Items.Count - 1
            l_Minutes2.SetSelected(i, True)
        Next
    End Sub

    Private Sub btn_Clear_Click(sender As System.Object, e As System.EventArgs) Handles btn_Clear.Click
        'l_Hours1.ClearSelected()
        'l_Hours2.ClearSelected()
        l_Minutes1.ClearSelected()
        l_Minutes2.ClearSelected()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Try
            If TaskBindingSource.Current Is Nothing Then Exit Sub
            Dim Task As DS_Kron.TaskRow = TaskBindingSource.Current.row
            System.Diagnostics.Process.Start(Task.Command)
        Catch ex As Exception
            MsgBox("Couldn't start task: " & ex.Message, MsgBoxStyle.Exclamation, "Unable to start task")
        End Try
    End Sub
End Class