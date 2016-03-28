var cricketModule = angular.module('CricketApp', ['ngRoute']);

cricketModule.controller("TournamentSchedulerCtrl", ['$scope', '$http', function ($scope, $http) {
    //this.Teams = [{
    //    teamId: 1,
    //    teamName: 'Team1'
    //}, {
    //    teamId: 2,
    //    teamName: 'Team2'
    //}, {
    //    teamId: 3,
    //    teamName: 'Team3'
    //}, {
    //    teamId: 4,
    //    teamName: 'Team4'
    //}];

    $http.get('/Tournament/Index').then(getTeamsSuccessCallback, getTeamsFailureCallback);

    $scope.Teams = function () {
        //return $http.get('/Tournament/Index').then(getTeamsSuccessCallback(response), getTeamsFailureCallback);


    }
}]);

function getTeamsSuccessCallback(response)
{
    alert('Success');
    //$scope.Teams = JSON.parse(response);
}

function getTeamsFailureCallback(response)
{
    alert('Failure');
}

cricketModule.config(['$routeProvider', function ($routeProvider) {
    $routeProvider
        .when('/Schedule', {
            templateUrl: 'Tournament/Schedule'
        });
}]);