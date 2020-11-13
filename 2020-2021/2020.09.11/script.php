<?php

if(isset($_POST["name"])){
    $pwd = $_POST["name"];
    $hash = password_hash($pwd, PASSWORD_DEFAULT);
    echo $hash;
}
else{
    header("Location: index.php");
}