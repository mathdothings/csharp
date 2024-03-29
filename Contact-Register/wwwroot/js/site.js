﻿// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

const now = () => new Date().getFullYear();

const currentYear = $("#current_year");
currentYear.text(now());

$(".close-alert").click(() => $(".alert").fadeOut("fast"));

function initializeDatatable(tableIdSelector) {
    $(tableIdSelector).DataTable();
}

$(document).ready( function () {
    initializeDatatable('#contact-list-table')
    initializeDatatable('#user-list-table')
} );