<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="AdministracionUsuarios.aspx.cs" Inherits="UI.AdministracionUsuarios1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p style="margin-left: 120px">
        <asp:Label ID="Label2" runat="server" Text="AGREGAR USUARIO"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label1" runat="server" Text="NOMBRE DE USUARIO:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="nombreUsuarioTXTagregar" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <p style="margin-left: 120px">
        <asp:Label ID="Label3" runat="server" Text="CONTRASENA:     "></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="contrasenaTXTagregar" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </p>
    <p style="margin-left: 120px">
        <asp:Label runat="server" Text="ROL:" ID="Label4"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="rolesDDLagregar" runat="server">
        </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </p>
    <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="aceptarBTNagregar" runat="server" OnClick="aceptarBTNagregar_Click" Text="ACEPTAR" />
    </p>
    <asp:Label ID="Label7" runat="server" style="margin-left: 440px" Text="ELIMINAR USUARIO"></asp:Label>
    <p style="margin-left: 440px">
        <asp:Label ID="Label5" runat="server" Text="NOMBRE DE USUARIO:"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="nombreUsuarioTXTeliminar" runat="server"></asp:TextBox>
    </p>
    <p style="margin-left: 440px">
        <asp:Label ID="Label6" runat="server" Text="CONTRASENA:     "></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="contrasenaTXTeliminar" runat="server"></asp:TextBox>
    </p>
    <p style="margin-left: 440px">
        <asp:Button ID="aceptarBTNeliminar" runat="server" OnClick="aceptarBTNeliminar_Click" Text="ACEPTAR" />
    </p>
    <p style="margin-left: 440px">
        &nbsp;</p>
    <p style="margin-left: 720px">
        <asp:Label ID="Label10" runat="server" Text="CONSULTAR USUARIO"></asp:Label>
    </p>
    <p style="margin-left: 720px">
        <asp:Label ID="Label8" runat="server" Text="NOMBRE DE USUARIO:"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="nombreUsuarioTXTconsultar" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="consultaTXT" runat="server" Width="337px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </p>
    <p style="margin-left: 720px">
        <asp:Label ID="Label9" runat="server" Text="CONTRASENA:     "></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="contrasenaTXTconsultar" runat="server"></asp:TextBox>
    </p>
    <p style="margin-left: 720px">
        <asp:Button ID="aceptarBTNconsultar" runat="server" Text="ACEPTAR" OnClick="aceptarBTNconsultar_Click" />
    </p>
    <p style="margin-left: 1040px">
        <asp:Label ID="Label15" runat="server" Text="MODIFICAR USUARIO"></asp:Label>
    </p>
    <p style="margin-left: 1040px">
        <asp:Label ID="Label11" runat="server" Text="NOMBRE DE USUARIO:"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="nombreUsuarioTXTmodificar" runat="server"></asp:TextBox>
    </p>
    <p style="margin-left: 1040px">
        <asp:Label ID="Label12" runat="server" Text="CONTRASENA:     "></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="contrasenaTXTmodificar" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </p>
    <p style="margin-left: 1040px">
        <asp:Label ID="Label14" runat="server" Text="ROL:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="rolesDDLmodificar" runat="server">
        </asp:DropDownList>
    </p>
    <p style="margin-left: 1040px">
        <asp:Button ID="aceptarBTNmodificar" runat="server" OnClick="aceptarBTNmodificar_Click1" Text="ACEPTAR" />
    </p>
    <p>
    </p>
    <p style="margin-left: 440px">
        &nbsp;</p>
    <p>
        &nbsp;</p>
</asp:Content>
