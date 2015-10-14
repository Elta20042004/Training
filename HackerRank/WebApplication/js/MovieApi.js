function Search(newTitle) {
    var parent = $('#accordion');



    $("#accordion").empty();
    var template = $('#template');

    $.getJSON('http://www.omdbapi.com/?s=' + newTitle + '&r=json', function (data) {

        for (var i = 0; i < data.Search.length; i++) {
            var el = data.Search[i];
            var keyCollapseOne = 'collapseOne' + i;
            var clone = template.clone();

            clone.find('[id="headingOne"]').attr('id', 'headingOne' + i);

            clone.find('[href = "#collapseOne"]').attr('href', '#' + keyCollapseOne);

            clone.find("[aria-controls='collapseOne']")
                .attr('aria-controls', keyCollapseOne);

            clone.find('#collapseOne').attr('id', keyCollapseOne);


            clone.find('[aria-labelledby="headingOne"]').attr('aria-labelledby', 'headingOne' + i);
                     
            clone.find('.Title')
                .text(el.Title + ' ' + el.Year + ' ' + el.Type + ' ' + el.imdbID);
            clone.find('.Global')
                .text(el.Title + ' ' + el.Year + ' ' + el.Type + ' ' + el.imdbID)
                .prepend('<img height="100" src="' + el.Poster + '" />');

            clone.appendTo(parent);
        }
    });

}
//<!--<div class="panel-group" id="accordion" role="tablist" aria-multiselectable="true">-->
//           <div class="panel-heading" role="tab" id="headingOne">
//               <h4 class="panel-title">
//                   <a role="button" data-toggle="collapse" data-parent="#accordion" href="#collapseOne" aria-expanded="true" aria-controls="collapseOne">
//                       Collapsible Group Item #1
//                   </a>
//               </h4>
//           </div>
//           <div id="collapseOne" class="panel-collapse collapse in" role="tabpanel" aria-labelledby="headingOne">
//               <div class="panel-body">
//                   Anim pariatur cliche reprehenderit, enim eiusmod high life accusamus terry richardson ad squid. 3 wolf moon officia aute, non cupidatat skateboard dolor brunch. Food truck quinoa nesciunt laborum eiusmod. Brunch 3 wolf moon tempor, sunt aliqua put a bird on it squid single-origin coffee nulla assumenda shoreditch et. Nihil anim keffiyeh helvetica, craft beer labore wes anderson cred nesciunt sapiente ea proident. Ad vegan excepteur butcher vice lomo. Leggings occaecat craft beer farm-to-table, raw denim aesthetic synth nesciunt you probably haven't heard of them accusamus labore sustainable VHS.
//               </div>
//           </div>
//           </div>