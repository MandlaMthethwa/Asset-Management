@ModelType ITAM.notification
@Code
    ViewData("Title") = "Details"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Details</h2>

<div>
    <h4>notification</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.message)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.message)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.requester_id)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.requester_id)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.notify_id }) |
    @Html.ActionLink("Back to List", "Index")
</p>
