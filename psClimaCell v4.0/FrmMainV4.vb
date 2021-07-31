Imports System.IO
Imports IWshRuntimeLibrary

Public Class FrmMainv4

    'https://docs.climacell.co/reference/api-formats#locations
    'https://docs.climacell.co/reference/data-layers-core
    'https://docs.climacell.co/reference/data-layers-overview
    Public tlNfo As CcTimelinesModel()
    Private ReadOnly _desktopPathName As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), My.Application.Info.AssemblyName & ".lnk")
    Private ReadOnly _startupPathName As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Startup), My.Application.Info.AssemblyName & ".lnk")
    Private ReadOnly _startMenuPathName As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.StartMenu), My.Application.Info.AssemblyName & ".lnk")
    Private _loading As Boolean = True

    Friend Shared Sub CollectMemoryGarbage(save As Boolean)
        Dim hg = GC.MaxGeneration
        Dim tmb = GC.GetTotalMemory(False)
        Dim mbc As Long = GC.GetTotalMemory(False)
        GC.Collect()
        Dim tma = GC.GetTotalMemory(False)
        Dim mac As Long = GC.GetTotalMemory(False)
        ''XML literal
        If save Then
            Dim msg = <msg>
Memory Garbage Collection
Highest Generation: <%= hg %>
Total memory before: <%= tmb.ToString("#,### bytes") %>
Total memory after: <%= tma.ToString("#,### bytes") %>
Total memory collected: <%= (mbc - mac).ToString("#,### bytes") %>
                      </msg>.Value
            PrintLog($"{msg}{vbLf}")
            Dim x = Process.GetCurrentProcess()
            PrintLog($"---{vbLf}Memory: {x.WorkingSet64 / 1024:N0} K{vbLf}{vbLf}Paged: {x.PagedMemorySize64 / 1024:N0} K{vbLf}")
            PrintLog($"{My.Resources.separator}{vbLf}")
        End If
        SaveLogs()
    End Sub

    ''' <summary>
    '''     Manually update application settings In Settings create MustUpgrade/Boolean/User/True
    ''' </summary>
    Private Shared Sub UpgradeMySettings()
        'https://stackoverflow.com/questions/1702260/losing-vb-net-my-settings-with-each-new-clickonce-deployment-release
        If My.Settings.MustUpgrade Then
            My.Settings.Upgrade()
            My.Settings.MustUpgrade = False
            My.Settings.Save()
        End If
    End Sub

    Private Sub Dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvDaily.CellClick, DgvCurrent.CellClick, DgvHour.CellClick, Dgv1Min.CellClick, Dgv5Min.CellClick, Dgv15Min.CellClick, Dgv30Min.CellClick, Dgv1dFull.CellClick
        With DirectCast(sender, DataGridView)
            Select Case CInt(.Tag)
                Case 0
                    DgvDaily.ClearSelection()
                Case 1
                    DgvHour.ClearSelection()
                Case 2
                    DgvCurrent.ClearSelection()
                Case 3
                    Dgv1Min.ClearSelection()
                Case 4
                    Dgv5Min.ClearSelection()
                Case 5
                    Dgv15Min.ClearSelection()
                Case 6
                    Dgv30Min.ClearSelection()
                Case 7
                    Dgv1dFull.ClearSelection()
                Case Else
                    Exit Sub
            End Select
        End With
    End Sub

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Application.EnableVisualStyles()
        AppStartTime = Now
        UpgradeMySettings()
        ChkScDesktop.Checked = IO.File.Exists(_desktopPathName)
        ChkScStartup.Checked = IO.File.Exists(_startupPathName)
        ChkScMenu.Checked = IO.File.Exists(_startMenuPathName)
        _loading = False
        LoadProgramSettings()
        CreateProgramFolders()
        StartLogfile()
        PerformLogMaintenance()
        ParseDataFieldUnits()
        AddContextMenu(RtbLog)
        AddContextMenu(RtbError)
        If String.IsNullOrEmpty(My.Settings.ApiKey) Then
            TC.SelectedTab = TpAppOptions
        End If
        Show()

        Text = $"psClimaCell V4 API - Tr: {My.Settings.TimesRun}"
        ShowInTaskbar = My.Settings.ShowTask
        TsslCpy.Text = Cpy
        TsslVer.Text = Application.ProductVersion
        LblAbout.Text = String.Format(My.Resources.about, vbLf, ParseVersion())
        FetchTimeLines(False)
        FetchWildfireData()
        SetMidnightRollover()
        SaveLogs()
        TmrClock.Start()
    End Sub

    Private Sub FrmMainv4_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        SaveLogs()
        My.Settings.Save()
        TIcon.Dispose()
    End Sub

    Private Sub Shortcuts(sender As Object, e As EventArgs) Handles ChkScDesktop.Click, ChkScStartup.Click, ChkScMenu.Click
        If Not _loading Then
            With DirectCast(sender, CheckBox)
                Select Case CInt(.Tag)
                    Case 0
                        CreateShortcut(_desktopPathName, .Checked) 'Create a shortcut on the desktop
                    Case 1
                        CreateShortcut(_startupPathName, .Checked) 'Create a shortcut in the start folder 'Starts with Windows'
                    Case 2
                        CreateShortcut(_startMenuPathName, .Checked) 'Create a shortcut in the start folder 'Starts with Windows'
                End Select
            End With
        End If
    End Sub

    Private Shared Sub CreateShortcut(shortcutPathName As String, create As Boolean)
        If create Then
            Try
                Dim shortcutTarget = Path.Combine(Application.StartupPath, My.Application.Info.AssemblyName & ".exe")
                Dim myShell As New WshShell()
                Dim myShortcut = CType(myShell.CreateShortcut(shortcutPathName), WshShortcut)
                myShortcut.TargetPath = shortcutTarget 'The exe file this shortcut executes when double clicked
                myShortcut.IconLocation = shortcutTarget & ",0" 'Sets the icon of the shortcut to the exe`s icon
                myShortcut.WorkingDirectory = Application.StartupPath 'The working directory for the exe
                myShortcut.Arguments = "" 'The arguments used when executing the exe
                myShortcut.Save() 'Creates the shortcut
                PrintLog($"Created shortcut: {shortcutTarget}{vbLf}")
            Catch ex As Exception When TypeOf ex Is ArgumentException OrElse TypeOf ex Is ArgumentNullException
                PrintLog($"   Error: {ex.Message}{vbLf}   Location: {ex.TargetSite}{vbLf}   Trace: { ex.StackTrace}{vbLf}")
            Finally
                'a
            End Try
        Else
            Try
                If IO.File.Exists(shortcutPathName) Then IO.File.Delete(shortcutPathName)
                PrintLog($"Deleted shortcut: {shortcutPathName}{vbLf}")
            Catch ex As Exception When TypeOf ex Is ArgumentException OrElse TypeOf ex Is ArgumentNullException OrElse TypeOf ex Is IOException
                PrintLog($"   Error: {ex.Message}{vbLf}   Location: {ex.TargetSite}{vbLf}   Trace: { ex.StackTrace}{vbLf}")
            Finally
                'a
            End Try
        End If
    End Sub

    Private Sub TsslRefresh_Click(sender As Object, e As EventArgs) Handles TsslRefresh.Click
        FetchTimeLines(True)
    End Sub

#Region "Timer Routines"

    Private Sub SetMidnightRollover()
        ''set the date to midnight + 5 seconds for the next day.
        Dim st = New DateTime(Now.Year, Now.Month, Now.Day, 0, 0, 1).AddDays(1)
        Dim _int As Long = Date2Unix(st) - Date2Unix(Now)
        MidDuration = New TimeSpan(0, 0, 0, CInt(_int))
        MidNextUpdate = Date.Now + MidDuration
        TmrMidnight.Interval = TimeSpan.FromSeconds(_int).TotalMilliseconds
        TmrMidnight.Start()
        TsslMidnight.ForeColor = Color.Blue
        TsslMidnight.Visible = True

        PrintLog($"=> Set midnight rollover: {st} -> Interval: {_int} seconds{vbLf}")
    End Sub

    Private Sub TmrClock_Elapsed(sender As Object, e As Timers.ElapsedEventArgs) Handles TmrClock.Elapsed
        TsslClock.Text = Now.ToLongTimeString

        If TmrTimelineUpdate.Enabled Then
            TsslNextTl.Text = If(DateDiff(DateInterval.Minute, My.Computer.Clock.LocalTime, TlNextUpdate) < 1,
     $"Tl: {DateDiff(DateInterval.Second, Date.Now, TlNextUpdate):N0}",
     $"Tl: {DateDiff(DateInterval.Minute, Date.Now, TlNextUpdate):N0}")
        End If

        If TmrMidnight.Enabled Then
            TsslMidnight.Text = If _
                (DateDiff(DateInterval.Minute, My.Computer.Clock.LocalTime, MidNextUpdate) < 1, $"Mn: {DateDiff(DateInterval.Second, Date.Now, MidNextUpdate):D0}",
                    $"Mn: {DateDiff(DateInterval.Minute, Date.Now, MidNextUpdate):D0}")
        End If

        If TmrReset.Enabled Then
            TsslReset.Text = $"{DateDiff(DateInterval.Second, Date.Now, ResetNextUpdate):D0}"
        End If

    End Sub

    Private Sub TmrMidnight_Elapsed(sender As Object, e As Timers.ElapsedEventArgs) Handles TmrMidnight.Elapsed
        TmrMidnight.Stop()
        PrintLog($"=> Midnight timer elapsed and stopped @ {Now:T}.{vbLf}")
        Dim _st As Date = New DateTime(Now.Year, Now.Month, Now.Day, 0, 0, 1).AddDays(1)
        Dim _int As Long = Date2Unix(_st) - Date2Unix(Now)
        MidDuration = New TimeSpan(0, 0, 0, CInt(_int))
        MidNextUpdate = Date.Now + MidDuration
        TmrMidnight.Interval = TimeSpan.FromSeconds(_int).TotalMilliseconds
        TmrMidnight.Start()
        PrintLog($"<== Midnight timer restarted @ {Now:T}.{vbLf}     Interval: {_int} seconds{vbLf}")
        Check4NewLogFile()
    End Sub

    Private Sub TmrReset_Tick(sender As Object, e As EventArgs) Handles TmrReset.Tick
        PrintLog($"Reset timer elapsed @ {Now:F}. ResetCounter: {ResetCounter}{vbLf}")
        TmrReset.Stop()
        TsslReset.Visible = False
        FetchTimeLines()
    End Sub

    Private Sub TmrTimelineUpdate_Elapsed(sender As Object, e As Timers.ElapsedEventArgs) Handles TmrTimelineUpdate.Elapsed
        PrintLog($"Timelines Update timer elapsed @ {Now:T}.{vbLf}")
        TmrTimelineUpdate.Stop()
        Dim st = New DateTime(Now.Year, Now.Month, Now.Day, Now.Hour, 0, 15).AddHours(1)
        Dim _int As Long = Date2Unix(st) - Date2Unix(Now)
        TlDuration = New TimeSpan(0, 0, 0, CInt(_int))
        TlNextUpdate = Date.Now + TlDuration
        TmrTimelineUpdate.Interval = TimeSpan.FromSeconds(_int).TotalMilliseconds
        TmrTimelineUpdate.Start()
        PrintLog($"*** Next TimeLines Update @ {TlNextUpdate:T}. ***{vbLf}")
        FetchTimeLines(True)
        FetchWildfireData()
    End Sub

#End Region

#Region "Field Data"

    Private Sub BtnFdCheck_Click(sender As Object, e As EventArgs) Handles BtnFdCheck.Click
        For Each c As CheckBox In FlpDataFields.Controls.OfType(Of CheckBox)()
            If Not c.Checked And c.Enabled Then
                c.Checked = True
            End If
        Next
        My.Settings.Save()
    End Sub

    Private Sub BtnFdUncheck_Click(sender As Object, e As EventArgs) Handles BtnFdUncheck.Click
        For Each c As CheckBox In FlpDataFields.Controls.OfType(Of CheckBox)()
            If c.Checked Then
                c.Checked = False
            End If
        Next
        My.Settings.Save()
    End Sub

    Private Sub SelectFieldData(sender As Object, e As EventArgs) Handles ChkCore20.CheckedChanged, ChkCore1.CheckedChanged, ChkCore2.CheckedChanged, ChkCore3.CheckedChanged, ChkCore4.CheckedChanged, ChkCore5.CheckedChanged, ChkCore6.CheckedChanged, ChkCore7.CheckedChanged, ChkCore8.CheckedChanged, ChkCore9.CheckedChanged, ChkCore10.CheckedChanged, ChkCore11.CheckedChanged, ChkCore12.CheckedChanged, ChkCore13.CheckedChanged, ChkCore14.CheckedChanged, ChkCore15.CheckedChanged, ChkCore16.CheckedChanged, ChkCore17.CheckedChanged, ChkCore18.CheckedChanged, ChkCore19.CheckedChanged, ChkCore0.CheckedChanged, ChkCore21.CheckedChanged, ChkCore22.CheckedChanged, ChkAqi0.CheckedChanged, ChkAqi1.CheckedChanged, ChkAqi2.CheckedChanged, ChkAqi3.CheckedChanged, ChkAqi4.CheckedChanged, ChkAqi5.CheckedChanged, ChkAqi6.CheckedChanged, ChkAqi7.CheckedChanged, ChkAqi8.CheckedChanged, ChkAqi9.CheckedChanged, ChkAqi10.CheckedChanged, ChkAqi11.CheckedChanged, ChkPol0.CheckedChanged, ChkPol1.CheckedChanged, ChkPol2.CheckedChanged, ChkPol3.CheckedChanged, ChkPol4.CheckedChanged, ChkPol5.CheckedChanged, ChkPol6.CheckedChanged, ChkPol7.CheckedChanged, ChkPol8.CheckedChanged, ChkPol9.CheckedChanged, ChkPol10.CheckedChanged, ChkPol12.CheckedChanged, ChkPol11.CheckedChanged, ChkPol13.CheckedChanged, ChkPol14.CheckedChanged, ChkPol15.CheckedChanged, ChkPol16.CheckedChanged, ChkPol17.CheckedChanged, ChkPol18.CheckedChanged, ChkPol19.CheckedChanged, ChkPol20.CheckedChanged, ChkPol21.CheckedChanged, ChkPol22.CheckedChanged, ChkPol23.CheckedChanged, ChkPol24.CheckedChanged, ChkPol25.CheckedChanged, ChkHail0.CheckedChanged, ChkFire0.CheckedChanged, ChkSol0.CheckedChanged, ChkSol1.CheckedChanged, ChkSol2.CheckedChanged, ChkMt0.CheckedChanged, ChkMt1.CheckedChanged, ChkMt2.CheckedChanged, ChkMt3.CheckedChanged, ChkMt4.CheckedChanged, ChkMt5.CheckedChanged, ChkMt6.CheckedChanged, ChkMt7.CheckedChanged, ChkMt8.CheckedChanged, ChkMt9.CheckedChanged, ChkMt10.CheckedChanged, ChkMt11.CheckedChanged, ChkMt12.CheckedChanged, ChkMt13.CheckedChanged, ChkMt14.CheckedChanged, ChkLand0.CheckedChanged, ChkLand1.CheckedChanged, ChkLand2.CheckedChanged, ChkLand3.CheckedChanged, ChkLand4.CheckedChanged, ChkLand5.CheckedChanged, ChkLand6.CheckedChanged, ChkLand7.CheckedChanged, ChkLand8.CheckedChanged, ChkLand9.CheckedChanged
        With DirectCast(sender, CheckBox)
            Select Case CInt(.Tag)
                Case 0
                    My.Settings.TlCore0 = .Checked
                Case 1
                    My.Settings.TlCore1 = .Checked
                Case 2
                    My.Settings.TlCore2 = .Checked
                Case 3
                    My.Settings.TlCore3 = .Checked
                Case 4
                    My.Settings.TlCore4 = .Checked
                Case 5
                    My.Settings.TlCore5 = .Checked
                Case 6
                    My.Settings.TlCore6 = .Checked
                Case 7
                    My.Settings.TlCore7 = .Checked
                Case 8
                    My.Settings.TlCore8 = .Checked
                Case 9
                    My.Settings.TlCore9 = .Checked
                Case 10
                    My.Settings.TlCore10 = .Checked
                Case 11
                    My.Settings.TlCore11 = .Checked
                Case 12
                    My.Settings.TlCore12 = .Checked
                Case 13
                    My.Settings.TlCore13 = .Checked
                Case 14
                    My.Settings.TlCore14 = .Checked
                Case 15
                    My.Settings.TlCore15 = .Checked
                Case 16
                    My.Settings.TlCore16 = .Checked
                Case 17
                    My.Settings.TlCore17 = .Checked
                Case 18
                    My.Settings.TlCore18 = .Checked
                Case 19
                    My.Settings.TlCore19 = .Checked
                Case 20
                    My.Settings.TlCore20 = .Checked
                Case 21
                    My.Settings.TlAqi0 = .Checked
                Case 22
                    My.Settings.TlAqi1 = .Checked
                Case 23
                    My.Settings.TlAqi2 = .Checked
                Case 24
                    My.Settings.TlAqi3 = .Checked
                Case 25
                    My.Settings.TlAqi4 = .Checked
                Case 26
                    My.Settings.TlAqi5 = .Checked
                Case 27
                    My.Settings.TlAqi6 = .Checked
                Case 28
                    My.Settings.TlAqi7 = .Checked
                Case 29
                    My.Settings.TlAqi8 = .Checked
                Case 30
                    My.Settings.TlAqi9 = .Checked
                Case 31
                    My.Settings.TlAqi10 = .Checked
                Case 32
                    My.Settings.TlAqi11 = .Checked
                Case 33
                    My.Settings.TlPol0 = .Checked
                Case 34
                    My.Settings.TlPol1 = .Checked
                Case 35
                    My.Settings.TlPol2 = .Checked
                Case 36
                    My.Settings.TlPol3 = .Checked
                Case 37
                    My.Settings.TlPol4 = .Checked
                Case 38
                    My.Settings.TlPol5 = .Checked
                Case 39
                    My.Settings.TlPol6 = .Checked
                Case 40
                    My.Settings.TlPol7 = .Checked
                Case 41
                    My.Settings.TlPol8 = .Checked
                Case 42
                    My.Settings.TlPol9 = .Checked
                Case 43
                    My.Settings.TlPol10 = .Checked
                Case 44
                    My.Settings.TlPol11 = .Checked
                Case 45
                    My.Settings.TlPol12 = .Checked
                Case 46
                    My.Settings.TlPol13 = .Checked
                Case 47
                    My.Settings.TlPol14 = .Checked
                Case 48
                    My.Settings.TlPol15 = .Checked
                Case 49
                    My.Settings.TlPol16 = .Checked
                Case 50
                    My.Settings.TlPol17 = .Checked
                Case 51
                    My.Settings.TlPol18 = .Checked
                Case 52
                    My.Settings.TlPol19 = .Checked
                Case 53
                    My.Settings.TlPol20 = .Checked
                Case 54
                    My.Settings.TlPol21 = .Checked
                Case 55
                    My.Settings.TlPol22 = .Checked
                Case 56
                    My.Settings.TlPol23 = .Checked
                Case 57
                    My.Settings.TlPol24 = .Checked
                Case 58
                    My.Settings.TlPol25 = .Checked
                Case 59
                    My.Settings.TlHail0 = .Checked
                Case 60
                    My.Settings.TlFire0 = .Checked
                Case 61
                    My.Settings.TlSol0 = .Checked
                Case 62
                    My.Settings.TlSol1 = .Checked
                Case 63
                    My.Settings.TlSol1 = .Checked
                Case 64
                    My.Settings.TlMt0 = .Checked
                Case 65
                    My.Settings.TlMt1 = .Checked
                Case 66
                    My.Settings.TlMt2 = .Checked
                Case 67
                    My.Settings.TlMt3 = .Checked
                Case 68
                    My.Settings.TlMt4 = .Checked
                Case 69
                    My.Settings.TlMt5 = .Checked
                Case 70
                    My.Settings.TlMt6 = .Checked
                Case 71
                    My.Settings.TlMt7 = .Checked
                Case 72
                    My.Settings.TlMt8 = .Checked
                Case 73
                    My.Settings.TlMt9 = .Checked
                Case 74
                    My.Settings.TlMt10 = .Checked
                Case 75
                    My.Settings.TlMt11 = .Checked
                Case 76
                    My.Settings.TlMt12 = .Checked
                Case 77
                    My.Settings.TlMt13 = .Checked
                Case 78
                    My.Settings.TlMt14 = .Checked
                Case 79
                    My.Settings.TlLand0 = .Checked
                Case 80
                    My.Settings.TlLand1 = .Checked
                Case 81
                    My.Settings.TlLand2 = .Checked
                Case 82
                    My.Settings.TlLand3 = .Checked
                Case 83
                    My.Settings.TlLand4 = .Checked
                Case 84
                    My.Settings.TlLand5 = .Checked
                Case 85
                    My.Settings.TlLand6 = .Checked
                Case 86
                    My.Settings.TlLand7 = .Checked
                Case 87
                    My.Settings.TlLand8 = .Checked
                Case 88
                    My.Settings.TlLand9 = .Checked
                Case 89
                    My.Settings.TlCore21 = .Checked
                Case 90
                    My.Settings.TlCore22 = .Checked
                Case Else
                    Exit Select
            End Select
        End With

        'only allowed 50 fields checked so, let's count them as we check and uncheck the boxes
        Dim ct As Integer
        For Each c As CheckBox In FlpDataFields.Controls.OfType(Of CheckBox)()
            If c.Checked Then
                ct += 1
            End If
        Next
        If My.Settings.TlCore0 Then
            'we get 3 for 1 here  temperature, temperatureMax and temperatureMin
            ct += 2
        End If
        If My.Settings.TlCore15 Then
            'we have a duplicate with solarGHI
            ct -= 1
        End If
        LblFieldsChecked.Text = String.Format(LblFieldsChecked.Tag.ToString, ct)
        If ct = 50 Then
            For Each c As CheckBox In FlpDataFields.Controls.OfType(Of CheckBox)
                If Not c.Checked Then
                    c.Enabled = False
                Else
                End If
            Next
        Else
            For Each c As CheckBox In FlpDataFields.Controls.OfType(Of CheckBox)
                c.Enabled = True
            Next
        End If
    End Sub

#End Region

#Region "App Settings"

    Private Sub BtnNewPointLocation_Click(sender As Object, e As EventArgs) Handles BtnNewPointLocation.Click
        If String.IsNullOrEmpty(TxtLocationName.Text) OrElse String.IsNullOrEmpty(TxtPointLat.Text) OrElse String.IsNullOrEmpty(TxtPointLong.Text) Then
            MsgBox("Cannot fetch location, data missing!")
        Else
            CreateNewPointLocation()
        End If
    End Sub

    Private Sub ImgStyle(sender As Object, e As EventArgs) Handles RbImgStyle0.CheckedChanged, RbImgStyle1.CheckedChanged
        Dim ct = DirectCast(sender, RadioButton)
        My.Settings.ImageStyle = CInt(ct.Tag)
        My.Settings.Save()
        For j = 0 To 3
            ImgPbArr(j).Image = Image.FromFile(Path.Combine(IconDir, "PNG", "COLOR", ImgStyleArr(My.Settings.ImageStyle), ImgSamp(j)))
        Next
    End Sub

    Private Sub LocationData(sender As Object, e As EventArgs) Handles NumLat.ValueChanged, NumLong.ValueChanged, NumTlInterval.ValueChanged, NumLogKeepDays.ValueChanged
        With DirectCast(sender, NumericUpDown)
            Select Case CInt(.Tag)
                Case 0
                    My.Settings.cLatitude = .Value
                Case 1
                    My.Settings.cLongitude = .Value
                Case 2
                    My.Settings.UpdateInt_Timelines = CInt(.Value)
                Case 3
                    My.Settings.Log_KeepDays = CInt(.Value)
                Case Else
                    Exit Select
            End Select
        End With
        My.Settings.Save()
    End Sub

    Private Sub LogBooleans(sender As Object, e As EventArgs) Handles ChkLogBool0.CheckedChanged, ChkLogBool1.CheckedChanged
        With DirectCast(sender, CheckBox)
            Select Case CInt(.Tag)
                Case 0
                    My.Settings.Log_Images = .Checked
                Case 1
                    My.Settings.Log_Headers = .Checked
                Case Else
                    Exit Select
            End Select
        End With
        My.Settings.Save()
    End Sub

    Private Sub Num_Enter(sender As Object, e As EventArgs) Handles NumLat.Enter, NumLong.Enter, NumLogKeepDays.Enter, NumTlInterval.Enter
        Dim ct = DirectCast(sender, NumericUpDown)
        ct.Select(0, ct.Text.Length)
    End Sub

    Private Sub TimeSteps(sender As Object, e As EventArgs) Handles ChkTs1m.CheckedChanged, ChkTs5m.CheckedChanged, ChkTs15m.CheckedChanged, ChkTs30m.CheckedChanged, ChkTs1h.CheckedChanged, ChkTs1d.CheckedChanged, ChkTsCur.CheckedChanged, ChkTsBest.CheckedChanged
        'maximum of 3 allowed
        With DirectCast(sender, CheckBox)
            Select Case CInt(.Tag)
                Case 0
                    My.Settings.Ts1m = .Checked
                Case 1
                    My.Settings.Ts5m = .Checked
                Case 2
                    My.Settings.Ts15m = .Checked
                Case 3
                    My.Settings.Ts30m = .Checked
                Case 4
                    My.Settings.Ts1h = .Checked
                Case 5
                    My.Settings.Ts1d = .Checked
                Case 6
                    My.Settings.TsCur = .Checked
                Case 7
                    My.Settings.TsBest = .Checked
                Case Else
                    Exit Select
            End Select
        End With
        My.Settings.Save()
        Dim ct As Integer
        For Each c As CheckBox In GbTimeSteps.Controls.OfType(Of CheckBox)()
            If c.Checked Then
                ct += 1
            End If
        Next

        If ct = 3 Then
            For Each c As CheckBox In GbTimeSteps.Controls.OfType(Of CheckBox)
                If Not c.Checked Then
                    c.Enabled = False
                Else
                End If
            Next
        Else
            For Each c As CheckBox In GbTimeSteps.Controls.OfType(Of CheckBox)
                c.Enabled = True
            Next
        End If
        LblNumTsSelected.Text = String.Format(LblNumTsSelected.Tag.ToString, ct)
    End Sub

    ''' <summary>
    ''' only allowed 50 fields checked so, let's count them when we enter the tabpage
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub TpDataFields_Enter(sender As Object, e As EventArgs) Handles TpDataFields.Enter
        Dim ct As Integer
        If My.Settings.TlCore0 Then
            ct = 2
        End If
        For Each c As CheckBox In FlpDataFields.Controls.OfType(Of CheckBox)()
            If c.Checked Then
                ct += 1
            End If
        Next
        LblFieldsChecked.Text = String.Format(LblFieldsChecked.Tag.ToString, ct)
    End Sub

    Private Sub TpOptions_Enter(sender As Object, e As EventArgs) Handles TpOptions.Enter
        Dim ct As Integer
        For Each c As CheckBox In GbTimeSteps.Controls.OfType(Of CheckBox)()
            If c.Checked Then
                ct += 1
            End If
        Next
        LblNumTsSelected.Text = String.Format(LblNumTsSelected.Tag.ToString, ct)
    End Sub

    Private Sub TxtApiKey_TextChanged(sender As Object, e As EventArgs) Handles TxtApiKey.TextChanged
        My.Settings.ApiKey = TxtApiKey.Text
        My.Settings.Save()
    End Sub

    Private Sub Units(sender As Object, e As EventArgs) Handles RbDataUnits0.CheckedChanged, RbDataUnits1.CheckedChanged
        Dim ct = DirectCast(sender, RadioButton)
        My.Settings.Units = CInt(ct.Tag)
        My.Settings.Save()
    End Sub

#End Region

#Region "Tray Icon"

    Private Sub FrmMainv4_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If WindowState = FormWindowState.Minimized Then
            ShowInTaskbar = False
            TIcon.Visible = True
        End If
    End Sub

    Private Sub LocateForm(sender As Object, e As EventArgs) Handles LocateToolStripMenuItem.Click
        Top = 150
        Left = 175
    End Sub

    Private Sub MaximizeForm(sender As Object, e As EventArgs) Handles MaximizeToolStripMenuItem.Click
        Hide()
        TIcon.Visible = False
        WindowState = FormWindowState.Normal
        ShowInTaskbar = True
        Update()
        Show()
    End Sub

    Private Sub MinimizeForm(sender As Object, e As EventArgs) Handles MinimizeToolStripMenuItem.Click
        TIcon.Visible = True
        WindowState = FormWindowState.Minimized
        ShowInTaskbar = False
    End Sub

    Private Sub TIcon_Click(sender As Object, e As MouseEventArgs) Handles TIcon.MouseDoubleClick
        'https://www.codeproject.com/questions/642452/multiple-notify-icon-in-tray-issue
        Me.WindowState = FormWindowState.Normal
        TIcon.Visible = False
        ShowInTaskbar = True
    End Sub

#End Region

#Region "About"

    Private Shared Function CalcUpTime() As TimeSpan
        'https://stackoverflow.com/questions/972105/retrieve-system-uptime-using-c-sharp
        Dim uptimeTs As New TimeSpan()
        Try
            Using pc As New PerformanceCounter($"System", "System Up Time")
                pc.NextValue()
                uptimeTs = TimeSpan.FromSeconds(pc.NextValue())
                Return uptimeTs
            End Using
        Catch ex As Exception
            PrintErr(ex.Message, ex.TargetSite.ToString, ex.StackTrace, ex.Source, ex.GetBaseException().ToString())
        Finally
            'a
        End Try
        Return uptimeTs
    End Function

    ''' <summary>
    ''' if you get "cannot load counter name data" error
    ''' https://stackoverflow.com/questions/17980178/cannot-load-counter-name-data-because-an-invalid-index-exception
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub TpAbout_Enter(sender As Object, e As EventArgs) Handles TpAbout.Enter
        Try
            Dim ts = CalcUpTime()
            Dim runtime = Date.Now - Process.GetCurrentProcess().StartTime
            LblSysUpTime.Text =
                $"System Uptime:{vbLf}{ts.TotalDays:N0} Days  {ts.Hours:N0} Hours  {ts.Minutes:N0} Minutes  {ts.Seconds:N0} Seconds{vbLf}{vbLf}Program Runtime:{vbLf}{ _
                    runtime.TotalDays:N0} Days  {runtime.Hours:N0} Hours  {runtime.Minutes:N0} Minutes  {runtime.Seconds:N0} Seconds"

            ''https://stackoverflow.com/questions/18039315/is-it-possible-to-determine-how-long-a-process-has-been-running

            Dim x = Process.GetCurrentProcess()
            LblMemory.Text = $"Memory: {x.WorkingSet64 / 1024:N0} K{vbLf}{vbLf}Paged: {x.PagedMemorySize64 / 1024:N0} K"
        Catch ex As Exception
            PrintErr(ex.Message, ex.TargetSite.ToString, ex.StackTrace, ex.Source, ex.GetBaseException().ToString())
        Finally
            'a
        End Try
    End Sub

