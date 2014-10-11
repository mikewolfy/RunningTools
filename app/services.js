

runningToolsApp.service('runService', function ($http, $q) {
        
    var shoeList = { content: null };

    $http.get('http://localhost:5368/api/shoe').
      success(function (data, status, headers, config) {
          shoeList.content = data;
      }).
      error(function (data, status, headers, config) {
          //log error
      });


       var runsList = [
            {
                id: 1,
                date: '7/18/2014',
                distance: 5,
                type: "Treadmill",
                shoes: "Saucony Progrid Ride Silver"
            },
            {
                id: 2,
                date: '7/19/2014',
                distance: 13,
                type: "Road",
                shoes: "Saucony Progrid Ride Silver"
            }
        ];

        this.runs = function () {
            return runsList;
        }

        this.miles = function () {
            return 37;
        };

        this.shoes = function () {
            return shoeList;
        }

    // http://www.bennadel.com/blog/2612-using-the-http-service-in-angularjs-to-make-ajax-requests.htm
    // I get all of the friends in the remote collection.
        function getShoes() {

            var request = $http({
                method: "get",
                url: "api/shoe",
                params: {
                    action: "get"
                }
            });

            return (request.then(handleSuccess, handleError));

        }


    // I remove the friend with the given ID from the remote collection.
        function removeShoe(id) {

            var request = $http({
                method: "delete",
                url: "api/shoe",
                params: {
                    action: "delete"
                },
                data: {
                    id: id
                }
            });

            return (request.then(handleSuccess, handleError));

        }


    // ---
    // PRIVATE METHODS.
    // ---


    // I transform the error response, unwrapping the application dta from
    // the API response payload.
        function handleError(response) {

            // The API response from the server should be returned in a
            // nomralized format. However, if the request was not handled by the
            // server (or what not handles properly - ex. server error), then we
            // may have to normalize it on our end, as best we can.
            if (
                !angular.isObject(response.data) ||
                !response.data.message
                ) {

                return ($q.reject("An unknown error occurred."));

            }

            // Otherwise, use expected error message.
            return ($q.reject(response.data.message));

        }


    // I transform the successful response, unwrapping the application data
    // from the API response payload.
        function handleSuccess(response) {

            return (response.data);

        }

    });