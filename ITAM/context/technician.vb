'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class technician
    Public Property technician_id As Integer
    Public Property technician_name As String

    Public Overridable Property assigns As ICollection(Of assign) = New HashSet(Of assign)
    Public Overridable Property technical_room As ICollection(Of technical_room) = New HashSet(Of technical_room)

End Class