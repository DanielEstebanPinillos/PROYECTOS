<%@ Page Title="CV - Nacionalidades" Language="vb" AutoEventWireup="false" MasterPageFile="~/_Plantilla.Master" CodeBehind="NacionalidadesView.aspx.vb" Inherits="Adya.CV.Web.NacionalidadesView" %>
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
          <td class="quince"></td>
          <td class="dos"></td>
          <td class="quince alinear_der">
            <asp:Label ID="lbl_nombres" runat="server" Text="Nacionalidad"></asp:Label>
          </td>
          <td class="veinticuatro">
            <asp:TextBox ID="txt_nombres" class="form-control" runat="server" ></asp:TextBox>
          </td>
          <td class="dos">
            &nbsp;</td>
          <td class="veinticuatro"></td>
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
              <asp:ListItem Value="1">Nacionalidad</asp:ListItem>
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
    <asp:GridView ID="grd_Nacionalidades" runat="server" AutoGenerateColumns="False" DataKeyNames="NacionalidadId" DataSourceID="sds_Nacionalidades" CssClass="table table-bordered" CellPadding="4" ForeColor="#333333" GridLines="None" AllowPaging="True" AllowSorting="True">
      <AlternatingRowStyle BackColor="White" />
      <Columns>
        <asp:CommandField ShowSelectButton="True" ControlStyle-CssClass="fa fa-pencil" ItemStyle-HorizontalAlign="Center" SelectText="">
          <ControlStyle CssClass="fa fa-pencil link_button_select" />
        </asp:CommandField>
        <asp:BoundField DataField="NacionalidadId" HeaderText="NacionalidadId" InsertVisible="False" ReadOnly="True" SortExpression="NacionalidadId" Visible="False" />
        <asp:BoundField DataField="Nombre" HeaderText="Nacionalidad" SortExpression="Nombre" />
      </Columns>
      <HeaderStyle ForeColor="White" BackColor="#005490" />
    </asp:GridView>
    <asp:SqlDataSource ID="sds_Nacionalidades" runat="server" ConnectionString="<%$ ConnectionStrings:CVConnectionString %>" SelectCommand="NacionalidadesListar" SelectCommandType="StoredProcedure">
      <SelectParameters>
        <asp:Parameter DefaultValue=" " Name="campo" Type="String" />
        <asp:Parameter DefaultValue="  " Name="texto" Type="String" />
      </SelectParameters>
    </asp:SqlDataSource>
  </asp:Panel>

  <asp:HiddenField ID="hdf_id" runat="server" />

  <script type="text/javascript">
    $(document).ready(function () {
      $("#mainNav li").removeAttr("class");
      $("#mainNav li").attr("class scroll-link");
      $("#li_nacionalidades").attr("class", "active");
    });

  </script>

</asp:Content>

