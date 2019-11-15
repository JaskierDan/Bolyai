<?php
require "connection.php";

$sql = "SELECT id, CONCAT_WS(' ', name, class) as ossz FROM students";
$result = $conn->query($sql);
echo "<select>";
while($row=$result->fetch_assoc()){
    $id = $row['id'];
    $ossz = $row['ossz'];
    echo "
        <option value='".$id."'>".$ossz."</option>
    ";
}
echo "</select>";