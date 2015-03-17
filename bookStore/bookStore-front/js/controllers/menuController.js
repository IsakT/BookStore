app.controller("menuController", ["$scope", "$rootScope", function($scope, $rootScope){
	

	var loggedIn;

	$scope.logIn = function(userName,password){
		if(userName == null && password == null){
			loggedIn = true;
			alertWindow();
			if(loggedIn){
				$scope.showAdd = true;
				$scope.hideLogIn = true;
				$scope.showLogOut = true;
				$rootScope.showEdit = true;
				$rootScope.showSave = true;
				$rootScope.showTxtEdit = true;
				console.log("Logged in as Admin")
			};
	}

	}
	$scope.logOut = function(){
		loggedIn = false;
		if(!loggedIn){
			$scope.showAdd = false;
			$scope.hideLogIn = false;
			$scope.showLogOut = false;
			$rootScope.showEdit = false;
			$rootScope.showSave = false;
			$rootScope.showTxtEdit = false;
			console.log("Logged out")
		};
	}

	var alertWindow = function(){
		var w = window.open('','','width=200,height=200')
			w.document.write('Logged in successfully as: ')
			w.focus()
			setTimeout(function() {w.close();}, 2000)
	}

}]);