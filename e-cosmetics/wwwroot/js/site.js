// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(document).ready(function () {
    $('.icon').click(function () {
        $('.icon').toggleClass('active');

        setTimeout(function () {
            document.getElementById('nav-toggle')
                .classList.toggle('active');
        }, 1000);
    })
})

//function show() {
//    document.getElementById('nav-toggle')
//        .classList.toggle('active');
//}

function closeToggle() {
    document.getElementById('nav-toggle')
        .classList.remove('active');

    $('.icon').toggleClass('active');
}