Imports Adya.CV.Modelo.HojadeVidaFacade
Imports Adya.CV.Modelo

Public Class AreasView
  Inherits System.Web.UI.Page

  Public Enum EnumModoPagina
    Insert
    Edit
  End Enum

  Public Property ModoPaginaAreas As EnumModoPagina
    Get
      Return ViewState("ModoPaginaAreas")
    End Get
    Set(ByVal value As EnumModoPagina)
      ViewState("ModoPaginaAreas") = value
    End Set
  End Property

  Dim AreaFacade As New Facades

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
        sds_Areas.SelectParameters.Clear()
        sds_Areas.SelectParameters.Add("campo", ddl_buscar.SelectedValue)
        sds_Areas.SelectParameters.Add("texto", txt_bucar.Text)
        Master.mensajes = Nothing
      Catch ex As Exception
        Master.mensajes = "danger;" & ex.Message
      End Try
    End If
  End Sub

  Protected Sub Agregar(sender As Object, e As EventArgs) Handles lkb_agregar.Click
    ModoPaginaAreas = EnumModoPagina.Insert
    MostrarFormulario()
    LimpiarArea()
  End Sub

  Protected Sub Editar(sender As Object, e As EventArgs) Handles grd_Areas.SelectedIndexChanged
    ModoPaginaAreas = EnumModoPagina.Edit
    MostrarFormulario()
    LimpiarArea()
    hdf_id.Value = grd_Areas.SelectedValue
    ObtenerArea()
  End Sub

  Protected Sub Guardar(sender As Object, e As EventArgs) Handles lkb_guardar.Click
    Try
      Dim Area = AsignarArea()
      If ModoPaginaAreas = EnumModoPagina.Insert Then
        AreaFacade.GuardarArea(Area)
        Master.mensajes = "success;Area creada con exito"
        OcultarBusqueda()
      Else
        AreaFacade.ActualizarArea(Area)
        Master.mensajes = "success;Area modificada con exito"
      End If
      MostrarLista()      
    Catch ex As Exception
      Master.mensajes = "danger;" & ex.Message
    End Try
  End Sub

  Protected Sub Eliminar(sender As Object, e As EventArgs) Handles lkb_eliminar.Click
    Try
      AreaFacade.EliminarArea(hdf_id.Value)
      Master.mensajes = "success;Area eliminada con exito"
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
    grd_Areas.DataBind()
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

  Public Sub ObtenerArea()
    Dim Area = AreaFacade.ConsultarAreaxId(hdf_id.Value)
    txt_nombres.Text = Area.Nombre
  End Sub

  Public Function AsignarArea() As Areas
    Dim Area As New Areas
    Try
      Area.AreaId = hdf_id.Value
    Catch ex As Exception

    End Try

    If txt_nombres.Text = "" Then
      Throw New Exception("Por favor ingrese un nombre")
    Else
      Area.Nombre = txt_nombres.Text
    End If
    Return Area
  End Function

  Public Sub LimpiarArea()
    hdf_id.Value = Nothing
    txt_nombres.Text = Nothing
    Master.mensajes = Nothing
    txt_nombres.Focus()
  End Sub

End Class