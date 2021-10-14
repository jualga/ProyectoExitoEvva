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


});