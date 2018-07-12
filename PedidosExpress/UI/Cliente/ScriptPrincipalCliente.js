function MostrarPlatos(){
	var req = $.ajax({
		url: "http://localhost:50408/WSRest/WSCliente.svc/listaPlatos",
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

	$.each(datos, function(){

		$("#carrito").attr("href","Carrito.html?cedula=" + getParameterByName('cedula'));

		var newLi = document.createElement("li");
		var newdiv = document.createElement("div");
		newdiv.setAttribute("id",this.nombrePlato);
		newdiv.setAttribute("style","background-color:white");
		var newRef = document.createElement("a");
		newRef.innerHTML = "Ver plato";
		newRef.setAttribute("id",this.nombrePlato);
		newRef.setAttribute("href","Plato.html?codigoPlato=" + this.codigoPlato + "&cedula=" + getParameterByName('cedula'));
		var newH = document.createElement("h4");
		newH.innerHTML = "Plato: " + this.nombrePlato;
		newdiv.appendChild(newH);
		var newP = document.createElement("p");
		newP.innerHTML += "Precio: " + this.precio;	
		newdiv.appendChild(newP);
		newdiv.appendChild(newRef);	
		newLi.appendChild(newdiv);
		$('#ListaPlatos').append(newLi);
	});
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

