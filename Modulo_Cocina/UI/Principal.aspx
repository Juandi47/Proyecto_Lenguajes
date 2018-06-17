<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Principal.aspx.vb" Inherits="UI.Principal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lbNombreUsuario" runat="server" Text="Nombre de usuario:"></asp:Label>
    <br />
    <asp:TextBox ID="txtNombreUsario" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="vldNombreUsuario" runat="server" ControlToValidate="txtNombreUsario" ErrorMessage="Debe completar los espacios" ValidationGroup="InicioSesion"></asp:RequiredFieldValidator>
    <br />
    <br />
    <asp:Label ID="lbContrasenna" runat="server" Text="Contraseña:"></asp:Label>
    <br />
    <asp:TextBox ID="txtContrasenna" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="vldContrasenna" runat="server" ErrorMessage="Debe completar los espacios" ValidationGroup="InicioSesion"></asp:RequiredFieldValidator>
    &nbsp;<br />
    <br />
    <asp:Button ID="Button1" runat="server" Text="Iniciar sesión" ValidationGroup="InicioSesion" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <br />
    <br />
    <asp:Label ID="lblRegistrarse" runat="server" Text="Si no tiene cuenta, debe crear una"></asp:Label>
    <br />
    <br />
    <asp:Button ID="btnRegistrarse" runat="server" Text="Crear cuenta" />
    <br />
    <br />
    <br /></div>
    </form>
</body>
</html>

