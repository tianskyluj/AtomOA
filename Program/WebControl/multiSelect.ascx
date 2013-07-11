<%@ Control Language="C#" AutoEventWireup="true" CodeFile="multiSelect.ascx.cs" Inherits="WebControl_multiSelect" %>
<script type="text/javascript">
    $(function () {
        var str = $("#<%= this.defaultText.ClientID %>").html();
        // 多选下拉框
        var select = $("#<%= this.multiSelect.ClientID %>");
        select.multiselect({
            includeSelectAllOption: true,
            buttonText: function (options) {
                if (options.length == 0) {
                    return '' + str + ' <b class="caret"></b>';
                }
                else if (options.length > 3) {
                    return options.length + ' 项被选中  <b class="caret"></b>';
                }
                else {
                    var selected = '';
                    options.each(function () {
                        selected += $(this).text() + ', ';
                    });
                    return selected.substr(0, selected.length - 2) + ' <b class="caret"></b>';
                }
            }
        });
        
        setValue();
         setCss();
    });

    function getValue() {
        var select = $("#<%= this.multiSelect.ClientID %>");
        var lis = select.find('li');
        var value = '';
        lis.each(function () {
            if ($(this).hasClass('active')) {
                value += $(this).find('input').val() + ',';
            }
        });
        $("#<%= this.selectedValue.ClientID %>").html(value);
    }

    function setValue() {
        var select = $("#<%= this.multiSelect.ClientID %>");
        var value = $("#<%= this.selectedValue.ClientID %>").html(); 
        var values = value.trim().split(',');
        for (var i = 0; i < values.length; i++) {
            var input = select.parent().find('input');
            input.each(function(){
                if($(this).val()==values[i])
                    $(this).click();
            });
        }
    }
    
    function setCss(){
        var select = $("#<%= this.multiSelect.ClientID %>");
        var cssText = $("#<%= this.lblclass.ClientID %>").html()
        select.addClass(cssText);
    }

</script>
<select id="multiSelect" class="multiSelect" multiple="true" runat="server">
	
</select>
<asp:Label ID="defaultValue" runat="server" Text="0" Visible="false"></asp:Label>
<asp:Label ID="defaultText" runat="server" Text="请选择" CssClass="hidden"></asp:Label>
<asp:Label ID="ifAutoPostBack" runat="server" Text="0" Visible="false"></asp:Label>
<asp:Label ID="oldText" runat="server" Text="" CssClass="hidden"></asp:Label>
<asp:Label ID="selectedValue" runat="server"  CssClass="hidden"></asp:Label>
<asp:Label ID="lblclass" runat="server"  CssClass="hidden"></asp:Label>