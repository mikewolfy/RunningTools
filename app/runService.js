runningToolsApp.factory('runService', function ($resource) {
    return {
        get: function () {
            return $resource('/api/run').query();
        }

        //miles: function () {
        //    return 35;
        //}
    }
});