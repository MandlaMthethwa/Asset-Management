@ModelType ITAM.asset_type
@Code
    ViewData("Title") = "Details"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Details</h2>

<div>
    <h4>asset_type</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.asset_type1)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.asset_type1)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.order_id)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.order_id)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.asset_id)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.asset_id)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.type_id }) |
    @Html.ActionLink("Back to List", "Index")
</p>
