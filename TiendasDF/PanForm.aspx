<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PanForm.aspx.cs" Inherits="TiendasDF.PanForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <h2>Panes</h2>
        <table>
            <tr>
                <th>ID</th>
                <th>Nombre</th>
                <th>Marca</th>
                <th>Codigo Barra</th>
                <th>Peso</th>
                <th>Stock</th>
                <th>Precio</th>
            </tr>            
        </table>
        <ul id="listaPanes"/>

    </div>
    <div>
        <h2>Busqueda por id</h2>
        <input type="text"id="panFiltro"size="5"/>
        <input type="button"value="Buscar"onclick="find();"/><hr/>
        <asp:Table ID="tablaResult" runat="server" visible="false">
            <asp:TableHeaderRow runat="server" Font-Bold="true">
                <asp:TableHeaderCell>ID</asp:TableHeaderCell>
                <asp:TableHeaderCell>Nombre</asp:TableHeaderCell>
                <asp:TableHeaderCell>Marca</asp:TableHeaderCell>
                <asp:TableHeaderCell>Codigo Barra</asp:TableHeaderCell>
                <asp:TableHeaderCell>Peso</asp:TableHeaderCell>
                <asp:TableHeaderCell>Stock</asp:TableHeaderCell>
                <asp:TableHeaderCell>Precio</asp:TableHeaderCell>
            </asp:TableHeaderRow>
        </asp:Table>
        <p id="pan"/>
    </div>

    <script src="http://ajax.aspnetcdn.com/ajax/jQuery/jquery-2.0.3.min.js"></script>
    <script>
        var url = 'api/pan';
        $(document).ready(function () {
            $.getJSON(url)
                .done(function (data) {

                    $.each(data, function (key, item) {

                        $('<li>', { text: formatItem(item) }).appendTo($('#listaPanes'));
                    });
                });
        });
        function formatItem(item) {
            return item.id + ' - ' + item.nombre +" "+ item.tipoPan + ' - ' + item.marca + ' - ' + item.codigoBarra + ' - ' + item.cantidad + item.unidadCantidad + ' - ' + item.stock + ' - $' + item.precio;
        }      
        function find() {
            var id = $('#panFiltro').val();
            $.getJSON(url + '/' + id)
                .done(function (data) {
                    $('#pan').text(formatItem(data));
                })
                .fail(function (jqXHR, textStatus, err) {
                    $('#pan').text('Error: ' + err);
                });
        }
    </script>
</asp:Content>
