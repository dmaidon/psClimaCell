﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace My
    
    <Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.8.1.0"),  _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
    Partial Friend NotInheritable Class MySettings
        Inherits Global.System.Configuration.ApplicationSettingsBase
        
        Private Shared defaultInstance As MySettings = CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New MySettings()),MySettings)
        
#Region "My.Settings Auto-Save Functionality"
#If _MyType = "WindowsForms" Then
    Private Shared addedHandler As Boolean

    Private Shared addedHandlerLockObject As New Object

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
    Private Shared Sub AutoSaveSettings(sender As Global.System.Object, e As Global.System.EventArgs)
        If My.Application.SaveMySettingsOnExit Then
            My.Settings.Save()
        End If
    End Sub
#End If
#End Region
        
        Public Shared ReadOnly Property [Default]() As MySettings
            Get
                
#If _MyType = "WindowsForms" Then
               If Not addedHandler Then
                    SyncLock addedHandlerLockObject
                        If Not addedHandler Then
                            AddHandler My.Application.Shutdown, AddressOf AutoSaveSettings
                            addedHandler = True
                        End If
                    End SyncLock
                End If
#End If
                Return defaultInstance
            End Get
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("100, 100")>  _
        Public Property MainFormLocation() As Global.System.Drawing.Point
            Get
                Return CType(Me("MainFormLocation"),Global.System.Drawing.Point)
            End Get
            Set
                Me("MainFormLocation") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property MustUpgrade() As Boolean
            Get
                Return CType(Me("MustUpgrade"),Boolean)
            End Get
            Set
                Me("MustUpgrade") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property TimesRun() As Long
            Get
                Return CType(Me("TimesRun"),Long)
            End Get
            Set
                Me("TimesRun") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("60")>  _
        Public Property UpdateInt_Timelines() As Integer
            Get
                Return CType(Me("UpdateInt_Timelines"),Integer)
            End Get
            Set
                Me("UpdateInt_Timelines") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property TlCore0() As Boolean
            Get
                Return CType(Me("TlCore0"),Boolean)
            End Get
            Set
                Me("TlCore0") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property TlCore1() As Boolean
            Get
                Return CType(Me("TlCore1"),Boolean)
            End Get
            Set
                Me("TlCore1") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property TlCore2() As Boolean
            Get
                Return CType(Me("TlCore2"),Boolean)
            End Get
            Set
                Me("TlCore2") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property TlCore3() As Boolean
            Get
                Return CType(Me("TlCore3"),Boolean)
            End Get
            Set
                Me("TlCore3") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property TlCore4() As Boolean
            Get
                Return CType(Me("TlCore4"),Boolean)
            End Get
            Set
                Me("TlCore4") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property TlCore5() As Boolean
            Get
                Return CType(Me("TlCore5"),Boolean)
            End Get
            Set
                Me("TlCore5") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property TlCore6() As Boolean
            Get
                Return CType(Me("TlCore6"),Boolean)
            End Get
            Set
                Me("TlCore6") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property TlCore7() As Boolean
            Get
                Return CType(Me("TlCore7"),Boolean)
            End Get
            Set
                Me("TlCore7") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property TlCore8() As Boolean
            Get
                Return CType(Me("TlCore8"),Boolean)
            End Get
            Set
                Me("TlCore8") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property TlCore9() As Boolean
            Get
                Return CType(Me("TlCore9"),Boolean)
            End Get
            Set
                Me("TlCore9") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property TlCore10() As Boolean
            Get
                Return CType(Me("TlCore10"),Boolean)
            End Get
            Set
                Me("TlCore10") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property TlCore11() As Boolean
            Get
                Return CType(Me("TlCore11"),Boolean)
            End Get
            Set
                Me("TlCore11") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property TlCore12() As Boolean
            Get
                Return CType(Me("TlCore12"),Boolean)
            End Get
            Set
                Me("TlCore12") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property TlCore13() As Boolean
            Get
                Return CType(Me("TlCore13"),Boolean)
            End Get
            Set
                Me("TlCore13") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property TlCore14() As Boolean
            Get
                Return CType(Me("TlCore14"),Boolean)
            End Get
            Set
                Me("TlCore14") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property TlCore15() As Boolean
            Get
                Return CType(Me("TlCore15"),Boolean)
            End Get
            Set
                Me("TlCore15") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property TlCore16() As Boolean
            Get
                Return CType(Me("TlCore16"),Boolean)
            End Get
            Set
                Me("TlCore16") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property TlCore17() As Boolean
            Get
                Return CType(Me("TlCore17"),Boolean)
            End Get
            Set
                Me("TlCore17") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property TlCore18() As Boolean
            Get
                Return CType(Me("TlCore18"),Boolean)
            End Get
            Set
                Me("TlCore18") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property TlCore19() As Boolean
            Get
                Return CType(Me("TlCore19"),Boolean)
            End Get
            Set
                Me("TlCore19") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property TlCore20() As Boolean
            Get
                Return CType(Me("TlCore20"),Boolean)
            End Get
            Set
                Me("TlCore20") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property TlAqi0() As Boolean
            Get
                Return CType(Me("TlAqi0"),Boolean)
            End Get
            Set
                Me("TlAqi0") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property TlAqi1() As Boolean
            Get
                Return CType(Me("TlAqi1"),Boolean)
            End Get
            Set
                Me("TlAqi1") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property TlAqi2() As Boolean
            Get
                Return CType(Me("TlAqi2"),Boolean)
            End Get
            Set
                Me("TlAqi2") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property TlAqi3() As Boolean
            Get
                Return CType(Me("TlAqi3"),Boolean)
            End Get
            Set
                Me("TlAqi3") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property TlAqi4() As Boolean
            Get
                Return CType(Me("TlAqi4"),Boolean)
            End Get
            Set
                Me("TlAqi4") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property TlAqi5() As Boolean
            Get
                Return CType(Me("TlAqi5"),Boolean)
            End Get
            Set
                Me("TlAqi5") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property TlAqi6() As Boolean
            Get
                Return CType(Me("TlAqi6"),Boolean)
            End Get
            Set
                Me("TlAqi6") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property TlAqi7() As Boolean
            Get
                Return CType(Me("TlAqi7"),Boolean)
            End Get
            Set
                Me("TlAqi7") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property TlAqi8() As Boolean
            Get
                Return CType(Me("TlAqi8"),Boolean)
            End Get
            Set
                Me("TlAqi8") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property TlAqi9() As Boolean
            Get
                Return CType(Me("TlAqi9"),Boolean)
            End Get
            Set
                Me("TlAqi9") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property TlAqi10() As Boolean
            Get
                Return CType(Me("TlAqi10"),Boolean)
            End Get
            Set
                Me("TlAqi10") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property TlAqi11() As Boolean
            Get
                Return CType(Me("TlAqi11"),Boolean)
            End Get
            Set
                Me("TlAqi11") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property TlPol0() As Boolean
            Get
                Return CType(Me("TlPol0"),Boolean)
            End Get
            Set
                Me("TlPol0") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property TlPol1() As Boolean
            Get
                Return CType(Me("TlPol1"),Boolean)
            End Get
            Set
                Me("TlPol1") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property TlPol2() As Boolean
            Get
                Return CType(Me("TlPol2"),Boolean)
            End Get
            Set
                Me("TlPol2") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property TlPol3() As Boolean
            Get
                Return CType(Me("TlPol3"),Boolean)
            End Get
            Set
                Me("TlPol3") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property TlPol4() As Boolean
            Get
                Return CType(Me("TlPol4"),Boolean)
            End Get
            Set
                Me("TlPol4") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property TlPol5() As Boolean
            Get
                Return CType(Me("TlPol5"),Boolean)
            End Get
            Set
                Me("TlPol5") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property TlPol6() As Boolean
            Get
                Return CType(Me("TlPol6"),Boolean)
            End Get
            Set
                Me("TlPol6") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property TlPol7() As Boolean
            Get
                Return CType(Me("TlPol7"),Boolean)
            End Get
            Set
                Me("TlPol7") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property TlPol8() As Boolean
            Get
                Return CType(Me("TlPol8"),Boolean)
            End Get
            Set
                Me("TlPol8") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property TlPol9() As Boolean
            Get
                Return CType(Me("TlPol9"),Boolean)
            End Get
            Set
                Me("TlPol9") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property TlPol10() As Boolean
            Get
                Return CType(Me("TlPol10"),Boolean)
            End Get
            Set
                Me("TlPol10") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property TlPol11() As Boolean
            Get
                Return CType(Me("TlPol11"),Boolean)
            End Get
            Set
                Me("TlPol11") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property TlPol12() As Boolean
            Get
                Return CType(Me("TlPol12"),Boolean)
            End Get
            Set
                Me("TlPol12") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property TlPol13() As Boolean
            Get
                Return CType(Me("TlPol13"),Boolean)
            End Get
            Set
                Me("TlPol13") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property TlPol14() As Boolean
            Get
                Return CType(Me("TlPol14"),Boolean)
            End Get
            Set
                Me("TlPol14") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property TlPol15() As Boolean
            Get
                Return CType(Me("TlPol15"),Boolean)
            End Get
            Set
                Me("TlPol15") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property TlPol16() As Boolean
            Get
                Return CType(Me("TlPol16"),Boolean)
            End Get
            Set
                Me("TlPol16") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property TlPol17() As Boolean
            Get
                Return CType(Me("TlPol17"),Boolean)
            End Get
            Set
                Me("TlPol17") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property TlPol18() As Boolean
            Get
                Return CType(Me("TlPol18"),Boolean)
            End Get
            Set
                Me("TlPol18") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property TlPol19() As Boolean
            Get
                Return CType(Me("TlPol19"),Boolean)
            End Get
            Set
                Me("TlPol19") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property TlPol20() As Boolean
            Get
                Return CType(Me("TlPol20"),Boolean)
            End Get
            Set
                Me("TlPol20") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property TlPol21() As Boolean
            Get
                Return CType(Me("TlPol21"),Boolean)
            End Get
            Set
                Me("TlPol21") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property TlPol22() As Boolean
            Get
                Return CType(Me("TlPol22"),Boolean)
            End Get
            Set
                Me("TlPol22") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property TlPol23() As Boolean
            Get
                Return CType(Me("TlPol23"),Boolean)
            End Get
            Set
                Me("TlPol23") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property TlPol24() As Boolean
            Get
                Return CType(Me("TlPol24"),Boolean)
            End Get
            Set
                Me("TlPol24") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property TlPol25() As Boolean
            Get
                Return CType(Me("TlPol25"),Boolean)
            End Get
            Set
                Me("TlPol25") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property TlHail0() As Boolean
            Get
                Return CType(Me("TlHail0"),Boolean)
            End Get
            Set
                Me("TlHail0") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property TlFire0() As Boolean
            Get
                Return CType(Me("TlFire0"),Boolean)
            End Get
            Set
                Me("TlFire0") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property Units() As Integer
            Get
                Return CType(Me("Units"),Integer)
            End Get
            Set
                Me("Units") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property ApiKey() As String
            Get
                Return CType(Me("ApiKey"),String)
            End Get
            Set
                Me("ApiKey") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("35")>  _
        Public Property cLatitude() As Decimal
            Get
                Return CType(Me("cLatitude"),Decimal)
            End Get
            Set
                Me("cLatitude") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("-78")>  _
        Public Property cLongitude() As Decimal
            Get
                Return CType(Me("cLongitude"),Decimal)
            End Get
            Set
                Me("cLongitude") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property Ts1m() As Boolean
            Get
                Return CType(Me("Ts1m"),Boolean)
            End Get
            Set
                Me("Ts1m") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property Ts5m() As Boolean
            Get
                Return CType(Me("Ts5m"),Boolean)
            End Get
            Set
                Me("Ts5m") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property Ts15m() As Boolean
            Get
                Return CType(Me("Ts15m"),Boolean)
            End Get
            Set
                Me("Ts15m") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property Ts30m() As Boolean
            Get
                Return CType(Me("Ts30m"),Boolean)
            End Get
            Set
                Me("Ts30m") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property Ts1h() As Boolean
            Get
                Return CType(Me("Ts1h"),Boolean)
            End Get
            Set
                Me("Ts1h") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property Ts1d() As Boolean
            Get
                Return CType(Me("Ts1d"),Boolean)
            End Get
            Set
                Me("Ts1d") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property Log_Images() As Boolean
            Get
                Return CType(Me("Log_Images"),Boolean)
            End Get
            Set
                Me("Log_Images") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property Log_Headers() As Boolean
            Get
                Return CType(Me("Log_Headers"),Boolean)
            End Get
            Set
                Me("Log_Headers") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property TsCur() As Boolean
            Get
                Return CType(Me("TsCur"),Boolean)
            End Get
            Set
                Me("TsCur") = value
            End Set
        End Property
    End Class
End Namespace

Namespace My
    
    <Global.Microsoft.VisualBasic.HideModuleNameAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Module MySettingsProperty
        
        <Global.System.ComponentModel.Design.HelpKeywordAttribute("My.Settings")>  _
        Friend ReadOnly Property Settings() As Global.psClimaCell_v4._0.My.MySettings
            Get
                Return Global.psClimaCell_v4._0.My.MySettings.Default
            End Get
        End Property
    End Module
End Namespace
