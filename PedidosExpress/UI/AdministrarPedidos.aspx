<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="AdministrarPedidos.aspx.cs" Inherits="UI.AdministrarPedidos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" />
       <link rel="stylesheet" href="Diseños/estilos.css" />
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
    <div class="row">
        <div class="col-md-3">
            <asp:Button ID="btnVerTodosClientes" runat="server" Text="Ver los pedidos de todos los clientes" OnClick="btnVerTodosClientes_Click" />
        </div>
        <div class="col-md-3">
            &nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label1" runat="server" Text="Filtrar busqueda por cliente"></asp:Label>
    <br />
    <asp:CheckBox ID="checkHabilitarCliente" runat="server" />
            <asp:TextBox ID="txtBuscarPorCliente" runat="server"></asp:TextBox>
&nbsp;<asp:RequiredFieldValidator ID="validaFiltroBuscarCliente" runat="server" ControlToValidate="txtBuscarPorCliente" ErrorMessage="*Informacion Requerida" ForeColor="Red" ValidationGroup="validaFiltroBuscarCliente"></asp:RequiredFieldValidator>
            <asp:Button ID="btnFiltroBuscarCliente" runat="server" Text="Buscar" OnClick="btnBuscar_Click" ValidationGroup="validaFiltroBuscarCliente" />
            
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

        </div>
        <div class="col-md-3">

        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="labelFecha" runat="server" Text="Filtrar por fecha"></asp:Label>
            <asp:CheckBox ID="checkFiltrarPorFecha" runat="server" />
            <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
            <asp:Button ID="btnBuscarPorFecha" runat="server" Text="Buscar" />
            <br />

        </div>
        <div class="col-md-3">
            <asp:Label ID="Label2" runat="server" Text="Filtrar busqueda por estados de pedido"></asp:Label>
            <br />
            <asp:CheckBox ID="checkHabilitarEstado" runat="server" />
            <br />
            <br />
        </div>
    </div>

        <div class="row">

            <div class="col-md-9">
            
            <asp:Label ID="Label3" runat="server" Text="Ingrese el codigo de la orden"></asp:Label>
            &nbsp;&nbsp;
                <asp:TextBox ID="txtCambiarEstado" runat="server"></asp:TextBox>
&nbsp;&nbsp;
            <asp:Button ID="btnCambiarEstado" runat="server" Text="Cambiar Estado" OnClick="btnCambiarEstado_Click" />
            
        </div>

        <div class="col-md-9">
            <br />
            <br />
            <asp:GridView ID="grdClientes" runat="server"></asp:GridView>
            <asp:Label ID="labelnformacion" runat="server"></asp:Label>
            <br />
            <br />
            <br />
        </div>

    </div>
</div>

</asp:Content>
