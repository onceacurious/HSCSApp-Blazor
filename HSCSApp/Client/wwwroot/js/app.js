console.log("App.js is active");

const btn = document.querySelector(".contact-btn");

function msg() {
  alert("Close btn clicked");
}

//Intersection Observer

function myObserver() {
  const sm = document.querySelector(".social-media");
  const footer = document.querySelector(".footer");

  const options = {
    rootMargin: "-20px 0px 0px 0px",
  };
  const observer = new IntersectionObserver(function (entries, observer) {
    entries.forEach((entry) => {
      if (entry.isIntersecting) {
        console.log(entry);
        sm.style.backgroundColor = "black";
      }

      // console.log(entry);
    });
  }, options);

  observer.observe(footer);
  console.log("My observer");
}

function NavChange() {}

// function myObserver(entries, observer) {}
