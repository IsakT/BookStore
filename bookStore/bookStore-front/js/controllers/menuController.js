app.controller("menuController", ["$scope", "$rootScope", "adminService", function($scope, $rootScope, adminService){
	

	$scope.login = function(){
		// adminService.login($scope)
		$scope.showAdd = !$scope.showAdd;
		$rootScope.showEdit = !$rootScope.showEdit;
		$rootScope.showSave = !$rootScope.showSave;
		$rootScope.showTxtEdit = !$rootScope.showTxtEdit;
		if($scope.showAdd){
					console.log("Logged in as Admin");
				};
	};

}]);