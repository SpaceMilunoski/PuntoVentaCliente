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
                        <asp:DropDownList CssClass="form-control" ID="ddlTipoBusqueda" runat="server">
                            <asp:ListItem Selected="True" Value="Empleado"> Empleado </asp:ListItem>
                            <asp:ListItem Value="Fecha"> Fecha </asp:ListItem>
                        </asp:DropDownList>
                    </div>
                </div>

                <br />

                <div class="form-group row">

                    <label for="Empleado" class="col-sm-1 col-form-label">Empleado: </label>
                    <div class="col-sm-2">
                        <asp:TextBox ID="txtbEmpleado" runat="server" type="text" class="form-control" name="Empleado" placeholder="Nombre o apellido" MaxLength="50" TextMode="SingleLine" AutoCompleteType="Disabled"></asp:TextBox>
                    </div>

                    <label for="FechaInicio" class="col-sm-1 col-form-label">De: </label>
                    <div class="col-sm-2">
                        <asp:TextBox ID="txtbFechaInicio" runat="server" type="text" class="form-control" name="FechaInicio" TextMode="Date"></asp:TextBox>
                    </div>

                    <label for="FechaFinal" class="col-sm-1 col-form-label">a: </label>
                    <div class="col-sm-2">
                        <asp:TextBox ID="txtbFechaFinal" runat="server" type="text" class="form-control" name="FechaFinal" TextMode="Date"></asp:TextBox>
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
                    AllowPaging="True" OnRowCommand="GridView_Reportes_RowCommand" OnPageIndexChanging="GridView_Reportes_PageIndexChanging">

                    <Columns>

                        <%--campos no editables...--%>
                        <asp:BoundField DataField="Id" HeaderText="Id" ReadOnly="True" SortExpression="Id"/>
                        <asp:BoundField DataField="SubTotal" HeaderText="SubTotal" ReadOnly="True" SortExpression="SubTotal"/>
                        <asp:BoundField DataField="Total" HeaderText="Total" ReadOnly="True" SortExpression="Total" />
                        <asp:BoundField DataField="Fecha" HeaderText="Fecha" ReadOnly="True" SortExpression="Fecha" />
                        <asp:BoundField DataField="Vendedor" HeaderText="Vendedor" ReadOnly="True" SortExpression="Vendedor" />
                        
                        <%--botones de acción sobre los registros...--%>
                        <asp:TemplateField ItemStyle-HorizontalAlign="Center" >
                            <ItemTemplate>
                                <%--Botones de eliminar y editar cliente...--%>
                                <asp:Button ID="btnVerDetalles" runat="server" CssClass="btn btn-info glyphicon glyphicon-remove" CommandName="VerDetalles" CommandArgument="<%# ((GridViewRow) Container).RowIndex %>" />
                            </ItemTemplate>

                        </asp:TemplateField>


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