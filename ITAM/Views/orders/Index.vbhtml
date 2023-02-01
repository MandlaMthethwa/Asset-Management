@ModelType IEnumerable(Of ITAM.order)
@Code
    ViewData("Title") = "Index"
End Code
<link rel="stylesheet" href="../Content/site" />

<h2>Orders</h2>
<div><a class="button-add" @Html.ActionLink("Add a new order", "Create")> </a> </div>
<br />
<br />

<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.order_number)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.order_date)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.eta)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.invoice_number)
        </th>
        <th></th>
    </tr>

    @For Each item In Model
        @<tr>
            <td>
                @Html.DisplayFor(Function(modelItem) item.order_number)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.order_date)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.eta)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.invoice_number)
            </td>

            <td>
             <a class="btn button-add" href="@Url.Action("Edit", New With {.id = item.order_id})">Update Order details</a>
                @*@Html.ActionLink("ItemsOrderd", "Items", New With {.htmlAttributes = New With {.id = item.order_id}})*@
                
                <a class="btn button-add" href="@Url.Action("create", "items", New With {.OrderID = item.order_id})">Add or Edit Items</a>
                @*<a id="item.order_id" href="../Items/Create">Create</a>
                @Html.ActionLink("Details", "Index", "Items", New With {.id = item.order_id}) |
                @Html.ActionLink("Delete", "Delete", New With {.id = item.order_id})*@
            </td>
        </tr>
    Next

</table>
