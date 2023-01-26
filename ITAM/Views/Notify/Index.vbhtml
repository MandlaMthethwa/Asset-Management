@ModelType IEnumerable(Of ITAM.notification)
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
            @Html.DisplayNameFor(Function(model) model.message)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.requester_id)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.message)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.requester_id)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.notify_id }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.notify_id }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.notify_id })
        </td>
    </tr>
Next

</table>
