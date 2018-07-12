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
	var newh = document.createElement("h2");
	var newP = document.createElement("p");
	newP.setAttribute("style","font-size: 20px;");
	newh.innerHTML= "Plato: ";
	newP.innerHTML=  datos.nombrePlato;
	$("#IS").append(newh);
	$("#IS").append(newP);
	$("#IS").attr("style","background-color:white; border-style: solid; border-color: gray ");
	var newh2 = document.createElement("h2");
	var newP2 = document.createElement("p");
	newh2.innerHTML= "Precio: ";
	newP2.innerHTML= datos.precio;
	newP2.setAttribute("style","font-size: 20px;");
	$("#DS").append(newh2);
	$("#DS").append(newP2);
	$("#DS").attr("style","background-color:white; border-style: solid; border-color: gray ");
	var newh3 = document.createElement("h2");
	var newP3 = document.createElement("p");
	newh3.innerHTML= "Descripción: ";
	newP3.innerHTML= datos.descripcionPlato;
	newP3.setAttribute("style","font-size: 20px;");
	$("#DI").append(newh3);
	$("#DI").append(newP3);
	$("#DI").attr("style","background-color:white; border-style: solid; border-color: gray ");
	var newh4 = document.createElement("h2");
	var imagen = document.createElement("img");
	newh4.innerHTML= "Foto: ";
	imagen.setAttribute("id","imgSalida");
	imagen.setAttribute("width","50%");
	imagen.setAttribute("height","50%");
	imagen.setAttribute("src","Imagenes/" + datos.imagen);
	$("#II").append(newh4);
	$("#II").append(imagen);
	$("#II").append(document.createElement("br"));
	$("#II").append(document.createElement("br"));
	$("#II").attr("style","background-color:white; border-style: solid; border-color: gray ");

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

function agregarCarrito(){
	var plato = getParameterByName('codigoPlato');
	var cedula = getParameterByName('cedula');
	var req = $.ajax({
		url: "http://localhost:50408/WSRest/WSCliente.svc/agregarCarrito?cedula=" + cedula + "&plato=" + plato,
		timeout:10000,
		dataType: "jsonp"
	});

	req.done(function(datos){
		recargar(datos);
	});

	req.fail(function(){
		alert("Error alconectar con el servicio");
	});

}

function recargar(){
	window.location = "Plato.html?codigoPlato=" + plato + "&cedula=" + cedula;

}

function volver(){
	window.location = "PrincipalCliente.html?cedula=" + getParameterByName('cedula');

}