
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations

Partial Public Class item
    <DisplayName("Item ID")>
    Public Property item_id As Integer
    <DisplayName("Item Name")>
    <DataType(DataType.Text)>
    <Required>
    Public Property item_name As String
    <DisplayName("Description")>
    <DataType(DataType.Text)>
    <Required>
    Public Property description As String
    <DisplayName("Quantity")>
    <Required>
    Public Property quantity As Integer
    <DisplayName("Manufacure")>
    <Required>
    <DataType(DataType.Text)>
    Public Property manufacture As String
    Public Property order_id As Nullable(Of Integer)

    Public Overridable Property order As order
End Class

Partial Public Class order
    <DisplayName("Order ID")>
    Public Property order_id As Integer
    <DisplayName("Order Number")>
    <Required>
    Public Property order_number As String
    <DisplayName("Order Date")>
    <DataType(DataType.Date)>
    <DisplayFormat(DataFormatString:="{0:yyyy-MM-dd}", ApplyFormatInEditMode:=True)>
    <Required>
    Public Property order_date As Nullable(Of Date)
    <DisplayName("ETA")>
    <DataType(DataType.Date)>
    <DisplayFormat(DataFormatString:="{0:yyyy-MM-dd}", ApplyFormatInEditMode:=True)>
    Public Property eta As Nullable(Of Date)
    <DisplayName("Invoice Number")>
    <Required>
    Public Property invoice_number As String

    Public Overridable Property assets As ICollection(Of asset) = New HashSet(Of asset)
    Public Overridable Property items As ICollection(Of item) = New HashSet(Of item)
    Public Overridable Property stocks As ICollection(Of stock) = New HashSet(Of stock)

End Class


