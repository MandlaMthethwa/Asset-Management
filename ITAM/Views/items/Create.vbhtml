@ModelType ITAM.item
@Code
    ViewData("Title") = "Create"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Add Item</h2>
@Using (Html.BeginForm()) 
    @Html.AntiForgeryToken()

    @<div class="form-horizontal">
    <h3>Order details</h3>
    <hr />
    @Html.ValidationSummary(True, "", New With {.class = "text-danger"})


    <div style="color:white">
        <h4>Order Number </h4>
        @ViewBag.CurrentOrder.order_number
    </div>
    <br />
    <div style="color:white">
        <h4>Invoice Number</h4>
        @ViewBag.CurrentOrder.invoice_number
    </div>
    <br />
    <div style="color:white">
        <h4>Order Date </h4>
        @ViewBag.CurrentOrder.order_date
    </div>

    <hr />
    <h3>Add Items ordered</h3>

    <div class="form-group ">
        @*@Html.LabelFor(Function(model) model.item_name, htmlAttributes:=New With {.class = "control-label col-md-2"})*@
        <div class="col-md-10">
            @Html.EditorFor(Function(model) model.item_name, New With {.htmlAttributes = New With {.class = "form-control", .placeholder = "Enter Item Name"}})
            @Html.ValidationMessageFor(Function(model) model.item_name, "", New With {.class = "text-danger"})
        </div>
    </div>

    <div class="form-group">
        @*@Html.LabelFor(Function(model) model.description, htmlAttributes:=New With {.class = "control-label col-md-2"})*@
        <div class="col-md-10">
            @Html.EditorFor(Function(model) model.description, New With {.htmlAttributes = New With {.class = "form-control", .placeholder = "Enter Order Description"}})
            @Html.ValidationMessageFor(Function(model) model.description, "", New With {.class = "text-danger"})
        </div>
    </div>

    <div class="form-group">
        @*@Html.LabelFor(Function(model) model.quantity, htmlAttributes:=New With {.class = "control-label col-md-2"})*@
        <div class="col-md-10">
            @Html.EditorFor(Function(model) model.quantity, New With {.htmlAttributes = New With {.class = "form-control", .placeholder = "Enter Quantity"}})
            @Html.ValidationMessageFor(Function(model) model.quantity, "", New With {.class = "text-danger"})
        </div>
    </div>

    <div class="form-group">
        @*@Html.LabelFor(Function(model) model.manufacture, htmlAttributes:=New With {.class = "control-label col-md-2"})*@
        <div class="col-md-10">
            @Html.EditorFor(Function(model) model.manufacture, New With {.htmlAttributes = New With {.class = "form-control", .placeholder = "Enter The Manufacturer "}})
            @Html.ValidationMessageFor(Function(model) model.manufacture, "", New With {.class = "text-danger"})
        </div>
    </div>
    <div>
        @Html.HiddenFor(Function(model) model.order_id, New With {.Value = ViewBag.OrderID})
    </div>
    <div>
        @*@Html.Action("create", "Orders", New With {.order_id = Model.order_id})*@
    </div>

    <div class="form-group">
        <div class="col-md-offset-2 col-md-10">
            <input type="submit" value="Add Asset" class="btn btn-default" />
        </div>
    </div>
</div>
End Using

<div>
 <a class="btn btn-default" href" @Html.ActionLink("Done", "Index", "Orders")" </a>
</div>

@Section Scripts
    @Scripts.Render("~/bundles/jqueryval")
End Section
