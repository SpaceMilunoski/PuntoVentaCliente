<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/Site.Master" AutoEventWireup="true" CodeBehind="Empleados.aspx.cs" Inherits="PuntoVentaCliente.Vistas.Modulos.Empleados" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

        <div class="container">
        <h1>Empleados</h1>
        <br />
        <div class="row">
            <form>
                <div class="form-group">

                    <!-- Empleados -->

                    <div class="col-sm-5" style="background-color: white;">
                        
                        <asp:TextBox ID="txtbId_Empleado" runat="server" type="text" class="form-control" name="Id" MaxLength="11" TextMode="SingleLine" visible="false"></asp:TextBox>

                        <div class="form-group row">
                            <label for="Nombre" class="col-sm-4 col-form-label">Nombre *</label>
                            <div class="col-sm-8">
                                <asp:TextBox ID="txtbNombre" runat="server" type="text" class="form-control" name="Nombre" placeholder="Introduzca el(los) nombre(s)" MaxLength="25" TextMode="SingleLine" AutoCompleteType="Disabled"></asp:TextBox>
                            </div>
                        </div>

                        <div class="form-group row">
                            <label for="Apellido" class="col-sm-4 col-form-label">Apellido *</label>
                            <div class="col-sm-8">
                                <asp:TextBox ID="txtbApellido" runat="server" type="text" class="form-control" name="Apellido" placeholder="Introduzca el(los) apellido(s)" MaxLength="25" TextMode="SingleLine" AutoCompleteType="Disabled"></asp:TextBox>
                            </div>
                        </div>

                        <div class="form-group row">
                            <label for="Telefono" class="col-sm-4 col-form-label">Telefono *</label>
                            <div class="col-sm-8">
                                <asp:TextBox ID="txtbTelefono" runat="server" type="text" class="form-control" name="Telefono" placeholder="Numero de celular" MaxLength="15" TextMode="Phone" AutoCompleteType="Disabled"></asp:TextBox>
                            </div>
                        </div>

                        <div class="form-group row">
                            <label for="FechaIngreso" class="col-sm-4 col-form-label">Fecha de ingreso *</label>
                            <div class="col-sm-8">
                                <asp:TextBox ID="txtbFechaIngreso" runat="server" type="text" class="form-control" name="FechaIngreso" TextMode="Date"></asp:TextBox>
                            </div>
                        </div>

                        <div class="form-group row">
                            <label for="Departamentos" class="col-sm-4 col-form-label">Departamento *</label>
                            <div class="col-sm-8">
                                <asp:DropDownList CssClass="form-control" ID="ddlDepartamentos" runat="server"></asp:DropDownList>
                            </div>
                        </div>

                        <div class="form-group row">
                            <label for="Puestos" class="col-sm-4 col-form-label">Puesto *</label>
                            <div class="col-sm-8">
                                <asp:DropDownList CssClass="form-control" ID="ddlPuestos" runat="server"></asp:DropDownList>
                            </div>
                        </div>

                    </div>

                    <!-- Usuario -->

                    <div class="col-sm-5" style="background-color: white;">

                        <asp:TextBox ID="txtId_Usuario" runat="server" type="text" class="form-control" name="Id" MaxLength="11" TextMode="SingleLine" visible="false"></asp:TextBox>

                        <div class="form-group row">
                            <label for="Usuario" class="col-sm-4 col-form-label">Usuario</label>
                            <div class="col-sm-8">
                                <asp:TextBox ID="txtbUsuario" runat="server" type="text" class="form-control" name="Usuario" placeholder="Nombre para inicio de sesion" MaxLength="10" TextMode="SingleLine" AutoCompleteType="Disabled"></asp:TextBox>
                            </div>
                        </div>

                        <div class="form-group row">
                            <label for="Password" class="col-sm-4 col-form-label">Contraseña</label>
                            <div class="col-sm-8">
                                <asp:TextBox ID="txtbPassword" runat="server" class="form-control" name="Password" placeholder="Maximo 8 caracteres" MaxLength="8" TextMode="Password" AutoCompleteType="Disabled"></asp:TextBox>
                            </div>
                        </div>

                        <div class="form-group row">
                            <label for="PasswordRepetir" class="col-sm-4 col-form-label">Repetir contraseña</label>
                            <div class="col-sm-8">
                                <asp:TextBox ID="txtbPasswordRepetir" runat="server" class="form-control" name="Password" placeholder="Maximo 8 caracteres" MaxLength="8" TextMode="Password" AutoCompleteType="Disabled"></asp:TextBox>
                            </div>
                        </div>

                        <div class="form-group row">
                            <label for="Privilegios" class="col-sm-4 col-form-label">Privilegios</label>
                            <div class="col-sm-8">
                                <asp:DropDownList CssClass="form-control" ID="ddlPrivilegios" runat="server">
                                    <asp:ListItem Selected="True" Value="Administrador"> Administrador </asp:ListItem>
                                    <asp:ListItem Value="Empleado"> Empleado </asp:ListItem>
                                </asp:DropDownList>
                            </div>
                        </div>

                        <asp:TextBox ID="txtbEmpleados_Id" runat="server" type="text" class="form-control" name="Id" MaxLength="11" TextMode="SingleLine" visible="false"></asp:TextBox>
                    

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
                        <asp:TextBox ID="txtbBusqueda" runat="server" type="text" class="form-control" name="buscar" placeholder="Busqueda por nombre o apellido" MaxLength="50" TextMode="SingleLine" AutoCompleteType="Disabled"></asp:TextBox>
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
                <asp:GridView ID="GridView_Empleados" runat="server"
                    AutoGenerateColumns="False"
                    CssClass="table table-bordered bs-table"
                    DataKeyNames="Id_Empleado"
                    AllowPaging="True" OnRowCommand="GridView_Empleados_RowCommand" OnPageIndexChanging="GridView_Empleados_PageIndexChanging">

                    <Columns>

                        <%--campos no editables...--%>
                        <asp:BoundField DataField="Id_Empleado" HeaderText="Id_Empleado" ReadOnly="True" SortExpression="Id_Empleado"/>
                        <asp:BoundField DataField="Nombre" HeaderText="Nombre" ReadOnly="True" SortExpression="Nombre" />
                        <asp:BoundField DataField="Apellido" HeaderText="Apellido" ReadOnly="True" SortExpression="Apellido" />
                        <asp:BoundField DataField="Telefono" HeaderText="Telefono" ReadOnly="True" SortExpression="Telefono" />
                        <asp:BoundField DataField="FechaIngreso" HeaderText="Fecha de ingreso" ReadOnly="True" SortExpression="FechaIngreso" DataFormatString="{0:yyyy-MM-dd}" HtmlEncode=false />
                        <asp:BoundField DataField="Departamento" HeaderText="Departamento" ReadOnly="True" SortExpression="Departamento" />
                        <asp:BoundField DataField="Puesto" HeaderText="Puesto" ReadOnly="True" SortExpression="Puesto" />
                        
                        <asp:BoundField DataField="Id_Usuario" HeaderText="Id_Usuario" ReadOnly="True" SortExpression="Id_Usuario"/>
                        <asp:BoundField DataField="Usuario" HeaderText="Usuario" ReadOnly="True" SortExpression="Usuario" />
                        <asp:BoundField DataField="Password" HeaderText="Password" ReadOnly="True" SortExpression="Password" />
                        <asp:BoundField DataField="Privilegios" HeaderText="Privilegios" ReadOnly="True" SortExpression="Privilegios" />
                        <asp:BoundField DataField="Empleados_Id" HeaderText="Empleados_Id" ReadOnly="True" SortExpression="Empleados_Id" />
                        
                        <%--botones de acción sobre los registros...--%>
                        <asp:TemplateField ItemStyle-HorizontalAlign="Center" >
                            <ItemTemplate>
                                <%--Botones de eliminar y editar cliente...--%>
                                <!-- <asp:Button ID="btnDelete" runat="server" Text="Eliminar" CssClass="btn btn-danger" CommandName="Eliminar" OnClientClick="return confirm('¿Eliminar registro?'); " CommandArgument="<%# ((GridViewRow) Container).RowIndex %>" /> -->
                                <asp:Button ID="btnEdit" runat="server" Text="Editar" CssClass="btn btn-info" CommandName="Editar" CommandArgument="<%# ((GridViewRow) Container).RowIndex %>" />
                            </ItemTemplate>

                        </asp:TemplateField>


                    </Columns>
                </asp:GridView>
            </div>

        </div>

    </div>

</asp:Content>
