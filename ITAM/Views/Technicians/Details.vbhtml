@ModelType ITAM.technician
@Code
    ViewData("Title") = "Details"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Details</h2>

<div>
    <h4>technician</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.technician_name)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.technician_name)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.technician_id }) |
    @Html.ActionLink("Back to List", "Index")
</p>
