<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="Command_Prototype.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:HiddenField ID="hfId" runat="server" />
    <asp:HiddenField ID="hfModo" runat="server" />

    <asp:TextBox ID="txtId" runat="server" Visible="true"></asp:TextBox>

    <asp:Label ID="lblMarca" runat="server" Text="Marca"></asp:Label>
    <asp:TextBox ID="txtMarca" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="rfvMarca" runat="server" ControlToValidate="txtMarca" ErrorMessage="Campo marca está vació" Display="Dynamic" ForeColor="Red" ValidationGroup="AgregarComputadora" />

    <br />
    <asp:Label ID="lblModelo" runat="server" Text="Modelo"></asp:Label>
    <asp:TextBox ID="txtModelo" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="rfvModelo" runat="server" ControlToValidate="txtModelo" ErrorMessage="Campo Modelo está vació" Display="Dynamic" ForeColor="Red" ValidationGroup="AgregarComputadora" />

    <br />
    <asp:Label ID="lblProcesador" runat="server" Text="Procesador"></asp:Label>
    <asp:TextBox ID="txtProcesador" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="rfvProcesador" runat="server" ControlToValidate="txtProcesador" ErrorMessage="Campo Procesador está vació" Display="Dynamic" ForeColor="Red" ValidationGroup="AgregarComputadora" />

    <br />
    <asp:Label ID="lblMemoriaRam" runat="server" Text="Memoria RAM"></asp:Label>
    <asp:TextBox ID="txtMemoriaRam" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="rfvMemoriaRam" runat="server" ControlToValidate="txtMemoriaRam" ErrorMessage="Campo Memoria RAM está vació" Display="Dynamic" ForeColor="Red" ValidationGroup="AgregarComputadora" />
    <asp:RangeValidator ID="rvMemoriaRam" runat="server" ControlToValidate="txtMemoriaRam" ErrorMessage="Solo se aceptan números enteros de 1 a 32768" Display="Dynamic" ForeColor="Red" MinimumValue="1" MaximumValue="32768" Type="Integer" ValidationGroup="AgregarComputadora" />

    <br />
    <asp:Label ID="lblAlmacenamiento" runat="server" Text="Almacenamiento"></asp:Label>
    <asp:TextBox ID="txtAlmacenamiento" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="rfvAlmacenamiento" runat="server" ControlToValidate="txtAlmacenamiento" ErrorMessage="Campo Almacenamiento está vació" Display="Dynamic" ForeColor="Red" ValidationGroup="AgregarComputadora" />
    <asp:RangeValidator ID="rvAlmacenamiento" runat="server" ControlToValidate="txtAlmacenamiento" ErrorMessage="Solo se aceptan números enteros de 1 a 1000000" Display="Dynamic" ForeColor="Red" MinimumValue="1" MaximumValue="1000000" Type="Integer" ValidationGroup="AgregarComputadora" />

    <br />
    <asp:Label ID="lblSistemaOperativo" runat="server" Text="Sistema Operativo"></asp:Label>
    <asp:TextBox ID="txtSistemaOperativo" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="rfvSistemaOperativo" runat="server" ControlToValidate="txtSistemaOperativo" ErrorMessage="Campo Sistema Operativo está vació" Display="Dynamic" ForeColor="Red" ValidationGroup="AgregarComputadora" />


    <br />
    <asp:Panel ID="Panel1" runat="server">
        <h2 style="text-align: center">Alta y Baja de Stock Computadoras</h2>
        <br />
        <div style="text-align: center">
            <asp:Label runat="server" Text="Ingrese la cantidad de Computadoras que existen:" Font-Size="Medium"></asp:Label><br />
            <asp:TextBox ID="txtCantidadProducto" runat="server" ToolTip="Representa la cantidad del producto"></asp:TextBox>

        </div>
        <br />
        <div style="text-align: center">
            <asp:Label runat="server" Text="Ingrese la cantidad de Computadoras para dar de Alta:" Font-Size="Medium"></asp:Label><br />
            <asp:TextBox ID="txtAlta" runat="server" ToolTip="Representa la cantidad del producto"></asp:TextBox>

        </div>
        <br />

        <div style="text-align: center">
            <asp:Label runat="server" Text="Ingrese la cantidad de Computadoras para dar de Baja:" Font-Size="Medium"></asp:Label><br />
            <asp:TextBox ID="txtBaja" runat="server" ToolTip="Representa la cantidad del producto"></asp:TextBox>

        </div>
        <br />


        <div style="text-align: center">
            <asp:Button runat="server" Text="Insertar" OnClick="Hecho_Click" Width="150px" />&nbsp;&nbsp;&nbsp;
       
        </div>
        <div style="text-align: center">
            <asp:Button runat="server" Text="Actualizar" OnClick="Actualizar_Click" Width="150px" />&nbsp;&nbsp;&nbsp;
       
        </div>
        <br />
        <br />
        <h3 runat="server" id="h1Resultado" style="text-align: center">Resultado de la operación      
    
        </h3>
        <br />
        <div style="text-align: center">
            <asp:Label ID="lblAltaStock" runat="server" Font-Size="Small"></asp:Label>
            <br />
            <asp:Label ID="lblBajaStok" runat="server" Font-Size="Small"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lblResultado" runat="server" Font-Size="Medium"></asp:Label>
        </div>
        <br />
    </asp:Panel>
</asp:Content>
