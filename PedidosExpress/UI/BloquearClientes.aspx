<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="BloquearClientes.aspx.cs" Inherits="UI.BloquearClientes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label2" runat="server" Text="Ver el estado de un cliente"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtBuscarCliente" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnVerEstado" runat="server" OnClick="btnVerEstado_Click" Text="Ver estado" Width="103px" />
&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="labelEstado" runat="server"></asp:Label>
    <br />
    <br />
    <asp:Label ID="Label3" runat="server" Text="Codigo cleinte a desbloquear"></asp:Label>
&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnDesbloquear" runat="server" Text="Desbloquear" />
&nbsp;&nbsp;
    <br />
    <br />
    <asp:Label ID="Label1" runat="server" Text="Codigo cliente a bloquear"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
    <asp:TextBox ID="txtBloquear" runat="server"></asp:TextBox>
&nbsp;&nbsp; &nbsp;
    <asp:Button ID="btnBloquear" runat="server" OnClick="btnBloquear_Click" Text="Bloquear" Width="110px" />
&nbsp;
</asp:Content>
