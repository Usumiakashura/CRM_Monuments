﻿var CustomersCount = 1;
var DeceasedsCount = 0;
var nte, tne, ee;

var typesText = ["Углубленный", "Литье", "Caggiatti", "На табличке", "На медальоне", "Станочный", "Фрейзерный"];
var typesPortrait = ["Ручной", "Станочный"];
var materialsMedallion = ["Керамогранит", "Керамика (фарфор)", "Триплекс", "Однослойное стекло", "Металлокерамика", "Табличка из нерж.стали"];
var shapesMedallion = ["Овальная", "Прямоугольная", "Арка"];
var colorsMedallion = ["Цветной", "Черно-белый"];

//AddDeceased();
//AddDeceased();
if ($("#Contract_Pickup").is(":checked")) {
    AddDisabledPickup(true)
}
//if ($("check-epitaph").is(":checked")) {
//    AddDisabledEpitaph(false);
//}

$(document).ready(function () {

    // --- Add/Remove -------------------------------------------------
    $("#AddCustomer").click(AddCustomer);
    $("#AddDeceased").click(AddDeceased);
    //$(".add-portrait").click(AddPortrait);
    //$(".add-medallion").click(AddMedallion);

    $(".remove-customer").click(RemoveCustomer);
    $(".remove-deceased").click(RemoveDeceased);
    //$(".remove-portrait").click(RemovePortrait);
    //$(".remove-medallion").click(RemoveMedallion);
    
    // ----------------------------------------------------------------
    // --- Код для чекбокса "Самовывоз" -------------------------------
    $("#Contract_Pickup").click(function () {
        if ($(this).is(":checked")) {
            AddDisabledPickup(true);
        }
        else {
            AddDisabledPickup(false);
        }
    });
    
    // ----------------------------------------------------------------
});
// --- При загрузке изображения добавляет его название в строку ---
$(document).on("input", ".custom-file-input", function () {
    var names = $(this).prop('files');
    var str = "";
    for (var i = 0; i < names.length; i++) {
        str += names[i].name;
        if (i !== (names.length - 1)) {
            str += ", ";
        }
    }
    $(this).siblings(".custom-file-label").addClass("selected").html(str);
});
// ----------------------------------------------------------------
// --- Код для чекбоксов внутри динамических блоков с эпитафией ---
$(document).on("click", ".check-epitaph", function () {
    var CheckEpitaphId = $(this).attr("id");
    var CheckEpitaphNum = parseInt(CheckEpitaphId.match(/\d+/));
    CalculateIdEpitaphBlocks(CheckEpitaphNum);

    var NotesTextEpitaph = document.querySelector(nte);
    var TypeNameEpitaph = document.querySelector(tne);
    var EngraverEpitaph = document.querySelector(ee);

    if ($(this).is(":checked")) {
        //AddDisabledEpitaph(false);
        $(NotesTextEpitaph).prop("disabled", false);
        $(TypeNameEpitaph).prop("disabled", false);
        $(EngraverEpitaph).prop("disabled", false);
    }
    else {
        //AddDisabledEpitaph(true);
        $(NotesTextEpitaph).prop("disabled", true);
        $(TypeNameEpitaph).prop("disabled", true);
        $(EngraverEpitaph).prop("disabled", true);
    }
});
function CalculateIdEpitaphBlocks(num) {
    nte = ('.notes-text-epitaph-' + num).toString();
    tne = ('.type-name-epitaph-' + num).toString();
    ee = ('.engraver-epitaph-' + num).toString();
}
// ----------------------------------------------------------------
// --- Код для чекбоксов внутри динамических блоков с медальоном ---
$(document).on("click", ".check-frame", function () {
    var keyF = ($(this).attr("id")).match(/D\d+M\d+/)[0];
    var FrameBlock = document.getElementsByClassName(keyF)[0];

    var TypeFrame = FrameBlock.querySelector("#Medallions_" + keyF + "__TypeFrame");
    var SizeFrame = FrameBlock.querySelector("#Medallions_" + keyF + "__SizeFrame");
    var ShapeFrame = FrameBlock.querySelector("#Medallions_" + keyF + "__ShapeFrame");
    var ColorFrame = FrameBlock.querySelector("#Medallions_" + keyF + "__ColorFrame");
    var NoteFrame = FrameBlock.querySelector("#Medallions_" + keyF + "__NoteFrame");
    var GluingIntoNiche = FrameBlock.querySelector("#Medallions_" + keyF + "__GluingIntoNiche");

    if ($(this).is(":checked")) {
        $(TypeFrame).prop("disabled", false);
        $(SizeFrame).prop("disabled", false);
        $(ShapeFrame).prop("disabled", false);
        $(ColorFrame).prop("disabled", false);
        $(NoteFrame).prop("disabled", false);
        $(GluingIntoNiche).prop("disabled", true);
    }
    else {
        $(TypeFrame).prop("disabled", true);
        $(SizeFrame).prop("disabled", true);
        $(ShapeFrame).prop("disabled", true);
        $(ColorFrame).prop("disabled", true);
        $(NoteFrame).prop("disabled", true);
        $(GluingIntoNiche).prop("disabled", false);
    }
});
// -----------------------------------------------------------------

