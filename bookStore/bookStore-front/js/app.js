var app = angular.module("bookStore", ["ngRoute"]).
	config(function ($routeProvider){
		$routeProvider.
			when("/", {templateUrl:"partials/homeView.html"}).
			when("/authors", {templateUrl:"partials/authorView.html",
						  controller: "authorController"}).
			when("/books", {templateUrl: "partials/bookView.html",
						  controller: "bookController"}).
			when("/genres", {templateUrl: "partials/genreView.html",
						  controller: "genreController"}).
			otherwise({
				redirectTo: "/"
			});

	});