#End Region

#Region "RtbMenu"

    Private Shared Sub RtbSearch(T As RichTextBox, word As String, color1 As Color, Optional color2 As Color = Nothing)
        Const pos = 0
        Dim s = T.Text
        Dim i = 0
        Dim stopWhile = False
        While Not stopWhile
            Dim j = s.IndexOf(word, i, StringComparison.CurrentCultureIgnoreCase)
            If j < 0 Then
                stopWhile = True
            Else
                T.Select(j, word.Length)
                T.SelectionColor = color1
                T.SelectionBackColor = color2
                i = j + 1
            End If
        End While
        T.Select(pos, 0)
    End Sub

    Private Sub ScrollToEndToolStripMenuItem_Click(sender As Object, e As EventArgs)
        RtbLog.Select(RtbLog.Text.Length, RtbLog.Text.Length)
        RtbLog.ScrollToCaret()
    End Sub

    Private Sub ScrollToTopToolStripMenuItem_Click(sender As Object, e As EventArgs)
        RtbLog.Select(0, 0)
        RtbLog.ScrollToCaret()
    End Sub

    Private Sub SearchToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim sStr As Object
        sStr = InputBox("Enter Text to Find", "Search", "")
        RtbSearch(RtbLog, sStr.ToString, Color.Crimson, Color.White)
    End Sub

