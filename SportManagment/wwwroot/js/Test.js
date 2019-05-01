var roleid = sessionStorage["RoleID"];
window.onload = function () {
    selectNewTest();
   
    if (roleid === "1") {
        $("#myBtn").show();
    } else {
        $("#myBtn").hide();
    }
};


// Get the modal
var modal = document.getElementById('myModal');

// Get the button that opens the modal
var btn = document.getElementById("myBtn");

// Get the <span> element that closes the modal
var span = document.getElementsByClassName("close")[0];

// When the user clicks the button, open the modal
btn.onclick = function () {
    modal.style.display = "block";
}

// When the user clicks on <span> (x), close the modal
span.onclick = function () {
    modal.style.display = "none";
}

// When the user clicks anywhere outside of the modal, close it
window.onclick = function (event) {
    if (event.target == modal) {
        modal.style.display = "none";
    }
}



$("#SubmitTest").click(function () {
    var Test_Name = $("#exampleSelect1").val();
    var date = $("#Date").val();

    $.ajax({
        type: "POST",
        url: "/Home/InsertTest?Test_Name=" + Test_Name + "&date=" + date,
        contentType: 'application/json; charset=utf-8',
        dataType: 'json',
        success: function (data) {
            

            $("#myModal").hide();
            selectNewTest();

        }
    });

});

function selectNewTest() {
    $.ajax({
        type: "GET",
        url: "/Home/getTest",
        contentType: 'application/json; charset=utf-8',
        dataType: 'json',
        success: function (data) {

            var gvCompany = '';
            var header = '<table  class="table table-hover" id="tblparticipants">' +
                ' <thead> <tr>' +
                '<th>Date</th>' +
                '<th>Number of participants</th>' +
                '<th>Test type</th>' +

                '</tr></thead><tbody>';

            var rows = '';
            for (var i = 0; i < data.Table.length; i++) {

                
                var NewTest_Date = data.Table[i].NewTest_Date;
                var splitdate = NewTest_Date.split("T");
                var NewTestDate = splitdate[0].replace(/[^a-z0-9\s]/gi, '').replace(/[_\s]/g, '-');
                if (roleid === "1") {
                    rows = rows +
                        '<tr>' +
                        '<td><a onclick="EditRowSelect(' + data.Table[i].NewTest_Id + ')"><i style="cursor:pointer;">' + NewTestDate + '</i></a></td>' +
                        '<td><a onclick="EditRowSelect(' + data.Table[i].Test_Name + ')"><i  style="cursor:pointer;">' + data.Table[i].Test_Name + '</i></a></td>' +
                        '<td><a onclick="EditRowSelect(' + data.Table[i].NewTest_Id + ')"><i style="cursor:pointer;">' + data.Table[i].Test_Name + '</i></a></td></tr>';
                } else {
                    rows = rows +
                        '<tr>' +
                        '<td>' + NewTestDate + '</td>' +
                        '<td>' + data.Table[i].Test_Name + '</td>' +
                        '<td>' + data.Table[i].Test_Name + '</tr>';
                }
            }
            gvCompany = header + rows + '</tbody></table>';

            $("#divGrid").empty().append(gvCompany);

        }
    });
}

function EditRowSelect(id) {
    window.location.href = '/DetailsTest/Index/?' + id;
}

$("#btnlogout").click(function () {
    
    sessionStorage.clear();
    window.location.href = '/Home/Logout/';
})