app.controller("searchController", ["$scope", "$http", function($scope, $http){
    console.log("searchController alive.");
    $http
    .get("data/bookData.json")
    .success(function(data){
      console.log("Got dummydata", data)
      $scope.bookData = data;
    });

    $scope.query = {}
    $scope.queryBy = 'author'
    $scope.searchResult = false;

    $scope.$watch("searchFilterResult", function(newVal, oldVal) {
      console.log("searchFilterResult changed from ", oldVal, " to ", newVal);
    });
}]);