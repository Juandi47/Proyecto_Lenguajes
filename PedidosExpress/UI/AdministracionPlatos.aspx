<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="AdministracionPlatos.aspx.cs" Inherits="UI.AdministracionPlatos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Diseños/estilo.css" rel="stylesheet" type="text/css" /> 
   <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css"/>
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
     
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    &nbsp;
   
        <div class="row1" style="background-color: darkslategray">
            <div class="container">
            
            <div class="col-md-4">
                <div class="form">
                    <br />
                    <div class="form-group">
                        <h2>Modificar</h2>
                        <br />
                        <input class="form-control" type="text" id="txtCodigoMod" value="" placeholder="Codigo" runat="server" />
                        <br />
                        <input class="form-control" type="text" id="txtNombreMod" value="" placeholder="Nombre" runat="server" />
                        <br />
                        <input class="form-control" type="text" id="txtDescripcionMod" value="" placeholder="Descripcion" runat="server" />
                        <br />
                        <input class="form-control" type="text" id="txtPrecioMod" value="" placeholder="Precio" runat="server" />
                        <br />
                        <input class="form-control" type="text" id="txtEstadoMod" value="" placeholder="Estado" runat="server" />
                        <br />
                        <input class="form-control" type="text" id="txtImagenMod" value="" placeholder="Path imagen" runat="server" />
                        <br />
                        <br />
                        <asp:Button CssClass="btn-success" ID="btnModificar" runat="server" OnClick="btnModificar_Click" Text="Modificar" />
                    </div>
                </div>
            </div>

                <div class="col-md-3">
                    <div class="form">
                        <br />
                        <div class="form-group">
                            <h2>Agregar plato</h2>
                            <br />
                            <input class="form-control" type="text" id="txtCodigoAdd" value="" placeholder="Codigo" runat="server" />
                            <br />
                            <input class="form-control" type="text" id="txtNombreAdd" value="" placeholder="Nombre" runat="server" />
                            <br />
                            <input class="form-control" type="text" id="txtDescripcionAdd" value="" placeholder="Descripcion" runat="server" />
                            <br />
                            <input class="form-control" type="text" id="txtPrecioAdd" value="" placeholder="Precio" runat="server" />
                            <br />
                            <input class="form-control" type="text" id="txtEstadoAdd" value="" placeholder="Estado" runat="server" />
                            <br />
                            <input class="form-control" type="text" id="txtImagenAdd" value="" placeholder="Path imagen" runat="server" />
                            <br />
                            <br />
                            <asp:Button CssClass="btn-success" ID="btnAgregar" runat="server" OnClick="btnAgregar_Click" Text="Agregar" />
                        </div>
                    </div>
                </div>

                <div class="col-md-3">
                    <div class="form">
                        <br />
                        <div class="form-group">
                            <h2>Buscar por codigo:</h2>
                            <br />
                            <input class="form-control" type="text" id="txtCodigoBus" value="" placeholder="Codigo" runat="server" />
                            <br />
                            <br />
                            <asp:Button CssClass="btn-success" ID="btnBuscar" runat="server" OnClick="btnBuscar_Click" Text="Buscar" />
                            <label id="LabelPlatoBusqueda" runat="server"></label>
                        </div>

                    </div>
                </div>

                <div class="col-md-3">
                    <div class="form">
                        <br />
                        <div class="form-group">
                            <h2>Eliminar por codigo:</h2>
                            <br />
                            <input class="form-control" type="text" id="txtCodigoEli" value="" placeholder="Codigo" runat="server" />
                            <br />
                            <br />
                            <asp:Button CssClass="btn-success" ID="btnEliminar" runat="server" OnClick="btnEliminar_Click" Text="Eliminar" />
                        </div>
                    </div>
                </div>

            </div>
        </div>
    
</asp:Content>
