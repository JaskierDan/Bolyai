<?php
    $server = 'localhost';
    $user = 'root';
    $pass = '';
    $db = 'csharptest';
    $conn = new mysqli($server, $user, $pass, $db) or die("Can't connect!");
    $sql = "SELECT * From students";
    $result = $conn->query($sql);
    if($result->num_rows > 0)
    {
        while($row = $result->fetch_assoc())
        {
            echo $row["id"]. "\t" . $row["StudentID"]. "\t" . $row["StudentFName"]. "\t" . $row["StudentLName"]. "<br>";
        }
    }
    else
    {
        echo "0 results";
    }
    $conn->close();
?>
