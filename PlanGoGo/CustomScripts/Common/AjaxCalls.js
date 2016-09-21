//Getting City Information
function GetCityList() {    
    $.ajax({
        type: "GET",
        url: '/Schedule/GetCityList',        
        dataType: "json",
        beforeSend: function () {
            $(".blockPage").show();
        },
        success: function (data) {
            cityList = [];
            
            $.each(data, function (cityKey, cityValue) {                
                item = [];
                item.value = cityValue["CityName"];
                item.data = cityValue["CityId"];
                cityList.push(item);
            });

            $('#autoCityName').autocomplete({
                source: cityList
            });


            $("#autoCityName").on("autocompleteselect", function (event, ui) {
                
                //this will get the category list
                var scope = angular.element("#controlerIndex").scope();
                scope.$apply(function () {
                    scope.GetCategoryList();
                });
            });
        },
        error: function (result) {
            alert('Service call failed: ' + result.status + ' Type :' + result.statusText);
        },
        complete: function () {
            $(".blockPage").hide();
        }
    });
}


