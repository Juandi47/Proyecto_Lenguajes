<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="BloquearClientes.aspx.cs" Inherits="UI.BloquearClientes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Codigo cliente a bloquear"></asp:Label>
&nbsp;&nbsp;
    <asp:TextBox ID="txtBloquear" runat="server"></asp:TextBox>
&nbsp;&nbsp;
    <asp:Button ID="btnBloquear" runat="server" OnClick="btnBloquear_Click" Text="Bloquear" />
&nbsp;
</asp:Content>
