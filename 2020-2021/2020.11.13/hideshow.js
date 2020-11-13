let login = document.getElementById("login");

function hideLogin(){
    login.style.transition = "1s";
    login.style.top = "-50%";
}

function showLogin(){
    login.style.transition = "1s";
    login.style.top = "50%";
}

function checkSignUpForm(){
    let x_name = document.forms["signupForm"]["user"].value;
    let x_pwd = document.forms["signupForm"]["pwd"].value;

    if(x_name == "" || x_pwd == ""){
        alert("Please fill out all the input fields!");
        return false;
    }
}

function checkLoginForm(){
    let y_name = document.forms["loginForm"]["user"].value;
    let y_pwd = document.forms["loginForm"]["pwd"].value;

    if(y_name == "" || y_pwd == ""){
        alert("Please fill out all the input fields!");
        return false;
    }
}