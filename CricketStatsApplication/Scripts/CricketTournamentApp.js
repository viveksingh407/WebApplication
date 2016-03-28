var cricketModule = angular.module('CricketApp', ['ngRoute']);

cricketModule.controller("TournamentSchedulerCtrl", ['$scope', '$http', function ($scope, $http) {
    $http.get('/api/tournamentservice').then(function (response) {
        $scope.Teams = JSON.parse(response.data);
    }, function () {
        alert('Failure');
    });

    //$http.get('/api/tournamentservice').then(getTeamsSuccessCallback, getTeamsFailureCallback);
}]);

//function getTeamsSuccessCallback(response)
//{
//    $scope.Teams = JSON.parse(response);
//}

//function getTeamsFailureCallback()
//{
//    alert('Failure');
//}

cricketModule.config(['$routeProvider', function ($routeProvider) {
    $routeProvider
        .when('/Schedule', {
            templateUrl: 'Tournament/Schedule'
        });
}]);