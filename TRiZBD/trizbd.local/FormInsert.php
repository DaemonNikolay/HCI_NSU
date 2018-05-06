<?php

$title = "Добавление";

require_once "header.php";
require_once "Connection.php";


?>
    <div>
        <input class="inputStandard" type="button" onclick="history.back();" value="Назад"/>
    </div>

    <form method="post" action=InsertUser.php>
        <fieldset>
            <legend>Добавление:</legend>
            <div class="field">
                <label>Login</label>
                <input class=inputForm type=text name=login required>
            </div>
            <div class="field">
                <label>Surname</label>
                <input class=inputForm type=text name=surname required>
            </div>
            <div class="field">
                <label>Name</label>
                <input class=inputForm type=text name=name required>
            </div>
            <div class="field">
                <label>Address</label>
                <input class=inputForm type=text name=address required>
            </div>
            <div class="field">
                <label>Sex</label>
                <select name="sex">
                    <option selected>female</option>
                    <option>male</option>
                </select>
            </div>
            <div class="field">
                <label>Password</label>
                <input class=inputForm type=password name=password required>
            </div>
            <div class="field">
                <label>Email</label>
                <input class=inputForm type=email name=email required>
            </div>
            <div class="field">
                <input class=inputStandard type=submit name=submit value="Добавить">
            </div>
        </fieldset>
    </form>
<?php


require_once "footer.php";