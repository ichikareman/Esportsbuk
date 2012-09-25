// map fixtures for this application

steal("jquery/dom/fixture", function(){
	
	$.fixture.make("navigator", 5, function(i, navigator){
		var descriptions = ["grill fish", "make ice", "cut onions"]
		return {
			name: "navigator "+i,
			description: $.fixture.rand( descriptions , 1)[0]
		}
	})
})