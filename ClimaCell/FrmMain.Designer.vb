<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TmrUpdate = New System.Timers.Timer()
        Me.TmrClock = New System.Timers.Timer()
        Me.TC = New System.Windows.Forms.TabControl()
        Me.TpForecast = New System.Windows.Forms.TabPage()
        Me.DgvDaily = New System.Windows.Forms.DataGridView()
        Me.TpLogs = New System.Windows.Forms.TabPage()
        Me.TcLogs = New System.Windows.Forms.TabControl()
        Me.TpLogLog = New System.Windows.Forms.TabPage()
        Me.RtbLog = New System.Windows.Forms.RichTextBox()
        Me.TpLogData = New System.Windows.Forms.TabPage()
        Me.RtbData = New System.Windows.Forms.RichTextBox()
        Me.TpLogError = New System.Windows.Forms.TabPage()
        Me.RtbError = New System.Windows.Forms.RichTextBox()
        Me.TpSettings = New System.Windows.Forms.TabPage()
        Me.PnlSettings = New System.Windows.Forms.Panel()
        Me.PnlAbout = New System.Windows.Forms.Panel()
        Me.LblAbout = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.ChkFetchHourly = New System.Windows.Forms.CheckBox()
        Me.ChkFetchDaily = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.NumUpdateInterval = New System.Windows.Forms.NumericUpDown()
        Me.PnlHourlyForecast = New System.Windows.Forms.Panel()
        Me.ChkAllHourly = New System.Windows.Forms.CheckBox()
        Me.GbHourlyFields = New System.Windows.Forms.GroupBox()
        Me.ChkHailRisk = New System.Windows.Forms.CheckBox()
        Me.ChkRiskScore = New System.Windows.Forms.CheckBox()
        Me.ChkRiskConfidence = New System.Windows.Forms.CheckBox()
        Me.ChkRiskCondition = New System.Windows.Forms.CheckBox()
        Me.ChkRoadRisk = New System.Windows.Forms.CheckBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ChkHourAqiPm25 = New System.Windows.Forms.CheckBox()
        Me.ChkHourAqiO3 = New System.Windows.Forms.CheckBox()
        Me.ChkHourAqiNo2 = New System.Windows.Forms.CheckBox()
        Me.ChkHourAqiCo = New System.Windows.Forms.CheckBox()
        Me.ChkHourAqiSo2 = New System.Windows.Forms.CheckBox()
        Me.ChkHourEpaAqi = New System.Windows.Forms.CheckBox()
        Me.ChkHourEpaPollutant = New System.Windows.Forms.CheckBox()
        Me.ChkHourEpaConcern = New System.Windows.Forms.CheckBox()
        Me.ChkHourChinaAqi = New System.Windows.Forms.CheckBox()
        Me.ChkHourChinaConcern = New System.Windows.Forms.CheckBox()
        Me.ChkHourChinaPollutant = New System.Windows.Forms.CheckBox()
        Me.ChkHourAqiPm10 = New System.Windows.Forms.CheckBox()
        Me.ChkHourGrass = New System.Windows.Forms.CheckBox()
        Me.ChkHourRagweed = New System.Windows.Forms.CheckBox()
        Me.ChkHourTreeAsh = New System.Windows.Forms.CheckBox()
        Me.ChkHourTreeBeech = New System.Windows.Forms.CheckBox()
        Me.ChkHourTreeBirch = New System.Windows.Forms.CheckBox()
        Me.ChkHourTreeCedar = New System.Windows.Forms.CheckBox()
        Me.ChkHourTreeCypress = New System.Windows.Forms.CheckBox()
        Me.ChkHourTreeElder = New System.Windows.Forms.CheckBox()
        Me.ChkHourTreeElm = New System.Windows.Forms.CheckBox()
        Me.ChkHourTreeHemlock = New System.Windows.Forms.CheckBox()
        Me.ChkHourTreeHickory = New System.Windows.Forms.CheckBox()
        Me.ChkHourTreeJuniper = New System.Windows.Forms.CheckBox()
        Me.ChkHourTreeMahogany = New System.Windows.Forms.CheckBox()
        Me.ChkHourTreeMaple = New System.Windows.Forms.CheckBox()
        Me.ChkHourTreeMulberry = New System.Windows.Forms.CheckBox()
        Me.ChkHourTreeOak = New System.Windows.Forms.CheckBox()
        Me.ChkHourTreePine = New System.Windows.Forms.CheckBox()
        Me.ChkHourTreeCottonwood = New System.Windows.Forms.CheckBox()
        Me.ChkHourTreeSpruce = New System.Windows.Forms.CheckBox()
        Me.ChkHourTreeSycamore = New System.Windows.Forms.CheckBox()
        Me.ChkHourTreeWalnut = New System.Windows.Forms.CheckBox()
        Me.ChkHourTreeWillow = New System.Windows.Forms.CheckBox()
        Me.ChkHourTreeAcacia = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ChkHourGrassPollen = New System.Windows.Forms.CheckBox()
        Me.ChkHourWeedPollen = New System.Windows.Forms.CheckBox()
        Me.ChkHourTreePollen = New System.Windows.Forms.CheckBox()
        Me.ChkHourSunrise = New System.Windows.Forms.CheckBox()
        Me.ChkHourCloudCover = New System.Windows.Forms.CheckBox()
        Me.ChkHourSunset = New System.Windows.Forms.CheckBox()
        Me.ChkHourCloudBase = New System.Windows.Forms.CheckBox()
        Me.ChkHourCloudCeil = New System.Windows.Forms.CheckBox()
        Me.ChkHourSSR = New System.Windows.Forms.CheckBox()
        Me.ChkHourMoonPhase = New System.Windows.Forms.CheckBox()
        Me.ChkHourWxCode = New System.Windows.Forms.CheckBox()
        Me.ChkHourVis = New System.Windows.Forms.CheckBox()
        Me.ChkHourPrecipProb = New System.Windows.Forms.CheckBox()
        Me.ChkHourFeelsLike = New System.Windows.Forms.CheckBox()
        Me.ChkHourWindSpeed = New System.Windows.Forms.CheckBox()
        Me.ChkHourDewpoint = New System.Windows.Forms.CheckBox()
        Me.ChkHourWindDir = New System.Windows.Forms.CheckBox()
        Me.ChkHourWindGust = New System.Windows.Forms.CheckBox()
        Me.ChkHourBP = New System.Windows.Forms.CheckBox()
        Me.ChkHourPrecip = New System.Windows.Forms.CheckBox()
        Me.ChkHourPrecipType = New System.Windows.Forms.CheckBox()
        Me.ChkHourRH = New System.Windows.Forms.CheckBox()
        Me.ChkHourTemp = New System.Windows.Forms.CheckBox()
        Me.PnlDailyForecast = New System.Windows.Forms.Panel()
        Me.GbDailyFields = New System.Windows.Forms.GroupBox()
        Me.ChkMoonPhase = New System.Windows.Forms.CheckBox()
        Me.ChkTemp = New System.Windows.Forms.CheckBox()
        Me.ChkWxCode = New System.Windows.Forms.CheckBox()
        Me.ChkPrecip = New System.Windows.Forms.CheckBox()
        Me.ChkVis = New System.Windows.Forms.CheckBox()
        Me.ChkBP = New System.Windows.Forms.CheckBox()
        Me.ChkPrecipProb = New System.Windows.Forms.CheckBox()
        Me.ChkWindDir = New System.Windows.Forms.CheckBox()
        Me.ChkPrecipAcc = New System.Windows.Forms.CheckBox()
        Me.ChkWindSpeed = New System.Windows.Forms.CheckBox()
        Me.ChkSunrise = New System.Windows.Forms.CheckBox()
        Me.ChkHumidity = New System.Windows.Forms.CheckBox()
        Me.ChkSunset = New System.Windows.Forms.CheckBox()
        Me.ChkDewpoint = New System.Windows.Forms.CheckBox()
        Me.ChkFeelsLike = New System.Windows.Forms.CheckBox()
        Me.ChkAllDaily = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RbUnitSI = New System.Windows.Forms.RadioButton()
        Me.RbUnitUS = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TxtApiKey = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtLocationId = New System.Windows.Forms.TextBox()
        Me.NumLongitude = New System.Windows.Forms.NumericUpDown()
        Me.NumLatiutude = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.TsslVer = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TsslNextUpdate = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TsslClock = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TsslCpy = New System.Windows.Forms.ToolStripStatusLabel()
        CType(Me.TmrUpdate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TmrClock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TC.SuspendLayout()
        Me.TpForecast.SuspendLayout()
        CType(Me.DgvDaily, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TpLogs.SuspendLayout()
        Me.TcLogs.SuspendLayout()
        Me.TpLogLog.SuspendLayout()
        Me.TpLogData.SuspendLayout()
        Me.TpLogError.SuspendLayout()
        Me.TpSettings.SuspendLayout()
        Me.PnlSettings.SuspendLayout()
        Me.PnlAbout.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.NumUpdateInterval, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlHourlyForecast.SuspendLayout()
        Me.GbHourlyFields.SuspendLayout()
        Me.PnlDailyForecast.SuspendLayout()
        Me.GbDailyFields.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NumLongitude, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumLatiutude, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TmrUpdate
        '
        Me.TmrUpdate.SynchronizingObject = Me
        '
        'TmrClock
        '
        Me.TmrClock.Interval = 999.0R
        Me.TmrClock.SynchronizingObject = Me
        '
        'TC
        '
        Me.TC.Controls.Add(Me.TpForecast)
        Me.TC.Controls.Add(Me.TpLogs)
        Me.TC.Controls.Add(Me.TpSettings)
        Me.TC.Dock = System.Windows.Forms.DockStyle.Top
        Me.TC.Location = New System.Drawing.Point(0, 0)
        Me.TC.Name = "TC"
        Me.TC.SelectedIndex = 0
        Me.TC.Size = New System.Drawing.Size(1580, 1047)
        Me.TC.TabIndex = 5
        '
        'TpForecast
        '
        Me.TpForecast.Controls.Add(Me.DgvDaily)
        Me.TpForecast.Location = New System.Drawing.Point(4, 29)
        Me.TpForecast.Name = "TpForecast"
        Me.TpForecast.Padding = New System.Windows.Forms.Padding(3)
        Me.TpForecast.Size = New System.Drawing.Size(1572, 1014)
        Me.TpForecast.TabIndex = 0
        Me.TpForecast.Text = "Forecast"
        Me.TpForecast.UseVisualStyleBackColor = True
        '
        'DgvDaily
        '
        Me.DgvDaily.AllowUserToAddRows = False
        Me.DgvDaily.AllowUserToDeleteRows = False
        Me.DgvDaily.AllowUserToResizeColumns = False
        Me.DgvDaily.AllowUserToResizeRows = False
        Me.DgvDaily.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvDaily.BackgroundColor = System.Drawing.Color.LightSkyBlue
        Me.DgvDaily.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.DgvDaily.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSkyBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DgvDaily.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvDaily.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvDaily.ColumnHeadersVisible = False
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSkyBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvDaily.DefaultCellStyle = DataGridViewCellStyle2
        Me.DgvDaily.Dock = System.Windows.Forms.DockStyle.Top
        Me.DgvDaily.Enabled = False
        Me.DgvDaily.EnableHeadersVisualStyles = False
        Me.DgvDaily.Location = New System.Drawing.Point(3, 3)
        Me.DgvDaily.Margin = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.DgvDaily.MultiSelect = False
        Me.DgvDaily.Name = "DgvDaily"
        Me.DgvDaily.ReadOnly = True
        Me.DgvDaily.RowHeadersVisible = False
        Me.DgvDaily.RowHeadersWidth = 62
        Me.DgvDaily.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DgvDaily.RowTemplate.Height = 30
        Me.DgvDaily.RowTemplate.ReadOnly = True
        Me.DgvDaily.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvDaily.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.DgvDaily.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DgvDaily.ShowEditingIcon = False
        Me.DgvDaily.Size = New System.Drawing.Size(1566, 1009)
        Me.DgvDaily.TabIndex = 5
        '
        'TpLogs
        '
        Me.TpLogs.Controls.Add(Me.TcLogs)
        Me.TpLogs.Location = New System.Drawing.Point(4, 29)
        Me.TpLogs.Name = "TpLogs"
        Me.TpLogs.Padding = New System.Windows.Forms.Padding(3)
        Me.TpLogs.Size = New System.Drawing.Size(1572, 1014)
        Me.TpLogs.TabIndex = 1
        Me.TpLogs.Text = "Logs"
        Me.TpLogs.UseVisualStyleBackColor = True
        '
        'TcLogs
        '
        Me.TcLogs.Alignment = System.Windows.Forms.TabAlignment.Right
        Me.TcLogs.Controls.Add(Me.TpLogLog)
        Me.TcLogs.Controls.Add(Me.TpLogData)
        Me.TcLogs.Controls.Add(Me.TpLogError)
        Me.TcLogs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TcLogs.Location = New System.Drawing.Point(3, 3)
        Me.TcLogs.Multiline = True
        Me.TcLogs.Name = "TcLogs"
        Me.TcLogs.SelectedIndex = 0
        Me.TcLogs.Size = New System.Drawing.Size(1566, 1008)
        Me.TcLogs.TabIndex = 0
        '
        'TpLogLog
        '
        Me.TpLogLog.Controls.Add(Me.RtbLog)
        Me.TpLogLog.Location = New System.Drawing.Point(4, 4)
        Me.TpLogLog.Name = "TpLogLog"
        Me.TpLogLog.Padding = New System.Windows.Forms.Padding(3)
        Me.TpLogLog.Size = New System.Drawing.Size(1534, 1000)
        Me.TpLogLog.TabIndex = 0
        Me.TpLogLog.Text = "Log"
        Me.TpLogLog.UseVisualStyleBackColor = True
        '
        'RtbLog
        '
        Me.RtbLog.BackColor = System.Drawing.SystemColors.Info
        Me.RtbLog.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RtbLog.Location = New System.Drawing.Point(3, 3)
        Me.RtbLog.Name = "RtbLog"
        Me.RtbLog.ReadOnly = True
        Me.RtbLog.ShowSelectionMargin = True
        Me.RtbLog.Size = New System.Drawing.Size(1528, 994)
        Me.RtbLog.TabIndex = 0
        Me.RtbLog.Text = ""
        '
        'TpLogData
        '
        Me.TpLogData.Controls.Add(Me.RtbData)
        Me.TpLogData.Location = New System.Drawing.Point(4, 4)
        Me.TpLogData.Name = "TpLogData"
        Me.TpLogData.Padding = New System.Windows.Forms.Padding(3)
        Me.TpLogData.Size = New System.Drawing.Size(1534, 1026)
        Me.TpLogData.TabIndex = 1
        Me.TpLogData.Text = "Data"
        Me.TpLogData.UseVisualStyleBackColor = True
        '
        'RtbData
        '
        Me.RtbData.BackColor = System.Drawing.SystemColors.Info
        Me.RtbData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RtbData.Location = New System.Drawing.Point(3, 3)
        Me.RtbData.Name = "RtbData"
        Me.RtbData.ReadOnly = True
        Me.RtbData.ShowSelectionMargin = True
        Me.RtbData.Size = New System.Drawing.Size(1528, 1020)
        Me.RtbData.TabIndex = 1
        Me.RtbData.Text = ""
        '
        'TpLogError
        '
        Me.TpLogError.Controls.Add(Me.RtbError)
        Me.TpLogError.Location = New System.Drawing.Point(4, 4)
        Me.TpLogError.Name = "TpLogError"
        Me.TpLogError.Size = New System.Drawing.Size(1534, 1026)
        Me.TpLogError.TabIndex = 2
        Me.TpLogError.Text = "Error"
        Me.TpLogError.UseVisualStyleBackColor = True
        '
        'RtbError
        '
        Me.RtbError.BackColor = System.Drawing.SystemColors.Info
        Me.RtbError.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RtbError.Location = New System.Drawing.Point(0, 0)
        Me.RtbError.Name = "RtbError"
        Me.RtbError.ReadOnly = True
        Me.RtbError.ShowSelectionMargin = True
        Me.RtbError.Size = New System.Drawing.Size(1534, 1026)
        Me.RtbError.TabIndex = 1
        Me.RtbError.Text = ""
        '
        'TpSettings
        '
        Me.TpSettings.Controls.Add(Me.PnlSettings)
        Me.TpSettings.Location = New System.Drawing.Point(4, 29)
        Me.TpSettings.Name = "TpSettings"
        Me.TpSettings.Size = New System.Drawing.Size(1572, 1014)
        Me.TpSettings.TabIndex = 2
        Me.TpSettings.Text = "Settings"
        Me.TpSettings.UseVisualStyleBackColor = True
        '
        'PnlSettings
        '
        Me.PnlSettings.BackColor = System.Drawing.Color.Linen
        Me.PnlSettings.BackgroundImage = Global.ClimaCell.My.Resources.Resources.powered_by_climacell_halo
        Me.PnlSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PnlSettings.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PnlSettings.Controls.Add(Me.PnlAbout)
        Me.PnlSettings.Controls.Add(Me.GroupBox4)
        Me.PnlSettings.Controls.Add(Me.PnlHourlyForecast)
        Me.PnlSettings.Controls.Add(Me.PnlDailyForecast)
        Me.PnlSettings.Controls.Add(Me.GroupBox3)
        Me.PnlSettings.Controls.Add(Me.GroupBox2)
        Me.PnlSettings.Controls.Add(Me.GroupBox1)
        Me.PnlSettings.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlSettings.Location = New System.Drawing.Point(0, 0)
        Me.PnlSettings.Name = "PnlSettings"
        Me.PnlSettings.Size = New System.Drawing.Size(1572, 1014)
        Me.PnlSettings.TabIndex = 0
        '
        'PnlAbout
        '
        Me.PnlAbout.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PnlAbout.Controls.Add(Me.LblAbout)
        Me.PnlAbout.ForeColor = System.Drawing.SystemColors.Info
        Me.PnlAbout.Location = New System.Drawing.Point(28, 872)
        Me.PnlAbout.Name = "PnlAbout"
        Me.PnlAbout.Size = New System.Drawing.Size(397, 142)
        Me.PnlAbout.TabIndex = 23
        '
        'LblAbout
        '
        Me.LblAbout.Location = New System.Drawing.Point(17, 19)
        Me.LblAbout.Name = "LblAbout"
        Me.LblAbout.Size = New System.Drawing.Size(362, 104)
        Me.LblAbout.TabIndex = 0
        Me.LblAbout.Text = "-"
        Me.LblAbout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GroupBox4.Controls.Add(Me.ChkFetchHourly)
        Me.GroupBox4.Controls.Add(Me.ChkFetchDaily)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.NumUpdateInterval)
        Me.GroupBox4.Location = New System.Drawing.Point(28, 402)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(520, 75)
        Me.GroupBox4.TabIndex = 22
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Fetch Data"
        '
        'ChkFetchHourly
        '
        Me.ChkFetchHourly.AutoSize = True
        Me.ChkFetchHourly.Location = New System.Drawing.Point(114, 25)
        Me.ChkFetchHourly.Name = "ChkFetchHourly"
        Me.ChkFetchHourly.Size = New System.Drawing.Size(80, 24)
        Me.ChkFetchHourly.TabIndex = 1
        Me.ChkFetchHourly.Tag = "1"
        Me.ChkFetchHourly.Text = "Hourly"
        Me.ChkFetchHourly.UseVisualStyleBackColor = True
        '
        'ChkFetchDaily
        '
        Me.ChkFetchDaily.AutoSize = True
        Me.ChkFetchDaily.Location = New System.Drawing.Point(21, 25)
        Me.ChkFetchDaily.Name = "ChkFetchDaily"
        Me.ChkFetchDaily.Size = New System.Drawing.Size(69, 24)
        Me.ChkFetchDaily.TabIndex = 0
        Me.ChkFetchDaily.Tag = "0"
        Me.ChkFetchDaily.Text = "Daily"
        Me.ChkFetchDaily.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(205, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(188, 20)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Update Interval (minutes)"
        '
        'NumUpdateInterval
        '
        Me.NumUpdateInterval.Location = New System.Drawing.Point(401, 24)
        Me.NumUpdateInterval.Maximum = New Decimal(New Integer() {240, 0, 0, 0})
        Me.NumUpdateInterval.Name = "NumUpdateInterval"
        Me.NumUpdateInterval.Size = New System.Drawing.Size(88, 26)
        Me.NumUpdateInterval.TabIndex = 3
        Me.NumUpdateInterval.Tag = "2"
        '
        'PnlHourlyForecast
        '
        Me.PnlHourlyForecast.BackColor = System.Drawing.Color.Silver
        Me.PnlHourlyForecast.Controls.Add(Me.ChkAllHourly)
        Me.PnlHourlyForecast.Controls.Add(Me.GbHourlyFields)
        Me.PnlHourlyForecast.Location = New System.Drawing.Point(684, 113)
        Me.PnlHourlyForecast.Name = "PnlHourlyForecast"
        Me.PnlHourlyForecast.Size = New System.Drawing.Size(715, 838)
        Me.PnlHourlyForecast.TabIndex = 21
        '
        'ChkAllHourly
        '
        Me.ChkAllHourly.AutoSize = True
        Me.ChkAllHourly.Location = New System.Drawing.Point(200, 801)
        Me.ChkAllHourly.Name = "ChkAllHourly"
        Me.ChkAllHourly.Size = New System.Drawing.Size(330, 24)
        Me.ChkAllHourly.TabIndex = 19
        Me.ChkAllHourly.Text = "Check/Uncheck All Hourly Forecast Fields"
        Me.ChkAllHourly.UseVisualStyleBackColor = True
        '
        'GbHourlyFields
        '
        Me.GbHourlyFields.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GbHourlyFields.Controls.Add(Me.ChkHailRisk)
        Me.GbHourlyFields.Controls.Add(Me.ChkRiskScore)
        Me.GbHourlyFields.Controls.Add(Me.ChkRiskConfidence)
        Me.GbHourlyFields.Controls.Add(Me.ChkRiskCondition)
        Me.GbHourlyFields.Controls.Add(Me.ChkRoadRisk)
        Me.GbHourlyFields.Controls.Add(Me.Label10)
        Me.GbHourlyFields.Controls.Add(Me.ChkHourAqiPm25)
        Me.GbHourlyFields.Controls.Add(Me.ChkHourAqiO3)
        Me.GbHourlyFields.Controls.Add(Me.ChkHourAqiNo2)
        Me.GbHourlyFields.Controls.Add(Me.ChkHourAqiCo)
        Me.GbHourlyFields.Controls.Add(Me.ChkHourAqiSo2)
        Me.GbHourlyFields.Controls.Add(Me.ChkHourEpaAqi)
        Me.GbHourlyFields.Controls.Add(Me.ChkHourEpaPollutant)
        Me.GbHourlyFields.Controls.Add(Me.ChkHourEpaConcern)
        Me.GbHourlyFields.Controls.Add(Me.ChkHourChinaAqi)
        Me.GbHourlyFields.Controls.Add(Me.ChkHourChinaConcern)
        Me.GbHourlyFields.Controls.Add(Me.ChkHourChinaPollutant)
        Me.GbHourlyFields.Controls.Add(Me.ChkHourAqiPm10)
        Me.GbHourlyFields.Controls.Add(Me.ChkHourGrass)
        Me.GbHourlyFields.Controls.Add(Me.ChkHourRagweed)
        Me.GbHourlyFields.Controls.Add(Me.ChkHourTreeAsh)
        Me.GbHourlyFields.Controls.Add(Me.ChkHourTreeBeech)
        Me.GbHourlyFields.Controls.Add(Me.ChkHourTreeBirch)
        Me.GbHourlyFields.Controls.Add(Me.ChkHourTreeCedar)
        Me.GbHourlyFields.Controls.Add(Me.ChkHourTreeCypress)
        Me.GbHourlyFields.Controls.Add(Me.ChkHourTreeElder)
        Me.GbHourlyFields.Controls.Add(Me.ChkHourTreeElm)
        Me.GbHourlyFields.Controls.Add(Me.ChkHourTreeHemlock)
        Me.GbHourlyFields.Controls.Add(Me.ChkHourTreeHickory)
        Me.GbHourlyFields.Controls.Add(Me.ChkHourTreeJuniper)
        Me.GbHourlyFields.Controls.Add(Me.ChkHourTreeMahogany)
        Me.GbHourlyFields.Controls.Add(Me.ChkHourTreeMaple)
        Me.GbHourlyFields.Controls.Add(Me.ChkHourTreeMulberry)
        Me.GbHourlyFields.Controls.Add(Me.ChkHourTreeOak)
        Me.GbHourlyFields.Controls.Add(Me.ChkHourTreePine)
        Me.GbHourlyFields.Controls.Add(Me.ChkHourTreeCottonwood)
        Me.GbHourlyFields.Controls.Add(Me.ChkHourTreeSpruce)
        Me.GbHourlyFields.Controls.Add(Me.ChkHourTreeSycamore)
        Me.GbHourlyFields.Controls.Add(Me.ChkHourTreeWalnut)
        Me.GbHourlyFields.Controls.Add(Me.ChkHourTreeWillow)
        Me.GbHourlyFields.Controls.Add(Me.ChkHourTreeAcacia)
        Me.GbHourlyFields.Controls.Add(Me.Label7)
        Me.GbHourlyFields.Controls.Add(Me.Label6)
        Me.GbHourlyFields.Controls.Add(Me.ChkHourGrassPollen)
        Me.GbHourlyFields.Controls.Add(Me.ChkHourWeedPollen)
        Me.GbHourlyFields.Controls.Add(Me.ChkHourTreePollen)
        Me.GbHourlyFields.Controls.Add(Me.ChkHourSunrise)
        Me.GbHourlyFields.Controls.Add(Me.ChkHourCloudCover)
        Me.GbHourlyFields.Controls.Add(Me.ChkHourSunset)
        Me.GbHourlyFields.Controls.Add(Me.ChkHourCloudBase)
        Me.GbHourlyFields.Controls.Add(Me.ChkHourCloudCeil)
        Me.GbHourlyFields.Controls.Add(Me.ChkHourSSR)
        Me.GbHourlyFields.Controls.Add(Me.ChkHourMoonPhase)
        Me.GbHourlyFields.Controls.Add(Me.ChkHourWxCode)
        Me.GbHourlyFields.Controls.Add(Me.ChkHourVis)
        Me.GbHourlyFields.Controls.Add(Me.ChkHourPrecipProb)
        Me.GbHourlyFields.Controls.Add(Me.ChkHourFeelsLike)
        Me.GbHourlyFields.Controls.Add(Me.ChkHourWindSpeed)
        Me.GbHourlyFields.Controls.Add(Me.ChkHourDewpoint)
        Me.GbHourlyFields.Controls.Add(Me.ChkHourWindDir)
        Me.GbHourlyFields.Controls.Add(Me.ChkHourWindGust)
        Me.GbHourlyFields.Controls.Add(Me.ChkHourBP)
        Me.GbHourlyFields.Controls.Add(Me.ChkHourPrecip)
        Me.GbHourlyFields.Controls.Add(Me.ChkHourPrecipType)
        Me.GbHourlyFields.Controls.Add(Me.ChkHourRH)
        Me.GbHourlyFields.Controls.Add(Me.ChkHourTemp)
        Me.GbHourlyFields.Location = New System.Drawing.Point(17, 13)
        Me.GbHourlyFields.Name = "GbHourlyFields"
        Me.GbHourlyFields.Size = New System.Drawing.Size(680, 770)
        Me.GbHourlyFields.TabIndex = 0
        Me.GbHourlyFields.TabStop = False
        Me.GbHourlyFields.Text = "Hourly Forecast Fields"
        '
        'ChkHailRisk
        '
        Me.ChkHailRisk.AutoSize = True
        Me.ChkHailRisk.Location = New System.Drawing.Point(429, 253)
        Me.ChkHailRisk.Name = "ChkHailRisk"
        Me.ChkHailRisk.Size = New System.Drawing.Size(97, 24)
        Me.ChkHailRisk.TabIndex = 70
        Me.ChkHailRisk.Tag = "62"
        Me.ChkHailRisk.Text = "Hail Risk"
        Me.ChkHailRisk.UseVisualStyleBackColor = True
        '
        'ChkRiskScore
        '
        Me.ChkRiskScore.AutoSize = True
        Me.ChkRiskScore.Location = New System.Drawing.Point(183, 727)
        Me.ChkRiskScore.Name = "ChkRiskScore"
        Me.ChkRiskScore.Size = New System.Drawing.Size(112, 24)
        Me.ChkRiskScore.TabIndex = 69
        Me.ChkRiskScore.Tag = "59"
        Me.ChkRiskScore.Text = "Risk Score"
        Me.ChkRiskScore.UseVisualStyleBackColor = True
        '
        'ChkRiskConfidence
        '
        Me.ChkRiskConfidence.AutoSize = True
        Me.ChkRiskConfidence.Location = New System.Drawing.Point(319, 727)
        Me.ChkRiskConfidence.Name = "ChkRiskConfidence"
        Me.ChkRiskConfidence.Size = New System.Drawing.Size(151, 24)
        Me.ChkRiskConfidence.TabIndex = 68
        Me.ChkRiskConfidence.Tag = "60"
        Me.ChkRiskConfidence.Text = "Risk Confidence"
        Me.ChkRiskConfidence.UseVisualStyleBackColor = True
        '
        'ChkRiskCondition
        '
        Me.ChkRiskCondition.AutoSize = True
        Me.ChkRiskCondition.Location = New System.Drawing.Point(494, 727)
        Me.ChkRiskCondition.Name = "ChkRiskCondition"
        Me.ChkRiskCondition.Size = New System.Drawing.Size(137, 24)
        Me.ChkRiskCondition.TabIndex = 67
        Me.ChkRiskCondition.Tag = "61"
        Me.ChkRiskCondition.Text = "Risk Condition"
        Me.ChkRiskCondition.UseVisualStyleBackColor = True
        '
        'ChkRoadRisk
        '
        Me.ChkRoadRisk.AutoSize = True
        Me.ChkRoadRisk.Location = New System.Drawing.Point(50, 727)
        Me.ChkRoadRisk.Name = "ChkRoadRisk"
        Me.ChkRoadRisk.Size = New System.Drawing.Size(109, 24)
        Me.ChkRoadRisk.TabIndex = 66
        Me.ChkRoadRisk.Tag = "58"
        Me.ChkRoadRisk.Text = "Road Risk"
        Me.ChkRoadRisk.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(65, 705)
        Me.Label10.MaximumSize = New System.Drawing.Size(550, 3)
        Me.Label10.MinimumSize = New System.Drawing.Size(550, 3)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(550, 3)
        Me.Label10.TabIndex = 65
        Me.Label10.Text = "Label10"
        '
        'ChkHourAqiPm25
        '
        Me.ChkHourAqiPm25.AutoSize = True
        Me.ChkHourAqiPm25.Location = New System.Drawing.Point(170, 594)
        Me.ChkHourAqiPm25.Name = "ChkHourAqiPm25"
        Me.ChkHourAqiPm25.Size = New System.Drawing.Size(76, 24)
        Me.ChkHourAqiPm25.TabIndex = 64
        Me.ChkHourAqiPm25.Tag = "47"
        Me.ChkHourAqiPm25.Text = "PM25"
        Me.ChkHourAqiPm25.UseVisualStyleBackColor = True
        '
        'ChkHourAqiO3
        '
        Me.ChkHourAqiO3.AutoSize = True
        Me.ChkHourAqiO3.Location = New System.Drawing.Point(277, 594)
        Me.ChkHourAqiO3.Name = "ChkHourAqiO3"
        Me.ChkHourAqiO3.Size = New System.Drawing.Size(56, 24)
        Me.ChkHourAqiO3.TabIndex = 63
        Me.ChkHourAqiO3.Tag = "48"
        Me.ChkHourAqiO3.Text = "O3"
        Me.ChkHourAqiO3.UseVisualStyleBackColor = True
        '
        'ChkHourAqiNo2
        '
        Me.ChkHourAqiNo2.AutoSize = True
        Me.ChkHourAqiNo2.Location = New System.Drawing.Point(551, 594)
        Me.ChkHourAqiNo2.Name = "ChkHourAqiNo2"
        Me.ChkHourAqiNo2.Size = New System.Drawing.Size(67, 24)
        Me.ChkHourAqiNo2.TabIndex = 62
        Me.ChkHourAqiNo2.Tag = "51"
        Me.ChkHourAqiNo2.Text = "NO2"
        Me.ChkHourAqiNo2.UseVisualStyleBackColor = True
        '
        'ChkHourAqiCo
        '
        Me.ChkHourAqiCo.AutoSize = True
        Me.ChkHourAqiCo.Location = New System.Drawing.Point(364, 594)
        Me.ChkHourAqiCo.Name = "ChkHourAqiCo"
        Me.ChkHourAqiCo.Size = New System.Drawing.Size(58, 24)
        Me.ChkHourAqiCo.TabIndex = 61
        Me.ChkHourAqiCo.Tag = "49"
        Me.ChkHourAqiCo.Text = "CO"
        Me.ChkHourAqiCo.UseVisualStyleBackColor = True
        '
        'ChkHourAqiSo2
        '
        Me.ChkHourAqiSo2.AutoSize = True
        Me.ChkHourAqiSo2.Location = New System.Drawing.Point(453, 594)
        Me.ChkHourAqiSo2.Name = "ChkHourAqiSo2"
        Me.ChkHourAqiSo2.Size = New System.Drawing.Size(67, 24)
        Me.ChkHourAqiSo2.TabIndex = 60
        Me.ChkHourAqiSo2.Tag = "50"
        Me.ChkHourAqiSo2.Text = "SO2"
        Me.ChkHourAqiSo2.UseVisualStyleBackColor = True
        '
        'ChkHourEpaAqi
        '
        Me.ChkHourEpaAqi.AutoSize = True
        Me.ChkHourEpaAqi.Location = New System.Drawing.Point(31, 629)
        Me.ChkHourEpaAqi.Name = "ChkHourEpaAqi"
        Me.ChkHourEpaAqi.Size = New System.Drawing.Size(99, 24)
        Me.ChkHourEpaAqi.TabIndex = 59
        Me.ChkHourEpaAqi.Tag = "52"
        Me.ChkHourEpaAqi.Text = "EPA AQI"
        Me.ChkHourEpaAqi.UseVisualStyleBackColor = True
        '
        'ChkHourEpaPollutant
        '
        Me.ChkHourEpaPollutant.AutoSize = True
        Me.ChkHourEpaPollutant.Location = New System.Drawing.Point(452, 629)
        Me.ChkHourEpaPollutant.Name = "ChkHourEpaPollutant"
        Me.ChkHourEpaPollutant.Size = New System.Drawing.Size(189, 24)
        Me.ChkHourEpaPollutant.TabIndex = 58
        Me.ChkHourEpaPollutant.Tag = "54"
        Me.ChkHourEpaPollutant.Text = "EPA Primary Pollutant"
        Me.ChkHourEpaPollutant.UseVisualStyleBackColor = True
        '
        'ChkHourEpaConcern
        '
        Me.ChkHourEpaConcern.AutoSize = True
        Me.ChkHourEpaConcern.Location = New System.Drawing.Point(187, 629)
        Me.ChkHourEpaConcern.Name = "ChkHourEpaConcern"
        Me.ChkHourEpaConcern.Size = New System.Drawing.Size(182, 24)
        Me.ChkHourEpaConcern.TabIndex = 57
        Me.ChkHourEpaConcern.Tag = "53"
        Me.ChkHourEpaConcern.Text = "EPA Health Concern"
        Me.ChkHourEpaConcern.UseVisualStyleBackColor = True
        '
        'ChkHourChinaAqi
        '
        Me.ChkHourChinaAqi.AutoSize = True
        Me.ChkHourChinaAqi.Location = New System.Drawing.Point(31, 665)
        Me.ChkHourChinaAqi.Name = "ChkHourChinaAqi"
        Me.ChkHourChinaAqi.Size = New System.Drawing.Size(108, 24)
        Me.ChkHourChinaAqi.TabIndex = 56
        Me.ChkHourChinaAqi.Tag = "55"
        Me.ChkHourChinaAqi.Text = "China AQI"
        Me.ChkHourChinaAqi.UseVisualStyleBackColor = True
        '
        'ChkHourChinaConcern
        '
        Me.ChkHourChinaConcern.AutoSize = True
        Me.ChkHourChinaConcern.Location = New System.Drawing.Point(187, 665)
        Me.ChkHourChinaConcern.Name = "ChkHourChinaConcern"
        Me.ChkHourChinaConcern.Size = New System.Drawing.Size(191, 24)
        Me.ChkHourChinaConcern.TabIndex = 55
        Me.ChkHourChinaConcern.Tag = "56"
        Me.ChkHourChinaConcern.Text = "China Health Concern"
        Me.ChkHourChinaConcern.UseVisualStyleBackColor = True
        '
        'ChkHourChinaPollutant
        '
        Me.ChkHourChinaPollutant.AutoSize = True
        Me.ChkHourChinaPollutant.Location = New System.Drawing.Point(452, 665)
        Me.ChkHourChinaPollutant.Name = "ChkHourChinaPollutant"
        Me.ChkHourChinaPollutant.Size = New System.Drawing.Size(198, 24)
        Me.ChkHourChinaPollutant.TabIndex = 54
        Me.ChkHourChinaPollutant.Tag = "57"
        Me.ChkHourChinaPollutant.Text = "China Primary Pollutant"
        Me.ChkHourChinaPollutant.UseVisualStyleBackColor = True
        '
        'ChkHourAqiPm10
        '
        Me.ChkHourAqiPm10.AutoSize = True
        Me.ChkHourAqiPm10.Location = New System.Drawing.Point(63, 594)
        Me.ChkHourAqiPm10.Name = "ChkHourAqiPm10"
        Me.ChkHourAqiPm10.Size = New System.Drawing.Size(76, 24)
        Me.ChkHourAqiPm10.TabIndex = 52
        Me.ChkHourAqiPm10.Tag = "46"
        Me.ChkHourAqiPm10.Text = "PM10"
        Me.ChkHourAqiPm10.UseVisualStyleBackColor = True
        '
        'ChkHourGrass
        '
        Me.ChkHourGrass.AutoSize = True
        Me.ChkHourGrass.Location = New System.Drawing.Point(406, 531)
        Me.ChkHourGrass.Name = "ChkHourGrass"
        Me.ChkHourGrass.Size = New System.Drawing.Size(78, 24)
        Me.ChkHourGrass.TabIndex = 49
        Me.ChkHourGrass.Tag = "45"
        Me.ChkHourGrass.Text = "Grass"
        Me.ChkHourGrass.UseVisualStyleBackColor = True
        '
        'ChkHourRagweed
        '
        Me.ChkHourRagweed.AutoSize = True
        Me.ChkHourRagweed.Location = New System.Drawing.Point(234, 531)
        Me.ChkHourRagweed.Name = "ChkHourRagweed"
        Me.ChkHourRagweed.Size = New System.Drawing.Size(103, 24)
        Me.ChkHourRagweed.TabIndex = 48
        Me.ChkHourRagweed.Tag = "44"
        Me.ChkHourRagweed.Text = "Ragweed"
        Me.ChkHourRagweed.UseVisualStyleBackColor = True
        '
        'ChkHourTreeAsh
        '
        Me.ChkHourTreeAsh.AutoSize = True
        Me.ChkHourTreeAsh.Location = New System.Drawing.Point(234, 356)
        Me.ChkHourTreeAsh.Name = "ChkHourTreeAsh"
        Me.ChkHourTreeAsh.Size = New System.Drawing.Size(67, 24)
        Me.ChkHourTreeAsh.TabIndex = 47
        Me.ChkHourTreeAsh.Tag = "24"
        Me.ChkHourTreeAsh.Text = "Ash "
        Me.ChkHourTreeAsh.UseVisualStyleBackColor = True
        '
        'ChkHourTreeBeech
        '
        Me.ChkHourTreeBeech.AutoSize = True
        Me.ChkHourTreeBeech.Location = New System.Drawing.Point(406, 356)
        Me.ChkHourTreeBeech.Name = "ChkHourTreeBeech"
        Me.ChkHourTreeBeech.Size = New System.Drawing.Size(81, 24)
        Me.ChkHourTreeBeech.TabIndex = 46
        Me.ChkHourTreeBeech.Tag = "25"
        Me.ChkHourTreeBeech.Text = "Beech"
        Me.ChkHourTreeBeech.UseVisualStyleBackColor = True
        '
        'ChkHourTreeBirch
        '
        Me.ChkHourTreeBirch.AutoSize = True
        Me.ChkHourTreeBirch.Location = New System.Drawing.Point(72, 391)
        Me.ChkHourTreeBirch.Name = "ChkHourTreeBirch"
        Me.ChkHourTreeBirch.Size = New System.Drawing.Size(71, 24)
        Me.ChkHourTreeBirch.TabIndex = 45
        Me.ChkHourTreeBirch.Tag = "26"
        Me.ChkHourTreeBirch.Text = "Birch"
        Me.ChkHourTreeBirch.UseVisualStyleBackColor = True
        '
        'ChkHourTreeCedar
        '
        Me.ChkHourTreeCedar.AutoSize = True
        Me.ChkHourTreeCedar.Location = New System.Drawing.Point(234, 391)
        Me.ChkHourTreeCedar.Name = "ChkHourTreeCedar"
        Me.ChkHourTreeCedar.Size = New System.Drawing.Size(78, 24)
        Me.ChkHourTreeCedar.TabIndex = 44
        Me.ChkHourTreeCedar.Tag = "27"
        Me.ChkHourTreeCedar.Text = "Cedar"
        Me.ChkHourTreeCedar.UseVisualStyleBackColor = True
        '
        'ChkHourTreeCypress
        '
        Me.ChkHourTreeCypress.AutoSize = True
        Me.ChkHourTreeCypress.Location = New System.Drawing.Point(406, 391)
        Me.ChkHourTreeCypress.Name = "ChkHourTreeCypress"
        Me.ChkHourTreeCypress.Size = New System.Drawing.Size(92, 24)
        Me.ChkHourTreeCypress.TabIndex = 43
        Me.ChkHourTreeCypress.Tag = "28"
        Me.ChkHourTreeCypress.Text = "Cypress"
        Me.ChkHourTreeCypress.UseVisualStyleBackColor = True
        '
        'ChkHourTreeElder
        '
        Me.ChkHourTreeElder.AutoSize = True
        Me.ChkHourTreeElder.Location = New System.Drawing.Point(72, 426)
        Me.ChkHourTreeElder.Name = "ChkHourTreeElder"
        Me.ChkHourTreeElder.Size = New System.Drawing.Size(72, 24)
        Me.ChkHourTreeElder.TabIndex = 42
        Me.ChkHourTreeElder.Tag = "29"
        Me.ChkHourTreeElder.Text = "Elder"
        Me.ChkHourTreeElder.UseVisualStyleBackColor = True
        '
        'ChkHourTreeElm
        '
        Me.ChkHourTreeElm.AutoSize = True
        Me.ChkHourTreeElm.Location = New System.Drawing.Point(234, 426)
        Me.ChkHourTreeElm.Name = "ChkHourTreeElm"
        Me.ChkHourTreeElm.Size = New System.Drawing.Size(62, 24)
        Me.ChkHourTreeElm.TabIndex = 41
        Me.ChkHourTreeElm.Tag = "30"
        Me.ChkHourTreeElm.Text = "Elm"
        Me.ChkHourTreeElm.UseVisualStyleBackColor = True
        '
        'ChkHourTreeHemlock
        '
        Me.ChkHourTreeHemlock.AutoSize = True
        Me.ChkHourTreeHemlock.Location = New System.Drawing.Point(406, 426)
        Me.ChkHourTreeHemlock.Name = "ChkHourTreeHemlock"
        Me.ChkHourTreeHemlock.Size = New System.Drawing.Size(97, 24)
        Me.ChkHourTreeHemlock.TabIndex = 40
        Me.ChkHourTreeHemlock.Tag = "31"
        Me.ChkHourTreeHemlock.Text = "Hemlock"
        Me.ChkHourTreeHemlock.UseVisualStyleBackColor = True
        '
        'ChkHourTreeHickory
        '
        Me.ChkHourTreeHickory.AutoSize = True
        Me.ChkHourTreeHickory.Location = New System.Drawing.Point(72, 461)
        Me.ChkHourTreeHickory.Name = "ChkHourTreeHickory"
        Me.ChkHourTreeHickory.Size = New System.Drawing.Size(87, 24)
        Me.ChkHourTreeHickory.TabIndex = 39
        Me.ChkHourTreeHickory.Tag = "32"
        Me.ChkHourTreeHickory.Text = "Hickory"
        Me.ChkHourTreeHickory.UseVisualStyleBackColor = True
        '
        'ChkHourTreeJuniper
        '
        Me.ChkHourTreeJuniper.AutoSize = True
        Me.ChkHourTreeJuniper.Location = New System.Drawing.Point(234, 461)
        Me.ChkHourTreeJuniper.Name = "ChkHourTreeJuniper"
        Me.ChkHourTreeJuniper.Size = New System.Drawing.Size(87, 24)
        Me.ChkHourTreeJuniper.TabIndex = 38
        Me.ChkHourTreeJuniper.Tag = "33"
        Me.ChkHourTreeJuniper.Text = "Juniper"
        Me.ChkHourTreeJuniper.UseVisualStyleBackColor = True
        '
        'ChkHourTreeMahogany
        '
        Me.ChkHourTreeMahogany.AutoSize = True
        Me.ChkHourTreeMahogany.Location = New System.Drawing.Point(406, 461)
        Me.ChkHourTreeMahogany.Name = "ChkHourTreeMahogany"
        Me.ChkHourTreeMahogany.Size = New System.Drawing.Size(109, 24)
        Me.ChkHourTreeMahogany.TabIndex = 37
        Me.ChkHourTreeMahogany.Tag = "34"
        Me.ChkHourTreeMahogany.Text = "Mahogany"
        Me.ChkHourTreeMahogany.UseVisualStyleBackColor = True
        '
        'ChkHourTreeMaple
        '
        Me.ChkHourTreeMaple.AutoSize = True
        Me.ChkHourTreeMaple.Location = New System.Drawing.Point(72, 496)
        Me.ChkHourTreeMaple.Name = "ChkHourTreeMaple"
        Me.ChkHourTreeMaple.Size = New System.Drawing.Size(78, 24)
        Me.ChkHourTreeMaple.TabIndex = 36
        Me.ChkHourTreeMaple.Tag = "35"
        Me.ChkHourTreeMaple.Text = "Maple"
        Me.ChkHourTreeMaple.UseVisualStyleBackColor = True
        '
        'ChkHourTreeMulberry
        '
        Me.ChkHourTreeMulberry.AutoSize = True
        Me.ChkHourTreeMulberry.Location = New System.Drawing.Point(234, 496)
        Me.ChkHourTreeMulberry.Name = "ChkHourTreeMulberry"
        Me.ChkHourTreeMulberry.Size = New System.Drawing.Size(95, 24)
        Me.ChkHourTreeMulberry.TabIndex = 35
        Me.ChkHourTreeMulberry.Tag = "36"
        Me.ChkHourTreeMulberry.Text = "Mulberry"
        Me.ChkHourTreeMulberry.UseVisualStyleBackColor = True
        '
        'ChkHourTreeOak
        '
        Me.ChkHourTreeOak.AutoSize = True
        Me.ChkHourTreeOak.Location = New System.Drawing.Point(406, 496)
        Me.ChkHourTreeOak.Name = "ChkHourTreeOak"
        Me.ChkHourTreeOak.Size = New System.Drawing.Size(64, 24)
        Me.ChkHourTreeOak.TabIndex = 34
        Me.ChkHourTreeOak.Tag = "37"
        Me.ChkHourTreeOak.Text = "Oak"
        Me.ChkHourTreeOak.UseVisualStyleBackColor = True
        '
        'ChkHourTreePine
        '
        Me.ChkHourTreePine.AutoSize = True
        Me.ChkHourTreePine.Location = New System.Drawing.Point(542, 356)
        Me.ChkHourTreePine.Name = "ChkHourTreePine"
        Me.ChkHourTreePine.Size = New System.Drawing.Size(66, 24)
        Me.ChkHourTreePine.TabIndex = 33
        Me.ChkHourTreePine.Tag = "38"
        Me.ChkHourTreePine.Text = "Pine"
        Me.ChkHourTreePine.UseVisualStyleBackColor = True
        '
        'ChkHourTreeCottonwood
        '
        Me.ChkHourTreeCottonwood.AutoSize = True
        Me.ChkHourTreeCottonwood.Location = New System.Drawing.Point(542, 391)
        Me.ChkHourTreeCottonwood.Name = "ChkHourTreeCottonwood"
        Me.ChkHourTreeCottonwood.Size = New System.Drawing.Size(121, 24)
        Me.ChkHourTreeCottonwood.TabIndex = 32
        Me.ChkHourTreeCottonwood.Tag = "39"
        Me.ChkHourTreeCottonwood.Text = "Cottonwood"
        Me.ChkHourTreeCottonwood.UseVisualStyleBackColor = True
        '
        'ChkHourTreeSpruce
        '
        Me.ChkHourTreeSpruce.AutoSize = True
        Me.ChkHourTreeSpruce.Location = New System.Drawing.Point(542, 426)
        Me.ChkHourTreeSpruce.Name = "ChkHourTreeSpruce"
        Me.ChkHourTreeSpruce.Size = New System.Drawing.Size(86, 24)
        Me.ChkHourTreeSpruce.TabIndex = 31
        Me.ChkHourTreeSpruce.Tag = "40"
        Me.ChkHourTreeSpruce.Text = "Spruce"
        Me.ChkHourTreeSpruce.UseVisualStyleBackColor = True
        '
        'ChkHourTreeSycamore
        '
        Me.ChkHourTreeSycamore.AutoSize = True
        Me.ChkHourTreeSycamore.Location = New System.Drawing.Point(542, 461)
        Me.ChkHourTreeSycamore.Name = "ChkHourTreeSycamore"
        Me.ChkHourTreeSycamore.Size = New System.Drawing.Size(106, 24)
        Me.ChkHourTreeSycamore.TabIndex = 30
        Me.ChkHourTreeSycamore.Tag = "41"
        Me.ChkHourTreeSycamore.Text = "Sycamore"
        Me.ChkHourTreeSycamore.UseVisualStyleBackColor = True
        '
        'ChkHourTreeWalnut
        '
        Me.ChkHourTreeWalnut.AutoSize = True
        Me.ChkHourTreeWalnut.Location = New System.Drawing.Point(542, 496)
        Me.ChkHourTreeWalnut.Name = "ChkHourTreeWalnut"
        Me.ChkHourTreeWalnut.Size = New System.Drawing.Size(85, 24)
        Me.ChkHourTreeWalnut.TabIndex = 29
        Me.ChkHourTreeWalnut.Tag = "42"
        Me.ChkHourTreeWalnut.Text = "Walnut"
        Me.ChkHourTreeWalnut.UseVisualStyleBackColor = True
        '
        'ChkHourTreeWillow
        '
        Me.ChkHourTreeWillow.AutoSize = True
        Me.ChkHourTreeWillow.Location = New System.Drawing.Point(72, 531)
        Me.ChkHourTreeWillow.Name = "ChkHourTreeWillow"
        Me.ChkHourTreeWillow.Size = New System.Drawing.Size(79, 24)
        Me.ChkHourTreeWillow.TabIndex = 28
        Me.ChkHourTreeWillow.Tag = "43"
        Me.ChkHourTreeWillow.Text = "Willow"
        Me.ChkHourTreeWillow.UseVisualStyleBackColor = True
        '
        'ChkHourTreeAcacia
        '
        Me.ChkHourTreeAcacia.AutoSize = True
        Me.ChkHourTreeAcacia.Location = New System.Drawing.Point(72, 356)
        Me.ChkHourTreeAcacia.Name = "ChkHourTreeAcacia"
        Me.ChkHourTreeAcacia.Size = New System.Drawing.Size(83, 24)
        Me.ChkHourTreeAcacia.TabIndex = 26
        Me.ChkHourTreeAcacia.Tag = "23"
        Me.ChkHourTreeAcacia.Text = "Acacia"
        Me.ChkHourTreeAcacia.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(65, 570)
        Me.Label7.MaximumSize = New System.Drawing.Size(550, 3)
        Me.Label7.MinimumSize = New System.Drawing.Size(550, 3)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(550, 3)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Label7"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(65, 296)
        Me.Label6.MaximumSize = New System.Drawing.Size(550, 3)
        Me.Label6.MinimumSize = New System.Drawing.Size(550, 3)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(550, 3)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Label6"
        '
        'ChkHourGrassPollen
        '
        Me.ChkHourGrassPollen.AutoSize = True
        Me.ChkHourGrassPollen.Location = New System.Drawing.Point(461, 323)
        Me.ChkHourGrassPollen.Name = "ChkHourGrassPollen"
        Me.ChkHourGrassPollen.Size = New System.Drawing.Size(125, 24)
        Me.ChkHourGrassPollen.TabIndex = 23
        Me.ChkHourGrassPollen.Tag = "22"
        Me.ChkHourGrassPollen.Text = "Grass Pollen"
        Me.ChkHourGrassPollen.UseVisualStyleBackColor = True
        '
        'ChkHourWeedPollen
        '
        Me.ChkHourWeedPollen.AutoSize = True
        Me.ChkHourWeedPollen.Location = New System.Drawing.Point(273, 323)
        Me.ChkHourWeedPollen.Name = "ChkHourWeedPollen"
        Me.ChkHourWeedPollen.Size = New System.Drawing.Size(124, 24)
        Me.ChkHourWeedPollen.TabIndex = 22
        Me.ChkHourWeedPollen.Tag = "21"
        Me.ChkHourWeedPollen.Text = "Weed Pollen"
        Me.ChkHourWeedPollen.UseVisualStyleBackColor = True
        '
        'ChkHourTreePollen
        '
        Me.ChkHourTreePollen.AutoSize = True
        Me.ChkHourTreePollen.Location = New System.Drawing.Point(95, 323)
        Me.ChkHourTreePollen.Name = "ChkHourTreePollen"
        Me.ChkHourTreePollen.Size = New System.Drawing.Size(114, 24)
        Me.ChkHourTreePollen.TabIndex = 21
        Me.ChkHourTreePollen.Tag = "20"
        Me.ChkHourTreePollen.Text = "Tree Pollen"
        Me.ChkHourTreePollen.UseVisualStyleBackColor = True
        '
        'ChkHourSunrise
        '
        Me.ChkHourSunrise.AutoSize = True
        Me.ChkHourSunrise.Location = New System.Drawing.Point(199, 63)
        Me.ChkHourSunrise.Name = "ChkHourSunrise"
        Me.ChkHourSunrise.Size = New System.Drawing.Size(89, 24)
        Me.ChkHourSunrise.TabIndex = 20
        Me.ChkHourSunrise.Tag = "11"
        Me.ChkHourSunrise.Text = "Sunrise"
        Me.ChkHourSunrise.UseVisualStyleBackColor = True
        '
        'ChkHourCloudCover
        '
        Me.ChkHourCloudCover.AutoSize = True
        Me.ChkHourCloudCover.Location = New System.Drawing.Point(199, 139)
        Me.ChkHourCloudCover.Name = "ChkHourCloudCover"
        Me.ChkHourCloudCover.Size = New System.Drawing.Size(121, 24)
        Me.ChkHourCloudCover.TabIndex = 19
        Me.ChkHourCloudCover.Tag = "14"
        Me.ChkHourCloudCover.Text = "Cloud Cover"
        Me.ChkHourCloudCover.UseVisualStyleBackColor = True
        '
        'ChkHourSunset
        '
        Me.ChkHourSunset.AutoSize = True
        Me.ChkHourSunset.Location = New System.Drawing.Point(429, 25)
        Me.ChkHourSunset.Name = "ChkHourSunset"
        Me.ChkHourSunset.Size = New System.Drawing.Size(86, 24)
        Me.ChkHourSunset.TabIndex = 18
        Me.ChkHourSunset.Tag = "12"
        Me.ChkHourSunset.Text = "Sunset"
        Me.ChkHourSunset.UseVisualStyleBackColor = True
        '
        'ChkHourCloudBase
        '
        Me.ChkHourCloudBase.AutoSize = True
        Me.ChkHourCloudBase.Location = New System.Drawing.Point(429, 139)
        Me.ChkHourCloudBase.Name = "ChkHourCloudBase"
        Me.ChkHourCloudBase.Size = New System.Drawing.Size(117, 24)
        Me.ChkHourCloudBase.TabIndex = 17
        Me.ChkHourCloudBase.Tag = "15"
        Me.ChkHourCloudBase.Text = "Cloud Base"
        Me.ChkHourCloudBase.UseVisualStyleBackColor = True
        '
        'ChkHourCloudCeil
        '
        Me.ChkHourCloudCeil.AutoSize = True
        Me.ChkHourCloudCeil.Location = New System.Drawing.Point(199, 177)
        Me.ChkHourCloudCeil.Name = "ChkHourCloudCeil"
        Me.ChkHourCloudCeil.Size = New System.Drawing.Size(127, 24)
        Me.ChkHourCloudCeil.TabIndex = 16
        Me.ChkHourCloudCeil.Tag = "16"
        Me.ChkHourCloudCeil.Text = "Cloud Ceiling"
        Me.ChkHourCloudCeil.UseVisualStyleBackColor = True
        '
        'ChkHourSSR
        '
        Me.ChkHourSSR.AutoSize = True
        Me.ChkHourSSR.Location = New System.Drawing.Point(429, 215)
        Me.ChkHourSSR.Name = "ChkHourSSR"
        Me.ChkHourSSR.Size = New System.Drawing.Size(242, 24)
        Me.ChkHourSSR.TabIndex = 15
        Me.ChkHourSSR.Tag = "17"
        Me.ChkHourSSR.Text = "Surface Shortwave Radiation"
        Me.ChkHourSSR.UseVisualStyleBackColor = True
        '
        'ChkHourMoonPhase
        '
        Me.ChkHourMoonPhase.AutoSize = True
        Me.ChkHourMoonPhase.Location = New System.Drawing.Point(199, 215)
        Me.ChkHourMoonPhase.Name = "ChkHourMoonPhase"
        Me.ChkHourMoonPhase.Size = New System.Drawing.Size(124, 24)
        Me.ChkHourMoonPhase.TabIndex = 14
        Me.ChkHourMoonPhase.Tag = "18"
        Me.ChkHourMoonPhase.Text = "Moon Phase"
        Me.ChkHourMoonPhase.UseVisualStyleBackColor = True
        '
        'ChkHourWxCode
        '
        Me.ChkHourWxCode.AutoSize = True
        Me.ChkHourWxCode.Location = New System.Drawing.Point(199, 253)
        Me.ChkHourWxCode.Name = "ChkHourWxCode"
        Me.ChkHourWxCode.Size = New System.Drawing.Size(138, 24)
        Me.ChkHourWxCode.TabIndex = 13
        Me.ChkHourWxCode.Tag = "19"
        Me.ChkHourWxCode.Text = "Weather Code"
        Me.ChkHourWxCode.UseVisualStyleBackColor = True
        '
        'ChkHourVis
        '
        Me.ChkHourVis.AutoSize = True
        Me.ChkHourVis.Location = New System.Drawing.Point(199, 101)
        Me.ChkHourVis.Name = "ChkHourVis"
        Me.ChkHourVis.Size = New System.Drawing.Size(90, 24)
        Me.ChkHourVis.TabIndex = 12
        Me.ChkHourVis.Tag = "13"
        Me.ChkHourVis.Text = "Visibility"
        Me.ChkHourVis.UseVisualStyleBackColor = True
        '
        'ChkHourPrecipProb
        '
        Me.ChkHourPrecipProb.AutoSize = True
        Me.ChkHourPrecipProb.Location = New System.Drawing.Point(199, 25)
        Me.ChkHourPrecipProb.Name = "ChkHourPrecipProb"
        Me.ChkHourPrecipProb.Size = New System.Drawing.Size(198, 24)
        Me.ChkHourPrecipProb.TabIndex = 11
        Me.ChkHourPrecipProb.Tag = "10"
        Me.ChkHourPrecipProb.Text = "Precipitation Probability"
        Me.ChkHourPrecipProb.UseVisualStyleBackColor = True
        '
        'ChkHourFeelsLike
        '
        Me.ChkHourFeelsLike.AutoSize = True
        Me.ChkHourFeelsLike.Location = New System.Drawing.Point(17, 63)
        Me.ChkHourFeelsLike.Name = "ChkHourFeelsLike"
        Me.ChkHourFeelsLike.Size = New System.Drawing.Size(107, 24)
        Me.ChkHourFeelsLike.TabIndex = 10
        Me.ChkHourFeelsLike.Tag = "1"
        Me.ChkHourFeelsLike.Text = "Feels Like"
        Me.ChkHourFeelsLike.UseVisualStyleBackColor = True
        '
        'ChkHourWindSpeed
        '
        Me.ChkHourWindSpeed.AutoSize = True
        Me.ChkHourWindSpeed.Location = New System.Drawing.Point(429, 101)
        Me.ChkHourWindSpeed.Name = "ChkHourWindSpeed"
        Me.ChkHourWindSpeed.Size = New System.Drawing.Size(122, 24)
        Me.ChkHourWindSpeed.TabIndex = 9
        Me.ChkHourWindSpeed.Tag = "4"
        Me.ChkHourWindSpeed.Text = "Wind Speed"
        Me.ChkHourWindSpeed.UseVisualStyleBackColor = True
        '
        'ChkHourDewpoint
        '
        Me.ChkHourDewpoint.AutoSize = True
        Me.ChkHourDewpoint.Location = New System.Drawing.Point(429, 63)
        Me.ChkHourDewpoint.Name = "ChkHourDewpoint"
        Me.ChkHourDewpoint.Size = New System.Drawing.Size(102, 24)
        Me.ChkHourDewpoint.TabIndex = 8
        Me.ChkHourDewpoint.Tag = "2"
        Me.ChkHourDewpoint.Text = "Dewpoint"
        Me.ChkHourDewpoint.UseVisualStyleBackColor = True
        '
        'ChkHourWindDir
        '
        Me.ChkHourWindDir.AutoSize = True
        Me.ChkHourWindDir.Location = New System.Drawing.Point(17, 139)
        Me.ChkHourWindDir.Name = "ChkHourWindDir"
        Me.ChkHourWindDir.Size = New System.Drawing.Size(138, 24)
        Me.ChkHourWindDir.TabIndex = 7
        Me.ChkHourWindDir.Tag = "5"
        Me.ChkHourWindDir.Text = "Wind Direction"
        Me.ChkHourWindDir.UseVisualStyleBackColor = True
        '
        'ChkHourWindGust
        '
        Me.ChkHourWindGust.AutoSize = True
        Me.ChkHourWindGust.Location = New System.Drawing.Point(17, 177)
        Me.ChkHourWindGust.Name = "ChkHourWindGust"
        Me.ChkHourWindGust.Size = New System.Drawing.Size(110, 24)
        Me.ChkHourWindGust.TabIndex = 6
        Me.ChkHourWindGust.Tag = "6"
        Me.ChkHourWindGust.Text = "Wind Gust"
        Me.ChkHourWindGust.UseVisualStyleBackColor = True
        '
        'ChkHourBP
        '
        Me.ChkHourBP.AutoSize = True
        Me.ChkHourBP.Location = New System.Drawing.Point(429, 177)
        Me.ChkHourBP.Name = "ChkHourBP"
        Me.ChkHourBP.Size = New System.Drawing.Size(179, 24)
        Me.ChkHourBP.TabIndex = 5
        Me.ChkHourBP.Tag = "7"
        Me.ChkHourBP.Text = "Barometric Pressure"
        Me.ChkHourBP.UseVisualStyleBackColor = True
        '
        'ChkHourPrecip
        '
        Me.ChkHourPrecip.AutoSize = True
        Me.ChkHourPrecip.Location = New System.Drawing.Point(17, 215)
        Me.ChkHourPrecip.Name = "ChkHourPrecip"
        Me.ChkHourPrecip.Size = New System.Drawing.Size(122, 24)
        Me.ChkHourPrecip.TabIndex = 4
        Me.ChkHourPrecip.Tag = "8"
        Me.ChkHourPrecip.Text = "Precipitation"
        Me.ChkHourPrecip.UseVisualStyleBackColor = True
        '
        'ChkHourPrecipType
        '
        Me.ChkHourPrecipType.AutoSize = True
        Me.ChkHourPrecipType.Location = New System.Drawing.Point(17, 253)
        Me.ChkHourPrecipType.Name = "ChkHourPrecipType"
        Me.ChkHourPrecipType.Size = New System.Drawing.Size(160, 24)
        Me.ChkHourPrecipType.TabIndex = 3
        Me.ChkHourPrecipType.Tag = "9"
        Me.ChkHourPrecipType.Text = "Precipitation Type"
        Me.ChkHourPrecipType.UseVisualStyleBackColor = True
        '
        'ChkHourRH
        '
        Me.ChkHourRH.AutoSize = True
        Me.ChkHourRH.Location = New System.Drawing.Point(17, 101)
        Me.ChkHourRH.Name = "ChkHourRH"
        Me.ChkHourRH.Size = New System.Drawing.Size(96, 24)
        Me.ChkHourRH.TabIndex = 1
        Me.ChkHourRH.Tag = "3"
        Me.ChkHourRH.Text = "Humidity"
        Me.ChkHourRH.UseVisualStyleBackColor = True
        '
        'ChkHourTemp
        '
        Me.ChkHourTemp.AutoSize = True
        Me.ChkHourTemp.Location = New System.Drawing.Point(17, 25)
        Me.ChkHourTemp.Name = "ChkHourTemp"
        Me.ChkHourTemp.Size = New System.Drawing.Size(126, 24)
        Me.ChkHourTemp.TabIndex = 0
        Me.ChkHourTemp.Tag = "0"
        Me.ChkHourTemp.Text = "Temperature"
        Me.ChkHourTemp.UseVisualStyleBackColor = True
        '
        'PnlDailyForecast
        '
        Me.PnlDailyForecast.BackColor = System.Drawing.Color.Silver
        Me.PnlDailyForecast.Controls.Add(Me.GbDailyFields)
        Me.PnlDailyForecast.Controls.Add(Me.ChkAllDaily)
        Me.PnlDailyForecast.Location = New System.Drawing.Point(28, 490)
        Me.PnlDailyForecast.Name = "PnlDailyForecast"
        Me.PnlDailyForecast.Size = New System.Drawing.Size(520, 366)
        Me.PnlDailyForecast.TabIndex = 20
        '
        'GbDailyFields
        '
        Me.GbDailyFields.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GbDailyFields.Controls.Add(Me.ChkMoonPhase)
        Me.GbDailyFields.Controls.Add(Me.ChkTemp)
        Me.GbDailyFields.Controls.Add(Me.ChkWxCode)
        Me.GbDailyFields.Controls.Add(Me.ChkPrecip)
        Me.GbDailyFields.Controls.Add(Me.ChkVis)
        Me.GbDailyFields.Controls.Add(Me.ChkBP)
        Me.GbDailyFields.Controls.Add(Me.ChkPrecipProb)
        Me.GbDailyFields.Controls.Add(Me.ChkWindDir)
        Me.GbDailyFields.Controls.Add(Me.ChkPrecipAcc)
        Me.GbDailyFields.Controls.Add(Me.ChkWindSpeed)
        Me.GbDailyFields.Controls.Add(Me.ChkSunrise)
        Me.GbDailyFields.Controls.Add(Me.ChkHumidity)
        Me.GbDailyFields.Controls.Add(Me.ChkSunset)
        Me.GbDailyFields.Controls.Add(Me.ChkDewpoint)
        Me.GbDailyFields.Controls.Add(Me.ChkFeelsLike)
        Me.GbDailyFields.Location = New System.Drawing.Point(21, 13)
        Me.GbDailyFields.Name = "GbDailyFields"
        Me.GbDailyFields.Size = New System.Drawing.Size(478, 292)
        Me.GbDailyFields.TabIndex = 18
        Me.GbDailyFields.TabStop = False
        Me.GbDailyFields.Text = "Daily Forecast Fields"
        '
        'ChkMoonPhase
        '
        Me.ChkMoonPhase.AutoSize = True
        Me.ChkMoonPhase.Location = New System.Drawing.Point(238, 217)
        Me.ChkMoonPhase.Name = "ChkMoonPhase"
        Me.ChkMoonPhase.Size = New System.Drawing.Size(124, 24)
        Me.ChkMoonPhase.TabIndex = 18
        Me.ChkMoonPhase.Tag = "14"
        Me.ChkMoonPhase.Text = "Moon Phase"
        Me.ChkMoonPhase.UseVisualStyleBackColor = True
        '
        'ChkTemp
        '
        Me.ChkTemp.AutoSize = True
        Me.ChkTemp.Location = New System.Drawing.Point(19, 25)
        Me.ChkTemp.Name = "ChkTemp"
        Me.ChkTemp.Size = New System.Drawing.Size(126, 24)
        Me.ChkTemp.TabIndex = 4
        Me.ChkTemp.Tag = "0"
        Me.ChkTemp.Text = "Temperature"
        Me.ChkTemp.UseVisualStyleBackColor = True
        '
        'ChkWxCode
        '
        Me.ChkWxCode.AutoSize = True
        Me.ChkWxCode.Location = New System.Drawing.Point(238, 185)
        Me.ChkWxCode.Name = "ChkWxCode"
        Me.ChkWxCode.Size = New System.Drawing.Size(138, 24)
        Me.ChkWxCode.TabIndex = 17
        Me.ChkWxCode.Tag = "13"
        Me.ChkWxCode.Text = "Weather Code"
        Me.ChkWxCode.UseVisualStyleBackColor = True
        '
        'ChkPrecip
        '
        Me.ChkPrecip.AutoSize = True
        Me.ChkPrecip.Location = New System.Drawing.Point(19, 249)
        Me.ChkPrecip.Name = "ChkPrecip"
        Me.ChkPrecip.Size = New System.Drawing.Size(122, 24)
        Me.ChkPrecip.TabIndex = 5
        Me.ChkPrecip.Tag = "7"
        Me.ChkPrecip.Text = "Precipitation"
        Me.ChkPrecip.UseVisualStyleBackColor = True
        '
        'ChkVis
        '
        Me.ChkVis.AutoSize = True
        Me.ChkVis.Location = New System.Drawing.Point(238, 153)
        Me.ChkVis.Name = "ChkVis"
        Me.ChkVis.Size = New System.Drawing.Size(90, 24)
        Me.ChkVis.TabIndex = 16
        Me.ChkVis.Tag = "12"
        Me.ChkVis.Text = "Visibility"
        Me.ChkVis.UseVisualStyleBackColor = True
        '
        'ChkBP
        '
        Me.ChkBP.AutoSize = True
        Me.ChkBP.Location = New System.Drawing.Point(19, 217)
        Me.ChkBP.Name = "ChkBP"
        Me.ChkBP.Size = New System.Drawing.Size(179, 24)
        Me.ChkBP.TabIndex = 6
        Me.ChkBP.Tag = "6"
        Me.ChkBP.Text = "Barometric Pressure"
        Me.ChkBP.UseVisualStyleBackColor = True
        '
        'ChkPrecipProb
        '
        Me.ChkPrecipProb.AutoSize = True
        Me.ChkPrecipProb.Location = New System.Drawing.Point(238, 25)
        Me.ChkPrecipProb.Name = "ChkPrecipProb"
        Me.ChkPrecipProb.Size = New System.Drawing.Size(198, 24)
        Me.ChkPrecipProb.TabIndex = 15
        Me.ChkPrecipProb.Tag = "8"
        Me.ChkPrecipProb.Text = "Precipitation Probability"
        Me.ChkPrecipProb.UseVisualStyleBackColor = True
        '
        'ChkWindDir
        '
        Me.ChkWindDir.AutoSize = True
        Me.ChkWindDir.Location = New System.Drawing.Point(19, 185)
        Me.ChkWindDir.Name = "ChkWindDir"
        Me.ChkWindDir.Size = New System.Drawing.Size(138, 24)
        Me.ChkWindDir.TabIndex = 7
        Me.ChkWindDir.Tag = "5"
        Me.ChkWindDir.Text = "Wind Direction"
        Me.ChkWindDir.UseVisualStyleBackColor = True
        '
        'ChkPrecipAcc
        '
        Me.ChkPrecipAcc.AutoSize = True
        Me.ChkPrecipAcc.Location = New System.Drawing.Point(238, 57)
        Me.ChkPrecipAcc.Name = "ChkPrecipAcc"
        Me.ChkPrecipAcc.Size = New System.Drawing.Size(222, 24)
        Me.ChkPrecipAcc.TabIndex = 14
        Me.ChkPrecipAcc.Tag = "9"
        Me.ChkPrecipAcc.Text = "Precipitation Accumulation"
        Me.ChkPrecipAcc.UseVisualStyleBackColor = True
        '
        'ChkWindSpeed
        '
        Me.ChkWindSpeed.AutoSize = True
        Me.ChkWindSpeed.Location = New System.Drawing.Point(19, 153)
        Me.ChkWindSpeed.Name = "ChkWindSpeed"
        Me.ChkWindSpeed.Size = New System.Drawing.Size(122, 24)
        Me.ChkWindSpeed.TabIndex = 8
        Me.ChkWindSpeed.Tag = "4"
        Me.ChkWindSpeed.Text = "Wind Speed"
        Me.ChkWindSpeed.UseVisualStyleBackColor = True
        '
        'ChkSunrise
        '
        Me.ChkSunrise.AutoSize = True
        Me.ChkSunrise.Location = New System.Drawing.Point(238, 89)
        Me.ChkSunrise.Name = "ChkSunrise"
        Me.ChkSunrise.Size = New System.Drawing.Size(89, 24)
        Me.ChkSunrise.TabIndex = 13
        Me.ChkSunrise.Tag = "10"
        Me.ChkSunrise.Text = "Sunrise"
        Me.ChkSunrise.UseVisualStyleBackColor = True
        '
        'ChkHumidity
        '
        Me.ChkHumidity.AutoSize = True
        Me.ChkHumidity.Location = New System.Drawing.Point(19, 121)
        Me.ChkHumidity.Name = "ChkHumidity"
        Me.ChkHumidity.Size = New System.Drawing.Size(96, 24)
        Me.ChkHumidity.TabIndex = 9
        Me.ChkHumidity.Tag = "3"
        Me.ChkHumidity.Text = "Humidity"
        Me.ChkHumidity.UseVisualStyleBackColor = True
        '
        'ChkSunset
        '
        Me.ChkSunset.AutoSize = True
        Me.ChkSunset.Location = New System.Drawing.Point(238, 121)
        Me.ChkSunset.Name = "ChkSunset"
        Me.ChkSunset.Size = New System.Drawing.Size(86, 24)
        Me.ChkSunset.TabIndex = 12
        Me.ChkSunset.Tag = "11"
        Me.ChkSunset.Text = "Sunset"
        Me.ChkSunset.UseVisualStyleBackColor = True
        '
        'ChkDewpoint
        '
        Me.ChkDewpoint.AutoSize = True
        Me.ChkDewpoint.Location = New System.Drawing.Point(19, 89)
        Me.ChkDewpoint.Name = "ChkDewpoint"
        Me.ChkDewpoint.Size = New System.Drawing.Size(102, 24)
        Me.ChkDewpoint.TabIndex = 10
        Me.ChkDewpoint.Tag = "2"
        Me.ChkDewpoint.Text = "Dewpoint"
        Me.ChkDewpoint.UseVisualStyleBackColor = True
        '
        'ChkFeelsLike
        '
        Me.ChkFeelsLike.AutoSize = True
        Me.ChkFeelsLike.Location = New System.Drawing.Point(19, 57)
        Me.ChkFeelsLike.Name = "ChkFeelsLike"
        Me.ChkFeelsLike.Size = New System.Drawing.Size(107, 24)
        Me.ChkFeelsLike.TabIndex = 11
        Me.ChkFeelsLike.Tag = "1"
        Me.ChkFeelsLike.Text = "Feels Like"
        Me.ChkFeelsLike.UseVisualStyleBackColor = True
        '
        'ChkAllDaily
        '
        Me.ChkAllDaily.AutoSize = True
        Me.ChkAllDaily.Location = New System.Drawing.Point(97, 324)
        Me.ChkAllDaily.Name = "ChkAllDaily"
        Me.ChkAllDaily.Size = New System.Drawing.Size(319, 24)
        Me.ChkAllDaily.TabIndex = 18
        Me.ChkAllDaily.Text = "Check/Uncheck All Daily Forecast Fields"
        Me.ChkAllDaily.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.RbUnitSI)
        Me.GroupBox3.Controls.Add(Me.RbUnitUS)
        Me.GroupBox3.Location = New System.Drawing.Point(366, 206)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(182, 75)
        Me.GroupBox3.TabIndex = 19
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Units"
        '
        'RbUnitSI
        '
        Me.RbUnitSI.AutoSize = True
        Me.RbUnitSI.Location = New System.Drawing.Point(110, 25)
        Me.RbUnitSI.Name = "RbUnitSI"
        Me.RbUnitSI.Size = New System.Drawing.Size(50, 24)
        Me.RbUnitSI.TabIndex = 1
        Me.RbUnitSI.TabStop = True
        Me.RbUnitSI.Tag = "1"
        Me.RbUnitSI.Text = "SI"
        Me.RbUnitSI.UseVisualStyleBackColor = True
        '
        'RbUnitUS
        '
        Me.RbUnitUS.AutoSize = True
        Me.RbUnitUS.Location = New System.Drawing.Point(23, 25)
        Me.RbUnitUS.Name = "RbUnitUS"
        Me.RbUnitUS.Size = New System.Drawing.Size(57, 24)
        Me.RbUnitUS.TabIndex = 0
        Me.RbUnitUS.TabStop = True
        Me.RbUnitUS.Tag = "0"
        Me.RbUnitUS.Text = "US"
        Me.RbUnitUS.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.TxtApiKey)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(28, 320)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(520, 69)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Security"
        '
        'TxtApiKey
        '
        Me.TxtApiKey.Location = New System.Drawing.Point(89, 21)
        Me.TxtApiKey.MaxLength = 40
        Me.TxtApiKey.Name = "TxtApiKey"
        Me.TxtApiKey.Size = New System.Drawing.Size(415, 26)
        Me.TxtApiKey.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "API Key"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.TxtLocationId)
        Me.GroupBox1.Controls.Add(Me.NumLongitude)
        Me.GroupBox1.Controls.Add(Me.NumLatiutude)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(28, 180)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(302, 127)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Location"
        '
        'TxtLocationId
        '
        Me.TxtLocationId.Enabled = False
        Me.TxtLocationId.Location = New System.Drawing.Point(109, 87)
        Me.TxtLocationId.Name = "TxtLocationId"
        Me.TxtLocationId.Size = New System.Drawing.Size(167, 26)
        Me.TxtLocationId.TabIndex = 5
        '
        'NumLongitude
        '
        Me.NumLongitude.DecimalPlaces = 7
        Me.NumLongitude.Location = New System.Drawing.Point(109, 56)
        Me.NumLongitude.Maximum = New Decimal(New Integer() {180, 0, 0, 0})
        Me.NumLongitude.Minimum = New Decimal(New Integer() {180, 0, 0, -2147483648})
        Me.NumLongitude.Name = "NumLongitude"
        Me.NumLongitude.Size = New System.Drawing.Size(167, 26)
        Me.NumLongitude.TabIndex = 4
        Me.NumLongitude.Tag = "1"
        '
        'NumLatiutude
        '
        Me.NumLatiutude.DecimalPlaces = 7
        Me.NumLatiutude.Location = New System.Drawing.Point(109, 25)
        Me.NumLatiutude.Maximum = New Decimal(New Integer() {89, 0, 0, 0})
        Me.NumLatiutude.Minimum = New Decimal(New Integer() {87, 0, 0, -2147483648})
        Me.NumLatiutude.Name = "NumLatiutude"
        Me.NumLatiutude.Size = New System.Drawing.Size(167, 26)
        Me.NumLatiutude.TabIndex = 3
        Me.NumLatiutude.Tag = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Location ID"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Longitude"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Latitude"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TTip
        '
        Me.TTip.IsBalloon = True
        Me.TTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        '
        'StatusStrip1
        '
        Me.StatusStrip1.GripMargin = New System.Windows.Forms.Padding(0)
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TsslVer, Me.TsslNextUpdate, Me.TsslCpy, Me.TsslClock})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 1057)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1580, 32)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 7
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'TsslVer
        '
        Me.TsslVer.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.TsslVer.ForeColor = System.Drawing.Color.Navy
        Me.TsslVer.Name = "TsslVer"
        Me.TsslVer.Size = New System.Drawing.Size(18, 25)
        Me.TsslVer.Text = "v"
        Me.TsslVer.ToolTipText = "Application version"
        '
        'TsslNextUpdate
        '
        Me.TsslNextUpdate.Name = "TsslNextUpdate"
        Me.TsslNextUpdate.Size = New System.Drawing.Size(32, 25)
        Me.TsslNextUpdate.Text = "nu"
        Me.TsslNextUpdate.ToolTipText = "Time to next update"
        '
        'TsslClock
        '
        Me.TsslClock.Name = "TsslClock"
        Me.TsslClock.Size = New System.Drawing.Size(58, 25)
        Me.TsslClock.Text = "h:mm"
        '
        'TsslCpy
        '
        Me.TsslCpy.Name = "TsslCpy"
        Me.TsslCpy.Size = New System.Drawing.Size(1411, 25)
        Me.TsslCpy.Spring = True
        Me.TsslCpy.Text = "cpy"
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1580, 1089)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.TC)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("Location", Global.ClimaCell.My.MySettings.Default, "MainFormLocation", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Location = Global.ClimaCell.My.MySettings.Default.MainFormLocation
        Me.MaximizeBox = False
        Me.Name = "FrmMain"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Form1"
        CType(Me.TmrUpdate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TmrClock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TC.ResumeLayout(False)
        Me.TpForecast.ResumeLayout(False)
        CType(Me.DgvDaily, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TpLogs.ResumeLayout(False)
        Me.TcLogs.ResumeLayout(False)
        Me.TpLogLog.ResumeLayout(False)
        Me.TpLogData.ResumeLayout(False)
        Me.TpLogError.ResumeLayout(False)
        Me.TpSettings.ResumeLayout(False)
        Me.PnlSettings.ResumeLayout(False)
        Me.PnlAbout.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.NumUpdateInterval, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlHourlyForecast.ResumeLayout(False)
        Me.PnlHourlyForecast.PerformLayout()
        Me.GbHourlyFields.ResumeLayout(False)
        Me.GbHourlyFields.PerformLayout()
        Me.PnlDailyForecast.ResumeLayout(False)
        Me.PnlDailyForecast.PerformLayout()
        Me.GbDailyFields.ResumeLayout(False)
        Me.GbDailyFields.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NumLongitude, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumLatiutude, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TmrUpdate As Timers.Timer
    Friend WithEvents TmrClock As Timers.Timer
    Friend WithEvents TC As TabControl
    Friend WithEvents TpForecast As TabPage
    Friend WithEvents DgvDaily As DataGridView
    Friend WithEvents TpLogs As TabPage
    Friend WithEvents TcLogs As TabControl
    Friend WithEvents TpLogLog As TabPage
    Friend WithEvents RtbLog As RichTextBox
    Friend WithEvents TpLogData As TabPage
    Friend WithEvents RtbData As RichTextBox
    Friend WithEvents TpLogError As TabPage
    Friend WithEvents RtbError As RichTextBox
    Friend WithEvents TpSettings As TabPage
    Friend WithEvents PnlSettings As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents NumLatiutude As NumericUpDown
    Friend WithEvents NumLongitude As NumericUpDown
    Friend WithEvents TxtLocationId As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtApiKey As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents NumUpdateInterval As NumericUpDown
    Friend WithEvents ChkFeelsLike As CheckBox
    Friend WithEvents ChkDewpoint As CheckBox
    Friend WithEvents ChkHumidity As CheckBox
    Friend WithEvents ChkWindSpeed As CheckBox
    Friend WithEvents ChkWindDir As CheckBox
    Friend WithEvents ChkBP As CheckBox
    Friend WithEvents ChkPrecip As CheckBox
    Friend WithEvents ChkTemp As CheckBox
    Friend WithEvents ChkPrecipProb As CheckBox
    Friend WithEvents ChkPrecipAcc As CheckBox
    Friend WithEvents ChkSunrise As CheckBox
    Friend WithEvents ChkSunset As CheckBox
    Friend WithEvents ChkWxCode As CheckBox
    Friend WithEvents ChkVis As CheckBox
    Friend WithEvents GbDailyFields As GroupBox
    Friend WithEvents ChkAllDaily As CheckBox
    Friend WithEvents ChkMoonPhase As CheckBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents RbUnitUS As RadioButton
    Friend WithEvents RbUnitSI As RadioButton
    Friend WithEvents PnlDailyForecast As Panel
    Friend WithEvents PnlHourlyForecast As Panel
    Friend WithEvents GbHourlyFields As GroupBox
    Friend WithEvents ChkAllHourly As CheckBox
    Friend WithEvents ChkHourSunrise As CheckBox
    Friend WithEvents ChkHourCloudCover As CheckBox
    Friend WithEvents ChkHourSunset As CheckBox
    Friend WithEvents ChkHourCloudBase As CheckBox
    Friend WithEvents ChkHourCloudCeil As CheckBox
    Friend WithEvents ChkHourSSR As CheckBox
    Friend WithEvents ChkHourMoonPhase As CheckBox
    Friend WithEvents ChkHourWxCode As CheckBox
    Friend WithEvents ChkHourVis As CheckBox
    Friend WithEvents ChkHourPrecipProb As CheckBox
    Friend WithEvents ChkHourFeelsLike As CheckBox
    Friend WithEvents ChkHourWindSpeed As CheckBox
    Friend WithEvents ChkHourDewpoint As CheckBox
    Friend WithEvents ChkHourWindDir As CheckBox
    Friend WithEvents ChkHourWindGust As CheckBox
    Friend WithEvents ChkHourBP As CheckBox
    Friend WithEvents ChkHourPrecip As CheckBox
    Friend WithEvents ChkHourPrecipType As CheckBox
    Friend WithEvents ChkHourRH As CheckBox
    Friend WithEvents ChkHourTemp As CheckBox
    Friend WithEvents ChkHourGrassPollen As CheckBox
    Friend WithEvents ChkHourWeedPollen As CheckBox
    Friend WithEvents ChkHourTreePollen As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ChkHourTreeAsh As CheckBox
    Friend WithEvents ChkHourTreeBeech As CheckBox
    Friend WithEvents ChkHourTreeBirch As CheckBox
    Friend WithEvents ChkHourTreeCedar As CheckBox
    Friend WithEvents ChkHourTreeCypress As CheckBox
    Friend WithEvents ChkHourTreeElder As CheckBox
    Friend WithEvents ChkHourTreeElm As CheckBox
    Friend WithEvents ChkHourTreeHemlock As CheckBox
    Friend WithEvents ChkHourTreeHickory As CheckBox
    Friend WithEvents ChkHourTreeJuniper As CheckBox
    Friend WithEvents ChkHourTreeMahogany As CheckBox
    Friend WithEvents ChkHourTreeMaple As CheckBox
    Friend WithEvents ChkHourTreeMulberry As CheckBox
    Friend WithEvents ChkHourTreeOak As CheckBox
    Friend WithEvents ChkHourTreePine As CheckBox
    Friend WithEvents ChkHourTreeCottonwood As CheckBox
    Friend WithEvents ChkHourTreeSpruce As CheckBox
    Friend WithEvents ChkHourTreeSycamore As CheckBox
    Friend WithEvents ChkHourTreeWalnut As CheckBox
    Friend WithEvents ChkHourTreeWillow As CheckBox
    Friend WithEvents ChkHourTreeAcacia As CheckBox
    Friend WithEvents Label7 As Label
    Friend WithEvents ChkHourGrass As CheckBox
    Friend WithEvents ChkHourRagweed As CheckBox
    Friend WithEvents ChkHourAqiPm25 As CheckBox
    Friend WithEvents ChkHourAqiO3 As CheckBox
    Friend WithEvents ChkHourAqiNo2 As CheckBox
    Friend WithEvents ChkHourAqiCo As CheckBox
    Friend WithEvents ChkHourAqiSo2 As CheckBox
    Friend WithEvents ChkHourEpaAqi As CheckBox
    Friend WithEvents ChkHourEpaPollutant As CheckBox
    Friend WithEvents ChkHourEpaConcern As CheckBox
    Friend WithEvents ChkHourChinaAqi As CheckBox
    Friend WithEvents ChkHourChinaConcern As CheckBox
    Friend WithEvents ChkHourChinaPollutant As CheckBox
    Friend WithEvents ChkHourAqiPm10 As CheckBox
    Friend WithEvents Label10 As Label
    Friend WithEvents ChkRiskScore As CheckBox
    Friend WithEvents ChkRiskConfidence As CheckBox
    Friend WithEvents ChkRiskCondition As CheckBox
    Friend WithEvents ChkRoadRisk As CheckBox
    Friend WithEvents ChkHailRisk As CheckBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents ChkFetchHourly As CheckBox
    Friend WithEvents ChkFetchDaily As CheckBox
    Friend WithEvents TTip As ToolTip
    Friend WithEvents PnlAbout As Panel
    Friend WithEvents LblAbout As Label
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents TsslVer As ToolStripStatusLabel
    Friend WithEvents TsslNextUpdate As ToolStripStatusLabel
    Friend WithEvents TsslClock As ToolStripStatusLabel
    Friend WithEvents TsslCpy As ToolStripStatusLabel
End Class
