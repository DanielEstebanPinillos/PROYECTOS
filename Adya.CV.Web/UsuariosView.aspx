<%@ Page Title="CV - Usuarios" Language="vb" AutoEventWireup="false" MasterPageFile="~/_Plantilla.Master" CodeBehind="UsuariosView.aspx.vb" Inherits="Adya.CV.Web.UsuariosView" %>
<%@ MasterType VirtualPath="~/_Plantilla.Master" %>
<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="cph_botones" runat="server">
  <asp:LinkButton CssClass="link_button" ID="lkb_buscar" runat="server" ToolTip="Buscar"><span class="fa fa-search"></span></asp:LinkButton>
  <asp:LinkButton CssClass="link_button" ID="lkb_agregar" runat="server" ToolTip="Agregar"><span class="fa fa-plus"></span></asp:LinkButton>
  <asp:LinkButton CssClass="link_button" ID="lkb_guardar" runat="server" ToolTip="Guardar"><span class="fa fa-floppy-o"></span></asp:LinkButton>
  <asp:LinkButton CssClass="link_button" ID="lkb_eliminar" runat="server" ToolTip="Eliminar"><span class="fa fa-trash-o"></span></asp:LinkButton>
  <asp:LinkButton CssClass="link_button" ID="lkb_salir" runat="server" ToolTip="Volver"><span class="fa fa-sign-out"></span></asp:LinkButton>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="cph_contenido" runat="server">
  <asp:Panel ID="pnl_form" runat="server">
    <table class="nav-justified">
      <tr>
        <td class="quince alinear_der">
          <asp:Label ID="lbl_nombres" runat="server" Text="Nombres"></asp:Label>
        </td>
        <td class="veinticuatro">
          <asp:TextBox ID="txt_nombres" class="form-control" runat="server"></asp:TextBox>
        </td>
        <td class="dos">&nbsp;</td>
        <td class="veinticuatro alinear_der">
          <asp:Label ID="lbl_apellidos" runat="server" Text="Apellidos"></asp:Label>
        </td>
        <td class="veinticuatro">
          <asp:TextBox ID="txt_apellidos" runat="server" class="form-control"></asp:TextBox>
        </td>
        <td class="dos">&nbsp;</td>
        <td class="nueve">&nbsp;</td>
      </tr>
      <tr>
        <td class="alinear_der">
          <asp:Label ID="lbl_usuario" runat="server" Text="Usuario"></asp:Label>
        </td>
        <td>
          <asp:TextBox ID="txt_usuario" runat="server" class="form-control"></asp:TextBox>
        </td>
        <td>&nbsp;</td>
        <td class="alinear_der">
          <asp:Label ID="lbl_admin" runat="server" Text="Administrador"></asp:Label>
        </td>
        <td>
          <asp:RadioButtonList ID="rbl_administrador" runat="server" RepeatDirection="Horizontal">
            <asp:ListItem Value="True">Si</asp:ListItem>
            <asp:ListItem Value="False">No</asp:ListItem>
          </asp:RadioButtonList>
        </td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
      </tr>
      <tr>
        <td class="alinear_der">
          <asp:Label ID="lbl_clave" runat="server" Text="Contraseña"></asp:Label>
        </td>
        <td>
          <asp:TextBox ID="txt_clave" runat="server" class="form-control" type="password"></asp:TextBox>
        </td>
        <td>&nbsp;</td>
        <td class="alinear_der">
          <asp:Label ID="lbl_confirmaclave" runat="server" Text="Confirmar Contraseña"></asp:Label>
        </td>
        <td>
          <asp:TextBox ID="txt_confirmaclave" runat="server" class="form-control" type="password"></asp:TextBox>
        </td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
      </tr>
    </table>
    <br />
    <asp:Panel ID="pnl_menus" runat="server">
      <br />
      <table class="nav-justified">
        <tr>
          <td class="veinte"></td>
          <td class="veinte"><strong>HOJAS DE VIDA</strong> </td>
          <td class="veinte">
            <strong>INVENTARIOS</strong>
          </td>
          <td class="veinte">
            <strong>SEGURIDAD</strong>
          </td>
          <td class="veinte">&nbsp;</td>
        </tr>
        <tr>
          <td>
            &nbsp;</td>
          <td>
            <asp:CheckBox ID="li_hojadevidas" runat="server" Text="Hoja de Vida" />
          </td>
          <td>
            <asp:CheckBox ID="li_inventarios" runat="server" Text="Inventarios" />
          </td>
          <td>
            <asp:CheckBox ID="li_usuarios" runat="server" Text="Usuarios" />
          </td>
          <td>&nbsp;</td>
        </tr>
        <tr>
          <td>
            &nbsp;</td>
          <td>
            <asp:CheckBox ID="li_actividades" runat="server" Text="Actividades" />
          </td>
          <td>
            <asp:CheckBox ID="li_ingresos" runat="server" Text="Ingresos" />
          </td>
          <td>&nbsp;</td>
          <td>&nbsp;</td>
        </tr>
        <tr>
          <td>
            &nbsp;</td>
          <td>
            <asp:CheckBox ID="li_areas" runat="server" SkinID="li_areas" Text="Areas" />
          </td>
          <td>
            <asp:CheckBox ID="li_empleados" runat="server" Text="Empleados" />
          </td>
          <td>&nbsp;</td>
          <td>&nbsp;</td>
        </tr>
        <tr>
          <td>
            &nbsp;</td>
          <td>
            <asp:CheckBox ID="li_cargos" runat="server" Text="Cargos" />
          </td>
          <td>
            <asp:CheckBox ID="li_proveedores" runat="server" Text="Proveedores" />
          </td>
          <td>&nbsp;</td>
          <td>&nbsp;</td>
        </tr>
        <tr>
          <td>
            &nbsp;</td>
          <td>
            <asp:CheckBox ID="li_ciudades" runat="server" Text="Ciudades" />
          </td>
          <td>
            <asp:CheckBox ID="li_tallas" runat="server" Text="Tallas" />
          </td>
          <td>&nbsp;</td>
          <td>&nbsp;</td>
        </tr>
        <tr>
          <td>
            &nbsp;</td>
          <td>
            <asp:CheckBox ID="li_nacionalidades" runat="server" Text="Nacionalidades" />
          </td>
          <td>
            &nbsp;</td>
          <td>&nbsp;</td>
          <td>&nbsp;</td>
        </tr>
        <tr>
          <td>
            &nbsp;</td>
          <td>
            <asp:CheckBox ID="li_profesiones" runat="server" Text="Profesiones" />
          </td>
          <td>
            &nbsp;</td>
          <td>&nbsp;</td>
          <td>&nbsp;</td>
        </tr>
      </table>
    </asp:Panel>
  </asp:Panel>
  

  <asp:Panel ID="pnl_list" runat="server">
    <asp:Panel ID="pnl_buscar" runat="server">
      <table class="cien">
        <tr>
          <td class="veinte"></td>
          <td class="veinte" align="center">
            <asp:DropDownList ID="ddl_buscar" runat="server" CssClass="dropdown btn btn-default dropdown-toggle text-center ochenta">
              <asp:ListItem Value="0">Buscar por</asp:ListItem>
              <asp:ListItem Value="1">Usuario</asp:ListItem>
              <asp:ListItem Value="2">Nombre</asp:ListItem>
              <asp:ListItem Value="3">Apellido</asp:ListItem>
            </asp:DropDownList>
          </td>
          <td class="veinte">
            <asp:TextBox ID="txt_bucar" class="form-control" runat="server"></asp:TextBox>
          </td>
          <td class="veinte" align="center">
            <button type="button" id="btn_filtrar" class="btn btn-default ochenta" runat="server">Filtrar</button>

          </td>
          <td class="veinte"></td>
        </tr>
      </table>
      <br />
    </asp:Panel>
    <asp:GridView ID="grd_usuarios" runat="server" AutoGenerateColumns="False" DataKeyNames="UsuarioId" DataSourceID="sds_usuarios" CssClass="table table-bordered" CellPadding="4" ForeColor="#333333" GridLines="None" AllowPaging="True" AllowSorting="True">
      <AlternatingRowStyle BackColor="White" />
      <Columns>
        <asp:CommandField ShowSelectButton="True" ControlStyle-CssClass="fa fa-pencil" ItemStyle-HorizontalAlign="Center" SelectText="" >
          <ControlStyle CssClass="fa fa-pencil link_button_select" />
        </asp:CommandField>
        <asp:BoundField DataField="UsuarioId" HeaderText="UsuarioId" InsertVisible="False" ReadOnly="True" SortExpression="UsuarioId" Visible="False" />
        <asp:BoundField DataField="Usuario" HeaderText="Usuario" SortExpression="Usuario" />
        <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
        <asp:BoundField DataField="Apellido" HeaderText="Apellido" SortExpression="Apellido" />
        <asp:CheckBoxField DataField="Administrador" HeaderText="Administrador" SortExpression="Administrador" />
      </Columns>
      <HeaderStyle ForeColor="White" BackColor="#005490" />
    </asp:GridView>
    <asp:SqlDataSource ID="sds_usuarios" runat="server" ConnectionString="<%$ ConnectionStrings:CVConnectionString %>" SelectCommand="UsuariosListar" SelectCommandType="StoredProcedure">
      <SelectParameters>
        <asp:Parameter DefaultValue=" " Name="campo" Type="String" />
        <asp:Parameter DefaultValue=" " Name="texto" Type="String" />
      </SelectParameters>
    </asp:SqlDataSource>
  </asp:Panel>

  <asp:HiddenField ID="hdf_id" runat="server" />

  <script type="text/javascript">
    $(document).ready(function () {
      $("#mainNav li").removeAttr("class");
      $("#mainNav li").attr("class scroll-link");
      $("#li_usuarios").attr("class", "active");
    });

  </script>

</asp:Content>

