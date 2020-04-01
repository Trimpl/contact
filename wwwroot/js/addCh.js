function select() {
	var len = Math.random() * 1000000000;
	if (document.getElementById("selectt").options.selectedIndex == 0) {
		$('div#add_field_area').append('<div id="' + len + '" class="row justify-content-center my-3"><div class="input-group col-lg-4 col-md-6"><div class="input-group-prepend"><span class= "input-group-text bg-white">Int</span></div><textarea class="form-control" id="Int" name="Int" aria-label="With textarea"></textarea>' +
			'<button class="btn btn-lg btn-outline-danger" onclick="deleteField(' + len + ')" ><i class="fas fa-trash-alt"></i></button ></div ></div> ');
	}
	if (document.getElementById("selectt").options.selectedIndex == 1) {
		$('div#add_field_area').append('<div id="' + len + '" class="row justify-content-center my-3"><div class="input-group col-lg-4 col-md-6"><div class="input-group-prepend"><span class= "input-group-text bg-white">Str</span></div><textarea class="form-control" id="Str" name="Str" aria-label="With textarea"></textarea>' +
			'<button class="btn btn-lg btn-outline-danger" onclick="deleteField(' + len + ')" ><i class="fas fa-trash-alt"></i></button ></div > ');
	}
	if (document.getElementById("selectt").options.selectedIndex == 2) {
		$('div#add_field_area').append('<div id="' + len + '" class="row justify-content-center my-3"><div class="input-group col-lg-4 col-md-6"><div class="input-group-prepend"><span class= "input-group-text bg-white">Date</span></div><textarea class="form-control" id="Date" name="Date" aria-label="With textarea"></textarea>' +
			'<button class="btn btn-lg btn-outline-danger" onclick="deleteField(' + len + ')" ><i class="fas fa-trash-alt"></i></button ></div > ');
	}
	if (document.getElementById("selectt").options.selectedIndex == 3) {
		$('div#add_field_area').append('<div id="' + len + '" class="row justify-content-center my-3"><div class="input-group col-lg-4 col-md-6"><div class="input-group-prepend"><span class= "input-group-text bg-white">Bool</span></div><textarea class="form-control" id="Bool" name="Bool" aria-label="With textarea"></textarea>' +
			'<button class="btn btn-lg btn-outline-danger" onclick="deleteField(' + len + ')" ><i class="fas fa-trash-alt"></i></button ></div > ');
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
	}
	xhr.send(fd);
}

function json() {
	$('#json').val();
}