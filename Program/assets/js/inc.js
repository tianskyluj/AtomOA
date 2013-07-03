
// 跳转至其他模块
function redirect(url) {
    $('#mainContent').load(url);
}

$(document).ready(function () {
    // 点击无子页面链接
    $('.accordion-toggle').click(function () {
        var accordions = $('.accordion-toggle');
        accordions.each(function () {
            $(this).removeClass('opened');
        });
        $(this).addClass('opened');
        if($(this).parent().parent().find('li').length==0){
            $(this).parent().parent('.accordion-group').addClass('active');
        }
    });
    
    // 点击子页面
    var li = $('.menu').find('li')
    li.click(function(){
        li.each(function(){
            $(this).removeClass('active');
        });
        $(this).addClass('active');
        
        $('.accordion-group').each(function(){
            $(this).removeClass('active');
        });
        
        $(this).parent().parent('.accordion-group').addClass('active');
    });
});