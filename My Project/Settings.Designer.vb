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
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0"),  _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
    Partial Friend NotInheritable Class MySettings
        Inherits Global.System.Configuration.ApplicationSettingsBase
        
        Private Shared defaultInstance As MySettings = CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New MySettings()),MySettings)
        
#Region "My.Settings Auto-Save Functionality"
#If _MyType = "WindowsForms" Then
    Private Shared addedHandler As Boolean

    Private Shared addedHandlerLockObject As New Object

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
    Private Shared Sub AutoSaveSettings(ByVal sender As Global.System.Object, ByVal e As Global.System.EventArgs)
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
         Global.System.Configuration.DefaultSettingValueAttribute("T0"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"G1 X162 F6500 ; go to left parking lot"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"G4 P250 ;dwell 250ms"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"M42 P11 S255 ; "& _ 
            "electro magnet 2 off"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"G4 P400 ;dwell 400ms"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"G1 X-67 F6500 ; go to right parking "& _ 
            "lot"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"G4 P250 ;dwell 250ms"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"M42 P6 S2 ; electro magnet 1 on"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"G4 P400 ;dwell 400ms"& _ 
            "")>  _
        Public Property T0() As String
            Get
                Return CType(Me("T0"),String)
            End Get
            Set
                Me("T0") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("G1 X-67 F6500 ; go to right parking lot"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"G4 P250 ;dwell 250ms"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"M42 P6 S255 ; elec"& _ 
            "tro magnet 1 off"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"G4 P400 ;dwell 400ms"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"G1 X162  F6500 ; go to left parking lot"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"G4 P250 ;dwell 250ms"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"M42 P11 S2 ;electro magnet 2 on"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"G4 P400 ;dwell 400ms"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"T1"& _ 
            "")>  _
        Public Property T1() As String
            Get
                Return CType(Me("T1"),String)
            End Get
            Set
                Me("T1") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("80")>  _
        Public Property SPEED1730() As String
            Get
                Return CType(Me("SPEED1730"),String)
            End Get
            Set
                Me("SPEED1730") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("80")>  _
        Public Property SPEEDE3D() As String
            Get
                Return CType(Me("SPEEDE3D"),String)
            End Get
            Set
                Me("SPEEDE3D") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("60")>  _
        Public Property CHAMBERTEMP() As String
            Get
                Return CType(Me("CHAMBERTEMP"),String)
            End Get
            Set
                Me("CHAMBERTEMP") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("T0"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"G1 X-67 F6500 ; go to right parking lot"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"G4 P250 ;dwell 250ms"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"M42 P6 S2 ; el"& _ 
            "ectro magnet T0 on"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"G4 P400 ;dwell 400ms")>  _
        Public Property STARTTOOL() As String
            Get
                Return CType(Me("STARTTOOL"),String)
            End Get
            Set
                Me("STARTTOOL") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("120")>  _
        Public Property OPWARMDWELLSEC() As String
            Get
                Return CType(Me("OPWARMDWELLSEC"),String)
            End Get
            Set
                Me("OPWARMDWELLSEC") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property isFirstRun() As Boolean
            Get
                Return CType(Me("isFirstRun"),Boolean)
            End Get
            Set
                Me("isFirstRun") = value
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
        Friend ReadOnly Property Settings() As Global.KT8dualpluspostpost.My.MySettings
            Get
                Return Global.KT8dualpluspostpost.My.MySettings.Default
            End Get
        End Property
    End Module
End Namespace
