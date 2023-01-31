@ModelType IEnumerable(Of ITAM.item)

@Code
End Code
<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <link rel="stylesheet" href="../Content/site.css" />
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

                    <a Class="btn button-update" @Html.ActionLink("Edit Item", "Edit", New With {.id = item.item_id})
                 <a Class="btn button-delete"  @Html.ActionLink("Remove Item", "Delete", New With {.id = item.item_id})
                </td>
            </tr>
        Next
    </table>
    <hr />
</body>
</html>
