steal("funcunit/qunit", "prematch/fixtures", "prematch/models/navigator.js", function(){
	module("Model: Prematch.Models.Navigator")
	
	test("findAll", function(){
		expect(4);
		stop();
		Prematch.Models.Navigator.findAll({}, function(navigators){
			ok(navigators)
	        ok(navigators.length)
	        ok(navigators[0].name)
	        ok(navigators[0].description)
			start();
		});
		
	})
	
	test("create", function(){
		expect(3)
		stop();
		new Prematch.Models.Navigator({name: "dry cleaning", description: "take to street corner"}).save(function(navigator){
			ok(navigator);
	        ok(navigator.id);
	        equals(navigator.name,"dry cleaning")
	        navigator.destroy()
			start();
		})
	})
	test("update" , function(){
		expect(2);
		stop();
		new Prematch.Models.Navigator({name: "cook dinner", description: "chicken"}).
	            save(function(navigator){
	            	equals(navigator.description,"chicken");
	        		navigator.update({description: "steak"},function(navigator){
	        			equals(navigator.description,"steak");
	        			navigator.destroy();
						start();
	        		})
	            })
	
	});
	test("destroy", function(){
		expect(1);
		stop();
		new Prematch.Models.Navigator({name: "mow grass", description: "use riding mower"}).
	            destroy(function(navigator){
	            	ok( true ,"Destroy called" )
					start();
	            })
	})
})