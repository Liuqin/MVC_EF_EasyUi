

define(function (require, exports, module) {
    //引入必须的css和js文件
    require("jquery");

    var confirmDiv, alertDiv;//遮罩层DIV
    confirmDiv = '<div id="confirm" style="width:100%;height:100%;z-index:99999; position:absolute;display:none; top:0px;background-color:rgba(0,0,0,0.5)!important; background:#000; filter:alpha(opacity=50); *background:#000; *filter:alpha(opacity=50);">' +
                    '<div class="tip">' +
                        '<div class="tipTop">' +
                            '<span class="title"></span>' +
                            '<a class="close"></a>' +
                        '</div>' +
                        '<div class="tipCenter">' +
                            '<span class="message"></span>' +
                        '</div>' +
                            '<div class="tipBottom">' +
                                '<input type="button" class="confirm" />&nbsp;' +
                                '<input type="button" class="cancel" />' +
                            '</div>' +
                        '</div>' +
                    '</div>' +
                 '</div>';
    alertDiv = '<div id="alert" style="width:100%;height:100%;z-index:99999;position:absolute;display:none; top:0px;background-color:rgba(0,0,0,0.5)!important; background:#000; filter:alpha(opacity=50); *background:#000; *filter:alpha(opacity=50);">' +
                    '<div class="tip">' +
                        '<div class="tipTop">' +
                            '<span class="title"></span>' +
                            '<a class="close"></a>' +
                        '</div>' +
                        '<div class="tipCenter">' +
                            '<span class="message"></span>' +
                        '</div>' +
                            '<div class="tipBottom">' +
                                '<input type="button" class="confirm" />' +
                            '</div>' +
                        '</div>' +
                    '</div>' +
                 '</div>';
    /*使用示例：
     $.NpMessage({type:'alert',title:'123',msg:'123',onconfirm:function(){}}).show();
     */
    exports.Message = function (options) {
        var option = $.extend({
            type: '',   //输出框类型（confirm/alert）
            height: '100%',
            title: '',  //标题
            msg: '',    //显示的信息
            onconfirm: function () { },
            oncancel: function () { },
            onclose: function () { }
        }, options);

        var that, body;
        body = $(document.body);//在哪一层显示
        $(body).css('position', 'relative');
        //确认框（confirm）
        if (option.type === "confirm") {
            that = $('#confirm');//DIV的id=confirm
            if (that.length === 0) {
                that = $(confirmDiv).appendTo(body).hide();//将DIV加入到body中
            }
        } else {//提示框（alert）
            that = $('#alert');//DIV的id=alert
            if (that.length === 0) {
                that = $(alertDiv).appendTo(body).hide();
            }
        }
        $(that).css("top", body.scrollTop || document.documentElement.scrollTop);
        $(that).height(option.height);
        //初始化并赋值
        //右上角的关闭按钮，class=close
        $(".close", that).click(function () {
            option.onclose();
            this.hide();//触发事件后隐藏掉
        }.bind(that));
        //确定按钮，input的class=confirm
        $(".confirm", that).click(function () {
            option.onconfirm();
            this.hide();
        }.bind(that));
        //取消按钮(询问框才会有)，input的class=cancel
        if (option.type === "confirm") {
            $(".cancel", that).click(function () {
                option.oncancel();
                this.hide();
            }.bind(that));
        }
        //标题title
        $(".title", that).html(option.title);
        //显示消息msg
        $(".message", that).html(option.msg);
        //最终显示图层
        return {
            box: that,
            show: function () {
                $(this.box).show();
                return this;
            }
        };
    }
    
});