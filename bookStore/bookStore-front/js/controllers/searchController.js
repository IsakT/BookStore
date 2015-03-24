app.controller("searchController", ["$scope", "$http", "$rootScope", "$routeParams", "$location", function($scope, $http, $rootScope, $routeParams, $location){
  
	
	$scope.filterOptions = ["all", "genre", "author", "title"];
  $scope.sortBy = $scope.filterOptions[0];

  if ($routeParams) {
    console.log("searchController got $routeParams: ", $routeParams, " now using these as $scope.query...");
    $rootScope.query = $routeParams;
  }

  $scope.searchFilterResult = [];
    console.log("searchController alive.");
    $http
    .get("data/bookData.json")
    .success(function(data){
      console.log("Got dummydata", data)
      $scope.bookData = data;
			
			// add a new property that mashes all properties
			// into one string in order to make filter = all work
			data.forEach(function(book){
				book.all = book.author + " " + book.genre + " " + book.title;
			});
			
    });

		//$rootScope.$watch("query",function(x){console.log("query",x)});
    $scope.$watch("searchFilterResult", function(newVal, oldVal) {
      console.log("searchFilterResult changed from ", oldVal, " to ", newVal);
    });

    $scope.$watch("sortBy", function(newVal, oldVal) {
      if (!oldVal) { return; }
      var textVal = $rootScope.query[oldVal];
      $rootScope.query[newVal] = textVal;
      console.log("sortBy changed from ", oldVal, " to ", newVal);
    });

    $scope.goSearch = function() {
      console.log("User wants to search with query: ", $rootScope.query);
      console.log("now changing $location to: " + "/search?" + $scope.sortBy +"=" + $rootScope.query[$scope.sortBy]);
      $location.url("/search?" + $scope.sortBy +"=" + $rootScope.query[$scope.sortBy]);
    }
}]);