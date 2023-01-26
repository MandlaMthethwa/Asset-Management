Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports ITAM

Namespace Controllers
    Public Class Received_StockController
        Inherits System.Web.Mvc.Controller

        Private db As New itamDB

        ' GET: Received_Stock
        Function Index() As ActionResult
            'Dim items = db.items
            'Dim order_id = db.orders.Add(order_id)
            'If order_id = Then
            '    Return View(items.ToList())
            'End If
            Dim stocks = db.stocks.Include(Function(s) s.order).Include(Function(s) s.status)
            Return View(stocks.ToList())
        End Function

        ' GET: Received_Stock/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim stock As stock = db.stocks.Find(id)
            If IsNothing(stock) Then
                Return HttpNotFound()
            End If
            Return View(stock)
        End Function

        ' GET: Received_Stock/Create
        Function Create() As ActionResult
            ViewBag.order_id = New SelectList(db.orders, "order_id", "invoice_number")
            ViewBag.status_id = New SelectList(db.status, "status_id", "status_name")
            Return View()
        End Function

        ' POST: Received_Stock/Create
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="stock_id,quantity,order_id,status_id")> ByVal stock As stock) As ActionResult

            'If db.orders.quantity < db.stocks.Add(quantity) Then
            '    MessageBox.Show("rfenf")
            'End If
            'If quantity Then

            'End If
            If ModelState.IsValid Then
                db.stocks.Add(stock)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.order_id = New SelectList(db.orders, "order_id", "invoice_number", stock.order_id)
            ViewBag.status_id = New SelectList(db.status, "status_id", "status_name", stock.status_id)
            ViewBag.order_quantity = New SelectList(db.orders, "order_id", "quantity")
            'If quantity < ViewBag.order_quantity Then
            '    Dim unused = MsgBox("Less than same", 1, "MsgBox Demonstration")
            'ElseIf ViewBag.quantity > ViewBag.order_quantity Then
            '    Dim unused = MsgBox("More than  ordered", 1, "MsgBox Demonstration")
            'Else
            '    Dim unused = MsgBox("It's the same", 1, "MsgBox Demonstration")

            'End If
            'If ViewBag.quantity > ViewBag.order_quantity Then
            '    MsgBox()
            'End If
            Return View(stock)
        End Function

        ' GET: Received_Stock/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim stock As stock = db.stocks.Find(id)
            If IsNothing(stock) Then
                Return HttpNotFound()
            End If
            ViewBag.order_id = New SelectList(db.orders, "order_id", "invoice_number", stock.order_id)
            ViewBag.status_id = New SelectList(db.status, "status_id", "status_name", stock.status_id)
            Return View(stock)
        End Function


        ' POST: Received_Stock/Edit/5
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="stock_id,quantity,order_id,status_id")> ByVal stock As stock) As ActionResult
            If ModelState.IsValid Then
                db.Entry(stock).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.order_id = New SelectList(db.orders, "order_id", "invoice_number", stock.order_id)
            ViewBag.status_id = New SelectList(db.status, "status_id", "status_name", stock.status_id)
            Return View(stock)
        End Function

        ' GET: Received_Stock/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim stock As stock = db.stocks.Find(id)
            If IsNothing(stock) Then
                Return HttpNotFound()
            End If
            Return View(stock)
        End Function

        ' POST: Received_Stock/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim stock As stock = db.stocks.Find(id)
            db.stocks.Remove(stock)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
