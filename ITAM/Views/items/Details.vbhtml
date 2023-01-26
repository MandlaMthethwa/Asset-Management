@ModelType ITAM.item
@Code
    ViewData("Title") = "Details"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Details</h2>

<div>
    <h4>item</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.item_name)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.item_name)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.description)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.description)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.quantity)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.quantity)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.manufacture)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.manufacture)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.item_id }) |
    @Html.ActionLink("Back to List", "Index")
</p>
