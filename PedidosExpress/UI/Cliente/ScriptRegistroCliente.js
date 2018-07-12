function Registrarse(){
	var req = $.ajax({
		url: "http://localhost:50408/WSRest/WSCliente.svc/RegistrarCliente?cedula=" + $("#cedula").val() + "&Nombre=" + $("#nombre").val() + "&Apellido1=" + $("#apellido1").val() + "&Apellido2=" + $("#apellido2").val() + "&correo=" + $("#correo").val() + "&contrasenna=" + $("#contrasenna").val() + "&CodPostal=" + $("#codPostal").val() + "&NombreUsuario=" + $("#nombreUsuario").val() + "&Provincia=" + $("#provincia").val() + "&Canton=" + $("#canton").val() + "&Distrito=" + $("#distrito").val(),
		timeout:10000,
		dataType: "jsonp"
	});

	req.done(function(datos){
		ProcesarRegistro(datos);		
	});

	req.fail(function(){
		alert("Error alconectar con el servicio");
	});
}

function ProcesarRegistro(datos){
	alert(datos);
	window.location="InicioCliente.html";
}