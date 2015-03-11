var app = angular.module("bookStore", ["ngRoute", "ui.bootstrap"]).
	config(["$routeProvider", "$locationProvider", function ($routeProvider, $locationProvider){
		$routeProvider.
			when("/home", {templateUrl:"partials/homeView.html"}).
			when("/authors", {templateUrl:"partials/authorView.html",
						  controller: "authorController"}).
			when("/books", {templateUrl: "partials/bookView.html",
						  controller: "bookController"}).
			when("/genres", {templateUrl: "partials/genreView.html",
						  controller: "genreController"}).
			when("/add", {templateUrl: "partials/addView.html",
						  controller: "addController"}).
			when("/authorDetails", {templateUrl: "partials/authorDetailView.html",
						  controller: "authorDetailController"}).
			when("/bookDetails", {templateUrl: "partials/bookDetailView.html",
						  controller: "bookDetailController"}).
			otherwise({
				redirectTo: "/home"
			});

			$locationProvider.html5Mode(true);

	}]);