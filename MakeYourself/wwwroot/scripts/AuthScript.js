let button = document.getElementById("Button_submit");

let label = document.createElement("label");
label.className = "message";
label.innerHTML = "Неверный логин или пароль";

let passwrd = document.getElementsByName('password')[0];

button.addEventListener("click", function () {
    
    if (document.querySelector(".message") !== null)
    {
        setTimeout(() => {
            const willBeRemoved = document.querySelector(".message");
            willBeRemoved.parentElement.removeChild(willBeRemoved);
        }, 2);
        }

    let client = {
        login: document.getElementsByName('login')[0].value,
        password: document.getElementsByName('password')[0].value
    };

    fetch('https://localhost:7291/auth', {
        method: 'POST',
        headers: {
            'Content-type': 'application/json;charset=utf-8'
        },
        body: JSON.stringify(client)
    })
        .then((response) => response.json())
        .then((data) => console.log(data))
        .catch(() => passwrd.insertAdjacentElement("afterend", label))
},
    false);