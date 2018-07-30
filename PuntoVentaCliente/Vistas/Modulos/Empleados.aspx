<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/Site.Master" AutoEventWireup="true" CodeBehind="Empleados.aspx.cs" Inherits="PuntoVentaCliente.Vistas.Modulos.Empleados" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">
        <h1 align="center">Usuarios</h1>
        <div class="row"><form>
        <div class="col-sm-5" style="background-color: white;">
        <div class="form-group row">
        <div class="col-sm-5"><input id="buscar" class="form-control" type="text" placeholder="Buscar" /></div>
        <div class="col-sm-3"><button class="btn btn-success" type="button">Buscar</button></div>
        </div>

        <form>

          <div class="form-group">
            <label for="exampleInputEmail1">Nombre</label>
            <input type="email" class="form-control" id="Nombre" aria-describedby="emailHelp" placeholder="Nombre">
            <small id="nombre" class="form-text text-muted">Nombre completo.</small>
          </div>
          <div class="form-group">
            <label for="exampleInputPassword1">Contraseña</label>
            <input type="password" class="form-control" id="Contraseña" placeholder="Contraseña">
          </div>
          <div class="form-group">
            <label for="exampleSelect1">Privilegios</label>
            <select class="form-control" id="privilegios">
              <option>Gerente</option>
              <option>Administrador</option>
              <option>Empleado</option>
              <option>4</option>
              <option>5</option>
            </select>
          </div>
  
                        
        </form>

        <div class="row">
            <table class="table">
        <thead>
            <tr>
            <th scope="col">ID</th>
            <th scope="col">Nombre</th>
            <th scope="col">Contraseña</th>
            <th scope="col">Privilegio</th>
            <th scope="col">&nbsp;</th>
            </tr>

        <tbody>
        <tr>
        <th scope="row">1</th>
        <td>Juan Perez Perez</td>
        <td>***********</td>
        <td>gerente</td>
            <td>
            <div class="row">
          <div class="col-sm-3"><button class="btn btn-danger" type="button"><em class="material-icons">delete</em></button></div>
                <div class="col-sm-3"><button class="btn btn-primary" type="button"><em class="material-icons">edit</em></button></div>
          </div>
        </td>
                </tr>
                    </tbody>
                </table>
</div>

</asp:Content>
