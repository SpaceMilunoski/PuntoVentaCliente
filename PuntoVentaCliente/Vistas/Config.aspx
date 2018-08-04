<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/Site.Master" AutoEventWireup="true" CodeBehind="Config.aspx.cs" Inherits="PuntoVentaCliente.Vistas.Config" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <br />
    <div class="white">

        <h1>Actualizar</h1>
        <br />

        <div class="form-group"> <!-- username -->
            <label for="username" class="control-label">Nuevo nombre de usuario</label>
            <asp:TextBox ID="txtbUserName" runat="server" type="text" class="form-control" name="username" placeholder="Nombre para inicio de sesion" MaxLength="10"></asp:TextBox>
        </div>   

        <div class="form-group"> <!-- password -->
            <label for="password" class="control-label">Contraseña actual</label>
            <asp:TextBox ID="txtbPassword" runat="server" type="text" class="form-control" name="password" placeholder="Maximo 8 caracteres" MaxLength="8" TextMode="Password"></asp:TextBox>
        </div>  

        <div class="form-group"> <!-- new password -->
            <label for="new_password" class="control-label">Nueva contraseña</label>
            <asp:TextBox ID="txtbNewPassword" runat="server" type="text" class="form-control" name="new_password" placeholder="Maximo 8 caracteres" MaxLength="8" TextMode="Password"></asp:TextBox>
        </div>  

        <div class="form-group"> <!-- new password repeat -->
            <label for="password_Repeat" class="control-label">Repita la contraseña</label>
            <asp:TextBox ID="txtbNewPasswordRepeat" runat="server" type="text" class="form-control" name="password_Repeat" placeholder="Maximo 8 caracteres" MaxLength="8" TextMode="Password"></asp:TextBox>
        </div>    

        <br />

         <div class="form-group"> <!-- Button -->
            <asp:Button ID="btnActualizar" runat="server" Text="Actualizar" class="btn btn-primary" OnClick="btnInsertar_Click"/>
        </div>
        
    </div>

</asp:Content>
