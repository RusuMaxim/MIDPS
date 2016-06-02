<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8"/>
<title>
Lab4MIDPS
</title>
<link href="style.css" rel="stylesheet" type="text/css"/>
<script type="text/javascript"src="jquery-1.12.4.min.js"></script>
<script>
	$(document).ready(function(){
		$("select[name='country']").bind("change", function(){
			$("select[name='city']").empty();
			$.get("countryCheck.php",{country:$
("select[name='country']").val()}, function(data){
				data =JSON.parse(data);
	
				for(var id in data) {
					$("select[name='city']").append($("<option value='" + id +"'>"+data[id]+"</option>"));
				}
			});
		});
	});
</script>
</head>
<body>
	<div class="message count">
	<label>Enter The Country</label>
	</div>
	<select name="country">
		<option value="0" selected="selected"></option>
		<option value="1">Germany</option>
		<option value="2">Italy</option>
		<option value="3">France</option>
		<option value="4">Russia</option>
		<option value="5">Moldova</option>
		<option value="6">Romania</option>
	</select>
	<div class="message cit">
	<label>City:</label>
	</div>
	<select name="city">
		<option value="0"></option>
	</select>
</body>
</html>