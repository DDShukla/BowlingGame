BowlingControllers.controller('ResultController', ['$scope', '$routeParams', '$location', 'BowlingGameService', 'GameRollService',
function ($scope, $routeParams, $location, BowlingGameService, GameRollService) {
    $scope.rolls = [];
    $scope.frameWiseScore = null;
    $scope.frames = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
    $scope.totalScore = null;
   
    init();

    function init()
    {
        $scope.rolls = GameRollService.getRolls();

        if ($scope.rolls != null && $scope.rolls.length > 0) {
            BowlingGameService.scoreByAllRolls($scope.rolls).then(function (data) { 
                if (data != null) {
                    $scope.totalScore = data;
                    

                }
            });

            BowlingGameService.allFramesScoreByRolls($scope.rolls).then(function (data) {
                if (data != null && data.length > 0) {
                    $scope.frameWiseScore = data;                  
                     

                }                
            });

        }
    };

    $scope.TryAgain = function ()
    {
        GameRollService.saveRolls("");
        $location.path('/game/start/');
    };


}]);