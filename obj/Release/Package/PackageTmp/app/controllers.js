'use strict';

runningToolsApp.controller('runsCtrl',
    function runsCtrl($scope, runService) {

        //$scope.miles = 25;
        $scope.miles =  runService.miles();

        $scope.runs = runService.runs();

        $scope.shoes = runService.shoes().content;

        //$scope.runs = [
        //    {
        //        id: 1,
        //        date: '7/18/2014',
        //        distance: 5
        //    },
        //    {
        //        id: 2,
        //        date: '7/19/2014',
        //        distance: 13
        //    }
        //];
        
    }
);