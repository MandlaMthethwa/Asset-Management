Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Data.Entity.Migrations
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports ITAM

Namespace Controllers
    Public Class itemsController
        Inherits System.Web.Mvc.Controller

        Private db As New itamDB

        ' GET: items
        Function Index() As ActionResult
            Dim items = db.items.Include(Function(r) r.order)
            'Dim items = db.items.Where(Function(f) f.order_id = OrderId)
            Return View(items.ToList())
        End Function

        ' GET: items/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim item As item = db.items.Find(id)
            If IsNothing(item) Then
                Return HttpNotFound()
            End If
            Return View(item)
        End Function
        Function Items(ByVal OrderId As Integer?) As ActionResult

            Dim item = db.items.Where(Function(f) f.order_id = OrderId)
            Return View(item.ToList())
        End Function

        ' GET: items/Create
        Function Create(ByVal OrderId As Integer?) As ActionResult
            ViewBag.order_id = New SelectList(db.orders, "order_id", "order_number")
            ViewBag.CurrentOrder = db.orders.Where(Function(a) a.order_id = OrderId).FirstOrDefault()
            ViewBag.Items = db.items.Where(Function(a) a.order_id = OrderId OrElse a.order_id Is Nothing).FirstOrDefault()
            ViewBag.OrderID = OrderId
            Return View()
        End Function


        ' POST: items/Create
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="item_id,item_name,description,quantity,manufacture,order_id")> ByVal item As item) As ActionResult
            ViewBag.OrderId = item.order_id
            If ModelState.IsValid Then
                db.items.Add(item)
                db.SaveChanges()
                Return RedirectToAction("Create", "items", New With {.OrderId = item.order_id})
            End If
            Return View("Create")
        End Function

        ' GET: items/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim item As item = db.items.Find(id)
            If IsNothing(item) Then
                Return HttpNotFound()
            End If
            Return View(item)
        End Function

        ' POST: items/Edit/5
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="item_id,item_name,description,quantity,manufacture")> ByVal item As item) As ActionResult
            If ModelState.IsValid Then
                db.Entry(item).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(item)
        End Function

        ' GET: items/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim item As item = db.items.Find(id)
            If IsNothing(item) Then
                Return HttpNotFound()
            End If
            Return View(item)
        End Function

        ' POST: items/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim item As item = db.items.Find(id)
            db.items.Remove(item)
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
