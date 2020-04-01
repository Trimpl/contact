$(document).ready(function () {
    $('#submit').click(function (e) {
        e.preventDefault();
        var name = $('#search').val();
        name = encodeURIComponent(name);
        $('#results').load('@Url.Action("ListComments", "Items")?IdItem=' + name);
    });
});
