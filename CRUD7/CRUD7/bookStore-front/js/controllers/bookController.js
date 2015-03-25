app.controller("bookController", ["$http", "$scope", function($http, $scope){
	
	$http
		.get("data/bookData.json")
		.success(function(data){
			console.log("Got dummydata", data);
			data.forEach(function(book){
				book.all = book.author + " " + book.genre + " " + book.title;
			});
			$scope.bookData = data;
	});

	var editBook;
	var editDescription;	
	//Get the id of the book being clicked	
	$scope.getBookId = function(bookId){
		$scope.bookId = bookId;
		console.log(bookId);
	}

	$scope.readMore = function(){
		$scope.more = !$scope.more;
		$scope.summary = !$scope.summary;
	}

	$scope.editBook = function(){
		$scope.showDetailWindow = !$scope.showDetalWindow;
		$scope.editBookView = !$scope.editBookView;
		$scope.showEdit = !$scope.showEdit;
	}
	$scope.saveData = function(){
		$scope.showDetailWindow = !$scope.showDetailWindow;
		$scope.editBookView = !$scope.editBookView;
		$scope.showEdit = !$scope.showEdit;
	}

	// $scope.books = Book.index();
	/*
	$scope.getBookRating = function(bookRating){
		$scope.bookRating = bookRating;
		console.log(bookRating);
	}
	*/
}]);
