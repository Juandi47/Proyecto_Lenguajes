﻿<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Principal.Master" CodeBehind="Ingreso.aspx.vb" Inherits="UI.Ingreso" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="lbNombreUsuario" runat="server" Text="Nombre de usuario:"></asp:Label>
    <br />
    <asp:TextBox ID="txtNombreUsario" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="vldNombreUsuario" runat="server" ControlToValidate="txtNombreUsario" ErrorMessage="Debe completar los espacios" ValidationGroup="InicioSesion"></asp:RequiredFieldValidator>
    <br />
    <br />
    <asp:Label ID="lbContrasenna" runat="server" Text="Contraseña:"></asp:Label>
    <br />
    <asp:TextBox ID="txtContrasenna" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="vldContrasenna" runat="server" ErrorMessage="Debe completar los espacios" ValidationGroup="InicioSesion"></asp:RequiredFieldValidator>
    &nbsp;s<br />
    <br />
    <asp:Button ID="Button1" runat="server" Text="Iniciar sesión" ValidationGroup="InicioSesion" />
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
