@ModelType IEnumerable(Of ITAM.technician)
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
            @Html.DisplayNameFor(Function(model) model.technician_name)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.technician_name)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.technician_id }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.technician_id }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.technician_id })
        </td>
    </tr>
Next

</table>
