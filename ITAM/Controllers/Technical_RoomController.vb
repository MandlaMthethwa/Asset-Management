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
    Public Class Technical_RoomController
        Inherits System.Web.Mvc.Controller

        Private db As New itamDB

        ' GET: Technical_Room
        Function Index() As ActionResult
            Dim technical_room = db.technical_room.Include(Function(t) t.asset).Include(Function(t) t.status).Include(Function(t) t.technician)
            Return View(technical_room.ToList())
        End Function

        Function storerooms() As ActionResult
            Return View()
        End Function
        ' GET: Technical_Room/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim technical_room As technical_room = db.technical_room.Find(id)
            If IsNothing(technical_room) Then
                Return HttpNotFound()
            End If
            Return View(technical_room)
        End Function

        ' GET: Technical_Room/Create
        Function Create() As ActionResult
            ViewBag.asset_id = New SelectList(db.assets, "asset_id", "model")
            ViewBag.status_id = New SelectList(db.status, "status_id", "status_name")
            ViewBag.technician_id = New SelectList(db.technicians, "technician_id", "technician_name")
            Return View()
        End Function

        ' POST: Technical_Room/Create
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="technical_id,upload_icf,status_id,asset_id,technician_id")> ByVal technical_room As technical_room) As ActionResult
            If ModelState.IsValid Then
                db.technical_room.Add(technical_room)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.asset_id = New SelectList(db.assets, "asset_id", "model", technical_room.asset_id)
            ViewBag.status_id = New SelectList(db.status, "status_id", "status_name", technical_room.status_id)
            ViewBag.technician_id = New SelectList(db.technicians, "technician_id", "technician_name", technical_room.technician_id)
            Return View(technical_room)
        End Function

        ' GET: Technical_Room/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim technical_room As technical_room = db.technical_room.Find(id)
            If IsNothing(technical_room) Then
                Return HttpNotFound()
            End If
            ViewBag.asset_id = New SelectList(db.assets, "asset_id", "model", technical_room.asset_id)
            ViewBag.status_id = New SelectList(db.status, "status_id", "status_name", technical_room.status_id)
            ViewBag.technician_id = New SelectList(db.technicians, "technician_id", "technician_name", technical_room.technician_id)
            Return View(technical_room)
        End Function

        ' POST: Technical_Room/Edit/5
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="technical_id,upload_icf,status_id,asset_id,technician_id")> ByVal technical_room As technical_room) As ActionResult
            If ModelState.IsValid Then
                db.Entry(technical_room).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.asset_id = New SelectList(db.assets, "asset_id", "model", technical_room.asset_id)
            ViewBag.status_id = New SelectList(db.status, "status_id", "status_name", technical_room.status_id)
            ViewBag.technician_id = New SelectList(db.technicians, "technician_id", "technician_name", technical_room.technician_id)
            Return View(technical_room)
        End Function

        ' GET: Technical_Room/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim technical_room As technical_room = db.technical_room.Find(id)
            If IsNothing(technical_room) Then
                Return HttpNotFound()
            End If
            Return View(technical_room)
        End Function

        ' POST: Technical_Room/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim technical_room As technical_room = db.technical_room.Find(id)
            db.technical_room.Remove(technical_room)
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
