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
        Dim DataGridViewCellStyle57 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle58 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle59 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle60 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle61 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle62 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle63 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle64 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TmrUpdateDaily = New System.Timers.Timer()
        Me.TmrClock = New System.Timers.Timer()
        Me.TC = New System.Windows.Forms.TabControl()
        Me.TpDaily = New System.Windows.Forms.TabPage()
        Me.DgvDaily = New System.Windows.Forms.DataGridView()
        Me.TpHourly = New System.Windows.Forms.TabPage()
        Me.DgvHourly = New System.Windows.Forms.DataGridView()
        Me.TpNowcast = New System.Windows.Forms.TabPage()
        Me.DgvNowcast = New System.Windows.Forms.DataGridView()
        Me.TpLogs = New System.Windows.Forms.TabPage()
        Me.TcLogs = New System.Windows.Forms.TabControl()
        Me.TpLogLog = New System.Windows.Forms.TabPage()
        Me.RtbLog = New System.Windows.Forms.RichTextBox()
        Me.TpLogData = New System.Windows.Forms.TabPage()
        Me.RtbData = New System.Windows.Forms.RichTextBox()
        Me.TpLogError = New System.Windows.Forms.TabPage()
        Me.RtbError = New System.Windows.Forms.RichTextBox()
        Me.TpOptions = New System.Windows.Forms.TabPage()
        Me.TcOpt = New System.Windows.Forms.TabControl()
        Me.TpOptMain = New System.Windows.Forms.TabPage()
        Me.PnlSettings = New System.Windows.Forms.Panel()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.NumNowcastInterval = New System.Windows.Forms.NumericUpDown()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.NumHourlyInterval = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.NumDailyInterval = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.ChkFetchNowcast = New System.Windows.Forms.CheckBox()
        Me.ChkFetchHourly = New System.Windows.Forms.CheckBox()
        Me.ChkFetchDaily = New System.Windows.Forms.CheckBox()
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
        Me.TpOptDaily = New System.Windows.Forms.TabPage()
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
        Me.TpOptHourly = New System.Windows.Forms.TabPage()
        Me.PnlHourlyForecast = New System.Windows.Forms.Panel()
        Me.ChkAllHourly = New System.Windows.Forms.CheckBox()
        Me.GbHourlyFields = New System.Windows.Forms.GroupBox()
        Me.ChkHrHailRisk = New System.Windows.Forms.CheckBox()
        Me.ChkHrRiskScore = New System.Windows.Forms.CheckBox()
        Me.ChkHrRiskConfidence = New System.Windows.Forms.CheckBox()
        Me.ChkHrRiskCondition = New System.Windows.Forms.CheckBox()
        Me.ChkHrRoadRisk = New System.Windows.Forms.CheckBox()
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
        Me.TpOptNowCast = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.NumNcTimeStep = New System.Windows.Forms.NumericUpDown()
        Me.ChkAllNowcast = New System.Windows.Forms.CheckBox()
        Me.GbNowcast = New System.Windows.Forms.GroupBox()
        Me.ChkNcHailRisk = New System.Windows.Forms.CheckBox()
        Me.ChkNcRiskScore = New System.Windows.Forms.CheckBox()
        Me.ChkNcRiskConfidence = New System.Windows.Forms.CheckBox()
        Me.ChkNcRiskCondition = New System.Windows.Forms.CheckBox()
        Me.ChkNcRoadRisk = New System.Windows.Forms.CheckBox()
        Me.ChkNcPm25 = New System.Windows.Forms.CheckBox()
        Me.ChkNcO3 = New System.Windows.Forms.CheckBox()
        Me.ChkNcNo2 = New System.Windows.Forms.CheckBox()
        Me.ChkNcCo = New System.Windows.Forms.CheckBox()
        Me.ChkNcSo2 = New System.Windows.Forms.CheckBox()
        Me.ChkNcEpaAqi = New System.Windows.Forms.CheckBox()
        Me.ChkNcEpaPollutant = New System.Windows.Forms.CheckBox()
        Me.ChkNcEpaConcern = New System.Windows.Forms.CheckBox()
        Me.ChkNcChinaAqi = New System.Windows.Forms.CheckBox()
        Me.ChkNcChinaConcern = New System.Windows.Forms.CheckBox()
        Me.ChkNcChinaPollutant = New System.Windows.Forms.CheckBox()
        Me.ChkNcPm10 = New System.Windows.Forms.CheckBox()
        Me.ChkNcGrass = New System.Windows.Forms.CheckBox()
        Me.ChkNcRagweed = New System.Windows.Forms.CheckBox()
        Me.ChkNcAsh = New System.Windows.Forms.CheckBox()
        Me.ChkNcBeech = New System.Windows.Forms.CheckBox()
        Me.ChkNcBirch = New System.Windows.Forms.CheckBox()
        Me.ChkNcCedar = New System.Windows.Forms.CheckBox()
        Me.ChkNcCypress = New System.Windows.Forms.CheckBox()
        Me.ChkNcElder = New System.Windows.Forms.CheckBox()
        Me.ChkNcElm = New System.Windows.Forms.CheckBox()
        Me.ChkNcHemlock = New System.Windows.Forms.CheckBox()
        Me.ChkNcHickory = New System.Windows.Forms.CheckBox()
        Me.ChkNcJuniper = New System.Windows.Forms.CheckBox()
        Me.ChkNcMahogany = New System.Windows.Forms.CheckBox()
        Me.ChkNcMaple = New System.Windows.Forms.CheckBox()
        Me.ChkNcMulberry = New System.Windows.Forms.CheckBox()
        Me.ChkNcOak = New System.Windows.Forms.CheckBox()
        Me.ChkNcPine = New System.Windows.Forms.CheckBox()
        Me.ChkNcCottonwood = New System.Windows.Forms.CheckBox()
        Me.ChkNcSpruce = New System.Windows.Forms.CheckBox()
        Me.ChkNcSycamore = New System.Windows.Forms.CheckBox()
        Me.ChkNcWalnut = New System.Windows.Forms.CheckBox()
        Me.ChkNcWillow = New System.Windows.Forms.CheckBox()
        Me.ChkNcAcacia = New System.Windows.Forms.CheckBox()
        Me.ChkNcGrassPollen = New System.Windows.Forms.CheckBox()
        Me.ChkNcWeedPollen = New System.Windows.Forms.CheckBox()
        Me.ChkNcTreePollen = New System.Windows.Forms.CheckBox()
        Me.ChkNcSunrise = New System.Windows.Forms.CheckBox()
        Me.ChkNcCloudCover = New System.Windows.Forms.CheckBox()
        Me.ChkNcSunset = New System.Windows.Forms.CheckBox()
        Me.ChkNcCloudBase = New System.Windows.Forms.CheckBox()
        Me.ChkNcCloudCeil = New System.Windows.Forms.CheckBox()
        Me.ChkNcSSR = New System.Windows.Forms.CheckBox()
        Me.ChkNcWxCode = New System.Windows.Forms.CheckBox()
        Me.ChkNcVis = New System.Windows.Forms.CheckBox()
        Me.ChkNcFeelsLike = New System.Windows.Forms.CheckBox()
        Me.ChkNcWindSpeed = New System.Windows.Forms.CheckBox()
        Me.ChkNcDewpoint = New System.Windows.Forms.CheckBox()
        Me.ChkNcWindDir = New System.Windows.Forms.CheckBox()
        Me.ChkNcWindGust = New System.Windows.Forms.CheckBox()
        Me.ChkNcBP = New System.Windows.Forms.CheckBox()
        Me.ChkNcPrecip = New System.Windows.Forms.CheckBox()
        Me.ChkNcPrecipType = New System.Windows.Forms.CheckBox()
        Me.ChkNcRH = New System.Windows.Forms.CheckBox()
        Me.ChkNcTemp = New System.Windows.Forms.CheckBox()
        Me.TpAbout = New System.Windows.Forms.TabPage()
        Me.PnlAbout = New System.Windows.Forms.Panel()
        Me.LblAbout = New System.Windows.Forms.Label()
        Me.TTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.TsslVer = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TsslNextDaily = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TsslNextHourly = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TsslNextNowcast = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TsslCpy = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TsslClock = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TmrUpdateHourly = New System.Timers.Timer()
        Me.TmrUpdateNowcast = New System.Timers.Timer()
        Me.ChkUncheckAllNowcast = New System.Windows.Forms.CheckBox()
        Me.c1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c3 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.c4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hr0 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hr1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hr2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.hr3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.TmrUpdateDaily, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TmrClock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TC.SuspendLayout()
        Me.TpDaily.SuspendLayout()
        CType(Me.DgvDaily, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TpHourly.SuspendLayout()
        CType(Me.DgvHourly, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TpNowcast.SuspendLayout()
        CType(Me.DgvNowcast, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TpLogs.SuspendLayout()
        Me.TcLogs.SuspendLayout()
        Me.TpLogLog.SuspendLayout()
        Me.TpLogData.SuspendLayout()
        Me.TpLogError.SuspendLayout()
        Me.TpOptions.SuspendLayout()
        Me.TcOpt.SuspendLayout()
        Me.TpOptMain.SuspendLayout()
        Me.PnlSettings.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.NumNowcastInterval, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumHourlyInterval, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumDailyInterval, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NumLongitude, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumLatiutude, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TpOptDaily.SuspendLayout()
        Me.PnlDailyForecast.SuspendLayout()
        Me.GbDailyFields.SuspendLayout()
        Me.TpOptHourly.SuspendLayout()
        Me.PnlHourlyForecast.SuspendLayout()
        Me.GbHourlyFields.SuspendLayout()
        Me.TpOptNowCast.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.NumNcTimeStep, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbNowcast.SuspendLayout()
        Me.TpAbout.SuspendLayout()
        Me.PnlAbout.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.TmrUpdateHourly, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TmrUpdateNowcast, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TmrUpdateDaily
        '
        Me.TmrUpdateDaily.SynchronizingObject = Me
        '
        'TmrClock
        '
        Me.TmrClock.Interval = 999.0R
        Me.TmrClock.SynchronizingObject = Me
        '
        'TC
        '
        Me.TC.Controls.Add(Me.TpDaily)
        Me.TC.Controls.Add(Me.TpHourly)
        Me.TC.Controls.Add(Me.TpNowcast)
        Me.TC.Controls.Add(Me.TpLogs)
        Me.TC.Controls.Add(Me.TpOptions)
        Me.TC.Controls.Add(Me.TpAbout)
        Me.TC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TC.Location = New System.Drawing.Point(0, 0)
        Me.TC.Name = "TC"
        Me.TC.SelectedIndex = 0
        Me.TC.Size = New System.Drawing.Size(1400, 1070)
        Me.TC.TabIndex = 5
        '
        'TpDaily
        '
        Me.TpDaily.BackColor = System.Drawing.Color.LightSkyBlue
        Me.TpDaily.Controls.Add(Me.DgvDaily)
        Me.TpDaily.Location = New System.Drawing.Point(4, 29)
        Me.TpDaily.Name = "TpDaily"
        Me.TpDaily.Padding = New System.Windows.Forms.Padding(3)
        Me.TpDaily.Size = New System.Drawing.Size(1392, 1037)
        Me.TpDaily.TabIndex = 0
        Me.TpDaily.Text = "Daily"
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
        DataGridViewCellStyle57.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle57.BackColor = System.Drawing.Color.LightSkyBlue
        DataGridViewCellStyle57.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle57.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle57.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle57.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DgvDaily.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle57
        Me.DgvDaily.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvDaily.ColumnHeadersVisible = False
        DataGridViewCellStyle58.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle58.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle58.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle58.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle58.SelectionBackColor = System.Drawing.Color.LightSkyBlue
        DataGridViewCellStyle58.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle58.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvDaily.DefaultCellStyle = DataGridViewCellStyle58
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
        Me.DgvDaily.Size = New System.Drawing.Size(1386, 1004)
        Me.DgvDaily.TabIndex = 5
        '
        'TpHourly
        '
        Me.TpHourly.BackColor = System.Drawing.Color.LightSkyBlue
        Me.TpHourly.Controls.Add(Me.DgvHourly)
        Me.TpHourly.Location = New System.Drawing.Point(4, 29)
        Me.TpHourly.Name = "TpHourly"
        Me.TpHourly.Size = New System.Drawing.Size(1392, 1037)
        Me.TpHourly.TabIndex = 5
        Me.TpHourly.Text = "Hourly"
        '
        'DgvHourly
        '
        Me.DgvHourly.AllowUserToAddRows = False
        Me.DgvHourly.AllowUserToDeleteRows = False
        Me.DgvHourly.AllowUserToResizeColumns = False
        Me.DgvHourly.AllowUserToResizeRows = False
        DataGridViewCellStyle59.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DgvHourly.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle59
        Me.DgvHourly.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvHourly.BackgroundColor = System.Drawing.Color.LightSkyBlue
        Me.DgvHourly.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.DgvHourly.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        DataGridViewCellStyle60.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle60.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle60.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle60.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle60.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle60.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DgvHourly.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle60
        Me.DgvHourly.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvHourly.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.hr0, Me.hr1, Me.hr2, Me.hr3})
        DataGridViewCellStyle61.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle61.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle61.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle61.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle61.SelectionBackColor = System.Drawing.Color.LightSkyBlue
        DataGridViewCellStyle61.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle61.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvHourly.DefaultCellStyle = DataGridViewCellStyle61
        Me.DgvHourly.Dock = System.Windows.Forms.DockStyle.Top
        Me.DgvHourly.Location = New System.Drawing.Point(0, 0)
        Me.DgvHourly.Margin = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.DgvHourly.MultiSelect = False
        Me.DgvHourly.Name = "DgvHourly"
        Me.DgvHourly.ReadOnly = True
        Me.DgvHourly.RowHeadersVisible = False
        Me.DgvHourly.RowHeadersWidth = 62
        Me.DgvHourly.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DgvHourly.RowTemplate.Height = 125
        Me.DgvHourly.RowTemplate.ReadOnly = True
        Me.DgvHourly.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvHourly.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DgvHourly.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DgvHourly.ShowEditingIcon = False
        Me.DgvHourly.Size = New System.Drawing.Size(1392, 1004)
        Me.DgvHourly.TabIndex = 6
        '
        'TpNowcast
        '
        Me.TpNowcast.BackColor = System.Drawing.Color.LightSkyBlue
        Me.TpNowcast.Controls.Add(Me.DgvNowcast)
        Me.TpNowcast.Location = New System.Drawing.Point(4, 29)
        Me.TpNowcast.Name = "TpNowcast"
        Me.TpNowcast.Size = New System.Drawing.Size(1392, 1037)
        Me.TpNowcast.TabIndex = 6
        Me.TpNowcast.Text = "Nowcast"
        '
        'DgvNowcast
        '
        Me.DgvNowcast.AllowUserToDeleteRows = False
        Me.DgvNowcast.AllowUserToResizeColumns = False
        Me.DgvNowcast.AllowUserToResizeRows = False
        DataGridViewCellStyle62.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DgvNowcast.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle62
        Me.DgvNowcast.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvNowcast.BackgroundColor = System.Drawing.Color.LightSkyBlue
        Me.DgvNowcast.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.DgvNowcast.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        DataGridViewCellStyle63.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle63.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle63.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle63.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle63.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle63.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DgvNowcast.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle63
        Me.DgvNowcast.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvNowcast.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.c1, Me.c2, Me.c3, Me.c4})
        DataGridViewCellStyle64.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle64.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle64.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle64.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle64.SelectionBackColor = System.Drawing.Color.LightSkyBlue
        DataGridViewCellStyle64.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle64.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvNowcast.DefaultCellStyle = DataGridViewCellStyle64
        Me.DgvNowcast.Dock = System.Windows.Forms.DockStyle.Top
        Me.DgvNowcast.Location = New System.Drawing.Point(0, 0)
        Me.DgvNowcast.Margin = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.DgvNowcast.MultiSelect = False
        Me.DgvNowcast.Name = "DgvNowcast"
        Me.DgvNowcast.ReadOnly = True
        Me.DgvNowcast.RowHeadersVisible = False
        Me.DgvNowcast.RowHeadersWidth = 62
        Me.DgvNowcast.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DgvNowcast.RowTemplate.Height = 125
        Me.DgvNowcast.RowTemplate.ReadOnly = True
        Me.DgvNowcast.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvNowcast.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DgvNowcast.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DgvNowcast.ShowEditingIcon = False
        Me.DgvNowcast.Size = New System.Drawing.Size(1392, 1004)
        Me.DgvNowcast.TabIndex = 6
        '
        'TpLogs
        '
        Me.TpLogs.Controls.Add(Me.TcLogs)
        Me.TpLogs.Location = New System.Drawing.Point(4, 29)
        Me.TpLogs.Name = "TpLogs"
        Me.TpLogs.Padding = New System.Windows.Forms.Padding(3)
        Me.TpLogs.Size = New System.Drawing.Size(1392, 1037)
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
        Me.TcLogs.Size = New System.Drawing.Size(1386, 1031)
        Me.TcLogs.TabIndex = 0
        '
        'TpLogLog
        '
        Me.TpLogLog.Controls.Add(Me.RtbLog)
        Me.TpLogLog.Location = New System.Drawing.Point(4, 4)
        Me.TpLogLog.Name = "TpLogLog"
        Me.TpLogLog.Padding = New System.Windows.Forms.Padding(3)
        Me.TpLogLog.Size = New System.Drawing.Size(1354, 1023)
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
        Me.RtbLog.Size = New System.Drawing.Size(1348, 1017)
        Me.RtbLog.TabIndex = 0
        Me.RtbLog.Text = ""
        '
        'TpLogData
        '
        Me.TpLogData.Controls.Add(Me.RtbData)
        Me.TpLogData.Location = New System.Drawing.Point(4, 4)
        Me.TpLogData.Name = "TpLogData"
        Me.TpLogData.Padding = New System.Windows.Forms.Padding(3)
        Me.TpLogData.Size = New System.Drawing.Size(1354, 1023)
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
        Me.RtbData.Size = New System.Drawing.Size(1348, 1017)
        Me.RtbData.TabIndex = 1
        Me.RtbData.Text = ""
        '
        'TpLogError
        '
        Me.TpLogError.Controls.Add(Me.RtbError)
        Me.TpLogError.Location = New System.Drawing.Point(4, 4)
        Me.TpLogError.Name = "TpLogError"
        Me.TpLogError.Size = New System.Drawing.Size(1354, 1023)
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
        Me.RtbError.Size = New System.Drawing.Size(1354, 1023)
        Me.RtbError.TabIndex = 1
        Me.RtbError.Text = ""
        '
        'TpOptions
        '
        Me.TpOptions.Controls.Add(Me.TcOpt)
        Me.TpOptions.Location = New System.Drawing.Point(4, 29)
        Me.TpOptions.Name = "TpOptions"
        Me.TpOptions.Size = New System.Drawing.Size(1392, 1037)
        Me.TpOptions.TabIndex = 3
        Me.TpOptions.Text = "Settings"
        Me.TpOptions.UseVisualStyleBackColor = True
        '
        'TcOpt
        '
        Me.TcOpt.Controls.Add(Me.TpOptMain)
        Me.TcOpt.Controls.Add(Me.TpOptDaily)
        Me.TcOpt.Controls.Add(Me.TpOptHourly)
        Me.TcOpt.Controls.Add(Me.TpOptNowCast)
        Me.TcOpt.Dock = System.Windows.Forms.DockStyle.Top
        Me.TcOpt.Location = New System.Drawing.Point(0, 0)
        Me.TcOpt.Name = "TcOpt"
        Me.TcOpt.SelectedIndex = 0
        Me.TcOpt.Size = New System.Drawing.Size(1392, 1006)
        Me.TcOpt.TabIndex = 0
        '
        'TpOptMain
        '
        Me.TpOptMain.Controls.Add(Me.PnlSettings)
        Me.TpOptMain.Location = New System.Drawing.Point(4, 29)
        Me.TpOptMain.Name = "TpOptMain"
        Me.TpOptMain.Size = New System.Drawing.Size(1384, 973)
        Me.TpOptMain.TabIndex = 2
        Me.TpOptMain.Text = "Main Settings"
        Me.TpOptMain.UseVisualStyleBackColor = True
        '
        'PnlSettings
        '
        Me.PnlSettings.BackColor = System.Drawing.Color.Linen
        Me.PnlSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PnlSettings.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PnlSettings.Controls.Add(Me.GroupBox5)
        Me.PnlSettings.Controls.Add(Me.GroupBox4)
        Me.PnlSettings.Controls.Add(Me.GroupBox3)
        Me.PnlSettings.Controls.Add(Me.GroupBox2)
        Me.PnlSettings.Controls.Add(Me.GroupBox1)
        Me.PnlSettings.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlSettings.Location = New System.Drawing.Point(0, 0)
        Me.PnlSettings.Name = "PnlSettings"
        Me.PnlSettings.Size = New System.Drawing.Size(1384, 970)
        Me.PnlSettings.TabIndex = 1
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GroupBox5.Controls.Add(Me.Label13)
        Me.GroupBox5.Controls.Add(Me.NumNowcastInterval)
        Me.GroupBox5.Controls.Add(Me.Label12)
        Me.GroupBox5.Controls.Add(Me.NumHourlyInterval)
        Me.GroupBox5.Controls.Add(Me.Label5)
        Me.GroupBox5.Controls.Add(Me.NumDailyInterval)
        Me.GroupBox5.Location = New System.Drawing.Point(721, 527)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(243, 135)
        Me.GroupBox5.TabIndex = 23
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Update Intervals (Minutes)"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(26, 86)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(70, 20)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "Nowcast"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NumNowcastInterval
        '
        Me.NumNowcastInterval.Location = New System.Drawing.Point(104, 83)
        Me.NumNowcastInterval.Maximum = New Decimal(New Integer() {240, 0, 0, 0})
        Me.NumNowcastInterval.Name = "NumNowcastInterval"
        Me.NumNowcastInterval.Size = New System.Drawing.Size(88, 26)
        Me.NumNowcastInterval.TabIndex = 7
        Me.NumNowcastInterval.Tag = "2"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(40, 57)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(54, 20)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Hourly"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NumHourlyInterval
        '
        Me.NumHourlyInterval.Location = New System.Drawing.Point(104, 54)
        Me.NumHourlyInterval.Maximum = New Decimal(New Integer() {240, 0, 0, 0})
        Me.NumHourlyInterval.Name = "NumHourlyInterval"
        Me.NumHourlyInterval.Size = New System.Drawing.Size(88, 26)
        Me.NumHourlyInterval.TabIndex = 5
        Me.NumHourlyInterval.Tag = "1"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(52, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 20)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Daily"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NumDailyInterval
        '
        Me.NumDailyInterval.Location = New System.Drawing.Point(104, 25)
        Me.NumDailyInterval.Maximum = New Decimal(New Integer() {240, 0, 0, 0})
        Me.NumDailyInterval.Name = "NumDailyInterval"
        Me.NumDailyInterval.Size = New System.Drawing.Size(88, 26)
        Me.NumDailyInterval.TabIndex = 3
        Me.NumDailyInterval.Tag = "0"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GroupBox4.Controls.Add(Me.ChkFetchNowcast)
        Me.GroupBox4.Controls.Add(Me.ChkFetchHourly)
        Me.GroupBox4.Controls.Add(Me.ChkFetchDaily)
        Me.GroupBox4.Location = New System.Drawing.Point(415, 557)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(302, 75)
        Me.GroupBox4.TabIndex = 22
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Fetch Data"
        '
        'ChkFetchNowcast
        '
        Me.ChkFetchNowcast.AutoSize = True
        Me.ChkFetchNowcast.Location = New System.Drawing.Point(188, 25)
        Me.ChkFetchNowcast.Name = "ChkFetchNowcast"
        Me.ChkFetchNowcast.Size = New System.Drawing.Size(96, 24)
        Me.ChkFetchNowcast.TabIndex = 2
        Me.ChkFetchNowcast.Tag = "2"
        Me.ChkFetchNowcast.Text = "Nowcast"
        Me.ChkFetchNowcast.UseVisualStyleBackColor = True
        '
        'ChkFetchHourly
        '
        Me.ChkFetchHourly.AutoSize = True
        Me.ChkFetchHourly.Location = New System.Drawing.Point(98, 25)
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
        Me.ChkFetchDaily.Location = New System.Drawing.Point(16, 25)
        Me.ChkFetchDaily.Name = "ChkFetchDaily"
        Me.ChkFetchDaily.Size = New System.Drawing.Size(69, 24)
        Me.ChkFetchDaily.TabIndex = 0
        Me.ChkFetchDaily.Tag = "0"
        Me.ChkFetchDaily.Text = "Daily"
        Me.ChkFetchDaily.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.RbUnitSI)
        Me.GroupBox3.Controls.Add(Me.RbUnitUS)
        Me.GroupBox3.Location = New System.Drawing.Point(782, 331)
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
        Me.RbUnitUS.Location = New System.Drawing.Point(22, 25)
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
        Me.GroupBox2.Location = New System.Drawing.Point(415, 444)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(550, 69)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Security"
        '
        'TxtApiKey
        '
        Me.TxtApiKey.Location = New System.Drawing.Point(88, 22)
        Me.TxtApiKey.MaxLength = 40
        Me.TxtApiKey.Name = "TxtApiKey"
        Me.TxtApiKey.Size = New System.Drawing.Size(439, 26)
        Me.TxtApiKey.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 25)
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
        Me.GroupBox1.Location = New System.Drawing.Point(415, 304)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(302, 128)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Location"
        '
        'TxtLocationId
        '
        Me.TxtLocationId.Enabled = False
        Me.TxtLocationId.Location = New System.Drawing.Point(110, 88)
        Me.TxtLocationId.Name = "TxtLocationId"
        Me.TxtLocationId.Size = New System.Drawing.Size(168, 26)
        Me.TxtLocationId.TabIndex = 5
        '
        'NumLongitude
        '
        Me.NumLongitude.DecimalPlaces = 7
        Me.NumLongitude.Location = New System.Drawing.Point(110, 55)
        Me.NumLongitude.Maximum = New Decimal(New Integer() {180, 0, 0, 0})
        Me.NumLongitude.Minimum = New Decimal(New Integer() {180, 0, 0, -2147483648})
        Me.NumLongitude.Name = "NumLongitude"
        Me.NumLongitude.Size = New System.Drawing.Size(166, 26)
        Me.NumLongitude.TabIndex = 4
        Me.NumLongitude.Tag = "1"
        '
        'NumLatiutude
        '
        Me.NumLatiutude.DecimalPlaces = 7
        Me.NumLatiutude.Location = New System.Drawing.Point(110, 25)
        Me.NumLatiutude.Maximum = New Decimal(New Integer() {89, 0, 0, 0})
        Me.NumLatiutude.Minimum = New Decimal(New Integer() {87, 0, 0, -2147483648})
        Me.NumLatiutude.Name = "NumLatiutude"
        Me.NumLatiutude.Size = New System.Drawing.Size(166, 26)
        Me.NumLatiutude.TabIndex = 3
        Me.NumLatiutude.Tag = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Location ID"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 58)
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
        'TpOptDaily
        '
        Me.TpOptDaily.BackColor = System.Drawing.Color.Linen
        Me.TpOptDaily.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TpOptDaily.Controls.Add(Me.PnlDailyForecast)
        Me.TpOptDaily.Location = New System.Drawing.Point(4, 29)
        Me.TpOptDaily.Name = "TpOptDaily"
        Me.TpOptDaily.Padding = New System.Windows.Forms.Padding(3)
        Me.TpOptDaily.Size = New System.Drawing.Size(1384, 973)
        Me.TpOptDaily.TabIndex = 0
        Me.TpOptDaily.Text = "Daily"
        '
        'PnlDailyForecast
        '
        Me.PnlDailyForecast.BackColor = System.Drawing.Color.Silver
        Me.PnlDailyForecast.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PnlDailyForecast.Controls.Add(Me.GbDailyFields)
        Me.PnlDailyForecast.Controls.Add(Me.ChkAllDaily)
        Me.PnlDailyForecast.Location = New System.Drawing.Point(430, 301)
        Me.PnlDailyForecast.Name = "PnlDailyForecast"
        Me.PnlDailyForecast.Size = New System.Drawing.Size(520, 366)
        Me.PnlDailyForecast.TabIndex = 21
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
        Me.GbDailyFields.Location = New System.Drawing.Point(21, 12)
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
        Me.ChkTemp.Location = New System.Drawing.Point(20, 25)
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
        Me.ChkPrecip.Location = New System.Drawing.Point(20, 249)
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
        Me.ChkVis.Location = New System.Drawing.Point(238, 152)
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
        Me.ChkBP.Location = New System.Drawing.Point(20, 217)
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
        Me.ChkWindDir.Location = New System.Drawing.Point(20, 185)
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
        Me.ChkWindSpeed.Location = New System.Drawing.Point(20, 152)
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
        Me.ChkHumidity.Location = New System.Drawing.Point(20, 122)
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
        Me.ChkSunset.Location = New System.Drawing.Point(238, 122)
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
        Me.ChkDewpoint.Location = New System.Drawing.Point(20, 89)
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
        Me.ChkFeelsLike.Location = New System.Drawing.Point(20, 57)
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
        Me.ChkAllDaily.Location = New System.Drawing.Point(98, 325)
        Me.ChkAllDaily.Name = "ChkAllDaily"
        Me.ChkAllDaily.Size = New System.Drawing.Size(319, 24)
        Me.ChkAllDaily.TabIndex = 18
        Me.ChkAllDaily.Text = "Check/Uncheck All Daily Forecast Fields"
        Me.ChkAllDaily.UseVisualStyleBackColor = True
        '
        'TpOptHourly
        '
        Me.TpOptHourly.BackColor = System.Drawing.Color.Linen
        Me.TpOptHourly.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TpOptHourly.Controls.Add(Me.PnlHourlyForecast)
        Me.TpOptHourly.Location = New System.Drawing.Point(4, 29)
        Me.TpOptHourly.Name = "TpOptHourly"
        Me.TpOptHourly.Padding = New System.Windows.Forms.Padding(3)
        Me.TpOptHourly.Size = New System.Drawing.Size(1384, 973)
        Me.TpOptHourly.TabIndex = 1
        Me.TpOptHourly.Text = "Hourly"
        '
        'PnlHourlyForecast
        '
        Me.PnlHourlyForecast.BackColor = System.Drawing.Color.Silver
        Me.PnlHourlyForecast.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PnlHourlyForecast.Controls.Add(Me.ChkAllHourly)
        Me.PnlHourlyForecast.Controls.Add(Me.GbHourlyFields)
        Me.PnlHourlyForecast.Location = New System.Drawing.Point(333, 65)
        Me.PnlHourlyForecast.Name = "PnlHourlyForecast"
        Me.PnlHourlyForecast.Size = New System.Drawing.Size(715, 838)
        Me.PnlHourlyForecast.TabIndex = 22
        '
        'ChkAllHourly
        '
        Me.ChkAllHourly.AutoSize = True
        Me.ChkAllHourly.Location = New System.Drawing.Point(200, 802)
        Me.ChkAllHourly.Name = "ChkAllHourly"
        Me.ChkAllHourly.Size = New System.Drawing.Size(330, 24)
        Me.ChkAllHourly.TabIndex = 19
        Me.ChkAllHourly.Text = "Check/Uncheck All Hourly Forecast Fields"
        Me.ChkAllHourly.UseVisualStyleBackColor = True
        '
        'GbHourlyFields
        '
        Me.GbHourlyFields.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GbHourlyFields.Controls.Add(Me.ChkHrHailRisk)
        Me.GbHourlyFields.Controls.Add(Me.ChkHrRiskScore)
        Me.GbHourlyFields.Controls.Add(Me.ChkHrRiskConfidence)
        Me.GbHourlyFields.Controls.Add(Me.ChkHrRiskCondition)
        Me.GbHourlyFields.Controls.Add(Me.ChkHrRoadRisk)
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
        Me.GbHourlyFields.Location = New System.Drawing.Point(16, 12)
        Me.GbHourlyFields.Name = "GbHourlyFields"
        Me.GbHourlyFields.Size = New System.Drawing.Size(680, 769)
        Me.GbHourlyFields.TabIndex = 0
        Me.GbHourlyFields.TabStop = False
        Me.GbHourlyFields.Text = "Hourly Forecast Fields"
        '
        'ChkHrHailRisk
        '
        Me.ChkHrHailRisk.AutoSize = True
        Me.ChkHrHailRisk.Location = New System.Drawing.Point(429, 252)
        Me.ChkHrHailRisk.Name = "ChkHrHailRisk"
        Me.ChkHrHailRisk.Size = New System.Drawing.Size(97, 24)
        Me.ChkHrHailRisk.TabIndex = 70
        Me.ChkHrHailRisk.Tag = "62"
        Me.ChkHrHailRisk.Text = "Hail Risk"
        Me.ChkHrHailRisk.UseVisualStyleBackColor = True
        '
        'ChkHrRiskScore
        '
        Me.ChkHrRiskScore.AutoSize = True
        Me.ChkHrRiskScore.Location = New System.Drawing.Point(183, 728)
        Me.ChkHrRiskScore.Name = "ChkHrRiskScore"
        Me.ChkHrRiskScore.Size = New System.Drawing.Size(112, 24)
        Me.ChkHrRiskScore.TabIndex = 69
        Me.ChkHrRiskScore.Tag = "59"
        Me.ChkHrRiskScore.Text = "Risk Score"
        Me.ChkHrRiskScore.UseVisualStyleBackColor = True
        '
        'ChkHrRiskConfidence
        '
        Me.ChkHrRiskConfidence.AutoSize = True
        Me.ChkHrRiskConfidence.Location = New System.Drawing.Point(320, 728)
        Me.ChkHrRiskConfidence.Name = "ChkHrRiskConfidence"
        Me.ChkHrRiskConfidence.Size = New System.Drawing.Size(151, 24)
        Me.ChkHrRiskConfidence.TabIndex = 68
        Me.ChkHrRiskConfidence.Tag = "60"
        Me.ChkHrRiskConfidence.Text = "Risk Confidence"
        Me.ChkHrRiskConfidence.UseVisualStyleBackColor = True
        '
        'ChkHrRiskCondition
        '
        Me.ChkHrRiskCondition.AutoSize = True
        Me.ChkHrRiskCondition.Location = New System.Drawing.Point(494, 728)
        Me.ChkHrRiskCondition.Name = "ChkHrRiskCondition"
        Me.ChkHrRiskCondition.Size = New System.Drawing.Size(137, 24)
        Me.ChkHrRiskCondition.TabIndex = 67
        Me.ChkHrRiskCondition.Tag = "61"
        Me.ChkHrRiskCondition.Text = "Risk Condition"
        Me.ChkHrRiskCondition.UseVisualStyleBackColor = True
        '
        'ChkHrRoadRisk
        '
        Me.ChkHrRoadRisk.AutoSize = True
        Me.ChkHrRoadRisk.Location = New System.Drawing.Point(50, 728)
        Me.ChkHrRoadRisk.Name = "ChkHrRoadRisk"
        Me.ChkHrRoadRisk.Size = New System.Drawing.Size(109, 24)
        Me.ChkHrRoadRisk.TabIndex = 66
        Me.ChkHrRoadRisk.Tag = "58"
        Me.ChkHrRoadRisk.Text = "Road Risk"
        Me.ChkHrRoadRisk.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(64, 705)
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
        Me.ChkHourAqiO3.Location = New System.Drawing.Point(278, 594)
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
        Me.ChkHourAqiNo2.Location = New System.Drawing.Point(550, 594)
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
        Me.ChkHourEpaAqi.Location = New System.Drawing.Point(32, 629)
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
        Me.ChkHourEpaConcern.Location = New System.Drawing.Point(188, 629)
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
        Me.ChkHourChinaAqi.Location = New System.Drawing.Point(32, 665)
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
        Me.ChkHourChinaConcern.Location = New System.Drawing.Point(188, 665)
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
        Me.ChkHourTreeAsh.Location = New System.Drawing.Point(234, 355)
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
        Me.ChkHourTreeBeech.Location = New System.Drawing.Point(406, 355)
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
        Me.ChkHourTreeHickory.Location = New System.Drawing.Point(72, 462)
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
        Me.ChkHourTreeJuniper.Location = New System.Drawing.Point(234, 462)
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
        Me.ChkHourTreeMahogany.Location = New System.Drawing.Point(406, 462)
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
        Me.ChkHourTreeMaple.Location = New System.Drawing.Point(72, 495)
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
        Me.ChkHourTreeMulberry.Location = New System.Drawing.Point(234, 495)
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
        Me.ChkHourTreeOak.Location = New System.Drawing.Point(406, 495)
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
        Me.ChkHourTreePine.Location = New System.Drawing.Point(542, 355)
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
        Me.ChkHourTreeSycamore.Location = New System.Drawing.Point(542, 462)
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
        Me.ChkHourTreeWalnut.Location = New System.Drawing.Point(542, 495)
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
        Me.ChkHourTreeAcacia.Location = New System.Drawing.Point(72, 355)
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
        Me.Label7.Location = New System.Drawing.Point(64, 569)
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
        Me.Label6.Location = New System.Drawing.Point(64, 295)
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
        Me.ChkHourGrassPollen.Location = New System.Drawing.Point(460, 323)
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
        Me.ChkHourTreePollen.Location = New System.Drawing.Point(94, 323)
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
        Me.ChkHourSunrise.Location = New System.Drawing.Point(200, 63)
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
        Me.ChkHourCloudCover.Location = New System.Drawing.Point(200, 138)
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
        Me.ChkHourCloudBase.Location = New System.Drawing.Point(429, 138)
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
        Me.ChkHourCloudCeil.Location = New System.Drawing.Point(200, 177)
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
        Me.ChkHourMoonPhase.Location = New System.Drawing.Point(200, 215)
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
        Me.ChkHourWxCode.Location = New System.Drawing.Point(200, 252)
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
        Me.ChkHourVis.Location = New System.Drawing.Point(200, 102)
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
        Me.ChkHourPrecipProb.Location = New System.Drawing.Point(200, 25)
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
        Me.ChkHourFeelsLike.Location = New System.Drawing.Point(16, 63)
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
        Me.ChkHourWindSpeed.Location = New System.Drawing.Point(429, 102)
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
        Me.ChkHourWindDir.Location = New System.Drawing.Point(16, 138)
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
        Me.ChkHourWindGust.Location = New System.Drawing.Point(16, 177)
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
        Me.ChkHourPrecip.Location = New System.Drawing.Point(16, 215)
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
        Me.ChkHourPrecipType.Location = New System.Drawing.Point(16, 252)
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
        Me.ChkHourRH.Location = New System.Drawing.Point(16, 102)
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
        Me.ChkHourTemp.Location = New System.Drawing.Point(16, 25)
        Me.ChkHourTemp.Name = "ChkHourTemp"
        Me.ChkHourTemp.Size = New System.Drawing.Size(126, 24)
        Me.ChkHourTemp.TabIndex = 0
        Me.ChkHourTemp.Tag = "0"
        Me.ChkHourTemp.Text = "Temperature"
        Me.ChkHourTemp.UseVisualStyleBackColor = True
        '
        'TpOptNowCast
        '
        Me.TpOptNowCast.BackColor = System.Drawing.Color.Linen
        Me.TpOptNowCast.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TpOptNowCast.Controls.Add(Me.Panel1)
        Me.TpOptNowCast.Location = New System.Drawing.Point(4, 29)
        Me.TpOptNowCast.Name = "TpOptNowCast"
        Me.TpOptNowCast.Size = New System.Drawing.Size(1384, 973)
        Me.TpOptNowCast.TabIndex = 3
        Me.TpOptNowCast.Text = "Nowcast"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.ChkUncheckAllNowcast)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.NumNcTimeStep)
        Me.Panel1.Controls.Add(Me.ChkAllNowcast)
        Me.Panel1.Controls.Add(Me.GbNowcast)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(200, 189)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(980, 591)
        Me.Panel1.TabIndex = 23
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(375, 536)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(133, 17)
        Me.Label14.TabIndex = 25
        Me.Label14.Text = "Time step (minutes)"
        '
        'NumNcTimeStep
        '
        Me.NumNcTimeStep.Location = New System.Drawing.Point(531, 533)
        Me.NumNcTimeStep.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.NumNcTimeStep.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumNcTimeStep.Name = "NumNcTimeStep"
        Me.NumNcTimeStep.Size = New System.Drawing.Size(70, 23)
        Me.NumNcTimeStep.TabIndex = 0
        Me.NumNcTimeStep.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'ChkAllNowcast
        '
        Me.ChkAllNowcast.AutoSize = True
        Me.ChkAllNowcast.Location = New System.Drawing.Point(340, 562)
        Me.ChkAllNowcast.Name = "ChkAllNowcast"
        Me.ChkAllNowcast.Size = New System.Drawing.Size(92, 21)
        Me.ChkAllNowcast.TabIndex = 1
        Me.ChkAllNowcast.Text = "Check All"
        Me.ChkAllNowcast.UseVisualStyleBackColor = True
        '
        'GbNowcast
        '
        Me.GbNowcast.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GbNowcast.Controls.Add(Me.ChkNcHailRisk)
        Me.GbNowcast.Controls.Add(Me.ChkNcRiskScore)
        Me.GbNowcast.Controls.Add(Me.ChkNcRiskConfidence)
        Me.GbNowcast.Controls.Add(Me.ChkNcRiskCondition)
        Me.GbNowcast.Controls.Add(Me.ChkNcRoadRisk)
        Me.GbNowcast.Controls.Add(Me.ChkNcPm25)
        Me.GbNowcast.Controls.Add(Me.ChkNcO3)
        Me.GbNowcast.Controls.Add(Me.ChkNcNo2)
        Me.GbNowcast.Controls.Add(Me.ChkNcCo)
        Me.GbNowcast.Controls.Add(Me.ChkNcSo2)
        Me.GbNowcast.Controls.Add(Me.ChkNcEpaAqi)
        Me.GbNowcast.Controls.Add(Me.ChkNcEpaPollutant)
        Me.GbNowcast.Controls.Add(Me.ChkNcEpaConcern)
        Me.GbNowcast.Controls.Add(Me.ChkNcChinaAqi)
        Me.GbNowcast.Controls.Add(Me.ChkNcChinaConcern)
        Me.GbNowcast.Controls.Add(Me.ChkNcChinaPollutant)
        Me.GbNowcast.Controls.Add(Me.ChkNcPm10)
        Me.GbNowcast.Controls.Add(Me.ChkNcGrass)
        Me.GbNowcast.Controls.Add(Me.ChkNcRagweed)
        Me.GbNowcast.Controls.Add(Me.ChkNcAsh)
        Me.GbNowcast.Controls.Add(Me.ChkNcBeech)
        Me.GbNowcast.Controls.Add(Me.ChkNcBirch)
        Me.GbNowcast.Controls.Add(Me.ChkNcCedar)
        Me.GbNowcast.Controls.Add(Me.ChkNcCypress)
        Me.GbNowcast.Controls.Add(Me.ChkNcElder)
        Me.GbNowcast.Controls.Add(Me.ChkNcElm)
        Me.GbNowcast.Controls.Add(Me.ChkNcHemlock)
        Me.GbNowcast.Controls.Add(Me.ChkNcHickory)
        Me.GbNowcast.Controls.Add(Me.ChkNcJuniper)
        Me.GbNowcast.Controls.Add(Me.ChkNcMahogany)
        Me.GbNowcast.Controls.Add(Me.ChkNcMaple)
        Me.GbNowcast.Controls.Add(Me.ChkNcMulberry)
        Me.GbNowcast.Controls.Add(Me.ChkNcOak)
        Me.GbNowcast.Controls.Add(Me.ChkNcPine)
        Me.GbNowcast.Controls.Add(Me.ChkNcCottonwood)
        Me.GbNowcast.Controls.Add(Me.ChkNcSpruce)
        Me.GbNowcast.Controls.Add(Me.ChkNcSycamore)
        Me.GbNowcast.Controls.Add(Me.ChkNcWalnut)
        Me.GbNowcast.Controls.Add(Me.ChkNcWillow)
        Me.GbNowcast.Controls.Add(Me.ChkNcAcacia)
        Me.GbNowcast.Controls.Add(Me.ChkNcGrassPollen)
        Me.GbNowcast.Controls.Add(Me.ChkNcWeedPollen)
        Me.GbNowcast.Controls.Add(Me.ChkNcTreePollen)
        Me.GbNowcast.Controls.Add(Me.ChkNcSunrise)
        Me.GbNowcast.Controls.Add(Me.ChkNcCloudCover)
        Me.GbNowcast.Controls.Add(Me.ChkNcSunset)
        Me.GbNowcast.Controls.Add(Me.ChkNcCloudBase)
        Me.GbNowcast.Controls.Add(Me.ChkNcCloudCeil)
        Me.GbNowcast.Controls.Add(Me.ChkNcSSR)
        Me.GbNowcast.Controls.Add(Me.ChkNcWxCode)
        Me.GbNowcast.Controls.Add(Me.ChkNcVis)
        Me.GbNowcast.Controls.Add(Me.ChkNcFeelsLike)
        Me.GbNowcast.Controls.Add(Me.ChkNcWindSpeed)
        Me.GbNowcast.Controls.Add(Me.ChkNcDewpoint)
        Me.GbNowcast.Controls.Add(Me.ChkNcWindDir)
        Me.GbNowcast.Controls.Add(Me.ChkNcWindGust)
        Me.GbNowcast.Controls.Add(Me.ChkNcBP)
        Me.GbNowcast.Controls.Add(Me.ChkNcPrecip)
        Me.GbNowcast.Controls.Add(Me.ChkNcPrecipType)
        Me.GbNowcast.Controls.Add(Me.ChkNcRH)
        Me.GbNowcast.Controls.Add(Me.ChkNcTemp)
        Me.GbNowcast.Location = New System.Drawing.Point(16, 9)
        Me.GbNowcast.Name = "GbNowcast"
        Me.GbNowcast.Size = New System.Drawing.Size(912, 518)
        Me.GbNowcast.TabIndex = 0
        Me.GbNowcast.TabStop = False
        Me.GbNowcast.Tag = "47"
        Me.GbNowcast.Text = "Nowcast Forecast Fields"
        '
        'ChkNcHailRisk
        '
        Me.ChkNcHailRisk.AutoSize = True
        Me.ChkNcHailRisk.Location = New System.Drawing.Point(283, 111)
        Me.ChkNcHailRisk.Name = "ChkNcHailRisk"
        Me.ChkNcHailRisk.Size = New System.Drawing.Size(89, 21)
        Me.ChkNcHailRisk.TabIndex = 18
        Me.ChkNcHailRisk.Tag = "18"
        Me.ChkNcHailRisk.Text = "Hail Risk"
        Me.ChkNcHailRisk.UseVisualStyleBackColor = True
        '
        'ChkNcRiskScore
        '
        Me.ChkNcRiskScore.AutoSize = True
        Me.ChkNcRiskScore.Location = New System.Drawing.Point(663, 421)
        Me.ChkNcRiskScore.Name = "ChkNcRiskScore"
        Me.ChkNcRiskScore.Size = New System.Drawing.Size(102, 21)
        Me.ChkNcRiskScore.TabIndex = 58
        Me.ChkNcRiskScore.Tag = "58"
        Me.ChkNcRiskScore.Text = "Risk Score"
        Me.ChkNcRiskScore.UseVisualStyleBackColor = True
        '
        'ChkNcRiskConfidence
        '
        Me.ChkNcRiskConfidence.AutoSize = True
        Me.ChkNcRiskConfidence.Location = New System.Drawing.Point(663, 452)
        Me.ChkNcRiskConfidence.Name = "ChkNcRiskConfidence"
        Me.ChkNcRiskConfidence.Size = New System.Drawing.Size(136, 21)
        Me.ChkNcRiskConfidence.TabIndex = 59
        Me.ChkNcRiskConfidence.Tag = "59"
        Me.ChkNcRiskConfidence.Text = "Risk Confidence"
        Me.ChkNcRiskConfidence.UseVisualStyleBackColor = True
        '
        'ChkNcRiskCondition
        '
        Me.ChkNcRiskCondition.AutoSize = True
        Me.ChkNcRiskCondition.Location = New System.Drawing.Point(663, 479)
        Me.ChkNcRiskCondition.Name = "ChkNcRiskCondition"
        Me.ChkNcRiskCondition.Size = New System.Drawing.Size(124, 21)
        Me.ChkNcRiskCondition.TabIndex = 60
        Me.ChkNcRiskCondition.Tag = "60"
        Me.ChkNcRiskCondition.Text = "Risk Condition"
        Me.ChkNcRiskCondition.UseVisualStyleBackColor = True
        '
        'ChkNcRoadRisk
        '
        Me.ChkNcRoadRisk.AutoSize = True
        Me.ChkNcRoadRisk.Enabled = False
        Me.ChkNcRoadRisk.Location = New System.Drawing.Point(663, 390)
        Me.ChkNcRoadRisk.Name = "ChkNcRoadRisk"
        Me.ChkNcRoadRisk.Size = New System.Drawing.Size(99, 21)
        Me.ChkNcRoadRisk.TabIndex = 57
        Me.ChkNcRoadRisk.Tag = "57"
        Me.ChkNcRoadRisk.Text = "Road Risk"
        Me.ChkNcRoadRisk.UseVisualStyleBackColor = True
        '
        'ChkNcPm25
        '
        Me.ChkNcPm25.AutoSize = True
        Me.ChkNcPm25.Location = New System.Drawing.Point(663, 49)
        Me.ChkNcPm25.Name = "ChkNcPm25"
        Me.ChkNcPm25.Size = New System.Drawing.Size(70, 21)
        Me.ChkNcPm25.TabIndex = 46
        Me.ChkNcPm25.Tag = "46"
        Me.ChkNcPm25.Text = "PM25"
        Me.ChkNcPm25.UseVisualStyleBackColor = True
        '
        'ChkNcO3
        '
        Me.ChkNcO3.AutoSize = True
        Me.ChkNcO3.Location = New System.Drawing.Point(663, 80)
        Me.ChkNcO3.Name = "ChkNcO3"
        Me.ChkNcO3.Size = New System.Drawing.Size(53, 21)
        Me.ChkNcO3.TabIndex = 47
        Me.ChkNcO3.Tag = "47"
        Me.ChkNcO3.Text = "O3"
        Me.ChkNcO3.UseVisualStyleBackColor = True
        '
        'ChkNcNo2
        '
        Me.ChkNcNo2.AutoSize = True
        Me.ChkNcNo2.Location = New System.Drawing.Point(663, 173)
        Me.ChkNcNo2.Name = "ChkNcNo2"
        Me.ChkNcNo2.Size = New System.Drawing.Size(63, 21)
        Me.ChkNcNo2.TabIndex = 50
        Me.ChkNcNo2.Tag = "50"
        Me.ChkNcNo2.Text = "NO2"
        Me.ChkNcNo2.UseVisualStyleBackColor = True
        '
        'ChkNcCo
        '
        Me.ChkNcCo.AutoSize = True
        Me.ChkNcCo.Location = New System.Drawing.Point(663, 111)
        Me.ChkNcCo.Name = "ChkNcCo"
        Me.ChkNcCo.Size = New System.Drawing.Size(54, 21)
        Me.ChkNcCo.TabIndex = 48
        Me.ChkNcCo.Tag = "48"
        Me.ChkNcCo.Text = "CO"
        Me.ChkNcCo.UseVisualStyleBackColor = True
        '
        'ChkNcSo2
        '
        Me.ChkNcSo2.AutoSize = True
        Me.ChkNcSo2.Location = New System.Drawing.Point(663, 142)
        Me.ChkNcSo2.Name = "ChkNcSo2"
        Me.ChkNcSo2.Size = New System.Drawing.Size(62, 21)
        Me.ChkNcSo2.TabIndex = 49
        Me.ChkNcSo2.Tag = "49"
        Me.ChkNcSo2.Text = "SO2"
        Me.ChkNcSo2.UseVisualStyleBackColor = True
        '
        'ChkNcEpaAqi
        '
        Me.ChkNcEpaAqi.AutoSize = True
        Me.ChkNcEpaAqi.Location = New System.Drawing.Point(663, 204)
        Me.ChkNcEpaAqi.Name = "ChkNcEpaAqi"
        Me.ChkNcEpaAqi.Size = New System.Drawing.Size(88, 21)
        Me.ChkNcEpaAqi.TabIndex = 51
        Me.ChkNcEpaAqi.Tag = "51"
        Me.ChkNcEpaAqi.Text = "EPA AQI"
        Me.ChkNcEpaAqi.UseVisualStyleBackColor = True
        '
        'ChkNcEpaPollutant
        '
        Me.ChkNcEpaPollutant.AutoSize = True
        Me.ChkNcEpaPollutant.Location = New System.Drawing.Point(663, 266)
        Me.ChkNcEpaPollutant.Name = "ChkNcEpaPollutant"
        Me.ChkNcEpaPollutant.Size = New System.Drawing.Size(172, 21)
        Me.ChkNcEpaPollutant.TabIndex = 53
        Me.ChkNcEpaPollutant.Tag = "53"
        Me.ChkNcEpaPollutant.Text = "EPA Primary Pollutant"
        Me.ChkNcEpaPollutant.UseVisualStyleBackColor = True
        '
        'ChkNcEpaConcern
        '
        Me.ChkNcEpaConcern.AutoSize = True
        Me.ChkNcEpaConcern.Location = New System.Drawing.Point(663, 235)
        Me.ChkNcEpaConcern.Name = "ChkNcEpaConcern"
        Me.ChkNcEpaConcern.Size = New System.Drawing.Size(163, 21)
        Me.ChkNcEpaConcern.TabIndex = 52
        Me.ChkNcEpaConcern.Tag = "52"
        Me.ChkNcEpaConcern.Text = "EPA Health Concern"
        Me.ChkNcEpaConcern.UseVisualStyleBackColor = True
        '
        'ChkNcChinaAqi
        '
        Me.ChkNcChinaAqi.AutoSize = True
        Me.ChkNcChinaAqi.Location = New System.Drawing.Point(663, 297)
        Me.ChkNcChinaAqi.Name = "ChkNcChinaAqi"
        Me.ChkNcChinaAqi.Size = New System.Drawing.Size(97, 21)
        Me.ChkNcChinaAqi.TabIndex = 54
        Me.ChkNcChinaAqi.Tag = "54"
        Me.ChkNcChinaAqi.Text = "China AQI"
        Me.ChkNcChinaAqi.UseVisualStyleBackColor = True
        '
        'ChkNcChinaConcern
        '
        Me.ChkNcChinaConcern.AutoSize = True
        Me.ChkNcChinaConcern.Location = New System.Drawing.Point(663, 328)
        Me.ChkNcChinaConcern.Name = "ChkNcChinaConcern"
        Me.ChkNcChinaConcern.Size = New System.Drawing.Size(172, 21)
        Me.ChkNcChinaConcern.TabIndex = 55
        Me.ChkNcChinaConcern.Tag = "55"
        Me.ChkNcChinaConcern.Text = "China Health Concern"
        Me.ChkNcChinaConcern.UseVisualStyleBackColor = True
        '
        'ChkNcChinaPollutant
        '
        Me.ChkNcChinaPollutant.AutoSize = True
        Me.ChkNcChinaPollutant.Location = New System.Drawing.Point(663, 359)
        Me.ChkNcChinaPollutant.Name = "ChkNcChinaPollutant"
        Me.ChkNcChinaPollutant.Size = New System.Drawing.Size(181, 21)
        Me.ChkNcChinaPollutant.TabIndex = 56
        Me.ChkNcChinaPollutant.Tag = "56"
        Me.ChkNcChinaPollutant.Text = "China Primary Pollutant"
        Me.ChkNcChinaPollutant.UseVisualStyleBackColor = True
        '
        'ChkNcPm10
        '
        Me.ChkNcPm10.AutoSize = True
        Me.ChkNcPm10.Location = New System.Drawing.Point(663, 18)
        Me.ChkNcPm10.Name = "ChkNcPm10"
        Me.ChkNcPm10.Size = New System.Drawing.Size(70, 21)
        Me.ChkNcPm10.TabIndex = 45
        Me.ChkNcPm10.Tag = "45"
        Me.ChkNcPm10.Text = "PM10"
        Me.ChkNcPm10.UseVisualStyleBackColor = True
        '
        'ChkNcGrass
        '
        Me.ChkNcGrass.AutoSize = True
        Me.ChkNcGrass.Location = New System.Drawing.Point(509, 297)
        Me.ChkNcGrass.Name = "ChkNcGrass"
        Me.ChkNcGrass.Size = New System.Drawing.Size(72, 21)
        Me.ChkNcGrass.TabIndex = 39
        Me.ChkNcGrass.Tag = "39"
        Me.ChkNcGrass.Text = "Grass"
        Me.ChkNcGrass.UseVisualStyleBackColor = True
        '
        'ChkNcRagweed
        '
        Me.ChkNcRagweed.AutoSize = True
        Me.ChkNcRagweed.Location = New System.Drawing.Point(509, 111)
        Me.ChkNcRagweed.Name = "ChkNcRagweed"
        Me.ChkNcRagweed.Size = New System.Drawing.Size(93, 21)
        Me.ChkNcRagweed.TabIndex = 33
        Me.ChkNcRagweed.Tag = "33"
        Me.ChkNcRagweed.Text = "Ragweed"
        Me.ChkNcRagweed.UseVisualStyleBackColor = True
        '
        'ChkNcAsh
        '
        Me.ChkNcAsh.AutoSize = True
        Me.ChkNcAsh.Location = New System.Drawing.Point(283, 421)
        Me.ChkNcAsh.Name = "ChkNcAsh"
        Me.ChkNcAsh.Size = New System.Drawing.Size(62, 21)
        Me.ChkNcAsh.TabIndex = 28
        Me.ChkNcAsh.Tag = "28"
        Me.ChkNcAsh.Text = "Ash "
        Me.ChkNcAsh.UseVisualStyleBackColor = True
        '
        'ChkNcBeech
        '
        Me.ChkNcBeech.AutoSize = True
        Me.ChkNcBeech.Location = New System.Drawing.Point(509, 142)
        Me.ChkNcBeech.Name = "ChkNcBeech"
        Me.ChkNcBeech.Size = New System.Drawing.Size(74, 21)
        Me.ChkNcBeech.TabIndex = 34
        Me.ChkNcBeech.Tag = "34"
        Me.ChkNcBeech.Text = "Beech"
        Me.ChkNcBeech.UseVisualStyleBackColor = True
        '
        'ChkNcBirch
        '
        Me.ChkNcBirch.AutoSize = True
        Me.ChkNcBirch.Location = New System.Drawing.Point(283, 266)
        Me.ChkNcBirch.Name = "ChkNcBirch"
        Me.ChkNcBirch.Size = New System.Drawing.Size(66, 21)
        Me.ChkNcBirch.TabIndex = 23
        Me.ChkNcBirch.Tag = "23"
        Me.ChkNcBirch.Text = "Birch"
        Me.ChkNcBirch.UseVisualStyleBackColor = True
        '
        'ChkNcCedar
        '
        Me.ChkNcCedar.AutoSize = True
        Me.ChkNcCedar.Location = New System.Drawing.Point(283, 452)
        Me.ChkNcCedar.Name = "ChkNcCedar"
        Me.ChkNcCedar.Size = New System.Drawing.Size(72, 21)
        Me.ChkNcCedar.TabIndex = 29
        Me.ChkNcCedar.Tag = "29"
        Me.ChkNcCedar.Text = "Cedar"
        Me.ChkNcCedar.UseVisualStyleBackColor = True
        '
        'ChkNcCypress
        '
        Me.ChkNcCypress.AutoSize = True
        Me.ChkNcCypress.Location = New System.Drawing.Point(509, 173)
        Me.ChkNcCypress.Name = "ChkNcCypress"
        Me.ChkNcCypress.Size = New System.Drawing.Size(85, 21)
        Me.ChkNcCypress.TabIndex = 35
        Me.ChkNcCypress.Tag = "35"
        Me.ChkNcCypress.Text = "Cypress"
        Me.ChkNcCypress.UseVisualStyleBackColor = True
        '
        'ChkNcElder
        '
        Me.ChkNcElder.AutoSize = True
        Me.ChkNcElder.Location = New System.Drawing.Point(283, 297)
        Me.ChkNcElder.Name = "ChkNcElder"
        Me.ChkNcElder.Size = New System.Drawing.Size(67, 21)
        Me.ChkNcElder.TabIndex = 24
        Me.ChkNcElder.Tag = "24"
        Me.ChkNcElder.Text = "Elder"
        Me.ChkNcElder.UseVisualStyleBackColor = True
        '
        'ChkNcElm
        '
        Me.ChkNcElm.AutoSize = True
        Me.ChkNcElm.Location = New System.Drawing.Point(509, 18)
        Me.ChkNcElm.Name = "ChkNcElm"
        Me.ChkNcElm.Size = New System.Drawing.Size(57, 21)
        Me.ChkNcElm.TabIndex = 30
        Me.ChkNcElm.Tag = "30"
        Me.ChkNcElm.Text = "Elm"
        Me.ChkNcElm.UseVisualStyleBackColor = True
        '
        'ChkNcHemlock
        '
        Me.ChkNcHemlock.AutoSize = True
        Me.ChkNcHemlock.Location = New System.Drawing.Point(509, 204)
        Me.ChkNcHemlock.Name = "ChkNcHemlock"
        Me.ChkNcHemlock.Size = New System.Drawing.Size(88, 21)
        Me.ChkNcHemlock.TabIndex = 36
        Me.ChkNcHemlock.Tag = "36"
        Me.ChkNcHemlock.Text = "Hemlock"
        Me.ChkNcHemlock.UseVisualStyleBackColor = True
        '
        'ChkNcHickory
        '
        Me.ChkNcHickory.AutoSize = True
        Me.ChkNcHickory.Location = New System.Drawing.Point(283, 328)
        Me.ChkNcHickory.Name = "ChkNcHickory"
        Me.ChkNcHickory.Size = New System.Drawing.Size(81, 21)
        Me.ChkNcHickory.TabIndex = 25
        Me.ChkNcHickory.Tag = "25"
        Me.ChkNcHickory.Text = "Hickory"
        Me.ChkNcHickory.UseVisualStyleBackColor = True
        '
        'ChkNcJuniper
        '
        Me.ChkNcJuniper.AutoSize = True
        Me.ChkNcJuniper.Location = New System.Drawing.Point(509, 49)
        Me.ChkNcJuniper.Name = "ChkNcJuniper"
        Me.ChkNcJuniper.Size = New System.Drawing.Size(81, 21)
        Me.ChkNcJuniper.TabIndex = 31
        Me.ChkNcJuniper.Tag = "31"
        Me.ChkNcJuniper.Text = "Juniper"
        Me.ChkNcJuniper.UseVisualStyleBackColor = True
        '
        'ChkNcMahogany
        '
        Me.ChkNcMahogany.AutoSize = True
        Me.ChkNcMahogany.Location = New System.Drawing.Point(509, 235)
        Me.ChkNcMahogany.Name = "ChkNcMahogany"
        Me.ChkNcMahogany.Size = New System.Drawing.Size(100, 21)
        Me.ChkNcMahogany.TabIndex = 37
        Me.ChkNcMahogany.Tag = "37"
        Me.ChkNcMahogany.Text = "Mahogany"
        Me.ChkNcMahogany.UseVisualStyleBackColor = True
        '
        'ChkNcMaple
        '
        Me.ChkNcMaple.AutoSize = True
        Me.ChkNcMaple.Location = New System.Drawing.Point(283, 359)
        Me.ChkNcMaple.Name = "ChkNcMaple"
        Me.ChkNcMaple.Size = New System.Drawing.Size(72, 21)
        Me.ChkNcMaple.TabIndex = 26
        Me.ChkNcMaple.Tag = "26"
        Me.ChkNcMaple.Text = "Maple"
        Me.ChkNcMaple.UseVisualStyleBackColor = True
        '
        'ChkNcMulberry
        '
        Me.ChkNcMulberry.AutoSize = True
        Me.ChkNcMulberry.Location = New System.Drawing.Point(509, 80)
        Me.ChkNcMulberry.Name = "ChkNcMulberry"
        Me.ChkNcMulberry.Size = New System.Drawing.Size(89, 21)
        Me.ChkNcMulberry.TabIndex = 32
        Me.ChkNcMulberry.Tag = "32"
        Me.ChkNcMulberry.Text = "Mulberry"
        Me.ChkNcMulberry.UseVisualStyleBackColor = True
        '
        'ChkNcOak
        '
        Me.ChkNcOak.AutoSize = True
        Me.ChkNcOak.Location = New System.Drawing.Point(509, 266)
        Me.ChkNcOak.Name = "ChkNcOak"
        Me.ChkNcOak.Size = New System.Drawing.Size(60, 21)
        Me.ChkNcOak.TabIndex = 38
        Me.ChkNcOak.Tag = "38"
        Me.ChkNcOak.Text = "Oak"
        Me.ChkNcOak.UseVisualStyleBackColor = True
        '
        'ChkNcPine
        '
        Me.ChkNcPine.AutoSize = True
        Me.ChkNcPine.Location = New System.Drawing.Point(509, 328)
        Me.ChkNcPine.Name = "ChkNcPine"
        Me.ChkNcPine.Size = New System.Drawing.Size(62, 21)
        Me.ChkNcPine.TabIndex = 40
        Me.ChkNcPine.Tag = "40"
        Me.ChkNcPine.Text = "Pine"
        Me.ChkNcPine.UseVisualStyleBackColor = True
        '
        'ChkNcCottonwood
        '
        Me.ChkNcCottonwood.AutoSize = True
        Me.ChkNcCottonwood.Location = New System.Drawing.Point(509, 359)
        Me.ChkNcCottonwood.Name = "ChkNcCottonwood"
        Me.ChkNcCottonwood.Size = New System.Drawing.Size(108, 21)
        Me.ChkNcCottonwood.TabIndex = 41
        Me.ChkNcCottonwood.Tag = "41"
        Me.ChkNcCottonwood.Text = "Cottonwood"
        Me.ChkNcCottonwood.UseVisualStyleBackColor = True
        '
        'ChkNcSpruce
        '
        Me.ChkNcSpruce.AutoSize = True
        Me.ChkNcSpruce.Location = New System.Drawing.Point(509, 390)
        Me.ChkNcSpruce.Name = "ChkNcSpruce"
        Me.ChkNcSpruce.Size = New System.Drawing.Size(79, 21)
        Me.ChkNcSpruce.TabIndex = 42
        Me.ChkNcSpruce.Tag = "42"
        Me.ChkNcSpruce.Text = "Spruce"
        Me.ChkNcSpruce.UseVisualStyleBackColor = True
        '
        'ChkNcSycamore
        '
        Me.ChkNcSycamore.AutoSize = True
        Me.ChkNcSycamore.Location = New System.Drawing.Point(509, 421)
        Me.ChkNcSycamore.Name = "ChkNcSycamore"
        Me.ChkNcSycamore.Size = New System.Drawing.Size(97, 21)
        Me.ChkNcSycamore.TabIndex = 43
        Me.ChkNcSycamore.Tag = "43"
        Me.ChkNcSycamore.Text = "Sycamore"
        Me.ChkNcSycamore.UseVisualStyleBackColor = True
        '
        'ChkNcWalnut
        '
        Me.ChkNcWalnut.AutoSize = True
        Me.ChkNcWalnut.Location = New System.Drawing.Point(509, 452)
        Me.ChkNcWalnut.Name = "ChkNcWalnut"
        Me.ChkNcWalnut.Size = New System.Drawing.Size(78, 21)
        Me.ChkNcWalnut.TabIndex = 44
        Me.ChkNcWalnut.Tag = "44"
        Me.ChkNcWalnut.Text = "Walnut"
        Me.ChkNcWalnut.UseVisualStyleBackColor = True
        '
        'ChkNcWillow
        '
        Me.ChkNcWillow.AutoSize = True
        Me.ChkNcWillow.Location = New System.Drawing.Point(283, 390)
        Me.ChkNcWillow.Name = "ChkNcWillow"
        Me.ChkNcWillow.Size = New System.Drawing.Size(73, 21)
        Me.ChkNcWillow.TabIndex = 27
        Me.ChkNcWillow.Tag = "27"
        Me.ChkNcWillow.Text = "Willow"
        Me.ChkNcWillow.UseVisualStyleBackColor = True
        '
        'ChkNcAcacia
        '
        Me.ChkNcAcacia.AutoSize = True
        Me.ChkNcAcacia.Location = New System.Drawing.Point(283, 235)
        Me.ChkNcAcacia.Name = "ChkNcAcacia"
        Me.ChkNcAcacia.Size = New System.Drawing.Size(76, 21)
        Me.ChkNcAcacia.TabIndex = 22
        Me.ChkNcAcacia.Tag = "22"
        Me.ChkNcAcacia.Text = "Acacia"
        Me.ChkNcAcacia.UseVisualStyleBackColor = True
        '
        'ChkNcGrassPollen
        '
        Me.ChkNcGrassPollen.AutoSize = True
        Me.ChkNcGrassPollen.Location = New System.Drawing.Point(283, 204)
        Me.ChkNcGrassPollen.Name = "ChkNcGrassPollen"
        Me.ChkNcGrassPollen.Size = New System.Drawing.Size(115, 21)
        Me.ChkNcGrassPollen.TabIndex = 21
        Me.ChkNcGrassPollen.Tag = "21"
        Me.ChkNcGrassPollen.Text = "Grass Pollen"
        Me.ChkNcGrassPollen.UseVisualStyleBackColor = True
        '
        'ChkNcWeedPollen
        '
        Me.ChkNcWeedPollen.AutoSize = True
        Me.ChkNcWeedPollen.Location = New System.Drawing.Point(283, 173)
        Me.ChkNcWeedPollen.Name = "ChkNcWeedPollen"
        Me.ChkNcWeedPollen.Size = New System.Drawing.Size(114, 21)
        Me.ChkNcWeedPollen.TabIndex = 20
        Me.ChkNcWeedPollen.Tag = "20"
        Me.ChkNcWeedPollen.Text = "Weed Pollen"
        Me.ChkNcWeedPollen.UseVisualStyleBackColor = True
        '
        'ChkNcTreePollen
        '
        Me.ChkNcTreePollen.AutoSize = True
        Me.ChkNcTreePollen.Location = New System.Drawing.Point(283, 142)
        Me.ChkNcTreePollen.Name = "ChkNcTreePollen"
        Me.ChkNcTreePollen.Size = New System.Drawing.Size(107, 21)
        Me.ChkNcTreePollen.TabIndex = 19
        Me.ChkNcTreePollen.Tag = "19"
        Me.ChkNcTreePollen.Text = "Tree Pollen"
        Me.ChkNcTreePollen.UseVisualStyleBackColor = True
        '
        'ChkNcSunrise
        '
        Me.ChkNcSunrise.AutoSize = True
        Me.ChkNcSunrise.Location = New System.Drawing.Point(68, 235)
        Me.ChkNcSunrise.Name = "ChkNcSunrise"
        Me.ChkNcSunrise.Size = New System.Drawing.Size(82, 21)
        Me.ChkNcSunrise.TabIndex = 7
        Me.ChkNcSunrise.Tag = "7"
        Me.ChkNcSunrise.Text = "Sunrise"
        Me.ChkNcSunrise.UseVisualStyleBackColor = True
        '
        'ChkNcCloudCover
        '
        Me.ChkNcCloudCover.AutoSize = True
        Me.ChkNcCloudCover.Location = New System.Drawing.Point(68, 297)
        Me.ChkNcCloudCover.Name = "ChkNcCloudCover"
        Me.ChkNcCloudCover.Size = New System.Drawing.Size(111, 21)
        Me.ChkNcCloudCover.TabIndex = 9
        Me.ChkNcCloudCover.Tag = "9"
        Me.ChkNcCloudCover.Text = "Cloud Cover"
        Me.ChkNcCloudCover.UseVisualStyleBackColor = True
        '
        'ChkNcSunset
        '
        Me.ChkNcSunset.AutoSize = True
        Me.ChkNcSunset.Location = New System.Drawing.Point(68, 390)
        Me.ChkNcSunset.Name = "ChkNcSunset"
        Me.ChkNcSunset.Size = New System.Drawing.Size(78, 21)
        Me.ChkNcSunset.TabIndex = 12
        Me.ChkNcSunset.Tag = "12"
        Me.ChkNcSunset.Text = "Sunset"
        Me.ChkNcSunset.UseVisualStyleBackColor = True
        '
        'ChkNcCloudBase
        '
        Me.ChkNcCloudBase.AutoSize = True
        Me.ChkNcCloudBase.Location = New System.Drawing.Point(283, 18)
        Me.ChkNcCloudBase.Name = "ChkNcCloudBase"
        Me.ChkNcCloudBase.Size = New System.Drawing.Size(106, 21)
        Me.ChkNcCloudBase.TabIndex = 15
        Me.ChkNcCloudBase.Tag = "15"
        Me.ChkNcCloudBase.Text = "Cloud Base"
        Me.ChkNcCloudBase.UseVisualStyleBackColor = True
        '
        'ChkNcCloudCeil
        '
        Me.ChkNcCloudCeil.AutoSize = True
        Me.ChkNcCloudCeil.Location = New System.Drawing.Point(68, 328)
        Me.ChkNcCloudCeil.Name = "ChkNcCloudCeil"
        Me.ChkNcCloudCeil.Size = New System.Drawing.Size(116, 21)
        Me.ChkNcCloudCeil.TabIndex = 10
        Me.ChkNcCloudCeil.Tag = "10"
        Me.ChkNcCloudCeil.Text = "Cloud Ceiling"
        Me.ChkNcCloudCeil.UseVisualStyleBackColor = True
        '
        'ChkNcSSR
        '
        Me.ChkNcSSR.AutoSize = True
        Me.ChkNcSSR.Location = New System.Drawing.Point(283, 80)
        Me.ChkNcSSR.Name = "ChkNcSSR"
        Me.ChkNcSSR.Size = New System.Drawing.Size(217, 21)
        Me.ChkNcSSR.TabIndex = 17
        Me.ChkNcSSR.Tag = "17"
        Me.ChkNcSSR.Text = "Surface Shortwave Radiation"
        Me.ChkNcSSR.UseVisualStyleBackColor = True
        '
        'ChkNcWxCode
        '
        Me.ChkNcWxCode.AutoSize = True
        Me.ChkNcWxCode.Location = New System.Drawing.Point(68, 359)
        Me.ChkNcWxCode.Name = "ChkNcWxCode"
        Me.ChkNcWxCode.Size = New System.Drawing.Size(125, 21)
        Me.ChkNcWxCode.TabIndex = 11
        Me.ChkNcWxCode.Tag = "11"
        Me.ChkNcWxCode.Text = "Weather Code"
        Me.ChkNcWxCode.UseVisualStyleBackColor = True
        '
        'ChkNcVis
        '
        Me.ChkNcVis.AutoSize = True
        Me.ChkNcVis.Location = New System.Drawing.Point(68, 266)
        Me.ChkNcVis.Name = "ChkNcVis"
        Me.ChkNcVis.Size = New System.Drawing.Size(84, 21)
        Me.ChkNcVis.TabIndex = 8
        Me.ChkNcVis.Tag = "8"
        Me.ChkNcVis.Text = "Visibility"
        Me.ChkNcVis.UseVisualStyleBackColor = True
        '
        'ChkNcFeelsLike
        '
        Me.ChkNcFeelsLike.AutoSize = True
        Me.ChkNcFeelsLike.Location = New System.Drawing.Point(68, 49)
        Me.ChkNcFeelsLike.Name = "ChkNcFeelsLike"
        Me.ChkNcFeelsLike.Size = New System.Drawing.Size(98, 21)
        Me.ChkNcFeelsLike.TabIndex = 1
        Me.ChkNcFeelsLike.Tag = "1"
        Me.ChkNcFeelsLike.Text = "Feels Like"
        Me.ChkNcFeelsLike.UseVisualStyleBackColor = True
        '
        'ChkNcWindSpeed
        '
        Me.ChkNcWindSpeed.AutoSize = True
        Me.ChkNcWindSpeed.Location = New System.Drawing.Point(68, 452)
        Me.ChkNcWindSpeed.Name = "ChkNcWindSpeed"
        Me.ChkNcWindSpeed.Size = New System.Drawing.Size(111, 21)
        Me.ChkNcWindSpeed.TabIndex = 14
        Me.ChkNcWindSpeed.Tag = "14"
        Me.ChkNcWindSpeed.Text = "Wind Speed"
        Me.ChkNcWindSpeed.UseVisualStyleBackColor = True
        '
        'ChkNcDewpoint
        '
        Me.ChkNcDewpoint.AutoSize = True
        Me.ChkNcDewpoint.Location = New System.Drawing.Point(68, 421)
        Me.ChkNcDewpoint.Name = "ChkNcDewpoint"
        Me.ChkNcDewpoint.Size = New System.Drawing.Size(92, 21)
        Me.ChkNcDewpoint.TabIndex = 13
        Me.ChkNcDewpoint.Tag = "13"
        Me.ChkNcDewpoint.Text = "Dewpoint"
        Me.ChkNcDewpoint.UseVisualStyleBackColor = True
        '
        'ChkNcWindDir
        '
        Me.ChkNcWindDir.AutoSize = True
        Me.ChkNcWindDir.Location = New System.Drawing.Point(68, 111)
        Me.ChkNcWindDir.Name = "ChkNcWindDir"
        Me.ChkNcWindDir.Size = New System.Drawing.Size(126, 21)
        Me.ChkNcWindDir.TabIndex = 3
        Me.ChkNcWindDir.Tag = "3"
        Me.ChkNcWindDir.Text = "Wind Direction"
        Me.ChkNcWindDir.UseVisualStyleBackColor = True
        '
        'ChkNcWindGust
        '
        Me.ChkNcWindGust.AutoSize = True
        Me.ChkNcWindGust.Location = New System.Drawing.Point(68, 142)
        Me.ChkNcWindGust.Name = "ChkNcWindGust"
        Me.ChkNcWindGust.Size = New System.Drawing.Size(100, 21)
        Me.ChkNcWindGust.TabIndex = 4
        Me.ChkNcWindGust.Tag = "4"
        Me.ChkNcWindGust.Text = "Wind Gust"
        Me.ChkNcWindGust.UseVisualStyleBackColor = True
        '
        'ChkNcBP
        '
        Me.ChkNcBP.AutoSize = True
        Me.ChkNcBP.Location = New System.Drawing.Point(283, 49)
        Me.ChkNcBP.Name = "ChkNcBP"
        Me.ChkNcBP.Size = New System.Drawing.Size(163, 21)
        Me.ChkNcBP.TabIndex = 16
        Me.ChkNcBP.Tag = "16"
        Me.ChkNcBP.Text = "Barometric Pressure"
        Me.ChkNcBP.UseVisualStyleBackColor = True
        '
        'ChkNcPrecip
        '
        Me.ChkNcPrecip.AutoSize = True
        Me.ChkNcPrecip.Location = New System.Drawing.Point(68, 173)
        Me.ChkNcPrecip.Name = "ChkNcPrecip"
        Me.ChkNcPrecip.Size = New System.Drawing.Size(112, 21)
        Me.ChkNcPrecip.TabIndex = 5
        Me.ChkNcPrecip.Tag = "5"
        Me.ChkNcPrecip.Text = "Precipitation"
        Me.ChkNcPrecip.UseVisualStyleBackColor = True
        '
        'ChkNcPrecipType
        '
        Me.ChkNcPrecipType.AutoSize = True
        Me.ChkNcPrecipType.Location = New System.Drawing.Point(68, 204)
        Me.ChkNcPrecipType.Name = "ChkNcPrecipType"
        Me.ChkNcPrecipType.Size = New System.Drawing.Size(148, 21)
        Me.ChkNcPrecipType.TabIndex = 6
        Me.ChkNcPrecipType.Tag = "6"
        Me.ChkNcPrecipType.Text = "Precipitation Type"
        Me.ChkNcPrecipType.UseVisualStyleBackColor = True
        '
        'ChkNcRH
        '
        Me.ChkNcRH.AutoSize = True
        Me.ChkNcRH.Location = New System.Drawing.Point(68, 80)
        Me.ChkNcRH.Name = "ChkNcRH"
        Me.ChkNcRH.Size = New System.Drawing.Size(88, 21)
        Me.ChkNcRH.TabIndex = 2
        Me.ChkNcRH.Tag = "2"
        Me.ChkNcRH.Text = "Humidity"
        Me.ChkNcRH.UseVisualStyleBackColor = True
        '
        'ChkNcTemp
        '
        Me.ChkNcTemp.AutoSize = True
        Me.ChkNcTemp.Location = New System.Drawing.Point(68, 18)
        Me.ChkNcTemp.Name = "ChkNcTemp"
        Me.ChkNcTemp.Size = New System.Drawing.Size(116, 21)
        Me.ChkNcTemp.TabIndex = 0
        Me.ChkNcTemp.Tag = "0"
        Me.ChkNcTemp.Text = "Temperature"
        Me.ChkNcTemp.UseVisualStyleBackColor = True
        '
        'TpAbout
        '
        Me.TpAbout.Controls.Add(Me.PnlAbout)
        Me.TpAbout.Location = New System.Drawing.Point(4, 29)
        Me.TpAbout.Name = "TpAbout"
        Me.TpAbout.Size = New System.Drawing.Size(1392, 1037)
        Me.TpAbout.TabIndex = 4
        Me.TpAbout.Text = "About"
        Me.TpAbout.UseVisualStyleBackColor = True
        '
        'PnlAbout
        '
        Me.PnlAbout.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PnlAbout.BackgroundImage = Global.ClimaCell.My.Resources.Resources.powered_by_climacell_halo
        Me.PnlAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PnlAbout.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PnlAbout.Controls.Add(Me.LblAbout)
        Me.PnlAbout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlAbout.ForeColor = System.Drawing.SystemColors.Info
        Me.PnlAbout.Location = New System.Drawing.Point(0, 0)
        Me.PnlAbout.Name = "PnlAbout"
        Me.PnlAbout.Size = New System.Drawing.Size(1392, 1037)
        Me.PnlAbout.TabIndex = 24
        '
        'LblAbout
        '
        Me.LblAbout.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblAbout.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAbout.Location = New System.Drawing.Point(394, 348)
        Me.LblAbout.Name = "LblAbout"
        Me.LblAbout.Size = New System.Drawing.Size(600, 337)
        Me.LblAbout.TabIndex = 0
        Me.LblAbout.Text = "-"
        Me.LblAbout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TsslVer, Me.TsslNextDaily, Me.TsslNextHourly, Me.TsslNextNowcast, Me.TsslCpy, Me.TsslClock})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 1038)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(2, 0, 14, 0)
        Me.StatusStrip1.ShowItemToolTips = True
        Me.StatusStrip1.Size = New System.Drawing.Size(1400, 32)
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
        'TsslNextDaily
        '
        Me.TsslNextDaily.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TsslNextDaily.ForeColor = System.Drawing.Color.Maroon
        Me.TsslNextDaily.Name = "TsslNextDaily"
        Me.TsslNextDaily.Size = New System.Drawing.Size(34, 25)
        Me.TsslNextDaily.Text = "du"
        Me.TsslNextDaily.ToolTipText = "Time to next daily update"
        '
        'TsslNextHourly
        '
        Me.TsslNextHourly.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TsslNextHourly.ForeColor = System.Drawing.Color.ForestGreen
        Me.TsslNextHourly.Name = "TsslNextHourly"
        Me.TsslNextHourly.Size = New System.Drawing.Size(34, 25)
        Me.TsslNextHourly.Text = "hu"
        Me.TsslNextHourly.ToolTipText = "Time to next hourly updatre"
        '
        'TsslNextNowcast
        '
        Me.TsslNextNowcast.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TsslNextNowcast.ForeColor = System.Drawing.Color.Purple
        Me.TsslNextNowcast.Name = "TsslNextNowcast"
        Me.TsslNextNowcast.Size = New System.Drawing.Size(34, 25)
        Me.TsslNextNowcast.Text = "nu"
        Me.TsslNextNowcast.ToolTipText = "Time to next nowcast update"
        '
        'TsslCpy
        '
        Me.TsslCpy.Font = New System.Drawing.Font("Segoe UI", 7.0!)
        Me.TsslCpy.ForeColor = System.Drawing.Color.Red
        Me.TsslCpy.Name = "TsslCpy"
        Me.TsslCpy.Size = New System.Drawing.Size(1206, 25)
        Me.TsslCpy.Spring = True
        Me.TsslCpy.Text = "cpy"
        '
        'TsslClock
        '
        Me.TsslClock.Name = "TsslClock"
        Me.TsslClock.Size = New System.Drawing.Size(58, 25)
        Me.TsslClock.Text = "h:mm"
        '
        'TmrUpdateHourly
        '
        Me.TmrUpdateHourly.SynchronizingObject = Me
        '
        'TmrUpdateNowcast
        '
        Me.TmrUpdateNowcast.SynchronizingObject = Me
        '
        'ChkUncheckAllNowcast
        '
        Me.ChkUncheckAllNowcast.AutoSize = True
        Me.ChkUncheckAllNowcast.Location = New System.Drawing.Point(580, 562)
        Me.ChkUncheckAllNowcast.Name = "ChkUncheckAllNowcast"
        Me.ChkUncheckAllNowcast.Size = New System.Drawing.Size(108, 21)
        Me.ChkUncheckAllNowcast.TabIndex = 26
        Me.ChkUncheckAllNowcast.Text = "Uncheck All"
        Me.ChkUncheckAllNowcast.UseVisualStyleBackColor = True
        '
        'c1
        '
        Me.c1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.c1.HeaderText = "Day"
        Me.c1.MinimumWidth = 8
        Me.c1.Name = "c1"
        Me.c1.ReadOnly = True
        Me.c1.Width = 69
        '
        'c2
        '
        Me.c2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.c2.HeaderText = "Time"
        Me.c2.MinimumWidth = 8
        Me.c2.Name = "c2"
        Me.c2.ReadOnly = True
        Me.c2.Width = 75
        '
        'c3
        '
        Me.c3.HeaderText = "Weather"
        Me.c3.MinimumWidth = 8
        Me.c3.Name = "c3"
        Me.c3.ReadOnly = True
        Me.c3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.c3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'c4
        '
        Me.c4.HeaderText = "Forecast"
        Me.c4.MinimumWidth = 8
        Me.c4.Name = "c4"
        Me.c4.ReadOnly = True
        '
        'hr0
        '
        Me.hr0.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.hr0.HeaderText = "Day"
        Me.hr0.MinimumWidth = 8
        Me.hr0.Name = "hr0"
        Me.hr0.ReadOnly = True
        Me.hr0.Width = 69
        '
        'hr1
        '
        Me.hr1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.hr1.HeaderText = "Hour"
        Me.hr1.MinimumWidth = 8
        Me.hr1.Name = "hr1"
        Me.hr1.ReadOnly = True
        Me.hr1.Width = 75
        '
        'hr2
        '
        Me.hr2.HeaderText = "Weather"
        Me.hr2.MinimumWidth = 8
        Me.hr2.Name = "hr2"
        Me.hr2.ReadOnly = True
        Me.hr2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.hr2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'hr3
        '
        Me.hr3.HeaderText = "Forecast"
        Me.hr3.MinimumWidth = 8
        Me.hr3.Name = "hr3"
        Me.hr3.ReadOnly = True
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1400, 1070)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.TC)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("Location", Global.ClimaCell.My.MySettings.Default, "MainFormLocation", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Location = Global.ClimaCell.My.MySettings.Default.MainFormLocation
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1422, 1126)
        Me.MinimumSize = New System.Drawing.Size(1422, 1126)
        Me.Name = "FrmMain"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Form1"
        CType(Me.TmrUpdateDaily, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TmrClock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TC.ResumeLayout(False)
        Me.TpDaily.ResumeLayout(False)
        CType(Me.DgvDaily, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TpHourly.ResumeLayout(False)
        CType(Me.DgvHourly, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TpNowcast.ResumeLayout(False)
        CType(Me.DgvNowcast, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TpLogs.ResumeLayout(False)
        Me.TcLogs.ResumeLayout(False)
        Me.TpLogLog.ResumeLayout(False)
        Me.TpLogData.ResumeLayout(False)
        Me.TpLogError.ResumeLayout(False)
        Me.TpOptions.ResumeLayout(False)
        Me.TcOpt.ResumeLayout(False)
        Me.TpOptMain.ResumeLayout(False)
        Me.PnlSettings.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.NumNowcastInterval, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumHourlyInterval, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumDailyInterval, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NumLongitude, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumLatiutude, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TpOptDaily.ResumeLayout(False)
        Me.PnlDailyForecast.ResumeLayout(False)
        Me.PnlDailyForecast.PerformLayout()
        Me.GbDailyFields.ResumeLayout(False)
        Me.GbDailyFields.PerformLayout()
        Me.TpOptHourly.ResumeLayout(False)
        Me.PnlHourlyForecast.ResumeLayout(False)
        Me.PnlHourlyForecast.PerformLayout()
        Me.GbHourlyFields.ResumeLayout(False)
        Me.GbHourlyFields.PerformLayout()
        Me.TpOptNowCast.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.NumNcTimeStep, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbNowcast.ResumeLayout(False)
        Me.GbNowcast.PerformLayout()
        Me.TpAbout.ResumeLayout(False)
        Me.PnlAbout.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.TmrUpdateHourly, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TmrUpdateNowcast, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TmrUpdateDaily As Timers.Timer
    Friend WithEvents TmrClock As Timers.Timer
    Friend WithEvents TC As TabControl
    Friend WithEvents TpDaily As TabPage
    Friend WithEvents DgvDaily As DataGridView
    Friend WithEvents TpLogs As TabPage
    Friend WithEvents TcLogs As TabControl
    Friend WithEvents TpLogLog As TabPage
    Friend WithEvents RtbLog As RichTextBox
    Friend WithEvents TpLogData As TabPage
    Friend WithEvents RtbData As RichTextBox
    Friend WithEvents TpLogError As TabPage
    Friend WithEvents RtbError As RichTextBox
    Friend WithEvents TTip As ToolTip
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents TsslVer As ToolStripStatusLabel
    Friend WithEvents TsslNextDaily As ToolStripStatusLabel
    Friend WithEvents TsslClock As ToolStripStatusLabel
    Friend WithEvents TsslCpy As ToolStripStatusLabel
    Friend WithEvents TpOptions As TabPage
    Friend WithEvents TcOpt As TabControl
    Friend WithEvents TpOptDaily As TabPage
    Friend WithEvents TpOptHourly As TabPage
    Friend WithEvents PnlHourlyForecast As Panel
    Friend WithEvents ChkAllHourly As CheckBox
    Friend WithEvents GbHourlyFields As GroupBox
    Friend WithEvents ChkHrHailRisk As CheckBox
    Friend WithEvents ChkHrRiskScore As CheckBox
    Friend WithEvents ChkHrRiskConfidence As CheckBox
    Friend WithEvents ChkHrRiskCondition As CheckBox
    Friend WithEvents ChkHrRoadRisk As CheckBox
    Friend WithEvents Label10 As Label
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
    Friend WithEvents ChkHourGrass As CheckBox
    Friend WithEvents ChkHourRagweed As CheckBox
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
    Friend WithEvents Label6 As Label
    Friend WithEvents ChkHourGrassPollen As CheckBox
    Friend WithEvents ChkHourWeedPollen As CheckBox
    Friend WithEvents ChkHourTreePollen As CheckBox
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
    Friend WithEvents PnlDailyForecast As Panel
    Friend WithEvents GbDailyFields As GroupBox
    Friend WithEvents ChkMoonPhase As CheckBox
    Friend WithEvents ChkTemp As CheckBox
    Friend WithEvents ChkWxCode As CheckBox
    Friend WithEvents ChkPrecip As CheckBox
    Friend WithEvents ChkVis As CheckBox
    Friend WithEvents ChkBP As CheckBox
    Friend WithEvents ChkPrecipProb As CheckBox
    Friend WithEvents ChkWindDir As CheckBox
    Friend WithEvents ChkPrecipAcc As CheckBox
    Friend WithEvents ChkWindSpeed As CheckBox
    Friend WithEvents ChkSunrise As CheckBox
    Friend WithEvents ChkHumidity As CheckBox
    Friend WithEvents ChkSunset As CheckBox
    Friend WithEvents ChkDewpoint As CheckBox
    Friend WithEvents ChkFeelsLike As CheckBox
    Friend WithEvents ChkAllDaily As CheckBox
    Friend WithEvents TpAbout As TabPage
    Friend WithEvents PnlAbout As Panel
    Friend WithEvents LblAbout As Label
    Friend WithEvents TpOptMain As TabPage
    Friend WithEvents PnlSettings As Panel
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents ChkFetchHourly As CheckBox
    Friend WithEvents ChkFetchDaily As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents NumDailyInterval As NumericUpDown
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents RbUnitSI As RadioButton
    Friend WithEvents RbUnitUS As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TxtApiKey As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtLocationId As TextBox
    Friend WithEvents NumLongitude As NumericUpDown
    Friend WithEvents NumLatiutude As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TpOptNowCast As TabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ChkAllNowcast As CheckBox
    Friend WithEvents GbNowcast As GroupBox
    Friend WithEvents ChkNcHailRisk As CheckBox
    Friend WithEvents ChkNcRiskScore As CheckBox
    Friend WithEvents ChkNcRiskConfidence As CheckBox
    Friend WithEvents ChkNcRiskCondition As CheckBox
    Friend WithEvents ChkNcRoadRisk As CheckBox
    Friend WithEvents ChkNcPm25 As CheckBox
    Friend WithEvents ChkNcO3 As CheckBox
    Friend WithEvents ChkNcNo2 As CheckBox
    Friend WithEvents ChkNcCo As CheckBox
    Friend WithEvents ChkNcSo2 As CheckBox
    Friend WithEvents ChkNcEpaAqi As CheckBox
    Friend WithEvents ChkNcEpaPollutant As CheckBox
    Friend WithEvents ChkNcEpaConcern As CheckBox
    Friend WithEvents ChkNcChinaAqi As CheckBox
    Friend WithEvents ChkNcChinaConcern As CheckBox
    Friend WithEvents ChkNcChinaPollutant As CheckBox
    Friend WithEvents ChkNcPm10 As CheckBox
    Friend WithEvents ChkNcGrass As CheckBox
    Friend WithEvents ChkNcRagweed As CheckBox
    Friend WithEvents ChkNcAsh As CheckBox
    Friend WithEvents ChkNcBeech As CheckBox
    Friend WithEvents ChkNcBirch As CheckBox
    Friend WithEvents ChkNcCedar As CheckBox
    Friend WithEvents ChkNcCypress As CheckBox
    Friend WithEvents ChkNcElder As CheckBox
    Friend WithEvents ChkNcElm As CheckBox
    Friend WithEvents ChkNcHemlock As CheckBox
    Friend WithEvents ChkNcHickory As CheckBox
    Friend WithEvents ChkNcJuniper As CheckBox
    Friend WithEvents ChkNcMahogany As CheckBox
    Friend WithEvents ChkNcMaple As CheckBox
    Friend WithEvents ChkNcMulberry As CheckBox
    Friend WithEvents ChkNcOak As CheckBox
    Friend WithEvents ChkNcPine As CheckBox
    Friend WithEvents ChkNcCottonwood As CheckBox
    Friend WithEvents ChkNcSpruce As CheckBox
    Friend WithEvents ChkNcSycamore As CheckBox
    Friend WithEvents ChkNcWalnut As CheckBox
    Friend WithEvents ChkNcWillow As CheckBox
    Friend WithEvents ChkNcAcacia As CheckBox
    Friend WithEvents ChkNcGrassPollen As CheckBox
    Friend WithEvents ChkNcWeedPollen As CheckBox
    Friend WithEvents ChkNcTreePollen As CheckBox
    Friend WithEvents ChkNcSunrise As CheckBox
    Friend WithEvents ChkNcCloudCover As CheckBox
    Friend WithEvents ChkNcSunset As CheckBox
    Friend WithEvents ChkNcCloudBase As CheckBox
    Friend WithEvents ChkNcCloudCeil As CheckBox
    Friend WithEvents ChkNcSSR As CheckBox
    Friend WithEvents ChkNcWxCode As CheckBox
    Friend WithEvents ChkNcVis As CheckBox
    Friend WithEvents ChkNcFeelsLike As CheckBox
    Friend WithEvents ChkNcWindSpeed As CheckBox
    Friend WithEvents ChkNcDewpoint As CheckBox
    Friend WithEvents ChkNcWindDir As CheckBox
    Friend WithEvents ChkNcWindGust As CheckBox
    Friend WithEvents ChkNcBP As CheckBox
    Friend WithEvents ChkNcPrecip As CheckBox
    Friend WithEvents ChkNcPrecipType As CheckBox
    Friend WithEvents ChkNcRH As CheckBox
    Friend WithEvents ChkNcTemp As CheckBox
    Friend WithEvents TmrUpdateHourly As Timers.Timer
    Friend WithEvents TmrUpdateNowcast As Timers.Timer
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label13 As Label
    Friend WithEvents NumNowcastInterval As NumericUpDown
    Friend WithEvents Label12 As Label
    Friend WithEvents NumHourlyInterval As NumericUpDown
    Friend WithEvents TsslNextHourly As ToolStripStatusLabel
    Friend WithEvents TsslNextNowcast As ToolStripStatusLabel
    Friend WithEvents ChkFetchNowcast As CheckBox
    Friend WithEvents TpHourly As TabPage
    Friend WithEvents TpNowcast As TabPage
    Friend WithEvents DgvHourly As DataGridView
    Friend WithEvents DgvNowcast As DataGridView
    Friend WithEvents NumNcTimeStep As NumericUpDown
    Friend WithEvents Label14 As Label
    Friend WithEvents ChkUncheckAllNowcast As CheckBox
    Friend WithEvents c1 As DataGridViewTextBoxColumn
    Friend WithEvents c2 As DataGridViewTextBoxColumn
    Friend WithEvents c3 As DataGridViewImageColumn
    Friend WithEvents c4 As DataGridViewTextBoxColumn
    Friend WithEvents hr0 As DataGridViewTextBoxColumn
    Friend WithEvents hr1 As DataGridViewTextBoxColumn
    Friend WithEvents hr2 As DataGridViewImageColumn
    Friend WithEvents hr3 As DataGridViewTextBoxColumn
End Class
