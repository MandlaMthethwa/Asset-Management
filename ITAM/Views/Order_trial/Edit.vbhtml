@ModelType ITAM.trial


@Code
    ViewData("Title") = "Edit"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Edit</h2>

@Using (Html.BeginForm())
    @Html.AntiForgeryToken()

    @<div class="form-horizontal">
        <h4>trial</h4>
        <hr />
        @Html.ValidationSummary(True, "", New With {.class = "text-danger"})
        @Html.HiddenFor(Function(model) model.order_stock)

        <div class="form-group">
            @Html.LabelFor(Function(model) model.invoice_number, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-10">
                @Html.TextBoxFor(Function(model) model.invoice_number, New With {.readonly = "readonly"})

                @*@Html.EditorFor(Function(model) model.invoice_number, New With {.htmlAttributes = New With {.class = "form-control"}}, New With {.ReadOnly = "readonly"})*@
                @Html.ValidationMessageFor(Function(model) model.invoice_number, "", New With {.class = "text-danger"})
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.model1, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-10">
                @Html.TextBoxFor(Function(model) model.model1, New With {.readonly = "readonly"})
                @Html.ValidationMessageFor(Function(model) model.model1, "", New With {.class = "text-danger"})
            </div>
        </div>

        <div class="form-group">
            @*@Html.LabelFor(Function(model) model.quantity1, htmlAttributes:=New With {.class = "control-label col-md-2"})*@
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.quantity1, New With {.htmlAttributes = New With {.class = "form-control"}})
                @Html.ValidationMessageFor(Function(model) model.quantity1, "", New With {.class = "text-danger"})
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.model2, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-10">
                @Html.TextBoxFor(Function(model) model.model2, New With {.readonly = "readonly"})
                @Html.ValidationMessageFor(Function(model) model.model2, "", New With {.class = "text-danger"})
            </div>
        </div>
        <div class="form-group">
            @*@Html.LabelFor(Function(model) model.quantity2, htmlAttributes:=New With {.class = "control-label col-md-2"})*@
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.quantity2, New With {.htmlAttributes = New With {.class = "form-control"}})
                @Html.ValidationMessageFor(Function(model) model.quantity2, "", New With {.class = "text-danger"})
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.model3, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-10">
                @Html.TextBoxFor(Function(model) model.model3, New With {.readonly = "readonly"})
                @Html.ValidationMessageFor(Function(model) model.model3, "", New With {.class = "text-danger"})
            </div>
        </div>

        <div class="form-group">
            @*@Html.LabelFor(Function(model) model.quantity3, htmlAttributes:=New With {.class = "control-label col-md-2"})*@
            @Html.EditorFor(Function(model) model.quantity3, New With {.htmlAttributes = New With {.class = "form-control"}})
            @Html.ValidationMessageFor(Function(model) model.quantity3, "", New With {.class = "text-danger"})
        </div>



        @*<div class="form-group">
                @Html.LabelFor(Function(model) model.date, htmlAttributes:=New With {.class = "control-label col-md-2"})
                <div class="col-md-10">
                    @Html.EditorFor(Function(model) model.date, New With {.htmlAttributes = New With {.class = "form-control"}})
                    @Html.ValidationMessageFor(Function(model) model.date, "", New With {.class = "text-danger"})
                </div>
            </div>
            <div class="form-group">
                @Html.LabelFor(Function(model) model.description, htmlAttributes:=New With {.class = "control-label col-md-2"})
                <div class="col-md-10">
                    @Html.EditorFor(Function(model) model.description, New With {.htmlAttributes = New With {.class = "form-control"}})
                    @Html.ValidationMessageFor(Function(model) model.description, "", New With {.class = "text-danger"})
                </div>
            </div>
            <div class="form-group">
                @Html.LabelFor(Function(model) model.eta, htmlAttributes:=New With {.class = "control-label col-md-2"})
                <div class="col-md-10">
                    @Html.EditorFor(Function(model) model.eta, New With {.htmlAttributes = New With {.class = "form-control"}})
                    @Html.ValidationMessageFor(Function(model) model.eta, "", New With {.class = "text-danger"})
                </div>
            </div>*@
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
