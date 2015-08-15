function getPrice(line){
	var price;
	var pattern = /[0-9,]+.₪/;
	price = pattern.exec($(line).text());
	price = price[0].replace(",","");
	return parseInt(price.slice(0,price.length-2));
}
/**
 * start to run this function when the document is ready.
 */
$(function() {
	var Checkout = (function(){
		this.cost =0;
		return {
			checkout: function(totalCost){
				try{
					if(window.localStorage){
						localStorage["totalCost"] = totalCost;
						cost = totalCost;
						window.location.href = "checkout.html";
					}
				} catch (e) {
					alert("Problem: can't complete without local storage");
				}
			}
		};
	})();
	var cartSum =0;
	function updateCartTotal(){
		$("#cartSum").text(cartSum);
	}
	$("#catalog-page").accordion({
		header : "> div > h2",
		heightStyle : "content"
	}).sortable({
		axis : "y",
		handle : "h2",
		stop : function(event, ui) {
			// IE doesn't register the blur when sorting
			// so trigger focusout handlers to remove .ui-state-focus
			ui.item.children("h3").triggerHandler("focusout");
		}
	});
	$("li.item").draggable({
		appendTo : "body",
		helper : "clone"
	});
	$("#shoppingCart ol").droppable({
		activeClass : "ui-state-default",
		hoverClass : "ui-state-hover",
		accept : ":not(.ui-sortable-helper)",
		drop : function(event, ui) {
			$(this).find(".placeholder").remove();
			$("<li></li>").append(ui.draggable.text() + '<span class="ui-button-icon-primary ui-icon ui-icon-closethick"></span>').appendTo(this);
			$("li span.ui-icon").last().click(function(){
				cartSum -= getPrice($(this).parent());
				$(this).parent().remove();
				updateCartTotal();
			});
			cartSum += getPrice(ui.draggable);
			updateCartTotal();
		}
	});
	$("#checkout").click(function(){
		Checkout.checkout(cartSum);
	});
});