#Region "Log Search"

    Private indexOfSearchText As Integer

    'variables used for log search
    Private start As Integer

    Public Function FindMyText(ByVal txtToSearch As String, ByVal searchStart As Integer, ByVal searchEnd As Integer) As Integer
        ' Unselect the previously searched string
        If searchStart > 0 AndAlso searchEnd > 0 AndAlso indexOfSearchText >= 0 Then
            RtbLog.Undo()
        End If

        ' Set the return value to -1 by default.
        Dim retVal As Integer = -1

        ' A valid starting index should be specified.
        ' if indexOfSearchText = -1, the end of search
        If searchStart >= 0 AndAlso indexOfSearchText >= 0 Then
            ' A valid ending index
            If searchEnd > searchStart OrElse searchEnd = -1 Then
                ' Find the position of search string in RichTextBox
                indexOfSearchText = RtbLog.Find(txtToSearch, searchStart, searchEnd, RichTextBoxFinds.None)
                ' Determine whether the text was found in richTextBox1.
                If indexOfSearchText <> -1 Then
                    ' Return the index to the specified search text.
                    retVal = indexOfSearchText
                End If
            End If
        End If
        Return retVal
    End Function

    Private Sub BtnFind_Click(sender As Object, e As EventArgs) Handles BtnFind.Click
        'http://www.dotnetcurry.com/showarticle.aspx?ID=146
        Dim startindex As Integer = 0

        If TxtLogSearch.Text.Length > 0 Then
            startindex = FindMyText(TxtLogSearch.Text.Trim(), start, RtbLog.Text.Length)
        End If

        ' If string was found in the RichTextBox, highlight it
        If startindex >= 0 Then
            ' Set the highlight color as red
            RtbLog.SelectionColor = Color.Red
            ' Find the end index. End Index = number of characters in textbox
            Dim endindex As Integer = TxtLogSearch.Text.Length
            ' Highlight the search string
            RtbLog.Select(startindex, endindex)
            RtbLog.ScrollToCaret()
            ' mark the start position after the position of
            ' last search string
            start = startindex + endindex
        End If
    End Sub

    Private Sub BtnLogSearchClear_Click(sender As Object, e As EventArgs) Handles BtnLogSearchClear.Click
        TxtLogSearch.Text = ""
        start = 0
        indexOfSearchText = 0
        RtbLog.SelectionColor = Color.Black
        RtbLog.Select(1, RtbLog.Text.Length)
        RtbLog.ScrollToCaret()
    End Sub

    Private Sub TxtLogSearch_TextChanged(sender As Object, e As EventArgs) Handles TxtLogSearch.TextChanged
        start = 0
        indexOfSearchText = 0
    End Sub

    Private Sub BtnLogRefresh_Click(sender As Object, e As EventArgs) Handles BtnLogRefresh.Click
        RtbLog.Refresh()
    End Sub

#End Region

#End Region

End Class