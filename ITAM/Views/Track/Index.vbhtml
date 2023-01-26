@ModelType IEnumerable(Of ITAM.location)
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
            @Html.DisplayNameFor(Function(model) model.serial_number)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.location1)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.asset.model)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.serial_number)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.location1)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.asset.model)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.location_id }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.location_id }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.location_id })
        </td>
    </tr>
Next

</table>
