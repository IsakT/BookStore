app.controller("addController", ["$scope", "$http", function($scope, $http){
	console.log("Controller is working");

	$http
		.get("data/bookData.json")
		.success(function(data ){
			console.log("Got dummydata", data)
			$scope.bookData = data;
		});

	$scope.selectedAuthor = {};

	$scope.authorsInDb = [
		{
		  name: 'Benjamin Sijercic'
		},
		{
		  name: 'Kim Holmberg'
		},

		{
		  name: 'Zigge zigarett'
		}
	];

	$scope.authorSelect = function(authIndex) {
		console.log("User selected author: ", $scope.bookData[authIndex].author);
		$scope.selectedAuthor.author = $scope.bookData[authIndex].author;
		console.log("selectedAuthor: ", $scope.selectedAuthor);
	}

	$scope.$watch("selectedAuthor", function(newVal, oldVal) {
		console.log("selectedAuthor changed from ", oldVal, " to ", newVal);
	})



	$scope.selectedGenre = {};

	$scope.genreSelect = function(genreIndex) {
		console.log("User selected genre: ", $scope.bookData[genreIndex].genre);
		$scope.selectedGenre.genre = $scope.bookData[genreIndex].genre;
		console.log("selectedGenre: ", $scope.selectedGenre);
	}

	$scope.$watch("selectedAuthor", function(newVal, oldVal) {
		console.log("selectedAuthor changed from ", oldVal, " to ", newVal);
	})

}]);