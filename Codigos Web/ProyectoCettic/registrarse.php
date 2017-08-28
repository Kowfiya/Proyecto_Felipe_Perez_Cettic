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
					<li><a href="puntajes.php">Puntuaciones</a></li>
					<li class="active"><a href="registrarse.php">Registro de sesion</a></li>
				</ul>
			</div>
			<div class="main">
				<div class="content">
				<h1>Ingreso</h1>
				<form action="Login.php" method="post">
				<p>Usuario:<input type="text" name="usernamePost" placeholder=" Usuario"></p>
				<p>Password:<input type="text" name="passwordPost" placeholder=" password"></p>
				<p><input type="submit" name="guardar"></p>
				</form>
				<br>
				<h1>Registro</h1>
				<form action="registrarUsuario.php" method="post">
				<p>Usuario:<input type="text" name="usernamePost" placeholder=" Usuario"></p>
				<p>Email:<input type="text" name="emailPost" placeholder=" Email"></p>
				<p>Password:<input type="text" name="passwordPost" placeholder=" Password"></p>
				<p><input type="submit" name="guardar2"></p>
				</form>
				</div>
			</div>
		</div>
		<?php
		if(isset($_POST['submit'])){
			require("registrarUsuario.php");
		}
	?>
	</body>
</html>