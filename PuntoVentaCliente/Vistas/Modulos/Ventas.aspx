<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/Site.Master" AutoEventWireup="true" CodeBehind="Ventas.aspx.cs" Inherits="PuntoVentaCliente.Vistas.Modulos.Ventas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">
        <h1>Ventas</h1>
            
        <br />

        <div class="row">
            <div class="col-sm-5">
                <div class="form-group row">
                    <div class="col-sm-8">
                        <asp:TextBox ID="txtbBusqueda" runat="server" type="text" class="form-control" name="buscar" placeholder="Codigo de barras" MaxLength="13" TextMode="SingleLine" AutoCompleteType="Disabled"></asp:TextBox>
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
                <asp:GridView ID="GridView_Ventas" runat="server"
                    AutoGenerateColumns="False"
                    CssClass="table table-bordered bs-table"
                    DataKeyNames="Id"
                    OnRowCommand="GridView_Ventas_RowCommand">

                    <Columns>

                        <%--campos no editables...--%>
                        <asp:BoundField DataField="Id" HeaderText="Id" ReadOnly="True" SortExpression="Id"/>
                        <asp:BoundField DataField="Producto" HeaderText="Producto" ReadOnly="True" SortExpression="Producto"/>
                        <asp:BoundField DataField="Marca" HeaderText="Marca" ReadOnly="True" SortExpression="Marca" />
                        <asp:BoundField DataField="Descripcion" HeaderText="Descripcion" ReadOnly="True" SortExpression="Descripcion" />
                        <asp:BoundField DataField="Proveedor" HeaderText="Proveedor" ReadOnly="True" SortExpression="Proveedor" />
                        <asp:BoundField DataField="CostoVenta" HeaderText="Costo unitario" ReadOnly="True" SortExpression="CostoVenta" />
                        <asp:BoundField DataField="Stock" HeaderText="Stock" ReadOnly="True" SortExpression="Stock" />
                        <asp:BoundField DataField="Cantidad" HeaderText="Cantidad" ReadOnly="True" SortExpression="Cantidad" />
                        <asp:BoundField DataField="PrecioTotal" HeaderText="Costo total" ReadOnly="True" SortExpression="PrecioTotal" />
                        
                        <%--botones de acción sobre los registros...--%>
                        <asp:TemplateField ItemStyle-HorizontalAlign="Center" >
                            <ItemTemplate>
                                <%--Botones de eliminar y editar cliente...--%>
                                <asp:Button ID="btnQuitar" runat="server" CssClass="btn btn-info glyphicon glyphicon-remove" CommandName="Quitar" Text="Quitar" CommandArgument="<%# ((GridViewRow) Container).RowIndex %>" />
                            </ItemTemplate>

                        </asp:TemplateField>


                    </Columns>
                </asp:GridView>
            </div>

            <div class="form-group row">
                <asp:Label ID="lblTotal" for="Nombre" class="col-sm-4 col-form-label" runat="server" Text=""></asp:Label>
            </div>
            
            <center>
                <div class="form-group"> <!-- Button -->
                    <asp:Button ID="btnVenta" runat="server" Text="Generar Venta" class="btn btn-primary" center-align="true" OnClick="btnVenta_Click" OnClientClick="return confirm('¿Realizar accion?');"/>
                </div>     
            </center>

            <br />

            <center>
                <div class="form-group" > <!-- Button -->
                    <asp:Button ID="btnTicket" runat="server" Text="Ticket" class="btn btn-success" center-align="true" OnClick="btnTicket_Click" Visible="false"/>
                </div> 
            </center>

        </div>

    </div>

</asp:Content>
