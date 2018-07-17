<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Productos.aspx.cs" Inherits="PuntoVentaCliente.Productos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <form>
      <div class="form-group">
        <div class="container">  
            <h1>Productos</h1>
              <div class="row">
                <div class="col-sm-4" <!--style="background-color:yellow;"-->>
                 <div class="form-group row">
                    <label for="identificador" class="col-sm-4 col-form-label">Identificador</label>
                    <div class="col-sm-8">
                        <input id="identificador" class="form-control" type="text" placeholder="Default input">
                    </div>
                 </div>
                    <!------->
                    <div class="form-group row">
                    <label for="nombre" class="col-sm-4 col-form-label">Nombre</label>
                    <div class="col-sm-8">
                        <input id="nombre" class="form-control" type="text" placeholder="Default input">
                    </div>
                 </div>
                    <!------------------>
                    <div class="form-group row">
                    <label for="marca" class="col-sm-4 col-form-label">Marca</label>
                    <div class="col-sm-8">
                        <input id="marca" class="form-control" type="text" placeholder="Default input">
                    </div>
                 </div>
                    <!------------------------->
                    <div class="form-group row">
                    <label for="proveedor" class="col-sm-4 col-form-label">Proveedor</label>
                    <div class="col-sm-8">
                        <input id="proveedor" class="form-control" type="text" placeholder="Default input">
                    </div>
                 </div>
                    <!------------------------->
                </div>
                <div class="col-sm-4" style="background-color:pink;">
                 <input class="form-control" type="text" placeholder="Default input">
                    <input class="form-control" type="text" placeholder="Default input">
                    <input class="form-control" type="text" placeholder="Default input">
                    <input class="form-control" type="text" placeholder="Default input">
                    <input class="form-control" type="text" placeholder="Default input">
                </div>
                  <div class="col-sm-4" <!--style="background-color:green;"-->>
                    <div class="form-group row">
                        <label for="fecha_registro" class="col-sm-4 col-form-label">Fecha de Registro</label>
                        <div class="col-sm-8">
                            <input id="fecha_registro" class="form-control" type="text" placeholder="Default input">
                        </div>
                     </div>
                      <!---------------------------------->
                      <div class="form-group row">
                        <label for="unidad_medida" class="col-sm-4 col-form-label">Unidad de Medida</label>
                        <div class="col-sm-8">
                            <input id="unidad_medida" class="form-control" type="text" placeholder="Default input">
                        </div>
                      </div>    
                      <!---------------------------------->
                      <div class="form-group row">
                        <label for="fecha_caducidad" class="col-sm-4 col-form-label">Fecha de caducidad</label>
                        <div class="col-sm-8">
                            <input id="fecha_caducidad" class="form-control" type="text" placeholder="Default input">
                        </div>
                      </div>   
                      <!---------------------------------->
                      <div class="form-group row">
                        <label for="departamento" class="col-sm-4 col-form-label">Departamento</label>
                        <div class="col-sm-8">
                            <input id="departamento" class="form-control" type="text" placeholder="Default input">
                        </div>
                      </div>   
                      <!---------------------------------->
                                                                  
              </div>
                  </div>
         </div>
        </div>
        <button type="submit" class="btn btn-primary">Submit</button>
    </form>
</asp:Content>