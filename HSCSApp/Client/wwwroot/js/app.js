console.log("App.js is active");

function ShowHeader() {
    const navHead = document.querySelector("#nav-header");
    const collHeader = document.querySelector(".collapse-header");

    navHead.classList.add("show");
    collHeader.classList.add("show");
}

function HideHeader() {
    const navHead = document.querySelector("#nav-header");
    const collHeader = document.querySelector(".collapse-header");

    navHead.classList.remove("show");
    collHeader.classList.remove("show");
}