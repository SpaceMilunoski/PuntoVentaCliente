<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Productos.aspx.cs" Inherits="PuntoVentaCliente.Productos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <form>
      <div class="form-group">
        <div class="container">  
            <h1>Productos</h1>
              <div class="row">
                <div class="col-sm-4" >
                    <div class="form-group row">
                        <label for="identificador" class="col-sm-2 col-form-label">Identificador</label>
                        <div class="col-sm-10">
                            <input class="form-control" id="identificador" type="text" placeholder="Default input">
                        </div>
                    </div>
                </div>
                <div class="col-sm-4" >
                 <input class="form-control" type="text" placeholder="Default input">
                    <input class="form-control" type="text" placeholder="Default input">
                    <input class="form-control" type="text" placeholder="Default input">
                    <input class="form-control" type="text" placeholder="Default input">
                    <input class="form-control" type="text" placeholder="Default input">
                </div>
                  <div class="col-sm-4" >
                  <input class="form-control" type="text" placeholder="Default input">
                      <input class="form-control" type="text" placeholder="Default input">
                      <input class="form-control" type="text" placeholder="Default input">
                      <input class="form-control" type="text" placeholder="Default input">
                </div>
              </div>
         </div>
        </div>
        <button type="submit" class="btn btn-primary">Submit</button>
    </form>
</asp:Content>