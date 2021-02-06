<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="PRYDonacion.Registro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style3 {
            width: 255px;
        }
        .auto-style4 {
            width: 923px;
        }
        .auto-style5 {
            width: 923px;
            text-align: center;
            font-size: large;
        }
    .auto-style6 {
        width: 184px;
    }
    .auto-style7 {
        width: 487px;
    }
    .auto-style8 {
        width: 487px;
        height: 49px;
    }
    .auto-style9 {
        width: 184px;
        height: 49px;
    }
    .auto-style10 {
        height: 49px;
    }
    .auto-style11 {
        width: 487px;
        height: 37px;
    }
    .auto-style12 {
        width: 184px;
        height: 37px;
    }
    .auto-style13 {
        height: 37px;
        width: 684px;
    }
    .auto-style14 {
        width: 487px;
        height: 42px;
    }
    .auto-style15 {
        width: 184px;
        height: 42px;
    }
    .auto-style16 {
        height: 42px;
    }
    .auto-style17 {
        width: 487px;
        height: 43px;
    }
    .auto-style18 {
        width: 184px;
        height: 43px;
    }
    .auto-style19 {
        height: 43px;
    }
    .auto-style20 {
        width: 684px;
    }
    .auto-style21 {
        height: 49px;
        width: 684px;
    }
    .auto-style22 {
        height: 42px;
        width: 684px;
    }
    .auto-style23 {
        height: 43px;
        width: 684px;
    }
    .auto-style24 {
        width: 380px;
    }
    .auto-style25 {
        width: 493px;
    }
    .auto-style26 {
        font-weight: bold;
    }
        .auto-style27 {
            width: 107px;
            height: 97px;
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
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style4">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <img alt="" class="auto-style27" src="Imagenes/Registro.jpg" /></td>
            <td class="auto-style5"><strong>Registro Datos Usuario</strong></td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style4">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>

    <table style="width: 100%;">
        <tr>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style20">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style8"></td>
            <td class="auto-style9">Cedula:</td>
            <td class="auto-style21">
                <asp:TextBox ID="txtCedula" runat="server" Height="27px" Width="337px"></asp:TextBox>
            </td>
            <td class="auto-style10"></td>
        </tr>
        <tr>
            <td class="auto-style11"></td>
            <td class="auto-style12">Nombres:</td>
            <td class="auto-style13">
                <asp:TextBox ID="txtNombres" runat="server" Height="28px" Width="340px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style14"></td>
            <td class="auto-style15">Apellidos:</td>
            <td class="auto-style22">
                <asp:TextBox ID="txtApellidos" runat="server" Height="25px" Width="340px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style17"></td>
            <td class="auto-style18">Correo:</td>
            <td class="auto-style23">
                <asp:TextBox ID="txtCorreo" runat="server" Height="28px" Width="338px"></asp:TextBox>
            </td>
            <td class="auto-style19"></td>
        </tr>
        <tr>
            <td class="auto-style14">&nbsp;</td>
            <td class="auto-style15">Telefono:</td>
            <td class="auto-style22">
                <asp:TextBox ID="txtTelefono" runat="server" Height="26px" Width="336px"></asp:TextBox>
            </td>
            <td class="auto-style16">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style14"></td>
            <td class="auto-style15">Pass:</td>
            <td class="auto-style22">
                <asp:TextBox ID="txtPass" runat="server" Height="26px" Width="339px" TextMode="Password"></asp:TextBox>
            </td>
            <td class="auto-style16"></td>
        </tr>
        <tr>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style20">&nbsp;</td>
        </tr>
    </table>
    <table style="width: 100%;">
        <tr>
            <td class="auto-style25">&nbsp;</td>
            <td class="auto-style24">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style25">&nbsp;</td>
            <td class="auto-style24"><strong>
                <asp:Button ID="btnRegistrar" runat="server" CssClass="auto-style26" Height="35px" Text="Registrar" Width="116px" OnClick="btnRegistrar_Click1" />
                </strong></td>
            <td>
                <asp:Label ID="lbEstadoTipo" runat="server"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style25">&nbsp;</td>
            <td class="auto-style24">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>

</asp:Content>
