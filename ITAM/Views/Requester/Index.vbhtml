@ModelType IEnumerable(Of ITAM.requester)
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
            @Html.DisplayNameFor(Function(model) model.requester_name)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.requester_email_address)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.requester_contact_number)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.notification.message)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.order.manufacture)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.requester_name)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.requester_email_address)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.requester_contact_number)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.notification.message)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.order.manufacture)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.requester_id }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.requester_id }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.requester_id })
        </td>
    </tr>
Next

</table>
