<?php
require "connection.php";

if(isset($_POST['access'])){
	$sql = "SELECT * From students";
    $result = $conn->query($sql);
    if($result->num_rows > 0)
    {
        while($row = $result->fetch_assoc())
        {
            echo $row["id"]. "\t" . $row["fName"]. "\t" . $row["lName"]. "\t" . "<br>";
        }
    }
    else
    {
        echo "0 results";
    }
    $conn->close();
}
else{
	header("Location: index.php");
}
