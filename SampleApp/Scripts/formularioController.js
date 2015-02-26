myApp.controller('formularioCtrl', ['$scope', '$http', '$q', function($scope, $http, $q) {
  
	init();

	function init() {
		
		var deferred = $q.defer(); 
        
        $http.get('/api/Formulario').success(function (results) { 
            $scope.formularios = results; 
            deferred.resolve(results); 
        }).error(function (data, status, headers, config) { 
            deferred.reject('Ocorreu um erro na tentativa de obter os dados.');
        }); 
 
        return deferred.promise; 
	}
}]);
