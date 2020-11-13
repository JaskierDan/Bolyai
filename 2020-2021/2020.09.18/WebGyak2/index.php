<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Login</title>
    <link rel="stylesheet" href="style.css">
</head>
<body>
    <form class="box" action="inc/signup.inc.php" method="POST">
        <h1>Sign Up</h1>
        <input type="text" name="user" placeholder="Username">
        <input type="password" name="pwd" placeholder="Password"> 
        <input type="submit" name="" value="Sign Up">
        <input type="button" onclick="showLogin()" name="" value="Login">
    </form>
    <form class="box" id="login" action="inc/login.inc.php" method="POST">
        <h1>Login</h1>
        <input type="text" name="user" placeholder="Username">
        <input type="password" name="pwd" placeholder="Password"> 
        <input type="submit" name="" value="Login">
        <input type="button" onclick="hideLogin()" name="" value="Sign Up">
    </form>
    
</body>
<script src="hideshow.js"></script>
</html>