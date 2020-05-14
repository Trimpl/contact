function select() {
	var len = Math.random() * 1000000000;
	var color = $('#Color').val();
	var text = $('#Text').val();
	var border = $('#Border').val();
	var string = $('#string').val();
	var integer = $('#integer').val();
	var boolean = $('#bool').val();
	var date = $('#date').val();
	if (document.getElementById("selectt").options.selectedIndex == 0) {
		$('div#add_field_area').append('<div id="' + len + '" class="row justify-content-center my-3"><div class="input-group col-lg-4 col-md-6 border-0"><div class="input-group-prepend border-0"><span class= "input-group-text border-0" style="' + color + '">' + integer + '</span></div><textarea class="form-control ' + text + ' ' + border + '" id="Int" name="Int" aria-label="With textarea" style="' + color + '"></textarea>' +
			'<button class="btn btn-lg btn-danger" onclick="deleteField(' + len + ')" ><i class="fas fa-trash-alt"></i></button ></div ></div> ');
	}
	if (document.getElementById("selectt").options.selectedIndex == 1) {
		$('div#add_field_area').append('<div id="' + len + '" class="row justify-content-center my-3"><div class="input-group col-lg-4 col-md-6 border-0"><div class="input-group-prepend border-0"><span class= "input-group-text border-0" style="' + color + '">' + string + '</span></div><textarea class="form-control ' + text + ' ' + border +  '" id="Str" name="Str" aria-label="With textarea" style="' + color +'"></textarea>' +
			'<button class="btn btn-lg btn-danger" onclick="deleteField(' + len + ')" ><i class="fas fa-trash-alt"></i></button ></div > ');
	}
	if (document.getElementById("selectt").options.selectedIndex == 2) {
		$('div#add_field_area').append('<div id="' + len + '" class="row justify-content-center my-3"><div class="input-group col-lg-4 col-md-6 border-0"><div class="input-group-prepend border-0"><span class= "input-group-text border-0" style="' + color + '">' + date + '</span></div><textarea class="form-control ' + text + ' ' + border +  '" id="Date" name="Date" aria-label="With textarea" style="' + color +'"></textarea>' +
			'<button class="btn btn-lg btn-danger" onclick="deleteField(' + len + ')" ><i class="fas fa-trash-alt"></i></button ></div > ');
	}
	if (document.getElementById("selectt").options.selectedIndex == 3) {
		$('div#add_field_area').append('<div id="' + len + '" class="row justify-content-center my-3"><div class="input-group col-lg-4 col-md-6 border-0"><div class="input-group-prepend border-0"><span class= "input-group-text border-0" style="' + color + '">' + boolean + '</span></div><textarea class="form-control ' + text + ' ' + border + '" id="Bool" name="Bool" aria-label="With textarea" style="' + color +'"></textarea>' +
			'<button class="btn btn-lg btn-danger" onclick="deleteField(' + len + ')" ><i class="fas fa-trash-alt"></i></button ></div > ');
	}
}
function deleteField(id) {
	var child = document.getElementById(id);
	child.remove();
}
function upload(file) {
	if (!file || !file.type.match(/image.*/)) return;
	var fd = new FormData();
	fd.append("image", file);
	fd.append("title", "stepa123");
	fd.append("client_secret", "bda650e874b80220bab96aa22c383a5e4581cead");

	var xhr = new XMLHttpRequest();
	xhr.open("POST", "https://api.imgur.com/3/image");
	xhr.setRequestHeader('Authorization', 'Client-ID 1337b94d530e99b');
	xhr.onload = function () {
		$("#imgur_link").val(JSON.parse(xhr.responseText).data.link);
		$("#Label").text(file.name);
		$("#cartinka").empty();
		$("#cartinka").append('<img style="width:100%;max-width:900px;max-height:500px;" class="mx-auto rounded shadow mb-3" src="' + JSON.parse(xhr.responseText).data.link + '" />');
	}
	xhr.send(fd);
}

function json() {
	$('#json').val();
}