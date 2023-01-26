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
    Public Class StatusController
        Inherits System.Web.Mvc.Controller

        Private db As New itamDB

        ' GET: Status
        Function Index() As ActionResult
            Return View(db.status.ToList())
        End Function

        ' GET: Status/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim status As status = db.status.Find(id)
            If IsNothing(status) Then
                Return HttpNotFound()
            End If
            Return View(status)
        End Function

        ' GET: Status/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: Status/Create
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="status_id,status_name,description")> ByVal status As status) As ActionResult
            If ModelState.IsValid Then
                db.status.Add(status)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(status)
        End Function

        ' GET: Status/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim status As status = db.status.Find(id)
            If IsNothing(status) Then
                Return HttpNotFound()
            End If
            Return View(status)
        End Function

        ' POST: Status/Edit/5
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="status_id,status_name,description")> ByVal status As status) As ActionResult
            If ModelState.IsValid Then
                db.Entry(status).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(status)
        End Function

        ' GET: Status/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim status As status = db.status.Find(id)
            If IsNothing(status) Then
                Return HttpNotFound()
            End If
            Return View(status)
        End Function

        ' POST: Status/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim status As status = db.status.Find(id)
            db.status.Remove(status)
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
