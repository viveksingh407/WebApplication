var cricketModule = angular.module('CricketApp', ['ngRoute']);

cricketModule.controller("TournamentSchedulerCtrl", ['$scope', 'tournamentFactory', function ($scope, factory) {
    factory.data().then(function (result) { $scope.Teams = result});
}]);

cricketModule.factory('tournamentFactory', ['tournamentService', '$http', function (service) {
    var data = {};

    var result = service.TeamDataFromService;

    return { data: result} ;
}])

cricketModule.service('tournamentService', ['$http', function ($http) {
    this.TeamDataFromService = function () { return $http.get('/api/tournamentservice')
        .then(
            function (response) {
                return JSON.parse(response.data); 
            }, 
            function (response, status) {
                console.log(response.responseText);
            });
    }
}])