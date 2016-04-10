var cricketModule = angular.module('CricketApp', ['ngRoute']);

cricketModule.controller("TournamentSchedulerCtrl", ['$scope', 'tournamentFactory', function ($scope, factory) {
    $scope.newTeamName = '';

    factory.data().then(function (result) { $scope.Teams = result });

    $scope.addNewTeam = function () {
        $scope.Teams.push({ 'TeamId': $scope.Teams.length + 1, 'TeamName': $scope.newTeamName });
        $scope.newTeamName = '';
    };

    $scope.selectAll = function ($event) {
        var checkbox = $event.target;

        var isChecked = checkbox.checked ? true : false;
        $('input:checkbox').each(function (index, selector) { $(selector).prop('checked', isChecked); })
    };

    $scope.deleteSelectedTeams = function () {
        $('input:checkbox:checked').siblings('span').each(function (index, control) {
            var removeItem = $(control).html();
            $scope.Teams = jQuery.grep($scope.Teams, function (value, control) {
                return value.TeamId != removeItem;
            });
        })
    };
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