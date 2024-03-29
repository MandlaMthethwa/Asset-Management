﻿@ModelType IEnumerable(Of ITAM.stock)
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
            @Html.DisplayNameFor(Function(model) model.quantity)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.order.invoice_number)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.status.status_name)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.quantity)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.order.invoice_number)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.status.status_name)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.stock_id }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.stock_id }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.stock_id })
        </td>
    </tr>
Next

</table>
