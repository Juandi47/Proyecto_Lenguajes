<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="LoguearUsuarios.aspx.cs" Inherits="UI.LoguearUsuarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<<<<<<< HEAD
     <link href="Diseños/estilo.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="height: 134px; width: 437px; top: 22px; left: 436px; margin-left: 66px;" class="general">
        <asp:Label ID="Label1" runat="server" Text="Ingrese su nombre de usuario"></asp:Label>
&nbsp;
    <asp:TextBox ID="txtNombreUsuario" runat="server" Width="128px"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="Label2" runat="server" Text="Ingrese su contraseña"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtContrasenna" runat="server" Width="135px" TextMode="Password"></asp:TextBox>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="btnRegistrarUsuario" runat="server" OnClick="btnRegistrarUsuario_Click" Text="Registrar" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
&nbsp;
    </div>
    <br />
    <br />
=======
     <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css"/>
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>

</asp:Content>
<%--<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
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
</div>--%>

<%-->>>>>>> b223e226b74f4a7731417c433f09c514d460bb87--%>
<%--</asp:Content>--%>
