<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/master.Master" UICulture="auto" CodeBehind="CocinaListaPedidosWF.aspx.cs" Inherits="UI.CocinaListaPedidosWF" %>

<asp:Content ID="content2" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" />
    <link rel="stylesheet" href="Diseños/estilos.css" />
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
    <style>
         .info123 {
         width:5%; 
         height:5%;
         float:left;
         background-color:antiquewhite;
         resize:inherit;  
         }

    </style>
    
</asp:Content>
<asp:Content ID="content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div class="container" "background-color:#FFFFFF">

        <div class="row fila">
            <h3>&nbsp;</h3>
            <h3>Orden 1:</h3>
            <div class="col-md-2">
            </div>
            <div class="col-md-8" style="background-color: #FDEBD0">
                <br />
                <asp:TextBox  CssClass="info123" ID="infoO1" runat="server" ReadOnly="True" Width="639px"></asp:TextBox>
                <br />
                <asp:Label ID="estadoO1" runat="server" Text="Estado: "></asp:Label>
                <asp:Label ID="res_estadoO1" runat="server" Text="Desconocido"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="entregarBTN1" runat="server" Text="Marcar como entregada" OnClick="entregarBTN1_Click" BorderStyle="Solid" />
                <br />
                Detalles de orden:<br />
                <asp:TextBox ID="detallesO1" runat="server" Height="116px" ReadOnly="True" TextMode="MultiLine" Width="865px"></asp:TextBox>
                <br />
                <br />
            </div>
            <div class="col-md-2">
            </div>
        </div>

        <div class="row fila">
            <h3>Orden 2:</h3>
            <div class="col-md-2">
            </div>
            <div class="col-md-8" style="background-color: #EAEDED">
                <p id="grdInfoOrden2" draggable="auto" style="background-color: #C0C0C0" >asdsdffffffsdfsdfsfsd</p>
                <asp:Label ID="estadoO2" runat="server" Text="Estado: "></asp:Label>
                <asp:Label ID="res_estadoO2" runat="server" Text="Desconocido"></asp:Label>
                <br />
                <asp:Button ID="entregarBTN2" runat="server" Text="Marcar como entregada" />
                <br />
                <br />
                <p id="infoPlatosP2">Aqui irian los datos de los platos</p>
                <br />
            </div>
            <div class="col-md-2">
            </div>
        </div>

        <div class="row fila">
            <h3>Orden 3:</h3>
            <div class="col-md-2">
            </div>
            <div class="col-md-8" style="background-color: #FDEBD0">
                <p id="grdInfoOrden3" ></p>
                <asp:Label ID="estadoO3" runat="server" Text="Estado: "></asp:Label>
                <asp:Label ID="res_estadoO3" runat="server" Text="Desconocido"></asp:Label>
                <br />
                <asp:Button ID="entregarBTN3" runat="server" Text="Marcar como entregada" />
                <br />
                <br />
                <p id="infoPlatosP3">Aqui irian los datos de los platos</p>
                <br />
            </div>
            <div class="col-md-2">
            </div>
        </div>

        <div class="row fila">
            <h3>Orden 4:</h3>
            <div class="col-md-2">
            </div>
            <div class="col-md-8" style="background-color: #EAEDED">
                <p id="grdInfoOrden4" ></p>
                <asp:Label ID="estadoO4" runat="server" Text="Estado: "></asp:Label>
                <asp:Label ID="res_estadoO4" runat="server" Text="Desconocido"></asp:Label>
                <br />
                <asp:Button ID="entregarBTN4" runat="server" Text="Marcar como entregada" />
                <br />
                <br />
                <p id="infoPlatosP4">Aqui irian los datos de los platos</p>
                <br />
            </div>
            <div class="col-md-2">
            </div>
        </div>

        <div class="row fila">
            <h3>Orden 5:</h3>
            <div class="col-md-2">
            </div>
            <div class="col-md-8" style="background-color: #FDEBD0">
                <p id="grdInfoOrden5" ></p>
                <asp:Label ID="estadoO5" runat="server" Text="Estado: "></asp:Label>
                <asp:Label ID="res_estadoO5" runat="server" Text="Desconocido"></asp:Label>
                <br />
                <asp:Button ID="entregarBTN5" runat="server" Text="Marcar como entregada" />
                <br />
                <br />
                <p id="infoPlatosP5">Aqui irian los datos de los platos</p>
                <br />
            </div>
            <div class="col-md-2">
            </div>
    </div>

</div> 
     <br />
</asp:Content>
