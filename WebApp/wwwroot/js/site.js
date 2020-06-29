
window.onscroll = function () { myFunction() };

function myFunction() {
    if (document.body.scrollTop > 50 || document.documentElement.scrollTop > 50) {
        document.getElementById("logo").className = "min-logo";
        document.getElementById("main-nav").className = "main-nav-scroll";
    } else {
        document.getElementById("logo").className = "max-logo";
        document.getElementById("main-nav").className = "main-nav";

    }
    console.log(document.body.scrollTop);
}

function ResponsiveMenu() {
    var x = document.getElementById("menu");
    if (x.className === "menu") {
        x.className += " responsive";
    } else {
        x.className = "menu";
    }
}

function CloseMenu() {
    var x = document.getElementById("menu");
    x.className = "menu";
}