var CustomersCount = 1;
var DeceasedsCount = $("#Deceaseds")[0].getElementsByClassName("deceased-container").length;
var PhotosCount = $("[id^='Photos'], .custom-file-input").length;
var deletedDeceasedCount = 0;
var deletedPhotoCount = 0;
var deletedCustomerCount = 0;

// --- Проверка чекбоксов (начало) -------------------------------------------------
// установка / самовывоз
if ($("#Contract_Pickup").is(":checked")) {
    AddDisabledPickup(true)
}
// эпитафии
var epitaphBoxes = document.getElementsByClassName("check-epitaph");
for (eph = 0; eph < epitaphBoxes.length; eph++) {
    if ($(epitaphBoxes[eph]).is(":checked")) {
        //console.log(epitaphBoxes[eph]);
        AddDisabledEpitaph(epitaphBoxes[eph], false);
    }
}
// рамки медальонов
var frameBoxes = document.getElementsByClassName("check-frame");
for (fr = 0; fr < frameBoxes.length; fr++) {
    if ($(frameBoxes[fr]).is(":checked")) {
        AddDisabledFrame(frameBoxes[fr], false);
    }
}
// --- Проверка чекбоксов (конец) -------------------------------------------------

$(document).ready(function () {
    // --- Add/Remove -------------------------------------------------
    $("#AddCustomer").click(AddCustomer);
    $("#AddDeceased").click(AddDeceased);
    $(".add-portrait").click(AddPortrait);
    $(".add-medallion").click(AddMedallion);

    $(".remove-customer").click(RemoveCustomer);
    $(".remove-deceased").click(RemoveDeceased);
    $(".remove-portrait").click(RemovePortrait);
    $(".remove-medallion").click(RemoveMedallion);

    $(".to-compleate-portrait").click(function () {
        SendToCompleate("портрет", "DateBegin", this);
    });
    $(".to-compleate-medallion").click(function () {
        SendToCompleate("медальон", "DateBegin", this);
    });
    $(".to-compleate-name").click(function () {
        SendToCompleate("текст ФИО усопшего", "DateBeginTextName", this);
    });
    $(".to-compleate-epitaph").click(function () {
        SendToCompleate("текст эпитафии", "DateBeginTextEpitaph", this);
    });
    $(".check-epitaph").click(CheckEpitaph);
    $(".check-frame").click(CheckFrame);
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
    //$(".custom-file-input").on("change", function () {
    //    var fileName = $(this).val().split("\\").pop();
    //    $(this).next(".custom-file-label").html(fileName);
    //});
});
// --- При загрузке изображения добавляет его название в строку ---
//$(document).on("input", ".custom-file-input", function () {
//    var names = $(this).prop('files');
//    var str = "";
//    for (var i = 0; i < names.length; i++) {
//        str += names[i].name;
//        if (i !== (names.length - 1)) {
//            str += ", ";
//        }
//    }
//    $(this).siblings(".custom-file-label").addClass("selected").html(str);
//});
// ----------------------------------------------------------------

function CheckFrame() {
    if ($(this).is(":checked")) {
        AddDisabledFrame(this, false);
    }
    else {
        AddDisabledFrame(this, true);
    }
}
function AddDisabledFrame(frameBox, trfl) {
    var keyF = ($(frameBox).attr("id")).match(/D\d+M\d+/)[0];

    var TypeFrame = $(frameBox).closest(".wrapper")[0].querySelector("[id$='__TypeFrame']");/* FrameBlock.querySelector("#Medallions_" + keyF + "__TypeFrame");*/
    var SizeFrame = $(frameBox).closest(".wrapper")[0].querySelector("[id$='__SizeFrame']");//FrameBlock.querySelector("#Medallions_" + keyF + "__SizeFrame");
    var ShapeFrame = $(frameBox).closest(".wrapper")[0].querySelector("[id$='__ShapeFrame']");//FrameBlock.querySelector("#Medallions_" + keyF + "__ShapeFrame");
    var ColorFrame = $(frameBox).closest(".wrapper")[0].querySelector("[id$='" + keyF + "__ColorFrame']");//FrameBlock.querySelector("#Medallions_" + keyF + "__ColorFrame");
    var NoteFrame = $(frameBox).closest(".wrapper")[0].querySelector("[id$='" + keyF + "__NoteFrame']");//FrameBlock.querySelector("#Medallions_" + keyF + "__NoteFrame");
    var GluingIntoNiche = $(frameBox).closest(".wrapper")[0].querySelector("[id$='" + keyF + "__GluingIntoNiche']");//FrameBlock.querySelector("#Medallions_" + keyF + "__GluingIntoNiche");

    $(TypeFrame).prop("disabled", trfl);
    $(SizeFrame).prop("disabled", trfl);
    $(ShapeFrame).prop("disabled", trfl);
    $(ColorFrame).prop("disabled", trfl);
    $(NoteFrame).prop("disabled", trfl);
    $(GluingIntoNiche).prop("disabled", !trfl);
}

