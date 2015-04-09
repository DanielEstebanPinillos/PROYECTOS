Imports Adya.CV.Modelo.HojadeVidaFacade
Imports Adya.CV.Modelo

Public Class ActividadesView
  Inherits System.Web.UI.Page

  Public Enum EnumModoPagina
    Insert
    Edit
  End Enum

  Public Property ModoPaginaActividades As EnumModoPagina
    Get
      Return ViewState("ModoPaginaActividades")
    End Get
    Set(ByVal value As EnumModoPagina)
      ViewState("ModoPaginaActividades") = value
    End Set
  End Property

  Dim ActividadFacade As New Facades

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
        sds_Actividades.SelectParameters.Clear()
        sds_Actividades.SelectParameters.Add("campo", ddl_buscar.SelectedValue)
        sds_Actividades.SelectParameters.Add("texto", txt_bucar.Text)
        Master.mensajes = Nothing
      Catch ex As Exception
        Master.mensajes = "danger;" & ex.Message
      End Try
    End If
  End Sub

  Protected Sub Agregar(sender As Object, e As EventArgs) Handles lkb_agregar.Click
    ModoPaginaActividades = EnumModoPagina.Insert
    MostrarFormulario()
    LimpiarActividad()
  End Sub

  Protected Sub Editar(sender As Object, e As EventArgs) Handles grd_Actividades.SelectedIndexChanged
    ModoPaginaActividades = EnumModoPagina.Edit
    MostrarFormulario()
    LimpiarActividad()
    hdf_id.Value = grd_Actividades.SelectedValue
    ObtenerActividad()
  End Sub

  Protected Sub Guardar(sender As Object, e As EventArgs) Handles lkb_guardar.Click
    Try
      Dim Actividad = AsignarActividad()
      If ModoPaginaActividades = EnumModoPagina.Insert Then
        ActividadFacade.GuardarActividad(Actividad)
        Master.mensajes = "success;Actividad creada con exito"
        OcultarBusqueda()
      Else
        ActividadFacade.ActualizarActividad(Actividad)
        Master.mensajes = "success;Actividad modificada con exito"
      End If
      MostrarLista()
    Catch ex As Exception
      Master.mensajes = "danger;" & ex.Message
    End Try
  End Sub

  Protected Sub Eliminar(sender As Object, e As EventArgs) Handles lkb_eliminar.Click
    Try
      ActividadFacade.EliminarActividad(hdf_id.Value)
      Master.mensajes = "success;Actividad eliminada con exito"
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
    grd_Actividades.DataBind()
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

  Public Sub ObtenerActividad()
    Dim Actividad = ActividadFacade.ConsultarActividadxId(hdf_id.Value)
    txt_nombres.Text = Actividad.Nombre
  End Sub

  Public Function AsignarActividad() As Actividades
    Dim Actividad As New Actividades
    Try
      Actividad.ActividadId = hdf_id.Value
    Catch ex As Exception

    End Try

    If txt_nombres.Text = "" Then
      Throw New Exception("Por favor ingrese un nombre")
    Else
      Actividad.Nombre = txt_nombres.Text
    End If
    Return Actividad
  End Function

  Public Sub LimpiarActividad()
    hdf_id.Value = Nothing
    txt_nombres.Text = Nothing
    Master.mensajes = Nothing
    txt_nombres.Focus()
  End Sub

End Class