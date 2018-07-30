<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/Site.Master" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="PuntoVentaCliente.Vistas.Menu" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <div class="white">
            <h2>Proveedores</h2>
            <p><h3>En este apartado tendras un control sobre los proveedores, para ser mas especificos podras:</h3></p>
            <ul>
                <li type="circle">Ingresar nuevos proveedores.</li>
                <li type="circle">Modificar su informnacion.</li>
                <li type="circle">Buscar un proveedor especifico.</li>
            </ul>
            <p><a href="Modulos/Proveedores" class="btn btn-primary btn-lg">Ir a &raquo;</a></p>
        </div>
        
    </div>
    
    <div class="jumbotron">
        <div class="white">
            <h2>Productos</h2>
            <p><h3>En este apartado tendras un control sobre los productos, para ser mas especificos podras:</h3></p>
            <ul>
                <li type="circle">Ingresar nuevos productos.</li>
                <li type="circle">Modificar su informacion.</li>
                <li type="circle">Eliminar el producto.</li>
            </ul>
            <p><a href="Modulos/Productos" class="btn btn-primary btn-lg">Ir a &raquo;</a></p>
        </div>
    </div>

    <div class="jumbotron">
        <div class="white">
            <h2>Usuarios</h2>
            <p><h3>En este apartado tendras un control sobre los usuarios si eres administrador, para ser mas especificos podras:</h3></p>
            <ul>
                <li type="circle">Registrar un nuevo usuario.</li>
                <li type="circle">Modificar su informacion.</li>
                <li type="circle">Eliminar al usuario.</li>
            </ul>
            <p><a href="Modulos/Empleados" class="btn btn-primary btn-lg">Ir a &raquo;</a></p>
        </div>
    </div>

    <div class="jumbotron">
        <div class="white">
            <h2>Ventas</h2>
            <p><h3>En este apartado podras realizar ventas, para ser mas especificos podras:</h3></p>
            <ul>
                <li type="circle">Realizar ventas de diversos productos.</li>
                <li type="circle">Generar ticket.</li>
            </ul>
            <p><a href="Modulos/Ventas" class="btn btn-primary btn-lg">Ir a &raquo;</a></p>
        </div>
    </div>

    
    <div class="jumbotron">
        <div class="white">
            <h2>Reportes</h2>
            <p><h3>En este apartado podras ver la informacion de las ventas, para ser mas especificos podras:</h3></p>
            <ul>
                <li type="circle">Ver las ventas de determinada fecha.</li>
                <li type="circle">Ver las ventas de determinado usuario.</li>
                <li type="circle">Generar un PDF con la lo seleccionado anteriormente.</li>
            </ul>
            <p><a href="Modulos/Reportes" class="btn btn-primary btn-lg">Ir a &raquo;</a></p>
        </div>
    </div>

</asp:Content>
