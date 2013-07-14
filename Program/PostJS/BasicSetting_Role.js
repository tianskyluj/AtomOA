
  $(function() {
    var options_elastic, tagit_options;
    $(".chzn-select").chosen({
      width: '95%'
    });
    $(".chzn-select-deselect").chosen({
      allow_single_deselect: true
    });
});

/* Set the defaults for DataTables initialisation */
$.extend(true, $.fn.dataTable.defaults, {
    "sDom": "<'row-fluid'<'span6'l><'span6'f>r>t<'row-fluid'<'span6'i><'span6'p>>",
    "sPaginationType": "bootstrap",
    "oLanguage": {
        "sLengthMenu": "_MENU_ records per page"
    }
});


/* Default class modification */
$.extend($.fn.dataTableExt.oStdClasses, {
    "sWrapper": "dataTables_wrapper form-inline"
});


/* API method to get paging information */
$.fn.dataTableExt.oApi.fnPagingInfo = function (oSettings) {
    return {
        "iStart": oSettings._iDisplayStart,
        "iEnd": oSettings.fnDisplayEnd(),
        "iLength": oSettings._iDisplayLength,
        "iTotal": oSettings.fnRecordsTotal(),
        "iFilteredTotal": oSettings.fnRecordsDisplay(),
        "iPage": oSettings._iDisplayLength === -1 ?
			0 : Math.ceil(oSettings._iDisplayStart / oSettings._iDisplayLength),
        "iTotalPages": oSettings._iDisplayLength === -1 ?
			0 : Math.ceil(oSettings.fnRecordsDisplay() / oSettings._iDisplayLength)
    };
};


/* Bootstrap style pagination control */
$.extend($.fn.dataTableExt.oPagination, {
    "bootstrap": {
        "fnInit": function (oSettings, nPaging, fnDraw) {
            var oLang = oSettings.oLanguage.oPaginate;
            var fnClickHandler = function (e) {
                e.preventDefault();
                if (oSettings.oApi._fnPageChange(oSettings, e.data.action)) {
                    fnDraw(oSettings);
                }
            };

            $(nPaging).addClass('pagination').append(
				'<ul>' +
					'<li class="prev disabled"><a href="#">&larr; ' + oLang.sPrevious + '</a></li>' +
					'<li class="next disabled"><a href="#">' + oLang.sNext + ' &rarr; </a></li>' +
				'</ul>'
			);
            var els = $('a', nPaging);
            $(els[0]).bind('click.DT', { action: "previous" }, fnClickHandler);
            $(els[1]).bind('click.DT', { action: "next" }, fnClickHandler);
        },

        "fnUpdate": function (oSettings, fnDraw) {
            var iListLength = 5;
            var oPaging = oSettings.oInstance.fnPagingInfo();
            var an = oSettings.aanFeatures.p;
            var i, ien, j, sClass, iStart, iEnd, iHalf = Math.floor(iListLength / 2);

            if (oPaging.iTotalPages < iListLength) {
                iStart = 1;
                iEnd = oPaging.iTotalPages;
            }
            else if (oPaging.iPage <= iHalf) {
                iStart = 1;
                iEnd = iListLength;
            } else if (oPaging.iPage >= (oPaging.iTotalPages - iHalf)) {
                iStart = oPaging.iTotalPages - iListLength + 1;
                iEnd = oPaging.iTotalPages;
            } else {
                iStart = oPaging.iPage - iHalf + 1;
                iEnd = iStart + iListLength - 1;
            }

            for (i = 0, ien = an.length; i < ien; i++) {
                // Remove the middle elements
                $('li:gt(0)', an[i]).filter(':not(:last)').remove();

                // Add the new list items and their event handlers
                for (j = iStart; j <= iEnd; j++) {
                    sClass = (j == oPaging.iPage + 1) ? 'class="active"' : '';
                    $('<li ' + sClass + '><a href="#">' + j + '</a></li>')
						.insertBefore($('li:last', an[i])[0])
						.bind('click', function (e) {
						    e.preventDefault();
						    oSettings._iDisplayStart = (parseInt($('a', this).text(), 10) - 1) * oPaging.iLength;
						    fnDraw(oSettings);
						});
                }

                // Add / remove disabled classes from the static elements
                if (oPaging.iPage === 0) {
                    $('li:first', an[i]).addClass('disabled');
                } else {
                    $('li:first', an[i]).removeClass('disabled');
                }

                if (oPaging.iPage === oPaging.iTotalPages - 1 || oPaging.iTotalPages === 0) {
                    $('li:last', an[i]).addClass('disabled');
                } else {
                    $('li:last', an[i]).removeClass('disabled');
                }
            }
        }
    }
});


