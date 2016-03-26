(function () {
    angular
        .module('CricketApp', [])
        .controller("CricketTeamsListCtrl", GetTeamsData);

    function GetTeamsData() {
        this.Teams = [{
            teamId: 1,
            teamName: 'Team1'
        }, {
            teamId: 2,
            teamName: 'Team2'
        }, {
            teamId: 3,
            teamName: 'Team3'
        }, {
            teamId: 4,
            teamName: 'Team4'
        }];
    }
})();