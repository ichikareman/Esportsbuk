steal("funcunit", function(){
	module("prematch test", { 
		setup: function(){
			S.open("//prematch/prematch.html");
		}
	});
	
	test("Copy Test", function(){
		equals(S("h1").text(), "Welcome to JavaScriptMVC 3.2!","welcome text");
	});
})