Imports Adya.CV.Modelo.HojadeVidaFacade
Imports Adya.CV.Modelo

Public Class CiudadesView
  Inherits System.Web.UI.Page

  Public Enum EnumModoPagina
    Insert
    Edit
  End Enum

  Public Property ModoPaginaCiudades As EnumModoPagina
    Get
      Return ViewState("ModoPaginaCiudades")
    End Get
    Set(ByVal value As EnumModoPagina)
      ViewState("ModoPaginaCiudades") = value
    End Set
  End Property

  Dim CiudadFacade As New Facades

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
        sds_Ciudades.SelectParameters.Clear()
        sds_Ciudades.SelectParameters.Add("campo", ddl_buscar.SelectedValue)
        sds_Ciudades.SelectParameters.Add("texto", txt_bucar.Text)
        Master.mensajes = Nothing
      Catch ex As Exception
        Master.mensajes = "danger;" & ex.Message
      End Try
    End If
  End Sub

  Protected Sub Agregar(sender As Object, e As EventArgs) Handles lkb_agregar.Click
    ModoPaginaCiudades = EnumModoPagina.Insert
    MostrarFormulario()
    LimpiarCiudad()
  End Sub

  Protected Sub Editar(sender As Object, e As EventArgs) Handles grd_Ciudades.SelectedIndexChanged
    ModoPaginaCiudades = EnumModoPagina.Edit
    MostrarFormulario()
    LimpiarCiudad()
    hdf_id.Value = grd_Ciudades.SelectedValue
    ObtenerCiudad()
  End Sub

  Protected Sub Guardar(sender As Object, e As EventArgs) Handles lkb_guardar.Click
    Try
      Dim Ciudad = AsignarCiudad()
      If ModoPaginaCiudades = EnumModoPagina.Insert Then
        CiudadFacade.GuardarCiudad(Ciudad)
        Master.mensajes = "success;Ciudad creada con exito"
        OcultarBusqueda()
      Else
        CiudadFacade.ActualizarCiudad(Ciudad)
        Master.mensajes = "success;Ciudad modificada con exito"
      End If
      MostrarLista()
    Catch ex As Exception
      Master.mensajes = "danger;" & ex.Message
    End Try
  End Sub

  Protected Sub Eliminar(sender As Object, e As EventArgs) Handles lkb_eliminar.Click
    Try
      CiudadFacade.EliminarCiudad(hdf_id.Value)
      Master.mensajes = "success;Ciudad eliminada con exito"
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
    grd_Ciudades.DataBind()
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

  Public Sub ObtenerCiudad()
    Dim Ciudad = CiudadFacade.ConsultarCiudadxId(hdf_id.Value)
    txt_nombres.Text = Ciudad.Nombre
  End Sub

  Public Function AsignarCiudad() As Ciudades
    Dim Ciudad As New Ciudades
    Try
      Ciudad.CiudadId = hdf_id.Value
    Catch ex As Exception

    End Try

    If txt_nombres.Text = "" Then
      Throw New Exception("Por favor ingrese un nombre")
    Else
      Ciudad.Nombre = txt_nombres.Text
    End If
    Return Ciudad
  End Function

  Public Sub LimpiarCiudad()
    hdf_id.Value = Nothing
    txt_nombres.Text = Nothing
    Master.mensajes = Nothing
    txt_nombres.Focus()
  End Sub

End Class