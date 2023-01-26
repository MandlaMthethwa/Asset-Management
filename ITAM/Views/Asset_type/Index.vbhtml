@ModelType IEnumerable(Of ITAM.asset_type)
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
            @Html.DisplayNameFor(Function(model) model.asset_type1)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.order_id)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.asset_id)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.asset_type1)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.order_id)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.asset_id)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.type_id }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.type_id }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.type_id })
        </td>
    </tr>
Next

</table>
