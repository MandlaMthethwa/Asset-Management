@ModelType ITAM.requester
@Code
    ViewData("Title") = "Delete"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
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
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-default" /> |
            @Html.ActionLink("Back to List", "Index")
        </div>
    End Using
</div>
