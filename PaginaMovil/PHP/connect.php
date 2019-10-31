<?php
	$server = "LocalHost:3307";
	$user = "root";
	$password = "";
	$db = "DBHosp";
	$conexion = mysqli_connect($server, $user, $password, $db);

	mysqli_set_charset($conexion, "utf8");	
?>