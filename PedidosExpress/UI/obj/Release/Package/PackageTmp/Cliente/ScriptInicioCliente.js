function Loguearse(){
	var req = $.ajax({
		url: "http://localhost:50408/WSRest/WSCliente.svc/logueo?NombreUsuario=" + $("#nombUser").val() + "&contrasenna=" + $("#contrasenna").val(),
		timeout:10000,
		dataType: "jsonp"
	});

	req.done(function(datos){
		ProcesarLogueo(datos);		
	});

	req.fail(function(){
		alert("Error alconectar con el servicio");
	});
}

function ProcesarLogueo(datos){
	if (datos) {
		window.location="PrincipalCliente.html?usuario=" + $("#nombUser").val();
	}
}