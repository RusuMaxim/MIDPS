<?php
	if($_GET["country"]==1) echo  json_encode(array("1"=>"Berlin","2"=>"Hanover"));
	else if($_GET["country"]==2) echo json_encode(array("3"=>"Rome","4"=>"Napoli"));
	else if($_GET["country"]==3) echo json_encode(array("5"=>"Paris","6"=>"Bordeaux"));
	else if($_GET["country"]==4) echo json_encode(array("7"=>"Moscow","8"=>"St-Petersburg"));
	else if($_GET["country"]==5) echo json_encode(array("9"=>"Chisinau","10"=>"Balti"));
	else if($_GET["country"]==6) echo json_encode(array("11"=>"Bucuresti","12"=>"Iasi"));
?>
