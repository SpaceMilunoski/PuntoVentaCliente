<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/Site.Master" AutoEventWireup="true" CodeBehind="Productos.aspx.cs" Inherits="PuntoVentaCliente.Vistas.Modulos.Productos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">
        <h1>Productos</h1>
        <br />
        <div class="row">
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
                        </div>
                    </div>

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

                        </div>

                        
                    </div>

                    <div class="form-group row">
                        <label for="Unidad" class="col-sm-4 col-form-label">Unidad *</label>
                        <div class="col-sm-8">
                            <asp:DropDownList CssClass="form-control" ID="ddlUnidad" runat="server"></asp:DropDownList>
                            <asp:TextBox ID="txtbUnidad" runat="server" type="text" class="form-control" name="Unidad" placeholder="Introduzca la unidad" MaxLength="50" TextMode="SingleLine" AutoCompleteType="Disabled" visible="false"></asp:TextBox>

                            <br />

                            <asp:Button ID="btnAgregarUnidad" runat="server" Text="Nueva Unidad" class="btn btn-primary" center-align="true" OnClick="btnAgregarUnidad_Click" />
                            <asp:Button ID="btnEliminarUnidad" runat="server" Text="Eliminar Unidad" class="btn btn-danger" center-align="true" OnClick="btnEliminarUnidad_Click" />


                        </div>
                    </div>

                    <br />

                    <div class="form-group row">
                        <center>
                            <asp:Button ID="btnInsertar" runat="server" Text="" class="btn btn-success" center-align="true" OnClick="btnInsertar_Click" />
                        </center>
                    </div>

                </div>
            </div>
        </div>
        <br />

        <div class="row">
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
                <asp:GridView ID="GridView_Productos" runat="server"
                    AutoGenerateColumns="False"
                    CssClass="table table-bordered bs-table"
                    DataKeyNames="Id"
                    AllowPaging="True" OnRowCommand="GridView_Productos_RowCommand" OnPageIndexChanging="GridView_Productos_PageIndexChanging">

                    <Columns>

                        <%--campos no editables...--%>
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

                        </asp:TemplateField>


                    </Columns>
                </asp:GridView>
            </div>

        </div>

    </div>

</asp:Content>
