app.controller("bookController", ["$scope", function($scope){
	
	$scope.readMore = function(){
		$scope.more = !$scope.more;
	}	
}]);