@ModelType IEnumerable(Of ITAM.assign)
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
            @Html.DisplayNameFor(Function(model) model.assign_name)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.department)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.icf)
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
            @Html.DisplayFor(Function(modelItem) item.assign_name)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.department)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.icf)
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
            @Html.ActionLink("Edit", "Edit", New With {.id = item.assign_id }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.assign_id }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.assign_id })
        </td>
    </tr>
Next

</table>
