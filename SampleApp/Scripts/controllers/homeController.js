myApp.controller('homeCtrl', ['$scope', '$http', '$q', function($scope, $http, $q) {
  
	init();

	function init() {
		 //getFormularios();
		 $scope.formularios = 
		 [
			{ Id: 1, Descricao: 'Veiculos', Categorias: 
	          	[{ Id: 1, Descricao: 'Acessórios de Veículos', Slug: 'veiculos-acessorios', SubCategorias: 
	          		[{ Id: 1, Descricao: 'Som', Slug: 'som', Campos: 
	          			[{ Id: 1, Ordem: 1, Descricao: 'Nome', Tipo: 'text' }]
	          		}]
				}]
			},
			{ Id: 1, Descricao: 'Educação', Categorias: 
	          	[{ Id: 1, Descricao: 'Graduação', Slug: 'graduacao', SubCategorias: 
	          		[
	          			{ Id: 1, Descricao: 'Curso', Slug: 'curso', Campos: 
		          			[
		          				{ Id: 1, Ordem: 1, Descricao: 'Nome do curso', Tipo: 'text' },
		          				{ Id: 2, Ordem: 2, Descricao: 'Nome do professor', Tipo: 'text' },
		          				{ Id: 3, Ordem: 3, Descricao: 'Depoimento', Tipo: 'textarea' }
		          			]
	          			},
	          			{ Id: 2, Descricao: 'Professores', Slug: 'professores', Campos: 
		          			[
		          				{ Id: 1, Ordem: 1, Descricao: 'Nome', Tipo: 'text' },
		          				{ Id: 2, Ordem: 2, Descricao: 'Disciplina', Tipo: 'text' }
		          			]
	          			}
          			]
				}],
			}
        ];
	}

	function getFormularios() {
		var deferred = $q.defer(); 
        
        $http.get('/api/Formulario').success(function (results) { 
            $scope.formularios = results; 
            deferred.resolve(results); 
        }).error(function (data, status, headers, config) { 
            deferred.reject('ocorreu um erro na tentativa de obter os dados.');
        }); 
 
        return deferred.promise;
	}

}]);
