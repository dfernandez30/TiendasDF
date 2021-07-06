<%@ Page Title="PERSONAL" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PersonalTienda.aspx.cs" Inherits="TiendasDF.PersonalTienda" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <script src="http://ajax.aspnetcdn.com/ajax/jQuery/jquery-2.0.3.min.js"></script>
    <script type="text/javascript">
        var urla = 'api/cajero';
        $(document).ready(function () {
            $.getJSON(urla)
                .done(function (data) {
                    $('<li>', { text: formatHeaderCajero() }).appendTo($('#headerCajeros'));
                    $.each(data, function (key, item) {

                        $('<li>', { text: formatCajero(item) }).appendTo($('#listaCajeros'));
                    });
                });
        });
        function formatCajero(item) {
            return item.id + ' - ' + item.nombre + " " + item.apellidoPaterno + " " + item.apellidoMaterno + ' - ' + item.rut + ' - ' + item.horasTrabajadas + ' - ' + item.mesesAntiguedad + " meses - " + item.bono + ' - ' + item.numeroCaja + ' - ' + item.turno;
        }
        function formatHeaderCajero() {
            return 'ID' + ' - ' + 'Nombre Completo' + ' - ' + 'Rut' + ' - ' + 'Horas Trabajadas' + ' - ' + 'Meses de Antiguedad' + ' - ' + 'Bono' + ' - ' + 'Caja Asignada' + ' - ' + 'Turno' ;
        }
        function findCajero() {
            var id = $('#idFiltro').val();
            $.getJSON(urla + '/' + id)
                .done(function (data) {
                    $('#lbPersona').text('ID - Nombre Completo - Rut - Horas Trabajadas - Meses Antiguedad - Bono - Caja Asignada - Tipo Turno ');
                    $('#result').text(formatCajero(data));
                    $(document.getElementById('txtHoras').value = (data.horasTrabajadas));
                })
                .fail(function (jqXHR, textStatus, err) {
                    $('#result').text('Error: ' + err);
                });
        }
    </script>
    <script type="text/javascript">
        var urlb = 'api/guardia';
        $(document).ready(function () {
            $.getJSON(urlb)
                .done(function (data) {
                    $('<li>', { text: formatHeaderGuardia() }).appendTo($('#headerGuardias'));
                    $.each(data, function (key, item) {

                        $('<li>', { text: formatGuardia(item) }).appendTo($('#listaGuardias'));
                    });
                });
        });
        function formatGuardia(item) {
            return item.id + ' - ' + item.nombre + " " + item.apellidoPaterno + " " + item.apellidoMaterno + ' - ' + item.rut + ' - ' + item.horasTrabajadas + ' - ' + item.mesesAntiguedad + " meses - " + item.bono + ' - ' + item.articulosRecuperados + ' - ' + item.area;
        }
        function formatHeaderGuardia() {
            return 'ID' + ' - ' + 'Nombre Completo' + ' - ' + 'Rut' + ' - ' + 'Horas Trabajadas' + ' - ' + 'Meses de Antiguedad' + ' - ' + 'Bono' + ' - ' + 'Robos Evitados' + ' - ' + 'Área';
        }
        function findGuardia() {
            var id = $('#idFiltro').val();
            $.getJSON(urlb + '/' + id)
                .done(function (data) {
                    $('#lbPersona').text('ID - Nombre Completo - Rut - Horas Trabajadas - Meses Antiguedad - Bono - Robos Evitados - Área ');
                    $('#result').text(formatGuardia(data));
                    $(document.getElementById('txtHoras').value = (data.horasTrabajadas));
                })
                .fail(function (jqXHR, textStatus, err) {
                    $('#result').text('Error: ' + err);
                });
        }
    </script>
    <script type="text/javascript">
        var urlc = 'api/jefe';
        $(document).ready(function () {
            $.getJSON(urlc)
                .done(function (data) {
                    $('<li>', { text: formatHeaderJefe() }).appendTo($('#headerJefes'));
                    $.each(data, function (key, item) {

                        $('<li>', { text: formatJefe(item) }).appendTo($('#listaJefes'));
                    });
                });
        });
        function formatJefe(item) {
            return item.id + ' - ' + item.nombre + " " + item.apellidoPaterno + " " + item.apellidoMaterno + ' - ' + item.rut + ' - ' + item.horasTrabajadas + ' - ' + item.mesesAntiguedad + " meses - " + item.bono + ' - ' + item.area + ' - ' + item.tamanioEquipo;
        }
        function formatHeaderJefe() {
            return 'ID' + ' - ' + 'Nombre Completo' + ' - ' + 'Rut' + ' - ' + 'Horas Trabajadas' + ' - ' + 'Meses de Antiguedad' + ' - ' + 'Bono' + ' - ' + 'Área' + ' - ' + 'N° de Subalternos';
        }
        function findJefe() {
            var id = $('#idFiltro').val();
            $.getJSON(urlc + '/' + id)
                .done(function (data) {
                    $('#lbPersona').text('ID - Nombre Completo - Rut -  Horas Trabajadas - Meses Antiguedad - Bono - Área - Cantidad Subalternos ');
                    $('#result').text(formatJefe(data));
                    $(document.getElementById('txtHoras').value = (data.horasTrabajadas));
                })
                .fail(function (jqXHR, textStatus, err) {
                    $('#result').text('Error: ' + err);
                });
        }
    </script>
    <div>
        <h2>Personal Tienda</h2>
    </div>
    <hr/>
    <div class="list">
        <h4>Cajeros</h4>
        <div><ul class="head" id="headerCajeros" /></div>
        <div><ul id="listaCajeros"/></div>
    </div>
    <div class="list">
        <hr/>
        <h4>Guardias</h4>
        <div><ul class="head" id="headerGuardias" /></div>
        <div><ul id="listaGuardias"/></div>
    </div>
    <div class="list">
        <hr/>
        <h4>Jefes de Area</h4>        
        <div><ul class="head" id="headerJefes" /></div>
        <div><ul id="listaJefes"/></div>
    </div>

    <div class="busqueda">
        <h2>Busqueda de personal por RUT</h2>
        <input type="text"id="idFiltro" placeholder="Ingrese Rut"/><br/>
        <br />
        <asp:Button ID="btnCajero" runat="server" Text="Buscar Cajero" OnClientClick="findCajero(); return false;"  />
        <asp:Button ID="btnGuardia" runat="server" Text="Buscar Guardia" OnClientClick="findGuardia(); return false;"  />
        <asp:Button ID="btnJefe" runat="server" Text="Buscar Jefe" OnClientClick="findJefe(); return false;"  />
        <hr/>
        <asp:Label ID="lbPersonal" runat ="server" Font-Bold="true" Text="Label"></asp:Label>
        <p id="lbPersona" />
        <br />
        <ul id="result"/>
    </div>
    <hr/>
    <div>
        <h2>Calculador de Sueldo </h2>
        <div class="sueldos">
        <asp:Label ID="lbCalculador" runat ="server" Font-Bold="true" Text="Label"></asp:Label>
        <br />
        Ingrese horas trabajadas: 
        <asp:TextBox ID="txtHoras" runat="server" ClientIDMode="Static"></asp:TextBox>
        <br />
        <br />
        Ingrese valor hora: 
        <asp:TextBox ID="txtValorHora" runat="server" ClientIDMode="Static"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnCalcular" runat="server" Text="Calcular Sueldo" OnClick="btnCalcular_Click" />
        <br />
        <asp:Label ID="lbSueldo" runat="server" Font-Bold="true" Text="Label"></asp:Label>

        </div>
    </div>
        

     
</asp:Content>
