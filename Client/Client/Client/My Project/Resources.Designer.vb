﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.18444
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'This class was auto-generated by the StronglyTypedResourceBuilder
    'class via a tool like ResGen or Visual Studio.
    'To add or remove a member, edit your .ResX file then rerun ResGen
    'with the /str option, or rebuild your VS project.
    '''<summary>
    '''  A strongly-typed resource class, for looking up localized strings, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("Client.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Overrides the current thread's CurrentUICulture property for all
        '''  resource lookups using this strongly typed resource class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property down() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("down", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property exclamation() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("exclamation", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property information() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("information", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Byte[].
        '''</summary>
        Friend ReadOnly Property main() As Byte()
            Get
                Dim obj As Object = ResourceManager.GetObject("main", resourceCulture)
                Return CType(obj,Byte())
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.IO.UnmanagedMemoryStream similar to System.IO.MemoryStream.
        '''</summary>
        Friend ReadOnly Property notify() As System.IO.UnmanagedMemoryStream
            Get
                Return ResourceManager.GetStream("notify", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to eVdnYx7dB6zj8Y8PvxLmlFA90e5OwmZCgCF66IGfJ/zaUZzZksnvsYAheuiBnyf8gCF66IGfJ/yAIXrogZ8n/IAheuiBnyf8gCF66IGfJ/xCy/G6oY1cY44UgkEsqDwQ+yT0ByLRGBrjpEmAvKx9nKcCioSME4K1HPlYvjFgyBvdyZ7Q0QsvqfeuKvXx8hTUPBNMhYrUHo4kQsTTPkA7KqDFAcIT0JgjIy1sfUIl037GhmmVAnFuEXrZkhobFUTmZ/aR2BTH1xHJ/XNE7GFIbmNk5po/R1yagCF66IGfJ/w3aDPgvHtv+IAheuiBnyf8HmXOzPbZxXg2QbJyCUDIoYXydCEQoVd64/GPD78S5pQZS0b55KHu4PjM4TXcs1+ob9gp+NbPMnEsToaFxomnnDKDwbbgzIzOs5Xw2XMyeTksToaFxomnnIAheuiBnyf8t7OMwW7xvSYOg/4yUYEiLvSb8tAS404DgCF66IGfJ/yAIXrogZ8n/IAheuiBnyf8 [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property stub() As String
            Get
                Return ResourceManager.GetString("stub", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property up() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("up", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property wait() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("wait", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
    End Module
End Namespace