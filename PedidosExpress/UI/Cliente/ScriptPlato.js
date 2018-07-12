function MostrarPlatos(){
	var plato = getParameterByName('codigoPlato');
	$("#x").val(plato);
	var req = $.ajax({
		url: "http://localhost:50408/WSRest/WSCliente.svc/InfoPlato?codigoPlato=" + $("#x").val(),
		timeout:10000,
		dataType: "jsonp"
	});

	req.done(function(datos){
		ProcesarPlatos(datos);
	});

	req.fail(function(){
		alert("Error alconectar con el servicio");
	});
}

function ProcesarPlatos(datos){
	var newP = document.createElement("p");
	newP.innerHTML= datos.nombrePlato;
	$("#IS").append(newP);
}

function getParameterByName(name, url) {
    if (!url) url = window.location.href;
    name = name.replace(/[\[\]]/g, '\\$&');
    var regex = new RegExp('[?&]' + name + '(=([^&#]*)|&|#|$)'),
        results = regex.exec(url);
    if (!results) return null;
    if (!results[2]) return '';
    return decodeURIComponent(results[2].replace(/\+/g, ' '));
}