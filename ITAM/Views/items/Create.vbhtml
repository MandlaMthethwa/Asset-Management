@ModelType ITAM.item
@Code
    ViewData("Title") = "Create"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Add Item</h2>

@Using (Html.BeginForm())
    @Html.AntiForgeryToken()

    @<div class="form-horizontal">

    @Html.ValidationSummary(True, "", New With {.class = "text-danger"})

    <h3>Order details</h3>
    <hr />
    <table style="width:100%">
        <tr>
            <th>Order Number</th>
            <th>Invoice number</th>
            <th>Order date</th>

        </tr>

        <tr>
            <td>@ViewBag.CurrentOrder.order_number</td>
            <td>@ViewBag.CurrentOrder.invoice_number</td>
            <td>@ViewBag.CurrentOrder.order_date</td>
        </tr>
    </table>
    <hr />
    <h3>Items ordered</h3>
    <table style="width:100%">
        <tr>
            <th>Item Name</th>
            <th>Description</th>
            <th>Quantity</th>
            <th>Manufacturer</th>
            <th>Action</th>
        </tr>
         <tr>

             <td>@ViewBag.Items.item_name</td>
             <td>@ViewBag.Items.description</td>
             <td>@ViewBag.Items.quantity</td>
             <td>@ViewBag.Items.manufacture</td>
            <td>

                <a Class="btn button-update" @Html.ActionLink("Edit Item", "Edit", New With {.id = ViewBag.Items.item_id})
                 <a Class="btn button-delete"  @Html.ActionLink("Remove Item", "Delete", New With {.id = ViewBag.Items.item_id})

            </td>
        </tr>
          
    </table>
    <hr />
    <h3> Add Item</h3>
    <Table>
            <tr>
            <td>
                @Html.EditorFor(Function(model) model.item_name, New With {.htmlAttributes = New With {.class = "form-control", .placeholder = "Enter Item Name"}})
                @Html.ValidationMessageFor(Function(model) model.item_name, "", New With {.class = "text-danger"})

            </td>
            <td>
                @Html.EditorFor(Function(model) model.description, New With {.htmlAttributes = New With {.class = "form-control", .placeholder = "Enter Order Description"}})
                @Html.ValidationMessageFor(Function(model) model.description, "", New With {.class = "text-danger"})

            </td>
            <td>
                @Html.EditorFor(Function(model) model.quantity, New With {.htmlAttributes = New With {.class = "form-control", .placeholder = "Enter Quantity"}})
                @Html.ValidationMessageFor(Function(model) model.quantity, "", New With {.class = "text-danger"})

            </td>
            <td>
                @Html.EditorFor(Function(model) model.manufacture, New With {.htmlAttributes = New With {.class = "form-control", .placeholder = "Enter The Manufacturer "}})
                @Html.ValidationMessageFor(Function(model) model.manufacture, "", New With {.class = "text-danger"})

            </td>
            <td>
            <input type = "submit" value="Add Asset" Class="btn button-add" />
            </td>

        </tr>
    </table>

    <div>
        @Html.HiddenFor(Function(model) model.order_id, New With {.Value = ViewBag.OrderID})
    </div>
    <br /><br />
    <div>
            <a style = "text-align: right; float:right;" Class="btn btn-default" @Html.ActionLink("Done", "Index", "Orders")  |
        <a style = "text-align: right; float:left;" Class="btn btn-default" @Html.ActionLink("Add a new order", "Create", "Orders")

    </div>
    
</div>
End Using



@Section Scripts
    @Scripts.Render("~/bundles/jqueryval")
End Section
