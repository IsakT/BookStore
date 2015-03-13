app.controller("genreController", ["$scope", function($scope){
	

	$scope.setMrBool = function() {
		$scope.mrBool = !$scope.mrBool;
	};
}]);

app.controller("genreController2", ["$scope", function($scope){

	$scope.oneAtATime = true;

	$scope.genres = [
	{
	  title: 'Adventure',
	  description: 'All about swords and stuff'
	},
	{
	  title: 'True Crime',
	  description: 'Stuff that actually happened'
	},
	{
	  title: 'Genre - 1',
	  description: 'Description - 1'
	},
	{
	  title: 'Genre - 1',
	  description: 'Description - 1'
	},
	{
	  title: 'Genre - 2',
	  description: 'Description- 2'
	}
	];

	$scope.books = [
	{
		title: "Derp",
		author: "Derpy"
	},
	{
		title: "Derp",
		author: "Derpy"
	},
	{
		title: "Derp",
		author: "Derpy"
	}
	];

	$scope.status = {
	isFirstOpen: true,
	isFirstDisabled: false
	};
}]);