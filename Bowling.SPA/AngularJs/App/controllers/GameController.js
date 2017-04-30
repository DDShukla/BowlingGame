BowlingControllers.controller('GameController', ['$scope', '$routeParams', '$location', 'BowlingGameService', 'GameRollService',
function ($scope, $routeParams, $location, BowlingGameService, GameRollService) {

    $scope.CurrentFrame = 1;
    $scope.CurrentScore = 0;
    $scope.BonusRoll = false;
    $scope.rolls = [];

    $scope.$watch('rollone', function (newValue) {

        if (newValue == 10 && $scope.CurrentFrame == 10) {
            $scope.BonusRoll = true;
        }

        if (newValue < 10 && $scope.CurrentFrame == 10) {
            $scope.BonusRoll = false;
        }
    });

    $scope.$watch('rolltwo', function (newValue) {

        if ($scope.CurrentFrame == 10 && ($scope.rollone + newValue == 10)) {
            $scope.BonusRoll = true;
        }

        if ($scope.CurrentFrame == 10 && ($scope.rollone + newValue < 10)) {
            $scope.BonusRoll = false;
        }
    });
    
    $scope.showFinalScore = function ()
    {
        if ($scope.CurrentFrame == 10) {

            $scope.rolls.push($scope.rollone);
            $scope.rolls.push($scope.rolltwo);

            if ($scope.BonusRoll)
            {
                $scope.rolls.push($scope.rollThree);
            }

            $scope.rollone = null;
            $scope.rolltwo = null;
            $scope.rollThree = null;

            GameRollService.saveRolls($scope.rolls);

            $location.path('/game/result/');
        }

        if ($scope.CurrentFrame < 10) {
            $scope.rolls.push($scope.rollone);
            $scope.rolls.push($scope.rolltwo);
            $scope.CurrentFrame++;
            $scope.rollone = null;
            $scope.rolltwo = null;

            if ($scope.rolls != null && $scope.rolls.length > 0) {
                BowlingGameService.scoreByAllRolls($scope.rolls).then(function (data) {
                    if (data != null) {
                        $scope.CurrentScore = data;
                    }
                });
            }
        }
    };   

}]);