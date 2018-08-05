<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/Site.Master" AutoEventWireup="true" CodeBehind="Productos.aspx.cs" Inherits="PuntoVentaCliente.Vistas.Modulos.Productos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">
        <h1>Productos</h1>
        <br />
        <div class="row">
<<<<<<< HEAD
            <form>
                <div class="form-group">
                    <div class="col-sm-3" style="background-color:white;">
                        <div class="form-group row">
                            <label for="identificador" class="col-sm-4 col-form-label">Codigo</label>
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
                            <label for="marca" class="col-sm-4 col-form-label">Marca</label>
                            <div class="col-sm-8">
                                <asp:TextBox  id="marca" class="form-control" type="text" placeholder="Default input" runat="server"></asp:TextBox>
                                <!--<asp:DropDownList CssClass="form-control" id="ddmarca" runat="server"></asp:DropDownList>-->
                            </div>
                        </div>
                        <!----------------------------------->
                        <div class="form-group row">
                            <label for="ddproveedor" class="col-sm-4 col-form-label">Proveedor</label>
                            <div class="col-sm-8">
                                <!--<input id="proveedor" class="form-control" type="text" placeholder="Default input">-->
                                <asp:DropDownList CssClass="form-control" id="ddproveedor" runat="server"></asp:DropDownList>
                            </div>
=======
            <div class="form-group">

                <div class="col-sm-6" style="background-color: white;">
                        
                    <asp:TextBox ID="txtbId" runat="server" type="text" class="form-control" name="Id" MaxLength="11" TextMode="SingleLine" visible="false"></asp:TextBox>

                    <div class="form-group row">
                        <label for="Codigo" class="col-sm-4 col-form-label">Codigo *</label>
                        <div class="col-sm-8">
                            <asp:TextBox ID="txtbCodigo" runat="server" type="text" class="form-control" name="Codigo" placeholder="Introduzca el codigo" MaxLength="13" TextMode="SingleLine" AutoCompleteType="Disabled"></asp:TextBox>
                        </div>
                    </div>

                    <div class="form-group row">
                        <label for="Nombre" class="col-sm-4 col-form-label">Nombre *</label>
                        <div class="col-sm-8">
                            <asp:TextBox ID="txtbNombre" runat="server" type="text" class="form-control" name="Nombre" placeholder="Introduzca el producto" MaxLength="100" TextMode="SingleLine" AutoCompleteType="Disabled"></asp:TextBox>
                        </div>
                    </div>

                    <div class="form-group row">
                        <label for="Marca" class="col-sm-4 col-form-label">Marca *</label>
                        <div class="col-sm-8">
                            <asp:TextBox ID="txtbMarca" runat="server" type="text" class="form-control" name="Marca" placeholder="Marca del producto" MaxLength="50" TextMode="SingleLine" AutoCompleteType="Disabled"></asp:TextBox>
                        </div>
                    </div>

                    <div class="form-group row">
                        <label for="Descripcion" class="col-sm-4 col-form-label">Descripcion *</label>
                        <div class="col-sm-8">
                            <asp:TextBox ID="txtbDescripcion" runat="server" type="text" class="form-control" name="Descripcion" placeholder="Descripcion del producto" MaxLength="200" TextMode="MultiLine" AutoCompleteType="Disabled"></asp:TextBox>
>>>>>>> 680b211b4cb5d995e79b849bccf6cefd083149dc
                        </div>
                    </div>
