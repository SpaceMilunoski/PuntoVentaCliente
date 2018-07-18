<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Ventas.aspx.cs" Inherits="PuntoVentaCliente.Ventas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">   
    <div  class="container">  
          <h1 align="center">Ventas</h1> 
        <div class="row">
         <form>
             <div class="col-sm-5" style="background-color:white;">
                 <div class="form-group row">
                     <div class="col-sm-5">
                         <input id="buscar" class="form-control" type="text" placeholder="Buscar">
                     </div>
                     <div class="col-sm-3">
                         <button type="button" class="btn btn-success">Buscar</button>
                     </div>
                 </div> 
                 <div class="form-group row"> 
                 </div>
                 <div class="form-group row">
                     <div class="col-sm-3">
                         <label for="cantidad" class="col-sm-4 col-form-label">Cantidad</label>
                     </div>
                     <div class="col-sm-6">
                         <input id="marca" class="form-control" type="number" placeholder="Default input">
                     </div>
                 </div>  
             </div>
             <div class="col-sm-3" style="background-color:white;">
                 <div class="form-group row">                      
                 </div> 
                 <div class="form-group row">  
                      <button type="button" class="btn btn-success">Agregar Producto</button>                    
                 </div>               
             </div>
             <div class="col-sm-4" style="background-color:white;">
                 <div class="form-group row"> 
                     <button type="button" class="btn btn-primary">Crear Pedido de Venta</button>
                 </div>
                 <div class="form-group row"> 
                 </div>
                 <div class="row"> 
                     <div class="row">
                         <div class="col-sm-4" style="background-color:white;">
                             <label for="ticket" class="col-sm-4 col-form-label">Ticket</label>  
                         </div>    
                         <div class="col-sm-4" style="background-color:white;">  
                             <input id="ticket" class="form-control" type="checkbox" >
                         </div>   
                     </div>
                     <div class="row">
                         <div class="col-sm-4" style="background-color:white;"> 
                             <label for="factura" class="col-sm-4 col-form-label">Factura</label>                               
                         </div>  
                         <div class="col-sm-4" style="background-color:white;"> 
                             <input id="factura" class="form-control" type="checkbox" >  
                         </div> 
                     </div>                                      
                 </div>   
             </div>
         </form>                                         
        </div>
         <div class="row">
             <table class="table">
                      <thead>
                        <tr>
                            <th scope="col">Productos</th>
                            <th scope="col">Cantidad</th>
                            <th scope="col">Costo</th>                            
                            <th scope="col"></th>
                        </tr>
                      </thead>
                      <tbody>
                        <tr>
                          <th scope="row">1</th>
                          <td>5</td>
                          <td>$15</td>                      
                          <td>
                                <div class="row">
                                    <div class="col-sm-3">
                                        <button type="button" class="btn btn-danger"><i class="material-icons">delete</i></button>
                                    </div>
                                    <div class="col-sm-3">
                                        <button type="button" class="btn btn-primary"><i class="material-icons">edit</i></button>
                                    </div>
                                </div>
                          </td>
                        </tr>
                      </tbody>
                    </table>                                             
        </div>         
</div>
</asp:Content>
