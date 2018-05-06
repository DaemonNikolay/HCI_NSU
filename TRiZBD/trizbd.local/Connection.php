<?php

$host = 'localhost'; //имя хоста (для локального сервера localhost)
$database = 'Trizbd2504'; //имя базы данных
$user = 'root'; //имя пользователя СУБД (по умолчанию: root)
$password = ''; //пароль пользователя (по умолчанию: ничего)

$link = mysqli_connect($host, $user, $password, $database) //устанавливаем соединение
or die("Error: " . mysqli_error($link)); //если возникнет ошибка подключения - выведем на экран