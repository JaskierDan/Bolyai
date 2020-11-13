let login = document.getElementById("login");

function hideLogin(){
    login.style.transition = "1s";
    login.style.top = "-50%";
}

function showLogin(){
    login.style.transition = "1s";
    login.style.top = "50%";
}