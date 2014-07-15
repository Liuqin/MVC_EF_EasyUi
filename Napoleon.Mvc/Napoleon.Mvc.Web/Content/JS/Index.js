define(function (require, exports, module) {
    //引入必须的css和js文件
    require("jquery");

    //#region 设置左边菜单的动画
    /*设置活动样式*/
    exports.SetSubmenu = function () {
        $(".submenu li.active").removeClass("active");
        $(this).addClass("active");
    };
    /*设置动画*/
    exports.SlideMenu = function () {
        var $ul = $(this).next('ul');
        $('dd').find('ul').slideUp();
        if ($ul.is(':visible')) {
            $(this).next('ul').slideUp();
        } else {
            $(this).next('ul').slideDown();
        }
    };
    //#endregion
});