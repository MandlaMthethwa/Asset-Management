<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>@ViewBag.Title - ITAM</title>
    @Styles.Render("~/Content/css")
    @Scripts.Render("~/bundles/modernizr")



</head>
<body>
    <header>
        <nav>
            <img class="logo" src="https://prontocs.co.za/wp-content/uploads/2018/01/Pronto-Inverted-Transparent-Globe.png" \>
            <ul>
                <li><a href="@Url.Action("create", "assets")">Book In </a></li>
                <li><a href="@Url.Action("create", "return_asset")">Return</a></li>
                <li><a href=" @Url.Action("index", "orders")">Orders</a></li>
                <li>
                    <a href="@Url.Action("index", "assets")">Assets</a>
                    @*<ul>
                        <li><a href="@Url.Action("index", "assets")">All Assets</a></li>
                        <li><a href="views/computers.html">Computers (10)</a></li>
                        <li><a>Monitors (20)</a></li>
                    </ul>*@
                </li>
                <li><a href="@Url.Action("storerooms", "Technical_Room")"> Storerooms</a></li>
                <li><a href=" @Url.Action("index", "status") ">Status</a></li>
                <li><a href="@Url.Action("index", "Asset_type") ">Type</a></li>
                <li><a href=" @Url.Action("index", "received_stock") ">Received Orders</a></li>


                @Html.Partial("_LoginPartial")
            </ul>
        </nav>
    </header>


    @RenderBody()
    @Scripts.Render("~/bundles/jquery")
    @Scripts.Render("~/bundles/bootstrap")
    @RenderSection("scripts", required:=False)


</body>
</html>
