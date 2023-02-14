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
    <!--<header>
        <nav class="navbar">
            <div>
                <img class="logo" src="https://prontocs.co.za/wp-content/uploads/2018/01/Pronto-Inverted-Transparent-Globe.png" \>
            </div>
            <div class="content">
                <ul class="menu-list">
                    <div class="icon cancel-btn">
                        <i class="fas fa-times"></i>
                    </div>
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
                    <li><a href="#"> Storerooms</a></li>-->
    @*<li><a href=" @Url.Action("index", "status") ">Status</a></li>
        <li><a href="@Url.Action("index", "Asset_type") ">Type</a></li>
        <li><a href=" @Url.Action("index", "received_stock") ">Received Orders</a></l*@
    @*<li>@Html.Partial("_LoginPartial")</li>*@
    <!--</ul>
                <div class="icon menu-btn">
                    <i class="fas fa-bars"></i>
                </div>
            </div>
        </nav>

    </header>-->
    @Html.Partial("_Navigation")
    <section>
        @RenderBody()
    </section>

    <script type="text/javascript">
        const body = document.querySelector("body");
        const navbar = document.querySelector(".navbar");
        const menu = document.querySelector(".menu-list");
        const menuBtn = document.querySelector(".menu-btn");
        const cancelBtn = document.querySelector(".cancel-btn");
        menuBtn.onclick = () => {
            menu.classList.add("active");
            menuBtn.classList.add("hide");
            cancelBtn.classList.add("show");
            body.classList.add("disabledScroll");
        }
        cancelBtn.onclick = () => {
            menu.classList.remove("active");
            menuBtn.classList.remove("hide");
            cancelBtn.classList.remove("show");
            body.classList.remove("disabledScroll");
        }
        window.onscroll = () => {
            this.scrollY > 20 ? navbar.classList.add("sticky") : navbar.classList.remove("sticky");
        }
    </script>
</body>
</html>
@Scripts.Render("~/bundles/jquery")
@Scripts.Render("~/bundles/bootstrap")
@RenderSection("scripts", required:=False)
