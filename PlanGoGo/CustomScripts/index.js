init();
//googleMapsData();
function init()
{
    
    try{
        //calling the auto complete for filling the city information
        GetCityList();

        $(function () {
            
            $("#tabs, #subtabs").tabs();
            
        });
    }
    catch(e)
    {
        alert(e);
    }
}

//displaying the google maps information with the current attraction information
function googleMapsData() {
    var googleMaps;
    $(document).ready(function () {
        //prettyPrint();
        googleMaps = new GMaps({
            div: '#googleMaps',
            lat: -12.043333,
            lng: -77.028333
        });
        googleMaps.addMarker({
            lat: -12.043333,
            lng: -77.03,
            title: 'Lima',
            details: {
                database_id: 42,
                author: 'HPNeo'
            },
            click: function (e) {
                if (console.log)
                    console.log(e);
                alert('You clicked in this marker');
            }
        });
        googleMaps.addMarker({
            lat: -12.042,
            lng: -77.028333,
            title: 'Marker with InfoWindow',
            infoWindow: {
                content: '<p>HTML Content</p>'
            }
        });
    });
}

