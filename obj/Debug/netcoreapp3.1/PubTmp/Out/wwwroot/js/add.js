function select() {
	if (document.getElementById("selectt").options.selectedIndex == 0 && document.getElementById("int1") == null) {
		$('div#add_field_area').append('<div id="int1"><label>Int1</label><input type = "text" name="Int1" width = "60" name = "val[]" id = "val" value = '+
			'"" /> <a class="btn" onclick="deleteField('+"'int1'"+')" ></a ></div > ');
	};
	if (document.getElementById("selectt").options.selectedIndex == 1 && document.getElementById("int2") == null) {
		$('div#add_field_area').append('<div id="int2"><label>Int2</label><input type = "text" name="Int2" width = "60" name = "val[]" id = "val" value = ' +
			'"" /> <a class="btn" onclick="deleteField(' + "'int2'" + ')" ></a ></div > ');
	};
	if (document.getElementById("selectt").options.selectedIndex == 2 && document.getElementById("int3") == null) {
		$('div#add_field_area').append('<div id="int3"><label>Int3</label><input type = "text" name="Int3" width = "60" name = "val[]" id = "val" value = ' +
			'"" /> <a class="btn" onclick="deleteField(' + "'int3'" + ')" ></a ></div > ');
	};
	if (document.getElementById("selectt").options.selectedIndex == 3 && document.getElementById("str1") == null) {
		$('div#add_field_area').append('<div id="str1"><label>String1</label><input type = "text" name="String1" width = "60" name = "val[]" id = "val" value = ' +
			'"" /> <a class="btn" onclick="deleteField(' + "'str1'" + ')" ></a ></div > ');
	};
	if (document.getElementById("selectt").options.selectedIndex == 4 && document.getElementById("str2") == null) {
		$('div#add_field_area').append('<div id="str2"><label>String2</label><input type = "text" name="String2" width = "60" name = "val[]" id = "val" value = ' +
			'"" /> <a class="btn" onclick="deleteField(' + "'str2'" + ')" ></a ></div > ');
	};
	if (document.getElementById("selectt").options.selectedIndex == 5 && document.getElementById("str3") == null) {
		$('div#add_field_area').append('<div id="str3"><label>String3</label><input type = "text" name="String3" width = "60" name = "val[]" id = "val" value = ' +
			'"" /> <a class="btn btn-outline-danger" onclick="deleteField(' + "'str3'" + ')" ></a ></div > ');
	};
	if (document.getElementById("selectt").options.selectedIndex == 6 && document.getElementById("date1") == null) {
		$('div#add_field_area').append('<div id="date1"><label>Date1</label><input type = "text" name="Date1" width = "60" name = "val[]" id = "val" value = ' +
			'"" /> <a class="btn" onclick="deleteField(' + "'date1'" + ')" ></a ></div > ');
	};
	if (document.getElementById("selectt").options.selectedIndex == 7 && document.getElementById("date2") == null) {
		$('div#add_field_area').append('<div id="Date2"><label>Date2</label><input type = "text" name="Date2" width = "60" name = "val[]" id = "val" value = ' +
			'"" /> <a class="btn" onclick="deleteField(' + "'Date2'" + ')" ></a ></div > ');
	};
	if (document.getElementById("selectt").options.selectedIndex == 8 && document.getElementById("date3") == null) {
		$('div#add_field_area').append('<div id="Date3"><label>Date3</label><input type = "text" name="Date3" width = "60" name = "val[]" id = "val" value = ' +
			'"" /> <a class="btn" onclick="deleteField(' + "'Date3'" + ')" ></a ></div > ');
	};
	if (document.getElementById("selectt").options.selectedIndex == 9 && document.getElementById("Bool1") == null) {
		$('div#add_field_area').append('<div id="Bool1"><label>Bool1</label><input type = "text" name="Bool1" width = "60" name = "val[]" id = "val" value = ' +
			'"" /> <a class="btn" onclick="deleteField(' + "'Bool1'" + ')" ></a ></div > ');
	};
	if (document.getElementById("selectt").options.selectedIndex == 10 && document.getElementById("Bool2") == null) {
		$('div#add_field_area').append('<div id="Bool2"><label>Bool2</label><input type = "text" name="Bool2" width = "60" name = "val[]" id = "val" value = ' +
			'"" /> <a class="btn" onclick="deleteField(' + "'Bool2'" + ')" ></a ></div > ');
	};
	if (document.getElementById("selectt").options.selectedIndex == 11 && document.getElementById("Bool3") == null) {
		$('div#add_field_area').append('<div id="Bool3"><label>Bool3</label><input type = "text" name="Bool3" width = "60" name = "val[]" id = "val" value = ' +
			'"" /> <a class="btn" onclick="deleteField(' + "'Bool3'" + ')" ></a ></div > ');
	};
}
function deleteField(id) {
	if (document.getElementById(id) != null) {
		alert("gay");
	};
	var child = document.getElementById(id);
	child.remove();
}
function upload(file) {
	alert("pidr");
	if (!file || !file.type.match(/image.*/)) return;
	var fd = new FormData();
	fd.append("image", file);
	fd.append("title", "stepa123");
	fd.append("client_secret", "bda650e874b80220bab96aa22c383a5e4581cead");

	var xhr = new XMLHttpRequest();
	xhr.open("POST", "https://api.imgur.com/3/image");
	xhr.setRequestHeader('Authorization', 'Client-ID 1337b94d530e99b');
	alert("gay");
	xhr.onload = function () {
		$("#imgur_link").val(JSON.parse(xhr.responseText).data.link);
	}
	xhr.send(fd);
}
