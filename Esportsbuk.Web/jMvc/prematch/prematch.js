steal(
	'./prematch.css', 			// application CSS file
	'./models/models.js', 	// steals all your models
	'./fixtures/fixtures.js', // sets up fixtures for your models
    'prematch/navigator/navigator.js',

	function () {	    		// configure your application

	    new Prematch.Navigator('#navigator');



	})