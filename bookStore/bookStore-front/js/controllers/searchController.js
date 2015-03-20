app.controller("searchController", ["$scope", "$http", "$rootScope", function($scope, $http, $rootScope){
  $rootScope.searchFilterResult = [];
    console.log("searchController alive.");
    $http
    .get("data/bookData.json")
    .success(function(data){
      console.log("Got dummydata", data)
      $rootScope.bookData = data;
			
			// add a new property that mashes all properties
			// into one string in order to make filter = all work
			data.forEach(function(book){
				book.all = book.author + " " + book.genre + " " + book.title;
			});
			
    });

		//$rootScope.$watch("query",function(x){console.log("query",x)});
    $rootScope.$watch("searchFilterResult", function(newVal, oldVal) {
      console.log("searchFilterResult changed from ", oldVal, " to ", newVal);
    });

    $rootScope.$watch("sortBy", function(newVal, oldVal) {
      var textVal = $rootScope.query[oldVal];
      $rootScope.query = {};
      $rootScope.query[newVal] = textVal;
      console.log("sortBy changed from ", oldVal, " to ", newVal);
    });
}]);