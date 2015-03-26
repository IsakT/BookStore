var app = angular.module("bookStore", ["ngRoute", "ui.bootstrap", "ngResource"]).
	config(["$routeProvider", function ($routeProvider){
		$routeProvider.
			when("/home", {
			    templateUrl: "/bookStore-front/partials/homeView.html",
						  controller: "bookController"}).
			when("/authors", {
			    templateUrl: "/bookStore-front/partials/authorView.html",
						  controller: "authorController"}).
			when("/books", {
			    templateUrl: "/bookStore-front/partials/bookView.html",
						  controller: "bookController"}).
			when("/genres", {
			    templateUrl: "/bookStore-front/partials/genreView.html",
						  controller: "genreController"}).
			when("/add", {
			    templateUrl: "/bookStore-front/partials/addView.html",
						  controller: "addController"}).
			when("/addAuthor", {
			    templateUrl: "/bookStore-front/partials/addAuthorView.html",
						  controller: "addAuthorController"}).
			when("/addGenre", {
			    templateUrl: "/bookStore-front/partials/addGenreView.html",
						  controller: "addGenreController"}).


		/*Possible routing for deletion.
		when("/delete", {templateUrl: "partials/addView.html",
						  controller: "editController"}).
		*/


			when("/authorDetails", {
			    templateUrl: "/bookStore-front/partials/authorDetailView.html",
						  controller: "authorDetailController"}).
			when("/bookDetails", {
			    templateUrl: "/bookStore-front/partials/bookDetailView.html",
						  controller: "bookDetailController"}).
			when("/search", {
			    templateUrl: "/bookStore-front/partials/search.html",
						  controller: "searchController"}).
			otherwise({
				redirectTo: "/home"
			});


	}]);