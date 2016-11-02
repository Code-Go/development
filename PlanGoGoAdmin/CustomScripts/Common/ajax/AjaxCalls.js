//getting the admin users
function Admin_GetUser(angularScope, http, ngTableParams) {

    $.ajax({
        type: "GET",
        url: '/User/Admin_GetUser',
        dataType: "json",
        beforeSend: function () {

        },
        success: function (data) {
            
            angularScope.$apply(function () {                
                angularScope.manageUsers = data;
                angularScope.manageUsersBinding(data);
                //angularScope.manageUsersTableParams = createUsingFullOptions(data, ngTableParams);
            });
        },
        error: function (result) {
            alert('Service call failed: ' + result.status + ' Type :' + result.statusText);
        },
        complete: function () {

        }
    });
}

//getting the admin users
function Admin_GetCountry(angularScope, http, ngTableParams) {

    $.ajax({
        type: "GET",
        url: '/Country/Admin_GetCountry',
        dataType: "json",
        beforeSend: function () {

        },
        success: function (data) {

            angularScope.$apply(function () {
                angularScope.manageCountry = data;
                angularScope.manageCountryBinding(data);                
            });
        },
        error: function (result) {
            alert('Service call failed: ' + result.status + ' Type :' + result.statusText);
        },
        complete: function () {

        }
    });
}