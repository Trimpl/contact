function Search() {
    setTimeout(SearchTm, 0);
}
function SearchTm() {
    $.ajax({
        url: '@Url.Action("Search", "Items")?Search=' + $('#search').val(),
        async: true,
        cache: false,
        success: function (data) {
            var json = JSON.parse(data);
            var arr = [];
            arr = json;
            arr.f
            $('#searchDiv').empty();
            $('#searchDiv').append('<ul>' + s + '</ul>');
        }
    });
}