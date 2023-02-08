@ModelType IEnumerable(Of ITAM.item)


<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <link rel="stylesheet" href="../Content/site" />
    <title>Items</title>
</head>
<body>
    <h3>Items ordered</h3>
    <table style="width:100%">
        <tr>
            <th>Item Name</th>
            <th>Description</th>
            <th>Quantity</th>
            <th>Manufacturer</th>
            <th>Action</th>
        </tr>
        @For Each item In Model
            @<tr>
                <td>
                    @Html.DisplayFor(Function(modelItem) item.item_name)
                </td>
                <td>
                    @Html.DisplayFor(Function(modelItem) item.description)
                </td>
                <td>
                    @Html.DisplayFor(Function(modelItem) item.quantity)
                </td>
                <td>
                    @Html.DisplayFor(Function(modelItem) item.manufacture)
                </td>
                <td>
                    <a Class="btn button-update" href ="@Url.Action("Edit", New With {.id = item.item_id})"><i class="fas fa-pencil-alt" style="color:white;"></i></a>
                    <a Class="btn button-delete" href="@Url.Action("Delete", New With {.id = item.item_id})"><i class="fa-solid fa-trash"></i></a>
                </td>
            </tr>
        Next
    </table>
    <br />
    @If ViewBag.PageNumber > 1 Then
        @Html.ActionLink("<< Go back", "create", New With {.page = ViewBag.PageNumber - 1, .OrderID = ViewBag.OrderID}, New With {.class = "button-update"})
    End If

    @If ViewBag.HasMoreData Then
        @Html.ActionLink("Show more >>", "create", New With {.page = ViewBag.PageNumber + 1, .OrderID = ViewBag.OrderID}, New With {.class = "button-update"})
    End If
    <hr />

</body>
</html>
