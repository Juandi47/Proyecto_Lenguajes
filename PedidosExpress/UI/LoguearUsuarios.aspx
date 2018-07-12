<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="LoguearUsuarios.aspx.cs" Inherits="UI.LoguearUsuarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
         <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css"/>
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>

     <link href="Diseños/estilo.css" rel="stylesheet" type="text/css" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="row1" style="background-color: darkslategray">
        <div class="container">
            <div class="col-md-4">

            </div>
            <div class="col-md-3">
                <div class="form">

                    <br />
                    <div class="form-group">
                        <h2>Credenciales</h2>
                        <br />
                        <br />
                        <input class="form-control" type="text" id="txtNombreUser" value="" placeholder="Nombre Usuario" runat="server" />
                        <br />
                        <br />
                        <input class="form-control" type="password" id="txtContrasennaUser" value="" placeholder="Cedula Usuario" runat="server" />
                        
                        <br />
                        <br />
                        <asp:Button runat="server" ID="btnLoguear"  OnClick="btnRegistrarUsuario_Click" Text="Loguear" />
                        <br />
                        <br />
                    </div>
                </div>
            </div>
            <div class="col-md-4">

            </div>
            </div>
        </div>


</asp:Content>

