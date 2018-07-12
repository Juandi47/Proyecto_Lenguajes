<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="AdministrarTiempoEstados.aspx.cs" Inherits="UI.AdministrarTiempoEstados" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Ingrese el tiempo a cambiar"></asp:Label>
    <asp:TextBox ID="tiempoTXT" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
    <asp:Button ID="aceptarBTN" runat="server" OnClick="aceptarBTN_Click" Text="Aceptar" />
</asp:Content>
