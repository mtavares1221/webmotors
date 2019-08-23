$(document).ready(function () {


    clearSelects();
    function clearSelects() {
        var itens = '<option value = "0">Selecione</option>';
        $("#modelsId").html(itens);
        $("#versionsId").html(itens);
    }
   

    $("#makesId").change(function () {
        var url = "https://localhost:44317/Ad/GetModelsByMake";
        var makeSelected = $("#makesId").val();
        $.getJSON(url, { MakeID: makeSelected }, function (data) {
            var itens = '';
            $("#modelsId").empty();
            clearSelects();
            $.each(data, function (i, models) {
                itens += "<option value='" + models.value + "'>" + models.text + "</option>";
            });
            $("#modelsId").html(itens);
        });
    });


    $("#modelsId").change(function () {
        var url = "https://localhost:44317/Ad/GetVersions";
        var makeSelected = $("#makesId").val();
        var modelSelected = $("#modelsId").val();
        var ddlSource = "#modelsId";
        $.getJSON(url, { MakeID: makeSelected, ModelID: modelSelected }, function (data) {
            var itens = '';
            $("#versionsId").empty();

            $.each(data, function (i, models) {
                itens += "<option value='" + models.value + "'>" + models.text + "</option>";
            });
            $("#versionsId").html(itens);
        });
    });

    $("#saveAd").click(function () {
        var AdJs = {
            ID: 0,
            Make: $("#makesId option:selected").html(),
            Model: $("#modelsId option:selected").html(),
            Version: $("#versionsId option:selected").html(),
            Year: $("#Year").val(),
            Km: $("#Km").val(),
            Obs: $("#Obs").val()
        };
        var url = "https://localhost:44317/Ad/Register";
        $.ajax({
            url: url,
            type: "POST",
            data: {
                AdJs: AdJs
            },
            success: function (resposta) {
                window.location.href = "/Ad/Index";
            }
        });
    });



    $("#editAd").click(function () {
        var AdJs = {
            ID: $("#ID").val(),
            Make: $("#makesId option:selected").html(),
            Model: $("#modelsId option:selected").html(),
            Version: $("#versionsId option:selected").html(),
            Year: $("#Year").val(),
            Km: $("#Km").val(),
            Obs: $("#Obs").val()
        };
        var url = "https://localhost:44317/Ad/Update";
        $.ajax({
            url: url,
            type: "POST",
            data: {
                AdJs: AdJs
            },
            success: function (resposta) {
                window.location.href = "/Ad/Index";
            }
        });
    });

});