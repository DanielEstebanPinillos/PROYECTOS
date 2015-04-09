<%@ Page Title="CV - HojadeVidas" Language="vb" AutoEventWireup="false" MasterPageFile="~/_Plantilla.Master" CodeBehind="HojadeVidasView.aspx.vb" Inherits="Adya.CV.Web.HojadeVidasView" %>

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
          <asp:Label ID="lbl_fecha" runat="server" Text="Fecha"></asp:Label>
        </td>
        <td class="veinticuatro">
          <asp:TextBox ID="txt_nombres" class="form-control" runat="server"></asp:TextBox>
        </td>
        <td class="dos">&nbsp;</td>
        <td class="veinticuatro alinear_der">
          <asp:Label ID="lbl_codigo" runat="server" Text="Codigo"></asp:Label>
        </td>
        <td class="veinticuatro">
          <asp:TextBox ID="txt_codigo" runat="server" class="form-control"></asp:TextBox>
        </td>
        <td class="dos">&nbsp;</td>
        <td class="nueve">&nbsp;</td>
      </tr>
      <tr>
        <td class="quince alinear_der">&nbsp;</td>
        <td class="veinticuatro">&nbsp;</td>
        <td class="dos">&nbsp;</td>
        <td class="veinticuatro alinear_der">&nbsp;</td>
        <td class="veinticuatro">&nbsp;</td>
        <td class="dos">&nbsp;</td>
        <td class="nueve">&nbsp;</td>
      </tr>
    </table>
    <br />
  </asp:Panel>

  <asp:Panel ID="pnl_list" runat="server">
    <asp:Panel ID="pnl_buscar" runat="server">
      <table class="cien">
        <tr>
          <td class="veinte"></td>
          <td class="veinte" align="center">
            <asp:DropDownList ID="ddl_buscar" runat="server" CssClass="dropdown btn btn-default dropdown-toggle text-center ochenta">
              <asp:ListItem Value="0">Buscar por</asp:ListItem>
              <asp:ListItem Value="1">Numero de Identificacion</asp:ListItem>
              <asp:ListItem Value="2">Nombre</asp:ListItem>
              <asp:ListItem Value="3">Apellido</asp:ListItem>
              <asp:ListItem Value="4">Telefono</asp:ListItem>
              <asp:ListItem Value="5">Correo</asp:ListItem>
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
    <asp:GridView ID="grd_HojadeVidas" runat="server" AutoGenerateColumns="False" DataKeyNames="HojadeVidaId" DataSourceID="sds_HojadeVidas" CssClass="table table-bordered" CellPadding="4" ForeColor="#333333" GridLines="None" AllowPaging="True" AllowSorting="True">
      <AlternatingRowStyle BackColor="White" />
      <Columns>
        <asp:CommandField ShowSelectButton="True" ControlStyle-CssClass="fa fa-pencil" ItemStyle-HorizontalAlign="Center" SelectText="">
          <ControlStyle CssClass="fa fa-pencil link_button_select" />
        </asp:CommandField>
        <asp:BoundField DataField="HojadeVidaId" HeaderText="HojadeVidaId" InsertVisible="False" ReadOnly="True" SortExpression="HojadeVidaId" Visible="False" />
        <asp:BoundField DataField="NumeroIdentificacion" HeaderText="Numero Identificacion" SortExpression="NumeroIdentificacion" />
        <asp:BoundField DataField="Nombres" HeaderText="Nombres" SortExpression="Nombres" />
        <asp:BoundField DataField="Apellidos" HeaderText="Apellidos" SortExpression="Apellidos" />
        <asp:BoundField DataField="Telefono" HeaderText="Telefono" SortExpression="Telefono" />
        <asp:BoundField DataField="Correo" HeaderText="Correo" SortExpression="Correo" />
      </Columns>
      <HeaderStyle ForeColor="White" BackColor="#005490" />
    </asp:GridView>
    <asp:SqlDataSource ID="sds_HojadeVidas" runat="server" ConnectionString="<%$ ConnectionStrings:CVConnectionString %>" SelectCommand="HojadeVidasListar" SelectCommandType="StoredProcedure">
      <SelectParameters>
        <asp:Parameter DefaultValue="  " Name="campo" Type="String" />
        <asp:Parameter DefaultValue="  " Name="texto" Type="String" />
      </SelectParameters>
    </asp:SqlDataSource>
  </asp:Panel>

  <asp:HiddenField ID="hdf_id" runat="server" />

  <script type="text/javascript">
    $(document).ready(function () {
      $("#mainNav li").removeAttr("class");
      $("#mainNav li").attr("class scroll-link");
      $("#li_HojadeVidas").attr("class", "active");
    });

  </script>

</asp:Content>

