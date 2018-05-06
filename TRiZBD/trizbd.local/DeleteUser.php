<?php

require_once "Connection.php";


$id = $_REQUEST['id'];
$sql = "DELETE FROM user WHERE id=$id";

$query = mysqli_query($link, $sql) or die("error delete");

mysqli_close($link);

?>

<HTML>
<HEAD>
    <META HTTP-EQUIV='Refresh' CONTENT='0; URL=Index.php'>
</HEAD>