<<<<<<< HEAD
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
=======

                    <div class="form-group row">
                        <label for="CostoCompra" class="col-sm-4 col-form-label">Costo compra *</label>
                        <div class="col-sm-8">
                            <asp:TextBox ID="txtbCostoCompra" runat="server" type="text" class="form-control" name="CostoCompra" placeholder="Introduzca el costo compra" MaxLength="14" TextMode="SingleLine" AutoCompleteType="Disabled"></asp:TextBox>
                        </div>
                    </div>

                    <div class="form-group row">
                        <label for="CostoVenta" class="col-sm-4 col-form-label">Costo venta *</label>
                        <div class="col-sm-8">
                            <asp:TextBox ID="txtbCostoVenta" runat="server" type="text" class="form-control" name="CostoVenta" placeholder="Introduzca el costo venta" MaxLength="14" TextMode="SingleLine" AutoCompleteType="Disabled"></asp:TextBox>
                        </div>
                    </div>

                    <div class="form-group row">
                        <label for="Stock" class="col-sm-4 col-form-label">Stock *</label>
                        <div class="col-sm-8">
                            <asp:TextBox ID="txtbStock" runat="server" type="text" class="form-control" name="Stock" placeholder="Stock del producto" MaxLength="11" TextMode="Number" AutoCompleteType="Disabled"></asp:TextBox>
                        </div>
                    </div>

                </div>

                <div class="col-sm-5" style="background-color: white;">

                    <div class="form-group row">
                        <label for="Proveedor" class="col-sm-4 col-form-label">Proveedor *</label>
                        <div class="col-sm-8">
                            <asp:DropDownList CssClass="form-control" ID="ddlProveedor" runat="server"></asp:DropDownList>
                        </div>
                    </div>

                    <div class="form-group row">
                        <label for="Departamentos" class="col-sm-4 col-form-label">Departamento *</label>
                        <div class="col-sm-8">
                            <asp:DropDownList CssClass="form-control" ID="ddlDepartamentos" runat="server"></asp:DropDownList>
                            <asp:TextBox ID="txtbDepartamento" runat="server" type="text" class="form-control" name="Departamentos" placeholder="Introduzca el departamento" MaxLength="50" TextMode="SingleLine" AutoCompleteType="Disabled" visible="false"></asp:TextBox>

                            <br />

                            <asp:Button ID="btnAgregarDepartamento" runat="server" Text="Nuevo Dpto." class="btn btn-primary" center-align="true" OnClick="btnAgregarDepartamento_Click" />
                            <asp:Button ID="btnEliminarDepartamento" runat="server" Text="Eliminar Dpto." class="btn btn-danger" center-align="true" OnClick="btnEliminarDepartamento_Click" />

>>>>>>> 680b211b4cb5d995e79b849bccf6cefd083149dc
                        </div>

                        
                    </div>
<<<<<<< HEAD
                    <div class="col-sm-3" style="background-color:white;">
                        <%--<div class="form-group row">
                            <label for="fecha_registro" class="col-sm-4 col-form-label">Fecha de Registro</label>
                            <div class="col-sm-8">
                                <asp:TextBox id="fecha_registro" class="form-control" type="date" min="1000-01-01" max="3000-12-31" runat="server"></asp:TextBox>
                            </div>
                        </div>--%>
                      <!------------------------------------->
                        <div class="form-group row">
                            <label for="ddunidad_medida" class="col-sm-4 col-form-label">Unidad de Medida</label>
                            <div class="col-sm-8">
                                <!--<input id="unidad_medida" class="form-control" type="text" placeholder="Default input">-->
                                <asp:DropDownList CssClass="form-control" id="ddunidad_medida" runat="server"></asp:DropDownList>
                            </div>
                        </div>    
                      <!------------------------------------->
                        <%--<div class="form-group row">
                          <label for="fecha_caducidad" class="col-sm-4 col-form-label">Fecha de caducidad</label>
                          <div class="col-sm-8">
                              <asp:TextBox id="fecha_caducidad" class="form-control" type="date" min="1000-01-01" max="3000-12-31" runat="server" ></asp:TextBox>
                          </div>
                      </div>   --%>
                      <!------------------------------------->
                        <div class="form-group row">
                            <label for="dddepartamento" class="col-sm-4 col-form-label">Departamento</label>
                            <div class="col-sm-8">
                                <!--<input id="departamento" class="form-control" type="text" placeholder="Default input">-->
                                <asp:DropDownList CssClass="form-control" id="dddepartamento" runat="server" ></asp:DropDownList>
                            </div>
                        </div>   
                      <!------------------------------------->                                                                  
