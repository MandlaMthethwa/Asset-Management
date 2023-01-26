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
    Public Class Return_AssetController
        Inherits System.Web.Mvc.Controller

        Private db As New itamDB

        ' GET: Return_Asset
        Function Index() As ActionResult
            Dim return_asset = db.return_asset.Include(Function(r) r.asset).Include(Function(r) r.asset_type).Include(Function(r) r.status)
            Return View(return_asset.ToList())
        End Function

        ' GET: Return_Asset/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim return_asset As return_asset = db.return_asset.Find(id)
            If IsNothing(return_asset) Then
                Return HttpNotFound()
            End If
            Return View(return_asset)
        End Function

        ' GET: Return_Asset/Create
        Function Create() As ActionResult
            ViewBag.asset_id = New SelectList(db.assets, "asset_id", "model")
            ViewBag.asset_type_id = New SelectList(db.asset_type, "type_id", "asset_type1")
            ViewBag.status_id = New SelectList(db.status, "status_id", "status_name")
            Return View()
        End Function

        ' POST: Return_Asset/Create
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="return_id,serial_number,return_date,manufacture,warranty_date,report,asset_id,asset_type_id,status_id")> ByVal return_asset As return_asset) As ActionResult
            If ModelState.IsValid Then
                db.return_asset.Add(return_asset)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.asset_id = New SelectList(db.assets, "asset_id", "model", return_asset.asset_id)
            ViewBag.asset_type_id = New SelectList(db.asset_type, "type_id", "asset_type1", return_asset.asset_type_id)
            ViewBag.status_id = New SelectList(db.status, "status_id", "status_name", return_asset.status_id)
            Return View(return_asset)
        End Function

        ' GET: Return_Asset/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim return_asset As return_asset = db.return_asset.Find(id)
            If IsNothing(return_asset) Then
                Return HttpNotFound()
            End If
            ViewBag.asset_id = New SelectList(db.assets, "asset_id", "model", return_asset.asset_id)
            ViewBag.asset_type_id = New SelectList(db.asset_type, "type_id", "asset_type1", return_asset.asset_type_id)
            ViewBag.status_id = New SelectList(db.status, "status_id", "status_name", return_asset.status_id)
            Return View(return_asset)
        End Function

        ' POST: Return_Asset/Edit/5
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="return_id,serial_number,return_date,manufacture,warranty_date,report,asset_id,asset_type_id,status_id")> ByVal return_asset As return_asset) As ActionResult
            If ModelState.IsValid Then
                db.Entry(return_asset).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.asset_id = New SelectList(db.assets, "asset_id", "model", return_asset.asset_id)
            ViewBag.asset_type_id = New SelectList(db.asset_type, "type_id", "asset_type1", return_asset.asset_type_id)
            ViewBag.status_id = New SelectList(db.status, "status_id", "status_name", return_asset.status_id)
            Return View(return_asset)
        End Function

        ' GET: Return_Asset/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim return_asset As return_asset = db.return_asset.Find(id)
            If IsNothing(return_asset) Then
                Return HttpNotFound()
            End If
            Return View(return_asset)
        End Function

        ' POST: Return_Asset/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim return_asset As return_asset = db.return_asset.Find(id)
            db.return_asset.Remove(return_asset)
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
