<?php

require_once "Connection.php";

$title = "Измение";

require_once "header.php";

$id = $_REQUEST['id'];

$sql = "SELECT * FROM user WHERE id=$id";
$query = mysqli_query($link, $sql) or die();

$dataFromTable = mysqli_fetch_assoc($query);
?>
    <div>
        <input class="inputStandard" type="button" onclick="history.back();" value="Назад"/>
    </div>

    <form action=EditUser.php>
        <fieldset>
            <legend>Регистрация:</legend>
            <input type=hidden name=id value="<? echo $dataFromTable['id'] ?>">
            <div class="field">
                <label>Login</label>
                <input class=inputForm type=text name=login value="<? echo $dataFromTable['login'] ?>">
            </div>
            <div class="field">
                <label>Surname</label>
                <input class=inputForm type=text name=surname value="<? echo $dataFromTable['surname'] ?>">
            </div>
            <div class="field">
                <label>Name</label>
                <input class=inputForm type=text name=name value="<? echo $dataFromTable['name'] ?>">
            </div>
            <div class="field">
                <label>Address</label>
                <input class=inputForm type=text name=address value="<? echo $dataFromTable['address'] ?>">
            </div>
            <div class="field">
                <label>Sex</label>
                <select name="sex">
                    <option disabled>Выберите пол</option>
                    <?php
                    if ($dataFromTable['sex'] == 'female') {
                        echo "<option selected>female</option>";
                        echo "<option>male</option>";;
                    } else {
                        echo "<option>female</option>";
                        echo "<option selected>male</option>";
                    }
                    ?>
                </select>
            </div>
            <div class="field">
                <label>Password</label>
                <input class=inputForm type=password name=password value="<? echo $dataFromTable['password'] ?>">
            </div>
            <div class="field">
                <label>Email</label>
                <input class=inputForm type=email name=email value="<? echo $dataFromTable['email'] ?>">
            </div>
            <div class="field">
                <input class=inputStandard type=submit name=submit value="Изменить">
            </div>
        </fieldset>
    </form>


<?php

require_once "footer.php";