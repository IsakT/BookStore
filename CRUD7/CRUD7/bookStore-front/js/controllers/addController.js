app.controller("addController", ["$scope", "$http", "$location", function($scope, $http, $location){
	console.log("Controller is working");
	$scope.newBookData = {};

	$scope.formTitle = "Please enter book credentials";
	$scope.saveBtnText = "Add to database";

	$scope.canDelete = true;

	//$http.post("someurl", $scope.newBookData);

	$scope.goTos = function(path) {
		$location.url(path);
	}

	$scope.save = function() {
		//i do nothing yet....
		console.log("newBookData: ", $scope.newBookData);
	};

	$scope.delete = function() {
		//i do nothing yet....
	};

	$http
		.get("data/bookData.json")
		.success(function(data ){
			console.log("Got dummydata", data)
			$scope.bookData = data();
		});

	$scope.authorSelect = function(authIndex) {
		console.log("User selected author: ", $scope.bookData[authIndex].author);
		$scope.newBookData.author = $scope.bookData[authIndex].author;
		console.log("selectedAuthor: ", $scope.newBookData.author);
	}

	$scope.$watch("selectedAuthor", function(newVal, oldVal) {
		console.log("selectedAuthor changed from ", oldVal, " to ", newVal);
	})


	$scope.genreSelect = function(genreIndex) {
		console.log("User selected genre: ", $scope.bookData[genreIndex].genre);
		$scope.newBookData.genre = $scope.bookData[genreIndex].genre;
		console.log("selectedGenre: ", $scope.newBookData.genre);
	}

	$scope.$watch("selectedAuthor", function(newVal, oldVal) {
		console.log("selectedAuthor changed from ", oldVal, " to ", newVal);
	})

	$scope.titleSelect = function(titleIndex) {
		console.log("User selected title: ", $scope.bookData[titleIndex].title);
		$scope.newBookData.title = $scope.bookData[titleIndex].title;
		console.log("selectedTitle: ", $scope.newBookData.title);
	}

	$scope.$watch("selectedAuthor", function(newVal, oldVal) {
		console.log("selectedAuthor changed from ", oldVal, " to ", newVal);
	})




}]);