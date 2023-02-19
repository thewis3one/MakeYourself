// function getBase64(file) {
//     let reader = new FileReader();
//     reader.readAsDataURL(file);
//     reader.onload = function () {
//         console.log(reader.result);
//     };
//     reader.onerror = function (error) {
//         console.log('Error: ', error);
//     };
// }

// let input = document.getElementsByName("file")[0];
// input.addEventListener("change", function () {
//     let fileBase64 = getBase64(input.files[0]);
    
//     fetch('', )
// },false);

let button = document.getElementsByClassName('menu-btn')[0];
console.log(button)
button.addEventListener('click', function (e) {
    e.preventDefault();
    let menu = document.getElementsByClassName('menu')[0];
    menu.classList.toggle('menu-active');
    let content_action = document.getElementsByClassName('content')[0];

    content_action.classList.toggle('content-active');
}, false)
