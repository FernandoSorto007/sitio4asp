<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="asp4.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <main role="main">

  <!-- Main jumbotron for a primary marketing message or call to action -->
  <div class="jumbotron">
    <div class="container">
      <h1 class="display-3">Hola Bienvenido!</h1>
      <p>Este el 4 sitio web desarrollado con ASP en servidores.</p>
      <p><a class="btn btn-primary btn-lg" href="#" role="button">Aceptar &raquo;</a></p>
    </div>
  </div>
   <h1 class="text-center">Pagina 4 con ASP</h1>
   <asp:GridView ID="GridView1" runat="server" Width="675px" HorizontalAlign="Center"></asp:GridView>

    <hr>
</main>

</asp:Content>