/*
* TableTools Bootstrap compatibility
* Required TableTools 2.1+
*/
if ($.fn.DataTable.TableTools) {
    // Set the classes that TableTools uses to something suitable for Bootstrap
    $.extend(true, $.fn.DataTable.TableTools.classes, {
        "container": "DTTT btn-group",
        "buttons": {
            "normal": "btn",
            "disabled": "disabled"
        },
        "collection": {
            "container": "DTTT_dropdown dropdown-menu",
            "buttons": {
                "normal": "",
                "disabled": "disabled"
            }
        },
        "print": {
            "info": "DTTT_print_info modal"
        },
        "select": {
            "row": "active"
        }
    });

    // Have the collection use a bootstrap compatible dropdown
    $.extend(true, $.fn.DataTable.TableTools.DEFAULTS.oTags, {
        "collection": {
            "container": "ul",
            "button": "li",
            "liner": "a"
        }
    });
}

/* Get the rows which are currently selected */
function fnGetSelected(oTableLocal) {
    return oTableLocal.$('tr.info');
}

// 初始化列表

$(document).ready(function () {
    var oTable;


    /* Add a click handler to the rows - this could be used as a callback */
    $("#listTable tbody").on('click', 'tr', function (e) {
        if ($(this).hasClass('info')) {
            $(this).removeClass('info').removeClass('text-success');
            $("#delete-row").addClass("disabled");
            $("#modify-row").addClass("disabled");
            $('#id').val('0');
        }
        else {
            oTable.$('tr.info').removeClass('info');
            $(this).addClass('info').addClass('text-success');
            if ($(this).find('#dataId').html() != undefined) {
                $("#delete-row").removeClass("disabled");
                $("#modify-row").removeClass("disabled");
                $('#id').val($(this).find('#dataId').html());
            }
        }
    });

    /* Init the table */
    oTable = $('#listTable').dataTable({
        "sDom": "<'row-fluid'<'span6'l><'span6'f>r>t<'row-fluid'<'span6'i><'span6'p>>",
        "sPaginationType": "bootstrap",
        "oLanguage": {
            "sProcessing": "处理中...",
            "sLengthMenu": "显示 _MENU_ 项结果",
            "sZeroRecords": "没有匹配结果",
            "sInfo": "显示第 _START_ 至 _END_ 项结果，共 _TOTAL_ 项",
            "sInfoEmpty": "显示第 0 至 0 项结果，共 0 项",
            "sInfoFiltered": "(由 _MAX_ 项结果过滤)",
            "sInfoPostFix": "",
            "sSearch": "搜索:",
            "sUrl": "",
            "oPaginate": {
                "sFirst": "首页",
                "sPrevious": "上页",
                "sNext": "下页",
                "sLast": "末页"
            }
        },
        "aaSorting": [[1, "asc"]],
        "aoColumnDefs": [
	          { 'bSortable': false, 'aTargets': [0] }
	       ]
    });



    $('#toggle-checkboxes').click(function () {
        var $checkbox = $("table").find(':checkbox');
        if ($(this).attr('checked')) {
            $checkbox.attr('checked', true);
        } else {
            $checkbox.attr('checked', false);
        }
    });
    /***********************************************************
    *   高级查询
    *************************************************************/
    // 控制页面操作

    // 弹出高级查询表单
    // 添加数据行
    $('#btn-advanced').click(function () {
        $('#advanced_search').modal('show');
    });

    // 高级查询
    $('#confirmSearch').click(function () {
        $('#advanced_search').modal('hide');
        $('#mainContent').load(
            '../Web/BasicSetting/Province.aspx',                              // 这里修改服务器提交位置
            {
            "provinceName": $('#provinceName_search').val(),                 // 这里修改查询提交参数
            "provinceNameIfAccurate": $('#provinceName_check_search').is(":checked"),
            "remark": $('#remark_search').val(),
            "remarkIfAccurate": $('#remark_check_search').is(":checked")
        }
        );
    });

    /***********************************************************
    *   添加数据
    *************************************************************/

    // 弹出添加数据行表单
    $('#add-row').click(function () {
        $('#addAndUpdateTitle').html('添加');
        $('#addAndUpdate').modal('show');
        clearForm();
    });

    // 确定添加修改数据行
    $('#confirmSave').click(function () {
        update();
    });

    /***********************************************************
    *   修改数据
    *************************************************************/

    // 弹出添加数据行表单
    $('#modify-row').click(function () {
        if ($("#modify-row").hasClass("disabled")) {
            return false;
        }
        else {
            $('#addAndUpdateTitle').html('修改');
            getModelValue();
            $('#addAndUpdate').modal('show');
        }
    });

    /***********************************************************
    *   删除数据
    *************************************************************/
    /* Add a click handler for the delete row */
    $('#delete-row').click(function () {
        if ($("#delete-row").hasClass("disabled")) {
            return false;
        }
        else {
            var anSelected = fnGetSelected(oTable);
            if (anSelected.length !== 0) {
                oTable.fnDeleteRow(anSelected[0]);
                $(this).addClass("disabled");
                $("#modify-row").addClass("disabled");
            }
            deleteModel();
        }
    });
});

