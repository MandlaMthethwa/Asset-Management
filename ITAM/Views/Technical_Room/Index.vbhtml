@ModelType IEnumerable(Of ITAM.technical_room)
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
            @Html.DisplayNameFor(Function(model) model.upload_icf)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.asset.model)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.status.status_name)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.technician.technician_name)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.upload_icf)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.asset.model)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.status.status_name)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.technician.technician_name)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.technical_id }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.technical_id }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.technical_id })
        </td>
    </tr>
Next

</table>
