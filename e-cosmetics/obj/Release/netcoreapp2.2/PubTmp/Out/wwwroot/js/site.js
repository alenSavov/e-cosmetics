// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function show() {
    document.getElementById('nav-toggle')
        .classList.toggle('active');
}

function closeToggle() {
    document.getElementById('nav-toggle')
        .classList.remove('active');
}