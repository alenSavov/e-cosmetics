


/*Hamburger*/
$(document).ready(function () {
    $('.icon').click(function () {
        $('.icon').toggleClass('active');

        setTimeout(function () {
            document.getElementById('nav-toggle')
                .classList.toggle('active');
        }, 500);
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

