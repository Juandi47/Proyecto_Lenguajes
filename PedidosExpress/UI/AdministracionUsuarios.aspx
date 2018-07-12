<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="AdministracionUsuarios.aspx.cs" Inherits="UI.AdministracionUsuarios1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" />
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>

    <link href="Diseños/estilo.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="row1" style="background-color: darkslategray">
        <div class="container">
            <div class="col-md-5">
                <div class="form">

                    <br />
                    <div class="form-group">
                        <h2>Modificar</h2>
                        <br />
                        <br />
                        <input class="form-control" type="text" id="txtNombreMod" value="" placeholder="Nombre Usuario" runat="server" />
                        <br />
                        <br />
                        <input class="form-control" type="text" id="txtCedulaMod" value="" placeholder="Cedula Usuario" runat="server" />
                        <br />
                        <br />
                        <asp:DropDownList ID="lista1" runat="server">
                        </asp:DropDownList>
                        <br />
                        <br />
                        <asp:Button CssClass="btn-success" ID="btnModificar" runat="server" OnClick="aceptarBTNmodificar_Click" Text="Modificar" />
                        <br />
                        <br />
                    </div>
                </div>
            </div>

            <div class="col-md-5">
                <div class="form">
                    <br />
                    <div class="form-group">
                        <h2>Agregar Usuario</h2>
                        <br />
                        <br />
                        <input class="form-control" type="text" id="txtNombreAdd" value="" placeholder="Nombre Usuario" runat="server" />
                        <br />
                        <br />
                        <input class="form-control" type="text" id="txtCedulaAdd" value="" placeholder="Cedula Usuario" runat="server" />
                        <br />
                        <br />
                        <asp:DropDownList ID="lista2" runat="server">
                        </asp:DropDownList>
                        <br />
                        <br />
                        <asp:Button CssClass="btn-success" ID="btnAgregar" runat="server" OnClick="aceptarBTNagregar_Click1" Text="Agregar" />
                        <br />
                        <br />
                    </div>
                </div>
            </div>

            <div class="col-md-5">
                <div class="form">
                    <br />
                    <div class="form-group">
                        <h2>Buscar por Cedula:</h2>
                        <br />
                        <input class="form-control" type="text" id="txtCedulaBus" value="" placeholder="cedula" runat="server" />
                        <br />
                        <input class="form-control" type="text" id="txtNombreBus" value="" placeholder="nombre" runat="server" />
                        <br />
                        <asp:Button CssClass="btn-success" ID="btnBuscar" runat="server" OnClick="aceptarBTNconsultar_Click" Text="Buscar" />
                        <br />
                        <label id="LabelPlatoBusqueda" runat="server"></label>

                    </div>
                </div>
            </div>

            <div class="col-md-5">
                <div class="form">
                    <br />
                    <div class="form-group">
                        <h2>Eliminar por cedula:</h2>
                        <br />
                        <input class="form-control" type="text" id="txtCedulaEli" value="" placeholder="Cedula" runat="server" />
                        <br />
                        <input class="form-control" type="text" id="txtNombreEli" value="" placeholder="Nombre" runat="server" />
                       
                        <br />
                        <asp:Button CssClass="btn-success" ID="btnEliminar" runat="server" OnClick="aceptarBTNeliminar_Click" Text="Eliminar" />
                        <br />
                    </div>
                </div>
            </div>

        </div>

    </div>



</asp:Content>
