<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>WebGyak1</title>
</head>
<body>
<!--<form action="script.php" method="post">
    <input type="password" name="name">
    <input type="submit">
</form>-->
<form action="createacc.php" method="post">
    <input type="text" placeholder="Username" name="user"><br>
    <input type="password" placeholder="Password" name="pwd"><br>
    <input type="submit" value="Create Account">
</form>
<form action="login.php" method="post">
    <input type="text" placeholder="Username" name="user"><br>
    <input type="password" placeholder="Password" name="pwd"><br>
    <input type="submit" value="Login">
</form>
</body>
</html>