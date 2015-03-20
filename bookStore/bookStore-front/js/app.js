var app = angular.module("bookStore", ["ngRoute", "ui.bootstrap", "ngResource"]).
	config(["$routeProvider", "$locationProvider", function ($routeProvider, $locationProvider){
		$routeProvider.
			when("/home", {templateUrl:"partials/homeView.html",
						  controller: "homeController"}).
			when("/authors", {templateUrl:"partials/authorView.html",
						  controller: "authorController"}).
			when("/books", {templateUrl: "partials/bookView.html",
						  controller: "bookController"}).
			when("/genres", {templateUrl: "partials/genreView.html",
						  controller: "genreController"}).
			when("/add", {templateUrl: "partials/addView.html",
						  controller: "addController"}).
			when("/addAuthor", {templateUrl:"partials/addAuthorView.html",
						  controller: "addAuthorController"}).


		/*Possible routing for deletion.
		when("/delete", {templateUrl: "partials/addView.html",
						  controller: "editController"}).
		*/


			when("/authorDetails", {templateUrl: "partials/authorDetailView.html",
						  controller: "authorDetailController"}).
			when("/bookDetails", {templateUrl: "partials/bookDetailView.html",
						  controller: "bookDetailController"}).
			when("/search", {templateUrl: "partials/search.html",
						  controller: "searchController"}).
			otherwise({
				redirectTo: "/home"
			});

			$locationProvider.html5Mode(true);

	}]);