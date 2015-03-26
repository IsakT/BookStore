var app = angular.module("bookStore", ["ngRoute", "ui.bootstrap", "ngResource"]).
	config(["$routeProvider", function ($routeProvider){
		$routeProvider.
			when("/home", {
			    templateUrl: "/bookStore-Front/partials/homeView.html",
						  controller: "homeController"}).
			when("/authors", {
			    templateUrl: "/bookStore-Front/partials/authorView.html",
						  controller: "authorController"}).
			when("/books", {
			    templateUrl: "/bookStore-Front/partials/bookView.html",
						  controller: "bookController"}).
			when("/genres", {
			    templateUrl: "/bookStore-Front/partials/genreView.html",
						  controller: "genreController"}).
			when("/add", {
			    templateUrl: "/bookStore-Front/partials/addView.html",
						  controller: "addController"}).
			when("/addAuthor", {
			    templateUrl: "/bookStore-Front/partials/addAuthorView.html",
						  controller: "addAuthorController"}).
			when("/addGenre", {
			    templateUrl: "/bookStore-Front/partials/addGenreView.html",
						  controller: "addGenreController"}).


		/*Possible routing for deletion.
		when("/delete", {templateUrl: "partials/addView.html",
						  controller: "editController"}).
		*/


			when("/authorDetails", {
			    templateUrl: "/bookStore-Front/partials/authorDetailView.html",
						  controller: "authorDetailController"}).
			when("/bookDetails", {
			    templateUrl: "/bookStore-Front/partials/bookDetailView.html",
						  controller: "bookDetailController"}).
			when("/search", {
			    templateUrl: "/bookStore-Front/partials/search.html",
						  controller: "searchController"}).
			otherwise({
				redirectTo: "/home"
			});

		/* $locationProvider.html5Mode(true); */

	}]);