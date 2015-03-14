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
	  description: 'Jessica´s hand gently slid down Amandas back... And then they lived happily ever after, after having killed all the zombies in the universe. Their wedding ceremony was precided over by the Space Pope, who subsequenty joined them in a rather spirited threesome.'
	}
	];

	$scope.books = [
	{
		title: "Oh the things",
		author: "Derpy McHerpaderp"
	},
	{
		title: "Lions, umbrellas and moss - my life among the Gnolls",
		author: "Sweaty Bootrash"
	},
	{
		title: "Potatoes - are they just wierd goose eggs?",
		author: "Shrilly McWankersham"
	}
	];

	$scope.status = {
	isFirstOpen: true,
	isFirstDisabled: false
	};
}]);

