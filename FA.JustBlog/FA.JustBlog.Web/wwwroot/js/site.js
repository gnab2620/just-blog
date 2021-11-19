// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(function () {
    $('#tblData').DataTable();
}

);
$(document).ready(function () {
    (function () {
        
        var url_list_category = $("#foo-view-list-category").data("url");
        $("#foo-view-list-category").load(url_list_category);
        var url_popular_tags = $("#foo-view-popular").data("url");
        $("#foo-view-popular").load(url_popular_tags);
    })();
});