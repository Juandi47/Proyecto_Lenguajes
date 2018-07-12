function Loguearse(){
	var req = $.ajax({
		url: "http://localhost:50408/WSRest/WSCliente.svc/logueo?NombreUsuario=" + $("#nombUser").val() + "&contrasenna=" + $("#contrasenna").val(),
		timeout:10000,
		dataType: "jsonp"
	});

	req.done(function(datos){
		pasar(datos);
	});

	req.fail(function(){
		alert("Error alconectar con el servicio");
	});
}

function pasar(datos){
	if(datos != ""){
		window.location="PrincipalCliente.html?cedula=" + datos;
	}else{

		alert("Nombre de usuario o contraseña no validos");
	}
}