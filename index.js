var hamburger = document.querySelector("#hamburger");
var links = document.querySelectorAll(".nav-link");

console.log("javascript file!");
console.log(hamburger);
console.log(links);

// hamburger.addEventListener("click", function() 
// { console.log("Hello World!"); });

hamburger.addEventListener("click", function() {
	console.log("CLICK WORKING!");
	for (var i = 0; i < links.length; i++) {
		if (links[i].style.display === 'flex' || links[i].style.display === 'block') {
			links[i].style.display = 'none'
		} else {
			links[i].style.display = 'block'
		}
	}	
})



