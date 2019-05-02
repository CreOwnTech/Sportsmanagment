// ON LOAD EVENT
window.onload = function () {
    url = window.location.href;
    if (url.split("?").length > 0) {
        query = url.split("?")[1];
        selectTestDetails(query);
        selectTitle(query);
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
    clear();
    $("#btnDeleteAthelet").hide();
    sessionStorage["id"] = "";
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


// ADD NEW ATHLETE TO TEST
$("#SubmitTestDetail").click(function () {
    var Ranking = $("#Ranking").val();
    var Distance = $("#Distance").val();
    if (sessionStorage["id"] != "") {
        $.ajax({
            type: "POST",
            url: "/DetailsTest/UpdateTestDetail?Ranking=" + Ranking + "&Distance=" + Distance + "&NewTest_Id=" + query + "&id=" + sessionStorage["id"],
            contentType: 'application/json; charset=utf-8',
            dataType: 'json',
            success: function (data) {
                $("#myModal").hide();
                selectTestDetails(query);
            }
        });
    }
    else {
        $.ajax({
            type: "POST",
            url: "/DetailsTest/InsertTestDetail?Ranking=" + Ranking + "&Distance=" + Distance + "&NewTest_Id=" + query,
            contentType: 'application/json; charset=utf-8',
            dataType: 'json',
            success: function (data) {
                $("#myModal").hide();
                selectTestDetails(query);
            }
        });
    }


});

// CLEAR DATA FROM DROP DOWN WHEN ADD NEW DATA
function clear() {
    $("#Ranking").val("");
    $("#Distance").val("");

}

// SAVE ATHLETE TO TEST AFTER EDIT
function selectTestDetails(query) {
    $.ajax({
        type: "GET",
        url: "/DetailsTest/GetTestDetail?Id=" + query,
        contentType: 'application/json; charset=utf-8',
        dataType: 'json',
        success: function (data) {
            
            var gvCompany = '';
            var header = '<table  class="table table-hover">' +
                ' <thead> <tr>' +
                '<th>Ranking</th>' +
                '<th>Distance (meter)</th>' +
                '<th>Fitness rating</th>' +

                '</tr></thead><tbody>';

            var rows = '';
            for (var i = 0; i < data.Table.length; i++) {
                
                var Fitnes = String.empty;

                if (data.Table[i].Distance <= 1000) {
                    Fitnes = "Below Average";
                }
                if (data.Table[i].Distance > 1000 && data.Table[i].Distance <= 2000) {
                    Fitnes = "Average";
                }
                if (data.Table[i].Distance > 2000 && data.Table[i].Distance <= 3500) {
                    Fitnes = "Good";
                }
                if (data.Table[i].Distance > 3500) {
                    Fitnes = "Very Good";
                }
                rows = rows +
                    '<tr>' +
                    '<td><a onclick="EditRowSelect(' + data.Table[i].Id + ')"><i  style="cursor:pointer;">' + data.Table[i].Ranking + '</i></a></td>' +
                    '<td><a onclick="EditRowSelect(' + data.Table[i].Id + ')"><i  style="cursor:pointer;">' + data.Table[i].Distance + '</i></a></td>' +
                    '<td><a onclick="EditRowSelect(' + data.Table[i].Id + ')"><i   style="cursor:pointer;">' + Fitnes + '</i></a></td></tr>';
            }
            gvCompany = header + rows + '</tbody></table>';

            $("#divGrid").empty().append(gvCompany);

        }
    });


}

// SELECT ATHLETE TO TEST FOR EDIT
function EditRowSelect(id) {
    sessionStorage["id"] = id;
    $("#btnDeleteAthelet").show();
    $.ajax({
        type: "GET",
        url: "/DetailsTest/edittest?id=" + id,
        contentType: 'application/json; charset=utf-8',
        dataType: 'json',
        success: function (data) {
            
            $("#Ranking").val(data.Table[0].Ranking);
            $("#Distance").val(data.Table[0].Distance);

            $("#myModal").show();


        }
    });
}


// DELET TEST WITH ATHLETE 
$("#deletetest").click(function () {
    swal({
        title: "Are you sure?",
        text: "Once deleted, you will not be able to recover this data file!",
        icon: "warning",
        buttons: true,
        dangerMode: true,
    })
        .then((willDelete) => {
            if (willDelete) {
                swal("Your data file has been deleted!", {
                    icon: "success",
                });

                $.ajax({
                    type: "Post",
                    url: "/DetailsTest/deletetest?id=" + query,
                    contentType: 'application/json; charset=utf-8',
                    dataType: 'json',
                    success: function (data) {

                        window.location.href = '/Home/Index/';

                    }
                });
            } else {
                swal("Your data file is safe!");
            }
        });



});

// DELET ONLY ATHLETE 
$("#btnDeleteAthelet").click(function () {
    swal({
        title: "CONFIRM",
        text: "Do you want to delete this athlete from the test !",
        icon: "warning",
        buttons: true,
        dangerMode: true,
    })
        .then((willDelete) => {
            if (willDelete) {
                swal("Your data file has been deleted!", {
                    icon: "success",
                });

                $.ajax({
                    type: "Post",
                    url: "/DetailsTest/DeleteAthelet?id=" + sessionStorage["id"],
                    contentType: 'application/json; charset=utf-8',
                    dataType: 'json',
                    success: function (data) {
                        selectTestDetails(query);
                        $("#myModal").hide();


                    }
                });
            } else {
                swal("Your data file is safe!");
            }
        });



});

// SELECT TITLE
function selectTitle(query) {
    $.ajax({
        type: "GET",
        url: "/DetailsTest/gettitle?Id=" + query,
        contentType: 'application/json; charset=utf-8',
        dataType: 'json',
        success: function (data) {
            var NewTest_Date = data.Table[0].NewTest_Date;
            var splitdate = NewTest_Date.split("T");
            var NewTestDate = splitdate[0].replace(/[^a-z0-9\s]/gi, '').replace(/[_\s]/g, '-');
            var Test_Name = data.Table[0].Test_Name.toUpperCase();
            $("#headtitle").text(Test_Name +' '+'D.'+ NewTestDate);
           
        }
    });


}

// LOGOUT 

$("#btnlogout").click(function () {
    sessionStorage.clear();
    window.location.href = '/Home/Logout/';
})