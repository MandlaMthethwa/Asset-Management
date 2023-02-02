@ModelType  ITAM.order

@Code
    ViewData("Title") = "Edit"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Edit</h2>
@Using (Html.BeginForm())
    @Html.AntiForgeryToken()

    @<Table class="table">
    <tr><th>Order Number</th> <th>Order Date</th> <th>ETA</th> <th>Invoice Number</th><th>Action</th></tr>
    
    <tr>
    <td>
    @Html.EditorFor(Function(model) model.order_number, New With {.htmlAttributes = New With {.class = "form-control"}})
    @Html.ValidationMessageFor(Function(model) model.order_number, "", New With {.class = "text-danger"})
        </td>
    <td>
        @Html.EditorFor(Function(model) model.order_date, New With {.htmlAttributes = New With {.class = "form-control"}})
        @Html.ValidationMessageFor(Function(model) model.order_date, "", New With {.class = "text-danger"})
    </td>
    <td>
        @Html.EditorFor(Function(model) model.eta, New With {.htmlAttributes = New With {.class = "form-control"}})
        @Html.ValidationMessageFor(Function(model) model.eta, "", New With {.class = "text-danger"})
    </td>
    <td>
        @Html.EditorFor(Function(model) model.invoice_number, New With {.htmlAttributes = New With {.class = "form-control"}})
        @Html.ValidationMessageFor(Function(model) model.invoice_number, "", New With {.class = "text-danger"})
    </td>
    <td>
        <input type="submit" value="Update" class="btn button-update" />
    </td>
    </tr>
    </Table>
     @<div>
            <a style = "text-align: right; float:right;" Class="btn button-add" @Html.ActionLink("Cancel", "Index")
        </div>

End Using



@Section Scripts
    @Scripts.Render("~/bundles/jqueryval")
End Section
