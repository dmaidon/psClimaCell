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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TmrUpdateDaily = New System.Timers.Timer()
        Me.TmrClock = New System.Timers.Timer()
        Me.TC = New System.Windows.Forms.TabControl()
        Me.TpDaily = New System.Windows.Forms.TabPage()
        Me.DgvDaily = New System.Windows.Forms.DataGridView()
        Me.TpHourly = New System.Windows.Forms.TabPage()
        Me.DgvHourly = New System.Windows.Forms.DataGridView()
        Me.hr0 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hr1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hr2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.hr3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TpNowcast = New System.Windows.Forms.TabPage()
        Me.DgvNowcast = New System.Windows.Forms.DataGridView()
        Me.c1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c3 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.c4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TpLogs = New System.Windows.Forms.TabPage()
        Me.TcLogs = New System.Windows.Forms.TabControl()
        Me.TpLogLog = New System.Windows.Forms.TabPage()
        Me.RtbLog = New System.Windows.Forms.RichTextBox()
        Me.TpLogError = New System.Windows.Forms.TabPage()
        Me.RtbError = New System.Windows.Forms.RichTextBox()
        Me.TpOptions = New System.Windows.Forms.TabPage()
        Me.TcOpt = New System.Windows.Forms.TabControl()
        Me.TpOptMain = New System.Windows.Forms.TabPage()
        Me.PnlSettings = New System.Windows.Forms.Panel()
        Me.PnlMainOpt = New System.Windows.Forms.Panel()
        Me.TlpMainOpt = New System.Windows.Forms.TableLayoutPanel()
        Me.RbUnitSI = New System.Windows.Forms.RadioButton()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.RbUnitUS = New System.Windows.Forms.RadioButton()
        Me.NumNowcastInterval = New System.Windows.Forms.NumericUpDown()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.NumHourlyInterval = New System.Windows.Forms.NumericUpDown()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.NumDailyInterval = New System.Windows.Forms.NumericUpDown()
        Me.ChkFetchHourly = New System.Windows.Forms.CheckBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtApiKey = New System.Windows.Forms.TextBox()
        Me.NumLongitude = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ChkFetchDaily = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NumLatiutude = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ChkFetchNowcast = New System.Windows.Forms.CheckBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TpOptDaily = New System.Windows.Forms.TabPage()
        Me.PnlDailyForecast = New System.Windows.Forms.Panel()
        Me.ChkUncheckAllDaily = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TlpDaily = New System.Windows.Forms.TableLayoutPanel()
        Me.ChkMoonPhase = New System.Windows.Forms.CheckBox()
        Me.ChkTemp = New System.Windows.Forms.CheckBox()
        Me.ChkWxCode = New System.Windows.Forms.CheckBox()
        Me.ChkFeelsLike = New System.Windows.Forms.CheckBox()
        Me.ChkVis = New System.Windows.Forms.CheckBox()
        Me.ChkPrecip = New System.Windows.Forms.CheckBox()
        Me.ChkSunset = New System.Windows.Forms.CheckBox()
        Me.ChkSunrise = New System.Windows.Forms.CheckBox()
        Me.ChkPrecipAcc = New System.Windows.Forms.CheckBox()
        Me.ChkPrecipProb = New System.Windows.Forms.CheckBox()
        Me.ChkDewpoint = New System.Windows.Forms.CheckBox()
        Me.ChkHumidity = New System.Windows.Forms.CheckBox()
        Me.ChkBP = New System.Windows.Forms.CheckBox()
        Me.ChkWindDir = New System.Windows.Forms.CheckBox()
        Me.ChkWindSpeed = New System.Windows.Forms.CheckBox()
        Me.ChkAllDaily = New System.Windows.Forms.CheckBox()
        Me.TpOptHourly = New System.Windows.Forms.TabPage()
        Me.PnlHourlyForecast = New System.Windows.Forms.Panel()
        Me.ChkUncheckAllHr = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TlpHourly = New System.Windows.Forms.TableLayoutPanel()
        Me.ChkHrRiskCondition = New System.Windows.Forms.CheckBox()
        Me.ChkHrRiskConfidence = New System.Windows.Forms.CheckBox()
        Me.ChkHrRiskScore = New System.Windows.Forms.CheckBox()
        Me.ChkHrHailRisk = New System.Windows.Forms.CheckBox()
        Me.ChkHourTemp = New System.Windows.Forms.CheckBox()
        Me.ChkHourFeelsLike = New System.Windows.Forms.CheckBox()
        Me.ChkHrRoadRisk = New System.Windows.Forms.CheckBox()
        Me.ChkHourRH = New System.Windows.Forms.CheckBox()
        Me.ChkHourChinaPollutant = New System.Windows.Forms.CheckBox()
        Me.ChkHourChinaConcern = New System.Windows.Forms.CheckBox()
        Me.ChkHourChinaAqi = New System.Windows.Forms.CheckBox()
        Me.ChkHourEpaPollutant = New System.Windows.Forms.CheckBox()
        Me.ChkHourEpaAqi = New System.Windows.Forms.CheckBox()
        Me.ChkHourEpaConcern = New System.Windows.Forms.CheckBox()
        Me.ChkHourAqiNo2 = New System.Windows.Forms.CheckBox()
        Me.ChkHourAqiO3 = New System.Windows.Forms.CheckBox()
        Me.ChkHourAqiSo2 = New System.Windows.Forms.CheckBox()
        Me.ChkHourAqiCo = New System.Windows.Forms.CheckBox()
        Me.ChkHourAqiPm25 = New System.Windows.Forms.CheckBox()
        Me.ChkHourWindDir = New System.Windows.Forms.CheckBox()
        Me.ChkHourWindGust = New System.Windows.Forms.CheckBox()
        Me.ChkHourPrecip = New System.Windows.Forms.CheckBox()
        Me.ChkHourPrecipType = New System.Windows.Forms.CheckBox()
        Me.ChkHourPrecipProb = New System.Windows.Forms.CheckBox()
        Me.ChkHourSunrise = New System.Windows.Forms.CheckBox()
        Me.ChkHourVis = New System.Windows.Forms.CheckBox()
        Me.ChkHourCloudCover = New System.Windows.Forms.CheckBox()
        Me.ChkHourCloudCeil = New System.Windows.Forms.CheckBox()
        Me.ChkHourMoonPhase = New System.Windows.Forms.CheckBox()
        Me.ChkHourWxCode = New System.Windows.Forms.CheckBox()
        Me.ChkHourAqiPm10 = New System.Windows.Forms.CheckBox()
        Me.ChkHourSunset = New System.Windows.Forms.CheckBox()
        Me.ChkHourTreeWalnut = New System.Windows.Forms.CheckBox()
        Me.ChkHourTreeSycamore = New System.Windows.Forms.CheckBox()
        Me.ChkHourTreeSpruce = New System.Windows.Forms.CheckBox()
        Me.ChkHourTreeCottonwood = New System.Windows.Forms.CheckBox()
        Me.ChkHourTreePine = New System.Windows.Forms.CheckBox()
        Me.ChkHourGrass = New System.Windows.Forms.CheckBox()
        Me.ChkHourDewpoint = New System.Windows.Forms.CheckBox()
        Me.ChkHourTreeOak = New System.Windows.Forms.CheckBox()
        Me.ChkHourTreeMahogany = New System.Windows.Forms.CheckBox()
        Me.ChkHourTreeHemlock = New System.Windows.Forms.CheckBox()
        Me.ChkHourTreeCypress = New System.Windows.Forms.CheckBox()
        Me.ChkHourTreeBeech = New System.Windows.Forms.CheckBox()
        Me.ChkHourRagweed = New System.Windows.Forms.CheckBox()
        Me.ChkHourWindSpeed = New System.Windows.Forms.CheckBox()
        Me.ChkHourTreeAsh = New System.Windows.Forms.CheckBox()
        Me.ChkHourTreeCedar = New System.Windows.Forms.CheckBox()
        Me.ChkHourTreeElm = New System.Windows.Forms.CheckBox()
        Me.ChkHourTreeJuniper = New System.Windows.Forms.CheckBox()
        Me.ChkHourTreeMulberry = New System.Windows.Forms.CheckBox()
        Me.ChkHourCloudBase = New System.Windows.Forms.CheckBox()
        Me.ChkHourBP = New System.Windows.Forms.CheckBox()
        Me.ChkHourTreeBirch = New System.Windows.Forms.CheckBox()
        Me.ChkHourSSR = New System.Windows.Forms.CheckBox()
        Me.ChkHourTreeElder = New System.Windows.Forms.CheckBox()
        Me.ChkHourTreePollen = New System.Windows.Forms.CheckBox()
        Me.ChkHourTreeHickory = New System.Windows.Forms.CheckBox()
        Me.ChkHourWeedPollen = New System.Windows.Forms.CheckBox()
        Me.ChkHourTreeMaple = New System.Windows.Forms.CheckBox()
        Me.ChkHourGrassPollen = New System.Windows.Forms.CheckBox()
        Me.ChkHourTreeAcacia = New System.Windows.Forms.CheckBox()
        Me.ChkHourTreeWillow = New System.Windows.Forms.CheckBox()
        Me.ChkAllHourly = New System.Windows.Forms.CheckBox()
        Me.TpOptNowCast = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TlpNowcast = New System.Windows.Forms.TableLayoutPanel()
        Me.ChkNcRiskCondition = New System.Windows.Forms.CheckBox()
        Me.ChkNcRiskConfidence = New System.Windows.Forms.CheckBox()
        Me.ChkNcHailRisk = New System.Windows.Forms.CheckBox()
        Me.ChkNcTemp = New System.Windows.Forms.CheckBox()
        Me.ChkNcFeelsLike = New System.Windows.Forms.CheckBox()
        Me.ChkNcRH = New System.Windows.Forms.CheckBox()
        Me.ChkNcChinaPollutant = New System.Windows.Forms.CheckBox()
        Me.ChkNcChinaConcern = New System.Windows.Forms.CheckBox()
        Me.ChkNcChinaAqi = New System.Windows.Forms.CheckBox()
        Me.ChkNcEpaPollutant = New System.Windows.Forms.CheckBox()
        Me.ChkNcEpaAqi = New System.Windows.Forms.CheckBox()
        Me.ChkNcEpaConcern = New System.Windows.Forms.CheckBox()
        Me.ChkNcNo2 = New System.Windows.Forms.CheckBox()
        Me.ChkNcO3 = New System.Windows.Forms.CheckBox()
        Me.ChkNcSo2 = New System.Windows.Forms.CheckBox()
        Me.ChkNcCo = New System.Windows.Forms.CheckBox()
        Me.ChkNcPm25 = New System.Windows.Forms.CheckBox()
        Me.ChkNcWindDir = New System.Windows.Forms.CheckBox()
        Me.ChkNcWindGust = New System.Windows.Forms.CheckBox()
        Me.ChkNcPrecip = New System.Windows.Forms.CheckBox()
        Me.ChkNcPrecipType = New System.Windows.Forms.CheckBox()
        Me.ChkNcSunrise = New System.Windows.Forms.CheckBox()
        Me.ChkNcVis = New System.Windows.Forms.CheckBox()
        Me.ChkNcCloudCover = New System.Windows.Forms.CheckBox()
        Me.ChkNcCloudCeil = New System.Windows.Forms.CheckBox()
        Me.ChkNcWxCode = New System.Windows.Forms.CheckBox()
        Me.ChkNcSunset = New System.Windows.Forms.CheckBox()
        Me.ChkNcDewpoint = New System.Windows.Forms.CheckBox()
        Me.ChkNcPm10 = New System.Windows.Forms.CheckBox()
        Me.ChkNcWindSpeed = New System.Windows.Forms.CheckBox()
        Me.ChkNcWalnut = New System.Windows.Forms.CheckBox()
        Me.ChkNcSycamore = New System.Windows.Forms.CheckBox()
        Me.ChkNcSpruce = New System.Windows.Forms.CheckBox()
        Me.ChkNcCottonwood = New System.Windows.Forms.CheckBox()
        Me.ChkNcPine = New System.Windows.Forms.CheckBox()
        Me.ChkNcGrass = New System.Windows.Forms.CheckBox()
        Me.ChkNcCloudBase = New System.Windows.Forms.CheckBox()
        Me.ChkNcOak = New System.Windows.Forms.CheckBox()
        Me.ChkNcMahogany = New System.Windows.Forms.CheckBox()
        Me.ChkNcHemlock = New System.Windows.Forms.CheckBox()
        Me.ChkNcCypress = New System.Windows.Forms.CheckBox()
        Me.ChkNcBeech = New System.Windows.Forms.CheckBox()
        Me.ChkNcRagweed = New System.Windows.Forms.CheckBox()
        Me.ChkNcBP = New System.Windows.Forms.CheckBox()
        Me.ChkNcAsh = New System.Windows.Forms.CheckBox()
        Me.ChkNcCedar = New System.Windows.Forms.CheckBox()
        Me.ChkNcElm = New System.Windows.Forms.CheckBox()
        Me.ChkNcJuniper = New System.Windows.Forms.CheckBox()
        Me.ChkNcMulberry = New System.Windows.Forms.CheckBox()
        Me.ChkNcSSR = New System.Windows.Forms.CheckBox()
        Me.ChkNcTreePollen = New System.Windows.Forms.CheckBox()
        Me.ChkNcBirch = New System.Windows.Forms.CheckBox()
        Me.ChkNcWeedPollen = New System.Windows.Forms.CheckBox()
        Me.ChkNcElder = New System.Windows.Forms.CheckBox()
        Me.ChkNcGrassPollen = New System.Windows.Forms.CheckBox()
        Me.ChkNcHickory = New System.Windows.Forms.CheckBox()
        Me.ChkNcAcacia = New System.Windows.Forms.CheckBox()
        Me.ChkNcMaple = New System.Windows.Forms.CheckBox()
        Me.ChkNcWillow = New System.Windows.Forms.CheckBox()
        Me.ChkNcRoadRisk = New System.Windows.Forms.CheckBox()
        Me.ChkNcRiskScore = New System.Windows.Forms.CheckBox()
        Me.ChkUncheckAllNowcast = New System.Windows.Forms.CheckBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.NumNcTimeStep = New System.Windows.Forms.NumericUpDown()
        Me.ChkAllNowcast = New System.Windows.Forms.CheckBox()
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
        Me.TpLogError.SuspendLayout()
        Me.TpOptions.SuspendLayout()
        Me.TcOpt.SuspendLayout()
        Me.TpOptMain.SuspendLayout()
        Me.PnlSettings.SuspendLayout()
        Me.PnlMainOpt.SuspendLayout()
        Me.TlpMainOpt.SuspendLayout()
        CType(Me.NumNowcastInterval, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumHourlyInterval, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumDailyInterval, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumLongitude, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumLatiutude, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TpOptDaily.SuspendLayout()
        Me.PnlDailyForecast.SuspendLayout()
        Me.TlpDaily.SuspendLayout()
        Me.TpOptHourly.SuspendLayout()
        Me.PnlHourlyForecast.SuspendLayout()
        Me.TlpHourly.SuspendLayout()
        Me.TpOptNowCast.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TlpNowcast.SuspendLayout()
        CType(Me.NumNcTimeStep, System.ComponentModel.ISupportInitialize).BeginInit()
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
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DgvHourly.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DgvHourly.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvHourly.BackgroundColor = System.Drawing.Color.LightSkyBlue
        Me.DgvHourly.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.DgvHourly.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DgvHourly.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DgvHourly.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvHourly.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.hr0, Me.hr1, Me.hr2, Me.hr3})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightSkyBlue
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvHourly.DefaultCellStyle = DataGridViewCellStyle5
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
        Me.DgvNowcast.AllowUserToAddRows = False
        Me.DgvNowcast.AllowUserToDeleteRows = False
        Me.DgvNowcast.AllowUserToResizeColumns = False
        Me.DgvNowcast.AllowUserToResizeRows = False
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DgvNowcast.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.DgvNowcast.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvNowcast.BackgroundColor = System.Drawing.Color.LightSkyBlue
        Me.DgvNowcast.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.DgvNowcast.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DgvNowcast.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DgvNowcast.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvNowcast.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.c1, Me.c2, Me.c3, Me.c4})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.LightSkyBlue
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvNowcast.DefaultCellStyle = DataGridViewCellStyle8
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
        Me.PnlSettings.BackgroundImage = Global.ClimaCell.My.Resources.Resources.powered_by_climacell_halo
        Me.PnlSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PnlSettings.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PnlSettings.Controls.Add(Me.PnlMainOpt)
        Me.PnlSettings.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlSettings.Location = New System.Drawing.Point(0, 0)
        Me.PnlSettings.Name = "PnlSettings"
        Me.PnlSettings.Size = New System.Drawing.Size(1384, 970)
        Me.PnlSettings.TabIndex = 1
        '
        'PnlMainOpt
        '
        Me.PnlMainOpt.BackColor = System.Drawing.Color.Silver
        Me.PnlMainOpt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PnlMainOpt.Controls.Add(Me.TlpMainOpt)
        Me.PnlMainOpt.Location = New System.Drawing.Point(341, 238)
        Me.PnlMainOpt.Name = "PnlMainOpt"
        Me.PnlMainOpt.Size = New System.Drawing.Size(698, 491)
        Me.PnlMainOpt.TabIndex = 25
        '
        'TlpMainOpt
        '
        Me.TlpMainOpt.ColumnCount = 2
        Me.TlpMainOpt.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TlpMainOpt.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.0!))
        Me.TlpMainOpt.Controls.Add(Me.RbUnitSI, 1, 13)
        Me.TlpMainOpt.Controls.Add(Me.Label15, 0, 12)
        Me.TlpMainOpt.Controls.Add(Me.RbUnitUS, 0, 13)
        Me.TlpMainOpt.Controls.Add(Me.NumNowcastInterval, 1, 11)
        Me.TlpMainOpt.Controls.Add(Me.Label13, 0, 11)
        Me.TlpMainOpt.Controls.Add(Me.NumHourlyInterval, 1, 10)
        Me.TlpMainOpt.Controls.Add(Me.Label10, 0, 5)
        Me.TlpMainOpt.Controls.Add(Me.NumDailyInterval, 1, 9)
        Me.TlpMainOpt.Controls.Add(Me.ChkFetchHourly, 0, 7)
        Me.TlpMainOpt.Controls.Add(Me.Label12, 0, 10)
        Me.TlpMainOpt.Controls.Add(Me.TxtApiKey, 1, 4)
        Me.TlpMainOpt.Controls.Add(Me.NumLongitude, 1, 2)
        Me.TlpMainOpt.Controls.Add(Me.Label5, 0, 9)
        Me.TlpMainOpt.Controls.Add(Me.ChkFetchDaily, 0, 6)
        Me.TlpMainOpt.Controls.Add(Me.Label4, 0, 4)
        Me.TlpMainOpt.Controls.Add(Me.Label3, 0, 0)
        Me.TlpMainOpt.Controls.Add(Me.NumLatiutude, 1, 1)
        Me.TlpMainOpt.Controls.Add(Me.Label1, 0, 1)
        Me.TlpMainOpt.Controls.Add(Me.Label2, 0, 2)
        Me.TlpMainOpt.Controls.Add(Me.Label7, 0, 3)
        Me.TlpMainOpt.Controls.Add(Me.ChkFetchNowcast, 1, 6)
        Me.TlpMainOpt.Controls.Add(Me.Label11, 0, 8)
        Me.TlpMainOpt.Location = New System.Drawing.Point(51, 31)
        Me.TlpMainOpt.Name = "TlpMainOpt"
        Me.TlpMainOpt.RowCount = 14
        Me.TlpMainOpt.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TlpMainOpt.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TlpMainOpt.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TlpMainOpt.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TlpMainOpt.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TlpMainOpt.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TlpMainOpt.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TlpMainOpt.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TlpMainOpt.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TlpMainOpt.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TlpMainOpt.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TlpMainOpt.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TlpMainOpt.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TlpMainOpt.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TlpMainOpt.Size = New System.Drawing.Size(596, 428)
        Me.TlpMainOpt.TabIndex = 24
        '
        'RbUnitSI
        '
        Me.RbUnitSI.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RbUnitSI.AutoSize = True
        Me.RbUnitSI.Location = New System.Drawing.Point(152, 393)
        Me.RbUnitSI.Name = "RbUnitSI"
        Me.RbUnitSI.Size = New System.Drawing.Size(50, 32)
        Me.RbUnitSI.TabIndex = 1
        Me.RbUnitSI.TabStop = True
        Me.RbUnitSI.Tag = "1"
        Me.RbUnitSI.Text = "SI"
        Me.RbUnitSI.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoEllipsis = True
        Me.Label15.AutoSize = True
        Me.TlpMainOpt.SetColumnSpan(Me.Label15, 2)
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Brown
        Me.Label15.Location = New System.Drawing.Point(1, 361)
        Me.Label15.Margin = New System.Windows.Forms.Padding(1)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(594, 28)
        Me.Label15.TabIndex = 8
        Me.Label15.Text = "Unit Type"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RbUnitUS
        '
        Me.RbUnitUS.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RbUnitUS.AutoSize = True
        Me.RbUnitUS.Location = New System.Drawing.Point(89, 393)
        Me.RbUnitUS.Name = "RbUnitUS"
        Me.RbUnitUS.Size = New System.Drawing.Size(57, 32)
        Me.RbUnitUS.TabIndex = 0
        Me.RbUnitUS.TabStop = True
        Me.RbUnitUS.Tag = "0"
        Me.RbUnitUS.Text = "US"
        Me.RbUnitUS.UseVisualStyleBackColor = True
        '
        'NumNowcastInterval
        '
        Me.NumNowcastInterval.Location = New System.Drawing.Point(152, 333)
        Me.NumNowcastInterval.Maximum = New Decimal(New Integer() {240, 0, 0, 0})
        Me.NumNowcastInterval.Name = "NumNowcastInterval"
        Me.NumNowcastInterval.Size = New System.Drawing.Size(88, 26)
        Me.NumNowcastInterval.TabIndex = 7
        Me.NumNowcastInterval.Tag = "2"
        '
        'Label13
        '
        Me.Label13.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(1, 331)
        Me.Label13.Margin = New System.Windows.Forms.Padding(1)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(147, 28)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "Nowcast"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NumHourlyInterval
        '
        Me.NumHourlyInterval.Location = New System.Drawing.Point(152, 303)
        Me.NumHourlyInterval.Maximum = New Decimal(New Integer() {240, 0, 0, 0})
        Me.NumHourlyInterval.Name = "NumHourlyInterval"
        Me.NumHourlyInterval.Size = New System.Drawing.Size(88, 26)
        Me.NumHourlyInterval.TabIndex = 5
        Me.NumHourlyInterval.Tag = "1"
        '
        'Label10
        '
        Me.Label10.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoEllipsis = True
        Me.Label10.AutoSize = True
        Me.TlpMainOpt.SetColumnSpan(Me.Label10, 2)
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Brown
        Me.Label10.Location = New System.Drawing.Point(1, 151)
        Me.Label10.Margin = New System.Windows.Forms.Padding(1)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(594, 28)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Fetch Data Type"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NumDailyInterval
        '
        Me.NumDailyInterval.Location = New System.Drawing.Point(152, 273)
        Me.NumDailyInterval.Maximum = New Decimal(New Integer() {240, 0, 0, 0})
        Me.NumDailyInterval.Name = "NumDailyInterval"
        Me.NumDailyInterval.Size = New System.Drawing.Size(88, 26)
        Me.NumDailyInterval.TabIndex = 3
        Me.NumDailyInterval.Tag = "0"
        '
        'ChkFetchHourly
        '
        Me.ChkFetchHourly.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkFetchHourly.AutoSize = True
        Me.ChkFetchHourly.Location = New System.Drawing.Point(66, 213)
        Me.ChkFetchHourly.Name = "ChkFetchHourly"
        Me.ChkFetchHourly.Size = New System.Drawing.Size(80, 24)
        Me.ChkFetchHourly.TabIndex = 1
        Me.ChkFetchHourly.Tag = "1"
        Me.ChkFetchHourly.Text = "Hourly"
        Me.ChkFetchHourly.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(1, 301)
        Me.Label12.Margin = New System.Windows.Forms.Padding(1)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(147, 28)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Hourly"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtApiKey
        '
        Me.TxtApiKey.Location = New System.Drawing.Point(152, 123)
        Me.TxtApiKey.MaxLength = 40
        Me.TxtApiKey.Name = "TxtApiKey"
        Me.TxtApiKey.Size = New System.Drawing.Size(439, 26)
        Me.TxtApiKey.TabIndex = 1
        '
        'NumLongitude
        '
        Me.NumLongitude.DecimalPlaces = 7
        Me.NumLongitude.Location = New System.Drawing.Point(152, 63)
        Me.NumLongitude.Maximum = New Decimal(New Integer() {180, 0, 0, 0})
        Me.NumLongitude.Minimum = New Decimal(New Integer() {180, 0, 0, -2147483648})
        Me.NumLongitude.Name = "NumLongitude"
        Me.NumLongitude.Size = New System.Drawing.Size(166, 26)
        Me.NumLongitude.TabIndex = 4
        Me.NumLongitude.Tag = "1"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(1, 271)
        Me.Label5.Margin = New System.Windows.Forms.Padding(1)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(147, 28)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Daily"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ChkFetchDaily
        '
        Me.ChkFetchDaily.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkFetchDaily.Location = New System.Drawing.Point(66, 183)
        Me.ChkFetchDaily.Name = "ChkFetchDaily"
        Me.ChkFetchDaily.Size = New System.Drawing.Size(80, 24)
        Me.ChkFetchDaily.TabIndex = 0
        Me.ChkFetchDaily.Tag = "0"
        Me.ChkFetchDaily.Text = "Daily"
        Me.ChkFetchDaily.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoEllipsis = True
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(1, 121)
        Me.Label4.Margin = New System.Windows.Forms.Padding(1)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(147, 28)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "API Key"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.TlpMainOpt.SetColumnSpan(Me.Label3, 2)
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Brown
        Me.Label3.Location = New System.Drawing.Point(1, 1)
        Me.Label3.Margin = New System.Windows.Forms.Padding(1)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(594, 28)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Location"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NumLatiutude
        '
        Me.NumLatiutude.DecimalPlaces = 7
        Me.NumLatiutude.Location = New System.Drawing.Point(152, 33)
        Me.NumLatiutude.Maximum = New Decimal(New Integer() {89, 0, 0, 0})
        Me.NumLatiutude.Minimum = New Decimal(New Integer() {87, 0, 0, -2147483648})
        Me.NumLatiutude.Name = "NumLatiutude"
        Me.NumLatiutude.Size = New System.Drawing.Size(166, 26)
        Me.NumLatiutude.TabIndex = 3
        Me.NumLatiutude.Tag = "0"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(1, 31)
        Me.Label1.Margin = New System.Windows.Forms.Padding(1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Latitude"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1, 61)
        Me.Label2.Margin = New System.Windows.Forms.Padding(1)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 28)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Longitude"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoEllipsis = True
        Me.Label7.AutoSize = True
        Me.TlpMainOpt.SetColumnSpan(Me.Label7, 2)
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Brown
        Me.Label7.Location = New System.Drawing.Point(1, 91)
        Me.Label7.Margin = New System.Windows.Forms.Padding(1)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(594, 28)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Security"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ChkFetchNowcast
        '
        Me.ChkFetchNowcast.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ChkFetchNowcast.AutoSize = True
        Me.ChkFetchNowcast.Location = New System.Drawing.Point(152, 183)
        Me.ChkFetchNowcast.Name = "ChkFetchNowcast"
        Me.ChkFetchNowcast.Size = New System.Drawing.Size(96, 24)
        Me.ChkFetchNowcast.TabIndex = 2
        Me.ChkFetchNowcast.Tag = "2"
        Me.ChkFetchNowcast.Text = "Nowcast"
        Me.ChkFetchNowcast.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoEllipsis = True
        Me.Label11.AutoSize = True
        Me.TlpMainOpt.SetColumnSpan(Me.Label11, 2)
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Brown
        Me.Label11.Location = New System.Drawing.Point(1, 241)
        Me.Label11.Margin = New System.Windows.Forms.Padding(1)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(594, 28)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "Update Intervals (minutes)"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.PnlDailyForecast.Controls.Add(Me.ChkUncheckAllDaily)
        Me.PnlDailyForecast.Controls.Add(Me.Label8)
        Me.PnlDailyForecast.Controls.Add(Me.TlpDaily)
        Me.PnlDailyForecast.Controls.Add(Me.ChkAllDaily)
        Me.PnlDailyForecast.Location = New System.Drawing.Point(255, 376)
        Me.PnlDailyForecast.Name = "PnlDailyForecast"
        Me.PnlDailyForecast.Size = New System.Drawing.Size(870, 217)
        Me.PnlDailyForecast.TabIndex = 21
        '
        'ChkUncheckAllDaily
        '
        Me.ChkUncheckAllDaily.AutoSize = True
        Me.ChkUncheckAllDaily.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkUncheckAllDaily.Location = New System.Drawing.Point(436, 181)
        Me.ChkUncheckAllDaily.Name = "ChkUncheckAllDaily"
        Me.ChkUncheckAllDaily.Size = New System.Drawing.Size(130, 24)
        Me.ChkUncheckAllDaily.TabIndex = 21
        Me.ChkUncheckAllDaily.Text = "Uncheck All"
        Me.ChkUncheckAllDaily.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Maroon
        Me.Label8.Location = New System.Drawing.Point(318, 14)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(231, 25)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Daily Forecast Options"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TlpDaily
        '
        Me.TlpDaily.ColumnCount = 4
        Me.TlpDaily.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TlpDaily.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TlpDaily.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TlpDaily.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TlpDaily.Controls.Add(Me.ChkMoonPhase, 3, 2)
        Me.TlpDaily.Controls.Add(Me.ChkTemp, 0, 0)
        Me.TlpDaily.Controls.Add(Me.ChkWxCode, 3, 1)
        Me.TlpDaily.Controls.Add(Me.ChkFeelsLike, 0, 1)
        Me.TlpDaily.Controls.Add(Me.ChkVis, 3, 0)
        Me.TlpDaily.Controls.Add(Me.ChkPrecip, 1, 3)
        Me.TlpDaily.Controls.Add(Me.ChkSunset, 2, 3)
        Me.TlpDaily.Controls.Add(Me.ChkSunrise, 2, 2)
        Me.TlpDaily.Controls.Add(Me.ChkPrecipAcc, 2, 1)
        Me.TlpDaily.Controls.Add(Me.ChkPrecipProb, 2, 0)
        Me.TlpDaily.Controls.Add(Me.ChkDewpoint, 0, 2)
        Me.TlpDaily.Controls.Add(Me.ChkHumidity, 0, 3)
        Me.TlpDaily.Controls.Add(Me.ChkBP, 1, 2)
        Me.TlpDaily.Controls.Add(Me.ChkWindDir, 1, 1)
        Me.TlpDaily.Controls.Add(Me.ChkWindSpeed, 1, 0)
        Me.TlpDaily.Location = New System.Drawing.Point(23, 50)
        Me.TlpDaily.MaximumSize = New System.Drawing.Size(820, 120)
        Me.TlpDaily.MinimumSize = New System.Drawing.Size(820, 120)
        Me.TlpDaily.Name = "TlpDaily"
        Me.TlpDaily.RowCount = 4
        Me.TlpDaily.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TlpDaily.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TlpDaily.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TlpDaily.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TlpDaily.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TlpDaily.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TlpDaily.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TlpDaily.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TlpDaily.Size = New System.Drawing.Size(820, 120)
        Me.TlpDaily.TabIndex = 19
        '
        'ChkMoonPhase
        '
        Me.ChkMoonPhase.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkMoonPhase.AutoSize = True
        Me.ChkMoonPhase.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkMoonPhase.Location = New System.Drawing.Point(618, 63)
        Me.ChkMoonPhase.Name = "ChkMoonPhase"
        Me.ChkMoonPhase.Size = New System.Drawing.Size(199, 24)
        Me.ChkMoonPhase.TabIndex = 14
        Me.ChkMoonPhase.Tag = "14"
        Me.ChkMoonPhase.Text = "Moon Phase"
        Me.ChkMoonPhase.UseVisualStyleBackColor = False
        '
        'ChkTemp
        '
        Me.ChkTemp.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkTemp.AutoSize = True
        Me.ChkTemp.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkTemp.Location = New System.Drawing.Point(3, 3)
        Me.ChkTemp.Name = "ChkTemp"
        Me.ChkTemp.Size = New System.Drawing.Size(199, 24)
        Me.ChkTemp.TabIndex = 0
        Me.ChkTemp.Tag = "0"
        Me.ChkTemp.Text = "Temperature"
        Me.ChkTemp.UseVisualStyleBackColor = False
        '
        'ChkWxCode
        '
        Me.ChkWxCode.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkWxCode.AutoSize = True
        Me.ChkWxCode.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkWxCode.Location = New System.Drawing.Point(618, 33)
        Me.ChkWxCode.Name = "ChkWxCode"
        Me.ChkWxCode.Size = New System.Drawing.Size(199, 24)
        Me.ChkWxCode.TabIndex = 13
        Me.ChkWxCode.Tag = "13"
        Me.ChkWxCode.Text = "Weather Code"
        Me.ChkWxCode.UseVisualStyleBackColor = False
        '
        'ChkFeelsLike
        '
        Me.ChkFeelsLike.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkFeelsLike.AutoSize = True
        Me.ChkFeelsLike.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkFeelsLike.Location = New System.Drawing.Point(3, 33)
        Me.ChkFeelsLike.Name = "ChkFeelsLike"
        Me.ChkFeelsLike.Size = New System.Drawing.Size(199, 24)
        Me.ChkFeelsLike.TabIndex = 1
        Me.ChkFeelsLike.Tag = "1"
        Me.ChkFeelsLike.Text = "Feels Like"
        Me.ChkFeelsLike.UseVisualStyleBackColor = False
        '
        'ChkVis
        '
        Me.ChkVis.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkVis.AutoSize = True
        Me.ChkVis.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkVis.Location = New System.Drawing.Point(618, 3)
        Me.ChkVis.Name = "ChkVis"
        Me.ChkVis.Size = New System.Drawing.Size(199, 24)
        Me.ChkVis.TabIndex = 12
        Me.ChkVis.Tag = "12"
        Me.ChkVis.Text = "Visibility"
        Me.ChkVis.UseVisualStyleBackColor = False
        '
        'ChkPrecip
        '
        Me.ChkPrecip.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkPrecip.AutoSize = True
        Me.ChkPrecip.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkPrecip.Location = New System.Drawing.Point(208, 93)
        Me.ChkPrecip.Name = "ChkPrecip"
        Me.ChkPrecip.Size = New System.Drawing.Size(199, 24)
        Me.ChkPrecip.TabIndex = 7
        Me.ChkPrecip.Tag = "7"
        Me.ChkPrecip.Text = "Precipitation"
        Me.ChkPrecip.UseVisualStyleBackColor = False
        '
        'ChkSunset
        '
        Me.ChkSunset.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkSunset.AutoSize = True
        Me.ChkSunset.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkSunset.Location = New System.Drawing.Point(413, 93)
        Me.ChkSunset.Name = "ChkSunset"
        Me.ChkSunset.Size = New System.Drawing.Size(199, 24)
        Me.ChkSunset.TabIndex = 11
        Me.ChkSunset.Tag = "11"
        Me.ChkSunset.Text = "Sunset"
        Me.ChkSunset.UseVisualStyleBackColor = False
        '
        'ChkSunrise
        '
        Me.ChkSunrise.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkSunrise.AutoSize = True
        Me.ChkSunrise.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkSunrise.Location = New System.Drawing.Point(413, 63)
        Me.ChkSunrise.Name = "ChkSunrise"
        Me.ChkSunrise.Size = New System.Drawing.Size(199, 24)
        Me.ChkSunrise.TabIndex = 10
        Me.ChkSunrise.Tag = "10"
        Me.ChkSunrise.Text = "Sunrise"
        Me.ChkSunrise.UseVisualStyleBackColor = False
        '
        'ChkPrecipAcc
        '
        Me.ChkPrecipAcc.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkPrecipAcc.AutoSize = True
        Me.ChkPrecipAcc.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkPrecipAcc.Location = New System.Drawing.Point(413, 33)
        Me.ChkPrecipAcc.Name = "ChkPrecipAcc"
        Me.ChkPrecipAcc.Size = New System.Drawing.Size(199, 24)
        Me.ChkPrecipAcc.TabIndex = 9
        Me.ChkPrecipAcc.Tag = "9"
        Me.ChkPrecipAcc.Text = "Precipitation Accumulation"
        Me.ChkPrecipAcc.UseVisualStyleBackColor = False
        '
        'ChkPrecipProb
        '
        Me.ChkPrecipProb.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkPrecipProb.AutoSize = True
        Me.ChkPrecipProb.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkPrecipProb.Location = New System.Drawing.Point(413, 3)
        Me.ChkPrecipProb.Name = "ChkPrecipProb"
        Me.ChkPrecipProb.Size = New System.Drawing.Size(199, 24)
        Me.ChkPrecipProb.TabIndex = 8
        Me.ChkPrecipProb.Tag = "8"
        Me.ChkPrecipProb.Text = "Precipitation Probability"
        Me.ChkPrecipProb.UseVisualStyleBackColor = False
        '
        'ChkDewpoint
        '
        Me.ChkDewpoint.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkDewpoint.AutoSize = True
        Me.ChkDewpoint.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkDewpoint.Location = New System.Drawing.Point(3, 63)
        Me.ChkDewpoint.Name = "ChkDewpoint"
        Me.ChkDewpoint.Size = New System.Drawing.Size(199, 24)
        Me.ChkDewpoint.TabIndex = 2
        Me.ChkDewpoint.Tag = "2"
        Me.ChkDewpoint.Text = "Dewpoint"
        Me.ChkDewpoint.UseVisualStyleBackColor = False
        '
        'ChkHumidity
        '
        Me.ChkHumidity.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkHumidity.AutoSize = True
        Me.ChkHumidity.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkHumidity.Location = New System.Drawing.Point(3, 93)
        Me.ChkHumidity.Name = "ChkHumidity"
        Me.ChkHumidity.Size = New System.Drawing.Size(199, 24)
        Me.ChkHumidity.TabIndex = 3
        Me.ChkHumidity.Tag = "3"
        Me.ChkHumidity.Text = "Humidity"
        Me.ChkHumidity.UseVisualStyleBackColor = False
        '
        'ChkBP
        '
        Me.ChkBP.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkBP.AutoSize = True
        Me.ChkBP.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkBP.Location = New System.Drawing.Point(208, 63)
        Me.ChkBP.Name = "ChkBP"
        Me.ChkBP.Size = New System.Drawing.Size(199, 24)
        Me.ChkBP.TabIndex = 6
        Me.ChkBP.Tag = "6"
        Me.ChkBP.Text = "Barometric Pressure"
        Me.ChkBP.UseVisualStyleBackColor = False
        '
        'ChkWindDir
        '
        Me.ChkWindDir.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkWindDir.AutoSize = True
        Me.ChkWindDir.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkWindDir.Location = New System.Drawing.Point(208, 33)
        Me.ChkWindDir.Name = "ChkWindDir"
        Me.ChkWindDir.Size = New System.Drawing.Size(199, 24)
        Me.ChkWindDir.TabIndex = 5
        Me.ChkWindDir.Tag = "5"
        Me.ChkWindDir.Text = "Wind Direction"
        Me.ChkWindDir.UseVisualStyleBackColor = False
        '
        'ChkWindSpeed
        '
        Me.ChkWindSpeed.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkWindSpeed.AutoSize = True
        Me.ChkWindSpeed.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkWindSpeed.Location = New System.Drawing.Point(208, 3)
        Me.ChkWindSpeed.Name = "ChkWindSpeed"
        Me.ChkWindSpeed.Size = New System.Drawing.Size(199, 24)
        Me.ChkWindSpeed.TabIndex = 4
        Me.ChkWindSpeed.Tag = "4"
        Me.ChkWindSpeed.Text = "Wind Speed"
        Me.ChkWindSpeed.UseVisualStyleBackColor = False
        '
        'ChkAllDaily
        '
        Me.ChkAllDaily.AutoSize = True
        Me.ChkAllDaily.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkAllDaily.Location = New System.Drawing.Point(263, 181)
        Me.ChkAllDaily.Name = "ChkAllDaily"
        Me.ChkAllDaily.Size = New System.Drawing.Size(110, 24)
        Me.ChkAllDaily.TabIndex = 0
        Me.ChkAllDaily.Text = "Check All"
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
        Me.PnlHourlyForecast.Controls.Add(Me.ChkUncheckAllHr)
        Me.PnlHourlyForecast.Controls.Add(Me.Label6)
        Me.PnlHourlyForecast.Controls.Add(Me.TlpHourly)
        Me.PnlHourlyForecast.Controls.Add(Me.ChkAllHourly)
        Me.PnlHourlyForecast.Location = New System.Drawing.Point(94, 235)
        Me.PnlHourlyForecast.Name = "PnlHourlyForecast"
        Me.PnlHourlyForecast.Size = New System.Drawing.Size(1193, 499)
        Me.PnlHourlyForecast.TabIndex = 22
        '
        'ChkUncheckAllHr
        '
        Me.ChkUncheckAllHr.AutoSize = True
        Me.ChkUncheckAllHr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkUncheckAllHr.Location = New System.Drawing.Point(667, 460)
        Me.ChkUncheckAllHr.Name = "ChkUncheckAllHr"
        Me.ChkUncheckAllHr.Size = New System.Drawing.Size(110, 24)
        Me.ChkUncheckAllHr.TabIndex = 22
        Me.ChkUncheckAllHr.Text = "Check All"
        Me.ChkUncheckAllHr.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Maroon
        Me.Label6.Location = New System.Drawing.Point(473, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(245, 25)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Hourly Forecast Options"
        '
        'TlpHourly
        '
        Me.TlpHourly.ColumnCount = 5
        Me.TlpHourly.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TlpHourly.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TlpHourly.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TlpHourly.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TlpHourly.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TlpHourly.Controls.Add(Me.ChkHrRiskCondition, 4, 10)
        Me.TlpHourly.Controls.Add(Me.ChkHrRiskConfidence, 4, 9)
        Me.TlpHourly.Controls.Add(Me.ChkHrRiskScore, 4, 8)
        Me.TlpHourly.Controls.Add(Me.ChkHrHailRisk, 1, 7)
        Me.TlpHourly.Controls.Add(Me.ChkHourTemp, 0, 0)
        Me.TlpHourly.Controls.Add(Me.ChkHourFeelsLike, 0, 1)
        Me.TlpHourly.Controls.Add(Me.ChkHrRoadRisk, 4, 7)
        Me.TlpHourly.Controls.Add(Me.ChkHourRH, 0, 2)
        Me.TlpHourly.Controls.Add(Me.ChkHourChinaPollutant, 4, 6)
        Me.TlpHourly.Controls.Add(Me.ChkHourChinaConcern, 4, 5)
        Me.TlpHourly.Controls.Add(Me.ChkHourChinaAqi, 4, 4)
        Me.TlpHourly.Controls.Add(Me.ChkHourEpaPollutant, 4, 3)
        Me.TlpHourly.Controls.Add(Me.ChkHourEpaAqi, 4, 1)
        Me.TlpHourly.Controls.Add(Me.ChkHourEpaConcern, 4, 2)
        Me.TlpHourly.Controls.Add(Me.ChkHourAqiNo2, 4, 0)
        Me.TlpHourly.Controls.Add(Me.ChkHourAqiO3, 3, 10)
        Me.TlpHourly.Controls.Add(Me.ChkHourAqiSo2, 3, 12)
        Me.TlpHourly.Controls.Add(Me.ChkHourAqiCo, 3, 11)
        Me.TlpHourly.Controls.Add(Me.ChkHourAqiPm25, 3, 9)
        Me.TlpHourly.Controls.Add(Me.ChkHourWindDir, 0, 3)
        Me.TlpHourly.Controls.Add(Me.ChkHourWindGust, 0, 4)
        Me.TlpHourly.Controls.Add(Me.ChkHourPrecip, 0, 5)
        Me.TlpHourly.Controls.Add(Me.ChkHourPrecipType, 0, 6)
        Me.TlpHourly.Controls.Add(Me.ChkHourPrecipProb, 0, 7)
        Me.TlpHourly.Controls.Add(Me.ChkHourSunrise, 0, 8)
        Me.TlpHourly.Controls.Add(Me.ChkHourVis, 0, 9)
        Me.TlpHourly.Controls.Add(Me.ChkHourCloudCover, 0, 10)
        Me.TlpHourly.Controls.Add(Me.ChkHourCloudCeil, 0, 11)
        Me.TlpHourly.Controls.Add(Me.ChkHourMoonPhase, 0, 12)
        Me.TlpHourly.Controls.Add(Me.ChkHourWxCode, 1, 0)
        Me.TlpHourly.Controls.Add(Me.ChkHourAqiPm10, 3, 8)
        Me.TlpHourly.Controls.Add(Me.ChkHourSunset, 1, 1)
        Me.TlpHourly.Controls.Add(Me.ChkHourTreeWalnut, 3, 7)
        Me.TlpHourly.Controls.Add(Me.ChkHourTreeSycamore, 3, 6)
        Me.TlpHourly.Controls.Add(Me.ChkHourTreeSpruce, 3, 5)
        Me.TlpHourly.Controls.Add(Me.ChkHourTreeCottonwood, 3, 4)
        Me.TlpHourly.Controls.Add(Me.ChkHourTreePine, 3, 3)
        Me.TlpHourly.Controls.Add(Me.ChkHourGrass, 3, 2)
        Me.TlpHourly.Controls.Add(Me.ChkHourDewpoint, 1, 2)
        Me.TlpHourly.Controls.Add(Me.ChkHourTreeOak, 3, 1)
        Me.TlpHourly.Controls.Add(Me.ChkHourTreeMahogany, 3, 0)
        Me.TlpHourly.Controls.Add(Me.ChkHourTreeHemlock, 2, 12)
        Me.TlpHourly.Controls.Add(Me.ChkHourTreeCypress, 2, 11)
        Me.TlpHourly.Controls.Add(Me.ChkHourTreeBeech, 2, 10)
        Me.TlpHourly.Controls.Add(Me.ChkHourRagweed, 2, 9)
        Me.TlpHourly.Controls.Add(Me.ChkHourWindSpeed, 1, 3)
        Me.TlpHourly.Controls.Add(Me.ChkHourTreeAsh, 2, 4)
        Me.TlpHourly.Controls.Add(Me.ChkHourTreeCedar, 2, 5)
        Me.TlpHourly.Controls.Add(Me.ChkHourTreeElm, 2, 6)
        Me.TlpHourly.Controls.Add(Me.ChkHourTreeJuniper, 2, 7)
        Me.TlpHourly.Controls.Add(Me.ChkHourTreeMulberry, 2, 8)
        Me.TlpHourly.Controls.Add(Me.ChkHourCloudBase, 1, 4)
        Me.TlpHourly.Controls.Add(Me.ChkHourBP, 1, 5)
        Me.TlpHourly.Controls.Add(Me.ChkHourTreeBirch, 1, 12)
        Me.TlpHourly.Controls.Add(Me.ChkHourSSR, 1, 6)
        Me.TlpHourly.Controls.Add(Me.ChkHourTreeElder, 2, 0)
        Me.TlpHourly.Controls.Add(Me.ChkHourTreePollen, 1, 8)
        Me.TlpHourly.Controls.Add(Me.ChkHourTreeHickory, 2, 1)
        Me.TlpHourly.Controls.Add(Me.ChkHourWeedPollen, 1, 9)
        Me.TlpHourly.Controls.Add(Me.ChkHourTreeMaple, 2, 2)
        Me.TlpHourly.Controls.Add(Me.ChkHourGrassPollen, 1, 10)
        Me.TlpHourly.Controls.Add(Me.ChkHourTreeAcacia, 1, 11)
        Me.TlpHourly.Controls.Add(Me.ChkHourTreeWillow, 2, 3)
        Me.TlpHourly.Location = New System.Drawing.Point(25, 52)
        Me.TlpHourly.MaximumSize = New System.Drawing.Size(1140, 390)
        Me.TlpHourly.MinimumSize = New System.Drawing.Size(1140, 390)
        Me.TlpHourly.Name = "TlpHourly"
        Me.TlpHourly.RowCount = 13
        Me.TlpHourly.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TlpHourly.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TlpHourly.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TlpHourly.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TlpHourly.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TlpHourly.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TlpHourly.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TlpHourly.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TlpHourly.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TlpHourly.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TlpHourly.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TlpHourly.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TlpHourly.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TlpHourly.Size = New System.Drawing.Size(1140, 390)
        Me.TlpHourly.TabIndex = 20
        '
        'ChkHrRiskCondition
        '
        Me.ChkHrRiskCondition.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkHrRiskCondition.AutoSize = True
        Me.ChkHrRiskCondition.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkHrRiskCondition.Location = New System.Drawing.Point(915, 303)
        Me.ChkHrRiskCondition.Name = "ChkHrRiskCondition"
        Me.ChkHrRiskCondition.Size = New System.Drawing.Size(222, 24)
        Me.ChkHrRiskCondition.TabIndex = 62
        Me.ChkHrRiskCondition.Tag = "61"
        Me.ChkHrRiskCondition.Text = "Risk Condition"
        Me.ChkHrRiskCondition.UseVisualStyleBackColor = False
        '
        'ChkHrRiskConfidence
        '
        Me.ChkHrRiskConfidence.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkHrRiskConfidence.AutoSize = True
        Me.ChkHrRiskConfidence.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkHrRiskConfidence.Location = New System.Drawing.Point(915, 273)
        Me.ChkHrRiskConfidence.Name = "ChkHrRiskConfidence"
        Me.ChkHrRiskConfidence.Size = New System.Drawing.Size(222, 24)
        Me.ChkHrRiskConfidence.TabIndex = 61
        Me.ChkHrRiskConfidence.Tag = "60"
        Me.ChkHrRiskConfidence.Text = "Risk Confidence"
        Me.ChkHrRiskConfidence.UseVisualStyleBackColor = False
        '
        'ChkHrRiskScore
        '
        Me.ChkHrRiskScore.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkHrRiskScore.AutoSize = True
        Me.ChkHrRiskScore.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkHrRiskScore.Location = New System.Drawing.Point(915, 243)
        Me.ChkHrRiskScore.Name = "ChkHrRiskScore"
        Me.ChkHrRiskScore.Size = New System.Drawing.Size(222, 24)
        Me.ChkHrRiskScore.TabIndex = 60
        Me.ChkHrRiskScore.Tag = "59"
        Me.ChkHrRiskScore.Text = "Risk Score"
        Me.ChkHrRiskScore.UseVisualStyleBackColor = False
        '
        'ChkHrHailRisk
        '
        Me.ChkHrHailRisk.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkHrHailRisk.AutoSize = True
        Me.ChkHrHailRisk.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkHrHailRisk.Location = New System.Drawing.Point(231, 213)
        Me.ChkHrHailRisk.Name = "ChkHrHailRisk"
        Me.ChkHrHailRisk.Size = New System.Drawing.Size(222, 24)
        Me.ChkHrHailRisk.TabIndex = 20
        Me.ChkHrHailRisk.Tag = "62"
        Me.ChkHrHailRisk.Text = "Hail Risk"
        Me.ChkHrHailRisk.UseVisualStyleBackColor = False
        '
        'ChkHourTemp
        '
        Me.ChkHourTemp.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkHourTemp.AutoSize = True
        Me.ChkHourTemp.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkHourTemp.Location = New System.Drawing.Point(3, 3)
        Me.ChkHourTemp.Name = "ChkHourTemp"
        Me.ChkHourTemp.Size = New System.Drawing.Size(222, 24)
        Me.ChkHourTemp.TabIndex = 0
        Me.ChkHourTemp.Tag = "0"
        Me.ChkHourTemp.Text = "Temperature"
        Me.ChkHourTemp.UseVisualStyleBackColor = False
        '
        'ChkHourFeelsLike
        '
        Me.ChkHourFeelsLike.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkHourFeelsLike.AutoSize = True
        Me.ChkHourFeelsLike.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkHourFeelsLike.Location = New System.Drawing.Point(3, 33)
        Me.ChkHourFeelsLike.Name = "ChkHourFeelsLike"
        Me.ChkHourFeelsLike.Size = New System.Drawing.Size(222, 24)
        Me.ChkHourFeelsLike.TabIndex = 1
        Me.ChkHourFeelsLike.Tag = "1"
        Me.ChkHourFeelsLike.Text = "Feels Like"
        Me.ChkHourFeelsLike.UseVisualStyleBackColor = False
        '
        'ChkHrRoadRisk
        '
        Me.ChkHrRoadRisk.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkHrRoadRisk.AutoSize = True
        Me.ChkHrRoadRisk.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkHrRoadRisk.Location = New System.Drawing.Point(915, 213)
        Me.ChkHrRoadRisk.Name = "ChkHrRoadRisk"
        Me.ChkHrRoadRisk.Size = New System.Drawing.Size(222, 24)
        Me.ChkHrRoadRisk.TabIndex = 59
        Me.ChkHrRoadRisk.Tag = "58"
        Me.ChkHrRoadRisk.Text = "Road Risk"
        Me.ChkHrRoadRisk.UseVisualStyleBackColor = False
        '
        'ChkHourRH
        '
        Me.ChkHourRH.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkHourRH.AutoSize = True
        Me.ChkHourRH.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkHourRH.Location = New System.Drawing.Point(3, 63)
        Me.ChkHourRH.Name = "ChkHourRH"
        Me.ChkHourRH.Size = New System.Drawing.Size(222, 24)
        Me.ChkHourRH.TabIndex = 2
        Me.ChkHourRH.Tag = "3"
        Me.ChkHourRH.Text = "Humidity"
        Me.ChkHourRH.UseVisualStyleBackColor = False
        '
        'ChkHourChinaPollutant
        '
        Me.ChkHourChinaPollutant.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkHourChinaPollutant.AutoSize = True
        Me.ChkHourChinaPollutant.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkHourChinaPollutant.Location = New System.Drawing.Point(915, 183)
        Me.ChkHourChinaPollutant.Name = "ChkHourChinaPollutant"
        Me.ChkHourChinaPollutant.Size = New System.Drawing.Size(222, 24)
        Me.ChkHourChinaPollutant.TabIndex = 58
        Me.ChkHourChinaPollutant.Tag = "57"
        Me.ChkHourChinaPollutant.Text = "China Primary Pollutant"
        Me.ChkHourChinaPollutant.UseVisualStyleBackColor = False
        '
        'ChkHourChinaConcern
        '
        Me.ChkHourChinaConcern.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkHourChinaConcern.AutoSize = True
        Me.ChkHourChinaConcern.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkHourChinaConcern.Location = New System.Drawing.Point(915, 153)
        Me.ChkHourChinaConcern.Name = "ChkHourChinaConcern"
        Me.ChkHourChinaConcern.Size = New System.Drawing.Size(222, 24)
        Me.ChkHourChinaConcern.TabIndex = 57
        Me.ChkHourChinaConcern.Tag = "56"
        Me.ChkHourChinaConcern.Text = "China Health Concern"
        Me.ChkHourChinaConcern.UseVisualStyleBackColor = False
        '
        'ChkHourChinaAqi
        '
        Me.ChkHourChinaAqi.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkHourChinaAqi.AutoSize = True
        Me.ChkHourChinaAqi.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkHourChinaAqi.Location = New System.Drawing.Point(915, 123)
        Me.ChkHourChinaAqi.Name = "ChkHourChinaAqi"
        Me.ChkHourChinaAqi.Size = New System.Drawing.Size(222, 24)
        Me.ChkHourChinaAqi.TabIndex = 56
        Me.ChkHourChinaAqi.Tag = "55"
        Me.ChkHourChinaAqi.Text = "China AQI"
        Me.ChkHourChinaAqi.UseVisualStyleBackColor = False
        '
        'ChkHourEpaPollutant
        '
        Me.ChkHourEpaPollutant.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkHourEpaPollutant.AutoSize = True
        Me.ChkHourEpaPollutant.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkHourEpaPollutant.Location = New System.Drawing.Point(915, 93)
        Me.ChkHourEpaPollutant.Name = "ChkHourEpaPollutant"
        Me.ChkHourEpaPollutant.Size = New System.Drawing.Size(222, 24)
        Me.ChkHourEpaPollutant.TabIndex = 55
        Me.ChkHourEpaPollutant.Tag = "54"
        Me.ChkHourEpaPollutant.Text = "EPA Primary Pollutant"
        Me.ChkHourEpaPollutant.UseVisualStyleBackColor = False
        '
        'ChkHourEpaAqi
        '
        Me.ChkHourEpaAqi.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkHourEpaAqi.AutoSize = True
        Me.ChkHourEpaAqi.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkHourEpaAqi.Location = New System.Drawing.Point(915, 33)
        Me.ChkHourEpaAqi.Name = "ChkHourEpaAqi"
        Me.ChkHourEpaAqi.Size = New System.Drawing.Size(222, 24)
        Me.ChkHourEpaAqi.TabIndex = 53
        Me.ChkHourEpaAqi.Tag = "52"
        Me.ChkHourEpaAqi.Text = "EPA AQI"
        Me.ChkHourEpaAqi.UseVisualStyleBackColor = False
        '
        'ChkHourEpaConcern
        '
        Me.ChkHourEpaConcern.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkHourEpaConcern.AutoSize = True
        Me.ChkHourEpaConcern.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkHourEpaConcern.Location = New System.Drawing.Point(915, 63)
        Me.ChkHourEpaConcern.Name = "ChkHourEpaConcern"
        Me.ChkHourEpaConcern.Size = New System.Drawing.Size(222, 24)
        Me.ChkHourEpaConcern.TabIndex = 54
        Me.ChkHourEpaConcern.Tag = "53"
        Me.ChkHourEpaConcern.Text = "EPA Health Concern"
        Me.ChkHourEpaConcern.UseVisualStyleBackColor = False
        '
        'ChkHourAqiNo2
        '
        Me.ChkHourAqiNo2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkHourAqiNo2.AutoSize = True
        Me.ChkHourAqiNo2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkHourAqiNo2.Location = New System.Drawing.Point(915, 3)
        Me.ChkHourAqiNo2.Name = "ChkHourAqiNo2"
        Me.ChkHourAqiNo2.Size = New System.Drawing.Size(222, 24)
        Me.ChkHourAqiNo2.TabIndex = 52
        Me.ChkHourAqiNo2.Tag = "51"
        Me.ChkHourAqiNo2.Text = "NO2"
        Me.ChkHourAqiNo2.UseVisualStyleBackColor = False
        '
        'ChkHourAqiO3
        '
        Me.ChkHourAqiO3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkHourAqiO3.AutoSize = True
        Me.ChkHourAqiO3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkHourAqiO3.Location = New System.Drawing.Point(687, 303)
        Me.ChkHourAqiO3.Name = "ChkHourAqiO3"
        Me.ChkHourAqiO3.Size = New System.Drawing.Size(222, 24)
        Me.ChkHourAqiO3.TabIndex = 49
        Me.ChkHourAqiO3.Tag = "48"
        Me.ChkHourAqiO3.Text = "O3"
        Me.ChkHourAqiO3.UseVisualStyleBackColor = False
        '
        'ChkHourAqiSo2
        '
        Me.ChkHourAqiSo2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkHourAqiSo2.AutoSize = True
        Me.ChkHourAqiSo2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkHourAqiSo2.Location = New System.Drawing.Point(687, 363)
        Me.ChkHourAqiSo2.Name = "ChkHourAqiSo2"
        Me.ChkHourAqiSo2.Size = New System.Drawing.Size(222, 24)
        Me.ChkHourAqiSo2.TabIndex = 51
        Me.ChkHourAqiSo2.Tag = "50"
        Me.ChkHourAqiSo2.Text = "SO2"
        Me.ChkHourAqiSo2.UseVisualStyleBackColor = False
        '
        'ChkHourAqiCo
        '
        Me.ChkHourAqiCo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkHourAqiCo.AutoSize = True
        Me.ChkHourAqiCo.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkHourAqiCo.Location = New System.Drawing.Point(687, 333)
        Me.ChkHourAqiCo.Name = "ChkHourAqiCo"
        Me.ChkHourAqiCo.Size = New System.Drawing.Size(222, 24)
        Me.ChkHourAqiCo.TabIndex = 50
        Me.ChkHourAqiCo.Tag = "49"
        Me.ChkHourAqiCo.Text = "CO"
        Me.ChkHourAqiCo.UseVisualStyleBackColor = False
        '
        'ChkHourAqiPm25
        '
        Me.ChkHourAqiPm25.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkHourAqiPm25.AutoSize = True
        Me.ChkHourAqiPm25.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkHourAqiPm25.Location = New System.Drawing.Point(687, 273)
        Me.ChkHourAqiPm25.Name = "ChkHourAqiPm25"
        Me.ChkHourAqiPm25.Size = New System.Drawing.Size(222, 24)
        Me.ChkHourAqiPm25.TabIndex = 48
        Me.ChkHourAqiPm25.Tag = "47"
        Me.ChkHourAqiPm25.Text = "PM25"
        Me.ChkHourAqiPm25.UseVisualStyleBackColor = False
        '
        'ChkHourWindDir
        '
        Me.ChkHourWindDir.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkHourWindDir.AutoSize = True
        Me.ChkHourWindDir.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkHourWindDir.Location = New System.Drawing.Point(3, 93)
        Me.ChkHourWindDir.Name = "ChkHourWindDir"
        Me.ChkHourWindDir.Size = New System.Drawing.Size(222, 24)
        Me.ChkHourWindDir.TabIndex = 3
        Me.ChkHourWindDir.Tag = "5"
        Me.ChkHourWindDir.Text = "Wind Direction"
        Me.ChkHourWindDir.UseVisualStyleBackColor = False
        '
        'ChkHourWindGust
        '
        Me.ChkHourWindGust.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkHourWindGust.AutoSize = True
        Me.ChkHourWindGust.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkHourWindGust.Location = New System.Drawing.Point(3, 123)
        Me.ChkHourWindGust.Name = "ChkHourWindGust"
        Me.ChkHourWindGust.Size = New System.Drawing.Size(222, 24)
        Me.ChkHourWindGust.TabIndex = 4
        Me.ChkHourWindGust.Tag = "6"
        Me.ChkHourWindGust.Text = "Wind Gust"
        Me.ChkHourWindGust.UseVisualStyleBackColor = False
        '
        'ChkHourPrecip
        '
        Me.ChkHourPrecip.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkHourPrecip.AutoSize = True
        Me.ChkHourPrecip.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkHourPrecip.Location = New System.Drawing.Point(3, 153)
        Me.ChkHourPrecip.Name = "ChkHourPrecip"
        Me.ChkHourPrecip.Size = New System.Drawing.Size(222, 24)
        Me.ChkHourPrecip.TabIndex = 5
        Me.ChkHourPrecip.Tag = "8"
        Me.ChkHourPrecip.Text = "Precipitation"
        Me.ChkHourPrecip.UseVisualStyleBackColor = False
        '
        'ChkHourPrecipType
        '
        Me.ChkHourPrecipType.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkHourPrecipType.AutoSize = True
        Me.ChkHourPrecipType.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkHourPrecipType.Location = New System.Drawing.Point(3, 183)
        Me.ChkHourPrecipType.Name = "ChkHourPrecipType"
        Me.ChkHourPrecipType.Size = New System.Drawing.Size(222, 24)
        Me.ChkHourPrecipType.TabIndex = 6
        Me.ChkHourPrecipType.Tag = "9"
        Me.ChkHourPrecipType.Text = "Precipitation Type"
        Me.ChkHourPrecipType.UseVisualStyleBackColor = False
        '
        'ChkHourPrecipProb
        '
        Me.ChkHourPrecipProb.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkHourPrecipProb.AutoSize = True
        Me.ChkHourPrecipProb.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkHourPrecipProb.Location = New System.Drawing.Point(3, 213)
        Me.ChkHourPrecipProb.Name = "ChkHourPrecipProb"
        Me.ChkHourPrecipProb.Size = New System.Drawing.Size(222, 24)
        Me.ChkHourPrecipProb.TabIndex = 7
        Me.ChkHourPrecipProb.Tag = "10"
        Me.ChkHourPrecipProb.Text = "Precipitation Probability"
        Me.ChkHourPrecipProb.UseVisualStyleBackColor = False
        '
        'ChkHourSunrise
        '
        Me.ChkHourSunrise.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkHourSunrise.AutoSize = True
        Me.ChkHourSunrise.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkHourSunrise.Location = New System.Drawing.Point(3, 243)
        Me.ChkHourSunrise.Name = "ChkHourSunrise"
        Me.ChkHourSunrise.Size = New System.Drawing.Size(222, 24)
        Me.ChkHourSunrise.TabIndex = 8
        Me.ChkHourSunrise.Tag = "11"
        Me.ChkHourSunrise.Text = "Sunrise"
        Me.ChkHourSunrise.UseVisualStyleBackColor = False
        '
        'ChkHourVis
        '
        Me.ChkHourVis.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkHourVis.AutoSize = True
        Me.ChkHourVis.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkHourVis.Location = New System.Drawing.Point(3, 273)
        Me.ChkHourVis.Name = "ChkHourVis"
        Me.ChkHourVis.Size = New System.Drawing.Size(222, 24)
        Me.ChkHourVis.TabIndex = 9
        Me.ChkHourVis.Tag = "13"
        Me.ChkHourVis.Text = "Visibility"
        Me.ChkHourVis.UseVisualStyleBackColor = False
        '
        'ChkHourCloudCover
        '
        Me.ChkHourCloudCover.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkHourCloudCover.AutoSize = True
        Me.ChkHourCloudCover.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkHourCloudCover.Location = New System.Drawing.Point(3, 303)
        Me.ChkHourCloudCover.Name = "ChkHourCloudCover"
        Me.ChkHourCloudCover.Size = New System.Drawing.Size(222, 24)
        Me.ChkHourCloudCover.TabIndex = 10
        Me.ChkHourCloudCover.Tag = "14"
        Me.ChkHourCloudCover.Text = "Cloud Cover"
        Me.ChkHourCloudCover.UseVisualStyleBackColor = False
        '
        'ChkHourCloudCeil
        '
        Me.ChkHourCloudCeil.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkHourCloudCeil.AutoSize = True
        Me.ChkHourCloudCeil.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkHourCloudCeil.Location = New System.Drawing.Point(3, 333)
        Me.ChkHourCloudCeil.Name = "ChkHourCloudCeil"
        Me.ChkHourCloudCeil.Size = New System.Drawing.Size(222, 24)
        Me.ChkHourCloudCeil.TabIndex = 11
        Me.ChkHourCloudCeil.Tag = "16"
        Me.ChkHourCloudCeil.Text = "Cloud Ceiling"
        Me.ChkHourCloudCeil.UseVisualStyleBackColor = False
        '
        'ChkHourMoonPhase
        '
        Me.ChkHourMoonPhase.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkHourMoonPhase.AutoSize = True
        Me.ChkHourMoonPhase.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkHourMoonPhase.Location = New System.Drawing.Point(3, 363)
        Me.ChkHourMoonPhase.Name = "ChkHourMoonPhase"
        Me.ChkHourMoonPhase.Size = New System.Drawing.Size(222, 24)
        Me.ChkHourMoonPhase.TabIndex = 12
        Me.ChkHourMoonPhase.Tag = "18"
        Me.ChkHourMoonPhase.Text = "Moon Phase"
        Me.ChkHourMoonPhase.UseVisualStyleBackColor = False
        '
        'ChkHourWxCode
        '
        Me.ChkHourWxCode.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkHourWxCode.AutoSize = True
        Me.ChkHourWxCode.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkHourWxCode.Location = New System.Drawing.Point(231, 3)
        Me.ChkHourWxCode.Name = "ChkHourWxCode"
        Me.ChkHourWxCode.Size = New System.Drawing.Size(222, 24)
        Me.ChkHourWxCode.TabIndex = 13
        Me.ChkHourWxCode.Tag = "19"
        Me.ChkHourWxCode.Text = "Weather Code"
        Me.ChkHourWxCode.UseVisualStyleBackColor = False
        '
        'ChkHourAqiPm10
        '
        Me.ChkHourAqiPm10.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkHourAqiPm10.AutoSize = True
        Me.ChkHourAqiPm10.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkHourAqiPm10.Location = New System.Drawing.Point(687, 243)
        Me.ChkHourAqiPm10.Name = "ChkHourAqiPm10"
        Me.ChkHourAqiPm10.Size = New System.Drawing.Size(222, 24)
        Me.ChkHourAqiPm10.TabIndex = 47
        Me.ChkHourAqiPm10.Tag = "46"
        Me.ChkHourAqiPm10.Text = "PM10"
        Me.ChkHourAqiPm10.UseVisualStyleBackColor = False
        '
        'ChkHourSunset
        '
        Me.ChkHourSunset.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkHourSunset.AutoSize = True
        Me.ChkHourSunset.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkHourSunset.Location = New System.Drawing.Point(231, 33)
        Me.ChkHourSunset.Name = "ChkHourSunset"
        Me.ChkHourSunset.Size = New System.Drawing.Size(222, 24)
        Me.ChkHourSunset.TabIndex = 14
        Me.ChkHourSunset.Tag = "12"
        Me.ChkHourSunset.Text = "Sunset"
        Me.ChkHourSunset.UseVisualStyleBackColor = False
        '
        'ChkHourTreeWalnut
        '
        Me.ChkHourTreeWalnut.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkHourTreeWalnut.AutoSize = True
        Me.ChkHourTreeWalnut.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkHourTreeWalnut.Location = New System.Drawing.Point(687, 213)
        Me.ChkHourTreeWalnut.Name = "ChkHourTreeWalnut"
        Me.ChkHourTreeWalnut.Size = New System.Drawing.Size(222, 24)
        Me.ChkHourTreeWalnut.TabIndex = 46
        Me.ChkHourTreeWalnut.Tag = "42"
        Me.ChkHourTreeWalnut.Text = "Walnut"
        Me.ChkHourTreeWalnut.UseVisualStyleBackColor = False
        '
        'ChkHourTreeSycamore
        '
        Me.ChkHourTreeSycamore.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkHourTreeSycamore.AutoSize = True
        Me.ChkHourTreeSycamore.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkHourTreeSycamore.Location = New System.Drawing.Point(687, 183)
        Me.ChkHourTreeSycamore.Name = "ChkHourTreeSycamore"
        Me.ChkHourTreeSycamore.Size = New System.Drawing.Size(222, 24)
        Me.ChkHourTreeSycamore.TabIndex = 45
        Me.ChkHourTreeSycamore.Tag = "41"
        Me.ChkHourTreeSycamore.Text = "Sycamore"
        Me.ChkHourTreeSycamore.UseVisualStyleBackColor = False
        '
        'ChkHourTreeSpruce
        '
        Me.ChkHourTreeSpruce.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkHourTreeSpruce.AutoSize = True
        Me.ChkHourTreeSpruce.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkHourTreeSpruce.Location = New System.Drawing.Point(687, 153)
        Me.ChkHourTreeSpruce.Name = "ChkHourTreeSpruce"
        Me.ChkHourTreeSpruce.Size = New System.Drawing.Size(222, 24)
        Me.ChkHourTreeSpruce.TabIndex = 44
        Me.ChkHourTreeSpruce.Tag = "40"
        Me.ChkHourTreeSpruce.Text = "Spruce"
        Me.ChkHourTreeSpruce.UseVisualStyleBackColor = False
        '
        'ChkHourTreeCottonwood
        '
        Me.ChkHourTreeCottonwood.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkHourTreeCottonwood.AutoSize = True
        Me.ChkHourTreeCottonwood.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkHourTreeCottonwood.Location = New System.Drawing.Point(687, 123)
        Me.ChkHourTreeCottonwood.Name = "ChkHourTreeCottonwood"
        Me.ChkHourTreeCottonwood.Size = New System.Drawing.Size(222, 24)
        Me.ChkHourTreeCottonwood.TabIndex = 43
        Me.ChkHourTreeCottonwood.Tag = "39"
        Me.ChkHourTreeCottonwood.Text = "Cottonwood"
        Me.ChkHourTreeCottonwood.UseVisualStyleBackColor = False
        '
        'ChkHourTreePine
        '
        Me.ChkHourTreePine.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkHourTreePine.AutoSize = True
        Me.ChkHourTreePine.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkHourTreePine.Location = New System.Drawing.Point(687, 93)
        Me.ChkHourTreePine.Name = "ChkHourTreePine"
        Me.ChkHourTreePine.Size = New System.Drawing.Size(222, 24)
        Me.ChkHourTreePine.TabIndex = 42
        Me.ChkHourTreePine.Tag = "38"
        Me.ChkHourTreePine.Text = "Pine"
        Me.ChkHourTreePine.UseVisualStyleBackColor = False
        '
        'ChkHourGrass
        '
        Me.ChkHourGrass.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkHourGrass.AutoSize = True
        Me.ChkHourGrass.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkHourGrass.Location = New System.Drawing.Point(687, 63)
        Me.ChkHourGrass.Name = "ChkHourGrass"
        Me.ChkHourGrass.Size = New System.Drawing.Size(222, 24)
        Me.ChkHourGrass.TabIndex = 41
        Me.ChkHourGrass.Tag = "45"
        Me.ChkHourGrass.Text = "Grass"
        Me.ChkHourGrass.UseVisualStyleBackColor = False
        '
        'ChkHourDewpoint
        '
        Me.ChkHourDewpoint.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkHourDewpoint.AutoSize = True
        Me.ChkHourDewpoint.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkHourDewpoint.Location = New System.Drawing.Point(231, 63)
        Me.ChkHourDewpoint.Name = "ChkHourDewpoint"
        Me.ChkHourDewpoint.Size = New System.Drawing.Size(222, 24)
        Me.ChkHourDewpoint.TabIndex = 15
        Me.ChkHourDewpoint.Tag = "2"
        Me.ChkHourDewpoint.Text = "Dewpoint"
        Me.ChkHourDewpoint.UseVisualStyleBackColor = False
        '
        'ChkHourTreeOak
        '
        Me.ChkHourTreeOak.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkHourTreeOak.AutoSize = True
        Me.ChkHourTreeOak.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkHourTreeOak.Location = New System.Drawing.Point(687, 33)
        Me.ChkHourTreeOak.Name = "ChkHourTreeOak"
        Me.ChkHourTreeOak.Size = New System.Drawing.Size(222, 24)
        Me.ChkHourTreeOak.TabIndex = 40
        Me.ChkHourTreeOak.Tag = "37"
        Me.ChkHourTreeOak.Text = "Oak"
        Me.ChkHourTreeOak.UseVisualStyleBackColor = False
        '
        'ChkHourTreeMahogany
        '
        Me.ChkHourTreeMahogany.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkHourTreeMahogany.AutoSize = True
        Me.ChkHourTreeMahogany.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkHourTreeMahogany.Location = New System.Drawing.Point(687, 3)
        Me.ChkHourTreeMahogany.Name = "ChkHourTreeMahogany"
        Me.ChkHourTreeMahogany.Size = New System.Drawing.Size(222, 24)
        Me.ChkHourTreeMahogany.TabIndex = 39
        Me.ChkHourTreeMahogany.Tag = "34"
        Me.ChkHourTreeMahogany.Text = "Mahogany"
        Me.ChkHourTreeMahogany.UseVisualStyleBackColor = False
        '
        'ChkHourTreeHemlock
        '
        Me.ChkHourTreeHemlock.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkHourTreeHemlock.AutoSize = True
        Me.ChkHourTreeHemlock.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkHourTreeHemlock.Location = New System.Drawing.Point(459, 363)
        Me.ChkHourTreeHemlock.Name = "ChkHourTreeHemlock"
        Me.ChkHourTreeHemlock.Size = New System.Drawing.Size(222, 24)
        Me.ChkHourTreeHemlock.TabIndex = 38
        Me.ChkHourTreeHemlock.Tag = "31"
        Me.ChkHourTreeHemlock.Text = "Hemlock"
        Me.ChkHourTreeHemlock.UseVisualStyleBackColor = False
        '
        'ChkHourTreeCypress
        '
        Me.ChkHourTreeCypress.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkHourTreeCypress.AutoSize = True
        Me.ChkHourTreeCypress.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkHourTreeCypress.Location = New System.Drawing.Point(459, 333)
        Me.ChkHourTreeCypress.Name = "ChkHourTreeCypress"
        Me.ChkHourTreeCypress.Size = New System.Drawing.Size(222, 24)
        Me.ChkHourTreeCypress.TabIndex = 37
        Me.ChkHourTreeCypress.Tag = "28"
        Me.ChkHourTreeCypress.Text = "Cypress"
        Me.ChkHourTreeCypress.UseVisualStyleBackColor = False
        '
        'ChkHourTreeBeech
        '
        Me.ChkHourTreeBeech.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkHourTreeBeech.AutoSize = True
        Me.ChkHourTreeBeech.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkHourTreeBeech.Location = New System.Drawing.Point(459, 303)
        Me.ChkHourTreeBeech.Name = "ChkHourTreeBeech"
        Me.ChkHourTreeBeech.Size = New System.Drawing.Size(222, 24)
        Me.ChkHourTreeBeech.TabIndex = 36
        Me.ChkHourTreeBeech.Tag = "25"
        Me.ChkHourTreeBeech.Text = "Beech"
        Me.ChkHourTreeBeech.UseVisualStyleBackColor = False
        '
        'ChkHourRagweed
        '
        Me.ChkHourRagweed.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkHourRagweed.AutoSize = True
        Me.ChkHourRagweed.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkHourRagweed.Location = New System.Drawing.Point(459, 273)
        Me.ChkHourRagweed.Name = "ChkHourRagweed"
        Me.ChkHourRagweed.Size = New System.Drawing.Size(222, 24)
        Me.ChkHourRagweed.TabIndex = 35
        Me.ChkHourRagweed.Tag = "44"
        Me.ChkHourRagweed.Text = "Ragweed"
        Me.ChkHourRagweed.UseVisualStyleBackColor = False
        '
        'ChkHourWindSpeed
        '
        Me.ChkHourWindSpeed.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkHourWindSpeed.AutoSize = True
        Me.ChkHourWindSpeed.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkHourWindSpeed.Location = New System.Drawing.Point(231, 93)
        Me.ChkHourWindSpeed.Name = "ChkHourWindSpeed"
        Me.ChkHourWindSpeed.Size = New System.Drawing.Size(222, 24)
        Me.ChkHourWindSpeed.TabIndex = 16
        Me.ChkHourWindSpeed.Tag = "4"
        Me.ChkHourWindSpeed.Text = "Wind Speed"
        Me.ChkHourWindSpeed.UseVisualStyleBackColor = False
        '
        'ChkHourTreeAsh
        '
        Me.ChkHourTreeAsh.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkHourTreeAsh.AutoSize = True
        Me.ChkHourTreeAsh.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkHourTreeAsh.Location = New System.Drawing.Point(459, 123)
        Me.ChkHourTreeAsh.Name = "ChkHourTreeAsh"
        Me.ChkHourTreeAsh.Size = New System.Drawing.Size(222, 24)
        Me.ChkHourTreeAsh.TabIndex = 30
        Me.ChkHourTreeAsh.Tag = "24"
        Me.ChkHourTreeAsh.Text = "Ash "
        Me.ChkHourTreeAsh.UseVisualStyleBackColor = False
        '
        'ChkHourTreeCedar
        '
        Me.ChkHourTreeCedar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkHourTreeCedar.AutoSize = True
        Me.ChkHourTreeCedar.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkHourTreeCedar.Location = New System.Drawing.Point(459, 153)
        Me.ChkHourTreeCedar.Name = "ChkHourTreeCedar"
        Me.ChkHourTreeCedar.Size = New System.Drawing.Size(222, 24)
        Me.ChkHourTreeCedar.TabIndex = 31
        Me.ChkHourTreeCedar.Tag = "27"
        Me.ChkHourTreeCedar.Text = "Cedar"
        Me.ChkHourTreeCedar.UseVisualStyleBackColor = False
        '
        'ChkHourTreeElm
        '
        Me.ChkHourTreeElm.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkHourTreeElm.AutoSize = True
        Me.ChkHourTreeElm.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkHourTreeElm.Location = New System.Drawing.Point(459, 183)
        Me.ChkHourTreeElm.Name = "ChkHourTreeElm"
        Me.ChkHourTreeElm.Size = New System.Drawing.Size(222, 24)
        Me.ChkHourTreeElm.TabIndex = 32
        Me.ChkHourTreeElm.Tag = "30"
        Me.ChkHourTreeElm.Text = "Elm"
        Me.ChkHourTreeElm.UseVisualStyleBackColor = False
        '
        'ChkHourTreeJuniper
        '
        Me.ChkHourTreeJuniper.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkHourTreeJuniper.AutoSize = True
        Me.ChkHourTreeJuniper.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkHourTreeJuniper.Location = New System.Drawing.Point(459, 213)
        Me.ChkHourTreeJuniper.Name = "ChkHourTreeJuniper"
        Me.ChkHourTreeJuniper.Size = New System.Drawing.Size(222, 24)
        Me.ChkHourTreeJuniper.TabIndex = 33
        Me.ChkHourTreeJuniper.Tag = "33"
        Me.ChkHourTreeJuniper.Text = "Juniper"
        Me.ChkHourTreeJuniper.UseVisualStyleBackColor = False
        '
        'ChkHourTreeMulberry
        '
        Me.ChkHourTreeMulberry.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkHourTreeMulberry.AutoSize = True
        Me.ChkHourTreeMulberry.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkHourTreeMulberry.Location = New System.Drawing.Point(459, 243)
        Me.ChkHourTreeMulberry.Name = "ChkHourTreeMulberry"
        Me.ChkHourTreeMulberry.Size = New System.Drawing.Size(222, 24)
        Me.ChkHourTreeMulberry.TabIndex = 34
        Me.ChkHourTreeMulberry.Tag = "36"
        Me.ChkHourTreeMulberry.Text = "Mulberry"
        Me.ChkHourTreeMulberry.UseVisualStyleBackColor = False
        '
        'ChkHourCloudBase
        '
        Me.ChkHourCloudBase.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkHourCloudBase.AutoSize = True
        Me.ChkHourCloudBase.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkHourCloudBase.Location = New System.Drawing.Point(231, 123)
        Me.ChkHourCloudBase.Name = "ChkHourCloudBase"
        Me.ChkHourCloudBase.Size = New System.Drawing.Size(222, 24)
        Me.ChkHourCloudBase.TabIndex = 17
        Me.ChkHourCloudBase.Tag = "15"
        Me.ChkHourCloudBase.Text = "Cloud Base"
        Me.ChkHourCloudBase.UseVisualStyleBackColor = False
        '
        'ChkHourBP
        '
        Me.ChkHourBP.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkHourBP.AutoSize = True
        Me.ChkHourBP.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkHourBP.Location = New System.Drawing.Point(231, 153)
        Me.ChkHourBP.Name = "ChkHourBP"
        Me.ChkHourBP.Size = New System.Drawing.Size(222, 24)
        Me.ChkHourBP.TabIndex = 18
        Me.ChkHourBP.Tag = "7"
        Me.ChkHourBP.Text = "Barometric Pressure"
        Me.ChkHourBP.UseVisualStyleBackColor = False
        '
        'ChkHourTreeBirch
        '
        Me.ChkHourTreeBirch.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkHourTreeBirch.AutoSize = True
        Me.ChkHourTreeBirch.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkHourTreeBirch.Location = New System.Drawing.Point(231, 363)
        Me.ChkHourTreeBirch.Name = "ChkHourTreeBirch"
        Me.ChkHourTreeBirch.Size = New System.Drawing.Size(222, 24)
        Me.ChkHourTreeBirch.TabIndex = 25
        Me.ChkHourTreeBirch.Tag = "26"
        Me.ChkHourTreeBirch.Text = "Birch"
        Me.ChkHourTreeBirch.UseVisualStyleBackColor = False
        '
        'ChkHourSSR
        '
        Me.ChkHourSSR.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkHourSSR.AutoSize = True
        Me.ChkHourSSR.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkHourSSR.Location = New System.Drawing.Point(231, 183)
        Me.ChkHourSSR.Name = "ChkHourSSR"
        Me.ChkHourSSR.Size = New System.Drawing.Size(222, 24)
        Me.ChkHourSSR.TabIndex = 19
        Me.ChkHourSSR.Tag = "17"
        Me.ChkHourSSR.Text = "Surface Shortwave Radiation"
        Me.ChkHourSSR.UseVisualStyleBackColor = False
        '
        'ChkHourTreeElder
        '
        Me.ChkHourTreeElder.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkHourTreeElder.AutoSize = True
        Me.ChkHourTreeElder.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkHourTreeElder.Location = New System.Drawing.Point(459, 3)
        Me.ChkHourTreeElder.Name = "ChkHourTreeElder"
        Me.ChkHourTreeElder.Size = New System.Drawing.Size(222, 24)
        Me.ChkHourTreeElder.TabIndex = 26
        Me.ChkHourTreeElder.Tag = "29"
        Me.ChkHourTreeElder.Text = "Elder"
        Me.ChkHourTreeElder.UseVisualStyleBackColor = False
        '
        'ChkHourTreePollen
        '
        Me.ChkHourTreePollen.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkHourTreePollen.AutoSize = True
        Me.ChkHourTreePollen.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkHourTreePollen.Location = New System.Drawing.Point(231, 243)
        Me.ChkHourTreePollen.Name = "ChkHourTreePollen"
        Me.ChkHourTreePollen.Size = New System.Drawing.Size(222, 24)
        Me.ChkHourTreePollen.TabIndex = 21
        Me.ChkHourTreePollen.Tag = "20"
        Me.ChkHourTreePollen.Text = "Tree Pollen"
        Me.ChkHourTreePollen.UseVisualStyleBackColor = False
        '
        'ChkHourTreeHickory
        '
        Me.ChkHourTreeHickory.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkHourTreeHickory.AutoSize = True
        Me.ChkHourTreeHickory.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkHourTreeHickory.Location = New System.Drawing.Point(459, 33)
        Me.ChkHourTreeHickory.Name = "ChkHourTreeHickory"
        Me.ChkHourTreeHickory.Size = New System.Drawing.Size(222, 24)
        Me.ChkHourTreeHickory.TabIndex = 27
        Me.ChkHourTreeHickory.Tag = "32"
        Me.ChkHourTreeHickory.Text = "Hickory"
        Me.ChkHourTreeHickory.UseVisualStyleBackColor = False
        '
        'ChkHourWeedPollen
        '
        Me.ChkHourWeedPollen.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkHourWeedPollen.AutoSize = True
        Me.ChkHourWeedPollen.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkHourWeedPollen.Location = New System.Drawing.Point(231, 273)
        Me.ChkHourWeedPollen.Name = "ChkHourWeedPollen"
        Me.ChkHourWeedPollen.Size = New System.Drawing.Size(222, 24)
        Me.ChkHourWeedPollen.TabIndex = 22
        Me.ChkHourWeedPollen.Tag = "21"
        Me.ChkHourWeedPollen.Text = "Weed Pollen"
        Me.ChkHourWeedPollen.UseVisualStyleBackColor = False
        '
        'ChkHourTreeMaple
        '
        Me.ChkHourTreeMaple.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkHourTreeMaple.AutoSize = True
        Me.ChkHourTreeMaple.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkHourTreeMaple.Location = New System.Drawing.Point(459, 63)
        Me.ChkHourTreeMaple.Name = "ChkHourTreeMaple"
        Me.ChkHourTreeMaple.Size = New System.Drawing.Size(222, 24)
        Me.ChkHourTreeMaple.TabIndex = 28
        Me.ChkHourTreeMaple.Tag = "35"
        Me.ChkHourTreeMaple.Text = "Maple"
        Me.ChkHourTreeMaple.UseVisualStyleBackColor = False
        '
        'ChkHourGrassPollen
        '
        Me.ChkHourGrassPollen.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkHourGrassPollen.AutoSize = True
        Me.ChkHourGrassPollen.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkHourGrassPollen.Location = New System.Drawing.Point(231, 303)
        Me.ChkHourGrassPollen.Name = "ChkHourGrassPollen"
        Me.ChkHourGrassPollen.Size = New System.Drawing.Size(222, 24)
        Me.ChkHourGrassPollen.TabIndex = 23
        Me.ChkHourGrassPollen.Tag = "22"
        Me.ChkHourGrassPollen.Text = "Grass Pollen"
        Me.ChkHourGrassPollen.UseVisualStyleBackColor = False
        '
        'ChkHourTreeAcacia
        '
        Me.ChkHourTreeAcacia.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkHourTreeAcacia.AutoSize = True
        Me.ChkHourTreeAcacia.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkHourTreeAcacia.Location = New System.Drawing.Point(231, 333)
        Me.ChkHourTreeAcacia.Name = "ChkHourTreeAcacia"
        Me.ChkHourTreeAcacia.Size = New System.Drawing.Size(222, 24)
        Me.ChkHourTreeAcacia.TabIndex = 24
        Me.ChkHourTreeAcacia.Tag = "23"
        Me.ChkHourTreeAcacia.Text = "Acacia"
        Me.ChkHourTreeAcacia.UseVisualStyleBackColor = False
        '
        'ChkHourTreeWillow
        '
        Me.ChkHourTreeWillow.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkHourTreeWillow.AutoSize = True
        Me.ChkHourTreeWillow.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkHourTreeWillow.Location = New System.Drawing.Point(459, 93)
        Me.ChkHourTreeWillow.Name = "ChkHourTreeWillow"
        Me.ChkHourTreeWillow.Size = New System.Drawing.Size(222, 24)
        Me.ChkHourTreeWillow.TabIndex = 29
        Me.ChkHourTreeWillow.Tag = "43"
        Me.ChkHourTreeWillow.Text = "Willow"
        Me.ChkHourTreeWillow.UseVisualStyleBackColor = False
        '
        'ChkAllHourly
        '
        Me.ChkAllHourly.AutoSize = True
        Me.ChkAllHourly.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkAllHourly.Location = New System.Drawing.Point(430, 460)
        Me.ChkAllHourly.Name = "ChkAllHourly"
        Me.ChkAllHourly.Size = New System.Drawing.Size(110, 24)
        Me.ChkAllHourly.TabIndex = 0
        Me.ChkAllHourly.Text = "Check All"
        Me.ChkAllHourly.UseVisualStyleBackColor = True
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
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.TlpNowcast)
        Me.Panel1.Controls.Add(Me.ChkUncheckAllNowcast)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.NumNcTimeStep)
        Me.Panel1.Controls.Add(Me.ChkAllNowcast)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(200, 176)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(980, 617)
        Me.Panel1.TabIndex = 23
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Maroon
        Me.Label9.Location = New System.Drawing.Point(401, 33)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(175, 25)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Nowcast Options"
        '
        'TlpNowcast
        '
        Me.TlpNowcast.ColumnCount = 4
        Me.TlpNowcast.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TlpNowcast.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TlpNowcast.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TlpNowcast.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TlpNowcast.Controls.Add(Me.ChkNcRiskCondition, 3, 12)
        Me.TlpNowcast.Controls.Add(Me.ChkNcRiskConfidence, 3, 11)
        Me.TlpNowcast.Controls.Add(Me.ChkNcHailRisk, 1, 2)
        Me.TlpNowcast.Controls.Add(Me.ChkNcTemp, 0, 0)
        Me.TlpNowcast.Controls.Add(Me.ChkNcFeelsLike, 0, 1)
        Me.TlpNowcast.Controls.Add(Me.ChkNcRH, 0, 2)
        Me.TlpNowcast.Controls.Add(Me.ChkNcChinaPollutant, 3, 8)
        Me.TlpNowcast.Controls.Add(Me.ChkNcChinaConcern, 3, 7)
        Me.TlpNowcast.Controls.Add(Me.ChkNcChinaAqi, 3, 6)
        Me.TlpNowcast.Controls.Add(Me.ChkNcEpaPollutant, 3, 5)
        Me.TlpNowcast.Controls.Add(Me.ChkNcEpaAqi, 3, 3)
        Me.TlpNowcast.Controls.Add(Me.ChkNcEpaConcern, 3, 4)
        Me.TlpNowcast.Controls.Add(Me.ChkNcNo2, 3, 2)
        Me.TlpNowcast.Controls.Add(Me.ChkNcO3, 2, 15)
        Me.TlpNowcast.Controls.Add(Me.ChkNcSo2, 3, 1)
        Me.TlpNowcast.Controls.Add(Me.ChkNcCo, 3, 0)
        Me.TlpNowcast.Controls.Add(Me.ChkNcPm25, 2, 14)
        Me.TlpNowcast.Controls.Add(Me.ChkNcWindDir, 0, 3)
        Me.TlpNowcast.Controls.Add(Me.ChkNcWindGust, 0, 4)
        Me.TlpNowcast.Controls.Add(Me.ChkNcPrecip, 0, 5)
        Me.TlpNowcast.Controls.Add(Me.ChkNcPrecipType, 0, 6)
        Me.TlpNowcast.Controls.Add(Me.ChkNcSunrise, 0, 7)
        Me.TlpNowcast.Controls.Add(Me.ChkNcVis, 0, 8)
        Me.TlpNowcast.Controls.Add(Me.ChkNcCloudCover, 0, 9)
        Me.TlpNowcast.Controls.Add(Me.ChkNcCloudCeil, 0, 10)
        Me.TlpNowcast.Controls.Add(Me.ChkNcWxCode, 0, 11)
        Me.TlpNowcast.Controls.Add(Me.ChkNcSunset, 0, 12)
        Me.TlpNowcast.Controls.Add(Me.ChkNcDewpoint, 0, 13)
        Me.TlpNowcast.Controls.Add(Me.ChkNcPm10, 2, 13)
        Me.TlpNowcast.Controls.Add(Me.ChkNcWindSpeed, 0, 14)
        Me.TlpNowcast.Controls.Add(Me.ChkNcWalnut, 2, 12)
        Me.TlpNowcast.Controls.Add(Me.ChkNcSycamore, 2, 11)
        Me.TlpNowcast.Controls.Add(Me.ChkNcSpruce, 2, 10)
        Me.TlpNowcast.Controls.Add(Me.ChkNcCottonwood, 2, 9)
        Me.TlpNowcast.Controls.Add(Me.ChkNcPine, 2, 8)
        Me.TlpNowcast.Controls.Add(Me.ChkNcGrass, 2, 7)
        Me.TlpNowcast.Controls.Add(Me.ChkNcCloudBase, 0, 15)
        Me.TlpNowcast.Controls.Add(Me.ChkNcOak, 2, 6)
        Me.TlpNowcast.Controls.Add(Me.ChkNcMahogany, 2, 5)
        Me.TlpNowcast.Controls.Add(Me.ChkNcHemlock, 2, 4)
        Me.TlpNowcast.Controls.Add(Me.ChkNcCypress, 2, 3)
        Me.TlpNowcast.Controls.Add(Me.ChkNcBeech, 2, 2)
        Me.TlpNowcast.Controls.Add(Me.ChkNcRagweed, 2, 1)
        Me.TlpNowcast.Controls.Add(Me.ChkNcBP, 1, 0)
        Me.TlpNowcast.Controls.Add(Me.ChkNcAsh, 1, 12)
        Me.TlpNowcast.Controls.Add(Me.ChkNcCedar, 1, 13)
        Me.TlpNowcast.Controls.Add(Me.ChkNcElm, 1, 14)
        Me.TlpNowcast.Controls.Add(Me.ChkNcJuniper, 1, 15)
        Me.TlpNowcast.Controls.Add(Me.ChkNcMulberry, 2, 0)
        Me.TlpNowcast.Controls.Add(Me.ChkNcSSR, 1, 1)
        Me.TlpNowcast.Controls.Add(Me.ChkNcTreePollen, 1, 3)
        Me.TlpNowcast.Controls.Add(Me.ChkNcBirch, 1, 7)
        Me.TlpNowcast.Controls.Add(Me.ChkNcWeedPollen, 1, 4)
        Me.TlpNowcast.Controls.Add(Me.ChkNcElder, 1, 8)
        Me.TlpNowcast.Controls.Add(Me.ChkNcGrassPollen, 1, 5)
        Me.TlpNowcast.Controls.Add(Me.ChkNcHickory, 1, 9)
        Me.TlpNowcast.Controls.Add(Me.ChkNcAcacia, 1, 6)
        Me.TlpNowcast.Controls.Add(Me.ChkNcMaple, 1, 10)
        Me.TlpNowcast.Controls.Add(Me.ChkNcWillow, 1, 11)
        Me.TlpNowcast.Controls.Add(Me.ChkNcRoadRisk, 3, 9)
        Me.TlpNowcast.Controls.Add(Me.ChkNcRiskScore, 3, 10)
        Me.TlpNowcast.Location = New System.Drawing.Point(29, 69)
        Me.TlpNowcast.MaximumSize = New System.Drawing.Size(918, 480)
        Me.TlpNowcast.MinimumSize = New System.Drawing.Size(918, 480)
        Me.TlpNowcast.Name = "TlpNowcast"
        Me.TlpNowcast.RowCount = 16
        Me.TlpNowcast.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25!))
        Me.TlpNowcast.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25!))
        Me.TlpNowcast.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25!))
        Me.TlpNowcast.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25!))
        Me.TlpNowcast.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25!))
        Me.TlpNowcast.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25!))
        Me.TlpNowcast.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25!))
        Me.TlpNowcast.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25!))
        Me.TlpNowcast.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25!))
        Me.TlpNowcast.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25!))
        Me.TlpNowcast.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25!))
        Me.TlpNowcast.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25!))
        Me.TlpNowcast.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25!))
        Me.TlpNowcast.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25!))
        Me.TlpNowcast.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25!))
        Me.TlpNowcast.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25!))
        Me.TlpNowcast.Size = New System.Drawing.Size(918, 480)
        Me.TlpNowcast.TabIndex = 27
        '
        'ChkNcRiskCondition
        '
        Me.ChkNcRiskCondition.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkNcRiskCondition.AutoSize = True
        Me.ChkNcRiskCondition.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkNcRiskCondition.Location = New System.Drawing.Point(688, 361)
        Me.ChkNcRiskCondition.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkNcRiskCondition.Name = "ChkNcRiskCondition"
        Me.ChkNcRiskCondition.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkNcRiskCondition.Size = New System.Drawing.Size(229, 28)
        Me.ChkNcRiskCondition.TabIndex = 60
        Me.ChkNcRiskCondition.Tag = "60"
        Me.ChkNcRiskCondition.Text = "Risk Condition"
        Me.ChkNcRiskCondition.UseVisualStyleBackColor = True
        '
        'ChkNcRiskConfidence
        '
        Me.ChkNcRiskConfidence.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkNcRiskConfidence.AutoSize = True
        Me.ChkNcRiskConfidence.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkNcRiskConfidence.Location = New System.Drawing.Point(688, 331)
        Me.ChkNcRiskConfidence.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkNcRiskConfidence.Name = "ChkNcRiskConfidence"
        Me.ChkNcRiskConfidence.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkNcRiskConfidence.Size = New System.Drawing.Size(229, 28)
        Me.ChkNcRiskConfidence.TabIndex = 59
        Me.ChkNcRiskConfidence.Tag = "59"
        Me.ChkNcRiskConfidence.Text = "Risk Confidence"
        Me.ChkNcRiskConfidence.UseVisualStyleBackColor = True
        '
        'ChkNcHailRisk
        '
        Me.ChkNcHailRisk.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkNcHailRisk.AutoSize = True
        Me.ChkNcHailRisk.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkNcHailRisk.Location = New System.Drawing.Point(230, 61)
        Me.ChkNcHailRisk.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkNcHailRisk.Name = "ChkNcHailRisk"
        Me.ChkNcHailRisk.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkNcHailRisk.Size = New System.Drawing.Size(227, 28)
        Me.ChkNcHailRisk.TabIndex = 18
        Me.ChkNcHailRisk.Tag = "18"
        Me.ChkNcHailRisk.Text = "Hail Risk"
        Me.ChkNcHailRisk.UseVisualStyleBackColor = True
        '
        'ChkNcTemp
        '
        Me.ChkNcTemp.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkNcTemp.AutoSize = True
        Me.ChkNcTemp.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkNcTemp.Location = New System.Drawing.Point(1, 1)
        Me.ChkNcTemp.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkNcTemp.Name = "ChkNcTemp"
        Me.ChkNcTemp.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkNcTemp.Size = New System.Drawing.Size(227, 28)
        Me.ChkNcTemp.TabIndex = 0
        Me.ChkNcTemp.Tag = "0"
        Me.ChkNcTemp.Text = "Temperature"
        Me.ChkNcTemp.UseVisualStyleBackColor = True
        '
        'ChkNcFeelsLike
        '
        Me.ChkNcFeelsLike.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkNcFeelsLike.AutoSize = True
        Me.ChkNcFeelsLike.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkNcFeelsLike.Location = New System.Drawing.Point(1, 31)
        Me.ChkNcFeelsLike.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkNcFeelsLike.Name = "ChkNcFeelsLike"
        Me.ChkNcFeelsLike.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkNcFeelsLike.Size = New System.Drawing.Size(227, 28)
        Me.ChkNcFeelsLike.TabIndex = 1
        Me.ChkNcFeelsLike.Tag = "1"
        Me.ChkNcFeelsLike.Text = "Feels Like"
        Me.ChkNcFeelsLike.UseVisualStyleBackColor = True
        '
        'ChkNcRH
        '
        Me.ChkNcRH.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkNcRH.AutoSize = True
        Me.ChkNcRH.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkNcRH.Location = New System.Drawing.Point(1, 61)
        Me.ChkNcRH.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkNcRH.Name = "ChkNcRH"
        Me.ChkNcRH.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkNcRH.Size = New System.Drawing.Size(227, 28)
        Me.ChkNcRH.TabIndex = 2
        Me.ChkNcRH.Tag = "2"
        Me.ChkNcRH.Text = "Humidity"
        Me.ChkNcRH.UseVisualStyleBackColor = True
        '
        'ChkNcChinaPollutant
        '
        Me.ChkNcChinaPollutant.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkNcChinaPollutant.AutoSize = True
        Me.ChkNcChinaPollutant.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkNcChinaPollutant.Location = New System.Drawing.Point(688, 241)
        Me.ChkNcChinaPollutant.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkNcChinaPollutant.Name = "ChkNcChinaPollutant"
        Me.ChkNcChinaPollutant.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkNcChinaPollutant.Size = New System.Drawing.Size(229, 28)
        Me.ChkNcChinaPollutant.TabIndex = 56
        Me.ChkNcChinaPollutant.Tag = "56"
        Me.ChkNcChinaPollutant.Text = "China Primary Pollutant"
        Me.ChkNcChinaPollutant.UseVisualStyleBackColor = True
        '
        'ChkNcChinaConcern
        '
        Me.ChkNcChinaConcern.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkNcChinaConcern.AutoSize = True
        Me.ChkNcChinaConcern.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkNcChinaConcern.Location = New System.Drawing.Point(688, 211)
        Me.ChkNcChinaConcern.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkNcChinaConcern.Name = "ChkNcChinaConcern"
        Me.ChkNcChinaConcern.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkNcChinaConcern.Size = New System.Drawing.Size(229, 28)
        Me.ChkNcChinaConcern.TabIndex = 55
        Me.ChkNcChinaConcern.Tag = "55"
        Me.ChkNcChinaConcern.Text = "China Health Concern"
        Me.ChkNcChinaConcern.UseVisualStyleBackColor = True
        '
        'ChkNcChinaAqi
        '
        Me.ChkNcChinaAqi.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkNcChinaAqi.AutoSize = True
        Me.ChkNcChinaAqi.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkNcChinaAqi.Location = New System.Drawing.Point(688, 181)
        Me.ChkNcChinaAqi.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkNcChinaAqi.Name = "ChkNcChinaAqi"
        Me.ChkNcChinaAqi.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkNcChinaAqi.Size = New System.Drawing.Size(229, 28)
        Me.ChkNcChinaAqi.TabIndex = 54
        Me.ChkNcChinaAqi.Tag = "54"
        Me.ChkNcChinaAqi.Text = "China AQI"
        Me.ChkNcChinaAqi.UseVisualStyleBackColor = True
        '
        'ChkNcEpaPollutant
        '
        Me.ChkNcEpaPollutant.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkNcEpaPollutant.AutoSize = True
        Me.ChkNcEpaPollutant.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkNcEpaPollutant.Location = New System.Drawing.Point(688, 151)
        Me.ChkNcEpaPollutant.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkNcEpaPollutant.Name = "ChkNcEpaPollutant"
        Me.ChkNcEpaPollutant.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkNcEpaPollutant.Size = New System.Drawing.Size(229, 28)
        Me.ChkNcEpaPollutant.TabIndex = 53
        Me.ChkNcEpaPollutant.Tag = "53"
        Me.ChkNcEpaPollutant.Text = "EPA Primary Pollutant"
        Me.ChkNcEpaPollutant.UseVisualStyleBackColor = True
        '
        'ChkNcEpaAqi
        '
        Me.ChkNcEpaAqi.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkNcEpaAqi.AutoSize = True
        Me.ChkNcEpaAqi.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkNcEpaAqi.Location = New System.Drawing.Point(688, 91)
        Me.ChkNcEpaAqi.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkNcEpaAqi.Name = "ChkNcEpaAqi"
        Me.ChkNcEpaAqi.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkNcEpaAqi.Size = New System.Drawing.Size(229, 28)
        Me.ChkNcEpaAqi.TabIndex = 51
        Me.ChkNcEpaAqi.Tag = "51"
        Me.ChkNcEpaAqi.Text = "EPA AQI"
        Me.ChkNcEpaAqi.UseVisualStyleBackColor = True
        '
        'ChkNcEpaConcern
        '
        Me.ChkNcEpaConcern.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkNcEpaConcern.AutoSize = True
        Me.ChkNcEpaConcern.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkNcEpaConcern.Location = New System.Drawing.Point(688, 121)
        Me.ChkNcEpaConcern.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkNcEpaConcern.Name = "ChkNcEpaConcern"
        Me.ChkNcEpaConcern.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkNcEpaConcern.Size = New System.Drawing.Size(229, 28)
        Me.ChkNcEpaConcern.TabIndex = 52
        Me.ChkNcEpaConcern.Tag = "52"
        Me.ChkNcEpaConcern.Text = "EPA Health Concern"
        Me.ChkNcEpaConcern.UseVisualStyleBackColor = True
        '
        'ChkNcNo2
        '
        Me.ChkNcNo2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkNcNo2.AutoSize = True
        Me.ChkNcNo2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkNcNo2.Location = New System.Drawing.Point(688, 61)
        Me.ChkNcNo2.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkNcNo2.Name = "ChkNcNo2"
        Me.ChkNcNo2.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkNcNo2.Size = New System.Drawing.Size(229, 28)
        Me.ChkNcNo2.TabIndex = 50
        Me.ChkNcNo2.Tag = "50"
        Me.ChkNcNo2.Text = "NO2"
        Me.ChkNcNo2.UseVisualStyleBackColor = True
        '
        'ChkNcO3
        '
        Me.ChkNcO3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkNcO3.AutoSize = True
        Me.ChkNcO3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkNcO3.Location = New System.Drawing.Point(459, 451)
        Me.ChkNcO3.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkNcO3.Name = "ChkNcO3"
        Me.ChkNcO3.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkNcO3.Size = New System.Drawing.Size(227, 28)
        Me.ChkNcO3.TabIndex = 47
        Me.ChkNcO3.Tag = "47"
        Me.ChkNcO3.Text = "O3"
        Me.ChkNcO3.UseVisualStyleBackColor = True
        '
        'ChkNcSo2
        '
        Me.ChkNcSo2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkNcSo2.AutoSize = True
        Me.ChkNcSo2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkNcSo2.Location = New System.Drawing.Point(688, 31)
        Me.ChkNcSo2.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkNcSo2.Name = "ChkNcSo2"
        Me.ChkNcSo2.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkNcSo2.Size = New System.Drawing.Size(229, 28)
        Me.ChkNcSo2.TabIndex = 49
        Me.ChkNcSo2.Tag = "49"
        Me.ChkNcSo2.Text = "SO2"
        Me.ChkNcSo2.UseVisualStyleBackColor = True
        '
        'ChkNcCo
        '
        Me.ChkNcCo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkNcCo.AutoSize = True
        Me.ChkNcCo.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkNcCo.Location = New System.Drawing.Point(688, 1)
        Me.ChkNcCo.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkNcCo.Name = "ChkNcCo"
        Me.ChkNcCo.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkNcCo.Size = New System.Drawing.Size(229, 28)
        Me.ChkNcCo.TabIndex = 48
        Me.ChkNcCo.Tag = "48"
        Me.ChkNcCo.Text = "CO"
        Me.ChkNcCo.UseVisualStyleBackColor = True
        '
        'ChkNcPm25
        '
        Me.ChkNcPm25.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkNcPm25.AutoSize = True
        Me.ChkNcPm25.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkNcPm25.Location = New System.Drawing.Point(459, 421)
        Me.ChkNcPm25.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkNcPm25.Name = "ChkNcPm25"
        Me.ChkNcPm25.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkNcPm25.Size = New System.Drawing.Size(227, 28)
        Me.ChkNcPm25.TabIndex = 46
        Me.ChkNcPm25.Tag = "46"
        Me.ChkNcPm25.Text = "PM25"
        Me.ChkNcPm25.UseVisualStyleBackColor = True
        '
        'ChkNcWindDir
        '
        Me.ChkNcWindDir.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkNcWindDir.AutoSize = True
        Me.ChkNcWindDir.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkNcWindDir.Location = New System.Drawing.Point(1, 91)
        Me.ChkNcWindDir.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkNcWindDir.Name = "ChkNcWindDir"
        Me.ChkNcWindDir.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkNcWindDir.Size = New System.Drawing.Size(227, 28)
        Me.ChkNcWindDir.TabIndex = 3
        Me.ChkNcWindDir.Tag = "3"
        Me.ChkNcWindDir.Text = "Wind Direction"
        Me.ChkNcWindDir.UseVisualStyleBackColor = True
        '
        'ChkNcWindGust
        '
        Me.ChkNcWindGust.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkNcWindGust.AutoSize = True
        Me.ChkNcWindGust.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkNcWindGust.Location = New System.Drawing.Point(1, 121)
        Me.ChkNcWindGust.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkNcWindGust.Name = "ChkNcWindGust"
        Me.ChkNcWindGust.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkNcWindGust.Size = New System.Drawing.Size(227, 28)
        Me.ChkNcWindGust.TabIndex = 4
        Me.ChkNcWindGust.Tag = "4"
        Me.ChkNcWindGust.Text = "Wind Gust"
        Me.ChkNcWindGust.UseVisualStyleBackColor = True
        '
        'ChkNcPrecip
        '
        Me.ChkNcPrecip.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkNcPrecip.AutoSize = True
        Me.ChkNcPrecip.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkNcPrecip.Location = New System.Drawing.Point(1, 151)
        Me.ChkNcPrecip.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkNcPrecip.Name = "ChkNcPrecip"
        Me.ChkNcPrecip.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkNcPrecip.Size = New System.Drawing.Size(227, 28)
        Me.ChkNcPrecip.TabIndex = 5
        Me.ChkNcPrecip.Tag = "5"
        Me.ChkNcPrecip.Text = "Precipitation"
        Me.ChkNcPrecip.UseVisualStyleBackColor = True
        '
        'ChkNcPrecipType
        '
        Me.ChkNcPrecipType.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkNcPrecipType.AutoSize = True
        Me.ChkNcPrecipType.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkNcPrecipType.Location = New System.Drawing.Point(1, 181)
        Me.ChkNcPrecipType.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkNcPrecipType.Name = "ChkNcPrecipType"
        Me.ChkNcPrecipType.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkNcPrecipType.Size = New System.Drawing.Size(227, 28)
        Me.ChkNcPrecipType.TabIndex = 6
        Me.ChkNcPrecipType.Tag = "6"
        Me.ChkNcPrecipType.Text = "Precipitation Type"
        Me.ChkNcPrecipType.UseVisualStyleBackColor = True
        '
        'ChkNcSunrise
        '
        Me.ChkNcSunrise.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkNcSunrise.AutoSize = True
        Me.ChkNcSunrise.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkNcSunrise.Location = New System.Drawing.Point(1, 211)
        Me.ChkNcSunrise.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkNcSunrise.Name = "ChkNcSunrise"
        Me.ChkNcSunrise.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkNcSunrise.Size = New System.Drawing.Size(227, 28)
        Me.ChkNcSunrise.TabIndex = 7
        Me.ChkNcSunrise.Tag = "7"
        Me.ChkNcSunrise.Text = "Sunrise"
        Me.ChkNcSunrise.UseVisualStyleBackColor = True
        '
        'ChkNcVis
        '
        Me.ChkNcVis.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkNcVis.AutoSize = True
        Me.ChkNcVis.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkNcVis.Location = New System.Drawing.Point(1, 241)
        Me.ChkNcVis.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkNcVis.Name = "ChkNcVis"
        Me.ChkNcVis.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkNcVis.Size = New System.Drawing.Size(227, 28)
        Me.ChkNcVis.TabIndex = 8
        Me.ChkNcVis.Tag = "8"
        Me.ChkNcVis.Text = "Visibility"
        Me.ChkNcVis.UseVisualStyleBackColor = True
        '
        'ChkNcCloudCover
        '
        Me.ChkNcCloudCover.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkNcCloudCover.AutoSize = True
        Me.ChkNcCloudCover.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkNcCloudCover.Location = New System.Drawing.Point(1, 271)
        Me.ChkNcCloudCover.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkNcCloudCover.Name = "ChkNcCloudCover"
        Me.ChkNcCloudCover.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkNcCloudCover.Size = New System.Drawing.Size(227, 28)
        Me.ChkNcCloudCover.TabIndex = 9
        Me.ChkNcCloudCover.Tag = "9"
        Me.ChkNcCloudCover.Text = "Cloud Cover"
        Me.ChkNcCloudCover.UseVisualStyleBackColor = True
        '
        'ChkNcCloudCeil
        '
        Me.ChkNcCloudCeil.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkNcCloudCeil.AutoSize = True
        Me.ChkNcCloudCeil.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkNcCloudCeil.Location = New System.Drawing.Point(1, 301)
        Me.ChkNcCloudCeil.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkNcCloudCeil.Name = "ChkNcCloudCeil"
        Me.ChkNcCloudCeil.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkNcCloudCeil.Size = New System.Drawing.Size(227, 28)
        Me.ChkNcCloudCeil.TabIndex = 10
        Me.ChkNcCloudCeil.Tag = "10"
        Me.ChkNcCloudCeil.Text = "Cloud Ceiling"
        Me.ChkNcCloudCeil.UseVisualStyleBackColor = True
        '
        'ChkNcWxCode
        '
        Me.ChkNcWxCode.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkNcWxCode.AutoSize = True
        Me.ChkNcWxCode.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkNcWxCode.Location = New System.Drawing.Point(1, 331)
        Me.ChkNcWxCode.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkNcWxCode.Name = "ChkNcWxCode"
        Me.ChkNcWxCode.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkNcWxCode.Size = New System.Drawing.Size(227, 28)
        Me.ChkNcWxCode.TabIndex = 11
        Me.ChkNcWxCode.Tag = "11"
        Me.ChkNcWxCode.Text = "Weather Code"
        Me.ChkNcWxCode.UseVisualStyleBackColor = True
        '
        'ChkNcSunset
        '
        Me.ChkNcSunset.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkNcSunset.AutoSize = True
        Me.ChkNcSunset.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkNcSunset.Location = New System.Drawing.Point(1, 361)
        Me.ChkNcSunset.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkNcSunset.Name = "ChkNcSunset"
        Me.ChkNcSunset.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkNcSunset.Size = New System.Drawing.Size(227, 28)
        Me.ChkNcSunset.TabIndex = 12
        Me.ChkNcSunset.Tag = "12"
        Me.ChkNcSunset.Text = "Sunset"
        Me.ChkNcSunset.UseVisualStyleBackColor = True
        '
        'ChkNcDewpoint
        '
        Me.ChkNcDewpoint.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkNcDewpoint.AutoSize = True
        Me.ChkNcDewpoint.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkNcDewpoint.Location = New System.Drawing.Point(1, 391)
        Me.ChkNcDewpoint.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkNcDewpoint.Name = "ChkNcDewpoint"
        Me.ChkNcDewpoint.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkNcDewpoint.Size = New System.Drawing.Size(227, 28)
        Me.ChkNcDewpoint.TabIndex = 13
        Me.ChkNcDewpoint.Tag = "13"
        Me.ChkNcDewpoint.Text = "Dewpoint"
        Me.ChkNcDewpoint.UseVisualStyleBackColor = True
        '
        'ChkNcPm10
        '
        Me.ChkNcPm10.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkNcPm10.AutoSize = True
        Me.ChkNcPm10.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkNcPm10.Location = New System.Drawing.Point(459, 391)
        Me.ChkNcPm10.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkNcPm10.Name = "ChkNcPm10"
        Me.ChkNcPm10.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkNcPm10.Size = New System.Drawing.Size(227, 28)
        Me.ChkNcPm10.TabIndex = 45
        Me.ChkNcPm10.Tag = "45"
        Me.ChkNcPm10.Text = "PM10"
        Me.ChkNcPm10.UseVisualStyleBackColor = True
        '
        'ChkNcWindSpeed
        '
        Me.ChkNcWindSpeed.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkNcWindSpeed.AutoSize = True
        Me.ChkNcWindSpeed.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkNcWindSpeed.Location = New System.Drawing.Point(1, 421)
        Me.ChkNcWindSpeed.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkNcWindSpeed.Name = "ChkNcWindSpeed"
        Me.ChkNcWindSpeed.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkNcWindSpeed.Size = New System.Drawing.Size(227, 28)
        Me.ChkNcWindSpeed.TabIndex = 14
        Me.ChkNcWindSpeed.Tag = "14"
        Me.ChkNcWindSpeed.Text = "Wind Speed"
        Me.ChkNcWindSpeed.UseVisualStyleBackColor = True
        '
        'ChkNcWalnut
        '
        Me.ChkNcWalnut.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkNcWalnut.AutoSize = True
        Me.ChkNcWalnut.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkNcWalnut.Location = New System.Drawing.Point(459, 361)
        Me.ChkNcWalnut.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkNcWalnut.Name = "ChkNcWalnut"
        Me.ChkNcWalnut.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkNcWalnut.Size = New System.Drawing.Size(227, 28)
        Me.ChkNcWalnut.TabIndex = 44
        Me.ChkNcWalnut.Tag = "44"
        Me.ChkNcWalnut.Text = "Walnut"
        Me.ChkNcWalnut.UseVisualStyleBackColor = True
        '
        'ChkNcSycamore
        '
        Me.ChkNcSycamore.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkNcSycamore.AutoSize = True
        Me.ChkNcSycamore.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkNcSycamore.Location = New System.Drawing.Point(459, 331)
        Me.ChkNcSycamore.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkNcSycamore.Name = "ChkNcSycamore"
        Me.ChkNcSycamore.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkNcSycamore.Size = New System.Drawing.Size(227, 28)
        Me.ChkNcSycamore.TabIndex = 43
        Me.ChkNcSycamore.Tag = "43"
        Me.ChkNcSycamore.Text = "Sycamore"
        Me.ChkNcSycamore.UseVisualStyleBackColor = True
        '
        'ChkNcSpruce
        '
        Me.ChkNcSpruce.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkNcSpruce.AutoSize = True
        Me.ChkNcSpruce.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkNcSpruce.Location = New System.Drawing.Point(459, 301)
        Me.ChkNcSpruce.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkNcSpruce.Name = "ChkNcSpruce"
        Me.ChkNcSpruce.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkNcSpruce.Size = New System.Drawing.Size(227, 28)
        Me.ChkNcSpruce.TabIndex = 42
        Me.ChkNcSpruce.Tag = "42"
        Me.ChkNcSpruce.Text = "Spruce"
        Me.ChkNcSpruce.UseVisualStyleBackColor = True
        '
        'ChkNcCottonwood
        '
        Me.ChkNcCottonwood.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkNcCottonwood.AutoSize = True
        Me.ChkNcCottonwood.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkNcCottonwood.Location = New System.Drawing.Point(459, 271)
        Me.ChkNcCottonwood.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkNcCottonwood.Name = "ChkNcCottonwood"
        Me.ChkNcCottonwood.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkNcCottonwood.Size = New System.Drawing.Size(227, 28)
        Me.ChkNcCottonwood.TabIndex = 41
        Me.ChkNcCottonwood.Tag = "41"
        Me.ChkNcCottonwood.Text = "Cottonwood"
        Me.ChkNcCottonwood.UseVisualStyleBackColor = True
        '
        'ChkNcPine
        '
        Me.ChkNcPine.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkNcPine.AutoSize = True
        Me.ChkNcPine.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkNcPine.Location = New System.Drawing.Point(459, 241)
        Me.ChkNcPine.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkNcPine.Name = "ChkNcPine"
        Me.ChkNcPine.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkNcPine.Size = New System.Drawing.Size(227, 28)
        Me.ChkNcPine.TabIndex = 40
        Me.ChkNcPine.Tag = "40"
        Me.ChkNcPine.Text = "Pine"
        Me.ChkNcPine.UseVisualStyleBackColor = True
        '
        'ChkNcGrass
        '
        Me.ChkNcGrass.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkNcGrass.AutoSize = True
        Me.ChkNcGrass.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkNcGrass.Location = New System.Drawing.Point(459, 211)
        Me.ChkNcGrass.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkNcGrass.Name = "ChkNcGrass"
        Me.ChkNcGrass.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkNcGrass.Size = New System.Drawing.Size(227, 28)
        Me.ChkNcGrass.TabIndex = 39
        Me.ChkNcGrass.Tag = "39"
        Me.ChkNcGrass.Text = "Grass"
        Me.ChkNcGrass.UseVisualStyleBackColor = True
        '
        'ChkNcCloudBase
        '
        Me.ChkNcCloudBase.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkNcCloudBase.AutoSize = True
        Me.ChkNcCloudBase.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkNcCloudBase.Location = New System.Drawing.Point(1, 451)
        Me.ChkNcCloudBase.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkNcCloudBase.Name = "ChkNcCloudBase"
        Me.ChkNcCloudBase.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkNcCloudBase.Size = New System.Drawing.Size(227, 28)
        Me.ChkNcCloudBase.TabIndex = 15
        Me.ChkNcCloudBase.Tag = "15"
        Me.ChkNcCloudBase.Text = "Cloud Base"
        Me.ChkNcCloudBase.UseVisualStyleBackColor = True
        '
        'ChkNcOak
        '
        Me.ChkNcOak.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkNcOak.AutoSize = True
        Me.ChkNcOak.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkNcOak.Location = New System.Drawing.Point(459, 181)
        Me.ChkNcOak.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkNcOak.Name = "ChkNcOak"
        Me.ChkNcOak.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkNcOak.Size = New System.Drawing.Size(227, 28)
        Me.ChkNcOak.TabIndex = 38
        Me.ChkNcOak.Tag = "38"
        Me.ChkNcOak.Text = "Oak"
        Me.ChkNcOak.UseVisualStyleBackColor = True
        '
        'ChkNcMahogany
        '
        Me.ChkNcMahogany.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkNcMahogany.AutoSize = True
        Me.ChkNcMahogany.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkNcMahogany.Location = New System.Drawing.Point(459, 151)
        Me.ChkNcMahogany.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkNcMahogany.Name = "ChkNcMahogany"
        Me.ChkNcMahogany.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkNcMahogany.Size = New System.Drawing.Size(227, 28)
        Me.ChkNcMahogany.TabIndex = 37
        Me.ChkNcMahogany.Tag = "37"
        Me.ChkNcMahogany.Text = "Mahogany"
        Me.ChkNcMahogany.UseVisualStyleBackColor = True
        '
        'ChkNcHemlock
        '
        Me.ChkNcHemlock.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkNcHemlock.AutoSize = True
        Me.ChkNcHemlock.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkNcHemlock.Location = New System.Drawing.Point(459, 121)
        Me.ChkNcHemlock.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkNcHemlock.Name = "ChkNcHemlock"
        Me.ChkNcHemlock.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkNcHemlock.Size = New System.Drawing.Size(227, 28)
        Me.ChkNcHemlock.TabIndex = 36
        Me.ChkNcHemlock.Tag = "36"
        Me.ChkNcHemlock.Text = "Hemlock"
        Me.ChkNcHemlock.UseVisualStyleBackColor = True
        '
        'ChkNcCypress
        '
        Me.ChkNcCypress.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkNcCypress.AutoSize = True
        Me.ChkNcCypress.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkNcCypress.Location = New System.Drawing.Point(459, 91)
        Me.ChkNcCypress.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkNcCypress.Name = "ChkNcCypress"
        Me.ChkNcCypress.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkNcCypress.Size = New System.Drawing.Size(227, 28)
        Me.ChkNcCypress.TabIndex = 35
        Me.ChkNcCypress.Tag = "35"
        Me.ChkNcCypress.Text = "Cypress"
        Me.ChkNcCypress.UseVisualStyleBackColor = True
        '
        'ChkNcBeech
        '
        Me.ChkNcBeech.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkNcBeech.AutoSize = True
        Me.ChkNcBeech.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkNcBeech.Location = New System.Drawing.Point(459, 61)
        Me.ChkNcBeech.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkNcBeech.Name = "ChkNcBeech"
        Me.ChkNcBeech.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkNcBeech.Size = New System.Drawing.Size(227, 28)
        Me.ChkNcBeech.TabIndex = 34
        Me.ChkNcBeech.Tag = "34"
        Me.ChkNcBeech.Text = "Beech"
        Me.ChkNcBeech.UseVisualStyleBackColor = True
        '
        'ChkNcRagweed
        '
        Me.ChkNcRagweed.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkNcRagweed.AutoSize = True
        Me.ChkNcRagweed.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkNcRagweed.Location = New System.Drawing.Point(459, 31)
        Me.ChkNcRagweed.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkNcRagweed.Name = "ChkNcRagweed"
        Me.ChkNcRagweed.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkNcRagweed.Size = New System.Drawing.Size(227, 28)
        Me.ChkNcRagweed.TabIndex = 33
        Me.ChkNcRagweed.Tag = "33"
        Me.ChkNcRagweed.Text = "Ragweed"
        Me.ChkNcRagweed.UseVisualStyleBackColor = True
        '
        'ChkNcBP
        '
        Me.ChkNcBP.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkNcBP.AutoSize = True
        Me.ChkNcBP.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkNcBP.Location = New System.Drawing.Point(230, 1)
        Me.ChkNcBP.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkNcBP.Name = "ChkNcBP"
        Me.ChkNcBP.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkNcBP.Size = New System.Drawing.Size(227, 28)
        Me.ChkNcBP.TabIndex = 16
        Me.ChkNcBP.Tag = "16"
        Me.ChkNcBP.Text = "Barometric Pressure"
        Me.ChkNcBP.UseVisualStyleBackColor = True
        '
        'ChkNcAsh
        '
        Me.ChkNcAsh.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkNcAsh.AutoSize = True
        Me.ChkNcAsh.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkNcAsh.Location = New System.Drawing.Point(230, 361)
        Me.ChkNcAsh.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkNcAsh.Name = "ChkNcAsh"
        Me.ChkNcAsh.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkNcAsh.Size = New System.Drawing.Size(227, 28)
        Me.ChkNcAsh.TabIndex = 28
        Me.ChkNcAsh.Tag = "28"
        Me.ChkNcAsh.Text = "Ash "
        Me.ChkNcAsh.UseVisualStyleBackColor = True
        '
        'ChkNcCedar
        '
        Me.ChkNcCedar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkNcCedar.AutoSize = True
        Me.ChkNcCedar.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkNcCedar.Location = New System.Drawing.Point(230, 391)
        Me.ChkNcCedar.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkNcCedar.Name = "ChkNcCedar"
        Me.ChkNcCedar.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkNcCedar.Size = New System.Drawing.Size(227, 28)
        Me.ChkNcCedar.TabIndex = 29
        Me.ChkNcCedar.Tag = "29"
        Me.ChkNcCedar.Text = "Cedar"
        Me.ChkNcCedar.UseVisualStyleBackColor = True
        '
        'ChkNcElm
        '
        Me.ChkNcElm.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkNcElm.AutoSize = True
        Me.ChkNcElm.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkNcElm.Location = New System.Drawing.Point(230, 421)
        Me.ChkNcElm.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkNcElm.Name = "ChkNcElm"
        Me.ChkNcElm.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkNcElm.Size = New System.Drawing.Size(227, 28)
        Me.ChkNcElm.TabIndex = 30
        Me.ChkNcElm.Tag = "30"
        Me.ChkNcElm.Text = "Elm"
        Me.ChkNcElm.UseVisualStyleBackColor = True
        '
        'ChkNcJuniper
        '
        Me.ChkNcJuniper.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkNcJuniper.AutoSize = True
        Me.ChkNcJuniper.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkNcJuniper.Location = New System.Drawing.Point(230, 451)
        Me.ChkNcJuniper.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkNcJuniper.Name = "ChkNcJuniper"
        Me.ChkNcJuniper.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkNcJuniper.Size = New System.Drawing.Size(227, 28)
        Me.ChkNcJuniper.TabIndex = 31
        Me.ChkNcJuniper.Tag = "31"
        Me.ChkNcJuniper.Text = "Juniper"
        Me.ChkNcJuniper.UseVisualStyleBackColor = True
        '
        'ChkNcMulberry
        '
        Me.ChkNcMulberry.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkNcMulberry.AutoSize = True
        Me.ChkNcMulberry.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkNcMulberry.Location = New System.Drawing.Point(459, 1)
        Me.ChkNcMulberry.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkNcMulberry.Name = "ChkNcMulberry"
        Me.ChkNcMulberry.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkNcMulberry.Size = New System.Drawing.Size(227, 28)
        Me.ChkNcMulberry.TabIndex = 32
        Me.ChkNcMulberry.Tag = "32"
        Me.ChkNcMulberry.Text = "Mulberry"
        Me.ChkNcMulberry.UseVisualStyleBackColor = True
        '
        'ChkNcSSR
        '
        Me.ChkNcSSR.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkNcSSR.AutoSize = True
        Me.ChkNcSSR.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkNcSSR.Location = New System.Drawing.Point(230, 31)
        Me.ChkNcSSR.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkNcSSR.Name = "ChkNcSSR"
        Me.ChkNcSSR.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkNcSSR.Size = New System.Drawing.Size(227, 28)
        Me.ChkNcSSR.TabIndex = 17
        Me.ChkNcSSR.Tag = "17"
        Me.ChkNcSSR.Text = "Surface Shortwave Radiation"
        Me.ChkNcSSR.UseVisualStyleBackColor = True
        '
        'ChkNcTreePollen
        '
        Me.ChkNcTreePollen.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkNcTreePollen.AutoSize = True
        Me.ChkNcTreePollen.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkNcTreePollen.Location = New System.Drawing.Point(230, 91)
        Me.ChkNcTreePollen.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkNcTreePollen.Name = "ChkNcTreePollen"
        Me.ChkNcTreePollen.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkNcTreePollen.Size = New System.Drawing.Size(227, 28)
        Me.ChkNcTreePollen.TabIndex = 19
        Me.ChkNcTreePollen.Tag = "19"
        Me.ChkNcTreePollen.Text = "Tree Pollen"
        Me.ChkNcTreePollen.UseVisualStyleBackColor = True
        '
        'ChkNcBirch
        '
        Me.ChkNcBirch.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkNcBirch.AutoSize = True
        Me.ChkNcBirch.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkNcBirch.Location = New System.Drawing.Point(230, 211)
        Me.ChkNcBirch.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkNcBirch.Name = "ChkNcBirch"
        Me.ChkNcBirch.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkNcBirch.Size = New System.Drawing.Size(227, 28)
        Me.ChkNcBirch.TabIndex = 23
        Me.ChkNcBirch.Tag = "23"
        Me.ChkNcBirch.Text = "Birch"
        Me.ChkNcBirch.UseVisualStyleBackColor = True
        '
        'ChkNcWeedPollen
        '
        Me.ChkNcWeedPollen.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkNcWeedPollen.AutoSize = True
        Me.ChkNcWeedPollen.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkNcWeedPollen.Location = New System.Drawing.Point(230, 121)
        Me.ChkNcWeedPollen.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkNcWeedPollen.Name = "ChkNcWeedPollen"
        Me.ChkNcWeedPollen.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkNcWeedPollen.Size = New System.Drawing.Size(227, 28)
        Me.ChkNcWeedPollen.TabIndex = 20
        Me.ChkNcWeedPollen.Tag = "20"
        Me.ChkNcWeedPollen.Text = "Weed Pollen"
        Me.ChkNcWeedPollen.UseVisualStyleBackColor = True
        '
        'ChkNcElder
        '
        Me.ChkNcElder.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkNcElder.AutoSize = True
        Me.ChkNcElder.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkNcElder.Location = New System.Drawing.Point(230, 241)
        Me.ChkNcElder.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkNcElder.Name = "ChkNcElder"
        Me.ChkNcElder.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkNcElder.Size = New System.Drawing.Size(227, 28)
        Me.ChkNcElder.TabIndex = 24
        Me.ChkNcElder.Tag = "24"
        Me.ChkNcElder.Text = "Elder"
        Me.ChkNcElder.UseVisualStyleBackColor = True
        '
        'ChkNcGrassPollen
        '
        Me.ChkNcGrassPollen.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkNcGrassPollen.AutoSize = True
        Me.ChkNcGrassPollen.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkNcGrassPollen.Location = New System.Drawing.Point(230, 151)
        Me.ChkNcGrassPollen.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkNcGrassPollen.Name = "ChkNcGrassPollen"
        Me.ChkNcGrassPollen.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkNcGrassPollen.Size = New System.Drawing.Size(227, 28)
        Me.ChkNcGrassPollen.TabIndex = 21
        Me.ChkNcGrassPollen.Tag = "21"
        Me.ChkNcGrassPollen.Text = "Grass Pollen"
        Me.ChkNcGrassPollen.UseVisualStyleBackColor = True
        '
        'ChkNcHickory
        '
        Me.ChkNcHickory.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkNcHickory.AutoSize = True
        Me.ChkNcHickory.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkNcHickory.Location = New System.Drawing.Point(230, 271)
        Me.ChkNcHickory.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkNcHickory.Name = "ChkNcHickory"
        Me.ChkNcHickory.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkNcHickory.Size = New System.Drawing.Size(227, 28)
        Me.ChkNcHickory.TabIndex = 25
        Me.ChkNcHickory.Tag = "25"
        Me.ChkNcHickory.Text = "Hickory"
        Me.ChkNcHickory.UseVisualStyleBackColor = True
        '
        'ChkNcAcacia
        '
        Me.ChkNcAcacia.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkNcAcacia.AutoSize = True
        Me.ChkNcAcacia.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkNcAcacia.Location = New System.Drawing.Point(230, 181)
        Me.ChkNcAcacia.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkNcAcacia.Name = "ChkNcAcacia"
        Me.ChkNcAcacia.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkNcAcacia.Size = New System.Drawing.Size(227, 28)
        Me.ChkNcAcacia.TabIndex = 22
        Me.ChkNcAcacia.Tag = "22"
        Me.ChkNcAcacia.Text = "Acacia"
        Me.ChkNcAcacia.UseVisualStyleBackColor = True
        '
        'ChkNcMaple
        '
        Me.ChkNcMaple.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkNcMaple.AutoSize = True
        Me.ChkNcMaple.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkNcMaple.Location = New System.Drawing.Point(230, 301)
        Me.ChkNcMaple.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkNcMaple.Name = "ChkNcMaple"
        Me.ChkNcMaple.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkNcMaple.Size = New System.Drawing.Size(227, 28)
        Me.ChkNcMaple.TabIndex = 26
        Me.ChkNcMaple.Tag = "26"
        Me.ChkNcMaple.Text = "Maple"
        Me.ChkNcMaple.UseVisualStyleBackColor = True
        '
        'ChkNcWillow
        '
        Me.ChkNcWillow.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkNcWillow.AutoSize = True
        Me.ChkNcWillow.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkNcWillow.Location = New System.Drawing.Point(230, 331)
        Me.ChkNcWillow.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkNcWillow.Name = "ChkNcWillow"
        Me.ChkNcWillow.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkNcWillow.Size = New System.Drawing.Size(227, 28)
        Me.ChkNcWillow.TabIndex = 27
        Me.ChkNcWillow.Tag = "27"
        Me.ChkNcWillow.Text = "Willow"
        Me.ChkNcWillow.UseVisualStyleBackColor = True
        '
        'ChkNcRoadRisk
        '
        Me.ChkNcRoadRisk.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkNcRoadRisk.AutoSize = True
        Me.ChkNcRoadRisk.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkNcRoadRisk.Enabled = False
        Me.ChkNcRoadRisk.Location = New System.Drawing.Point(688, 271)
        Me.ChkNcRoadRisk.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkNcRoadRisk.Name = "ChkNcRoadRisk"
        Me.ChkNcRoadRisk.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkNcRoadRisk.Size = New System.Drawing.Size(229, 28)
        Me.ChkNcRoadRisk.TabIndex = 57
        Me.ChkNcRoadRisk.Tag = "57"
        Me.ChkNcRoadRisk.Text = "Road Risk"
        Me.ChkNcRoadRisk.UseVisualStyleBackColor = True
        '
        'ChkNcRiskScore
        '
        Me.ChkNcRiskScore.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkNcRiskScore.AutoSize = True
        Me.ChkNcRiskScore.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChkNcRiskScore.Location = New System.Drawing.Point(688, 301)
        Me.ChkNcRiskScore.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkNcRiskScore.Name = "ChkNcRiskScore"
        Me.ChkNcRiskScore.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkNcRiskScore.Size = New System.Drawing.Size(229, 28)
        Me.ChkNcRiskScore.TabIndex = 58
        Me.ChkNcRiskScore.Tag = "58"
        Me.ChkNcRiskScore.Text = "Risk Score"
        Me.ChkNcRiskScore.UseVisualStyleBackColor = True
        '
        'ChkUncheckAllNowcast
        '
        Me.ChkUncheckAllNowcast.AutoSize = True
        Me.ChkUncheckAllNowcast.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkUncheckAllNowcast.Location = New System.Drawing.Point(717, 569)
        Me.ChkUncheckAllNowcast.Name = "ChkUncheckAllNowcast"
        Me.ChkUncheckAllNowcast.Size = New System.Drawing.Size(119, 21)
        Me.ChkUncheckAllNowcast.TabIndex = 26
        Me.ChkUncheckAllNowcast.Text = "Uncheck All"
        Me.ChkUncheckAllNowcast.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(94, 571)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(152, 17)
        Me.Label14.TabIndex = 25
        Me.Label14.Text = "Time step (minutes)"
        '
        'NumNcTimeStep
        '
        Me.NumNcTimeStep.Location = New System.Drawing.Point(259, 568)
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
        Me.ChkAllNowcast.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkAllNowcast.Location = New System.Drawing.Point(488, 569)
        Me.ChkAllNowcast.Name = "ChkAllNowcast"
        Me.ChkAllNowcast.Size = New System.Drawing.Size(101, 21)
        Me.ChkAllNowcast.TabIndex = 1
        Me.ChkAllNowcast.Text = "Check All"
        Me.ChkAllNowcast.UseVisualStyleBackColor = True
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
        Me.TsslNextDaily.Size = New System.Drawing.Size(60, 25)
        Me.TsslNextDaily.Text = "Dly: 0"
        Me.TsslNextDaily.ToolTipText = "Time to next daily update"
        '
        'TsslNextHourly
        '
        Me.TsslNextHourly.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TsslNextHourly.ForeColor = System.Drawing.Color.ForestGreen
        Me.TsslNextHourly.Name = "TsslNextHourly"
        Me.TsslNextHourly.Size = New System.Drawing.Size(54, 25)
        Me.TsslNextHourly.Text = "Hr: 0"
        Me.TsslNextHourly.ToolTipText = "Time to next hourly updatre"
        '
        'TsslNextNowcast
        '
        Me.TsslNextNowcast.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TsslNextNowcast.ForeColor = System.Drawing.Color.Purple
        Me.TsslNextNowcast.Name = "TsslNextNowcast"
        Me.TsslNextNowcast.Size = New System.Drawing.Size(55, 25)
        Me.TsslNextNowcast.Text = "Nc: 0"
        Me.TsslNextNowcast.ToolTipText = "Time to next nowcast update"
        '
        'TsslCpy
        '
        Me.TsslCpy.Font = New System.Drawing.Font("Segoe UI", 7.0!)
        Me.TsslCpy.ForeColor = System.Drawing.Color.Red
        Me.TsslCpy.Name = "TsslCpy"
        Me.TsslCpy.Size = New System.Drawing.Size(1139, 25)
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
        Me.TpLogError.ResumeLayout(False)
        Me.TpOptions.ResumeLayout(False)
        Me.TcOpt.ResumeLayout(False)
        Me.TpOptMain.ResumeLayout(False)
        Me.PnlSettings.ResumeLayout(False)
        Me.PnlMainOpt.ResumeLayout(False)
        Me.TlpMainOpt.ResumeLayout(False)
        Me.TlpMainOpt.PerformLayout()
        CType(Me.NumNowcastInterval, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumHourlyInterval, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumDailyInterval, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumLongitude, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumLatiutude, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TpOptDaily.ResumeLayout(False)
        Me.PnlDailyForecast.ResumeLayout(False)
        Me.PnlDailyForecast.PerformLayout()
        Me.TlpDaily.ResumeLayout(False)
        Me.TlpDaily.PerformLayout()
        Me.TpOptHourly.ResumeLayout(False)
        Me.PnlHourlyForecast.ResumeLayout(False)
        Me.PnlHourlyForecast.PerformLayout()
        Me.TlpHourly.ResumeLayout(False)
        Me.TlpHourly.PerformLayout()
        Me.TpOptNowCast.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TlpNowcast.ResumeLayout(False)
        Me.TlpNowcast.PerformLayout()
        CType(Me.NumNcTimeStep, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents ChkHrHailRisk As CheckBox
    Friend WithEvents ChkHrRiskScore As CheckBox
    Friend WithEvents ChkHrRiskConfidence As CheckBox
    Friend WithEvents ChkHrRiskCondition As CheckBox
    Friend WithEvents ChkHrRoadRisk As CheckBox
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
    Friend WithEvents ChkFetchHourly As CheckBox
    Friend WithEvents ChkFetchDaily As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents NumDailyInterval As NumericUpDown
    Friend WithEvents RbUnitSI As RadioButton
    Friend WithEvents RbUnitUS As RadioButton
    Friend WithEvents TxtApiKey As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents NumLongitude As NumericUpDown
    Friend WithEvents NumLatiutude As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TpOptNowCast As TabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ChkAllNowcast As CheckBox
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
    Friend WithEvents TlpNowcast As TableLayoutPanel
    Friend WithEvents TlpDaily As TableLayoutPanel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TlpHourly As TableLayoutPanel
    Friend WithEvents Label6 As Label
    Friend WithEvents ChkUncheckAllDaily As CheckBox
    Friend WithEvents ChkUncheckAllHr As CheckBox
    Friend WithEvents TlpMainOpt As TableLayoutPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents PnlMainOpt As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label15 As Label
End Class
