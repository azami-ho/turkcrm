
window.onscroll = function () { myFunction() };

function myFunction() {
    if (document.body.scrollTop > 50 || document.documentElement.scrollTop > 50) {
        document.getElementById("logo").className = "min-logo";
    } else {
        document.getElementById("logo").className = "max-logo";
    }
    console.log(document.body.scrollTop);
}
