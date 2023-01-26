@ModelType ITAM.asset
@Code
    ViewData("Title") = "Details"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Details</h2>

<div>
    <h4>asset</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.model)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.model)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.po_number)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.po_number)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.manufacture)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.manufacture)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.serial_number)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.serial_number)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.description)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.description)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.warranty_date)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.warranty_date)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.asset_type_id)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.asset_type_id)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.asset1.model)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.asset1.model)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.asset2.model)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.asset2.model)
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
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.asset_id }) |
    @Html.ActionLink("Back to List", "Index")
</p>