function AddDisabledPickup(trfl) {
    $("#Contract_BurialAddress").prop("disabled", trfl);
    $("#Contract_Sector").prop("disabled", trfl);
    $("#Contract_Row").prop("disabled", trfl);
    $("#Contract_BurialPlace").prop("disabled", trfl);
    $("#Contract_Grave").prop("disabled", trfl);
    $("#Contract_DistanceFromMKAD").prop("disabled", trfl);
    $("#Contract_NumberOfTrips").prop("disabled", trfl);
}
//function AddDisabledEpitaph(trfl) {
//    $(NotesTextEpitaph).prop("disabled", trfl);
//    $(TypeNameEpitaph).prop("disabled", trfl);
//    $(EngraverEpitaph).prop("disabled", trfl);
//}

function AddCustomer() {
    //добавляем поля

    var CustomerContainer = $("<div/>").attr("class", "customer-container")
        .attr("id", "CustomerContainer" + CustomersCount).appendTo("#Customers");

    var Wrapper = $("<div/>").attr("class", "wrapper w5 p96 float-md-left").appendTo(CustomerContainer);

    $("<div/>").attr("class", "box1").text("ФИО заказчика: ").appendTo(Wrapper);
    $("<div/>").text("Телефон: ").appendTo(Wrapper);
    var DivForMess = $("<div/>").appendTo(Wrapper);
    $("<img/>").attr("class", "icon").attr("src", "/Images/viber.png").attr("title", "viber").appendTo(DivForMess);
    $("<img/>").attr("class", "icon").attr("src", "/Images/telegram.png").attr("title", "telegram").appendTo(DivForMess);
    $("<img/>").attr("class", "icon").attr("src", "/Images/whatsapp.png").attr("title", "whatsapp").appendTo(DivForMess);
    $("<div/>").text("Email: ").appendTo(Wrapper);
    $("<div/>").text("Другая связь: ").appendTo(Wrapper);
    //$("<div/>").attr("style", "width: 50px").appendTo(Wrapper);

    var DivFIO = $("<div/>").attr("class", "box1").appendTo(Wrapper);
    $("<input/>").attr("type", "text").attr("name", "Contract.Customers[" + CustomersCount + "].LastName")
        .attr("class", "form-control").attr("placeholder", "Фамилия")
        .attr("id", "Contract_Customers_" + CustomersCount + "__LastName").appendTo(DivFIO);
    //CustomerContainer.text("  Имя : ");
    $("<input/>").attr("type", "text").attr("name", "Contract.Customers[" + CustomersCount + "].FirstName")
        .attr("class", "form-control").attr("placeholder", "Имя")
        .attr("id", "Contract_Customers_" + CustomersCount + "__FirstName").appendTo(DivFIO);
    $("<input/>").attr("type", "text").attr("name", "Contract.Customers[" + CustomersCount + "].MiddleName")
        .attr("class", "form-control").attr("placeholder", "Отчество")
        .attr("id", "Contract_Customers_" + CustomersCount + "__MiddleName").appendTo(DivFIO);

    var DivPhone = $("<div/>").appendTo(Wrapper);
    $("<input/>").attr("type", "text").attr("name", "Contract.Customers[" + CustomersCount + "].Number")
        .attr("class", "form-control")
        .attr("id", "Contract_Customers_" + CustomersCount + "__Number").appendTo(DivPhone);

    var DivCheckMess = $("<div/>").appendTo(Wrapper);
    $("<input/>").attr("type", "checkbox")
        .attr("data-val", "true")
        .attr("data-val-required", "The Viber field is required.")
        .attr("id", "Contract_Customers_" + CustomersCount + "__Viber")
        .attr("name", "Contract.Customers[" + CustomersCount + "].Viber")
        .attr("value", "true")
        .attr("class", "check-box")
        .appendTo(DivCheckMess);
    $("<input/>").attr("type", "checkbox")
        .attr("data-val", "true")
        .attr("data-val-required", "The Telegram field is required.")
        .attr("id", "Contract_Customers_" + CustomersCount + "__Telegram")
        .attr("name", "Contract.Customers[" + CustomersCount + "].Telegram")
        .attr("value", "true")
        .attr("class", "check-box")
        .appendTo(DivCheckMess);
    $("<input/>").attr("type", "checkbox")
        .attr("data-val", "true")
        .attr("data-val-required", "The WhatsApp field is required.")
        .attr("id", "Contract_Customers_" + CustomersCount + "__WhatsApp")
        .attr("name", "Contract.Customers[" + CustomersCount + "].WhatsApp")
        .attr("value", "true")
        .attr("class", "check-box")
        .appendTo(DivCheckMess);

    $("<input/>").attr("type", "text").attr("name", "Contract.Customers[" + CustomersCount + "].Email")
        .attr("class", "form-control")
        .attr("id", "Contract_Customers_" + CustomersCount + "__Email").appendTo(Wrapper);

    $("<input/>").attr("type", "text").attr("name", "Contract.Customers[" + CustomersCount + "].Note")
        .attr("class", "form-control")
        .attr("id", "Contract_Customers_" + CustomersCount + "__Note").appendTo(Wrapper);


    //OwnershipContainer.text("  Price : ");

    var RemoveButton = $("<input/>").attr("type", "button").attr("class", "remove-customer r-btn float-md-left")
        .attr("value", "x").appendTo(CustomerContainer);
    //на нажатие этого элемента добавляем обработчик - функцию удаления
    RemoveButton.click(RemoveCustomer);
    CustomersCount++;
}
function RemoveCustomer() {
    var RecalculateStartNum = parseInt($(this).parent().attr("id").substring("CustomerContainer".length));
    //удаляем этот div
    $(this).parent().remove();
    for (var i = RecalculateStartNum + 1; i < CustomersCount; i++) {
        //функция пересчета аттрибутов name и id
        RecalculateNamesAndIdsCustomers(i);
    }
    CustomersCount--;
}
function RecalculateNamesAndIdsCustomers(number) {
    var prevNumber = number - 1;
    $("#CustomerContainer" + number).attr("id", "CustomerContainer" + prevNumber);
    //скобки "[" и "]" которые присутствуют в id DOM-объекта в jquery селекторе необходим экранировать двойным обратным слэшем \\
    $("#Contract_Customers_" + number + "__LastName").attr("id", "Contract_Customers_" + prevNumber + "__LastName")
        .attr("name", "Contract.Customers[" + prevNumber + "].LastName");
    $("#Contract_Customers_" + number + "__FirstName").attr("id", "Contract_Customers_" + prevNumber + "__FirstName")
        .attr("name", "Contract.Customers[" + prevNumber + "].FirstName");
    $("#Contract_Customers_" + number + "__MiddleName").attr("id", "Contract_Customers_" + prevNumber + "__MiddleName")
        .attr("name", "Contract.Customers[" + prevNumber + "].MiddleName");

    $("#Contract_Customers_" + number + "__Email").attr("id", "Contract_Customers_" + prevNumber + "__Email")
        .attr("name", "Contract.Customers[" + prevNumber + "].Email");
    $("#Contract_Customers_" + number + "__Number").attr("id", "Contract_Customers_" + prevNumber + "__Number")
        .attr("name", "Contract.Customers[" + prevNumber + "].Number");
    $("#Contract_Customers_" + number + "__Viber").attr("id", "Contract_Customers_" + prevNumber + "__Viber")
        .attr("name", "Contract.Customers[" + prevNumber + "].Viber");
    $("#Contract_Customers_" + number + "__Telegram").attr("id", "Contract_Customers_" + prevNumber + "__Telegram")
        .attr("name", "Contract.Customers[" + prevNumber + "].Telegram");
    $("#Contract_Customers_" + number + "__WhatsApp").attr("id", "Contract_Customers_" + prevNumber + "__WhatsApp")
        .attr("name", "Contract.Customers[" + prevNumber + "].WhatsApp");
    $("#Contract_Customers_" + number + "__Note").attr("id", "Contract_Customers_" + prevNumber + "__Note")
        .attr("name", "Contract.Customers[" + prevNumber + "].Note");
    //$("#Ownerships\\[" + number + "\\]_Price").attr("id", "Ownerships[" + prevNumber + "]_Price")
    //    .attr("name", "Ownerships[" + prevNumber + "].Price");
}

