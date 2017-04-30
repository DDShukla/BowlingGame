window.BowlingControllers.controller('StartController', ['$scope', '$routeParams','$location',
function ($scope, $routeParams, $location) {
  
    $scope.startGame = function ()
    {
        $location.path('/game/gameWindow/');
    };

}]);