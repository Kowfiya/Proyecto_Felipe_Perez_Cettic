<!DOCTYPE html>
<html>
	<head>
		<title>Felipe Perez Cisternas</title>
		<link rel="stylesheet" href="style.css">
	</head>
	<body>
		<div class="container">
			<div class="sidebar">
				<h4 class="sitename"><a href="index.html">INICIO</a></h4>
				<ul>
					<li><a href="index.html">Home</a></li>
					<li><a href="modificar.php">Modificar Juego</a></li>
					<li class="active"><a href="basejson.php">Puntuaciones</a></li>
					<li><a href="registrarse.php">Registro de sesion</a></li>
				</ul>
			</div>
			<div class="main">
				<div class="content">
					<table cellspacing=1 cellpadding=2 style="font-size: 15pt"><tr>
	<td><font face="Usuario"><b>Usuario</b></font></td>
	<td><font face="Puntaje"><b>Puntaje</b></font></td>
	</tr>
	<?php  
	$servername = "localhost";
	$username = "root";
	$password = "";
	$dbName = "proyecto";
	
	$conn = new mysqli($servername, $username, $password, $dbName);
	if(!$conn){
		die("Connection Failed. ". mysqli_connect_error());
	}
  $sql = "SELECT * FROM tablapuntaje ORDER BY puntos DESC";
  $result = mysqli_query($conn, $sql);
  $numero = 0;
  while($row = mysqli_fetch_array($result))
  {

    echo "<tr><td width=\"25%\"><font face=\"ID\">" . 
	    $row["nombre"] . "</font></td>";
    echo "<td width=\"25%\"><font face=\"Usuario\">" . 
	    $row["puntos"] . "</font></td>";
  }
  
  mysqli_free_result($result);
  mysqli_close($conn);
?>
</table>
				</div>
			</div>
		</div>
	</body>
</html>