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
    Public Class Asset_typeController
        Inherits System.Web.Mvc.Controller

        Private db As New itamDB

        ' GET: Asset_type
        Function Index() As ActionResult
            Return View(db.asset_type.ToList())
        End Function

        ' GET: Asset_type/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim asset_type As asset_type = db.asset_type.Find(id)
            If IsNothing(asset_type) Then
                Return HttpNotFound()
            End If
            Return View(asset_type)
        End Function

        ' GET: Asset_type/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: Asset_type/Create
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="type_id,asset_type1,order_id,asset_id")> ByVal asset_type As asset_type) As ActionResult
            If ModelState.IsValid Then
                db.asset_type.Add(asset_type)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(asset_type)
        End Function

        ' GET: Asset_type/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim asset_type As asset_type = db.asset_type.Find(id)
            If IsNothing(asset_type) Then
                Return HttpNotFound()
            End If
            Return View(asset_type)
        End Function

        ' POST: Asset_type/Edit/5
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="type_id,asset_type1,order_id,asset_id")> ByVal asset_type As asset_type) As ActionResult
            If ModelState.IsValid Then
                db.Entry(asset_type).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(asset_type)
        End Function

        ' GET: Asset_type/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim asset_type As asset_type = db.asset_type.Find(id)
            If IsNothing(asset_type) Then
                Return HttpNotFound()
            End If
            Return View(asset_type)
        End Function

        ' POST: Asset_type/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim asset_type As asset_type = db.asset_type.Find(id)
            db.asset_type.Remove(asset_type)
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
