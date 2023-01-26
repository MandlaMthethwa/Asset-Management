@ModelType ITAM.return_asset
@Code
    ViewData("Title") = "Delete"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
<div>
    <h4>return_asset</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.report)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.report)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.asset.model)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.asset.model)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.asset_type.asset_type1)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.asset_type.asset_type1)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.status.status_name)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.status.status_name)
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
