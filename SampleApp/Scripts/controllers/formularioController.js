myApp.controller('formularioCtrl', ['$scope', '$http', '$q', function($scope, $http, $q) {
  
	init();

	function init() {
		 getFormularios();
	}

	function getFormularios() {
		var deferred = $q.defer(); 
        
        $http.get('/api/Formulario').success(function(results) { 
            $scope.formularios = results; 
            deferred.resolve(results); 
        }).error(function (data, status, headers, config) { 
            deferred.reject('ocorreu um erro na tentativa de obter os dados.');
        }); 
 
        return deferred.promise;
	}

	$scope.add = function () {          
        $http.post('/api/Formulario/', this.addFormulario).success(function (data) {  
            alert("Adicionado com Successo!!");  
            $scope.formularios.push(data);  
        }).error(function (data) {  
            $scope.error = "ocorreu um erro ao tentar salvar os dados! ";   
        });  
    };

    $scope.delete = function () {          
        var formularioId = this.formulario.Id;  
        $http.delete('/api/Formulario/' + formularioId).success(function (data) {  
            alert("Deletado com Successo!!");  
            $.each($scope.formularios, function (i) {  
                if ($scope.formularios[i].Id === formularioId) {  
                    $scope.formularios.splice(i, 1);  
                    return false;  
                }  
            });   
        }).error(function (data) {  
            $scope.error = "ocorreu um erro ao tentar salvar os dados! ";    
        });  
    };

}]);
