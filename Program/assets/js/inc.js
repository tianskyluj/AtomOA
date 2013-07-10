
// 跳转至其他模块
function redirect(url) {
    $('#mainContent').load(url);
}

// 获取多选下拉列表的值的字符串，形如：1，2，3，4 
function getMultiSelectValue (obj){
    var valusString = '';
    var select = obj;
    var lis = select.find('li');
    var value = '';
    lis.each(function () {
        if ($(this).hasClass('active')) {
            value += $(this).find('input').val() + ',';
        }
    });
    return valusString.trim(',');
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