<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="LoguearUsuarios.aspx.cs" Inherits="UI.LoguearUsuarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css"/>
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
    <div class="row">
        <div class="col-sm-1 col-md-3">
        </div>
        <div class="col-md-4">
            <div class="form">
                <br />
                <div class="form-group"> 
                    <label for="detallesO1">Ingrese su nombre de usuario:</label>
                    <asp:TextBox CssClass="form-control" ID="txtNombreUsuario" runat="server" TextMode="SingleLine"></asp:TextBox>
                </div>

                <div class="form-group">
                    <label for="detallesO1">Ingrese su contraseña:</label>
                    <input id="txtContrasenna" class="form-control" type="password" runat="server" />

                </div>

                <asp:Button ID="btnRegistrarUsuario" runat="server" OnClick="btnRegistrarUsuario_Click" Text="Registrar" />
                <br />
            </div>
            <br />
        </div>
        <div class="col-md-3"></div>
    </div>
</div>

</asp:Content>
