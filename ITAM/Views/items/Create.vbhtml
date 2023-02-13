@ModelType ITAM.item
@Code
    ViewData("Title") = "Create"
End Code
<script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
<br />
<br />

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
                <td>@ViewBag.CurrentOrder.order_date.ToShortDateString()</td>
            </tr>
        </table>
        <hr />
        <div>@Html.Action("ItemsOrdered", New With {.htmlAttributes = New With {.id = ViewBag.OrderID}})</div>
        <h3> Add Item</h3>
        <Table>
            <tr>
                <td>
                    @Html.EditorFor(Function(model) model.item_name, New With {.htmlAttributes = New With {.class = "form-control", .placeholder = "Enter Item Name", .id = "firstInputField"}})
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
                    <input type="submit" value="Add Asset" Class="btn button-add" />
                </td>

            </tr>
        </Table>

        <div>
            @Html.HiddenFor(Function(model) model.order_id, New With {.Value = ViewBag.OrderID})
        </div>
        <br /><br />
        <div>
            <a style="text-align: right; float:right;" Class="btn button-add" @Html.ActionLink("Done", "Index", "Orders") |
        <a style = "text-align: right; float:left;" Class="btn button-add" @Html.ActionLink("Add a new order", "Create", "Orders")
        </div>

    </div>
End Using

<script>
    $(document).ready(function () {
        $("#firstInputField").focus();
    });
</script>

@Section Scripts
    @Scripts.Render("~/bundles/jqueryval")
End Section
