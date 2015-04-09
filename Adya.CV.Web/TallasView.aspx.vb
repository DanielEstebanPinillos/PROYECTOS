Imports Adya.CV.Modelo.HojadeVidaFacade
Imports Adya.CV.Modelo
Imports Adya.CV.Modelo.Facade.InventarioFacade

Public Class TallasView
  Inherits System.Web.UI.Page

  Public Enum EnumModoPagina
    Insert
    Edit
  End Enum

  Public Property ModoPaginaTallas As EnumModoPagina
    Get
      Return ViewState("ModoPaginaTallas")
    End Get
    Set(ByVal value As EnumModoPagina)
      ViewState("ModoPaginaTallas") = value
    End Set
  End Property

  Dim TallaFacade As New InventarioFacade

  Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    If Not Page.IsPostBack Then
      MostrarLista()
      pnl_buscar.Visible = False
    End If
  End Sub

  Protected Sub Buscar(sender As Object, e As EventArgs) Handles lkb_buscar.Click
    pnl_buscar.Visible = True
    Master.mensajes = Nothing
  End Sub

  Protected Sub Filtrar(sender As Object, e As EventArgs) Handles btn_filtrar.ServerClick
    If ddl_buscar.SelectedValue = 0 Then
      Master.mensajes = "warning;Por favor seleccione el campo a buscar"
    ElseIf txt_bucar.Text = "" Then
      Master.mensajes = "warning;Por favor ingrese la informacion a buscar"
    Else
      Try
        sds_Tallas.SelectParameters.Clear()
        sds_Tallas.SelectParameters.Add("campo", ddl_buscar.SelectedValue)
        sds_Tallas.SelectParameters.Add("texto", txt_bucar.Text)
        Master.mensajes = Nothing
      Catch ex As Exception
        Master.mensajes = "danger;" & ex.Message
      End Try
    End If
  End Sub

  Protected Sub Agregar(sender As Object, e As EventArgs) Handles lkb_agregar.Click
    ModoPaginaTallas = EnumModoPagina.Insert
    MostrarFormulario()
    LimpiarTalla()
  End Sub

  Protected Sub Editar(sender As Object, e As EventArgs) Handles grd_Tallas.SelectedIndexChanged
    ModoPaginaTallas = EnumModoPagina.Edit
    MostrarFormulario()
    LimpiarTalla()
    hdf_id.Value = grd_Tallas.SelectedValue
    ObtenerTalla()
  End Sub

  Protected Sub Guardar(sender As Object, e As EventArgs) Handles lkb_guardar.Click
    Try
      Dim Talla = AsignarTalla()
      If ModoPaginaTallas = EnumModoPagina.Insert Then
        TallaFacade.GuardarTalla(Talla)
        Master.mensajes = "success;Talla creada con exito"
        OcultarBusqueda()
      Else
        TallaFacade.ActualizarTalla(Talla)
        Master.mensajes = "success;Talla modificada con exito"
      End If
      MostrarLista()
    Catch ex As Exception
      Master.mensajes = "danger;" & ex.Message
    End Try
  End Sub

  Protected Sub Eliminar(sender As Object, e As EventArgs) Handles lkb_eliminar.Click
    Try
      TallaFacade.EliminarTalla(hdf_id.Value)
      Master.mensajes = "success;Talla eliminada con exito"
      MostrarLista()
    Catch ex As Exception
      Master.mensajes = "danger;" & ex.Message
    End Try
  End Sub

  Protected Sub Salir(sender As Object, e As EventArgs) Handles lkb_salir.Click
    MostrarLista()
    Master.mensajes = Nothing
  End Sub

  Public Sub MostrarLista()
    pnl_form.Visible = False
    pnl_list.Visible = True
    lkb_buscar.Visible = True
    lkb_agregar.Visible = True
    lkb_guardar.Visible = False
    lkb_eliminar.Visible = False
    lkb_salir.Visible = False
    grd_Tallas.DataBind()
  End Sub

  Public Sub MostrarFormulario()
    pnl_form.Visible = True
    pnl_list.Visible = False
    lkb_buscar.Visible = False
    lkb_agregar.Visible = False
    lkb_guardar.Visible = True
    lkb_eliminar.Visible = True
    lkb_salir.Visible = True
  End Sub

  Public Sub OcultarBusqueda()
    pnl_buscar.Visible = False
    ddl_buscar.SelectedValue = 0
    txt_bucar.Text = ""
  End Sub

  Public Sub ObtenerTalla()
    Dim Talla = TallaFacade.ConsultarTallaxId(hdf_id.Value)
    txt_nombres.Text = Talla.Nombre
  End Sub

  Public Function AsignarTalla() As Tallas
    Dim Talla As New Tallas
    Try
      Talla.TallaId = hdf_id.Value
    Catch ex As Exception

    End Try

    If txt_nombres.Text = "" Then
      Throw New Exception("Por favor ingrese un nombre")
    Else
      Talla.Nombre = txt_nombres.Text
    End If
    Return Talla
  End Function

  Public Sub LimpiarTalla()
    hdf_id.Value = Nothing
    txt_nombres.Text = Nothing
    Master.mensajes = Nothing
    txt_nombres.Focus()
  End Sub

End Class