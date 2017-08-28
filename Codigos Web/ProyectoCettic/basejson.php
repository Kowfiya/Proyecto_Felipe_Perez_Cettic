<?php
$conn = mysqli_connect("localhost", "root", "", "proyecto");
if (!$conn) {
    die("Connection failed: " . mysqli_connect_error());
}

$sql    = "SELECT * FROM tablapuntaje";
$result = mysqli_query($conn, $sql);

if (mysqli_num_rows($result) > 0) {
    $rows = array();
    while ($row = mysqli_fetch_array($result)) {

        $rows[] = $row;
    }

    echo json_encode($rows);
	$json_data = json_encode($rows);
	file_put_contents('basePuntaje.json', $json_data);
	header("Location: puntajes.php");
} else {
    echo "Sin resultados";
}


mysqli_close($conn);
?>