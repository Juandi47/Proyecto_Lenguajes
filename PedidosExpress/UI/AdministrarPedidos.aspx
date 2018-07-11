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
            <asp:Calendar ID="calendarioFiltro" runat="server" OnSelectionChanged="calendarioFiltro_SelectionChanged" SelectedDate="07/10/2018 23:13:22"></asp:Calendar>
            <asp:Button ID="btnBuscarPorFecha" runat="server" Text="Inicio fecha" OnClick="btnBuscarPorFecha_Click" />
            <br />

        </div>
        <div class="col-md-3">
            <asp:Label ID="Label2" runat="server" Text="Filtrar busqueda por estados de pedido"></asp:Label>
            <br />
            <asp:RadioButton ID="radioAtiempo" runat="server" GroupName ="Estados" Text="A tiempo"/>
            &nbsp;&nbsp;&nbsp;
            <asp:RadioButton ID="radioSobreTiempo" runat="server" GroupName ="Estados" Text="Sobre tiempo"/>
            &nbsp;&nbsp;&nbsp;
            <asp:RadioButton ID="radioDemorado" runat="server" GroupName ="Estados" Text="Demorado" />
&nbsp;&nbsp;&nbsp;
            <asp:RadioButton ID="radioAnulado" runat="server" GroupName ="Estados" Text="Anulado" />
&nbsp;&nbsp;&nbsp;
            <asp:RadioButton ID="radioEntregado" runat="server" GroupName ="Estados" Text="Entregado" />
            <br />
            <asp:Button ID="btnBuscarPorEstados" runat="server" GroupName ="Estados" OnClick="btnBuscarPorEstados_Click" Text="Buscar" />
            <br />
            <br />
        </div>
    </div>

        <div class="row">

            <div class="col-md-9">
            
                <br />
            <asp:GridView ID="grdClientes" runat="server"></asp:GridView>
            <asp:Label ID="labelnformacion" runat="server"></asp:Label>
                <br />
            
        </div>

        <div class="col-md-9">
            <br />
            <asp:RadioButton ID="radioEstadoAtiempo" runat="server" GroupName ="CambiarEstados" Text="A tiempo" />
&nbsp;&nbsp;&nbsp;
            <asp:RadioButton ID="radioEstadoSobreTiempo" runat="server" GroupName ="CambiarEstados" Text="Sobre Tiempo"/>
&nbsp;&nbsp;&nbsp;
            <asp:RadioButton ID="radioEstadoDemorado" runat="server" GroupName ="CambiarEstados" Text="Demorado"/>
&nbsp;&nbsp;&nbsp;
            <asp:RadioButton ID="radioEstadoAnulado" runat="server" GroupName ="CambiarEstados" Text="Anulado"/>
&nbsp;&nbsp;&nbsp;
            <asp:RadioButton ID="radioEstadoEntregado" runat="server" GroupName ="CambiarEstados" Text="Entregado" />
            <br />
            
            <asp:Label ID="Label3" runat="server" Text="Ingrese el codigo de la orden"></asp:Label>
            &nbsp;&nbsp;
                <asp:TextBox ID="txtCambiarEstado" runat="server"></asp:TextBox>
&nbsp;&nbsp;<asp:RequiredFieldValidator ID="validatorCodigoEstado" runat="server" ControlToValidate="txtCambiarEstado" ErrorMessage="*Informacion requerida" ForeColor="Red" ValidationGroup="  public List&lt;TOOrden&gt; buscarPedidosClienteEstado(string estado, string cedula)"></asp:RequiredFieldValidator>
&nbsp;<asp:Button ID="btnCambiarEstado" runat="server" Text="Cambiar Estado" OnClick="btnCambiarEstado_Click" ValidationGroup="validaEstado" />
            
            <br />
            <br />
            <br />
        </div>

    </div>
</div>

</asp:Content>
