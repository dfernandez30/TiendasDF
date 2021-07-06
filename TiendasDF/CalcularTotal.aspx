<%@ Page Title="DESCUENTOS" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CalcularTotal.aspx.cs" Inherits="TiendasDF.CalcularTotal" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Calcular Total de la Compra</h2>
    <br />
    <p>Acá podrá calcular el total de su compra según su calidad de cliente</p>
    <hr />
    <div class="busqueda">
    <asp:Label ID="lbSimulador" runat ="server" Font-Bold="true" Text="Label"></asp:Label>
    <asp:Label ID="lbContadorClientes" runat ="server" Font-Bold="true" Text="Label"></asp:Label>
    <hr />  
    Ingrese el valor neto de la compra: 
    <asp:TextBox ID="txtValor" runat="server"></asp:TextBox>
    <br />
    <br />
    Elija el tipo de cliente que realiza la compra:
    <br />
    <br />
    <asp:RadioButton ID="rbSinConvenio" GroupName="OpcionCliente" runat="server" Text="Sin Convenio &#128531"/>
    <asp:RadioButton ID="rbBronce" GroupName="OpcionCliente" runat="server" Text="Club Bronce &#128118"/>
    <asp:RadioButton ID="rbOro" GroupName="OpcionCliente" runat="server" Text="Club Oro &#128081"/>
    <asp:RadioButton ID="rbDiamante" GroupName="OpcionCliente" runat="server" Text="Club Diamante &#128142"/>
    <asp:RadioButton ID="rbPlatino" GroupName="OpcionCliente" runat="server" Text="Club Platino &#129297"/>    
    <br />
    <br />
    <asp:Button ID="btnCalcular" runat="server" Text="Calcular Valor a Pagar" OnClick="btnCalcular_Click" />
    <br />
    <br />
    <asp:Label ID="lbResultado" runat="server" Font-Bold="true" Text="Label"></asp:Label></div>
</asp:Content>
