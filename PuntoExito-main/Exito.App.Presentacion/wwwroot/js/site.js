// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.
$(document).ready(function() {
    $("#UDoc").on("keyup", function() {
        console.log("pressed: " + $("#UDoc").val())
        $("#UPassword").val($("#UDoc").val());
    });
    $("#Bsubmenu").on("click", function() {
        document.getElementsByClassName("submenu")[0].classList.toggle("hide");
    });
    let indexs = location.href.split('/');
    if (indexs.length === 4) {
        let last = indexs[indexs.length - 1];
        $('.' + last).addClass("i-active");
        console.log("4" + last)
    }
    if (indexs.length === 5) {
        let last = indexs[indexs.length - 2];
        $('.' + last).addClass("i-active");
        console.log("5" + last)

    }



});