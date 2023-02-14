@ModelType IEnumerable(Of ITAM.order)
@Code
    ViewData("Title") = "Index"
End Code


@Html.AntiForgeryToken()

<h2>Orders</h2>
<div class="table-wrapper">

    <Table Class="table">
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
                    <a class="btn button-update" href="@Url.Action("create", "items", New With {.OrderID = item.order_id})"><i class="fa-solid fa-plus"></i> Items</a>
                    <a class="btn button-update" href="@Url.Action("Edit", New With {.id = item.order_id})"><i class="fas fa-pencil-alt" style="color:white;"></i></a>
                    <a class="btn  button-delete" href="@Url.Action("Delete", New With {.id = item.order_id})"><i class="fa-solid fa-trash"></i></a>
                </td>
            </tr>
        Next
    </Table>
</div>
<div style="padding:15px">
    @If ViewBag.PageNumber > 1 Then
        @Html.ActionLink("<< Go back", "Index", New With {.page = ViewBag.PageNumber - 1}, New With {.class = "button-update"})
    End If

    @If ViewBag.HasMoreData Then
        @Html.ActionLink("Show more >>", "Index", New With {.page = ViewBag.PageNumber + 1}, New With {.class = "button-update"})
    End If
</div>