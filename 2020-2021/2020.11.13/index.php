<?php session_start();
    if(isset($_SESSION["logged-in"])){
        if($_SESSION["logged-in"] == true){
            header("Location: dashboard.php");
        }
    }
?>
<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Login</title>
    <link rel="stylesheet" href="style.css">
    <link rel="icon" href="assets/imgs/code.png">
</head>

<body>
    <form class="box" name="signupForm" onsubmit="return checkSignUpForm()" action="inc/signup.inc.php" method="POST">
        <h1>Sign Up</h1>
        <input type="text" name="user" placeholder="Username">
        <input type="password" name="pwd" placeholder="Password">
        <input type="submit" name="" value="Sign Up">
        <input type="button" onclick="showLogin()" name="" value="Login">
    </form>
    <form class="box" name="loginForm" id="login" onsubmit="return checkLoginForm()" action="inc/login.inc.php" method="POST">
        <h1>Login</h1>
        <input type="text" name="user" placeholder="Username">
        <input type="password" name="pwd" placeholder="Password">
        <input type="submit" name="" value="Login">
        <input type="button" onclick="hideLogin()" name="" value="Sign Up">
    </form>

</body>
<script src="hideshow.js"></script>

</html>