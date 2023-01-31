@ModelType IEnumerable(Of ITAM.order)
@Code
    ViewData("Title") = "Index"
End Code
<link rel="stylesheet" href="../Content/site.css" />

<h2>Orders</h2>
<div><a class="button-add" @Html.ActionLink("Add a new order", "Create")> </a> </div>
<br />
<br />

<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.order_number)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.order_date)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.eta)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.invoice_number)
        </th>
        <th></th>
    </tr>

    @For Each item In Model
        @<tr>
            <td>
                @Html.DisplayFor(Function(modelItem) item.order_number)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.order_date)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.eta)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.invoice_number)
            </td>

            <td>
                @Html.ActionLink("Edit", "Edit", New With {.id = item.order_id}) |
                @*@Html.Action("Create", "Items", New With {.id = item.order_id})*@
                |
                @Html.ActionLink("Details", "Index", "Items", New With {.id = item.order_id}) |
                @Html.ActionLink("Delete", "Delete", New With {.id = item.order_id})
            </td>
        </tr>
    Next

</table>
