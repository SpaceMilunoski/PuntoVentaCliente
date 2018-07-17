<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Productos.aspx.cs" Inherits="PuntoVentaCliente.Productos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">   
    <div class="container">  
        <h1>Productos</h1>
        <div class="row">
            <form>
                <div class="form-group">
                    <div class="col-sm-3" style="background-color:white;">
                        <div class="form-group row">
                            <label for="identificador" class="col-sm-4 col-form-label">Identificador</label>
                            <div class="col-sm-8">
                                <input id="identificador" class="form-control" type="text" placeholder="Default input">
                            </div>
                        </div>
                        <!----------------------------------->
                        <div class="form-group row">
                            <label for="nombre" class="col-sm-4 col-form-label">Nombre</label>
                            <div class="col-sm-8">
                                <input id="nombre" class="form-control" type="text" placeholder="Default input">
                            </div>
                        </div>
                        <!----------------------------------->
                        <div class="form-group row">
                            <label for="marca" class="col-sm-4 col-form-label">Marca</label>
                            <div class="col-sm-8">
                                <input id="marca" class="form-control" type="text" placeholder="Default input">
                            </div>
                        </div>
                        <!----------------------------------->
                        <div class="form-group row">
                            <label for="proveedor" class="col-sm-4 col-form-label">Proveedor</label>
                            <div class="col-sm-8">
                                <input id="proveedor" class="form-control" type="text" placeholder="Default input">
                            </div>
                        </div>
                        <!----------------------------------->
                    </div>
                    <div class="col-sm-3" style="background-color:white;">
                        <div class="form-group row">
                            <label for="descripcion" class="col-sm-4 col-form-label">Descripcion</label>
                            <div class="col-sm-8">
                                <input id="descripcion" class="form-control" type="text" placeholder="Default input">
                            </div>
                        </div>
                        <!----------------------------------->
                        <div class="form-group row">
                            <label for="imagen" class="col-sm-4 col-form-label">Imagen</label>
                            <div class="col-sm-8">
                                <input id="imagen" class="form-control" type="text" placeholder="Default input">
                            </div>
                        </div>
                        <!----------------------------------->
                        <div class="form-group row">
                            <label for="costo_venta" class="col-sm-4 col-form-label">Costo de venta</label>
                            <div class="col-sm-8">
                                <input id="costo_venta" class="form-control" type="text" placeholder="Default input">
                            </div>
                        </div>
                        <!----------------------------------->
                        <div class="form-group row">
                            <label for="costo_compra" class="col-sm-4 col-form-label">Costo de compra</label>
                            <div class="col-sm-8">
                                <input id="costo_compra" class="form-control" type="text" placeholder="Default input">
                            </div>
                        </div>
                        <!----------------------------------->
                        <div class="form-group row">
                            <label for="costo_compra" class="col-sm-4 col-form-label">Costo de compra</label>
                            <div class="col-sm-8">
                                <input id="costo_compra" class="form-control" type="text" placeholder="Default input">
                            </div>
                        </div>
                        <!----------------------------------->
                        <div class="form-group row">
                            <label for="stock" class="col-sm-4 col-form-label">Stock</label>
                            <div class="col-sm-8">
                                <input id="stock" class="form-control" type="text" placeholder="Default input">
                            </div>
                        </div>
                        <!----------------------------------->                    
                    </div>
                    <div class="col-sm-3" style="background-color:white;">
                        <div class="form-group row">
                            <label for="fecha_registro" class="col-sm-4 col-form-label">Fecha de Registro</label>
                            <div class="col-sm-8">
                                <input id="fecha_registro" class="form-control" type="text" placeholder="Default input">
                            </div>
                        </div>
                      <!------------------------------------->
                        <div class="form-group row">
                            <label for="unidad_medida" class="col-sm-4 col-form-label">Unidad de Medida</label>
                            <div class="col-sm-8">
                                <input id="unidad_medida" class="form-control" type="text" placeholder="Default input">
                            </div>
                        </div>    
                      <!------------------------------------->
                        <div class="form-group row">
                          <label for="fecha_caducidad" class="col-sm-4 col-form-label">Fecha de caducidad</label>
                          <div class="col-sm-8">
                              <input id="fecha_caducidad" class="form-control" type="text" placeholder="Default input">
                          </div>
                      </div>   
                      <!------------------------------------->
                        <div class="form-group row">
                            <label for="departamento" class="col-sm-4 col-form-label">Departamento</label>
                            <div class="col-sm-8">
                                <input id="departamento" class="form-control" type="text" placeholder="Default input">
                            </div>
                        </div>   
                      <!------------------------------------->                                                                  
                    </div>
                </div>
            </form>
                    <div class="col-sm-3" style="background-color:white;">
                        <div class="form-group row">
                            <button type="button" class="btn btn-success">Agregar</button>
                        </div>
                        <!------------------------------------->
                        <div class="form-group row">
                            <button type="button" class="btn btn-primary">Actualizar</button>
                        </div>
                        <!--------------------------------------->
                    </div>         
        </div>
        <div class="row">
            <div class="col-sm-6">
            </div>
            <div class="col-sm-3">
                        <div class="form-group row">
                           <div class="col-sm-8">
                                <input id="buscar" class="form-control" type="text" placeholder="Buscar">
                            </div>
                            <button type="button" class="btn btn-success">Buscar</button>
                        </div>
                        <!--------------------------------------->
            </div>
        </div>
        <div class="row">
            <div class="col-sm-12">
                <table class="table">
                      <thead>
                        <tr>
                          <th scope="col">#</th>
                          <th scope="col">First</th>
                          <th scope="col">Last</th>
                          <th scope="col">Handle</th>
                        </tr>
                      </thead>
                      <tbody>
                        <tr>
                          <th scope="row">1</th>
                          <td>Mark</td>
                          <td>Otto</td>
                          <td>@mdo</td>
                        </tr>
                        <tr>
                          <th scope="row">2</th>
                          <td>Jacob</td>
                          <td>Thornton</td>
                          <td>@fat</td>
                        </tr>
                        <tr>
                          <th scope="row">3</th>
                          <td>Larry</td>
                          <td>the Bird</td>
                          <td>@twitter</td>
                        </tr>
                      </tbody>
                    </table>
            </div>
        </div>
</asp:Content>