<?php
session_start();
include "connection.php";
$conn = new Connection();

if(isset($_POST['fullName']) && isset($_POST['email'])){
    $user = $_SESSION['userID'];
    $f_name = $_POST['fullName'];
    $email = $_POST['email'];

    $conn->updateData($user, $f_name, $email);
}