<%@ Page Language="C#" AutoEventWireup="true" CodeFile="~/Controller/Registro.aspx.cs" Inherits="View_Registro" %>

<!DOCTYPE html>
<html lang="en">

<head runat="server">
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Registro</title>
    <link rel="stylesheet" href="https://fonts.googleapis.com/css2?family=Ubuntu&display=swap" />
    <link rel="stylesheet" href="../css/normalize.css" />
    <link rel="stylesheet" href="../css/registerstyle.css" />
</head>

<body>
    <form id="formularioRegistro" method="post" runat="server">
        <section class="form-registro">

            <h3 class="centrar-texto">Formulario de Registro</h3>
            <h4>Nombre:</h4>
            <asp:TextBox ID="tb_nombre" runat="server" CssClass="controles"></asp:TextBox>
            <h4>Apellido:</h4>
            <asp:TextBox ID="tb_apellido" runat="server" CssClass="controles"></asp:TextBox>
            <h4>Email:</h4>
            <asp:TextBox ID="tb_email" runat="server" CssClass="controles" TextMode="Email"></asp:TextBox>
            <h4>Username:</h4>
            <asp:TextBox ID="tb_username" runat="server" CssClass="controles"></asp:TextBox>
            <h4>Password:</h4>
            <asp:TextBox ID="tb_password" runat="server" CssClass="controles" TextMode="Password" ForeColor="White" Text="Ingrese password"></asp:TextBox>
            <asp:Button ID="btn_Registrar" CssClass="boton" runat="server" Text="Registrar" OnClick="btn_Registrar_Click" />
            <p><a href="Login.aspx">Ya tengo una cuenta</a></p>

        </section>
    </form>
</body>
</html>
