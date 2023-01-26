@ModelType ITAM.location
@Code
    ViewData("Title") = "Delete"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
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
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-default" /> |
            @Html.ActionLink("Back to List", "Index")
        </div>
    End Using
</div>
