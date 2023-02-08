<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="../Content/fontawesome-free/css/all.min.css">

    <title>@ViewBag.Title - ITAM</title>
    @Styles.Render("~/Content/css")
    @Scripts.Render("~/bundles/modernizr")

</head>
<body>
    <header>
        <div class="toggle-btn" id="toggle-btn" onClick="myfunction();">
            <span></span>
            <span></span>
            <span></span>
        </div>
        <div>
            <img class="logo" src="https://prontocs.co.za/wp-content/uploads/2018/01/Pronto-Inverted-Transparent-Globe.png" \>
        </div>
        <nav id="nav">
            <ul>
                <li>
                    <a>Orders</a>
                    <ul>
                        <li><a href=" @Url.Action("index", "orders")">View Orderes</a>
                        <li><a href=" @Url.Action("create", "orders")">Add a new Order</a>
                    </ul>
                </li>
                <li><a href="#">Book In </a></li>
                <li><a href="#">Return</a></li>
                <li><a href="#">Assets</a></li>
                <li><a href="#"> Storerooms</a></li>
                @*<li><a href=" @Url.Action("index", "status") ">Status</a></li>
                    <li><a href="@Url.Action("index", "Asset_type") ">Type</a></li>
                    <li><a href=" @Url.Action("index", "received_stock") ">Received Orders</a></li>*@
                @*<li>@Html.Partial("_LoginPartial")</li>*@
            </ul>
        </nav>
    </header>
    <main>
        @RenderBody()
    </main>


    <script type="text/javascript">
        function myfunction() {
            var navbar = document.getElementById("nav");
            navbar.classList.toggle("show");
        }
    </script>

</body>
</html>
@Scripts.Render("~/bundles/jquery")
@Scripts.Render("~/bundles/bootstrap")
@RenderSection("scripts", required:=False)
