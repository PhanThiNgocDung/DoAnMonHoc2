$(document).ready(function () {
    loadData();
});

//function loadData()
//{
//    $.ajax({
//        url: "/Food/listFood",
//        type: "GET",
//        contentType: "application/json;charset=utf-8",
//        dataType: "json",
//        success: function (result) {
//            var html = '';
//            $.each(result, function (key, item) {
//                html += '<tr>';
//                html += '<td>' + item.id + '</td>';
//                html += '<td>' + item.name + '</td>';
//                html += '<td>' + item.type + '</td>';
//                html += '<td>' + item.price + '</td>';
//                html += '<td><a href="#" onclick="getbyID('+ item.id +')">Edit </a>|' + '<a href="#" onclick="Delete(' + item.id + ')"> Delete</a></td>';
//                html += '</tr>';
//            });
//            $('.tbody').html(html);
//        },
//        error: function (errormessage)
//        { alert(errormessage.responseText); }
//    });
//}

//function Add()
//{
//    var empObj = {
//        id: $('#ID').val(),
//        name: $('#Name').val(),
//        type: $('#Type').val(),
//        price: $('#Price').val(),
//    };
//    $.ajax({
//        url: "/Food/Add",
//        data: JSON.stringify(empObj),
//        type: "POST",
//        contentType: "application/json;charset=utf-8",
//        dataType: "json",
//        success: function (result)
//        {
//            loadData();
//            $('#myModal').modal('hide');
//        },
//        error: function (errormessage)
//        { alert(errormessage.responseText); }
//    });
//}

//function getbyID(EmpID)
//{
//    $('#Name').css('border-color', 'lightgrey');
//    $('#Type').css('border-color', 'lightgrey');
//    $('#Price').css('border-color', 'lightgrey');
//    $.ajax({
//        url: "/Food/GetbyID/"+EmpID,
//        type: "GET",
//        contentType: "application/json;charset=utf-8",
//        dataType: "json",
//        success: function (result) {         
//            $('#ID').val(result.id);
//            $('#Name').val(result.name);
//            $('#Type').val(result.type);
//            $('#Price').val(result.price);
//            $('#myModal').modal('show');
//            $('#btnUpdate').show();
//            $('#btnAdd').hide();
//        },
//        error: function (errormessage)
//        { alert(errormessage.responseText); }
//    });
//    return false;
//}
function Update()
{
    var empObj = {
        id: $('#MaTin').val(),
        name: $('#TieuDe').val(),
        type: $('#NoiDung').val(),
        price: $('#NgayTao').val(),
    };
    $.ajax({
        url: "/Food/Update",
        data: JSON.stringify(empObj),
        type: "POST",
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        success: function (result) {
            loadData();
            $('#myModal').modal('hide');
            $('#MaTin').val("");
            $('#TieuDe').val("");
            $('#NoiDung').val("");
            $('#NgayTao').val("");
        },
        error: function (errormessage)
        { alert(errormessage.responseText); }
    });
}