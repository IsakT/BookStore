app.controller("genreController", ["$scope", function($scope){
	

	$scope.setMrBool = function() {
		$scope.mrBool = !$scope.mrBool;
	};
}]);

app.controller("genreController2", ["$scope", function($scope){

	$scope.oneAtATime = true;

	$scope.genres = [
	{
	  title: 'Fantasy',
	  description: 'All about swords and stuff, dragons, maidens, magic rings, talking animals, witches, ketchup with wings etc.'
	},

	{
	  title: 'True Crime',
	  description: 'Stuff that actually happened. Bad people doing bad things to marginally better people, generally with some sort of pointed metal instrument. Or, like poison.'
	},
	{
	  title: 'Horror',
	  description: 'I keel you ded, hooman. BOO! -- AAH! What the what you inconsiderent eerily transparent person - oh my dog, you´re a ghost. Shit. I´m fucked.'
	},
	{
	  title: 'Young Adult',
	  description: 'Like, OMG did you see LaShawna´s new hair style? Talk about nasty, mhmm. Twilight and all that shit.'
	},
	{
	  title: 'Romance',
	  description: 'Jessie´s hand gently slid down Andy´s back... And then they lived happily ever after, after having killed all the zombies in the universe. Their wedding ceremony was precided over by the Space Pope, who subsequenty joined them in a rather spirited threesome.'
	}
	];

	$scope.books = [
	{
		title: "Harry Potter and the Philisopher´s stone",
		genre: "Fantasy, Young Adult",
		author: "JK Rowling"
	},
	{
		title: "Harry Potter and the Chamber of Secrets",
		genre: "Fantasy, Young Adult",
		author: "JK Rowling"
	},
	{
		title: "Harry Potter and the Prisoner of Azkaban",
		genre: "Fantasy, Young Adult",
		author: "JK Rowling"
	},
	{
		title: "In cold blood",
		genre: "True Crime",
		author: "Truman Capote"
	},
	{
		title: "The stranger beside me",
		genre: "True Crime",
		author: "Ann Rule"
	},
	{
		title: "Helter Skelter",
		genre: "True Crime",
		author: "Vincent Bugliosi and Curt Gentry"
	},
	{
		title: "The Shining",
		genre: "Horror",
		author: "Stephen King"
	},
	{
		title: "Carrie",
		genre: "Horror",
		author: "Stephen King"
	},
	{
		title: "Pet cemetary",
		genre: "Horror",
		author: "Stephen King"
	},
	{
		title: "The fault in our stars",
		genre: "Young Adult",
		author: "John Green"
	},
	{
		title: "The maze runner",
		genre: "Young Adult",
		author: "James Dashner"
	},
	{
		title: "Insurgent",
		genre: "Young Adult",
		author: "Veronica Roth"
	},
	{
		title: "Pride and Prejudice",
		genre: "Romance",
		author: "Jane Austen"
	},
	{
		title: "Beautiful Disaster",
		genre: "Romance",
		author: "Jamie McGuire"
	},
	{
		title: "Bared to you",
		genre: "Romance",
		author: "Sylvia Day"
	}
	];

	$scope.status = {
	isFirstOpen: true,
	isFirstDisabled: false
	};
}]);