function AddDeceased() {
    var DeceasedContainer = $("<div/>").attr("class", "deceased-container")
        .attr("id", "DeceasedContainer" + DeceasedsCount).appendTo("#Deceaseds");

    var WrapperD = $("<div/>").attr("class", "wrapper w5 p96 float-md-left border  b-grey").appendTo(DeceasedContainer);

    $("<div/>").text("ФИО: ").appendTo(WrapperD);
    $("<div/>").appendTo(WrapperD);
    $("<div/>").appendTo(WrapperD);
    $("<div/>").text("Дата рождения: ").appendTo(WrapperD);
    $("<div/>").text("Дата смерти: ").appendTo(WrapperD);

    $("<input/>").attr("type", "text").attr("name", "Contract.Deceaseds[" + DeceasedsCount + "].LastName")
        .attr("id", "Contract_Deceaseds_" + DeceasedsCount + "__LastName")
        .attr("class", "form-control full").attr("placeholder", "Фамилия")
        .appendTo(WrapperD);
    $("<input/>").attr("type", "text").attr("name", "Contract.Deceaseds[" + DeceasedsCount + "].FirstName")
        .attr("id", "Contract_Deceaseds_" + DeceasedsCount + "__FirstName")
        .attr("class", "form-control full").attr("placeholder", "Имя")
        .appendTo(WrapperD);
    $("<input/>").attr("type", "text").attr("name", "Contract.Deceaseds[" + DeceasedsCount + "].MiddleName")
        .attr("id", "Contract_Deceaseds_" + DeceasedsCount + "__MiddleName")
        .attr("class", "form-control full").attr("placeholder", "Отчество")
        .appendTo(WrapperD);
    $("<input/>").attr("type", "date").attr("name", "Contract.Deceaseds[" + DeceasedsCount + "].DateBirthday")
        .attr("id", "Contract_Deceaseds_" + DeceasedsCount + "__DateBirthday")
        .attr("class", "form-control full")
        .appendTo(WrapperD);
    $("<input/>").attr("type", "date").attr("name", "Contract.Deceaseds[" + DeceasedsCount + "].DateRip")
        .attr("id", "Contract_Deceaseds_" + DeceasedsCount + "__DateRip")
        .attr("class", "form-control full")
        .appendTo(WrapperD);

    var SelectDeceasedsTypeText = $("<select/>").attr("class", "form-control full")
        .attr("id", "Contract_Deceaseds_" + DeceasedsCount + "__TypeNameText")
        .attr("name", "Contract.Deceaseds[" + DeceasedsCount + "].TypeNameText")
        .appendTo(WrapperD);
    $("<option/>").attr("value", "0").text("Тип текста ФИО...").appendTo(SelectDeceasedsTypeText);
    for (i = 0; i < typesText.length; i++) {
        $("<option/>").attr("value", typesText[i])
            .text(typesText[i])
            .appendTo(SelectDeceasedsTypeText);
    }

    $("<input/>").attr("type", "text").attr("name", "Contract.Deceaseds[" + DeceasedsCount + "].EngraverName")
        .attr("id", "Contract_Deceaseds_" + DeceasedsCount + "__EngraverName")
        .attr("class", "form-control full").attr("placeholder", "Гравер (ФИО)...")
        .appendTo(WrapperD);
    $("<input/>").attr("type", "text").attr("name", "Contract.Deceaseds[" + DeceasedsCount + "].NotesTextName")
        .attr("id", "Contract_Deceaseds_" + DeceasedsCount + "__NotesTextName")
        .attr("class", "form-control typetext-note full").attr("placeholder", "Примечание (ФИО)...")
        .appendTo(WrapperD);

    //----- Эпитафия (начало) ------------------------

    var DivEpitaph = $("<div/>").appendTo(WrapperD);
    $("<input/>").attr("type", "checkbox")
        .attr("data-val", "true")
        .attr("data-val-required", "The Epitaph field is required.")
        .attr("id", "Contract_Deceaseds_" + DeceasedsCount + "__Epitaph")
        .attr("name", "Contract.Deceaseds[" + DeceasedsCount + "].Epitaph")
        .attr("value", "true")
        .attr("class", "check-box check-epitaph")
        .appendTo(DivEpitaph);
    $("<label/>").text(" Эпитафия: ").appendTo(DivEpitaph);

    $("<textarea/>").attr("id", "Contract_Deceaseds_" + DeceasedsCount + "__NotesTextEpitaph")
        .attr("name", "Contract.Deceaseds[" + DeceasedsCount + "].NotesTextEpitaph")
        .attr("class", "form-control text-note full notes-text-epitaph-" + DeceasedsCount)
        .attr("placeholder", "Текст эпитафии...")
        .prop("disabled", true)
        .appendTo(WrapperD);

    $("<div/>").appendTo(WrapperD);

    var SelectEpitaphTypeText = $("<select/>").attr("class", "form-control full type-name-epitaph-" + DeceasedsCount)
        .attr("id", "Contract_Deceaseds_" + DeceasedsCount + "__TypeNameEpitaph")
        .attr("name", "Contract.Deceaseds[" + DeceasedsCount + "].TypeNameEpitaph")
        .prop("disabled", true)
        .appendTo(WrapperD);
    $("<option/>").attr("value", "0").text("Тип текста эпитафии...").appendTo(SelectEpitaphTypeText);
    for (i = 0; i < typesText.length; i++) {
        $("<option/>").attr("value", typesText[i])
            .text(typesText[i])
            .appendTo(SelectEpitaphTypeText);
    }

    $("<input/>").attr("type", "text")
        .attr("id", "Contract_Deceaseds_" + DeceasedsCount + "__EngraverEpitaph")
        .attr("name", "Contract.Deceaseds[" + DeceasedsCount + "].EngraverEpitaph")
        .attr("class", "form-control full engraver-epitaph-" + DeceasedsCount)
        .attr("placeholder", "Гравер (эпитафия)...")
        .prop("disabled", true)
        .appendTo(WrapperD);
    //----- Эпитафия (конец) ------------------------


    /////// Фотографии (начало) /////////////////////
    var DeceasedPhoto = $("<div/>").attr("class", "full-wrap").appendTo(WrapperD);
    //----- Портреты (начало) -----------------------
    $("<div/>").attr("class", "Portraits" + DeceasedsCount).attr("id", "Portraits" + DeceasedsCount).appendTo(DeceasedPhoto);
    //----- Портреты (конец) ------------------------
    var AddPortraitButton = $("<input/>").attr("type", "button").attr("class", "add-btn my-btn add-portrait ap" + DeceasedsCount)
        .attr("value", "Добавить портрет").appendTo(DeceasedPhoto);
    //----- Медальоны (начало) ----------------------
    $("<div/>").attr("class", "Medallions" + DeceasedsCount).attr("id", "Medallions" + DeceasedsCount).appendTo(DeceasedPhoto);
    //----- Медальоны (конец) -----------------------
    //var AddMedallionButton = 
    var AddMedallionButton = $("<input/>").attr("type", "button").attr("class", "add-btn my-btn add-medallion am" + DeceasedsCount)
        .attr("value", "Добавить медальон").appendTo(DeceasedPhoto);
    /////// Фотографии (конец) //////////////////////


    var RemoveButton = $("<input/>").attr("type", "button").attr("class", "remove-deceased r-btn float-md-left")
        .attr("value", "x").appendTo(DeceasedContainer);

    //навешиваем обработчики
    RemoveButton.click(RemoveDeceased);
    AddPortraitButton.click(AddPortrait);
    AddMedallionButton.click(AddMedallion);
    DeceasedsCount++;

}
function RemoveDeceased() {
    var RecalculateStartNum = parseInt($(this).parent().attr("id").substring("DeceasedContainer".length));
    //удаляем этот div
    $(this).parent().remove();
    for (var i = RecalculateStartNum + 1; i < DeceasedsCount; i++) {
        //функция пересчета аттрибутов name и id
        RecalculateNamesAndIdsDeceaseds(i);
    }
    DeceasedsCount--;
}
function RecalculateNamesAndIdsDeceaseds(number) {
    var prevNumber = number - 1;
    $("#DeceasedContainer" + number).attr("id", "DeceasedContainer" + prevNumber);

    $("#Contract_Deceaseds_" + number + "__LastName").attr("id", "Contract_Deceaseds_" + prevNumber + "__LastName")
        .attr("name", "Contract.Deceaseds[" + prevNumber + "].LastName");
    $("#Contract_Deceaseds_" + number + "__FirstName").attr("id", "Contract_Deceaseds_" + prevNumber + "__FirstName")
        .attr("name", "Contract.Deceaseds[" + prevNumber + "].FirstName");
    $("#Contract_Deceaseds_" + number + "__MiddleName").attr("id", "Contract_Deceaseds_" + prevNumber + "__MiddleName")
        .attr("name", "Contract.Deceaseds[" + prevNumber + "].MiddleName");
    $("#Contract_Deceaseds_" + number + "__DateBirthday").attr("id", "Contract_Deceaseds_" + prevNumber + "__DateBirthday")
        .attr("name", "Contract.Deceaseds[" + prevNumber + "].DateBirthday");
    $("#Contract_Deceaseds_" + number + "__DateRip").attr("id", "Contract_Deceaseds_" + prevNumber + "__DateRip")
        .attr("name", "Contract.Deceaseds[" + prevNumber + "].DateRip");
    $("#Contract_Deceaseds_" + number + "__TypeNameText").attr("id", "Contract_Deceaseds_" + prevNumber + "__TypeNameText")
        .attr("name", "Contract.Deceaseds[" + prevNumber + "].TypeNameText");
    $("#Contract_Deceaseds_" + number + "__EngraverName").attr("id", "Contract_Deceaseds_" + prevNumber + "__EngraverName")
        .attr("name", "Contract.Deceaseds[" + prevNumber + "].EngraverName");
    $("#Contract_Deceaseds_" + number + "__NotesTextName").attr("id", "Contract_Deceaseds_" + prevNumber + "__NotesTextName")
        .attr("name", "Contract.Deceaseds[" + prevNumber + "].NotesTextName");

    $("#Contract_Deceaseds_" + number + "__Epitaph").attr("id", "Contract_Deceaseds_" + prevNumber + "__Epitaph")
        .attr("name", "Contract.Deceaseds[" + prevNumber + "].Epitaph");
    $("#Contract_Deceaseds_" + number + "__NotesTextEpitaph").attr("id", "Contract_Deceaseds_" + prevNumber + "__NotesTextEpitaph")
        .attr("name", "Contract.Deceaseds[" + prevNumber + "].NotesTextEpitaph")
        .attr("class", "form-control text-note full notes-text-epitaph-" + prevNumber);
    $("#Contract_Deceaseds_" + number + "__TypeNameEpitaph").attr("id", "Contract_Deceaseds_" + prevNumber + "__TypeNameEpitaph")
        .attr("name", "Contract.Deceaseds[" + prevNumber + "].TypeNameEpitaph")
        .attr("class", "form-control full type-name-epitaph-" + prevNumber);
    $("#Contract_Deceaseds_" + number + "__EngraverEpitaph").attr("id", "Contract_Deceaseds_" + prevNumber + "__EngraverEpitaph")
        .attr("name", "Contract.Deceaseds[" + prevNumber + "].EngraverEpitaph")
        .attr("class", "form-control full engraver-epitaph-" + prevNumber);


    $("#Portraits" + number).attr("id", "Portraits" + prevNumber).attr("class", "Portraits" + prevNumber);
    $(".ap" + number).attr("class", "add-btn my-btn add-portrait ap" + prevNumber);
    $("#Medallions" + number).attr("id", "Medallions" + prevNumber).attr("class", "Medallions" + prevNumber);
    $(".am" + number).attr("class", "add-btn my-btn add-medallion am" + prevNumber);

    //----- Пересчет для портретов ------
    
    var PortraitsContainers = $("#Portraits" + prevNumber).children();
    for (i = 0; i < PortraitsContainers.length; i++) {
        RecalculateNamesAndIdsPortraits(true, number, i);
    }

    //----- Пересчет для медальонов -----

    var MedallionsContainers = $("#Medallions" + prevNumber).children();
    for (e = 0; e < MedallionsContainers.length; e++) {
        RecalculateNamesAndIdsMedallions(true, number, e);
    }

}

