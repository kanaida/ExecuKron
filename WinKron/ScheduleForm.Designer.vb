<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ScheduleForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ScheduleForm))
        Me.l_Minutes1 = New System.Windows.Forms.ListBox()
        Me.l_Minutes2 = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.l_daysOfMonth = New System.Windows.Forms.ListBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.l_Hours1 = New System.Windows.Forms.ListBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.l_daysOfWeek = New System.Windows.Forms.ListBox()
        Me.ScheduleDetailsGroup = New System.Windows.Forms.GroupBox()
        Me.btn_Clear = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.l_Months = New System.Windows.Forms.ListBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_Save = New System.Windows.Forms.Button()
        Me.AgendaGroup = New System.Windows.Forms.GroupBox()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuccessNotifyCheckBox = New System.Windows.Forms.CheckBox()
        Me.TaskBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_Kron = New WinKron.DS_Kron()
        Me.TasksDataGridView = New System.Windows.Forms.DataGridView()
        Me.NameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.ScheduleTasksDataGridView = New System.Windows.Forms.DataGridView()
        Me.TaskIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.BS_TaskCombo = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ScheduleTaskBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ScheduleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SchedulesDataGridView = New System.Windows.Forms.DataGridView()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ScheduleEnabled = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.NotificationEmailBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NotificationEmailDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.ScheduleDetailsGroup.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AgendaGroup.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        CType(Me.TaskBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_Kron, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TasksDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox7.SuspendLayout()
        CType(Me.ScheduleTasksDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BS_TaskCombo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ScheduleTaskBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ScheduleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SchedulesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NotificationEmailBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NotificationEmailDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'l_Minutes1
        '
        Me.l_Minutes1.Font = New System.Drawing.Font("Mistral", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_Minutes1.FormattingEnabled = True
        Me.l_Minutes1.ItemHeight = 16
        Me.l_Minutes1.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30"})
        Me.l_Minutes1.Location = New System.Drawing.Point(6, 19)
        Me.l_Minutes1.Name = "l_Minutes1"
        Me.l_Minutes1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.l_Minutes1.Size = New System.Drawing.Size(58, 484)
        Me.l_Minutes1.TabIndex = 0
        '
        'l_Minutes2
        '
        Me.l_Minutes2.Font = New System.Drawing.Font("Mistral", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_Minutes2.FormattingEnabled = True
        Me.l_Minutes2.ItemHeight = 16
        Me.l_Minutes2.Items.AddRange(New Object() {"31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "00"})
        Me.l_Minutes2.Location = New System.Drawing.Point(70, 19)
        Me.l_Minutes2.Name = "l_Minutes2"
        Me.l_Minutes2.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.l_Minutes2.Size = New System.Drawing.Size(58, 484)
        Me.l_Minutes2.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.l_Minutes1)
        Me.GroupBox1.Controls.Add(Me.l_Minutes2)
        Me.GroupBox1.Font = New System.Drawing.Font("Mistral", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Gainsboro
        Me.GroupBox1.Location = New System.Drawing.Point(301, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(134, 519)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Minutes:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.l_daysOfMonth)
        Me.GroupBox2.Font = New System.Drawing.Font("Mistral", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Gainsboro
        Me.GroupBox2.Location = New System.Drawing.Point(6, 36)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(106, 522)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Days of Month:"
        '
        'l_daysOfMonth
        '
        Me.l_daysOfMonth.Font = New System.Drawing.Font("Mistral", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_daysOfMonth.FormattingEnabled = True
        Me.l_daysOfMonth.ItemHeight = 16
        Me.l_daysOfMonth.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        Me.l_daysOfMonth.Location = New System.Drawing.Point(6, 19)
        Me.l_daysOfMonth.Name = "l_daysOfMonth"
        Me.l_daysOfMonth.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.l_daysOfMonth.Size = New System.Drawing.Size(88, 500)
        Me.l_daysOfMonth.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.l_Hours1)
        Me.GroupBox3.Font = New System.Drawing.Font("Mistral", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Gainsboro
        Me.GroupBox3.Location = New System.Drawing.Point(224, 36)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(71, 418)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Hours:"
        '
        'l_Hours1
        '
        Me.l_Hours1.Font = New System.Drawing.Font("Mistral", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_Hours1.FormattingEnabled = True
        Me.l_Hours1.ItemHeight = 16
        Me.l_Hours1.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24"})
        Me.l_Hours1.Location = New System.Drawing.Point(6, 19)
        Me.l_Hours1.Name = "l_Hours1"
        Me.l_Hours1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.l_Hours1.Size = New System.Drawing.Size(58, 388)
        Me.l_Hours1.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.l_daysOfWeek)
        Me.GroupBox4.Font = New System.Drawing.Font("Mistral", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Gainsboro
        Me.GroupBox4.Location = New System.Drawing.Point(118, 36)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(100, 184)
        Me.GroupBox4.TabIndex = 6
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Days of Week:"
        '
        'l_daysOfWeek
        '
        Me.l_daysOfWeek.Font = New System.Drawing.Font("Mistral", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_daysOfWeek.FormattingEnabled = True
        Me.l_daysOfWeek.ItemHeight = 19
        Me.l_daysOfWeek.Location = New System.Drawing.Point(6, 19)
        Me.l_daysOfWeek.Name = "l_daysOfWeek"
        Me.l_daysOfWeek.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.l_daysOfWeek.Size = New System.Drawing.Size(88, 156)
        Me.l_daysOfWeek.TabIndex = 0
        '
        'ScheduleDetailsGroup
        '
        Me.ScheduleDetailsGroup.Controls.Add(Me.btn_Clear)
        Me.ScheduleDetailsGroup.Controls.Add(Me.GroupBox5)
        Me.ScheduleDetailsGroup.Controls.Add(Me.GroupBox2)
        Me.ScheduleDetailsGroup.Controls.Add(Me.GroupBox4)
        Me.ScheduleDetailsGroup.Controls.Add(Me.GroupBox1)
        Me.ScheduleDetailsGroup.Controls.Add(Me.GroupBox3)
        Me.ScheduleDetailsGroup.Enabled = False
        Me.ScheduleDetailsGroup.Font = New System.Drawing.Font("Mistral", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ScheduleDetailsGroup.ForeColor = System.Drawing.Color.Red
        Me.ScheduleDetailsGroup.Location = New System.Drawing.Point(609, 13)
        Me.ScheduleDetailsGroup.Name = "ScheduleDetailsGroup"
        Me.ScheduleDetailsGroup.Size = New System.Drawing.Size(441, 564)
        Me.ScheduleDetailsGroup.TabIndex = 7
        Me.ScheduleDetailsGroup.TabStop = False
        Me.ScheduleDetailsGroup.Text = "Schedule Details:"
        '
        'btn_Clear
        '
        Me.btn_Clear.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Clear.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Clear.ForeColor = System.Drawing.Color.Black
        Me.btn_Clear.Location = New System.Drawing.Point(224, 460)
        Me.btn_Clear.Name = "btn_Clear"
        Me.btn_Clear.Size = New System.Drawing.Size(71, 23)
        Me.btn_Clear.TabIndex = 10
        Me.btn_Clear.Text = "Clear ->>"
        Me.btn_Clear.UseVisualStyleBackColor = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.l_Months)
        Me.GroupBox5.Font = New System.Drawing.Font("Mistral", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.Gainsboro
        Me.GroupBox5.Location = New System.Drawing.Point(118, 226)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(100, 222)
        Me.GroupBox5.TabIndex = 7
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Months:"
        '
        'l_Months
        '
        Me.l_Months.Font = New System.Drawing.Font("Mistral", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_Months.FormattingEnabled = True
        Me.l_Months.ItemHeight = 16
        Me.l_Months.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.l_Months.Location = New System.Drawing.Point(6, 19)
        Me.l_Months.Name = "l_Months"
        Me.l_Months.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.l_Months.Size = New System.Drawing.Size(88, 196)
        Me.l_Months.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WinKron.My.Resources.Resources._3_1_executioner_with_axe
        Me.PictureBox1.Location = New System.Drawing.Point(1056, 28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(191, 282)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'btn_Save
        '
        Me.btn_Save.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Save.Location = New System.Drawing.Point(1056, 316)
        Me.btn_Save.Name = "btn_Save"
        Me.btn_Save.Size = New System.Drawing.Size(191, 23)
        Me.btn_Save.TabIndex = 9
        Me.btn_Save.Text = "Save Changes"
        Me.btn_Save.UseVisualStyleBackColor = False
        '
        'AgendaGroup
        '
        Me.AgendaGroup.Controls.Add(Me.GroupBox8)
        Me.AgendaGroup.Controls.Add(Me.GroupBox7)
        Me.AgendaGroup.Font = New System.Drawing.Font("Mistral", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AgendaGroup.ForeColor = System.Drawing.Color.Red
        Me.AgendaGroup.Location = New System.Drawing.Point(12, 13)
        Me.AgendaGroup.Name = "AgendaGroup"
        Me.AgendaGroup.Size = New System.Drawing.Size(591, 564)
        Me.AgendaGroup.TabIndex = 12
        Me.AgendaGroup.TabStop = False
        Me.AgendaGroup.Text = "Executioner's Agenda:"
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.Button1)
        Me.GroupBox8.Controls.Add(Me.TasksDataGridView)
        Me.GroupBox8.Controls.Add(Me.TextBox4)
        Me.GroupBox8.Controls.Add(Me.Label4)
        Me.GroupBox8.Controls.Add(Me.TextBox5)
        Me.GroupBox8.Controls.Add(Me.Label5)
        Me.GroupBox8.Controls.Add(Me.TextBox2)
        Me.GroupBox8.Controls.Add(Me.Label2)
        Me.GroupBox8.Controls.Add(Me.TextBox1)
        Me.GroupBox8.Controls.Add(Me.Label1)
        Me.GroupBox8.Controls.Add(Me.SuccessNotifyCheckBox)
        Me.GroupBox8.Controls.Add(Me.CheckBox1)
        Me.GroupBox8.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox8.ForeColor = System.Drawing.Color.Gainsboro
        Me.GroupBox8.Location = New System.Drawing.Point(6, 268)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(579, 293)
        Me.GroupBox8.TabIndex = 5
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Things to do:"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Control
        Me.Button1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(449, 260)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(124, 23)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Run"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'SuccessNotifyCheckBox
        '
        Me.SuccessNotifyCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.TaskBindingSource, "SuccessNotify", True))
        Me.SuccessNotifyCheckBox.Location = New System.Drawing.Point(449, 182)
        Me.SuccessNotifyCheckBox.Name = "SuccessNotifyCheckBox"
        Me.SuccessNotifyCheckBox.Size = New System.Drawing.Size(124, 24)
        Me.SuccessNotifyCheckBox.TabIndex = 13
        Me.SuccessNotifyCheckBox.Text = "Success Email"
        Me.SuccessNotifyCheckBox.UseVisualStyleBackColor = True
        '
        'TaskBindingSource
        '
        Me.TaskBindingSource.DataMember = "Task"
        Me.TaskBindingSource.DataSource = Me.DS_Kron
        '
        'DS_Kron
        '
        Me.DS_Kron.DataSetName = "DS_Kron"
        Me.DS_Kron.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TasksDataGridView
        '
        Me.TasksDataGridView.AutoGenerateColumns = False
        Me.TasksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TasksDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NameDataGridViewTextBoxColumn1, Me.DataGridViewCheckBoxColumn2})
        Me.TasksDataGridView.DataSource = Me.TaskBindingSource
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.TasksDataGridView.DefaultCellStyle = DataGridViewCellStyle1
        Me.TasksDataGridView.Location = New System.Drawing.Point(6, 25)
        Me.TasksDataGridView.Name = "TasksDataGridView"
        Me.TasksDataGridView.Size = New System.Drawing.Size(567, 161)
        Me.TasksDataGridView.TabIndex = 12
        '
        'NameDataGridViewTextBoxColumn1
        '
        Me.NameDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NameDataGridViewTextBoxColumn1.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn1.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn1.Name = "NameDataGridViewTextBoxColumn1"
        '
        'DataGridViewCheckBoxColumn2
        '
        Me.DataGridViewCheckBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewCheckBoxColumn2.DataPropertyName = "Enabled"
        Me.DataGridViewCheckBoxColumn2.HeaderText = "E"
        Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
        Me.DataGridViewCheckBoxColumn2.Width = 24
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TaskBindingSource, "Password", True))
        Me.TextBox4.Location = New System.Drawing.Point(288, 257)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.PasswordChar = Global.Microsoft.VisualBasic.ChrW(35)
        Me.TextBox4.Size = New System.Drawing.Size(155, 26)
        Me.TextBox4.TabIndex = 10
        Me.TextBox4.UseSystemPasswordChar = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(239, 260)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 20)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Pass:"
        '
        'TextBox5
        '
        Me.TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TaskBindingSource, "User", True))
        Me.TextBox5.Location = New System.Drawing.Point(93, 257)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(140, 26)
        Me.TextBox5.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(46, 260)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 20)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "User:"
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TaskBindingSource, "Command", True))
        Me.TextBox2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(93, 225)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(480, 22)
        Me.TextBox2.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 228)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Command:"
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TaskBindingSource, "Name", True))
        Me.TextBox1.Location = New System.Drawing.Point(93, 192)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(350, 26)
        Me.TextBox1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 195)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Task Name:"
        '
        'CheckBox1
        '
        Me.CheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.TaskBindingSource, "FailNotify", True))
        Me.CheckBox1.Location = New System.Drawing.Point(449, 201)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(124, 24)
        Me.CheckBox1.TabIndex = 14
        Me.CheckBox1.Text = "Failure Email"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.ScheduleTasksDataGridView)
        Me.GroupBox7.Controls.Add(Me.SchedulesDataGridView)
        Me.GroupBox7.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.ForeColor = System.Drawing.Color.Gainsboro
        Me.GroupBox7.Location = New System.Drawing.Point(6, 36)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(579, 226)
        Me.GroupBox7.TabIndex = 4
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Schedules:"
        '
        'ScheduleTasksDataGridView
        '
        Me.ScheduleTasksDataGridView.AutoGenerateColumns = False
        Me.ScheduleTasksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ScheduleTasksDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TaskIdDataGridViewTextBoxColumn, Me.DataGridViewCheckBoxColumn1})
        Me.ScheduleTasksDataGridView.DataSource = Me.ScheduleTaskBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ScheduleTasksDataGridView.DefaultCellStyle = DataGridViewCellStyle2
        Me.ScheduleTasksDataGridView.Location = New System.Drawing.Point(288, 19)
        Me.ScheduleTasksDataGridView.Name = "ScheduleTasksDataGridView"
        Me.ScheduleTasksDataGridView.Size = New System.Drawing.Size(285, 201)
        Me.ScheduleTasksDataGridView.TabIndex = 1
        '
        'TaskIdDataGridViewTextBoxColumn
        '
        Me.TaskIdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TaskIdDataGridViewTextBoxColumn.DataPropertyName = "TaskId"
        Me.TaskIdDataGridViewTextBoxColumn.DataSource = Me.BS_TaskCombo
        Me.TaskIdDataGridViewTextBoxColumn.DisplayMember = "Name"
        Me.TaskIdDataGridViewTextBoxColumn.HeaderText = "Task"
        Me.TaskIdDataGridViewTextBoxColumn.Name = "TaskIdDataGridViewTextBoxColumn"
        Me.TaskIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TaskIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.TaskIdDataGridViewTextBoxColumn.ValueMember = "Id"
        '
        'BS_TaskCombo
        '
        Me.BS_TaskCombo.DataMember = "Task"
        Me.BS_TaskCombo.DataSource = Me.DS_Kron
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "Enabled"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "E"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.Width = 24
        '
        'ScheduleTaskBindingSource
        '
        Me.ScheduleTaskBindingSource.DataMember = "FK_Schedule_ScheduleTask"
        Me.ScheduleTaskBindingSource.DataSource = Me.ScheduleBindingSource
        '
        'ScheduleBindingSource
        '
        Me.ScheduleBindingSource.DataMember = "Schedule"
        Me.ScheduleBindingSource.DataSource = Me.DS_Kron
        '
        'SchedulesDataGridView
        '
        Me.SchedulesDataGridView.AutoGenerateColumns = False
        Me.SchedulesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SchedulesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NameDataGridViewTextBoxColumn, Me.ScheduleEnabled})
        Me.SchedulesDataGridView.DataSource = Me.ScheduleBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.SchedulesDataGridView.DefaultCellStyle = DataGridViewCellStyle3
        Me.SchedulesDataGridView.Location = New System.Drawing.Point(6, 19)
        Me.SchedulesDataGridView.Name = "SchedulesDataGridView"
        Me.SchedulesDataGridView.Size = New System.Drawing.Size(276, 201)
        Me.SchedulesDataGridView.TabIndex = 1
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        '
        'ScheduleEnabled
        '
        Me.ScheduleEnabled.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ScheduleEnabled.DataPropertyName = "Enabled"
        Me.ScheduleEnabled.HeaderText = "E"
        Me.ScheduleEnabled.Name = "ScheduleEnabled"
        Me.ScheduleEnabled.Width = 24
        '
        'NotificationEmailBindingSource
        '
        Me.NotificationEmailBindingSource.DataMember = "NotificationEmail"
        Me.NotificationEmailBindingSource.DataSource = Me.DS_Kron
        '
        'NotificationEmailDataGridView
        '
        Me.NotificationEmailDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.NotificationEmailDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.NotificationEmailDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.NotificationEmailDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1})
        Me.NotificationEmailDataGridView.DataSource = Me.NotificationEmailBindingSource
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.NotificationEmailDataGridView.DefaultCellStyle = DataGridViewCellStyle6
        Me.NotificationEmailDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NotificationEmailDataGridView.Location = New System.Drawing.Point(3, 33)
        Me.NotificationEmailDataGridView.Name = "NotificationEmailDataGridView"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.NotificationEmailDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.NotificationEmailDataGridView.Size = New System.Drawing.Size(185, 196)
        Me.NotificationEmailDataGridView.TabIndex = 12
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Email"
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn1.HeaderText = "Email"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.NotificationEmailDataGridView)
        Me.GroupBox6.Font = New System.Drawing.Font("Mistral", 18.0!)
        Me.GroupBox6.ForeColor = System.Drawing.Color.Red
        Me.GroupBox6.Location = New System.Drawing.Point(1056, 345)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(191, 232)
        Me.GroupBox6.TabIndex = 13
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Notifications"
        '
        'ScheduleForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1257, 588)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.AgendaGroup)
        Me.Controls.Add(Me.btn_Save)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ScheduleDetailsGroup)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ScheduleForm"
        Me.Text = "ExecuKron"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.ScheduleDetailsGroup.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AgendaGroup.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        CType(Me.TaskBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_Kron, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TasksDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox7.ResumeLayout(False)
        CType(Me.ScheduleTasksDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BS_TaskCombo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ScheduleTaskBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ScheduleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SchedulesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NotificationEmailBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NotificationEmailDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents l_Minutes1 As System.Windows.Forms.ListBox
    Friend WithEvents l_Minutes2 As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents l_daysOfMonth As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents l_Hours1 As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents l_daysOfWeek As System.Windows.Forms.ListBox
    Friend WithEvents ScheduleDetailsGroup As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btn_Save As System.Windows.Forms.Button
    Friend WithEvents AgendaGroup As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents TasksDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents SchedulesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ScheduleTasksDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents TaskBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DS_Kron As WinKron.DS_Kron
    Friend WithEvents BS_TaskCombo As System.Windows.Forms.BindingSource
    Friend WithEvents ScheduleTaskBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ScheduleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents l_Months As System.Windows.Forms.ListBox
    Friend WithEvents NameDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn2 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents TaskIdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ScheduleEnabled As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents SuccessNotifyCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents NotificationEmailBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents NotificationEmailDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Clear As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
