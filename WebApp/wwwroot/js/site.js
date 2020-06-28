
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
    var x = document.getElementById("myTopnav");
    if (x.className === "topnav") {
        x.className += " responsive";
    } else {
        x.className = "topnav";
    }
}