var hamburger = document.querySelector("#hamburger");
var links = document.querySelectorAll(".nav-link");


hamburger.addEventListener("click", function() {
	console.log("CLICK WORKING!");
	for (var i = 0; i < links.length; i++) {
		if (links[i].style.display === 'flex' || 
			links[i].style.display === 'block') {
			links[i].style.display = 'none'
		} else {
			links[i].style.display = 'block'
		}
	}	
})



