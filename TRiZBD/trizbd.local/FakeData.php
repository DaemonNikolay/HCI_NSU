<?php

require_once 'Faker/src/autoload.php';
require_once 'Connection.php';


function Generate_male_or_female()
{
    if (rand(0, 1) == 0) {
        return "female";
    }

    return "male";
}


$faker = Faker\Factory::create();

for ($i = 0; $i < 100; $i++) {
    $login = rand(0, 99999);
    $sex = Generate_male_or_female();
    $surname = $faker->lastName($gender = $sex);
    $name = $faker->firstName($gender = $sex);
    $address = $faker->country;
    $password = $faker->md5;
    $email = $faker->email;

    $query = "INSERT INTO user (login, surname, name, address, sex, password, email) " .
        " value('$login', '$surname', '$name', '$address', '$sex', '$password', '$email');";
    $result = mysqli_query($link, $query) or die("Error " . mysqli_error($link));

    echo $query, "<br />";
}

mysqli_close($link);