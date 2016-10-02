/* globals  Navigo dataService */

let router = new Navigo(null , true);

router
    .on("login", controllers.login)
    .on("home", controllers.home)
    .on("cookie-add", controllers.addCookie)
    .on(() => {
        $("#main-nav .home a").addClass("active");
        router.navigate("/home");
    })
    .resolve();


$(".btn-nav-logout").on("click", () => {
    dataService.logout()
        .then(() => {
            $(document.body).removeClass("logged-in");
            
        });
        
});

dataService.isLoggedIn()
    .then(function(isLoggedIn){
        if(isLoggedIn){
            $(document.body).addClass("logged-in");
        }
    })