function AddPortrait() {
    var thisId = parseInt($(this).attr("class").match(/\d+/));
    var PortraitBlocks = $(this).siblings();


    var PortraitCount = PortraitBlocks[0].getElementsByClassName("portrait-container").length;
    
    var keyP = PortraitIdCreator(thisId, PortraitCount);

    var PortraitContainer = $("<div/>").attr("id", "PortraitContainer" + PortraitCount)
        .attr("class", "portrait-container")
        .appendTo(PortraitBlocks[0]);
    var PortraitBox = $("<div/>").attr("class", " border p96 float-md-left ")
        .appendTo(PortraitContainer);
    $("<label/>").attr("class", "font-weight-bold").text("Портрет").appendTo(PortraitBox);
    var WrapperP = $("<div/>").attr("class", "wrapper w3").appendTo(PortraitBox);

    var ImgBlock = $("<div/>").attr("class", "custom-file img-block").appendTo(WrapperP);
    $("<input/>").attr("type", "file")
        .attr("accept", "image/*,image/jpeg")
        .attr("multiple", "true")
        .attr("name", "Portraits[" + keyP + "].PhotoImage")
        .attr("id", "Portraits_" + keyP + "__PhotoImage")
        .attr("class", "custom-file-input form-control full").appendTo(ImgBlock);
    $("<label/>").attr("class", "custom-file-label form-control")
        .attr("for", "Portraits_" + keyP + "__PhotoImage").appendTo(ImgBlock);

    var SelectPortraitType = $("<select/>").attr("class", "form-control min-width-select-for-photo")
        .attr("name", "Portraits[" + keyP + "].TypePortrait")
        .attr("id", "Portraits_" + keyP + "__TypePortrait")
        .appendTo(WrapperP);
    $("<option/>").attr("value", "0").text("Тип портрета...").appendTo(SelectPortraitType);
    for (i = 0; i < typesPortrait.length; i++) {
        $("<option/>").attr("value", typesPortrait[i])
            .text(typesPortrait[i])
            .appendTo(SelectPortraitType);
    }

    $("<input/>").attr("class", "form-control")
        .attr("name", "Portraits[" + keyP + "].Artist")
        .attr("id", "Portraits_" + keyP + "__Artist")
        .attr("placeholder", "Художник...")
        .appendTo(WrapperP);

    var NoteWrap = $("<div/>").attr("class", "full-wrap3 ").appendTo(WrapperP);
    $("<textarea/>").attr("class", "form-control full")
        .attr("name", "Portraits[" + keyP + "].Note")
        .attr("id", "Portraits_" + keyP + "__Note")
        .attr("placeholder", "Примечание...")
        .appendTo(NoteWrap);

    var RemoveButton = $("<input/>").attr("type", "button").attr("class", "remove-portrait rp-btn float-md-left")
        .attr("value", "x").appendTo(PortraitContainer);

    //навешиваем обработчики
    RemoveButton.click(RemovePortrait);
    //PortraitCount++;
}
function RemovePortrait() {
    var PortraitContainer = $(this).parent();
    var DeceasedNum = parseInt(PortraitContainer.parent().attr("id").match(/\d+/));
    var PortraitSturtNum = parseInt(PortraitContainer.attr("id").match(/\d+/));
    
    var PortraitCount = PortraitContainer.parent()[0].getElementsByClassName("portrait-container").length;

    $(this).parent().remove();
    for (var i = PortraitSturtNum + 1; i < PortraitCount; i++) {
        RecalculateNamesAndIdsPortraits(false, DeceasedNum, i);
    }
}
function RecalculateNamesAndIdsPortraits(deceasedIsChange, deceasedNum, portraitStartNum) {
    var OurKey = PortraitIdCreator(deceasedNum, portraitStartNum);
    var PrevKey;

    if (deceasedIsChange) {
        PrevKey = PortraitIdCreator(deceasedNum - 1, portraitStartNum);
    }
    else {
        PrevKey = PortraitIdCreator(deceasedNum, portraitStartNum - 1);
    }

    $("#PortraitContainer" + portraitStartNum).attr("id", "PortraitContainer" + (portraitStartNum - 1));

    var ImgPortrait = $("#Portraits_" + OurKey + "__PhotoImage");
    console.log(ImgPortrait[0]);
    ImgPortrait[0].setAttribute("id", "Portraits_" + PrevKey + "__PhotoImage");
    ImgPortrait[0].setAttribute("name", "Portraits[" + PrevKey + "].PhotoImage");
    ImgPortrait[0].nextElementSibling.setAttribute("for", "Portraits_" + PrevKey + "__PhotoImage");
    $("#Portraits_" + OurKey + "__TypePortrait").attr("id", "Portraits_" + PrevKey + "__TypePortrait").attr("name", "Portraits[" + PrevKey + "].TypePortrait");
    $("#Portraits_" + OurKey + "__Artist").attr("id", "Portraits_" + PrevKey + "__Artist").attr("name", "Portraits[" + PrevKey + "].Artist");
    $("#Portraits_" + OurKey + "__Note").attr("id", "Portraits_" + PrevKey + "__Note").attr("name", "Portraits[" + PrevKey + "].Note");
}
function PortraitIdCreator(idDeceased, idPortrait) {
    return "D" + idDeceased + "P" + idPortrait;
}

