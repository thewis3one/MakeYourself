let button = document.getElementById("Button_submit");

let label = document.createElement("label");
label.className = "message";
label.innerHTML = "Данный логин уже занят";

let select = document.getElementsByName("buildTypeId")[0];

button.addEventListener("click", function () {

    if (document.querySelector(".message") !== null) {
        setTimeout(() => {
            const willBeRemoved = document.querySelector(".message");
            willBeRemoved.parentElement.removeChild(willBeRemoved);
        }, 2);
    }

    let client = {
        fio: document.getElementsByName('fio')[0].value,
        dateOfBirth: document.getElementsByName('dateOfBirth')[0].value,
        weight: document.getElementsByName('weight')[0].value,
        height: document.getElementsByName('height')[0].value,
        login: document.getElementsByName('login')[0].value,
        password: document.getElementsByName('password')[0].value,
        buildTypeId: document.getElementsByName('buildTypeId')[0].value
    };

    fetch('https://localhost:7291/register', {
        method: 'POST',
        headers: {
            'Content-type': 'application/json;charset=utf-8'
        },
        body: JSON.stringify(client)
    })
        .then((response) => response.json())
        .then((data) => console.log(data))
        .catch(() => select.insertAdjacentElement("afterend", label))

}, false);