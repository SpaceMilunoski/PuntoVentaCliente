<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/Site.Master" AutoEventWireup="true" CodeBehind="Proveedores.aspx.cs" Inherits="PuntoVentaCliente.Vistas.Modulos.Proveedores" ValidateRequest="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">
        <h1>Proveedores</h1>
        <br />
        <div class="row">
            <form>
                <div class="form-group">
                    <div class="col-sm-5" style="background-color: white;">
                        
                        <asp:TextBox ID="txtbId" runat="server" type="text" class="form-control" name="Id" MaxLength="11" TextMode="SingleLine" visible="false"></asp:TextBox>

                        <div class="form-group row">
                            <label for="RazonSocial" class="col-sm-4 col-form-label">Razon social</label>
                            <div class="col-sm-8">
                                <asp:TextBox ID="txtbRazonSocial" runat="server" type="text" class="form-control" name="RazonSocial" placeholder="Nombre de la empresa" MaxLength="50" TextMode="SingleLine" AutoCompleteType="Disabled"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group row">
                            <label for="DireccionFiscal" class="col-sm-4 col-form-label">Direccion fiscal</label>
                            <div class="col-sm-8">
                                <asp:TextBox ID="txtbDireccionFiscal" runat="server" type="text" class="form-control" name="DireccionFiscal" placeholder="Direccion fiscal de la empresa" MaxLength="100" TextMode="SingleLine" AutoCompleteType="Disabled"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group row">
                            <label for="DireccionUbicacion" class="col-sm-4 col-form-label">Ubicacion fisica</label>
                            <div class="col-sm-8">
                                <asp:TextBox ID="txtbDireccionUbicacion" runat="server" type="text" class="form-control" name="DireccionUbicacion" placeholder="Direccion ubicacion de la empresa" MaxLength="100" TextMode="SingleLine" AutoCompleteType="Disabled"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group row">
                            <label for="Rfc" class="col-sm-4 col-form-label">RFC</label>
                            <div class="col-sm-8">
                                <asp:TextBox ID="txtbRfc" runat="server" type="text" class="form-control" name="Rfc" placeholder="RFC de la empresa" MaxLength="13" TextMode="SingleLine"></asp:TextBox>
                            </div>
                        </div>
                    </div>

                    <div class="col-sm-5" style="background-color: white;">

                        <div class="form-group row">
                            <label for="NombreContacto" class="col-sm-4 col-form-label">Contacto</label>
                            <div class="col-sm-8">
                                <asp:TextBox ID="txtbNombreContacto" runat="server" type="text" class="form-control" name="NombreContacto" placeholder="Nombre de contacto" MaxLength="50" TextMode="SingleLine" AutoCompleteType="Disabled"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group row">
                            <label for="Telefono" class="col-sm-4 col-form-label">Telefono</label>
                            <div class="col-sm-8">
                                <asp:TextBox ID="txtbTelefono" runat="server" type="text" class="form-control" name="Telefono" placeholder="Telefono de contacto" MaxLength="15" TextMode="Phone" AutoCompleteType="Disabled"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group row">
                            <label for="Correo" class="col-sm-4 col-form-label">Correo</label>
                            <div class="col-sm-8">
                                <asp:TextBox ID="txtbCorreo" runat="server" type="text" class="form-control" name="Correo" placeholder="Correo del contacto" MaxLength="50" TextMode="Email" AutoCompleteType="Disabled"></asp:TextBox>
                            </div>
                        </div>

                        <div style="background-color: white;">
                            <div class="form-group row">
                                <asp:Button ID="btnInsertar" runat="server" Text="" class="btn btn-success" center-align="true" OnClick="btnInsertar_Click" />
                            </div>
                        </div>

                    </div>
                </div>
            </form>
        </div>
        <br />
        <div class="row">
            <div class="col-sm-5">
                <div class="form-group row">
                    <div class="col-sm-8">
                        <asp:TextBox ID="txtbBusqueda" runat="server" type="text" class="form-control" name="buscar" placeholder="Busqueda por Razon Social o RFC" MaxLength="50" TextMode="SingleLine" AutoCompleteType="Disabled"></asp:TextBox>
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
                <asp:GridView ID="GridView_Proveedores" runat="server"
                    AutoGenerateColumns="False"
                    CssClass="table table-bordered bs-table"
                    DataKeyNames="Id"
                    AllowPaging="true" OnRowCommand="GridView_Proveedores_RowCommand" OnPageIndexChanging="GridView_Proveedores_PageIndexChanging">

                    <Columns>

                        <%--campos no editables...--%>
                        <asp:BoundField DataField="Id" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="id" visible="true"/>
                        <asp:BoundField DataField="RazonSocial" HeaderText="Razon Social" InsertVisible="False" ReadOnly="True" SortExpression="RazonSocial" />
                        <asp:BoundField DataField="DireccionFiscal" HeaderText="Direccion Fiscal" ReadOnly="True" SortExpression="DireccionFiscal" />
                        <asp:BoundField DataField="DireccionUbicacion" HeaderText="Direccion ubicacion" ReadOnly="True" SortExpression="DireccionUbicacion" />
                        <asp:BoundField DataField="Rfc" HeaderText="RFC" ReadOnly="True" SortExpression="Rfc" />
                        <asp:BoundField DataField="NombreContacto" HeaderText="Nombre contacto" ReadOnly="True" SortExpression="NombreContacto" />
                        <asp:BoundField DataField="Telefono" HeaderText="Telefono" ReadOnly="True" SortExpression="Telefono" />
                        <asp:BoundField DataField="Correo" HeaderText="Correo" ReadOnly="True" SortExpression="Correo" />
                        
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

</asp:Content>
