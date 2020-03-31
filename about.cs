body {
  margin: 0px;
  padding: 0px;
  font-family: "Roboto", sans-serif;
  font-weight: 300;
  background-color: white;
}

p {
  line-height: 1.5rem;
  font-family: "Lora", serif;
}

h1, h2 {
  font-family: "Lora", serif;
  font-weight: 400;
}

h1 {
  font-size: 72pt;
}

h2 {
  font-size: 48pt;
}

nav {
  width: 100%;
  position: sticky;
  top: 0px;
  display: flex;
  z-index: 10;
  align-items: center;
  background-color: #1A1A1A;
}
nav a {
  text-decoration: none;
  color: #E00073;
  padding: 20px 50px;
  text-transform: uppercase;
}
nav a:hover {
  color: white;
}

@media screen and (min-width: 601px) {
  nav {
    justify-content: center;
  }
}
@media screen and (max-width: 600px) {
  nav {
    display: flex;
    flex-direction: column;
    align-items: flex-start;
    min-height: 50px;
  }
  nav a {
    padding: 2px 10px;
    display: none;
    background-color: #24002E;
  }

  nav:hover a {
    display: block;
  }
}
footer {
  height: 100px;
  width: 100%;
  background-color: #1A1A1A;
  margin: 0px;
  display: flex;
  justify-content: center;
  align-items: center;
}
footer a {
  text-decoration: none;
  color: grey;
  margin: 0px 50px;
}
footer a:hover {
  color: white;
}

.about {
  margin-top: 100px;
  display: flex;
  width: 100%;
  flex-direction: column;
  align-items: center;
}
.about .skills-container {
  display: flex;
  justify-content: space-around;
  flex-wrap: wrap;
  width: 50%;
  margin-bottom: 50px;
}
.about .skills-container .skill {
  display: flex;
  flex-direction: column;
  align-items: center;
  justify-content: space-between;
  margin: 0px 50px;
  font-family: "Roboto", sans-serif;
  font-weight: 300;
}
.about .skills-container .skill i {
  font-size: 48pt;
  color: #00FFBF;
}
.about .skills-container .skill img {
  width: 50px;
}
.about .bio {
  display: flex;
  justify-content: center;
  width: 80%;
  margin-bottom: 50px;
  margin-top: 50px;
}
.about .bio img {
  width: 300px;
  height: 300px;
  border: 1px solid black;
}
.about .bio p {
  width: 300px;
}
@media screen and (max-width: 600px) {
  .about .bio {
    flex-direction: column;
    align-items: center;
  }
  .about .bio p {
    margin-top: 20px;
  }
}
@media screen and (min-width: 601px) {
  .about p {
    margin-left: 20px;
    margin-top: 0px;
  }
}
.about .links-container {
  display: flex;
  align-items: center;
  margin-bottom: 50px;
  width: 50%;
  flex-wrap: wrap;
}
.about .links-container a {
  text-decoration: none;
  background-color: white;
  color: #E00073;
  border: 2px solid #E00073;
  padding: 10px;
  border-radius: 5px;
  margin: 20px 20px;
}
.about .links-container a:hover {
  color: white;
  background-color: #E00073;
}

/*# sourceMappingURL=about.cs.map */
