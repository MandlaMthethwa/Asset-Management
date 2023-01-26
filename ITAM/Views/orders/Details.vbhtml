@ModelType ITAM.order
@Code
    ViewData("Title") = "Details"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Details</h2>

<div>
    <h4>order</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.model)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.model)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.order_date)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.order_date)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.eta)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.eta)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.invoice_number)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.invoice_number)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.item.item_name)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.item.item_name)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.order_id }) |
    @Html.ActionLink("Back to List", "Index")
</p>
