


function MostrarVehiculos() {
    var req = $.ajax({
        url: "http://lucam593-001-site1.itempurl.com/WSRest/WSVehiculoRest.svc/listaVehiculos",
        timeout: 10000,
        dataType: "jsonp"
    });

    req.done(function (datos) {
        ProcesarVehiculos(datos);
    });

    req.fail(function () {
        alert("Error alconectar con el servicio");
    });
}

function ProcesarVehiculos(datos) {

    $.each(datos, function () {

        var newLi = document.createElement("li");

        var newH = document.createElement("h4");
        newH.innerHTML = "Vehículo con el VIN: " + this.VIN;
        newLi.appendChild(newH);


        var newP = document.createElement("p");
        newP.innerHTML += "Placa: " + this.Placa;
        newP.appendChild(document.createElement("br"));
        newP.innerHTML += "Marca: " + this.Marca;
        newP.appendChild(document.createElement("br"));
        newP.innerHTML += "Modelo: " + this.Modelo;
        newP.appendChild(document.createElement("br"));
        newP.innerHTML += "Año: " + this.anno;

        newLi.appendChild(newP);
        $('#ListaVehiculos').append(newLi);
    });
}