Imports System.Globalization

Friend Module SettingsV4

    Friend Sub LoadProgramSettings()
        Timesrun = My.Settings.TimesRun + 1
        My.Settings.TimesRun = Timesrun

        With FrmMainv4
            .TxtApiKey.Text = My.Settings.ApiKey

            'check for Imperial or Metric data units
            'defaults to Imperial
            Select Case My.Settings.Units
                Case 0
                    .RbDataUnits0.Checked = True
                Case 1
                    .RbDataUnits1.Checked = True
                Case Else
                    .RbDataUnits0.Checked = True
            End Select

            Select Case My.Settings.ImageStyle
                Case 0
                    .RbImgStyle0.Checked = True
                Case 1
                    .RbImgStyle1.Checked = True
                Case Else
                    .RbImgStyle0.Checked = True
            End Select

            .ChkTs1m.Checked = My.Settings.Ts1m
            .ChkTs5m.Checked = My.Settings.Ts5m
            .ChkTs15m.Checked = My.Settings.Ts15m
            .ChkTs30m.Checked = My.Settings.Ts30m
            .ChkTs1h.Checked = My.Settings.Ts1h
            .ChkTs1d.Checked = My.Settings.Ts1d
            .ChkTsCur.Checked = My.Settings.TsCur
            .ChkLogBool0.Checked = My.Settings.Log_Images
            .ChkLogBool1.Checked = My.Settings.Log_Headers
            .NumLat.Value = My.Settings.cLatitude
            .NumLong.Value = My.Settings.cLongitude
            .NumTlInterval.Value = My.Settings.UpdateInt_Timelines
            .NumLogKeepDays.Value = My.Settings.Log_KeepDays

            'set timer for 1 second after the hour.  Datafile will update hourly
            Dim st = New DateTime(Now.Year, Now.Month, Now.Day, Now.Hour, 0, 15).AddHours(1)
            Dim _int As Long = Date2Unix(st) - Date2Unix(Now)
            TlDuration = New TimeSpan(0, 0, 0, CInt(_int))
            TlNextUpdate = Date.Now + TlDuration
            FrmMainv4.TmrTimelineUpdate.Interval = TimeSpan.FromSeconds(_int).TotalMilliseconds
            FrmMainv4.TmrTimelineUpdate.Start()
            PrintLog($"*** Next update time: {TlNextUpdate:h:mm:ss tt} ***{vbLf}")
            .LblTimesrun.Text = String.Format(CultureInfo.CurrentCulture, CType(.LblTimesrun.Tag, String), Timesrun, NumControls(FrmMainv4), vbLf, ParseVersion)
        End With

        LoadDataFields()

        My.Settings.Save()
    End Sub

    Private Sub LoadDataFields()
        With FrmMainv4
            .ChkCore0.Checked = My.Settings.TlCore0
            .ChkCore1.Checked = My.Settings.TlCore1
            .ChkCore2.Checked = My.Settings.TlCore2
            .ChkCore3.Checked = My.Settings.TlCore3
            .ChkCore4.Checked = My.Settings.TlCore4
            .ChkCore5.Checked = My.Settings.TlCore5
            .ChkCore6.Checked = My.Settings.TlCore6
            .ChkCore7.Checked = My.Settings.TlCore7
            .ChkCore8.Checked = My.Settings.TlCore8
            .ChkCore9.Checked = My.Settings.TlCore9
            .ChkCore10.Checked = My.Settings.TlCore10
            .ChkCore11.Checked = My.Settings.TlCore11
            .ChkCore12.Checked = My.Settings.TlCore12
            .ChkCore13.Checked = My.Settings.TlCore13
            .ChkCore14.Checked = My.Settings.TlCore14
            .ChkCore15.Checked = My.Settings.TlCore15
            .ChkCore16.Checked = My.Settings.TlCore16
            .ChkCore17.Checked = My.Settings.TlCore17
            .ChkCore18.Checked = My.Settings.TlCore18
            .ChkCore19.Checked = My.Settings.TlCore19
            .ChkCore20.Checked = My.Settings.TlCore20
            .ChkAqi0.Checked = My.Settings.TlAqi0
            .ChkAqi1.Checked = My.Settings.TlAqi1
            .ChkAqi2.Checked = My.Settings.TlAqi2
            .ChkAqi3.Checked = My.Settings.TlAqi3
            .ChkAqi4.Checked = My.Settings.TlAqi4
            .ChkAqi5.Checked = My.Settings.TlAqi5
            .ChkAqi6.Checked = My.Settings.TlAqi6
            .ChkAqi7.Checked = My.Settings.TlAqi7
            .ChkAqi8.Checked = My.Settings.TlAqi8
            .ChkAqi9.Checked = My.Settings.TlAqi9
            .ChkAqi10.Checked = My.Settings.TlAqi10
            .ChkAqi11.Checked = My.Settings.TlAqi11
            .ChkPol0.Checked = My.Settings.TlPol0
            .ChkPol1.Checked = My.Settings.TlPol1
            .ChkPol2.Checked = My.Settings.TlPol2
            .ChkPol3.Checked = My.Settings.TlPol3
            .ChkPol4.Checked = My.Settings.TlPol4
            .ChkPol5.Checked = My.Settings.TlPol5
            .ChkPol6.Checked = My.Settings.TlPol6
            .ChkPol7.Checked = My.Settings.TlPol7
            .ChkPol8.Checked = My.Settings.TlPol8
            .ChkPol9.Checked = My.Settings.TlPol9
            .ChkPol10.Checked = My.Settings.TlPol10
            .ChkPol11.Checked = My.Settings.TlPol11
            .ChkPol12.Checked = My.Settings.TlPol12
            .ChkPol13.Checked = My.Settings.TlPol13
            .ChkPol14.Checked = My.Settings.TlPol14
            .ChkPol15.Checked = My.Settings.TlPol15
            .ChkPol16.Checked = My.Settings.TlPol16
            .ChkPol17.Checked = My.Settings.TlPol17
            .ChkPol18.Checked = My.Settings.TlPol18
            .ChkPol19.Checked = My.Settings.TlPol19
            .ChkPol20.Checked = My.Settings.TlPol20
            .ChkPol21.Checked = My.Settings.TlPol21
            .ChkPol22.Checked = My.Settings.TlPol22
            .ChkPol23.Checked = My.Settings.TlPol23
            .ChkPol24.Checked = My.Settings.TlPol24
            .ChkPol25.Checked = My.Settings.TlPol25
            .ChkHail0.Checked = My.Settings.TlHail0
            .ChkFire0.Checked = My.Settings.TlFire0
        End With
    End Sub

End Module