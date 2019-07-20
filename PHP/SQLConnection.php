<?php

$db_host = "localhost";//host of the database
$db_username = "root";// database username
$db_pass = "";// database password
$db_name = "test_database";//database name

@mysql_connect("$db_host","$db_username","$db_pass") or die ("Could not connect to MySql.");
@mysql_select_db("$db_name") or die ("No Database");

/* echo"Successful Connection"; *///I usually add this when first connect to make sure I have a connection then comment out

?>