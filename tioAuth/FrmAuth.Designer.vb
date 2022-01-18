<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAuth
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
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.WbAuth = New System.Windows.Forms.WebBrowser()
        Me.ButtonChkAuth = New System.Windows.Forms.Button()
        Me.TxtPIN = New System.Windows.Forms.TextBox()
        Me.Label174 = New System.Windows.Forms.Label()
        Me.BtnAuthorize = New System.Windows.Forms.Button()
        Me.PbAuth = New System.Windows.Forms.PictureBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TpAuth = New System.Windows.Forms.TabPage()
        Me.TpLog = New System.Windows.Forms.TabPage()
        Me.RtbLog = New System.Windows.Forms.RichTextBox()
        CType(Me.PbAuth, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TpAuth.SuspendLayout()
        Me.TpLog.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.GripMargin = New System.Windows.Forms.Padding(0)
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 755)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1199, 22)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'WbAuth
        '
        Me.WbAuth.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.WbAuth.Location = New System.Drawing.Point(3, 73)
        Me.WbAuth.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WbAuth.Name = "WbAuth"
        Me.WbAuth.Size = New System.Drawing.Size(1185, 643)
        Me.WbAuth.TabIndex = 6
        '
        'ButtonChkAuth
        '
        Me.ButtonChkAuth.AutoSize = True
        Me.ButtonChkAuth.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButtonChkAuth.Location = New System.Drawing.Point(698, 15)
        Me.ButtonChkAuth.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButtonChkAuth.Name = "ButtonChkAuth"
        Me.ButtonChkAuth.Size = New System.Drawing.Size(243, 46)
        Me.ButtonChkAuth.TabIndex = 10
        Me.ButtonChkAuth.Text = "Check Authorization"
        Me.ButtonChkAuth.UseVisualStyleBackColor = True
        '
        'TxtPIN
        '
        Me.TxtPIN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtPIN.Location = New System.Drawing.Point(464, 27)
        Me.TxtPIN.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtPIN.Name = "TxtPIN"
        Me.TxtPIN.Size = New System.Drawing.Size(148, 26)
        Me.TxtPIN.TabIndex = 9
        '
        'Label174
        '
        Me.Label174.AutoSize = True
        Me.Label174.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label174.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label174.Location = New System.Drawing.Point(324, 30)
        Me.Label174.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label174.Name = "Label174"
        Me.Label174.Size = New System.Drawing.Size(140, 20)
        Me.Label174.TabIndex = 8
        Me.Label174.Text = "Enter PIN number:"
        Me.Label174.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BtnAuthorize
        '
        Me.BtnAuthorize.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnAuthorize.Location = New System.Drawing.Point(169, 21)
        Me.BtnAuthorize.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnAuthorize.Name = "BtnAuthorize"
        Me.BtnAuthorize.Size = New System.Drawing.Size(112, 35)
        Me.BtnAuthorize.TabIndex = 7
        Me.BtnAuthorize.Text = "Authorize"
        Me.BtnAuthorize.UseVisualStyleBackColor = True
        '
        'PbAuth
        '
        Me.PbAuth.Location = New System.Drawing.Point(984, 19)
        Me.PbAuth.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PbAuth.Name = "PbAuth"
        Me.PbAuth.Size = New System.Drawing.Size(38, 38)
        Me.PbAuth.TabIndex = 11
        Me.PbAuth.TabStop = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TpAuth)
        Me.TabControl1.Controls.Add(Me.TpLog)
        Me.TabControl1.DataBindings.Add(New System.Windows.Forms.Binding("Location", Global.tioAuth.My.MySettings.Default, "AuthFormLocation", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TabControl1.Location = Global.tioAuth.My.MySettings.Default.AuthFormLocation
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1199, 752)
        Me.TabControl1.TabIndex = 12
        '
        'TpAuth
        '
        Me.TpAuth.Controls.Add(Me.WbAuth)
        Me.TpAuth.Controls.Add(Me.PbAuth)
        Me.TpAuth.Controls.Add(Me.ButtonChkAuth)
        Me.TpAuth.Controls.Add(Me.BtnAuthorize)
        Me.TpAuth.Controls.Add(Me.TxtPIN)
        Me.TpAuth.Controls.Add(Me.Label174)
        Me.TpAuth.Location = New System.Drawing.Point(4, 29)
        Me.TpAuth.Name = "TpAuth"
        Me.TpAuth.Padding = New System.Windows.Forms.Padding(3)
        Me.TpAuth.Size = New System.Drawing.Size(1191, 719)
        Me.TpAuth.TabIndex = 0
        Me.TpAuth.Text = "Authenticate"
        Me.TpAuth.UseVisualStyleBackColor = True
        '
        'TpLog
        '
        Me.TpLog.Controls.Add(Me.RtbLog)
        Me.TpLog.Location = New System.Drawing.Point(4, 29)
        Me.TpLog.Name = "TpLog"
        Me.TpLog.Padding = New System.Windows.Forms.Padding(3)
        Me.TpLog.Size = New System.Drawing.Size(1191, 719)
        Me.TpLog.TabIndex = 1
        Me.TpLog.Text = "Log"
        Me.TpLog.UseVisualStyleBackColor = True
        '
        'RtbLog
        '
        Me.RtbLog.BackColor = System.Drawing.SystemColors.Info
        Me.RtbLog.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RtbLog.Location = New System.Drawing.Point(3, 3)
        Me.RtbLog.Name = "RtbLog"
        Me.RtbLog.ReadOnly = True
        Me.RtbLog.ShowSelectionMargin = True
        Me.RtbLog.Size = New System.Drawing.Size(1185, 713)
        Me.RtbLog.TabIndex = 0
        Me.RtbLog.Text = ""
        '
        'FrmAuth
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1199, 777)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Name = "FrmAuth"
        Me.Text = "Form1"
        CType(Me.PbAuth, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TpAuth.ResumeLayout(False)
        Me.TpAuth.PerformLayout()
        Me.TpLog.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents WbAuth As WebBrowser
    Friend WithEvents PbAuth As PictureBox
    Friend WithEvents ButtonChkAuth As Button
    Friend WithEvents TxtPIN As TextBox
    Friend WithEvents Label174 As Label
    Friend WithEvents BtnAuthorize As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TpAuth As TabPage
    Friend WithEvents TpLog As TabPage
    Friend WithEvents RtbLog As RichTextBox
End Class
