// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

const now = () => new Date().getFullYear();

const currentYear = document.getElementById("current_year");
currentYear.innerText = now();
