Imports System.ComponentModel
Imports System.IO

Imports CoreTweet

Imports Microsoft.Win32

Imports Newtonsoft.Json.Linq

Public Class FrmAuth

    Public Const R_Token As String = "Software\PAROLE Software\psTomorrowIO\Setup\Tokens\Consumer\Keys"
    Public LogFile As String
    Private _session As OAuth.OAuthSession
    Private Const ConsumerKeySecret As String = "8yFOc18ePp7BBSMdxcdmpjH4t8DsZtzJhvBk2PhnAhfoNPOjH2"
    Private Const ConsumerKeyToken As String = "m1WCMumIPQfn4FeebrxJM62hk"


    Private Sub FrmAuth_Load(sender As Object, e As EventArgs) Handles Me.Load
        Application.EnableVisualStyles()
        UpgradeMySettings()
        LogFile = Path.Combine(Application.StartupPath, "Logs", $"auth_{Now:MMddyyss}.log")
        Text = "Tomorrow.io Authentication"
        RtbLog.AppendText($"Application started: {Now}.{vbLf}")
        My.Settings.Save()
    End Sub

    Private Sub FrmAuth_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        My.Settings.Save()
        RtbLog.AppendText($"Application closed: {Now}.{vbLf}")
        SaveLogs()
    End Sub

    Private Shared Sub UpgradeMySettings()
        'https://stackoverflow.com/questions/1702260/losing-vb-net-my-settings-with-each-new-clickonce-deployment-release
        If My.Settings.MustUpgrade Then
            My.Settings.Upgrade()
            My.Settings.MustUpgrade = False
            My.Settings.Save()
        End If
    End Sub

#Region "Authenticate"

    Public Sub AuthorizeTwitter()
        Try
            _session = OAuth.Authorize(ConsumerKeyToken, ConsumerKeySecret)
            WbAuth.Navigate(New Uri(_session.AuthorizeUri.AbsoluteUri))
        Catch ex As Exception
            PrintErr(ex.Message, ex.TargetSite.ToString, ex.StackTrace, ex.Source, ex.GetBaseException().ToString())
        Finally
            ''
        End Try
    End Sub
    Friend Sub ApplyPin()
        Try
            Using kt As RegistryKey = Registry.CurrentUser.CreateSubKey(R_Token, True)
                Dim tok = _session.GetTokens(TxtPIN.Text)
                kt.SetValue(My.Resources.reg_access_key, tok.AccessToken, RegistryValueKind.String)
                kt.SetValue(My.Resources.reg_access_secret, tok.AccessTokenSecret, RegistryValueKind.String)
                PbAuth.Image = My.Resources.check
                'frmauth.TsbAuth.ForeColor = Color.Green
                Tokens.Create(ConsumerKeyToken, ConsumerKeySecret, tok.AccessToken, tok.AccessTokenSecret)
            End Using
        Catch ex As Exception
            PrintErr(ex.Message, ex.TargetSite.ToString, ex.StackTrace, ex.Source, ex.GetBaseException().ToString())
            'frmauth.TsbAuth.ForeColor = Color.Red
        Finally
            ''
        End Try
    End Sub
#End Region

#Region "Logs"

    ''' <summary>
    ''' Writes any error to the log file.
    ''' </summary>
    ''' <param name="msg">Message</param>
    ''' <param name="trg">TargetSite</param>
    ''' <param name="stk">StackTrace</param>
    Friend Sub PrintErr(msg As String, trg As String, stk As String, src As String, Optional gbe As String = "- Empty -", Optional hl As String = "- Blank -", Optional dt As String = "- Empty -")

        'GotErr = True
        Dim em As String =
                $"   Error:{vbLf}{msg}{vbLf}{vbLf}   Location:{vbLf}{trg}{vbLf}{vbLf}   Trace:{vbLf}{stk}{vbLf}{vbLf}   Source:{vbLf}{src}{vbLf}{vbLf}   Base Exception:{ _
                vbLf}{gbe}{vbLf}Help Link:{vbLf}{hl}{vbLf}Data:{vbLf}{dt}{vbLf}"

        RtbLog.AppendText($"{em}{My.Resources.separator}{vbLf}")

        SaveLogs()
    End Sub

    Private Sub SaveLogs()
        Try
            RtbLog.SaveFile(LogFile, RichTextBoxStreamType.PlainText)
        Catch ex As Exception When TypeOf ex Is ArgumentException OrElse TypeOf ex Is IOException
            MsgBox($"Unable to save logfile.{vbLf}Error: {ex.Message}")
        Finally
            ''a
        End Try
    End Sub


#End Region
End Class
