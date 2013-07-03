
// 跳转至其他模块
function redirect(url) {
    $('#mainContent').load(url);
}

$(document).ready(function () {
    $('.accordion-toggle').click(function () {
        var accordions = $('.accordion-toggle');
        accordions.each(function () {
            $(this).removeClass('opened');
        });
        $(this).addClass('opened');
    });
});