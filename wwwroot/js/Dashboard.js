// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(function () {
    $('.DayInfo').hide();
    $('#One .DayInfo').show();

    $('#One').click(function () {
        if ($('.DayInfo').is(":visible")) {
            $('.DayInfo').slideUp();
        }
        $('#One .DayInfo').slideDown();
    })

    $('#Two').click(function () {
        if ($('.DayInfo').is(":visible")) {
            $('.DayInfo').slideUp();
        }
        $('#Two .DayInfo').slideDown();
    })
    $('#Three').click(function () {
        if ($('.DayInfo').is(":visible")) {
            $('.DayInfo').slideUp();
        }
        $('#Three .DayInfo').slideDown();
    })

    $('#Four').click(function () {
        if ($('.DayInfo').is(":visible")) {
            $('.DayInfo').slideUp();
        }
        $('#Four .DayInfo').slideDown();
    })

    $('#Five').click(function () {
        if ($('.DayInfo').is(":visible")) {
            $('.DayInfo').slideUp();
        }
        $('#Five .DayInfo').slideDown();
    })

    $('#Six').click(function () {
        if ($('.DayInfo').is(":visible")) {
            $('.DayInfo').slideUp();
        }
        $('#Six .DayInfo').slideDown();
    })

    $('#Seven').click(function () {
        if ($('.DayInfo').is(":visible")) {
            $('.DayInfo').slideUp();
        }
        $('#Seven .DayInfo').slideDown();
    })

})