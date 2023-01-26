@ModelType IEnumerable(Of ITAM.trial)
@Code
ViewData("Title") = "Index"
Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Index</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.order_stock)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.date)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.description)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.eta)
        </th>
        @*<th>
            @Html.DisplayNameFor(Function(model) model.quantity1)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.quantity2)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.quantity3)
        </th>*@
        <th>
            @Html.DisplayNameFor(Function(model) model.invoice_number)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
    <td>
        @Html.DisplayFor(Function(modelItem) item.order_stock)
    </td>
    <td>
        @Html.DisplayFor(Function(modelItem) item.date)
    </td>
    <td>
        @Html.DisplayFor(Function(modelItem) item.description)
    </td>
    <td>
        @Html.DisplayFor(Function(modelItem) item.eta)
    </td>
    @*<td>
        @Html.DisplayFor(Function(modelItem) item.quantity1)
    </td>
    <td>
        @Html.DisplayFor(Function(modelItem) item.quantity2)
    </td>
    <td>
        @Html.DisplayFor(Function(modelItem) item.quantity3)
    </td>*@
    <td>
        @Html.DisplayFor(Function(modelItem) item.invoice_number)
    </td>
    <td>
        @Html.ActionLink("Receive Stock", "Edit", New With {.id = item.order_stock}) 
        @*@Html.ActionLink("Details", "Details", New With {.id = item.order_stock}) |
        @Html.ActionLink("Delete", "Delete", New With {.id = item.order_stock})*@
    </td>
</tr>
Next

</table>
