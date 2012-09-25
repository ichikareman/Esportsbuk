steal('jquery/controller', 'jquery/view/ejs')
	.then('./views/init.ejs', function ($) {

	    /**
	    * @class Prematch.Navigator
	    */
	    $.Controller('Prematch.Navigator',
	    /** @Static */
        {
        defaults: {}
        },
	    /** @Prototype */
        {
        init: function () {
            var controller = this;
            Prematch.Models.Navigator.getCategories(function (navigationData) {
                controller.element.html("//prematch/navigator/views/init.ejs", navigationData);
            });
        }
    })
});