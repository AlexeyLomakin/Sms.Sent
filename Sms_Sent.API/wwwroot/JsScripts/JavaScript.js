//получение всех смс
async function GetAllSms() {
    const response = await fetch("api/sms",
        {
            method: "GET",
            headers: { "Accept": "application/json" }
        });
    if (response.ok == true) {
        const smsResp = await response.json();
        let rows = document.querySelector("tbody");
        smsResp.forEach(sms => 
            //добавление полученных элементов в таблицу
            rows.append(row(sms))
        )
    };
}
//Добавление СМС
async function PostSms(RecepientPhone, Text) {

    const response = await fetch("api/sms", {
        method: "POST",
        headers: { "Accept": "application/json", "Content-Type": "application/json" },
        body: JSON.stringify({
            recepientPhone: RecepientPhone,
            smsText: Text
        })
    });
    if (response.ok === true) {
        const sms = await response.json();
        reset();
        document.querySelector("tbody").append(row(sms));
    }
    else {
        const errorData = await response.json();
        console.log("errors", errorData);
        document.getElementById("errors").style.display = "block";
    }
}
//отрисовка смс в таблице
function row(sms) {
    const tr = document.createElement("tr");
    tr.setAttribute("data-rowid", sms.id);

    const dateTD = document.createElement("td");
    dateTD.append(sms.dateSend);
    tr.append(dateTD);

    const phoneTd = document.createElement("td");
    phoneTd.append(sms.recepientPhone);
    tr.append(phoneTd);

    const textTd = document.createElement("td");
    textTd.append(sms.smsText);
    tr.append(textTd);

    const statusTd = document.createElement("td");
    statusTd.append(sms.smsStatus);
    tr.append(statusTd);

    const linksTd = document.createElement("td");
    tr.appendChild(linksTd);

    return tr;
}