<?php
include "connection.php";

if(isset($_POST['user']) && isset($_POST['pwd'])){
    $user = $_POST['user'];
    $pwd = $_POST['pwd'];
    $sql = "SELECT name, password FROM users WHERE name='$user'";
    $result = $conn->query($sql);
    while($row = $result->fetch_assoc()){
        $hashedPwd = $row['password'];
    }
    if(password_verify($pwd, $hashedPwd)){
        echo "Sikeres!";
    }
    else{
        echo "Sikertelen!";
    }
}
else{
    header("Location: index.php");
}