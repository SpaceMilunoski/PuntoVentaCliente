<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/Site.Master" AutoEventWireup="true" CodeBehind="Reportes.aspx.cs" Inherits="PuntoVentaCliente.Vistas.Modulos.Reportes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div  class="container">  
          <h1 align="center">Reportes de Venta</h1>
        <div class="form-group row"> 
            <div class="col-sm-3">
                         <input id="buscar" class="form-control" type="text" placeholder="Buscar por fecha " runat="server">
            </div>
            <div class="col-sm-3">
                         <button type="button" class="btn btn-success">Buscar</button>
            </div>
            <div class="col-sm-3">
            </div>
            <div class="col-sm-3">
                         <button type="button" class="btn btn-danger"><i class="material-icons">print</i></button>
            </div>
        </div>
        <div class="form-group row"> 
             <table class="table">
                      <thead>
                        <tr>
                            <th scope="col">No. Venta</th>
                            <th scope="col">Subtotal</th>
                            <th scope="col">Total</th>       
                            <th scope="col">Fecha</th>                        
                            <th scope="col">Empleado</th>
                        </tr>
                      </thead>
                      <tbody>
                        <tr>
                          <th scope="row">1</th>
                          <td>$10</td>
                          <td>$15</td>    
                          <td>30/07/2018</td>                   
                          <td>Luis</td>
                        </tr>
                      </tbody>
                    </table>
        </div>       
</div>
</asp:Content>
