steal('funcunit').then(function(){

module("Prematch.Navigator", { 
	setup: function(){
		S.open("//prematch/navigator/navigator.html");
	}
});

test("Text Test", function(){
	equals(S("h1").text(), "Prematch.Navigator Demo","demo text");
});


});