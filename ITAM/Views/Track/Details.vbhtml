@ModelType ITAM.location
@Code
    ViewData("Title") = "Details"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Details</h2>

<div>
    <h4>location</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.serial_number)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.serial_number)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.location1)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.location1)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.asset.model)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.asset.model)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.location_id }) |
    @Html.ActionLink("Back to List", "Index")
</p>
