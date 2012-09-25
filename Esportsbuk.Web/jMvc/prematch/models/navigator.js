steal('jquery/model', function () {

    /**
    * @class Prematch.Models.Navigator
    * @parent index
    * @inherits jQuery.Model
    * Wraps backend navigator services.  
    */
    $.Model('Prematch.Models.Navigator',
    /* @Static */
        {
        /*
        findAll: "/navigators.json",
        findOne : "/navigators/{id}.json", 
        create : "/navigators.json",
        update : "/navigators/{id}.json",
        destroy : "/navigators/{id}.json"
        */
        getCategories: function (callback) {

            var navUrl = "http://localhost:2838/api/Navigation/GetPrematchMarketNavigation";

            $.ajax({
                url: navUrl,
                type: 'GET',
                dataType: 'json',
                success: function (data) {
                    callback(data);
                }
            });
        }
    },
    /* @Prototype */
{});

})