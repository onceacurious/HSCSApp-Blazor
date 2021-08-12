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

function QuoteShow() {
    const quote = document.querySelector(".quotation");

    if (quote.classList.contains("_hide-quote")) {
        quote.classList.remove("_hide-quote");
        quote.classList.add("_show-quote");
    }
    else {
        quote.classList.add("_show-quote");
    }
}

function QuoteHide() {
    const quote = document.querySelector(".quotation");

    if (quote.classList.contains("_show-quote")) {
        quote.classList.remove("_show-quote");
        quote.classList.add("_hide-quote");
    }
}

function QuoteTitle() {
    const title = document.querySelector("#Title");
    const icon = document.querySelector("#quoteIcon");

    title.innerText = "Quotation Form";
    icon.src = "images/quote_icon.png";
}

function GetElementId() {
    const btn = document.querySelector(".btn-img-overlay");
    btn.classList.add("_test");
}