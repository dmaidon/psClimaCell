Public Class FrmMainv4
    'https://docs.climacell.co/reference/api-formats#locations
    'https://docs.climacell.co/reference/data-layers-core
    'https://docs.climacell.co/reference/data-layers-overview
    Public tlNfo As CcTimelinesModel()

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpgradeMySettings()
        LoadProgramSettings()
        CreateProgramFolders()
        StartLogfile()
        PerformLogMaintenance()
        ParseDataFieldUnits()

        If String.IsNullOrEmpty(My.Settings.ApiKey) Then
            TC.SelectedTab = TpAppOptions
        End If
        Show()

        Text = $"psClimaCell V4 API - Tr: {My.Settings.TimesRun}"
        TsslCpy.Text = Cpy
        TsslVer.Text = Application.ProductVersion
        LblAbout.Text = String.Format(My.Resources.about, vbLf, ParseVersion())
        LblNumControls.Text = NumControls(Me).ToString
        FetchTimeLines()

        SaveLogs()
        TmrClock.Start()
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

    Private Sub TmrClock_Elapsed(sender As Object, e As Timers.ElapsedEventArgs) Handles TmrClock.Elapsed
        TsslClock.Text = Now.ToLongTimeString

        If TmrTimelineUpdate.Enabled Then
            TsslNextTl.Text = If(DateDiff(DateInterval.Minute, My.Computer.Clock.LocalTime, TlNextUpdate) < 1,
     $"Tl: {DateDiff(DateInterval.Second, Date.Now, TlNextUpdate):N0}",
     $"Tl: {DateDiff(DateInterval.Minute, Date.Now, TlNextUpdate):N0}")
            End If

    End Sub

#Region "Field Data"

    Private Sub SelectFieldData(sender As Object, e As EventArgs) Handles ChkCore20.CheckedChanged, ChkCore1.CheckedChanged, ChkCore2.CheckedChanged, ChkCore3.CheckedChanged, ChkCore4.CheckedChanged, ChkCore5.CheckedChanged, ChkCore6.CheckedChanged, ChkCore7.CheckedChanged, ChkCore8.CheckedChanged, ChkCore9.CheckedChanged, ChkCore10.CheckedChanged, ChkCore11.CheckedChanged, ChkCore12.CheckedChanged, ChkCore13.CheckedChanged, ChkCore14.CheckedChanged, ChkCore15.CheckedChanged, ChkCore16.CheckedChanged, ChkCore17.CheckedChanged, ChkCore18.CheckedChanged, ChkCore19.CheckedChanged, ChkCore0.CheckedChanged, ChkAqi0.CheckedChanged, ChkAqi1.CheckedChanged, ChkAqi2.CheckedChanged, ChkAqi3.CheckedChanged, ChkAqi4.CheckedChanged, ChkAqi5.CheckedChanged, ChkAqi6.CheckedChanged, ChkAqi7.CheckedChanged, ChkAqi8.CheckedChanged, ChkAqi9.CheckedChanged, ChkAqi10.CheckedChanged, ChkAqi11.CheckedChanged, ChkPol0.CheckedChanged, ChkPol1.CheckedChanged, ChkPol2.CheckedChanged, ChkPol3.CheckedChanged, ChkPol4.CheckedChanged, ChkPol5.CheckedChanged, ChkPol6.CheckedChanged, ChkPol7.CheckedChanged, ChkPol8.CheckedChanged, ChkPol9.CheckedChanged, ChkPol10.CheckedChanged, ChkPol12.CheckedChanged, ChkPol11.CheckedChanged, ChkPol13.CheckedChanged, ChkPol14.CheckedChanged, ChkPol15.CheckedChanged, ChkPol16.CheckedChanged, ChkPol17.CheckedChanged, ChkPol18.CheckedChanged, ChkPol19.CheckedChanged, ChkPol20.CheckedChanged, ChkPol21.CheckedChanged, ChkPol22.CheckedChanged, ChkPol23.CheckedChanged, ChkPol24.CheckedChanged, ChkPol25.CheckedChanged, ChkHail0.CheckedChanged, ChkFire0.CheckedChanged
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
                Case Else
                    Exit Select
            End Select
        End With

        'only allowed 50 fields checked so, let's count them as we check anbd uncheck the boxes
        Dim ct As Integer
        For Each c As CheckBox In FlpDataFields.Controls.OfType(Of CheckBox)()
            If c.Checked Then
                ct += 1
            End If
        Next
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

    Private Sub FrmMainv4_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        SaveLogs()
        My.Settings.Save()
    End Sub

#End Region

#Region "App Settings"

    Private Sub Units(sender As Object, e As EventArgs) Handles RbDataUnits0.CheckedChanged, RbDataUnits1.CheckedChanged
        Dim ct = DirectCast(sender, RadioButton)
        My.Settings.Units = CInt(ct.Tag)
        My.Settings.Save()
    End Sub

    Private Sub TimeSteps(sender As Object, e As EventArgs) Handles ChkTs1m.CheckedChanged, ChkTs5m.CheckedChanged, ChkTs15m.CheckedChanged, ChkTs30m.CheckedChanged, ChkTs1h.CheckedChanged, ChkTs1d.CheckedChanged, ChkTsCur.CheckedChanged
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

    Private Sub TxtApiKey_TextChanged(sender As Object, e As EventArgs) Handles TxtApiKey.TextChanged
        My.Settings.ApiKey = TxtApiKey.Text
        My.Settings.Save()
    End Sub

    Private Sub Num_Enter(sender As Object, e As EventArgs) Handles NumLat.Enter, NumLong.Enter
        Dim ct = DirectCast(sender, NumericUpDown)
        ct.Select(0, ct.Text.Length)
    End Sub

    Private Sub LocationData(sender As Object, e As EventArgs) Handles NumLat.ValueChanged, NumLong.ValueChanged, NumTlInterval.ValueChanged
        With DirectCast(sender, NumericUpDown)
            Select Case CInt(.Tag)
                Case 0
                    My.Settings.cLatitude = .Value
                Case 1
                    My.Settings.cLongitude = .Value
                Case 2
                    My.Settings.UpdateInt_Timelines = CInt(.Value)
                Case Else
                    Exit Select
            End Select
        End With
        My.Settings.Save()
    End Sub

    ''' <summary>
    ''' only allowed 50 fields checked so, let's count them when we enter the tabpage
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub TpDataFields_Enter(sender As Object, e As EventArgs) Handles TpDataFields.Enter
        Dim ct As Integer
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

    Private Sub TmrTimelineUpdate_Elapsed(sender As Object, e As Timers.ElapsedEventArgs) Handles TmrTimelineUpdate.Elapsed
        PrintLog($"Timelines Update timer elapsed @ {Now:T}.{vbLf}")
        TlDuration = New TimeSpan(0, 0, My.Settings.UpdateInt_Timelines, 0)
        TlNextUpdate = Date.Now + TlDuration
        PrintLog($"Next Daily Update @ {TlNextUpdate:T}.{vbLf}")
        FetchTimeLines()
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

#End Region

End Class