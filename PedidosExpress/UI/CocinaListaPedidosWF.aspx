<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/master.Master" UICulture="auto" CodeBehind="CocinaListaPedidosWF.aspx.cs" Inherits="UI.CocinaListaPedidosWF" %>

<asp:Content ID="content2" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="Diseños/estilos.css" />
  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css"/>
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

    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <h3> Hora del servidor:</h3>
                &nbsp<asp:label id="Label1" runat="server" ></asp:label>
                <asp:Timer ID="Timer1" runat="server" Interval="1000" OnTick="Timer1_Tick1" Enabled="true">
                </asp:Timer>
            </ContentTemplate>
        </asp:UpdatePanel>

    <div class="form" "background-color:#FFFFFF">
        <div class="row1">
             
            <p>&nbsp;</p>
            <h4>Orden 1:</h4>
            <div class="container">
                    <div class="form-group" >
                        <label for="infoOrden1">Info orden:</label>
                        <input runat="server" type="text" class="form-control" id="infoOrden1" readonly="True"/>
                        <asp:label runat="server" id="e1"></asp:label>
                    </div>
                    <div class="form-group">
                        <label for="detallesO1">Detalles:</label>
                        <asp:TextBox CssClass="form-control" ID="detallesO1" runat="server" Height="116px" ReadOnly="True" TextMode="MultiLine" ></asp:TextBox>
                    </div>
                <asp:Button ID="Button0" runat="server" Text="Marcar como entregada" OnClick="Button0_Click" />
            </div>  
        </div>

          <div class="row2" style="background-color:#edbb99 ">
            <h3>&nbsp;</h3>
            <h3>Orden 2:</h3>
            <div class="container">
                    <div class="form-group">
                        <label for="infoOrden2">Info orden:</label>
                        <input runat="server" type="text" class="form-control" id="infoOrden2" readonly="True"/>
                         <asp:label runat="server" id="e2"></asp:label>
                    </div>
                    <div class="form-group">
                        <label for="detallesO2">Detalles:</label>
                        <asp:TextBox CssClass="form-control" ID="detallesO2" runat="server" Height="116px" ReadOnly="True" TextMode="MultiLine" ></asp:TextBox>
                    </div>
                <asp:Button ID="Button1" runat="server" Text="Marcar como entregada" OnClick="Button1_Click" />
                
            </div>  
        </div>

        <div class="row1">
            <h3>&nbsp;</h3>
            <h3>Orden 3:</h3>
            <div class="container">
                    <div class="form-group">
                        <label for="infoOrden3">Info orden:</label>
                        <input runat="server" type="text" class="form-control" id="infoOrden3" readonly="True"/>
                         <asp:label runat="server" id="e3"></asp:label>
                    </div>
                    <div class="form-group">
                        <label for="detallesO3">Detalles:</label>
                        <asp:TextBox CssClass="form-control" ID="detallesO3" runat="server" Height="116px" ReadOnly="True" TextMode="MultiLine" ></asp:TextBox>
                    </div>
                 <asp:Button ID="Button2" runat="server" Text="Marcar como entregada" OnClick="Button2_Click" />
            </div>  
        </div>

          <div class="row2" style="background-color:#edbb99 ">
            <h3>&nbsp;</h3>
            <h3>Orden 4:</h3>
            <div class="container">
                    <div class="form-group">
                        <label for="infoOrden4">Info orden:</label>
                        <input runat="server" type="text" class="form-control" id="infoOrden4" readonly="True"/>
                       <asp:label runat="server" id="e4"></asp:label>
                    </div>
                    <div class="form-group">
                        <label for="detallesO4">Detalles:</label>
                        <asp:TextBox CssClass="form-control" ID="detallesO4" runat="server" Height="116px" ReadOnly="True" TextMode="MultiLine" ></asp:TextBox>
                    </div>
                <asp:Button ID="Button3" runat="server" Text="Marcar como entregada" OnClick="Button3_Click" />
            </div>  
        </div>

           <div class="row1" >
            <h3>&nbsp;</h3>
            <h3>Orden 5:</h3>
            <div class="container">
                    <div class="form-group">
                        <label for="infoOrden5">Info orden:</label>
                        <input runat="server" type="text" class="form-control" id="infoOrden5" readonly="True"/>
                        <asp:label runat="server" id="e5"></asp:label>
                    </div>
                    <div class="form-group">
                        <label for="detallesO5">Detalles:</label>
                        <asp:TextBox CssClass="form-control" ID="detallesO5" runat="server" Height="116px" ReadOnly="True" TextMode="MultiLine" ></asp:TextBox>
                    </div>
                 <asp:Button ID="Button4" runat="server" Text="Marcar como entregada" OnClick="Button4_Click" />
            </div>  
        </div>

    </div> 
     <br />
</asp:Content>
