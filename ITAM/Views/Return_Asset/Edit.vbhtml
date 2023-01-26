@ModelType ITAM.return_asset
@Code
    ViewData("Title") = "Edit"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Edit</h2>

@Using (Html.BeginForm())
    @Html.AntiForgeryToken()
    
    @<div class="form-horizontal">
        <h4>return_asset</h4>
        <hr />
        @Html.ValidationSummary(True, "", New With { .class = "text-danger" })
        @Html.HiddenFor(Function(model) model.return_id)

        @Html.HiddenFor(Function(model) model.serial_number)

        @Html.HiddenFor(Function(model) model.return_date)

        @Html.HiddenFor(Function(model) model.manufacture)

        @Html.HiddenFor(Function(model) model.warranty_date)

        <div class="form-group">
            @Html.LabelFor(Function(model) model.report, htmlAttributes:= New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.report, New With { .htmlAttributes = New With { .class = "form-control" } })
                @Html.ValidationMessageFor(Function(model) model.report, "", New With { .class = "text-danger" })
            </div>
        </div>

        @Html.HiddenFor(Function(model) model.asset_id)

        @Html.HiddenFor(Function(model) model.asset_type_id)

        @Html.HiddenFor(Function(model) model.status_id)

        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <input type="submit" value="Save" class="btn btn-default" />
            </div>
        </div>
    </div>
End Using

<div>
    @Html.ActionLink("Back to List", "Index")
</div>

@Section Scripts 
    @Scripts.Render("~/bundles/jqueryval")
End Section
