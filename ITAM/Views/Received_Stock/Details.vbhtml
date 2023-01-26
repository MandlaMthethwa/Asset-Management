@ModelType ITAM.stock
@Code
    ViewData("Title") = "Details"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Details</h2>

<div>
    <h4>stock</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.quantity)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.quantity)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.order.manufacture)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.order.manufacture)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.status.status_name)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.status.status_name)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.stock_id }) |
    @Html.ActionLink("Back to List", "Index")
</p>
