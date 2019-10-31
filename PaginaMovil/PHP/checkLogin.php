<?php
	include("connect.php");
	$user = $_POST['name'];
	$password = $_POST['pass'];
	
	if ($query = $conexion->prepare("SELECT COUNT(*) as existe, contraseña FROM usuarios WHERE usuario = ?")) {

        $query->bind_param("s", $user);
        $query->execute();
        $query->bind_result($existe, $contraseña);
        $query->fetch();
        $query->close();

		if ($existe) {
            if (password_verify($password, password_hash($contraseña, PASSWORD_BCRYPT))) {
                session_start();
                $_SESSION['usuario'] = $user;
                header("Status: 301 Moved Permanently");
                header("Location: ../paginaBoton.html");
            } 
            else {
                echo "Error.";
            }        
        } 
        else {
            header("Status: 301 Moved Permanently");
            header("Location: ../index.html");
        }
	}
?>