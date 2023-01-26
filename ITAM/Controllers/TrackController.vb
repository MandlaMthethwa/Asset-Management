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
    Public Class TrackController
        Inherits System.Web.Mvc.Controller

        Private db As New itamDB

        ' GET: Track
        Function Index() As ActionResult
            Dim locations = db.locations.Include(Function(l) l.asset)
            Return View(locations.ToList())
        End Function

        ' GET: Track/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim location As location = db.locations.Find(id)
            If IsNothing(location) Then
                Return HttpNotFound()
            End If
            Return View(location)
        End Function

        ' GET: Track/Create
        Function Create() As ActionResult
            ViewBag.asset_id = New SelectList(db.assets, "asset_id", "model")
            Return View()
        End Function

        ' POST: Track/Create
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="location_id,serial_number,location1,asset_id")> ByVal location As location) As ActionResult
            If ModelState.IsValid Then
                db.locations.Add(location)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.asset_id = New SelectList(db.assets, "asset_id", "model", location.asset_id)
            Return View(location)
        End Function

        ' GET: Track/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim location As location = db.locations.Find(id)
            If IsNothing(location) Then
                Return HttpNotFound()
            End If
            ViewBag.asset_id = New SelectList(db.assets, "asset_id", "model", location.asset_id)
            Return View(location)
        End Function

        ' POST: Track/Edit/5
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="location_id,serial_number,location1,asset_id")> ByVal location As location) As ActionResult
            If ModelState.IsValid Then
                db.Entry(location).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.asset_id = New SelectList(db.assets, "asset_id", "model", location.asset_id)
            Return View(location)
        End Function

        ' GET: Track/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim location As location = db.locations.Find(id)
            If IsNothing(location) Then
                Return HttpNotFound()
            End If
            Return View(location)
        End Function

        ' POST: Track/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim location As location = db.locations.Find(id)
            db.locations.Remove(location)
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
