@ModelType ITAM.item
@Code
    ViewData("Title") = "Delete"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Delete</h2>

<h3 style="color:red">Are you sure you want to delete this item?</h3>

<hr />

@Using (Html.BeginForm())
    @Html.AntiForgeryToken()
    @<Table Class="table">
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
        <th> Action</th>
    </tr>

    <tr>
            <td>
        @Html.DisplayFor(Function(model) model.item_name)
        </td>
        <td>
        @Html.DisplayFor(Function(model) model.description)
        </td>
        <td>
        @Html.DisplayFor(Function(model) model.quantity)
        </td>
        <td>
        @Html.DisplayFor(Function(model) model.manufacture)
        @Html.HiddenFor(Function(model) model.order_id)
        </td>
        <td>
            <input type="submit" value="Delete" class="btn button-delete" />
            @*<a Class="btn button-update" style="float:right" href="@Html.Action("create", "items", New With {.OrderID = ViewBag.OrderId})">Cancel</a>*@

        </td>
    </tr>
</table>

End Using
@*<a Class="btn button-add" href="@Url.Action("create", New With {.OrderID = ViewBag.OrderID})">Cancel</a>*@