function AddDisabledPickup(trfl) {
    $("#Contract_BurialAddress").prop("disabled", trfl);
    $("#Contract_Sector").prop("disabled", trfl);
    $("#Contract_Row").prop("disabled", trfl);
    $("#Contract_BurialPlace").prop("disabled", trfl);
    $("#Contract_Grave").prop("disabled", trfl);
    $("#Contract_DistanceFromMKAD").prop("disabled", trfl);
    $("#Contract_NumberOfTrips").prop("disabled", trfl);
    if (trfl) {
        $("#calculateTrips").attr("class", "disabled");
    }
    else {
        $("#calculateTrips").attr("class", "");
    }
    
}

function CheckEpitaph() {
    if ($(this).is(":checked")) {
        AddDisabledEpitaph(this, false);
    }
    else {
        AddDisabledEpitaph(this, true);
    }
}
function AddDisabledEpitaph(epitaphBox, trfl) {
    var NotesTextEpitaph = $(epitaphBox).closest(".wrapper")[0].querySelector("[id$='__NotesTextEpitaph']");
    var TypeNameEpitaph = $(epitaphBox).closest(".wrapper")[0].querySelector("[id$='__TypeNameEpitaph']");
    var EngraverEpitaph = $(epitaphBox).closest(".wrapper")[0].querySelector("[id$='__EngraverEpitaph']");

    $(NotesTextEpitaph).prop("disabled", trfl);
    $(TypeNameEpitaph).prop("disabled", trfl);
    $(EngraverEpitaph).prop("disabled", trfl);
}

function SendToCompleatePortrait() {
    SendToCompleate("портрет", "DateBegin", this);
}
function SendToCompleateMedallion() {
    SendToCompleate("медальон", "DateBegin", this);
}
function SendToCompleateTextName() {
    SendToCompleate("текст ФИО усопшего", "DateBeginTextName", this);
}
function SendToCompleateTextEpitaph() {
    if ($($(this).parent()[0].querySelector("[id$='__Epitaph']")).is(":checked")) {
        SendToCompleate("текст эпитафии", "DateBeginTextEpitaph", this);
    }
    else {
        alert('Нет доступной эпитафии для отправки на выполнение');
    }
    
}
function SendToCompleate(nameSend, id, btn) {
    if (confirm("Вы действительно хотите отправить " + nameSend + " на выполнение?")) {
        var date = new Date();
        $($(btn).parent()[0].querySelector("[id$='" + id + "']")).val(date.toDateString());
        $(btn).remove();
        alert('Для завершения отправки на выполнение нажмите кнопку "Сохранить" в конце страницы');
    }
}