function AddMedallion() {
    var thisId = parseInt($(this).attr("class").match(/\d+/));
    var MedallionsBlock = $(this).siblings();

    var MedallionCount = MedallionsBlock[2].getElementsByClassName("medallion-container").length;

    var keyM = MedallionIdCreator(thisId, MedallionCount);

    var MedallionContainer = $("<div/>").attr("id", "MedallionContainer" + MedallionCount)
        .attr("class", "medallion-container")
        .appendTo(MedallionsBlock[2]);

    var MedallionBox = $("<div/>").attr("class", " border p96 float-md-left ")
        .appendTo(MedallionContainer);
    $("<label/>").attr("class", "font-weight-bold").text("Медальон").appendTo(MedallionBox);
    var WrapperM = $("<div/>").attr("class", "wrapper w3").appendTo(MedallionBox);


    var ImgBlock = $("<div/>").attr("class", "custom-file img-block").appendTo(WrapperM);
    $("<input/>").attr("type", "file")
        .attr("accept", "image/*,image/jpeg")
        .attr("multiple", "true")
        .attr("name", "Medallions[" + keyM + "].PhotoImage")
        .attr("id", "Medallions_" + keyM + "__PhotoImage")
        .attr("class", "custom-file-input form-control full").appendTo(ImgBlock);
    $("<label/>").attr("class", "custom-file-label form-control")
        .attr("for", "Medallions_" + keyM + "__PhotoImage").appendTo(ImgBlock);


    var SelectMaterial = $("<select/>").attr("class", "form-control min-width-select-for-photo")
        .attr("name", "Medallions[" + keyM + "].MaterialMedallion")
        .attr("id", "Medallions_" + keyM + "__MaterialMedallion")
        .appendTo(WrapperM);
    $("<option/>").attr("value", "0").text("Материал...").appendTo(SelectMaterial);
    for (i = 0; i < materialsMedallion.length; i++) {
        $("<option/>").attr("value", materialsMedallion[i])
            .text(materialsMedallion[i])
            .appendTo(SelectMaterial);
    }

    $("<input/>").attr("class", "form-control")
        .attr("name", "Medallions[" + keyM + "].SizeMedallion")
        .attr("id", "Medallions_" + keyM + "__SizeMedallion")
        .attr("placeholder", "Размер медальона...")
        .appendTo(WrapperM);

    var SelectShape = $("<select/>").attr("class", "form-control min-width-select-for-photo")
        .attr("name", "Medallions[" + keyM + "].ShapeMedallion")
        .attr("id", "Medallions_" + keyM + "__ShapeMedallion")
        .appendTo(WrapperM);
    $("<option/>").attr("value", "0").text("Форма...").appendTo(SelectShape);
    for (i = 0; i < shapesMedallion.length; i++) {
        $("<option/>").attr("value", shapesMedallion[i])
            .text(shapesMedallion[i])
            .appendTo(SelectShape);
    }

    var SelectColor = $("<select/>").attr("class", "form-control min-width-select-for-photo")
        .attr("name", "Medallions[" + keyM + "].ColorMedallion")
        .attr("id", "Medallions_" + keyM + "__ColorMedallion")
        .appendTo(WrapperM);
    $("<option/>").attr("value", 0).text("Цвет...").appendTo(SelectColor);
    for (i = 0; i < colorsMedallion.length; i++) {
        $("<option/>").attr("value", colorsMedallion[i])
            .text(colorsMedallion[i])
            .appendTo(SelectColor);
    }

    $("<input/>").attr("class", "form-control")
        .attr("name", "Medallions[" + keyM + "].BackgroundMedallion")
        .attr("id", "Medallions_" + keyM + "__BackgroundMedallion")
        .attr("placeholder", "Фон...")
        .appendTo(WrapperM);

    var NoteWrap = $("<div/>").attr("class", "full-wrap3 ").appendTo(WrapperM);
    $("<textarea/>").attr("class", "form-control full")
        .attr("name", "Medallions[" + keyM + "].Note")
        .attr("id", "Medallions_" + keyM + "__Note")
        .attr("placeholder", "Примечание...")
        .appendTo(NoteWrap);

    //--- Рамка (начало) ------------------------------------------------
    var WrapperF = $("<div/>").attr("class", "wrapper w5 " + keyM).appendTo(MedallionBox);

    var DivFrame = $("<div/>").appendTo(WrapperF);
    $("<input/>").attr("type", "checkbox")
        .attr("data-val", "true")
        .attr("data-val-required", "The Frame field is required.")
        .attr("name", "Medallions[" + keyM + "].Frame")
        .attr("id", "Medallions_" + keyM + "__Frame")
        .attr("value", "true")
        .attr("class", " form-control check-frame check-box")
        .appendTo(DivFrame);
    $("<label/>").text(" Рамка").appendTo(DivFrame);

    $("<input/>").attr("class", "form-control")
        .attr("name", "Medallions[" + keyM + "].TypeFrame")
        .attr("id", "Medallions_" + keyM + "__TypeFrame")
        .attr("placeholder", "Тип...")
        .prop("disabled", true)
        .appendTo(WrapperF);
    $("<input/>").attr("class", "form-control")
        .attr("name", "Medallions[" + keyM + "].SizeFrame")
        .attr("id", "Medallions_" + keyM + "__SizeFrame")
        .attr("placeholder", "Размер...")
        .prop("disabled", true)
        .appendTo(WrapperF);
    $("<input/>").attr("class", "form-control")
        .attr("name", "Medallions[" + keyM + "].ShapeFrame")
        .attr("id", "Medallions_" + keyM + "__ShapeFrame")
        .attr("placeholder", "Форма...")
        .prop("disabled", true)
        .appendTo(WrapperF);
    $("<input/>").attr("class", "form-control")
        .attr("name", "Medallions[" + keyM + "].ColorFrame")
        .attr("id", "Medallions_" + keyM + "__ColorFrame")
        .attr("placeholder", "Цвет...")
        .prop("disabled", true)
        .appendTo(WrapperF);

    var DivGluing = $("<div/>").appendTo(WrapperF);
    $("<input/>").attr("type", "checkbox")
        .attr("data-val", "true")
        .attr("data-val-required", "The Frame field is required.")
        .attr("name", "Medallions[" + keyM + "].GluingIntoNiche")
        .attr("id", "Medallions_" + keyM + "__GluingIntoNiche")
        .attr("value", "true")
        .attr("class", "form-control check-box")
        .prop("disabled", false)
        .appendTo(DivGluing);
    $("<label/>").text(" Вклейка в нишу").appendTo(DivGluing);

    var NoteFrame = $("<div/>").attr("class", "text-note").appendTo(WrapperF);
    $("<textarea/>").attr("class", "form-control full")
        .attr("name", "Medallions[" + keyM + "].NoteFrame")
        .attr("id", "Medallions_" + keyM + "__NoteFrame")
        .attr("placeholder", "Примечание...")
        .prop("disabled", true)
        .appendTo(NoteFrame);

    //--- Рамка (конец) -------------------------------------------------

    var RemoveButton = $("<input/>").attr("type", "button").attr("class", "remove-portrait rp-btn float-md-left")
        .attr("value", "x").appendTo(MedallionContainer);
    RemoveButton.click(RemoveMedallion);
    /*MedallionCount++;*/
}
function RemoveMedallion() {
    var MedallionContainer = $(this).parent();
    var DeceasedNum = parseInt(MedallionContainer.parent().attr("id").match(/\d+/));
    var MedallionSturtNum = parseInt(MedallionContainer.attr("id").match(/\d+/));

    var MedallionCount = MedallionContainer.parent()[0].getElementsByClassName("medallion-container").length;

    $(this).parent().remove();
    for (var i = MedallionSturtNum + 1; i < MedallionCount; i++) {
        RecalculateNamesAndIdsMedallions(false, DeceasedNum, i);
    }
}
function RecalculateNamesAndIdsMedallions(deceasedIsChange, deceasedNum, medallionStartNum) {
    var OurKey = MedallionIdCreator(deceasedNum, medallionStartNum);
    var PrevKey;

    if (deceasedIsChange) {
        PrevKey = MedallionIdCreator(deceasedNum - 1, medallionStartNum);
    }
    else {
        PrevKey = MedallionIdCreator(deceasedNum, medallionStartNum - 1);
    }

    $("#MedallionContainer" + medallionStartNum).attr("id", "MedallionContainer" + (medallionStartNum - 1));

    var ImgMedallion = $("#Medallions_" + OurKey + "__PhotoImage");
    ImgMedallion[0].setAttribute("id", "Medallions_" + PrevKey + "__PhotoImage");
    ImgMedallion[0].setAttribute("name", "Medallions[" + PrevKey + "].PhotoImage");
    ImgMedallion[0].nextElementSibling.setAttribute("for", "Medallions_" + PrevKey + "__PhotoImage");
    $("#Medallions_" + OurKey + "__MaterialMedallion").attr("id", "Medallions_" + PrevKey + "__MaterialMedallion").attr("name", "Medallions[" + PrevKey + "].MaterialMedallion");
    $("#Medallions_" + OurKey + "__SizeMedallion").attr("id", "Medallions_" + PrevKey + "__SizeMedallion").attr("name", "Medallions[" + PrevKey + "].SizeMedallion");
    $("#Medallions_" + OurKey + "__ShapeMedallion").attr("id", "Medallions_" + PrevKey + "__ShapeMedallion").attr("name", "Medallions[" + PrevKey + "].ShapeMedallion");
    $("#Medallions_" + OurKey + "__ColorMedallion").attr("id", "Medallions_" + PrevKey + "__ColorMedallion").attr("name", "Medallions[" + PrevKey + "].ColorMedallion");
    $("#Medallions_" + OurKey + "__BackgroundMedallion").attr("id", "Medallions_" + PrevKey + "__BackgroundMedallion").attr("name", "Medallions[" + PrevKey + "].BackgroundMedallion");
    $("#Medallions_" + OurKey + "__Note").attr("id", "Medallions_" + PrevKey + "__Note").attr("name", "Medallions[" + PrevKey + "].Note");
    $("#Medallions_" + OurKey + "__Frame").attr("id", "Medallions_" + PrevKey + "__Frame").attr("name", "Medallions[" + PrevKey + "].Frame");
    $("#Medallions_" + OurKey + "__TypeFrame").attr("id", "Medallions_" + PrevKey + "__TypeFrame").attr("name", "Medallions[" + PrevKey + "].TypeFrame");
    $("#Medallions_" + OurKey + "__SizeFrame").attr("id", "Medallions_" + PrevKey + "__SizeFrame").attr("name", "Medallions[" + PrevKey + "].SizeFrame");
    $("#Medallions_" + OurKey + "__ShapeFrame").attr("id", "Medallions_" + PrevKey + "__ShapeFrame").attr("name", "Medallions[" + PrevKey + "].ShapeFrame");
    $("#Medallions_" + OurKey + "__ColorFrame").attr("id", "Medallions_" + PrevKey + "__ColorFrame").attr("name", "Medallions[" + PrevKey + "].ColorFrame");
    $("#Medallions_" + OurKey + "__GluingIntoNiche").attr("id", "Medallions_" + PrevKey + "__GluingIntoNiche").attr("name", "Medallions[" + PrevKey + "].GluingIntoNiche");
    $("#Medallions_" + OurKey + "__NoteFrame").attr("id", "Medallions_" + PrevKey + "__NoteFrame").attr("name", "Medallions[" + PrevKey + "].NoteFrame");

}
function MedallionIdCreator(idDeceased, idMedallion) {
    return "D" + idDeceased + "M" + idMedallion;
}
