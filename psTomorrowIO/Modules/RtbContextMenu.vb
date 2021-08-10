Imports System.Runtime.CompilerServices

Friend Module RtbContextMenu
    'https://stackoverflow.com/questions/18966407/enable-copy-cut-past-window-in-a-rich-text-box
    <Extension()> Friend Sub AddContextMenu(rtb As RichTextBox)
        If rtb.ContextMenuStrip Is Nothing Then
            Dim cms As New ContextMenuStrip() With {.ShowImageMargin = False}

            Dim tsmiUndo As New ToolStripMenuItem("Undo")
            AddHandler tsmiUndo.Click, Sub(sender, e) rtb.Undo()
            cms.Items.Add(tsmiUndo)

            Dim tsmiRedo As New ToolStripMenuItem("Redo")
            AddHandler tsmiRedo.Click, Sub(sender, e) rtb.Redo()
            cms.Items.Add(tsmiRedo)

            cms.Items.Add(New ToolStripSeparator())

            Dim tsmiCut As New ToolStripMenuItem("Cut")
            AddHandler tsmiCut.Click, Sub(sender, e) rtb.Cut()
            cms.Items.Add(tsmiCut)

            Dim tsmiCopy As New ToolStripMenuItem("Copy")
            AddHandler tsmiCopy.Click, Sub(sender, e) rtb.Copy()
            cms.Items.Add(tsmiCopy)

            Dim tsmiPaste As New ToolStripMenuItem("Paste")
            AddHandler tsmiPaste.Click, Sub(sender, e) rtb.Paste()
            cms.Items.Add(tsmiPaste)

            Dim tsmiDelete As New ToolStripMenuItem("Delete")
            AddHandler tsmiDelete.Click, Sub(sender, e) rtb.SelectedText = ""
            cms.Items.Add(tsmiDelete)

            cms.Items.Add(New ToolStripSeparator())

            Dim tsmiSelectAll As New ToolStripMenuItem("Select All")
            AddHandler tsmiSelectAll.Click, Sub(sender, e) rtb.SelectAll()
            cms.Items.Add(tsmiSelectAll)

            'cms.Items.Add(New ToolStripSeparator())

            'Dim tsmiScrollEnd As New ToolStripMenuItem("Scroll to End")
            'AddHandler tsmiScrollEnd.Click, Sub(sender, e) rtb.ScrollToCaret()
            'cms.Items.Add(tsmiScrollEnd)

            'Dim tsmiScrollTop As New ToolStripMenuItem("Scroll to Top")
            'AddHandler tsmiScrollTop.Click, Sub(sender, e) rtb.ScrollToCaret()
            'cms.Items.Add(tsmiScrollTop)

            AddHandler cms.Opening, Sub(sender, e)
                                        tsmiUndo.Enabled = Not rtb.ReadOnly AndAlso rtb.CanUndo
                                        tsmiRedo.Enabled = Not rtb.ReadOnly AndAlso rtb.CanRedo
                                        tsmiCut.Enabled = Not rtb.ReadOnly AndAlso rtb.SelectionLength > 0
                                        tsmiCopy.Enabled = rtb.SelectionLength > 0
                                        tsmiPaste.Enabled = Not rtb.ReadOnly AndAlso Clipboard.ContainsText()
                                        tsmiDelete.Enabled = Not rtb.ReadOnly AndAlso rtb.SelectionLength > 0
                                        tsmiSelectAll.Enabled = rtb.TextLength > 0 AndAlso rtb.SelectionLength < rtb.TextLength
                                        'tsmiScrollEnd.Enabled = rtb.SelectionStart = rtb.Text.Length
                                        'tsmiScrollTop.Enabled = rtb.SelectionStart = 1
                                    End Sub

            rtb.ContextMenuStrip = cms
        End If
    End Sub

End Module
