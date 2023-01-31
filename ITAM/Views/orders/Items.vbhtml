@ModelType IEnumerable(Of ITAM.order)

@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Items</title>
</head>
<body>
    @*<table>
        <tr>
            <th>Item Name</th>
            <th>Description</th>
            <th>Quantity</th>
            <th>Manufacturer</th>

        </tr>*@
         
                @ViewBag.Items.item_name
                @ViewBag.Items.description
                @ViewBag.Items.quantity
                @ViewBag.Items.manufacture
            
        

</body>
</html>
