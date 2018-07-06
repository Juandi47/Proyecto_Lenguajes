<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Login.aspx.vb" Inherits="UI.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registro</title>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.1.0/css/bootstrap.min.css" />
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.0/umd/popper.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.1.0/js/bootstrap.min.js"></script>
</head>
<body>
    <div class="container">
        <h2>Bienvenido!</h2>
        <p>Ingrese sus credenciales</p>
        <form action="/action_page.php">
            <div class="form-group">
                <label for="usr">Nombre:</label>
                <asp:TextBox ID="usernameTB" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="pwd">Contraseña:</label><br />
                <asp:TextBox ID="passTB" runat="server"></asp:TextBox>
            </div>
            <asp:Button ID="registrarseBTN" runat="server" Text="Ingresar"/>
        </form>
    </div>
</body>
</html>
