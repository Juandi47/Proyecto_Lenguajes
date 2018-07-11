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
&nbsp;<br />
    <br />
    <asp:Label ID="Label2" runat="server" Text="Modificar:"></asp:Label>
    <br />
    <br />
    <asp:Label ID="Label4" runat="server" Text="Codigo"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtCodigo" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="Label3" runat="server" Text="Nombre"></asp:Label>
&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <br />
    <br />
    <asp:Label ID="Label5" runat="server" Text="Descripcion"></asp:Label>
&nbsp;
    <asp:TextBox ID="txtDescripcion" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="Label6" runat="server" Text="Precio"></asp:Label>
&nbsp;
    <asp:TextBox ID="txtPrecio" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="Label7" runat="server" Text="Estado"></asp:Label>
&nbsp;<asp:TextBox ID="txtEstado" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="Label8" runat="server" Text="Imagen"></asp:Label>
&nbsp;
    <asp:TextBox ID="txtImagen" runat="server"></asp:TextBox>
    <br />
    <br />
&nbsp;&nbsp;
    <asp:Button ID="btnModificar" runat="server" OnClick="btnModificar_Click" Text="Modificar" />
    <br />
    <br />
    <asp:Label ID="Label9" runat="server" Text="Agregar Plato"></asp:Label>
&nbsp;
    <br />
    <br />
    <asp:Label ID="Label10" runat="server" Text="Codigo"></asp:Label>
&nbsp;
    <asp:TextBox ID="txtCodAgregar" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="Label11" runat="server" Text="Nombre"></asp:Label>
&nbsp;
    <asp:TextBox ID="txtNomAgregar" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="Label12" runat="server" Text="Descripcion"></asp:Label>
&nbsp;
    <asp:TextBox ID="txtDesAgregar" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="Label13" runat="server" Text="Precio"></asp:Label>
&nbsp;
    <asp:TextBox ID="txtPreAgregar" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="Label14" runat="server" Text="Estado"></asp:Label>
&nbsp;
    <asp:TextBox ID="txtEstAgregar" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="Label15" runat="server" Text="Imagen"></asp:Label>
&nbsp;
    <asp:TextBox ID="txtImaAgregar" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="btnAgregar" runat="server" OnClick="btnAgregar_Click" Text="Agregar" />
    <br />
    <br />
    <asp:Label ID="Label16" runat="server" Text="Eliminar por codigo"></asp:Label>
&nbsp;&nbsp;
    <asp:TextBox ID="txtEliminar" runat="server"></asp:TextBox>
&nbsp;&nbsp;
    <asp:Button ID="btnEliminar" runat="server" OnClick="btnEliminar_Click" Text="Eliminar" />
    <br />
&nbsp;
</asp:Content>
