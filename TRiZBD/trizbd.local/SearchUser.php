<?php

require_once "Connection.php";
require_once "header.php";


$login = $_REQUEST['login'];

$sql = "SELECT * FROM user WHERE login='$login'";
$result = mysqli_query($link, $sql) or die("Error " . mysqli_error($link));

?>
    <div>
        <input class="inputStandard" type="button" onclick="history.back();" value="Назад"/>
    </div>

    <table border="1">
        <tr>
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
                echo "<td>" . $row['login'] . "</td>";
                echo "<td>" . $row['surname'] . "</td>";
                echo "<td>" . $row['name'] . "</td>";
                echo "<td>" . $row['address'] . "</td>";
                echo "<td>" . $row['sex'] . "</td>";
                echo "<td>" . $row['password'] . "</td>";
                echo "<td>" . $row['email'] . "</td>";
                echo "<td>" . "<a href=FormEdit.php?id=" . $row['id'] . ">Изменить</a></td>";
                echo "<td>" . "<a href=DeleteUser.php?id=" . $row['id'] . ">Удалить</a></td>";
                ?>
            </tr>

            <?php
        }
        ?>
    </table>

<?php

require_once "footer.php";