@ModelType ITAM.order
@Code
    ViewData("Title") = "Delete"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
<div>
    <h4>order</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.order_number)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.order_number)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.order_date)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.order_date)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.eta)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.eta)
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
