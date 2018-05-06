<?php

require_once "Connection.php";


$id = $_REQUEST['id'];
$login = $_REQUEST['login'];
$surname = $_REQUEST['surname'];
$name = $_REQUEST['name'];
$address = $_REQUEST['address'];
$sex = $_REQUEST['sex'];
$password = $_REQUEST['password'];
$email = $_REQUEST['email'];

$sql = "SELECT password FROM user WHERE id=$id";
$query = mysqli_query($link, $sql) or die();
$dataFromTable = mysqli_fetch_assoc($query);

if ($password == $dataFromTable['password']) {
    $sql = "UPDATE user set login='$login', surname='$surname', name='$name', address='$address', sex='$sex', password='$password', email='$email' WHERE id=$id";
} else {
    $password = md5($password);
    $sql = "UPDATE user set login='$login', surname='$surname', name='$name', address='$address', sex='$sex', password='$password', email='$email' WHERE id=$id";
}

$query = mysqli_query($link, $sql) or die("error update");

mysqli_close($link);
?>

<HTML>
<HEAD>
    <META HTTP-EQUIV='Refresh' CONTENT='0; URL=index.php'>
</HEAD>