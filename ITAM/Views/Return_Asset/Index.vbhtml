@ModelType IEnumerable(Of ITAM.return_asset)
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
            @Html.DisplayNameFor(Function(model) model.report)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.asset.model)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.asset_type.asset_type1)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.status.status_name)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.report)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.asset.model)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.asset_type.asset_type1)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.status.status_name)
        </td>
        <td>
            @*@Html.ActionLink("Edit", "Edit", New With {.id = item.PrimaryKey}) |
            @Html.ActionLink("Details", "Details", New With {.id = item.PrimaryKey}) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.PrimaryKey})*@
        </td>
    </tr>
Next

</table>
