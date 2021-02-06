<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="Donacion.aspx.cs" Inherits="PRYDonacion.Donacion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style5 {
            width: 296px;
        }
        .auto-style6 {
            width: 392px;
        }
        .auto-style7 {
            width: 416px;
        }
        .auto-style8 {
            width: 201px;
        }
        .auto-style9 {
            width: 410px;
            height: 48px;
        }
        .auto-style10 {
            width: 201px;
            height: 48px;
        }
        .auto-style11 {
            width: 296px;
            height: 48px;
        }
        .auto-style12 {
            height: 48px;
        }
        .auto-style13 {
            width: 410px;
            height: 42px;
        }
        .auto-style14 {
            width: 201px;
            height: 42px;
        }
        .auto-style15 {
            width: 296px;
            height: 42px;
        }
        .auto-style16 {
            height: 42px;
        }
        .auto-style17 {
            width: 410px;
            height: 43px;
        }
        .auto-style18 {
            width: 201px;
            height: 43px;
        }
        .auto-style19 {
            width: 296px;
            height: 43px;
        }
        .auto-style20 {
            height: 43px;
        }
        .auto-style21 {
            width: 389px;
        }
        .auto-style22 {
            width: 413px;
        }
        .auto-style24 {
            width: 641px;
        }
        .auto-style25 {
            width: 641px;
            font-size: large;
            text-align: center;
        }
        .auto-style26 {
            font-size: large;
        }
        .auto-style27 {
            width: 410px;
        }
        .auto-style28 {
            width: 164px;
            height: 100px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width: 100%;">
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
    <table style="width: 100%;">
        <tr>
            <td class="auto-style21">&nbsp;</td>
            <td class="auto-style24">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style21"><span class="auto-style26">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>
                <img alt="" class="auto-style28" src="Imagenes/registroDonacion.png" /></td>
            <td class="auto-style25"><strong>Registro Donación</strong></td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style21">&nbsp;</td>
            <td class="auto-style24">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
    <table style="width: 100%;">
        <tr>
            <td class="auto-style27">&nbsp;</td>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style9"></td>
            <td class="auto-style10">
                Descripción:</td>
            <td class="auto-style11">
                <asp:TextBox ID="txtDescripcionDonacion" runat="server" Height="28px" Width="273px"></asp:TextBox>
            </td>
            <td class="auto-style12"></td>
        </tr>
        <tr>
            <td class="auto-style13"></td>
            <td class="auto-style14">Cantidad:</td>
            <td class="auto-style15">
                <asp:TextBox ID="txtCantidad" runat="server" Height="28px" Width="272px"></asp:TextBox>
            </td>
            <td class="auto-style16"></td>
        </tr>
        <tr>
            <td class="auto-style17"></td>
            <td class="auto-style18">Monto:</td>
            <td class="auto-style19">
                <asp:TextBox ID="txtMonto" runat="server" Height="28px" Width="269px"></asp:TextBox>
            </td>
            <td class="auto-style20"></td>
        </tr>
        <tr>
            <td class="auto-style27">&nbsp;</td>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
    <table style="width: 100%;">
        <tr>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style6">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style6">
                <asp:DropDownList ID="cbListaTipoDonacion" runat="server" Height="25px" Width="172px">
                </asp:DropDownList>
            </td>
            <td>
                <asp:Label ID="lbErroRol" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style6">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
    <table style="width: 100%;">
        <tr>
            <td class="auto-style22">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style22">&nbsp;</td>
            <td>
                <asp:Button ID="btnRegistrar" runat="server" Height="35px" OnClick="btnRegistrar_Click" Text="Registrar" Width="131px" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style22">&nbsp;</td>
            <td>
                <asp:Label ID="lblRegistro" runat="server"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
