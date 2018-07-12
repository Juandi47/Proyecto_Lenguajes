<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="AdministrarTiempoEstados.aspx.cs" Inherits="UI.AdministrarTiempoEstados" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <link href="Diseños/estilo.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <div class="general" style="height: 99px; width: 506px; top: -2px; left: 461px;">
        <asp:Label ID="Label1" runat="server" Text="Ingrese el tiempo a cambiar"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="tiempoTXT" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Info" runat="server"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;<br />
        <br />
        <br />
&nbsp;<asp:Button ID="aceptarBTN" runat="server" OnClick="aceptarBTN_Click" Text="Aceptar" />
    </div>
&nbsp;
</asp:Content>
