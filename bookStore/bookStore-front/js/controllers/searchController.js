app.controller("searchController", ["$scope", "$http", function($scope, $http){
  $scope.searchFilterResult = [];
    console.log("searchController alive.");
    $http
    .get("data/bookData.json")
    .success(function(data){
      console.log("Got dummydata", data)
      $scope.bookData = data;
    });

    $scope.query = {}
    $scope.filterOptions = ["genre", "author", "title"];

    $scope.sortBy = $scope.filterOptions[0];

    $scope.$watch("searchFilterResult", function(newVal, oldVal) {
      console.log("searchFilterResult changed from ", oldVal, " to ", newVal);
    });

    $scope.$watch("sortBy", function(newVal, oldVal) {
      var textVal = $scope.query[oldVal];
      $scope.query = {};
      $scope.query[newVal] = textVal;
      console.log("sortBy changed from ", oldVal, " to ", newVal);
    });
}]);