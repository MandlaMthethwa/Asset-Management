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
    Public Class NotifyController
        Inherits System.Web.Mvc.Controller

        Private db As New itamDB

        ' GET: Notify
        Function Index() As ActionResult
            Return View(db.notifications.ToList())
        End Function

        ' GET: Notify/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim notification As notification = db.notifications.Find(id)
            If IsNothing(notification) Then
                Return HttpNotFound()
            End If
            Return View(notification)
        End Function

        ' GET: Notify/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: Notify/Create
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="notify_id,message,requester_id")> ByVal notification As notification) As ActionResult
            If ModelState.IsValid Then
                db.notifications.Add(notification)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(notification)
        End Function

        ' GET: Notify/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim notification As notification = db.notifications.Find(id)
            If IsNothing(notification) Then
                Return HttpNotFound()
            End If
            Return View(notification)
        End Function

        ' POST: Notify/Edit/5
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="notify_id,message,requester_id")> ByVal notification As notification) As ActionResult
            If ModelState.IsValid Then
                db.Entry(notification).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(notification)
        End Function

        ' GET: Notify/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim notification As notification = db.notifications.Find(id)
            If IsNothing(notification) Then
                Return HttpNotFound()
            End If
            Return View(notification)
        End Function

        ' POST: Notify/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim notification As notification = db.notifications.Find(id)
            db.notifications.Remove(notification)
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
