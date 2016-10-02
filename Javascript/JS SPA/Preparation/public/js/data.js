/* globals requester localStorage */
let dataService = {
    cookies(){
        return requester.getJSON('/api/cookies');
    },

    login(user) {
        return requester.putJSON("/api/auth", user)
            .then(respUser => {
                localStorage.setItem("username", respUser.result.username);
                localStorage.setItem("authKey", respUser.result.authKey);
            });
    },

    logout(){
        return Promise.resolve()
            .then(()=>{
                localStorage.removeItem('username');
                localStorage.removeItem('authKey');
                
            });
    },

    isLoggedIn(user){
        return Promise.resolve()
            .then(() => {
                return !!localStorage.getItem('username');
            })
    },

    register(user) {
        return requester.postJSON("/api/users", user);
    },

    addCookie(data){
        var options = {
            headers: {
                "x-auth-key" : localStorage.authKey
            }
        }
        return requester.postJSON('/api/cookies', data , options);
    },

    rateCookie(cookieId , type ){
        var options = {
            headers: {
                "x-auth-key" : localStorage.authKey
            }
        }
        return requester.putJSON('/api/cookies/'+cookieId , { type } , options );
    }
}