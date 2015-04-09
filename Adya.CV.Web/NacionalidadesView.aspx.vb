Imports Adya.CV.Modelo.HojadeVidaFacade
Imports Adya.CV.Modelo

Public Class NacionalidadesView
  Inherits System.Web.UI.Page

  Public Enum EnumModoPagina
    Insert
    Edit
  End Enum

  Public Property ModoPaginaNacionalidades As EnumModoPagina
    Get
      Return ViewState("ModoPaginaNacionalidades")
    End Get
    Set(ByVal value As EnumModoPagina)
      ViewState("ModoPaginaNacionalidades") = value
    End Set
  End Property

  Dim NacionalidadFacade As New Facades

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
        sds_Nacionalidades.SelectParameters.Clear()
        sds_Nacionalidades.SelectParameters.Add("campo", ddl_buscar.SelectedValue)
        sds_Nacionalidades.SelectParameters.Add("texto", txt_bucar.Text)
        Master.mensajes = Nothing
      Catch ex As Exception
        Master.mensajes = "danger;" & ex.Message
      End Try
    End If
  End Sub

  Protected Sub Agregar(sender As Object, e As EventArgs) Handles lkb_agregar.Click
    ModoPaginaNacionalidades = EnumModoPagina.Insert
    MostrarFormulario()
    LimpiarNacionalidad()
  End Sub

  Protected Sub Editar(sender As Object, e As EventArgs) Handles grd_Nacionalidades.SelectedIndexChanged
    ModoPaginaNacionalidades = EnumModoPagina.Edit
    MostrarFormulario()
    LimpiarNacionalidad()
    hdf_id.Value = grd_Nacionalidades.SelectedValue
    ObtenerNacionalidad()
  End Sub

  Protected Sub Guardar(sender As Object, e As EventArgs) Handles lkb_guardar.Click
    Try
      Dim Nacionalidad = AsignarNacionalidad()
      If ModoPaginaNacionalidades = EnumModoPagina.Insert Then
        NacionalidadFacade.GuardarNacionalidad(Nacionalidad)
        Master.mensajes = "success;Nacionalidad creada con exito"
        OcultarBusqueda()
      Else
        NacionalidadFacade.ActualizarNacionalidad(Nacionalidad)
        Master.mensajes = "success;Nacionalidad modificada con exito"
      End If
      MostrarLista()
    Catch ex As Exception
      Master.mensajes = "danger;" & ex.Message
    End Try
  End Sub

  Protected Sub Eliminar(sender As Object, e As EventArgs) Handles lkb_eliminar.Click
    Try
      NacionalidadFacade.EliminarNacionalidad(hdf_id.Value)
      Master.mensajes = "success;Nacionalidad eliminada con exito"
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
    grd_Nacionalidades.DataBind()
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

  Public Sub ObtenerNacionalidad()
    Dim Nacionalidad = NacionalidadFacade.ConsultarNacionalidadxId(hdf_id.Value)
    txt_nombres.Text = Nacionalidad.Nombre
  End Sub

  Public Function AsignarNacionalidad() As Nacionalidades
    Dim Nacionalidad As New Nacionalidades
    Try
      Nacionalidad.NacionalidadId = hdf_id.Value
    Catch ex As Exception

    End Try

    If txt_nombres.Text = "" Then
      Throw New Exception("Por favor ingrese un nombre")
    Else
      Nacionalidad.Nombre = txt_nombres.Text
    End If
    Return Nacionalidad
  End Function

  Public Sub LimpiarNacionalidad()
    hdf_id.Value = Nothing
    txt_nombres.Text = Nothing
    Master.mensajes = Nothing
    txt_nombres.Focus()
  End Sub

End Class