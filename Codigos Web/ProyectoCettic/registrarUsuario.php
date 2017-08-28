 <?php
$username = $_POST["usernamePost"];
$email = $_POST["emailPost"];
$password = $_POST["passwordPost"];

$conn = new mysqli("localhost", "root", "" ,"proyecto");
if (!$conn) {
    die("Connection failed: " . mysqli_connect_error());
}
$sql = "INSERT INTO usuarios (username, email, password)
VALUES ('$username', '$email', '$password')";

if (mysqli_query($conn, $sql)) {
    echo "Bien";
} else {
    echo "Error";
}

mysqli_close($conn);
?>