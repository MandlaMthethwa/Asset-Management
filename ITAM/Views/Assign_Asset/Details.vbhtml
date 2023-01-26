@ModelType ITAM.assign
@Code
    ViewData("Title") = "Details"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Details</h2>

<div>
    <h4>assign</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.assign_name)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.assign_name)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.department)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.department)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.icf)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.icf)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.asset.model)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.asset.model)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.status.status_name)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.status.status_name)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.technician.technician_name)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.technician.technician_name)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.assign_id }) |
    @Html.ActionLink("Back to List", "Index")
</p>
