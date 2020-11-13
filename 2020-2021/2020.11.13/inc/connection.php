<?php
class Connection{
    
    function connect(){
        $conn = new mysqli("localhost", "root", "", "login") or die("Couldn't establish connection!");
        return $conn;
    }
    
    /* #region Login & SignUp */

    function login($user, $pwd){

        $conn = $this->connect();
        
        $sql = "SELECT id, name, password FROM users WHERE name='$user'";

        $result = $conn->query($sql);

        while ($row = $result->fetch_assoc()) {

            $hashedPwd = $row['password'];
            $_SESSION["user"] = $row['name'];
            $_SESSION["userID"] = $row['id'];
        }

        if (password_verify($pwd, $hashedPwd)) {

            $_SESSION["logged-in"] = true;
            header("Location: ../dashboard.php");
        } else {

            header("Location: ../index.php");
        }
    }

    function signup($user, $pwd){

        $conn = $this->connect();
        $userExistsSql = "SELECT name FROM users WHERE name='$user'";
        $result = $conn->query($userExistsSql);
        if(mysqli_num_rows($result) > 0){

            header("Location: ../index.php");
        }
        else{
            $hash = password_hash($pwd, PASSWORD_DEFAULT);
            $sql = "INSERT INTO users (name, password) VALUES('$user', '$hash')";
            $conn->query($sql);

            header("Location: ../index.php");
        }
    }
    /* #endregion */

    /* #region fillData & updateData */

    function fillData($user, $f_name, $email){

        $conn = $this->connect();
        $userExists = "SELECT userID FROM personaldata WHERE userID=$user";
        $result = $conn->query($userExists);

        if(mysqli_num_rows($result) > 0){
            header("Location: ../dashboard.php");
        }
        else{
            $sql = "INSERT INTO personaldata(id, userID, full_name, email) VALUES(NULL, ".$user.", '$f_name', '$email')";

            $conn->query($sql);

            header("Location: ../dashboard.php");
        }
    }

    function updateData($user, $f_name, $email){

        $conn = $this->connect();
        $userExists = "SELECT userID FROM personaldata WHERE userID=$user";
        $result = $conn->query($userExists);

        if(mysqli_num_rows($result) > 0){
            $sql = "UPDATE personaldata SET userID=$user, full_name='$f_name', email='$email' WHERE userID=$user";
            $conn->query($sql);
            header("Location: ../dashboard.php");
        }
        else{
            header("Location: ../dashboard.php");
        }  
    }
    /* #endregion */
}
