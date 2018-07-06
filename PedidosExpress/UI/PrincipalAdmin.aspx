<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="PrincipalAdmin.aspx.cs" Inherits="UI.PrincipalAdmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Button ID="btnAdministrarPlatos" runat="server" OnClick="btnAdministrarPlatos_Click" Text="Administrar Platos" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnAdministrarUsuario" runat="server" Text="Administracion Usuarios" OnClick="btnAdministrarUsuario_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnBloquear" runat="server" Text="Bloquear clientes" OnClick="btnBloquear_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnAdministrarPedidos" runat="server" Text="Administracion de pedidos" OnClick="btnAdministrarPedidos_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnAdministrarEstados" runat="server" Text="Administrar Estados" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
</asp:Content>
