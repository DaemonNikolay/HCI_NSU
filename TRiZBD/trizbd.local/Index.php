<?php

$title = "Главная";

include_once("header.php");
include_once("Connection.php");


$query = "SELECT * FROM user";
$result = mysqli_query($link, $query) or die("Error " . mysqli_error($link));

if (!$result) {
    echo "Used query not complete...";
    exit;
}

?>
    <table border="1">
        <tr>
            <th hidden>Id</th>
            <th>Login</th>
            <th>Surname</th>
            <th>Name</th>
            <th>Address</th>
            <th>Sex</th>
            <th>Password</th>
            <th>Email</th>
            <th colspan="2">Действие</th>
        </tr>
        <?php

        while ($row = mysqli_fetch_assoc($result)) { ?>
            <tr>
                <?php
                echo "<td hidden>" . $row['id'] . "</td>";
                echo "<td>" . $row['login'] . "</td>";
                echo "<td>" . $row['surname'] . "</td>";
                echo "<td>" . $row['name'] . "</td>";
                echo "<td>" . $row['address'] . "</td>";
                echo "<td>" . $row['sex'] . "</td>";
                echo "<td>" . $row['password'] . "</td>";
                echo "<td>" . $row['email'] . "</td>";
                echo "<td>" . "<a href=EditUser.php?id=" . $row['id'] . ">Изменить</a></td>";
                echo "<td>" . "<a href=DeleteUser.php?id=" . $row['id'] . ">Удалить</a></td>";
                ?>
            </tr>
            <?php
        }
        ?>
    </table>
<?php


mysqli_close($link);

include_once("footer.php");