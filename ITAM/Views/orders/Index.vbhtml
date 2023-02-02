@ModelType IEnumerable(Of ITAM.order)
@Code
    ViewData("Title") = "Index"
End Code
<link rel="stylesheet" href="../Content/site" />

<h2>Orders</h2>

@Using (Html.BeginForm())
    @Html.AntiForgeryToken()
    @<div> <a Class="button-add" style="float:left" href ="@Url.Action("Create")"> Add a new order</a> </div> @<br/>@<br/>

    @<Table style="width:150%" Class="table">
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
        <th> Action</th>
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
            <a class="btn button-update" href="@Url.Action("Edit", New With {.id = item.order_id})">Update Order details</a>
            <a class="btn button-update" href="@Url.Action("create", "items", New With {.OrderID = item.order_id})">Add or Edit Items</a> 
            <a class="btn  button-delete" href="@Url.Action("Delete", New With {.id = item.order_id})">Remove Order</a>
         </td>
       </tr>
    Next

    </Table>
End Using