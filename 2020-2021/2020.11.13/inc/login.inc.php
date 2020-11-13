<?php
session_start();
include "connection.php";

$conn = new Connection();

if (isset($_POST['user']) && isset($_POST['pwd'])) {

    $user = $_POST['user'];
    $pwd = $_POST['pwd'];

    $conn->login($user, $pwd);
    
} else {

    header("Location: ../index.php");
}
