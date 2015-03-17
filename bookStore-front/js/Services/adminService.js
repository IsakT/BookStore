app.factory("adminService", function(){
	return{
			login: function(display){
				display.showAdd = !display.showAdd;
				if(display.showAdd){
					console.log("Logged in as Admin");
				};		
		  	}
		  };
});