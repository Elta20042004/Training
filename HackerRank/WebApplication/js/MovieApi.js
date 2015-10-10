function Search(newTitle) {
    var parent = $('.Global');


    $(".Global").empty();


    $.getJSON('http://www.omdbapi.com/?s=' + newTitle + '&r=json', function (data) {

        for (var i = 0; i < data.Search.length; i++) {
            var el = data.Search[i]
            $('<div></div>').addClass('box')
               .text(el.Title + ' ' + el.Year + ' ' + el.Type + ' ' + el.imdbID)
               .prepend('<img height="100" src="'+ el.Poster +'" />')
               .appendTo(parent);
        
        }
    });

}