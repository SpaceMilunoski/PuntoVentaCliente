<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/Site.Master" AutoEventWireup="true" CodeBehind="Productos.aspx.cs" Inherits="PuntoVentaCliente.Vistas.Modulos.Productos" %>
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
                                <asp:TextBox id="identificador" class="form-control" type="text" placeholder="" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <!----------------------------------->
                        <div class="form-group row">
                            <label for="nombre" class="col-sm-4 col-form-label">Nombre</label>
                            <div class="col-sm-8">
                                <asp:TextBox id="nombre" class="form-control" type="text" placeholder="" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <!----------------------------------->
                        <div class="form-group row">
                            <label for="ddmarca" class="col-sm-4 col-form-label">Marca</label>
                            <div class="col-sm-8">
                                <!--<input id="marca" class="form-control" type="text" placeholder="Default input">-->
                                <asp:DropDownList CssClass="form-control" id="ddmarca" runat="server"></asp:DropDownList>
                                <asp:DropDownList CssClass="form-control" id="ddIdmarca" runat="server" Visible="false"></asp:DropDownList>
                                
                            </div>
                        </div>
                        <!----------------------------------->
                        <div class="form-group row">
                            <label for="ddproveedor" class="col-sm-4 col-form-label">Proveedor</label>
                            <div class="col-sm-8">
                                <!--<input id="proveedor" class="form-control" type="text" placeholder="Default input">-->
                                <asp:DropDownList CssClass="form-control" id="ddproveedor" runat="server"></asp:DropDownList>
                                <asp:DropDownList CssClass="form-control" id="ddIdproveedor" runat="server" Visible="false"></asp:DropDownList>    
                            </div>
                        </div>
                        <!----------------------------------->
                    </div>
                    <div class="col-sm-3" style="background-color:white;">
                        <div class="form-group row">
                            <label for="descripcion" class="col-sm-4 col-form-label">Descripcion</label>
                            <div class="col-sm-8">
                                <asp:TextBox id="descripcion" class="form-control" type="text" placeholder="" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <!----------------------------------->
                        
                        <!----------------------------------->
                        <div class="form-group row">
                            <label for="costo_venta" class="col-sm-4 col-form-label">Costo de venta</label>
                            <div class="col-sm-8">
                                <asp:TextBox id="costo_venta" class="form-control" type="number" placeholder="0" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <!----------------------------------->
                        <div class="form-group row">
                            <label for="costo_compra" class="col-sm-4 col-form-label">Costo de compra</label>
                            <div class="col-sm-8">
                                <asp:TextBox id="costo_compra" class="form-control" type="number" placeholder="0" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <!----------------------------------->
                        <div class="form-group row">
                            <label for="stock" class="col-sm-4 col-form-label">Stock</label>
                            <div class="col-sm-8">
                                <asp:TextBox id="stock" class="form-control" type="number" placeholder="0" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <!----------------------------------->                    
                    </div>
                    <div class="col-sm-3" style="background-color:white;">
                        <div class="form-group row">
                            <label for="fecha_registro" class="col-sm-4 col-form-label">Fecha de Registro</label>
                            <div class="col-sm-8">
                                <asp:TextBox id="fecha_registro" class="form-control" type="date" min="1000-01-01" max="3000-12-31" runat="server"></asp:TextBox>
                            </div>
                        </div>
                      <!------------------------------------->
                        <div class="form-group row">
                            <label for="ddunidad_medida" class="col-sm-4 col-form-label">Unidad de Medida</label>
                            <div class="col-sm-8">
                                <!--<input id="unidad_medida" class="form-control" type="text" placeholder="Default input">-->
                                <asp:DropDownList CssClass="form-control" id="ddunidad_medida" runat="server"></asp:DropDownList>
                                <asp:DropDownList CssClass="form-control" id="ddIdunidad_medida" runat="server" Visible="false"></asp:DropDownList>
                            </div>
                        </div>    
                      <!------------------------------------->
                        <div class="form-group row">
                          <label for="fecha_caducidad" class="col-sm-4 col-form-label">Fecha de caducidad</label>
                          <div class="col-sm-8">
                              <asp:TextBox id="fecha_caducidad" class="form-control" type="date" min="1000-01-01" max="3000-12-31" runat="server" ></asp:TextBox>
                          </div>
                      </div>   
                      <!------------------------------------->
                        <div class="form-group row">
                            <label for="dddepartamento" class="col-sm-4 col-form-label">Departamento</label>
                            <div class="col-sm-8">
                                <!--<input id="departamento" class="form-control" type="text" placeholder="Default input">-->
                                <asp:DropDownList CssClass="form-control" id="dddepartamento" runat="server" ></asp:DropDownList>
                                <asp:DropDownList CssClass="form-control" id="ddIddepartamento" runat="server" Visible="false"></asp:DropDownList>
                            </div>
                        </div>   
                      <!------------------------------------->                                                                  
                    </div>
                </div>
            </form>
                    <div class="col-sm-3" style="background-color:white;">
                        <div class="form-group row">
                            <asp:Button id="btnAgregar" runat="server" class="btn btn-success" Text="Agregar"/>
                        </div>
                        <!------------------------------------->
                        <div class="form-group row">
                             <asp:Button id="btnActualizar" runat="server" class="btn btn-primary" Text="Actualizar"/>
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
                                <asp:TextBox id="buscar" class="form-control" type="text" placeholder="Buscar" runat="server"></asp:TextBox>
                            </div>
                            <div class="col-sm-2">
                             <asp:Button id="btnBuscar" runat="server" class="btn btn-success" Text="Buscar"/>
                            </div>
                        </div>
                        <!--------------------------------------->
            </div>
        </div>
        <div class="row">
            <div class="col-sm-12">
                <div Class="table bs-table">
                <asp:GridView ID="GridView_Productos" runat="server"
                    AutoGenerateColumns="False"
                    CssClass="table table-bordered bs-table"
                    DataKeyNames="Id"
                    AllowPaging="true" OnRowCommand="GridView_Productos_RowCommand" OnPageIndexChanging="GridView_Pr_PageIndexChanging">

                    <Columns>

                        <%--campos no editables...--%>
                        <asp:BoundField DataField="Id" HeaderText="Identificador" ReadOnly="True" visible="true"/>
                        <asp:BoundField DataField="Nombre" HeaderText="Nombre" ReadOnly="True" />
                        <asp:BoundField DataField="Marca" HeaderText="Marca" ReadOnly="True" />
                        <asp:BoundField DataField="Proveedor" HeaderText="Proveedor" ReadOnly="True" />
                        <asp:BoundField DataField="Descripcion" HeaderText="Descripción" ReadOnly="True" />
                        <asp:BoundField DataField="CostoVenta" HeaderText="Costo venta" ReadOnly="True" />
                        <asp:BoundField DataField="CostoCompra" HeaderText="Costo compra" ReadOnly="True"/>
                        <asp:BoundField DataField="Stock" HeaderText="Stock" ReadOnly="True"/>
                        <asp:BoundField DataField="FechaRegistro" HeaderText="Fecha registro" ReadOnly="True"/>
                        <asp:BoundField DataField="UnidadMedida" HeaderText="Unidad medida" ReadOnly="True"/>
                        <asp:BoundField DataField="FechaCaducidad" HeaderText="Fecha caducidad" ReadOnly="True"/>
                        <asp:BoundField DataField="Departamento" HeaderText="Departamento" ReadOnly="True"/>
                        
                        <%--botones de acción sobre los registros...--%>
                        <asp:TemplateField ItemStyle-HorizontalAlign="Center" >
                            <ItemTemplate>
                                <%--Botones de eliminar y editar cliente...--%>
                                <!-- <asp:Button ID="btnDelete" runat="server" Text="Eliminar" CssClass="btn btn-danger" CommandName="Eliminar" OnClientClick="return confirm('¿Eliminar registro?'); " CommandArgument="<%# ((GridViewRow) Container).RowIndex %>" /> -->
                                <asp:Button ID="btnEdit" runat="server" Text="Editar" CssClass="btn btn-info" CommandName="Editar" OnClientClick="return confirm('¿Editar registro?'); " CommandArgument="<%# ((GridViewRow) Container).RowIndex %>" />
                            </ItemTemplate>
                        </asp:TemplateField>


                    </Columns>
                </asp:GridView>
            </div>
            </div>
        </div>
    </div>
    </div>
</asp:Content>
