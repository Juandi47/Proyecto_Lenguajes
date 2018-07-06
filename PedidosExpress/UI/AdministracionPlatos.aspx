<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="AdministracionPlatos.aspx.cs" Inherits="UI.AdministracionPlatos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    &nbsp;
    <asp:Label ID="Label1" runat="server" Text="Buscar Plato"></asp:Label>
&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtPlato" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnBuscar" runat="server" OnClick="btnBuscar_Click" Text="Buscar" />
&nbsp;&nbsp;
    <asp:Label ID="LabelPlato" runat="server"></asp:Label>
&nbsp;
</asp:Content>
