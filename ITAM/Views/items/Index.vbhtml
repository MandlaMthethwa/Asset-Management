@ModelType IEnumerable(Of ITAM.item)
@Code
    ViewData("Title") = "Index"
End Code

<h2>Items Ordered</h2>
<link rel="stylesheet" href="../Content/site.css" />

<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.item_name)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.description)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.quantity)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.manufacture)
        </th>
        <th>@Html.DisplayNameFor(Function(model) model.order_id)</th>
        <th></th>
    </tr>

    @For Each item In Model
        @<tr>
            <td>
                @Html.DisplayFor(Function(modelItem) item.item_name)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.description)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.quantity)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.manufacture)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.order_id)
            </td>
            <td>
                @Html.ActionLink("Edit", "Edit", New With {.id = item.item_id}) |
                @Html.ActionLink("Details", "Details", New With {.id = item.item_id}) |
                @Html.ActionLink("Delete", "Delete", New With {.id = item.item_id})
            </td>
        </tr>
    Next

</table>
