@Code
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code
<!DOCTYPE html>
<html lang="en">
<head>
</head>

<body>
    <h2>Storerooms</h2>
    <table class="table">
        <tr>
            <th>Storeroom Name</th>
            <th>Action</th>
        </tr>
        <tr>
            <td>New Assets Room</td>
            <td><a class="button-update" href="@Url.Action("index", "assets")">View Assets</a></td>
        </tr>

        <tr>
            <td>Old Assets Room</td>
            <td><a class="button-update" href="@Url.Action("index", "return_asset")">View Assets</a></td>
        </tr>

        <tr>
            <td>Technicial room</td>
            <td><a class="button-update" href="@Url.Action("index")">View Assets</a></td>
        </tr>
    </table>
</body>
</html>