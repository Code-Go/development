
var appPlanGoGo = angular.module('AppPlanGoGo', ["ngTable"]);
appPlanGoGo.controller('controlerIndex', function ($scope, $http) {
    
    $scope.CategoryList = [];
    $scope.TravelModeId;
    $scope.SourceAttractionID;
    $scope.DestinationAttractionID;
    $scope.AttractionID;
    $scope.StartDate;
    $scope.StartTime;
    $scope.attractionList = [];

    $scope.OrderOfAttractionList = [];



    //GetCategoryList($scope, $http);

    $scope.GetCategoryList = function () {        
        GetCategoryList($scope, $http);
    };

    $scope.CategorySelected = function (categoryList) {
        //selectedCategoryList
        
        var isRecordFound = false;
        $.each(selectedCategoryList, function (categoryKey, categoryValue) {            
            if(categoryValue["CategoryId"]==categoryList.CategoryId)
            {                
                isRecordFound = true;
                selectedCategoryList.splice(categoryKey, 1);
                return false;
            }
            else
            {
                isRecordFound = false;
            }
        });        
        if (!isRecordFound) {
            item = [];
            item.CategoryId = categoryList.CategoryId;
            item.CategoryName = categoryList.CategoryName;
            selectedCategoryList.push(item);
        }
        //It will get the all the attractions information
        PublicFilterAttractions(angularScope, http);        
    };

    //City Selected
    $scope.CitySelected=function(data)
    {
        //Google Maps data binding
        $scope.GoogleMapMarks(data);
       

        $.each(data, function (attractionKey, attractionValue)
        {
            item = [];
            item.value = attractionValue["GoogleSearchText"];
            item.data = attractionValue["AttractionsId"];
            $scope.attractionList.push(item);
        });

        
        //Source Auto Complete Data
        $('#autoStartLocation').autocomplete({
            source: $scope.attractionList
        });


        $("#autoStartLocation").on("autocompleteselect", function (event, ui) {

            //this will get the category list
            //var scope = angular.element("#controlerIndex").scope();
            //scope.$apply(function () {
            //    scope.GetCategoryList();
            //});
        });

        //Desitnation auto complete information
        $('#autoDestinationLocation').autocomplete({
            source: $scope.attractionList
        });


        $("#autoDestinationLocation").on("autocompleteselect", function (event, ui) {

            //this will get the category list
            //var scope = angular.element("#controlerIndex").scope();
            //scope.$apply(function () {
            //    scope.GetCategoryList();
            //});
        });

        $scope.AttractionInformationBinding();

    };

    //Getting the order of Attractions
    $scope.AttractionInformationBinding=function()
    {
        
        var attractionListConcated;
        var isFirst=false;
        $.each($scope.attractionList, function (attractionKey, attractionValue) {
            if(!isFirst)
            {
                isFirst = true;
                $scope.SourceAttractionID = $scope.DestinationAttractionID = attractionListConcated = attractionValue["data"];
            }
            else
            {                
                attractionListConcated += "," + attractionValue["data"];
            }
        });

        //We need to make dynamic
        $scope.TravelModeId = 1;
        $scope.StartDate = '';
        $scope.StartTime = '';
        if ($("#autoStartLocation").val() != "")
        {
            $scope.SourceAttractionID = $("#autoStartLocation").val();
        }
        if ($("#autoDestinationLocation").val() != "")
        {
            $scope.DestinationAttractionID = $("#autoDestinationLocation").val();
        }        
        $scope.AttractionID = attractionListConcated;
        if ($("#calStartDateAndTime").val() != "") {
            $scope.StartDate = $("#calStartDateAndTime").val();
        }
        if ($("#calDropDateAndTime").val() != "") {
            $scope.StartTime = $("#calDropDateAndTime").val();
        }

        Public_GetOrderOfAttractionVisit($scope, $http);
    };

    //Ajax return data for the order of attractions
    $scope.AttractionInformationRendaring = function (data)
    {
        
        //$scope.$apply(function () {
        $scope.OrderOfAttractionList = data;
        //$scope.$apply();
        //});
        $scope.ItenateDynamicDatesCreation(data);
    };

    //displaying the google maps information with the current attraction information
    $scope.GoogleMapMarks = function (data) {
        var googleMaps;
        var isFirst = true;

        $.each(data, function (googleKey,googleValue) {
            if(isFirst)
            {
                isFirst = false;
                googleMaps = new GMaps({
                    div: '#googleMaps',
                    lat: googleValue.Latitude,
                    lng: googleValue.Longitude
                });
            }

            googleMaps.addMarker({
                lat: googleValue.Latitude,
                lng: googleValue.Longitude,
                title: googleValue.AttractionName,
                infoWindow: {
                    content: googleValue.AttractionName + "<br/>" + googleValue.AddressOne + "<br/>" + googleValue.AddressTwo + "<br/>"
                }
            });
        });        
    };


    $scope.ItenateDynamicDatesCreation = function (data) {
        $("div#subtabs").tabs();
        $("div#subtabs ul").empty();
        var num_tabs = $("div#subtabs ul li").length + 1;

        $.each(data, function (groupKey, groupValue) {
            $("div#subtabs ul").append(
                "<li><a href='#tab_" + groupValue.GroupDate.replace("/", "_").replace("/", "_") + "'>" + groupValue.GroupDate + "</a></li>"
            );
            $("div#subtabs").append(
                        "<div id='tab_" + groupValue.GroupDate.replace("/", "_").replace("/", "_") + "'>" +
                        TourInformation(
                                            "tab_" + groupValue.GroupDate.replace("/", "_").replace("/", "_")
                                            , groupValue.ListGetOrderOfAttractionVisit
                                        ) + "</div>"
                    );
            $("div#subtabs").tabs("refresh");
        }
        );
    };
    
    



    
});