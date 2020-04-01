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
		if (links[i].style.display === 'none') {
			links[i].style.display = 'block'
		} else {
			links[i].style.display = 'none'
		}
	}	
})

