<?php
	require("connect_db.php");

	$username=$_POST['usernamePost'];
	$pass=$_POST['passwordPost'];
	
	$sql=mysqli_query($mysqli,"SELECT * FROM usuarios WHERE username='$username'");
	if($f=mysqli_fetch_assoc($sql)){
		if($pass==$f['password']){
			echo "correcto,$username";
		}else{
			echo "mal";
		}
	}

?>