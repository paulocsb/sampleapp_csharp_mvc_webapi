myApp.controller('campoCtrl', ['$scope', '$http', '$q', function($scope, $http, $q) {
  
	init();

	function init() {
		 getCampos();
	}

	function getCampos() {
		var deferred = $q.defer(); 
        
        $http.get('/api/Campo').success(function (results) { 
            $scope.campos = results; 
            deferred.resolve(results); 
        }).error(function (data, status, headers, config) { 
            deferred.reject('ocorreu um erro na tentativa de obter os dados.');
        }); 
 
        return deferred.promise;
	}

	$scope.add = function () {          
        $http.post('/api/Campo/', this.addCampo).success(function (data) {  
            alert("Adicionado com Successo!!");  
            $scope.campos.push(data);  
        }).error(function (data) {  
            $scope.error = "ocorreu um erro ao tentar salvar os dados! " + data;   
        });  
    };

    $scope.delete = function () {          
        var campoId = this.campo.Id;  
        $http.delete('/api/Campo/' + campoId).success(function (data) {  
            alert("Deletado com Successo!!");  
            $.each($scope.campos, function (i) {  
                if ($scope.campos[i].Id === campoId) {  
                    $scope.campos.splice(i, 1);  
                    return false;  
                }  
            });   
        }).error(function (data) {  
            $scope.error = "ocorreu um erro ao tentar salvar os dados! " + data;    
        });  
    };

}]);
