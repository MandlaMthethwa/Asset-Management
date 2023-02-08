@ModelType ITAM.order
@Code
    ViewData("Title") = "Delete"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Delete</h2>

<h3 style="color: #cc0000">Are you sure you want to delete this order?</h3>
<div>

    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()
        @<hr />

        @<Table class="table">
            <tr>
                <th>
                    @Html.DisplayNameFor(Function(model) model.order_number)
                </th>
                <th>
                    @Html.DisplayNameFor(Function(model) model.order_date)
                </th>
                <th>
                    @Html.DisplayNameFor(Function(model) model.eta)
                </th>

                <th>
                    @Html.DisplayNameFor(Function(model) model.invoice_number)
                </th>
                <th>Action</th>
            </tr>

            <tr>
                <td>
                    @Html.DisplayFor(Function(model) model.order_number)
                </td>
                <td>
                    @Html.DisplayFor(Function(model) model.order_date)
                </td>
                <td>
                    @Html.DisplayFor(Function(model) model.eta)
                </td>
                <td>
                    @Html.DisplayFor(Function(model) model.invoice_number)
                </td>
                <td>
                    <input type="submit" value="Delete" class="btn button-delete" />
                    <a Class="btn button-update" @Html.ActionLink("Cancel", "Index")

                </td>
            </tr>

        </Table>

    End Using
</div>
