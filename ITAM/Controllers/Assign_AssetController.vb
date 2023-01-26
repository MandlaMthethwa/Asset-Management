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
    Public Class Assign_AssetController
        Inherits System.Web.Mvc.Controller

        Private db As New itamDB

        ' GET: Assign_Asset
        Function Index() As ActionResult
            Dim assigns = db.assigns.Include(Function(a) a.asset).Include(Function(a) a.status).Include(Function(a) a.technician)
            Return View(assigns.ToList())
        End Function

        ' GET: Assign_Asset/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim assign As assign = db.assigns.Find(id)
            If IsNothing(assign) Then
                Return HttpNotFound()
            End If
            Return View(assign)
        End Function

        ' GET: Assign_Asset/Create
        Function Create() As ActionResult
            ViewBag.asset_id = New SelectList(db.assets, "asset_id", "model")
            ViewBag.status_id = New SelectList(db.status, "status_id", "status_name")
            ViewBag.technician_id = New SelectList(db.technicians, "technician_id", "technician_name")
            Return View()
        End Function

        ' POST: Assign_Asset/Create
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="assign_id,assign_name,department,icf,asset_id,status_id,technician_id")> ByVal assign As assign) As ActionResult
            If ModelState.IsValid Then
                db.assigns.Add(assign)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.asset_id = New SelectList(db.assets, "asset_id", "model", assign.asset_id)
            ViewBag.status_id = New SelectList(db.status, "status_id", "status_name", assign.status_id)
            ViewBag.technician_id = New SelectList(db.technicians, "technician_id", "technician_name", assign.technician_id)
            Return View(assign)
        End Function

        ' GET: Assign_Asset/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim assign As assign = db.assigns.Find(id)
            If IsNothing(assign) Then
                Return HttpNotFound()
            End If
            ViewBag.asset_id = New SelectList(db.assets, "asset_id", "model", assign.asset_id)
            ViewBag.status_id = New SelectList(db.status, "status_id", "status_name", assign.status_id)
            ViewBag.technician_id = New SelectList(db.technicians, "technician_id", "technician_name", assign.technician_id)
            Return View(assign)
        End Function

        ' POST: Assign_Asset/Edit/5
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="assign_id,assign_name,department,icf,asset_id,status_id,technician_id")> ByVal assign As assign) As ActionResult
            If ModelState.IsValid Then
                db.Entry(assign).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.asset_id = New SelectList(db.assets, "asset_id", "model", assign.asset_id)
            ViewBag.status_id = New SelectList(db.status, "status_id", "status_name", assign.status_id)
            ViewBag.technician_id = New SelectList(db.technicians, "technician_id", "technician_name", assign.technician_id)
            Return View(assign)
        End Function

        ' GET: Assign_Asset/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim assign As assign = db.assigns.Find(id)
            If IsNothing(assign) Then
                Return HttpNotFound()
            End If
            Return View(assign)
        End Function

        ' POST: Assign_Asset/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim assign As assign = db.assigns.Find(id)
            db.assigns.Remove(assign)
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
