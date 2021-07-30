console.log("App.js is active");

function NavHeader() {
  const navHead = document.querySelector("#nav-header");
  const collHeader = document.querySelector(".collapse-header");

  if (navHead.classList.contains("hide")) {
    navHead.classList.remove("hide");
    collHeader.classList.remove("hide");
  } else {
    navHead.classList.add("hide");
    collHeader.classList.add("hide");
  }
}
