<?php
include "connection.php";

if(isset($_POST['user']) && isset($_POST['pwd'])){
    $user = $_POST['user'];
    $pwd = $_POST['pwd'];
    $hash = password_hash($pwd, PASSWORD_DEFAULT);
    $sql = "INSERT INTO users (name, password) VALUES('$user', '$hash')";
    $conn->query($sql);
    header("Location: index.php");
}
else{
    header("Location: index.php");
}