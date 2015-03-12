app.controller("menuController", ["$scope", "adminService", function($scope, adminService){
	

	$scope.login = function(){
		adminService.login($scope)
	};

}]);