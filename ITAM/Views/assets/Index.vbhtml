@ModelType IEnumerable(Of ITAM.asset)
@Code
ViewData("Title") = "Index"
Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Index</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table" >
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.model)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.po_number)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.manufacture)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.serial_number)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.description)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.warranty_date)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.asset_type_id)
        </th>
        
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.order.manufacture)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.status.status_name)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.model)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.po_number)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.manufacture)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.serial_number)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.description)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.warranty_date)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.asset_type_id)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.order.manufacture)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.status.status_name)
        </td>
        <td>
            @Html.ActionLink("Add Serial Number", "Edit", New With {.id = item.asset_id}) |
            @*@Html.ActionLink("Details", "Details", New With {.id = item.asset_id}) |*@
            <a class="button" href="@Url.Action("create", "Assign_asset")">Assign</a>
        </td>
    </tr>
Next

</table>
