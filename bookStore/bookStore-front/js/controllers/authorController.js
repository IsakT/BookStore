app.controller("authorController", ["$scope", "$http", function($scope, $http){

		$http
		.get("data/bookData.json")
		.success(function(data){
			console.log("Got dummydata", data)
			$scope.bookData = data;
	});
	
}]);

//Var anropas denna controllern? Eller är AuthornView länkat istället till bookController?