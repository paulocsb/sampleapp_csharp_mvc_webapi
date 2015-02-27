myApp.controller('subcategoriaCtrl', ['$scope', '$http', '$q', function($scope, $http, $q) {
  
	init();

	function init() {
		 getSubCategorias();
	}

	function getSubCategorias() {
		var deferred = $q.defer(); 
        
        $http.get('/api/SubCategoria').success(function (results) { 
            $scope.subcategorias = results; 
            deferred.resolve(results); 
        }).error(function (data, status, headers, config) { 
            deferred.reject('ocorreu um erro na tentativa de obter os dados.');
        }); 
 
        return deferred.promise;
	}

	$scope.add = function () {          
        $http.post('/api/SubCategoria/', this.addSubCategoria).success(function (data) {  
            alert("Adicionado com Successo!!");  
            $scope.subcategorias.push(data);  
        }).error(function (data) {  
            $scope.error = "ocorreu um erro ao tentar salvar os dados! ";   
        });  
    };

    $scope.delete = function () {          
        var subcategoriaId = this.subcategoria.Id;  
        $http.delete('/api/SubCategoria/' + subcategoriaId).success(function (data) {  
            alert("Deletado com Successo!!");  
            $.each($scope.subcategorias, function (i) {  
                if ($scope.subcategorias[i].Id === subcategoriaId) {  
                    $scope.subcategorias.splice(i, 1);  
                    return false;  
                }  
            });   
        }).error(function (data) {  
            $scope.error = "ocorreu um erro ao tentar salvar os dados! ";    
        });  
    };

}]);
