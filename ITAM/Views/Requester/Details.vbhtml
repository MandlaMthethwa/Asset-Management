@ModelType ITAM.requester
@Code
    ViewData("Title") = "Details"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Details</h2>

<div>
    <h4>requester</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.requester_name)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.requester_name)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.requester_email_address)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.requester_email_address)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.requester_contact_number)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.requester_contact_number)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.notification.message)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.notification.message)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.order.manufacture)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.order.manufacture)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.requester_id }) |
    @Html.ActionLink("Back to List", "Index")
</p>
