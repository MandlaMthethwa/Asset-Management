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
    Public Class assetsController
        Inherits System.Web.Mvc.Controller

        Private db As New itamDB

        ' GET: assets
        Function Index() As ActionResult
            Dim assets = db.assets.Include(Function(a) a.order).Include(Function(a) a.status)
            Return View(assets.ToList())
        End Function

        ' GET: assets/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim asset As asset = db.assets.Find(id)
            If IsNothing(asset) Then
                Return HttpNotFound()
            End If
            Return View(asset)
        End Function

        ' GET: assets/Create
        Function Create() As ActionResult
            ViewBag.asset_id = New SelectList(db.assets, "asset_id", "model")
            'ViewBag.asset_id = New SelectList(db.asset_type, "type_id", "asset_type")
            ViewBag.order_id = New SelectList(db.orders, "order_id", "quantity")
            ViewBag.status_id = New SelectList(db.status, "status_id", "status_name")
            Return View()
        End Function

        ' POST: assets/Create
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="asset_id,model,po_number,manufacture,serial_number,description,warranty_date,status_id,order_id,asset_type_id")> ByVal asset As asset) As ActionResult
            If ModelState.IsValid Then
                db.assets.Add(asset)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.asset_id = New SelectList(db.assets, "asset_id", "model", asset.asset_id)
            'ViewBag.asset_id = New SelectList(db.asset_type, "type_id", "asset_type", asset.asset_type_id)
            ViewBag.order_id = New SelectList(db.orders, "order_id", "quantity", asset.order_id)
            ViewBag.status_id = New SelectList(db.status, "status_id", "status_name", asset.status_id)
            Return View(asset)
        End Function

        ' GET: assets/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim asset As asset = db.assets.Find(id)
            If IsNothing(asset) Then
                Return HttpNotFound()
            End If
            ViewBag.asset_id = New SelectList(db.assets, "asset_id", "model", asset.asset_id)
            'ViewBag.asset_id = New SelectList(db.asset_type, "type_id", "asset_type", asset.asset_type_id)
            ViewBag.status_id = New SelectList(db.status, "status_id", "status_name", asset.status_id)
            Return View(asset)
        End Function

        ' POST: assets/Edit/5
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="asset_id,model,po_number,manufacture,serial_number,description,warranty_date,status_id,order_id,asset_type_id")> ByVal asset As asset) As ActionResult
            If ModelState.IsValid Then
                db.Entry(asset).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.asset_id = New SelectList(db.assets, "asset_id", "model", asset.asset_id)
            'ViewBag.asset_id = New SelectList(db.asset_type, "type_id", "asset_type", asset.asset_type_id)
            ViewBag.order_id = New SelectList(db.orders, "order_id", "quantity", asset.order_id)
            ViewBag.status_id = New SelectList(db.status, "status_id", "status_name", asset.status_id)
            Return View(asset)
        End Function

        ' GET: assets/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim asset As asset = db.assets.Find(id)
            If IsNothing(asset) Then
                Return HttpNotFound()
            End If
            Return View(asset)
        End Function

        ' POST: assets/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim asset As asset = db.assets.Find(id)
            db.assets.Remove(asset)
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
