$(function () {
    $('input[name="birthday"]').daterangepicker({
        singleDatePicker: true,
        showDropdowns: true,
        maxYear: parseInt(moment().format('YYYY'), 10)
    }, function (start, end, label) {

    });
});