
    <header>
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
                    <li><a href="#"> Storerooms</a></li>
                    @*<li><a href=" @Url.Action("index", "status") ">Status</a></li>
                        <li><a href="@Url.Action("index", "Asset_type") ">Type</a></li>
                        <li><a href=" @Url.Action("index", "received_stock") ">Received Orders</a></l*@
                    @*<li>@Html.Partial("_LoginPartial")</li>*@
                </ul>
                <div class="icon menu-btn">
                    <i class="fas fa-bars"></i>
                </div>
            </div>
        </nav>
    </header>
