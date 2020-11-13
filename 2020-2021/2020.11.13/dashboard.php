<?php session_start();
if (!isset($_SESSION["logged-in"])) {
    header("Location: index.php");
}
?>
<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Dashboard</title>
    <link rel="stylesheet" href="style.css">
    <link rel="icon" href="assets/imgs/code.png">
</head>

<body>
    <form class="box" action="inc/logout.inc.php" method="POST">
        <input type="submit" value="Log out">
        <input type="button" onclick="showInput()" value="Back">
    </form>

    <form class="box" id="input-field" name="personalInfo" onsubmit="return showAlert()" action="inc/filldata.inc.php" method="POST">
        <label for="input">User: <?php echo $_SESSION["user"]; ?></label>
        <input type="text" name="fullName" placeholder="Full name">
        <input type="text" name="email" placeholder="E-mail">
        <input type="submit" value="Input data">
        <input type="button" onclick="showUpdate()" value="Update">
        <input type="button" onclick="hideInput()" value="Log out">
    </form>

    <form class="updatebox" id="update-field" name="updatePersonalInfo" onsubmit="return showUpdateAlert()" action="inc/updatedata.inc.php" method="POST">
        <label for="input">User: <?php echo $_SESSION["user"]; ?></label>
        <input type="text" name="fullName" placeholder="Full name">
        <input type="text" name="email" placeholder="E-mail">
        <input type="submit" value="Update data">
        <input type="button" onclick="hideUpdate()" value="Back">
    </form>

</body>
<script src="alert.js"></script>
<script src="input.js"></script>

</html>