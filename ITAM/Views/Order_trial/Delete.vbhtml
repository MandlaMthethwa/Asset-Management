@ModelType ITAM.trial
@Code
    ViewData("Title") = "Delete"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
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
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-default" /> |
            @Html.ActionLink("Back to List", "Index")
        </div>
    End Using
</div>
