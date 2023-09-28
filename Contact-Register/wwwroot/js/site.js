// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

const now = () => new Date().getFullYear();

const currentYear = $("#current_year");
currentYear.text(now());

$(".close-alert").click(() => $(".alert").fadeOut("fast"));

$(document).ready( function () {
    $('#contact-list-table').DataTable();
} );