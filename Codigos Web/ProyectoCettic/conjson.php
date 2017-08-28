<?php 
$datos = array(
		'Velocidad'=>$_POST['velocidad'],
		'Viempo'=>$_POST['tiempo'],
		'Vuntos'=>$_POST['puntos']
	);
	$json_data = json_encode($datos);
	file_put_contents('modifi.json', $json_data);
	header("Location: modificar.php");
?>

