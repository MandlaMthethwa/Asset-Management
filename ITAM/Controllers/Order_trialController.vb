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
    Public Class Order_trialController
        Inherits System.Web.Mvc.Controller

        Private db As New itamDB

        ' GET: Order_trial
        Function Index() As ActionResult
            Return View(db.trials.ToList())
        End Function

        ' GET: Order_trial/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim trial As trial = db.trials.Find(id)
            If IsNothing(trial) Then
                Return HttpNotFound()
            End If
            Return View(trial)
        End Function

        ' GET: Order_trial/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: Order_trial/Create
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="order_stock,model1,model2,model3,quantity1,quantity2,quantity3,invoice_number,date,description,eta")> ByVal trial As trial) As ActionResult
            If ModelState.IsValid Then
                db.trials.Add(trial)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(trial)
        End Function

        ' GET: Order_trial/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim trial As trial = db.trials.Find(id)
            If IsNothing(trial) Then
                Return HttpNotFound()
            End If
            Return View(trial)
        End Function

        ' POST: Order_trial/Edit/5
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="order_stock,model1,model2,model3,quantity1,quantity2,quantity3,invoice_number,date,description,eta")> ByVal trial As trial) As ActionResult
            If ModelState.IsValid Then
                db.Entry(trial).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(trial)
        End Function

        ' GET: Order_trial/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim trial As trial = db.trials.Find(id)
            If IsNothing(trial) Then
                Return HttpNotFound()
            End If
            Return View(trial)
        End Function

        ' POST: Order_trial/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim trial As trial = db.trials.Find(id)
            db.trials.Remove(trial)
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
