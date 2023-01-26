@ModelType ITAM.trial
@Code
    ViewData("Title") = "Details"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Details</h2>

<div>
    <h4>trial</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.model1)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.model1)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.model2)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.model2)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.model3)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.model3)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.quantity1)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.quantity1)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.quantity2)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.quantity2)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.quantity3)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.quantity3)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.invoice_number)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.invoice_number)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.order_stock }) |
    @Html.ActionLink("Back to List", "Index")
</p>
