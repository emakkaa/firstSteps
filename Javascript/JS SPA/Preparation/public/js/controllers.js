/* globals  dataService templates $ Handlebars console*/
var handlebars = handlebars || Handlebars;

let controllers = {
    home() {
        var cookies;
        dataService.cookies()
            .then((cookiesResponse) => {
                cookies = cookiesResponse;
                console.log(cookies);

                return templates.get("home");
            })
            .then((templateHtml) => {
                let templateFunc = handlebars.compile(templateHtml);
                let html = templateFunc(cookies);
                $("#container").html(html);


                $('.btn-like-dislike').on('click',function(ev){
                    let type = $(this).attr("data-type");
                    let cookieId = $(this).parents("li").attr("data-id");
                    
                    dataService.rateCookie(cookieId , type);

                })   
            });

        
    },

    login(){
        dataService.isLoggedIn()
        .then(isLoggedIn => {
            if(isLoggedIn){
                window.location = '#/home';
                return;
            }


            templates.get('login')
                .then(templateHtml => {
                    let templateFunc = handlebars.compile(templateHtml);
                    let html = templateFunc();

                    
                    console.log(html);
                    $('#container').html(html);

                    $('#btn-login').on('click',() => {
                       let user = {
                            username: $("#tb-username").val(),
                            passHash: $("#tb-password").val()
                        };

                       dataService.login(user)
                        .then((respUser) => {
                            $(document.body).addClass("logged-in");
                            document.location = "#/home";
                        })
                    })

                    $('#btn-register').on('click',() => {
                        let user = {
                            username: $("#tb-username").val(),
                            passHash: $("#tb-password").val()
                        };
                       console.log(user);
                       dataService.register(user)
                        .then((respUser)=>{
                            
                            dataService.login(user);
                            
                        })
                        .then((respUser) =>{
                            $(document.body).addClass("logged-in");
                            document.location = "#/home";
                        })
                    })
                })
        })
    },

    addCookie(){
        templates.get('cookie-add')
            .then((templateHtml) => {
                var templateFunc = handlebars.compile(templateHtml);
                var html = templateFunc();

                $('#container').html(html);

                $('#btn-add').on('click',function(){
                    var cookie = {
                        text: $("#tb-text").val(),
                        img: $("#tb-img-url").val()
                    };
                    

                    dataService.addCookie(cookie)
                        .then(() => {
                            window.location = "#/home";
                        })
                })

                
            })
    }
}