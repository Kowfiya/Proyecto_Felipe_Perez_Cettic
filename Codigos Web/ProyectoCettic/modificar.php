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
					<li class = "active"><a href="modificar.php">Modificar Juego</a></li>
					<li><a href="puntajes.php">Puntuaciones</a></li>
					<li><a href="registrarse.php">Registro de sesion</a></li>
				</ul>
			</div>
			<div class="main">
				<div class="content">
				<h1>Dato</h1>
				<form action="conjson.php" method="post">
				<p>Velocidad:<input type="text" name="velocidad" placeholder="Velocidad"></p>
				<p>Tiempo:<input type="text" name="tiempo" placeholder="Tiempo"></p>
				<p>Puntos:<input type="text" name="puntos" placeholder="Puntos"></p>
				<p><input type="submit" name="guardar"></p>
				</form>
				</div>
			</div>
		</div>
	</body>
</html>