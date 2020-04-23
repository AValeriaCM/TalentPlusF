<%@ Page Language="C#" AutoEventWireup="true" CodeFile="~/Controller/Login.aspx.cs" Inherits="View_Login" %>

<!DOCTYPE html>
<html lang="en">

<head runat="server">
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Login</title>
    <link rel="stylesheet" href="https://fonts.googleapis.com/css2?family=Ubuntu&display=swap" />
    <link rel="stylesheet" href="../css/normalize.css" />
    <link rel="stylesheet" href="../css/registerstyle.css" />
</head>

<body>
    <form id="formularioLogin" method="post" runat="server">
        <section class="form-registro">
            <h3 class="centrar-texto">Iniciar Sesión</h3>
            <h4>Username:</h4>
            <asp:TextBox ID="tb_username" runat="server" CssClass="controles"></asp:TextBox>
            <h4>Password:</h4>
            <asp:TextBox ID="tb_password" runat="server" TextMode="Password" CssClass="controles"></asp:TextBox>
            <asp:Button ID="btn_Login" CssClass="boton" runat="server" Text="Iniciar Sesion" OnClick="btn_Login_Click" />
            <p> <asp:Label ID="lb_error" runat="server" Text=" " ForeColor="Red"></asp:Label>
                <a href="#">¿Olvidaste tu contraseña?</a></p>
            <p><a href="Registro.aspx">No tengo una cuenta</a></p>
        </section>
    </form>
</body>
</html>
