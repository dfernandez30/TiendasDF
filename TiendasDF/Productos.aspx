<%@ Page Title="PRODUCTOS" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Productos.aspx.cs" Inherits="TiendasDF.Productos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <h2>PRODUCTOS</h2>
    </div>
    <hr/>   
        <h4>Pan</h4>
    <img src="pan.jpg" alt="pan" width="40%" height="40%" style="float: right;">
    <div class="list"> 
        <div><ul class="head" id="headerPanes" /></div>
        <div><ul id="listaPanes"/></div>        
    </div>   
        <hr/>
        <h4>Carne</h4>
    <img src="carne.jpg" alt="carne" width="40%" height="40%" style="float: right;">
    <div class="list">
        <div><ul class="head" id="headerCarnes" /></div>
        <div><ul id="listaCarnes"/></div>
    </div>   
        <hr/>
        <h4>Queso</h4>
    <img src="queso.jpg" alt="queso" width="40%" height="40%" style="float: right;">
    <div class="list">
        <div><ul class="head" id="headerQuesos" /></div>
        <div><ul id="listaQuesos"/></div>
    </div>
    <div class="busqueda">
        <h2>Busqueda de productos por id</h2>
        <input type="text"id="idFiltro"placeholder="Ingrese Id"/><br/>
        <br/>
        <input type="button"value="Buscar Pan"onclick="findPan();"/>
        <input type="button"value="Buscar Carnes"onclick="findCarne();"/>
        <input type="button"value="Buscar Quesos"onclick="findQueso();"/><hr/>
        <p id="lbProducto" />
        <br />
        <ul id="result"/>
    </div>

    <script src="http://ajax.aspnetcdn.com/ajax/jQuery/jquery-2.0.3.min.js"></script>
    <script type="text/javascript">
        var urla = 'api/pan';
        $(document).ready(function () {
            $.getJSON(urla)
                .done(function (data) {
                    $('<li>', { text: formatHeaderPan() }).appendTo($('#headerPanes'));
                    $.each(data, function (key, item) {

                        $('<li>', { text: formatPan(item) }).appendTo($('#listaPanes'));
                        
                    });
                });
        });
        function formatHeaderPan() {
            return 'ID' + '   ' + 'Nombre' + '   ' + 'Marca' + '   ' + 'Codigo de Barra' + '   ' + 'Peso' + '   ' + 'Stock' + '   ' + 'Precio';
        }
        function formatPan(item) {
            return item.id + " - " + item.nombre + " - " + item.tipoPan + ' - ' + item.marca + ' - ' + item.codigoBarra + ' - ' + item.cantidad + item.unidadCantidad + ' - ' + item.stock + ' - $' + item.precio;
        }      
        function findPan() {
            var id = $('#idFiltro').val();
            $.getJSON(urla + '/' + id)
                .done(function (data) {
                    $('#lbProducto').text('ID - Nombre - Marca -  Código de Barra - Peso - Stock - Precio ');
                    $('#result').text(formatPan(data));
                })
                .fail(function (jqXHR, textStatus, err) {
                    $('#result').text('Error: ' + err);
                });
        }
    </script>
    <script type="text/javascript">
        var urlb = 'api/carne';
        $(document).ready(function () {
            $.getJSON(urlb)
                .done(function (data) {
                    $('<li>', { text: formatHeaderCarne() }).appendTo($('#headerCarnes'));
                    $.each(data, function (key, item) {

                        $('<li>', { text: formatCarne(item) }).appendTo($('#listaCarnes'));
                    });
                });
        });

        function formatHeaderCarne() {
            return 'ID' + '   ' + 'Nombre' + '   ' + 'Marca' + '   ' + 'Codigo de Barra' + '   ' + 'Peso' + '   ' + 'Stock' + '   ' + 'Fecha Envasado' + '   ' + 'Animal' + '   ' + 'Precio';
        }
        function formatCarne(item) {
            return item.id + ' - ' + item.nombre + ' - ' + item.marca + ' - ' + item.codigoBarra + ' - ' + item.cantidad + item.unidadCantidad + ' - ' + item.stock + ' - ' + item.fechaEnvasado + ' - ' + item.animal + ' - $' + item.precio;
        }
        function findCarne() {
            var id = $('#idFiltro').val();
            $.getJSON(urlb + '/' + id)
                .done(function (data) {
                    $('#lbProducto').text('ID - Nombre - Marca -  Código de Barra - Peso - Stock - Fecha Envasado - Animal - Precio ');
                    $('#result').text(formatCarne(data));
                })
                .fail(function (jqXHR, textStatus, err) {
                    $('#result').text('Error: ' + err);
                });
        }
    </script>
    <script type="text/javascript">
        var urlc = 'api/queso';
        $(document).ready(function () {
            $.getJSON(urlc)
                .done(function (data) {
                    $('<li>', { text: formatHeaderQueso() }).appendTo($('#headerQuesos'));
                    $.each(data, function (key, item) {

                        $('<li>', { text: formatQueso(item) }).appendTo($('#listaQuesos'));
                    });
                });
        });

        function formatHeaderQueso() {
            return 'ID' + '   ' + 'Nombre' + '   ' + 'Marca' + '   ' + 'Codigo de Barra' + '   ' + 'Peso' + '   ' + 'Stock' + '   ' + 'Tipo' + '   ' + 'Leche' + '   ' + 'Precio';
        }
        function formatQueso(item) {
            return item.id + ' - ' + item.nombre + ' - ' + item.marca + ' - ' + item.codigoBarra + ' - ' + item.cantidad + item.unidadCantidad + ' - ' + item.stock + ' - ' + item.tipo + ' - ' + item.tipoLeche + ' - $' + item.precio;
        }
        function findQueso() {
            var id = $('#idFiltro').val();
            $.getJSON(urlc + '/' + id)
                .done(function (data) {
                    $('#lbProducto').text('ID - Nombre - Marca -  Código de Barra - Peso - Stock - Tipo - Leche - Precio ');
                    $('#result').text(formatQueso(data));
                })
                .fail(function (jqXHR, textStatus, err) {
                    $('#result').text('Error: ' + err);
                });
        }
    </script>
</asp:Content>
