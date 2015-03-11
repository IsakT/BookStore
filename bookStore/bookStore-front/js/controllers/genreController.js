app.controller("genreController", ["$scope", function($scope){
	

	$scope.setMrBool = function() {
		$scope.mrBool = !$scope.mrBool;
	};
}]);

app.controller("genreController2", ["$scope", function($scope){

	$scope.oneAtATime = true;

	$scope.groups = [
	{
	  title: 'Genre - 1',
	  content: 'Description - 1'
	},
	{
	  title: 'Genre - 2',
	  content: 'Description- 2'
	}
	];

	$scope.items = ['Item 1', 'Item 2', 'Item 3'];

	$scope.addItem = function() {
	var newItemNo = $scope.items.length + 1;
	$scope.items.push('Item ' + newItemNo);
	};

	$scope.status = {
	isFirstOpen: true,
	isFirstDisabled: false
	};

}]);