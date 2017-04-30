publication.factory('BowlingGameService', ['$http', '$q', function ($http, $q) {
    return {
        scoreByAllRolls: _scoreByAllRolls,
        allFramesScoreByRolls: _allFramesScoreByRolls      
    };

    function _scoreByAllRolls(rolls) {
        var deferred = $q.defer();
        var httpMethod = "POST";
        $http({ method: httpMethod, url: URLconfiguration.generateApiUrl('BowlingGame/ScoreByAllRolls'), data: JSON.stringify(rolls) }).
           success(function (data, status, headers, URLconfiguration) {               
               deferred.resolve(data);
           });
        return deferred.promise;
    }

    function _allFramesScoreByRolls(rolls) {
        var deferred = $q.defer();
        var httpMethod = "POST";         
        $http({ method: httpMethod, url: URLconfiguration.generateApiUrl('BowlingGame/AllFramesScoreByRolls'), data: JSON.stringify(rolls) }).
           success(function (data, status, headers, URLconfiguration) {               
               deferred.resolve(data);
           });
        
        return deferred.promise;
    }


}]);

publication.service('GameRollService', function () {
      
    var rolls = {};   
    this.saveRolls = function (rolls) {
        this.rolls = rolls; 
       
    };

    this.getRolls = function () {
        return this.rolls;
    };

});
