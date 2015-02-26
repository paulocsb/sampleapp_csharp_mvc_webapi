myApp.controller('categoriaCtrl', ['$scope', '$http', '$q', function($scope, $http, $q) {
  
	init();

	function init() {
		 getCategorias();
	}

	function getCategorias() {
		var deferred = $q.defer(); 
        
        $http.get('/api/Categoria').success(function (results) { 
            $scope.categorias = results; 
            deferred.resolve(results); 
        }).error(function (data, status, headers, config) { 
            deferred.reject('ocorreu um erro na tentativa de obter os dados.');
        }); 
 
        return deferred.promise;
	}

	$scope.add = function () {          
        $http.post('/api/Categoria/', this.addCategoria).success(function (data) {  
            alert("Adicionado com Successo!!");  
            $scope.categorias.push(data);  
        }).error(function (data) {  
            $scope.error = "ocorreu um erro ao tentar salvar os dados! " + data;   
        });  
    };

    $scope.delete = function () {          
        var categoriaId = this.categoria.Id;  
        $http.delete('/api/Categoria/' + categoriaId).success(function (data) {  
            alert("Deletado com Successo!!");  
            $.each($scope.categorias, function (i) {  
                if ($scope.categorias[i].Id === categoriaId) {  
                    $scope.categorias.splice(i, 1);  
                    return false;  
                }  
            });   
        }).error(function (data) {  
            $scope.error = "ocorreu um erro ao tentar salvar os dados! " + data;    
        });  
    };

}]);
