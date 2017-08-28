<?php
$usuario = $_POST["usuarioPost"];
$puntaje = $_POST["puntosPost"];

$conn = new mysqli("localhost", "root", "" ,"proyecto");
if (!$conn) {
    die("Connection failed: " . mysqli_connect_error());
}

$sql = "INSERT INTO tablapuntaje (nombre, puntos)
VALUES ('$usuario', '$puntaje')";

if (mysqli_query($conn, $sql)) {
    echo "Bien";
} else {
    echo "Error";
}

mysqli_close($conn);
?>