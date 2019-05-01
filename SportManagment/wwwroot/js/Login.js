window.onload = function () {
    var modal = document.getElementById('myModal');
    modal.style.display = "block";
};

$("#BtnLogin").click(function () {
    var UserName = $("#UserName").val();
    var Password = $("#Password").val();
    $.ajax({
        type: "POST",
        url: "/Home/Login?UserName=" + UserName + "&Password=" + Password,
        contentType: 'application/json; charset=utf-8',
        dataType: 'json',
        success: function (data) {
            if (data.Table.length > 0) {
                console.log(data.Table[0].Users_RoleID);
                sessionStorage["RoleID"] = data.Table[0].Users_RoleID;
                window.location.href = '/Home/Index/';
            }
            else {
                swal("Wrong credential");
            }
            
        }
    });
});