<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="LoguearUsuarios.aspx.cs" Inherits="UI.LoguearUsuarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Ingrese su nombre de usuario"></asp:Label>
&nbsp;
    <asp:TextBox ID="txtNombreAdmin" runat="server" Width="128px"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="Label2" runat="server" Text="Ingrese su contraseña"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtPassword" runat="server" Width="135px"></asp:TextBox>
    <br />
    <br />
&nbsp;&nbsp;
    <asp:Button ID="btnRegistrarUsuario" runat="server" OnClick="btnRegistrarUsuario_Click" Text="Registrar" />
&nbsp;
</asp:Content>
