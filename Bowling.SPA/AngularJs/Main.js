window.BowlingControllers = angular.module('BowlingControllers', ['ngSanitize']);

window.publication = angular.module('BowlingApp', ['ngRoute', 'BowlingControllers']);

publication.config(['$routeProvider', function ($routeProvider) {
    $routeProvider
        .when('/', { templateUrl: 'AngularJs/App/html/Start.html', controller: 'StartController' })
        .when('/game/start', { templateUrl: 'AngularJs/App/html/Start.html', controller: 'StartController' })
        .when('/game/gameWindow', { templateUrl: 'AngularJs/App/html/game.html', controller: 'GameController' })
        .when('/game/result', { templateUrl: 'AngularJs/App/html/Result.html', controller: 'ResultController' })
}]);