=======

                    <div class="form-group row">
                        <label for="Unidad" class="col-sm-4 col-form-label">Unidad *</label>
                        <div class="col-sm-8">
                            <asp:DropDownList CssClass="form-control" ID="ddlUnidad" runat="server"></asp:DropDownList>
                            <asp:TextBox ID="txtbUnidad" runat="server" type="text" class="form-control" name="Unidad" placeholder="Introduzca la unidad" MaxLength="50" TextMode="SingleLine" AutoCompleteType="Disabled" visible="false"></asp:TextBox>

                            <br />

                            <asp:Button ID="btnAgregarUnidad" runat="server" Text="Nueva Unidad" class="btn btn-primary" center-align="true" OnClick="btnAgregarUnidad_Click" />
                            <asp:Button ID="btnEliminarUnidad" runat="server" Text="Eliminar Unidad" class="btn btn-danger" center-align="true" OnClick="btnEliminarUnidad_Click" />


                        </div>
>>>>>>> 680b211b4cb5d995e79b849bccf6cefd083149dc
                    </div>

                    <br />

                    <div class="form-group row">
                        <center>
                            <asp:Button ID="btnInsertar" runat="server" Text="" class="btn btn-success" center-align="true" OnClick="btnInsertar_Click" />
                        </center>
                    </div>

                </div>
<<<<<<< HEAD
            </form>
                    <div class="col-sm-3" style="background-color:white;">
                        <div class="form-group row">
                            <asp:Button id="btnAgregar" runat="server" class="btn btn-success" Text="Agregar" OnClick="btnAgregar_Click"/>
                        </div>
                        <!------------------------------------->
                        <div class="form-group row">
                             <asp:Button id="btnActualizar" runat="server" class="btn btn-primary" Text="Actualizar" OnClick="btnActualizar_Click"/>
                        </div>
                        <!--------------------------------------->
                    </div>         
=======
            </div>
>>>>>>> 680b211b4cb5d995e79b849bccf6cefd083149dc
        </div>
        <br />

        <div class="row">
<<<<<<< HEAD
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
=======
            <div class="col-sm-5">
                <div class="form-group row">
                    <div class="col-sm-8">
                        <asp:TextBox ID="txtbBusqueda" runat="server" type="text" class="form-control" name="buscar" placeholder="Busqueda por nombre, marca o codigo" MaxLength="100" TextMode="SingleLine" AutoCompleteType="Disabled"></asp:TextBox>
                    </div>
                    <div class="col-sm-2">
                        <asp:Button ID="btnBuscar" runat="server" Text="Buscar" class="btn btn-info" center-align="true" OnClick="btnBuscar_Click" />
                    </div>
                </div>
            </div>
        </div>

        <br />
        <div >
            
            <div Class="table bs-table">
>>>>>>> 680b211b4cb5d995e79b849bccf6cefd083149dc
                <asp:GridView ID="GridView_Productos" runat="server"
                    AutoGenerateColumns="False"
                    CssClass="table table-bordered bs-table"
                    DataKeyNames="Id"
<<<<<<< HEAD
                    AllowPaging="true" OnRowCommand="GridView_Productos_RowCommand" OnPageIndexChanging="GridView_Pr_PageIndexChanging">
=======
                    AllowPaging="True" OnRowCommand="GridView_Productos_RowCommand" OnPageIndexChanging="GridView_Productos_PageIndexChanging">
>>>>>>> 680b211b4cb5d995e79b849bccf6cefd083149dc

                    <Columns>

                        <%--campos no editables...--%>
