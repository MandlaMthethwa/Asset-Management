@ModelType ITAM.order
@Code
    ViewData("Title") = "Create"
End Code
<link rel="stylesheet" href="../Content/site.css" />

<h2>Add a new Order</h2>

@Using (Html.BeginForm())
    @Html.AntiForgeryToken()


    @<div class="form-horizontal">
        <h3></h3>
        <hr />


        @Html.ValidationSummary(True, "", New With {.class = "text-danger"})
        <table style="width:100%">
            <tr> <th>Order Number</th> <th>ETA</th> <th>Invoice number</th> <th>Action</th></tr>
            <tr>
                <td>
                    @Html.EditorFor(Function(model) model.order_number, New With {.htmlAttributes = New With {.class = "form-control", .placeholder = "Enter order nuber"}})
                    @Html.ValidationMessageFor(Function(model) model.order_number, "", New With {.class = "text-danger"})
                </td>
                <td>
                    @Html.EditorFor(Function(model) model.eta, New With {.htmlAttributes = New With {.class = "form-control", .placeholder = "Enter order nuber"}})
                    @Html.ValidationMessageFor(Function(model) model.eta, "", New With {.class = "text-danger"})
                </td>
                <td>
                    @Html.EditorFor(Function(model) model.invoice_number, New With {.htmlAttributes = New With {.class = "form-control", .placeholder = "Enter order nuber"}})
                    @Html.ValidationMessageFor(Function(model) model.invoice_number, "", New With {.class = "text-danger"})
                </td>
                <td>
                    <input type="submit" value="Add Order" Class="btn button-add" />
                </td>
            </tr>
        </table>
        <br /><br />

        <div>
            @Html.HiddenFor(Function(model) model.order_date, New With {.Value = DateTime.Now.ToString("yyyy-MM-dd")})
        </div>
        <div>
            <a style="text-align: right; float:right;" Class="btn button-add" @Html.ActionLink("Cancel", "Index")
        </div>
    </div>
End Using


@Section Scripts
    @Scripts.Render("~/bundles/jqueryval")
End Section
