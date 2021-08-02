console.log("App.js is active");

function ShowHeader() {
  const navHead = document.querySelector("#nav-header");
  const collHeader = document.querySelector(".collapse-header");

  navHead.classList.add("nav-show");
  collHeader.classList.add("nav-show");
}

function HideHeader() {
  const navHead = document.querySelector("#nav-header");
  const collHeader = document.querySelector(".collapse-header");

  navHead.classList.remove("nav-show");
  collHeader.classList.remove("nav-show");
}

//Individual Event Listener
