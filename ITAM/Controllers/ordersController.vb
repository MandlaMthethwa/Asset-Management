﻿Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports System.Web.Services
Imports ITAM

Namespace Controllers
    Public Class ordersController
        Inherits System.Web.Mvc.Controller

        Private db As New itamDB


        ' GET: orders
        Function Index() As ActionResult

            Dim orders = db.orders

            Return View(orders.ToList())
        End Function

        ' GET: orders/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim order As order = db.orders.Find(id)
            If IsNothing(order) Then
                Return HttpNotFound()
            End If
            Return View(order)
        End Function



        ' GET: orders/Create
        Function Create() As ActionResult

            Return View()
        End Function



        ' POST: orders/Create
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="order_id,order_number,order_date,eta,invoice_number")> ByVal order As order) As ActionResult

            If order.eta < DateTime.Now Then
                ModelState.AddModelError("ETA", "ETA date must not be in the past")
            End If
            If ModelState.IsValid Then
                db.orders.Add(order)
                db.SaveChanges()
                Dim orderID = db.orders.Where(Function(o) o.order_number = order.order_number).Select(Function(o) o.order_id).FirstOrDefault()

                Return RedirectToAction("Create", "items", New With {.OrderId = orderID})
            End If
            Return View(order)
        End Function


        ' GET: orders/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim order As order = db.orders.Find(id)
            If IsNothing(order) Then
                Return HttpNotFound()
            End If
            ViewBag.Items = db.items.Where(Function(a) a.order_id = id).FirstOrDefault()
            'ViewBag.item_id = New SelectList(db.items, "item_id", "item_name", order.item_id)
            Return View(order)
        End Function

        ' POST: orders/Edit/5
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="order_id,order_number,order_date,eta,invoice_number")> ByVal order As order) As ActionResult
            If ModelState.IsValid Then
                db.Entry(order).State = EntityState.Modified
                db.SaveChanges()
                Dim orderID = db.orders.Where(Function(o) o.order_number = order.order_number).Select(Function(o) o.order_id).FirstOrDefault()
                Return RedirectToAction("Create", "Received_stock", New With {.OrderId = orderID})
            End If
            ViewBag.CurrentOrder = db.orders.Where(Function(a) a.order_id = order.order_id).FirstOrDefault()
            Return View(order)
        End Function

        ' GET: orders/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim order As order = db.orders.Find(id)
            If IsNothing(order) Then
                Return HttpNotFound()
            End If
            Return View(order)
        End Function

        ' POST: orders/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim order As order = db.orders.Find(id)
            db.orders.Remove(order)
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
