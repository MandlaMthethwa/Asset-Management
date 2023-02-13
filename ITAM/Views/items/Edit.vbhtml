@ModelType ITAM.item
@Code
    ViewData("Title") = "Edit"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code
<br />
<br />
<br />
<h2>Update Item details</h2>

@Using (Html.BeginForm())
    @Html.AntiForgeryToken()
    @<div class="form-horizontal">

        <hr />
        @Html.ValidationSummary(True, "", New With {.class = "text-danger"})
        @Html.HiddenFor(Function(model) model.item_id)

        <table>
            <tr>
                <th>Item Name</th>
                <th>Description</th>
                <th>Quantity</th>
                <th>Manufacture</th>
                <th>Action</th>
            </tr>
            <tr>
                <td>
                    @Html.EditorFor(Function(model) model.item_name, New With {.htmlAttributes = New With {.class = "form-control"}})
                    @Html.ValidationMessageFor(Function(model) model.item_name, "", New With {.class = "text-danger"})
                </td>
                <td>
                    @Html.EditorFor(Function(model) model.description, New With {.htmlAttributes = New With {.class = "form-control"}})
                    @Html.ValidationMessageFor(Function(model) model.description, "", New With {.class = "text-danger"})
                </td>
                <td>
                    @Html.EditorFor(Function(model) model.quantity, New With {.htmlAttributes = New With {.class = "form-control"}})
                    @Html.ValidationMessageFor(Function(model) model.quantity, "", New With {.class = "text-danger"})
                </td>
                <td>
                    @Html.EditorFor(Function(model) model.manufacture, New With {.htmlAttributes = New With {.class = "form-control"}})
                    @Html.ValidationMessageFor(Function(model) model.manufacture, "", New With {.class = "text-danger"})
                </td>
                <td>
                    <input type="submit" value="Update" class="btn button-update" />

                </td>
            </tr>
        </table>
        <div style="display:none">
            @Html.EditorFor(Function(model) model.order_id, New With {.Value = ViewBag.OrderID})

        </div>

    </div>
End Using
@*<a Class="btn button-add" href="@Url.Action("create", New With {.OrderID = item.order_id})">Cancel</a>*@

@Section Scripts
    @Scripts.Render("~/bundles/jqueryval")
End Section