/***********************************************************
*   自定义函数
*************************************************************/

// 初始化表单
function clearForm(){                                                              // 这里修改初始化表单
    $('#id').val('0');
    initMultiSelect('.province_edit');
    $('#department_edit').val('');
    $('#remark_edit').val('');
}

// 添加或或修改数据行函数
function update() {
    var provinceSelectOptions = getMultiSelectValue('.province_edit');
    if ($('#roleName_edit').val().length == 0) {
        showError("请填写角色名称");
        return false;
    }
    if (provinceSelectOptions.length == 0)                            // 这里修改控制判断语句
    {
        showError("请选择省份");
        return false;
    }
    var data = '{'                                                                  // 这里修改取数位置
                + ' id: "' + $('#id').val() + '"'
                + ',roleName: "' + $('#roleName_edit').val() + '"'
                + ',provinceIds: "' + provinceSelectOptions + '"'
                + ',remark:"' + $('#remark_edit').val() + '" '
                + '}'; 
    $.ajax({
        type: "POST",
        url: "../Web/BasicSetting/Role.aspx/update",                          // 这里要修改服务器提交位置
        data: data,
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (json) {
            if (json.d == "1") {
                $('#addAndUpdate').modal('hide');
                $('#mainContent').load('../Web/BasicSetting/Role.aspx');      // 这里要修改服务器提交位置
                showSuccess("操作成功");
            }
            else showError("操作出错:" + json.d);
        },
        error: function (error) {
            alert("调用出错" + error.responseText);
        }
    });
}

// 修改的记录赋值

function getModelValue()
{
    var data = '{'
                + ' id: "' + $('#id').val() + '"'
                + '}'; 
    $.ajax({
        type: "POST",
        url: "../Web/BasicSetting/Province.aspx/getModelValue",       // 这里要修改服务器提交位置
        data: data,
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (data) {
             data = jQuery.parseJSON(data.d);
                $.each(data, function (i, item) {
                    $('#provinceName_edit').val(item.ProvinceName); // 这里要修改赋值,注意DepartmentName 首字母大写
                    $('#remark_edit').val(item.Remark);
                })
        },
        error: function (error) {
            alert("调用出错" + error.responseText);
        }
    });
}


// 删除记录
function deleteModel(){
    var data = '{'
                + ' id: "' + $('#id').val() + '"'
                + '}'; 
    $.ajax({
        type: "POST",
        url: "../Web/BasicSetting/Province.aspx/deleteModel",       // 这里要修改服务器提交位置
        data: data,
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (json) {
             if (json.d == "1") {
                showSuccess("操作成功");
            }
            else showError("操作出错:" + json.d);
        },
        error: function (error) {
            alert("调用出错" + error.responseText);
        }
    });
}