function AddCustomer() {
    //добавляем поля
    var CustomerContainer = $("<div/>").attr("class", "customer-container")
        .attr("id", "CustomerContainer" + CustomersCount).appendTo("#Customers");

    var Wrapper = $("<div/>").attr("class", "wrapper w5 p96 float-md-left").appendTo(CustomerContainer);

    $("<div/>").attr("class", "box1").text("ФИО заказчика: ").appendTo(Wrapper);
    $("<div/>").text("Телефон: ").appendTo(Wrapper);
    var DivForMess = $("<div/>").attr("class", "boxMessengers").appendTo(Wrapper);
    $("<img/>").attr("class", "icon").attr("src", "/Images/viber.png").attr("title", "viber").appendTo(DivForMess);
    $("<img/>").attr("class", "icon").attr("src", "/Images/telegram.png").attr("title", "telegram").appendTo(DivForMess);
    $("<img/>").attr("class", "icon").attr("src", "/Images/whatsapp.png").attr("title", "whatsapp").appendTo(DivForMess);
    $("<div/>").text("Email: ").appendTo(Wrapper);
    $("<div/>").text("Другая связь: ").appendTo(Wrapper);
    //$("<div/>").attr("style", "width: 50px").appendTo(Wrapper);

    var DivFIO = $("<div/>").attr("class", "box1").appendTo(Wrapper);
    $("<input/>").attr("type", "text").attr("name", "Contract.Customers[" + CustomersCount + "].LastName")
        .attr("class", "form-control full").attr("placeholder", "Фамилия")
        .attr("id", "Contract_Customers_" + CustomersCount + "__LastName").appendTo(DivFIO);
    //CustomerContainer.text("  Имя : ");
    $("<input/>").attr("type", "text").attr("name", "Contract.Customers[" + CustomersCount + "].FirstName")
        .attr("class", "form-control full").attr("placeholder", "Имя")
        .attr("id", "Contract_Customers_" + CustomersCount + "__FirstName").appendTo(DivFIO);
    $("<input/>").attr("type", "text").attr("name", "Contract.Customers[" + CustomersCount + "].MiddleName")
        .attr("class", "form-control full").attr("placeholder", "Отчество")
        .attr("id", "Contract_Customers_" + CustomersCount + "__MiddleName").appendTo(DivFIO);

    var DivPhone = $("<div/>").appendTo(Wrapper);
    $("<input/>").attr("type", "text").attr("name", "Contract.Customers[" + CustomersCount + "].Number")
        .attr("class", "form-control full")
        .attr("id", "Contract_Customers_" + CustomersCount + "__Number").appendTo(DivPhone);

    var DivCheckMess = $("<div/>").attr("class", "boxMessengers").appendTo(Wrapper);
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
        .attr("class", "form-control full")
        .attr("id", "Contract_Customers_" + CustomersCount + "__Email").appendTo(Wrapper);

    $("<input/>").attr("type", "text").attr("name", "Contract.Customers[" + CustomersCount + "].Note")
        .attr("class", "form-control full")
        .attr("id", "Contract_Customers_" + CustomersCount + "__Note").appendTo(Wrapper);

    $("<input/>").attr("data-val", true).attr("name", "Contract.Customers[" + CustomersCount + "].Id")
        .attr("type", "hidden").attr("data-val-required", "The Id field is required.").val(-1)
        .attr("id", "Contract_Customers_" + CustomersCount + "__Id").appendTo(CustomerContainer);
    //OwnershipContainer.text("  Price : ");

    var RemoveButton = $("<input/>").attr("type", "button").attr("class", "remove-customer r-btn float-md-left")
        .attr("value", "x").appendTo(CustomerContainer);
    //на нажатие этого элемента добавляем обработчик - функцию удаления
    RemoveButton.click(RemoveCustomer);
    CustomersCount++;
    
}
function RemoveCustomer() {
    if (confirm("Вы действительно хотите удалить информацию о заказчике?")) {
        var RecalculateStartNum = parseInt($(this).parent().attr("id").substring("CustomerContainer".length));

        var deletedCustomerId = $($(this).siblings()[1]).attr("value");
        $("<input/>").attr("id", "DeletedCustomerIds_" + deletedCustomerCount + "_").attr("name", "DeletedCustomerIds[" + deletedCustomerCount + "]")
            .attr("type", "hidden").attr("value", deletedCustomerId).appendTo(".deleted");
        deletedCustomerCount++;


        $(this).parent().remove();
        for (var i = RecalculateStartNum + 1; i < CustomersCount; i++) {
            //функция пересчета аттрибутов name и id
            RecalculateNamesAndIdsCustomers(i);
        }
        CustomersCount--;
    }
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
    $("#Contract_Customers_" + number + "__Id").attr("id", "Contract_Customers_" + prevNumber + "__Id")
        .attr("name", "Contract.Customers[" + prevNumber + "].Id");
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

    var SelectEngraverName = $("<select/>").attr("class", "form-control full")
        .attr("name", "Contract.Deceaseds[" + DeceasedsCount + "].EngraverName")
        .attr("id", "Contract_Deceaseds_" + DeceasedsCount + "__EngraverName")
        .appendTo(WrapperD);
    $("<option/>").attr("value", "0").text("Гравер (ФИО, даты)...").appendTo(SelectEngraverName);

    //$("<input/>").attr("type", "text").attr("name", "Contract.Deceaseds[" + DeceasedsCount + "].EngraverName")
    //    .attr("id", "Contract_Deceaseds_" + DeceasedsCount + "__EngraverName")
    //    .attr("class", "form-control full").attr("placeholder", "Гравер (ФИО)...")
    //    .appendTo(WrapperD);
    $("<input/>").attr("type", "text").attr("name", "Contract.Deceaseds[" + DeceasedsCount + "].NotesTextName")
        .attr("id", "Contract_Deceaseds_" + DeceasedsCount + "__NotesTextName")
        .attr("class", "form-control typetext-note full").attr("placeholder", "Примечание (ФИО)...")
        .appendTo(WrapperD);

    //----- Эпитафия (начало) ------------------------

    var DivEpitaph = $("<div/>").appendTo(WrapperD);
    var CheckEpit = $("<input/>").attr("type", "checkbox")
        .attr("data-val", "true")
        .attr("data-val-required", "The Epitaph field is required.")
        .attr("id", "Contract_Deceaseds_" + DeceasedsCount + "__Epitaph")
        .attr("name", "Contract.Deceaseds[" + DeceasedsCount + "].Epitaph")
        .attr("value", "true")
        .attr("class", "check-box check-epitaph")
        .appendTo(DivEpitaph);
    CheckEpit.click(CheckEpitaph);
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

    var SelectEngraverEpitaph = $("<select/>").attr("id", "Contract_Deceaseds_" + DeceasedsCount + "__EngraverEpitaph")
        .attr("name", "Contract.Deceaseds[" + DeceasedsCount + "].EngraverEpitaph")
        .attr("class", "form-control full engraver-epitaph-" + DeceasedsCount)
        .prop("disabled", true)
        .appendTo(WrapperD);
    $("<option/>").attr("value", "0").text("Гравер (эпитафия)...").appendTo(SelectEngraverEpitaph);

    //$("<input/>").attr("type", "text")
    //    .attr("id", "Contract_Deceaseds_" + DeceasedsCount + "__EngraverEpitaph")
    //    .attr("name", "Contract.Deceaseds[" + DeceasedsCount + "].EngraverEpitaph")
    //    .attr("class", "form-control full engraver-epitaph-" + DeceasedsCount)
    //    .attr("placeholder", "Гравер (эпитафия)...")
    //    .prop("disabled", true)
    //    .appendTo(WrapperD);
    //----- Эпитафия (конец) ------------------------


    /////// Фотографии (начало) /////////////////////
    var DeceasedPhoto = $("<div/>").attr("class", "full-wrap").appendTo(WrapperD);
    //----- Портреты (начало) -----------------------
    $("<div/>").attr("class", "Portraits" + DeceasedsCount).attr("id", "Portraits" + DeceasedsCount).appendTo(DeceasedPhoto);
    //----- Портреты (конец) ------------------------
    var AddPortraitButton = $("<input/>").attr("type", "button").attr("class", "add-btn my-btn add-portrait").attr("id", "ap" + DeceasedsCount)
        .attr("value", "Добавить портрет").appendTo(DeceasedPhoto);
    //----- Медальоны (начало) ----------------------
    $("<div/>").attr("class", "Medallions" + DeceasedsCount).attr("id", "Medallions" + DeceasedsCount).appendTo(DeceasedPhoto);
    //----- Медальоны (конец) -----------------------
    //var AddMedallionButton = 
    var AddMedallionButton = $("<input/>").attr("type", "button").attr("class", "add-btn my-btn add-medallion").attr("id", "am" + DeceasedsCount)
        .attr("value", "Добавить медальон").appendTo(DeceasedPhoto);
    /////// Фотографии (конец) //////////////////////
    $("<input/>").attr("data-val", true).attr("name", "Contract.Deceaseds[" + DeceasedsCount + "].Id")
        .attr("type", "hidden").attr("data-val-required", "The Id field is required.").val(-1)
        .attr("id", "Contract_Deceaseds_" + DeceasedsCount + "__Id").appendTo(DeceasedContainer);
    $("<input/>").attr("data-val", true).attr("name", "Contract.Deceaseds[" + DeceasedsCount + "].DateBeginTextName")
        .attr("type", "hidden").attr("data-val-required", "The DateBeginTextName field is required.")
        .attr("id", "Contract_Deceaseds_" + DeceasedsCount + "__DateBeginTextName").appendTo(DeceasedContainer);
    $("<input/>").attr("data-val", true).attr("name", "Contract.Deceaseds[" + DeceasedsCount + "].DateCompleatTextName")
        .attr("type", "hidden").attr("data-val-required", "The DateCompleatTextName field is required.")
        .attr("id", "Contract_Deceaseds_" + DeceasedsCount + "__DateCompleatTextName").appendTo(DeceasedContainer);
    $("<input/>").attr("data-val", true).attr("name", "Contract.Deceaseds[" + DeceasedsCount + "].DateBeginTextEpitaph")
        .attr("type", "hidden").attr("data-val-required", "The DateBeginTextEpitaph field is required.")
        .attr("id", "Contract_Deceaseds_" + DeceasedsCount + "__DateBeginTextEpitaph").appendTo(DeceasedContainer);
    $("<input/>").attr("data-val", true).attr("name", "Contract.Deceaseds[" + DeceasedsCount + "].DateCompleatTextEpitaph")
        .attr("type", "hidden").attr("data-val-required", "The DateCompleatTextEpitaph field is required.")
        .attr("id", "Contract_Deceaseds_" + DeceasedsCount + "__DateCompleatTextEpitaph").appendTo(DeceasedContainer);

    var RemoveButton = $("<input/>").attr("type", "button").attr("class", "remove-deceased r-btn float-md-left")
        .attr("value", "x").appendTo(DeceasedContainer);
    var SendButtonName = $("<a/>").attr("class", "to-compleate-name rp-btn float-md-left")
        .attr("title", "Отправить текст ФИО на выполнение").appendTo(DeceasedContainer);
    $("<img/>").attr("src", "/Images/send.png").attr("class", "send-btn").appendTo(SendButtonName);
    var SendButtonEpitaph = $("<a/>").attr("class", "to-compleate-epitaph rp-btn float-md-left")/*.prop("disabled", true)*/
        .attr("title", "Отправить текст эпитафии на выполнение").appendTo(DeceasedContainer);
    $("<img/>").attr("src", "/Images/send.png").attr("class", "send-btn").appendTo(SendButtonEpitaph);

    //навешиваем обработчики
    RemoveButton.click(RemoveDeceased);
    AddPortraitButton.click(AddPortrait);
    AddMedallionButton.click(AddMedallion);
    SendButtonName.click(SendToCompleateTextName);
    SendButtonEpitaph.click(SendToCompleateTextEpitaph);
    DeceasedsCount++;

}
function RemoveDeceased() {
    if (confirm("Вы действительно хотите удалить информацию об усопшем?")) {
        var RecalculateStartNum = parseInt($(this).parent().attr("id").substring("DeceasedContainer".length));

        var deletedDeceasedId = $($(this).siblings()[1]).attr("value");
        var removePortraitButtons = $(this).siblings()[0].getElementsByClassName("remove-portrait");
        var removeMedallionButtons = $(this).siblings()[0].getElementsByClassName("remove-medallion");
        var rpbLength = removePortraitButtons.length;
        var rmbLength = removeMedallionButtons.length;
        for (i = 0; i < rpbLength; i++) {
            removePortraitButtons[i].click();
        }
        for (i = 0; i < rmbLength; i++) {
            removeMedallionButtons[i].click();
        }

        $("<input/>").attr("id", "DeletedDeceasedIds_" + deletedDeceasedCount + "_").attr("name", "DeletedDeceasedIds[" + deletedDeceasedCount + "]")
            .attr("type", "hidden").attr("value", deletedDeceasedId).appendTo(".deleted");
        deletedDeceasedCount++;

        $(this).parent().remove();
        for (var i = RecalculateStartNum + 1; i < DeceasedsCount; i++) {
            //функция пересчета аттрибутов name и id
            RecalculateNamesAndIdsDeceaseds(i);
        }
        DeceasedsCount--;
    }

    
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
    $("#Contract_Deceaseds_" + number + "__Id").attr("id", "Contract_Deceaseds_" + prevNumber + "__Id")
        .attr("name", "Contract.Deceaseds[" + prevNumber + "].Id");

    $("#Contract_Deceaseds_" + number + "__DateBeginTextName").attr("id", "Contract_Deceaseds_" + prevNumber + "__DateBeginTextName")
        .attr("name", "Contract.Deceaseds[" + prevNumber + "].DateBeginTextName");
    $("#Contract_Deceaseds_" + number + "__DateCompleatTextName").attr("id", "Contract_Deceaseds_" + prevNumber + "__DateCompleatTextName")
        .attr("name", "Contract.Deceaseds[" + prevNumber + "].DateCompleatTextName");
    $("#Contract_Deceaseds_" + number + "__DateBeginTextEpitaph").attr("id", "Contract_Deceaseds_" + prevNumber + "__DateBeginTextEpitaph")
        .attr("name", "Contract.Deceaseds[" + prevNumber + "].DateBeginTextEpitaph");
    $("#Contract_Deceaseds_" + number + "__DateCompleatTextEpitaph").attr("id", "Contract_Deceaseds_" + prevNumber + "__DateCompleatTextEpitaph")
        .attr("name", "Contract.Deceaseds[" + prevNumber + "].DateCompleatTextEpitaph");

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
    var thisId = parseInt($(this).attr("id").match(/\d+/));
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
    $("<input/>").attr("type", "hidden")
        .attr("value", keyP)
        .attr("name", "Photos[" + (PhotosCount - 1) + "].PhotoKey")
        .attr("id", "Photos_" + (PhotosCount - 1) + "__PhotoKey").appendTo(ImgBlock);
    $("<input/>").attr("type", "file")
        .attr("accept", "image/*,image/jpeg")
        .attr("multiple", "true")
        .attr("name", "Photos[" + (PhotosCount - 1) + "].Image")
        .attr("id", "Photos_" + (PhotosCount - 1) + "__Image")
        .attr("class", "custom-file-input form-control full").appendTo(ImgBlock);
    $("<label/>").attr("class", "custom-file-label form-control").text("Новое изображение...")
        .attr("for", "Photos_" + (PhotosCount - 1) + "__Image").appendTo(ImgBlock);

    var SelectPortraitType = $("<select/>").attr("class", "form-control min-width-select-for-photo")
        .attr("name", "Portraits[" + keyP + "].TypePortraitId")
        .attr("id", "Portraits_" + keyP + "__TypePortraitId")
        .appendTo(WrapperP);
    $("<option/>").attr("value", "0").text("Тип портрета...").appendTo(SelectPortraitType);


    var SelectArtist = $("<select/>").attr("class", "form-control min-width-select-for-photo")
        .attr("name", "Portraits[" + keyP + "].Artist")
        .attr("id", "Portraits_" + keyP + "__Artist")
        .appendTo(WrapperP);
    $("<option/>").attr("value", "0").text("Художник...").appendTo(SelectArtist);

    var NoteWrap = $("<div/>").attr("class", "full-wrap3 ").appendTo(WrapperP);
    $("<textarea/>").attr("class", "form-control full")
        .attr("name", "Portraits[" + keyP + "].Note")
        .attr("id", "Portraits_" + keyP + "__Note")
        .attr("placeholder", "Примечание...")
        .appendTo(NoteWrap);

    $("<input/>").attr("data-val", true).attr("name", "Portraits[" + keyP + "].Id")
        .attr("type", "hidden").attr("data-val-required", "The Id field is required.").val(-1)
        .attr("id", "Portraits_" + keyP + "__Id").appendTo(PortraitContainer);
    $("<input/>").attr("data-val", true).attr("name", "Portraits[" + keyP + "].PhotoPath")
        .attr("type", "hidden").attr("data-val-required", "The PhotoPath field is required.")
        .attr("id", "Portraits_" + keyP + "__PhotoPath").appendTo(PortraitContainer);
    $("<input/>").attr("data-val", true).attr("name", "Portraits[" + keyP + "].PhotoName")
        .attr("type", "hidden").attr("data-val-required", "The PhotoName field is required.")
        .attr("id", "Portraits_" + keyP + "__PhotoName").appendTo(PortraitContainer);
    $("<input/>").attr("data-val", true).attr("name", "Portraits[" + keyP + "].DateCompleat")
        .attr("type", "hidden").attr("data-val-required", "The DateCompleat field is required.")
        .attr("id", "Portraits_" + keyP + "__DateCompleat").appendTo(PortraitContainer);
    $("<input/>").attr("data-val", true).attr("name", "Portraits[" + keyP + "].DateBegin")
        .attr("type", "hidden").attr("data-val-required", "The DateBegin field is required.")
        .attr("id", "Portraits_" + keyP + "__DateBegin").appendTo(PortraitContainer);
    $("<input/>").attr("data-val", true).attr("name", "Portraits[" + keyP + "].TypePortrait")
        .attr("type", "hidden").attr("data-val-required", "The TypePortrait field is required.")
        .attr("id", "Portraits_" + keyP + "__TypePortrait").appendTo(PortraitContainer);

    var RemoveButton = $("<input/>").attr("type", "button").attr("class", "remove-portrait rp-btn float-md-left")
        .attr("value", "x").appendTo(PortraitContainer);
    var SendButton = $("<a/>").attr("class", "to-compleate-portrait rp-btn float-md-left")
        .attr("title", "Отправить портрет на выполнение").appendTo(PortraitContainer);
    $("<img/>").attr("src", "/Images/send.png").attr("class", "send-btn").appendTo(SendButton);

    //навешиваем обработчики
    RemoveButton.click(RemovePortrait);
    SendButton.click(SendToCompleatePortrait);
    PhotosCount++
}
function RemovePortrait() {
    if (confirm("Вы действительно хотите удалить портрет?")) {
        var PortraitContainer = $(this).parent();
        var DeceasedNum = parseInt(PortraitContainer.parent().attr("id").match(/\d+/));
        var PortraitSturtNum = parseInt(PortraitContainer.attr("id").match(/\d+/));

        var PortraitCount = PortraitContainer.parent()[0].getElementsByClassName("portrait-container").length;
        var deletedPortraitId = $($(this).siblings()[1]).attr("value");
        $("<input/>").attr("id", "DeletedPhotoIds_" + deletedPhotoCount + "_").attr("name", "DeletedPhotoIds[" + deletedPhotoCount + "]")
            .attr("type", "hidden").attr("value", deletedPortraitId).appendTo(".deleted");
        deletedPhotoCount++;

        $(this).parent().remove();
        for (var i = PortraitSturtNum + 1; i < PortraitCount; i++) {
            RecalculateNamesAndIdsPortraits(false, DeceasedNum, i);
        }
        var imgStartNum = parseInt($($(this).parent()[0].getElementsByClassName("custom-file-input")[0]).attr("id").match(/\d+/));
        for (var j = imgStartNum + 1; j < PhotosCount; j++) {
            RecalculateNamesAndIdsPhotos(j);
        }
        PhotosCount--;
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
    $("#PortraitContainer" + (portraitStartNum - 1)).find("[id$='__PhotoKey']").first().val(PrevKey);

    $("#Portraits_" + OurKey + "__TypePortraitId").attr("id", "Portraits_" + PrevKey + "__TypePortraitId").attr("name", "Portraits[" + PrevKey + "].TypePortraitId");
    $("#Portraits_" + OurKey + "__Artist").attr("id", "Portraits_" + PrevKey + "__Artist").attr("name", "Portraits[" + PrevKey + "].Artist");
    $("#Portraits_" + OurKey + "__Note").attr("id", "Portraits_" + PrevKey + "__Note").attr("name", "Portraits[" + PrevKey + "].Note");
    $("#Portraits_" + OurKey + "__Id").attr("id", "Portraits_" + PrevKey + "__Id").attr("name", "Portraits[" + PrevKey + "].Id");
    $("#Portraits_" + OurKey + "__PhotoPath").attr("id", "Portraits_" + PrevKey + "__PhotoPath").attr("name", "Portraits[" + PrevKey + "].PhotoPath");
    $("#Portraits_" + OurKey + "__PhotoName").attr("id", "Portraits_" + PrevKey + "__PhotoName").attr("name", "Portraits[" + PrevKey + "].PhotoName");
    $("#Portraits_" + OurKey + "__DateCompleat").attr("id", "Portraits_" + PrevKey + "__DateCompleat").attr("name", "Portraits[" + PrevKey + "].DateCompleat");
    $("#Portraits_" + OurKey + "__DateBegin").attr("id", "Portraits_" + PrevKey + "__DateBegin").attr("name", "Portraits[" + PrevKey + "].DateBegin");
    $("#Portraits_" + OurKey + "__TypePortrait").attr("id", "Portraits_" + PrevKey + "__TypePortrait").attr("name", "Portraits[" + PrevKey + "].TypePortrait");
}
function PortraitIdCreator(idDeceased, idPortrait) {
    return "D" + idDeceased + "P" + idPortrait;
}

function AddMedallion() {
    var thisId = parseInt($(this).attr("id").match(/\d+/));
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
    $("<input/>").attr("type", "hidden")
        .attr("value", keyM)
        .attr("name", "Photos[" + (PhotosCount - 1) + "].PhotoKey")
        .attr("id", "Photos_" + (PhotosCount - 1) + "__PhotoKey").appendTo(ImgBlock);
    $("<input/>").attr("type", "file")
        .attr("accept", "image/*,image/jpeg")
        .attr("multiple", "true")
        .attr("name", "Photos[" + (PhotosCount - 1) + "].Image")
        .attr("id", "Photos_" + (PhotosCount - 1) + "__Image")
        .attr("class", "custom-file-input form-control full").appendTo(ImgBlock);
    $("<label/>").attr("class", "custom-file-label form-control").text("Новое изображение...")
        .attr("for", "Photos_" + (PhotosCount - 1) + "__Image").appendTo(ImgBlock);

    var SelectMaterial = $("<select/>").attr("class", "form-control min-width-select-for-photo")
        .attr("name", "Medallions[" + keyM + "].MaterialMedallion")
        .attr("id", "Medallions_" + keyM + "__MaterialMedallion")
        .appendTo(WrapperM);
    $("<option/>").attr("value", "0").text("Материал...").appendTo(SelectMaterial);

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

    var SelectColor = $("<select/>").attr("class", "form-control min-width-select-for-photo")
        .attr("name", "Medallions[" + keyM + "].ColorMedallion")
        .attr("id", "Medallions_" + keyM + "__ColorMedallion")
        .appendTo(WrapperM);
    $("<option/>").attr("value", 0).text("Цвет...").appendTo(SelectColor);

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
    var CheckFr =  $("<input/>").attr("type", "checkbox")
        .attr("data-val", "true")
        .attr("data-val-required", "The Frame field is required.")
        .attr("name", "Medallions[" + keyM + "].Frame")
        .attr("id", "Medallions_" + keyM + "__Frame")
        .attr("value", "true")
        .attr("class", " form-control check-frame check-box")
        .appendTo(DivFrame);
    CheckFr.click(CheckFrame);
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

    $("<input/>").attr("data-val", true).attr("name", "Medallions[" + keyM + "].Id")
        .attr("type", "hidden").attr("data-val-required", "The Id field is required.").val(-1)
        .attr("id", "Medallions_" + keyM + "__Id").appendTo(MedallionContainer);
    $("<input/>").attr("data-val", true).attr("name", "Medallions[" + keyM + "].PhotoPath")
        .attr("type", "hidden").attr("data-val-required", "The PhotoPath field is required.")
        .attr("id", "Medallions_" + keyM + "__PhotoPath").appendTo(MedallionContainer);
    $("<input/>").attr("data-val", true).attr("name", "Medallions[" + keyM + "].PhotoName")
        .attr("type", "hidden").attr("data-val-required", "The PhotoName field is required.")
        .attr("id", "Medallions_" + keyM + "__PhotoName").appendTo(MedallionContainer);
    $("<input/>").attr("data-val", true).attr("name", "Medallions[" + keyM + "].DateCompleat")
        .attr("type", "hidden").attr("data-val-required", "The DateCompleat field is required.")
        .attr("id", "Medallions_" + keyM + "__DateCompleat").appendTo(MedallionContainer);
    $("<input/>").attr("data-val", true).attr("name", "Medallions[" + keyM + "].DateBegin")
        .attr("type", "hidden").attr("data-val-required", "The DateBegin field is required.")
        .attr("id", "Medallions_" + keyM + "__DateBegin").appendTo(MedallionContainer);

    var RemoveButton = $("<input/>").attr("type", "button").attr("class", "remove-medallion rp-btn float-md-left")
        .attr("value", "x").appendTo(MedallionContainer);
    var SendButton = $("<a/>").attr("class", "to-compleate-medallion rp-btn float-md-left")
        .attr("title", "Отправить медальон на выполнение").appendTo(MedallionContainer);
    $("<img/>").attr("src", "/Images/send.png").attr("class", "send-btn").appendTo(SendButton);


    RemoveButton.click(RemoveMedallion);
    SendButton.click(SendToCompleateMedallion);
    PhotosCount++;
}
function RemoveMedallion() {
    if (confirm("Вы действительно хотите удалить медальон?")) {
        var MedallionContainer = $(this).parent();
        var DeceasedNum = parseInt(MedallionContainer.parent().attr("id").match(/\d+/));
        var MedallionSturtNum = parseInt(MedallionContainer.attr("id").match(/\d+/));

        var MedallionCount = MedallionContainer.parent()[0].getElementsByClassName("medallion-container").length;
        var deletedMedallionId = $($(this).siblings()[1]).attr("value");
        $("<input/>").attr("id", "DeletedPhotoIds_" + deletedPhotoCount + "_").attr("name", "DeletedPhotoIds[" + deletedPhotoCount + "]")
            .attr("type", "hidden").attr("value", deletedMedallionId).appendTo(".deleted");
        deletedPhotoCount++;

        $(this).parent().remove();
        for (var i = MedallionSturtNum + 1; i < MedallionCount; i++) {
            RecalculateNamesAndIdsMedallions(false, DeceasedNum, i);
        }
        var imgStartNum = parseInt($($(this).parent()[0].getElementsByClassName("custom-file-input")[0]).attr("id").match(/\d+/));
        for (var j = imgStartNum + 1; j < PhotosCount; j++) {
            RecalculateNamesAndIdsPhotos(j);
        }
        PhotosCount--;
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
    $("#MedallionContainer" + (medallionStartNum - 1)).find("[id$='__PhotoKey']").first().val(PrevKey);
    //var NumPhotos = $(document).find("[id$='__PhotoKey']").length - 1;

    //$("#Photos_" + medallionStartNum + "__PhotoKey").attr("id", "Photos_" + (medallionStartNum - 1) + "__PhotoKey")
    //    .attr("name", "Photos[" + (medallionStartNum - 1) + "].PhotoKey").val(PrevKey);

    //var ImgMedallion = $("#MedallionPhotos_" + medallionStartNum + "__Image");

    //$("#Photos_" + medallionStartNum + "__Image").attr("id", "Photos_" + (medallionStartNum - 1) + "__Image");
    //$("#Photos_" + medallionStartNum + "__Image").attr("name", "Photos[" + (medallionStartNum - 1) + "].Image");
    //$("#Photos_" + medallionStartNum + "__Image").nextElementSibling.attr("for", "Photos_" + (medallionStartNum - 1) + "__Image");
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
    $("#Medallions_" + OurKey + "__Id").attr("id", "Medallions_" + PrevKey + "__Id").attr("name", "Medallions[" + PrevKey + "].Id");
    $("#Medallions_" + OurKey + "__PhotoPath").attr("id", "Medallions_" + PrevKey + "__PhotoPath").attr("name", "Medallions[" + PrevKey + "].PhotoPath");
    $("#Medallions_" + OurKey + "__PhotoName").attr("id", "Medallions_" + PrevKey + "__PhotoName").attr("name", "Medallions[" + PrevKey + "].PhotoName");
    $("#Medallions_" + OurKey + "__DateCompleat").attr("id", "Medallions_" + PrevKey + "__DateCompleat").attr("name", "Medallions[" + PrevKey + "].DateCompleat");
    $("#Medallions_" + OurKey + "__DateBegin").attr("id", "Medallions_" + PrevKey + "__DateBegin").attr("name", "Medallions[" + PrevKey + "].DateBegin");
}
function MedallionIdCreator(idDeceased, idMedallion) {
    return "D" + idDeceased + "M" + idMedallion;
}

function RecalculateNamesAndIdsPhotos(startCount) {
    var prevCount = startCount - 1;
    $("#Photos_" + startCount + "__PhotoKey").attr("id", "Photos_" + prevCount + "__PhotoKey")
        .attr("name", "Photos[" + prevCount + "].PhotoKey");
    $("#Photos_" + startCount + "__Image").attr("id", "Photos_" + prevCount + "__Image")
        .attr("name", "Photos[" + prevCount + "].Image");
    $("#Photos_" + prevCount + "__Image").siblings()[1].attr("for", "Photos_" + prevCount + "__Image");
}
