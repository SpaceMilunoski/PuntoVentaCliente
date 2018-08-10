<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/Site.Master" AutoEventWireup="true" CodeBehind="Ventas.aspx.cs" Inherits="PuntoVentaCliente.Vistas.Modulos.Ventas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">
        <h1>Ventas</h1>
            
        <br />

        <div class="row">
            <div class="col-sm-5">
                <div class="form-group row">
                    <div class="col-sm-8">
                        <asp:TextBox ID="txtbBusqueda" runat="server" type="text" class="form-control" name="Agregar Producto a la Venta" placeholder="Codigo de barras" MaxLength="50" TextMode="SingleLine" AutoCompleteType="Disabled"></asp:TextBox>
                    </div>
                    <div class="col-sm-2">
                        <asp:Button ID="btnBuscar" runat="server" Text="Agregar Producto a la venta" class="btn btn-success" center-align="true" OnClick="btnBuscar_Click" />
                    </div>
                </div>
            </div>
        </div>

        <br />
        <div >
            
            <div Class="table bs-table">
                <asp:GridView ID="GridView_Ventas" runat="server"
                    AutoGenerateColumns="False"
                    CssClass="table table-bordered bs-table"
                    DataKeyNames="Id"
                    AllowPaging="True" OnRowCommand="GridView_Ventas_RowCommand">

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

                        <asp:BoundField DataField="Cantidad" HeaderText="Cantidad" ReadOnly="True" SortExpression="Cantidad" />
                        <asp:BoundField DataField="PrecioTotal" HeaderText="Costo total" ReadOnly="True" SortExpression="PrecioTotal" />
                        
                        <%--botones de acción sobre los registros...--%>
                        <asp:TemplateField ItemStyle-HorizontalAlign="Center" >
                            <ItemTemplate>
                                <%--Botones de eliminar y editar cliente...--%>
                               <asp:Button ID="btnDelete" runat="server" Text="Eliminar" CssClass="btn btn-danger" CommandName="Eliminar" OnClientClick="return confirm('¿Eliminar Producto?'); " CommandArgument="<%# ((GridViewRow) Container).RowIndex %>" />
                            </ItemTemplate>

                        </asp:TemplateField>


                    </Columns>
                </asp:GridView>
            </div>

            <center>
                <div class="form-group">
                    <asp:Button ID="btnVenta" runat="server" Text="Generar Venta" class="btn btn-primary" center-align="true" OnClick="btnVenta_Click" />
                </div>     
            </center>

        </div>
        <div class="row">
            <asp:label for="subtotal" runat="server" class="col-sm-1 col-form-label">Subtotal</asp:label> 
            <asp:Label ID="lbSubtotal" runat="server" class="col-sm-1 col-form-label"  ></asp:Label>
            <asp:label for="total" runat="server" class="col-sm-1 col-form-label">Total</asp:label> 
            <asp:Label ID="lbTotal" runat="server" class="col-sm-1 col-form-label"  ></asp:Label>
        </div> 
    </div>

</asp:Content>

