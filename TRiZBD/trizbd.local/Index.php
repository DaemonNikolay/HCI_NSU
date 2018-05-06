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
    <div>
        <a href="FormInsert.php"><input class="inputStandard" type="button" value="Добавить"/></a>
    </div>

    <div>
        <input type="text" id="search_login" placeholder="Поиск по логину..."/>
        <a id="search" href="SearchUser.php?login="><input onclick="Replace_link();" id="buttonSeacrh"
                                                           class="inputStandard"
                                                           type="button"
                                                           value="Найти"/></a>
    </div>

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
                echo "<td>" . "<a href=FormEdit.php?id=" . $row['id'] . ">Изменить</a></td>";
                echo "<td>" . "<a href=DeleteUser.php?id=" . $row['id'] . ">Удалить</a></td>";
                ?>
            </tr>
            <?php
        }
        ?>
    </table>

    <script>
        function Replace_link() {
            document.querySelector('#search').setAttribute('href', 'SearchUser.php?login=' + document.getElementById("search_login").value);
            document.getElementById("search_login").value = "";
        }
    </script>
<?php


mysqli_close($link);

include_once("footer.php");