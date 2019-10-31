<?php
    include("connect.php");
    if ($query = $conexion->prepare("select id from secthab where ocupado=0 limit 1")){
        $query->execute();
        $query->bind_result($id );
        $query->fetch();
        $query->close();
        if ($query = $conexion->prepare("INSERT INTO alarma values ('',curdate(),curtime(),null,1,?)")) {
            $query->bind_param("s", $id);
            $query->execute();
            $query->close();
            if ($query = $conexion->prepare("update secthab set ocupado=1 where id=?")) {
                $query->bind_param("s", $id);
                $query->execute();
                $query->close();
                header("Status: 301 Moved Permanently");
                header("Location: ../paginaInfo.html");
            }
        }
    }
    echo "<script
    type='text/javacript'>alert('Alarma activada');
    </script>";
    
?>