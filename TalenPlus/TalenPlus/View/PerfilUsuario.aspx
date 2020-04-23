<%@ Page Title="" Language="C#" MasterPageFile="~/View/Usuario.master" AutoEventWireup="true" CodeFile="~/Controller/PerfilUsuario.aspx.cs" Inherits="View_PerfilUsuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <section class="form-registro">

        <h3 class="centrar-texto">Mi Perfil</h3>
        <h4>Nombre:</h4>
        <br />
        <h4><asp:Label ID="lb_nombre" runat="server"></asp:Label></h4>
        <br />
        <asp:TextBox ID="tb_Nnombre" Visible="false" runat="server" CssClass="controles" placeholder="nombre"></asp:TextBox>
        <h4>Apellido:</h4>
        <br />
        <h4><asp:Label ID="lb_apellido" runat="server"></asp:Label></h4>
        <br />
        <asp:TextBox ID="tb_Napellido" Visible="false" runat="server" CssClass="controles" placeholder="apellido"></asp:TextBox>
        <h4>Email:</h4>
        <br />
        <h4><asp:Label ID="lb_email" runat="server"></asp:Label></h4>
        <br />
        <h4>Username:</h4>
        <br />
        <h4><asp:Label ID="lb_username" runat="server"></asp:Label></h4>
        <br />
        <asp:TextBox ID="tb_Nusername" Visible="false" runat="server" CssClass="controles" placeholder="username"></asp:TextBox>
        <h4>Contraseña:</h4>
        <br />
        <h4><asp:Label ID="lb_contrasela" runat="server"></asp:Label></h4>
        <br />
        <asp:TextBox ID="tb_Npass" Visible="false" runat="server" CssClass="controles" placeholder="contraseña"></asp:TextBox>
        <br />
        <asp:TextBox ID="tb_Dusername" Visible="false" runat="server" CssClass="controles" placeholder="Ingrese su username"></asp:TextBox>
        <asp:Button ID="btn_Modificar" CssClass="boton" runat="server" Text="Modificar" OnClick="btn_Modificar_Click" />
        <asp:Button ID="btn_Guardar" CssClass="boton" runat="server" Text="Guardar Cambios" Visible="false" OnClick="btn_Guardar_Click"/>
        <asp:Button ID="btn_Eliminar" CssClass="boton" runat="server" Text="Eliminar cuenta" OnClick="btn_Eliminar_Click"/>
        <asp:Button ID="btn_Confirmar" CssClass="boton" runat="server" Text="Confirmar eliminar" Visible="false" ForeColor="Red" OnClick="btn_Confirmar_Click"/>

    </section>
</asp:Content>

