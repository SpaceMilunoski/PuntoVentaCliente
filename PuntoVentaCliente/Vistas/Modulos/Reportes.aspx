<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/Site.Master" AutoEventWireup="true" CodeBehind="Reportes.aspx.cs" Inherits="PuntoVentaCliente.Vistas.Modulos.Reportes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">
        <h1>Reportes</h1>
        <br />
        <div class="row">
            <div class="form-group">
                
                <div class="form-group row">
                    <label for="TipoBusqueda" class="col-sm-2 col-form-label">Tipo de busqueda</label>
                    <div class="col-sm-3">
                        <asp:DropDownList CssClass="form-control" ID="ddlTipoBusqueda" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlTipoBusqueda_SelectedIndexChanged">
                            <asp:ListItem Selected="True" Value="Fecha"> Fecha </asp:ListItem>
                            <asp:ListItem Value="Empleado"> Empleado </asp:ListItem>
                        </asp:DropDownList>
                    </div>
                </div>

                <br />

                <div class="form-group row">

                    <asp:Label for="Empleado" ID="lblEmpleado" class="col-sm-1 col-form-label" runat="server" Text="Empleado: " Visible ="False"></asp:Label>
                    <div class="col-sm-2">
                        <asp:TextBox ID="txtbEmpleado" runat="server" type="text" class="form-control" name="Empleado" placeholder="Nombre o apellido" MaxLength="50" TextMode="SingleLine" AutoCompleteType="Disabled" Visible="false"></asp:TextBox>
                    </div>

                </div>

                <div class="form-group row">

                    <asp:Label for="FechaInicio" ID="lblDe" class="col-sm-1 col-form-label" runat="server" Text="De: "></asp:Label>
                    <div class="col-sm-2">
                        <asp:TextBox ID="txtbFechaInicio" runat="server" type="text" class="form-control" name="FechaInicio" TextMode="Date"></asp:TextBox>
                    </div>

                    <asp:Label for="FechaFinal" ID="lblA" class="col-sm-1 col-form-label" runat="server" Text="a: "></asp:Label>
                    <div class="col-sm-2">
                        <asp:TextBox ID="txtbFechaFinal" runat="server" type="text" class="form-control" name="FechaFinal" TextMode="Date"></asp:TextBox>
                    </div>
                    
                </div>

                <div class="form-group row">

                    <div class="col-sm-2">
                        <asp:Button ID="btnBuscar" runat="server" Text="Buscar" class="btn btn-info" center-align="true" OnClick="btnBuscar_Click" />
                    </div>

                </div>

            </div>
        </div>

        <br />

        <div >
            
           <div Class="table bs-table">
                <asp:GridView ID="GridView_Reportes" runat="server"
                    AutoGenerateColumns="False"
                    CssClass="table table-bordered bs-table"
                    DataKeyNames="Id"
                    AllowPaging="True" OnRowCommand="GridView_Reportes_RowCommand" OnPageIndexChanging="GridView_Reportes_PageIndexChanging">

                    <Columns>

                        <%--campos no editables...--%>
                        <asp:BoundField DataField="Id" HeaderText="No. Venta" ReadOnly="True" SortExpression="Id"/>
                        <asp:BoundField DataField="SubTotal" HeaderText="SubTotal" ReadOnly="True" SortExpression="SubTotal"/>
                        <asp:BoundField DataField="Total" HeaderText="Total" ReadOnly="True" SortExpression="Total" />
                        <asp:BoundField DataField="FechaVenta" HeaderText="Fecha" ReadOnly="True" SortExpression="Fecha" DataFormatString="{0:yyyy-MM-dd}" HtmlEncode=false />
                        <asp:BoundField DataField="Vendedor" HeaderText="Vendedor" ReadOnly="True" SortExpression="Vendedor" />
                        
                        <%--botones de acción sobre los registros...--%>
                        <asp:TemplateField ItemStyle-HorizontalAlign="Center" >
                            <ItemTemplate>
                                <%--Botones de eliminar y editar cliente...--%>
                                <asp:Button ID="btnVerDetalles" runat="server" CssClass="btn btn-info" Text="Ver detalles" CommandName="VerDetalles" CommandArgument="<%# ((GridViewRow) Container).RowIndex %>" />
                            </ItemTemplate>

                        </asp:TemplateField>


                    </Columns>
                </asp:GridView>


               <asp:GridView ID="GridView_Detalles" runat="server"
                    AutoGenerateColumns="False"
                    CssClass="table table-bordered bs-table"
                    DataKeyNames="Venta">

                    <Columns>

                        <%--campos no editables...--%>
                        <asp:BoundField DataField="Venta" HeaderText="No. Venta" ReadOnly="True"/>
                        <asp:BoundField DataField="Nombre" HeaderText="Producto" ReadOnly="True"/>
                        <asp:BoundField DataField="Marca" HeaderText="Marca" ReadOnly="True"/>
                        <asp:BoundField DataField="PrecioUnitario" HeaderText="Precio unitario" ReadOnly="True"/>
                        <asp:BoundField DataField="Cantidad" HeaderText="Cantidad" ReadOnly="True"/>
                        <asp:BoundField DataField="PrecioTotal" HeaderText="PrecioTotal" ReadOnly="True"/>
                        
                    </Columns>
                </asp:GridView>

            </div>

            <center>
                <div class="form-group"> <!-- Button -->
                    <asp:Button ID="btnPDF" runat="server" Text="Generar PDF" class="btn btn-primary" center-align="true" OnClick="btnPDF_Click" />
                </div>     
            </center>


        </div>

    </div>

</asp:Content>