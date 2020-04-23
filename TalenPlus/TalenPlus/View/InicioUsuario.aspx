<%@ Page Title="" Language="C#" MasterPageFile="~/View/Usuario.master" AutoEventWireup="true" CodeFile="~/Controller/InicioUsuario.aspx.cs" Inherits="View_InicioUsuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <section class="form-registro">
        <h2>Hola, <asp:Label ID="lb_username" runat="server" Text=" - " ForeColor="White"></asp:Label></h2>
        <br />
        <br />
        <br />
        <br />
        <h4>Publica tu vídeo:</h4>
        <br />
        <br />
        <br />
        <br />
        <h5>Tamaño max: 15mb
        </h5>
        <p>&nbsp;</p>
        <asp:FileUpload ID="fu_video" runat="server" />
        <asp:Button ID="btn_Subir" CssClass="boton2" runat="server" Text="Subir" BackColor="#666666" OnClick="btn_Subir_Click" />
        <br />
        <asp:Label ID="lblErrorVideo" runat="server" EnableViewState="False" CssClass="redbold"></asp:Label>
    </section>
</asp:Content>