<<<<<<< HEAD
                        <asp:BoundField DataField="Id" HeaderText="Id" ReadOnly="True" visible="true"/>
                        <asp:BoundField DataField="Codigo" HeaderText="Codigo" ReadOnly="True" />
                        <asp:BoundField DataField="Nombre" HeaderText="Nombre" ReadOnly="True" />
                        <asp:BoundField DataField="Marca" HeaderText="Marca" ReadOnly="True" />
                        <asp:BoundField DataField="Descripcion" HeaderText="Descripción" ReadOnly="True" />
                        <asp:BoundField DataField="CostoVenta" HeaderText="Costo venta" ReadOnly="True" />
                        <asp:BoundField DataField="CostoCompra" HeaderText="Costo compra" ReadOnly="True"/>
                        <asp:BoundField DataField="Stock" HeaderText="Stock" ReadOnly="True"/>
                        <asp:BoundField DataField="Proveedor" HeaderText="Proveedor" ReadOnly="True" />
                        <asp:BoundField DataField="Departamento" HeaderText="Departamento" ReadOnly="True"/>
                        <asp:BoundField DataField="Unidad" HeaderText="Unidad medida" ReadOnly="True"/>
                        <%--<asp:BoundField DataField="FechaRegistro" HeaderText="Fecha registro" ReadOnly="True"/>
                        <asp:BoundField DataField="FechaCaducidad" HeaderText="Fecha caducidad" ReadOnly="True"/>--%>
                        
                        <%--botones de acción sobre los registros...--%>
                        <asp:TemplateField ItemStyle-HorizontalAlign="Center" >
                            <ItemTemplate>
                                <%--Botones de eliminar y editar cliente...--%>
                                <!-- <asp:Button ID="btnDelete" runat="server" Text="Eliminar" CssClass="btn btn-danger" CommandName="Eliminar" OnClientClick="return confirm('¿Eliminar registro?'); " CommandArgument="<%# ((GridViewRow) Container).RowIndex %>" /> -->
                                <asp:Button ID="btnEdit" runat="server" Text="Editar" CssClass="btn btn-info" CommandName="Editar" OnClientClick="return confirm('¿Editar registro?'); " CommandArgument="<%# ((GridViewRow) Container).RowIndex %>" />
                            </ItemTemplate>
=======
                        <asp:BoundField DataField="Id" HeaderText="Id" ReadOnly="True" SortExpression="Id"/>
                        <asp:BoundField DataField="Codigo" HeaderText="Codigo" ReadOnly="True" SortExpression="Codigo" />
                        <asp:BoundField DataField="Nombre" HeaderText="Nombre" ReadOnly="True" SortExpression="Nombre" />
                        <asp:BoundField DataField="Marca" HeaderText="Marca" ReadOnly="True" SortExpression="Marca" />
                        <asp:BoundField DataField="Descripcion" HeaderText="Descripcion" ReadOnly="True" SortExpression="Descripccion" />
                        <asp:BoundField DataField="CostoCompra" HeaderText="CostoCompra" ReadOnly="True" SortExpression="CostoCompra" />
                        <asp:BoundField DataField="CostoVenta" HeaderText="CostoVenta" ReadOnly="True" SortExpression="CostoVenta"/>
                        <asp:BoundField DataField="Stock" HeaderText="Stock" ReadOnly="True" SortExpression="Stock" />
                        <asp:BoundField DataField="Proveedor" HeaderText="Proveedor" ReadOnly="True" SortExpression="Proveedor" />
                        <asp:BoundField DataField="Departamento" HeaderText="Departamento" ReadOnly="True" SortExpression="Departamento" />
                        <asp:BoundField DataField="Unidad" HeaderText="Unidad" ReadOnly="True" SortExpression="Unidad" />
                        
                        <%--botones de acción sobre los registros...--%>
                        <asp:TemplateField ItemStyle-HorizontalAlign="Center" HeaderStyle-Width="300px">
                            <ItemTemplate>
                                <%--Botones de eliminar y editar cliente...--%>
                                <asp:Button ID="btnDelete" runat="server" Text="Eliminar" CssClass="btn btn-danger" CommandName="Eliminar" OnClientClick="return confirm('¿Eliminar registro?'); " CommandArgument="<%# ((GridViewRow) Container).RowIndex %>" />
                                <asp:Button ID="btnEdit" runat="server" Text="Editar" CssClass="btn btn-info" CommandName="Editar" CommandArgument="<%# ((GridViewRow) Container).RowIndex %>" />
                                <asp:Button ID="btnAgregar" runat="server" Text="Agregar" CssClass="btn btn-success" CommandName="Agregar" CommandArgument="<%# ((GridViewRow) Container).RowIndex %>" />
                            </ItemTemplate>

>>>>>>> 680b211b4cb5d995e79b849bccf6cefd083149dc
                        </asp:TemplateField>


                    </Columns>
                </asp:GridView>
<<<<<<< HEAD
            </div>
=======
>>>>>>> 680b211b4cb5d995e79b849bccf6cefd083149dc
            </div>

        </div>

    </div>
<<<<<<< HEAD
    </div>
=======

>>>>>>> 680b211b4cb5d995e79b849bccf6cefd083149dc
</asp:Content>
