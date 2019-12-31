<?php

$mysqli = new mysqli('sql100.epizy.com', 'epiz_22501813', 'DianaPereira', 'epiz_22501813_pkdata') or die(mysqli_error($mysqli));

if (isset($_POST['add'])){
    $id = $_POST['id'];
    $name = $_POST['name'];
    $catch = $_POST['catch'];
    $img = $_POST['img'];
    $type1 = $_POST['type1'];
    $type2 = $_POST['type2'];
    $categorie = $_POST['categorie'];
    $bio = $_POST['bio'];}

    $mysqli->query("INSERT INTO data (id, name, catch, img, type1, type2, categorie, bio) VALUES('$id', '$name', '$catch', '$img', '$type1', '$type2', '$categorie', '$bio' )") or die($mysqli->error)

    ?>