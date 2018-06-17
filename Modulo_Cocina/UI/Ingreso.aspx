<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Principal.Master" CodeBehind="Ingreso.aspx.vb" Inherits="UI.Ingreso" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="lbNombreUsuario" runat="server" Text="Nombre de usuario:"></asp:Label>
    <br />
    <asp:TextBox ID="txtNombreUsario" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>
    <br />
    <br />
    <asp:Label ID="lbContrasenna" runat="server" Text="Contraseña:"></asp:Label>
    <br />
    <asp:TextBox ID="txtContrasenna" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" Text="Iniciar sesión" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <br />
    <br />
    <asp:Label ID="lblRegistrarse" runat="server" Text="Si no tiene cuenta, debe crear una"></asp:Label>
    <br />
    <br />
    <asp:Button ID="btnRegistrarse" runat="server" Text="Crear cuenta" />
    <br />
    <br />
    <br />
</asp:Content>
