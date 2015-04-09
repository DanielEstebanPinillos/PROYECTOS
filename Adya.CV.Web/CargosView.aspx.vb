Imports Adya.CV.Modelo.HojadeVidaFacade
Imports Adya.CV.Modelo

Public Class CargosView
  Inherits System.Web.UI.Page

  Public Enum EnumModoPagina
    Insert
    Edit
  End Enum

  Public Property ModoPaginaCargos As EnumModoPagina
    Get
      Return ViewState("ModoPaginaCargos")
    End Get
    Set(ByVal value As EnumModoPagina)
      ViewState("ModoPaginaCargos") = value
    End Set
  End Property

  Dim CargoFacade As New Facades

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
        sds_Cargos.SelectParameters.Clear()
        sds_Cargos.SelectParameters.Add("campo", ddl_buscar.SelectedValue)
        sds_Cargos.SelectParameters.Add("texto", txt_bucar.Text)
        Master.mensajes = Nothing
      Catch ex As Exception
        Master.mensajes = "danger;" & ex.Message
      End Try
    End If
  End Sub

  Protected Sub Agregar(sender As Object, e As EventArgs) Handles lkb_agregar.Click
    ModoPaginaCargos = EnumModoPagina.Insert
    MostrarFormulario()
    LimpiarCargo()
  End Sub

  Protected Sub Editar(sender As Object, e As EventArgs) Handles grd_Cargos.SelectedIndexChanged
    ModoPaginaCargos = EnumModoPagina.Edit
    MostrarFormulario()
    LimpiarCargo()
    hdf_id.Value = grd_Cargos.SelectedValue
    ObtenerCargo()
  End Sub

  Protected Sub Guardar(sender As Object, e As EventArgs) Handles lkb_guardar.Click
    Try
      Dim Cargo = AsignarCargo()
      If ModoPaginaCargos = EnumModoPagina.Insert Then
        CargoFacade.GuardarCargo(Cargo)
        Master.mensajes = "success;Cargo creada con exito"
        OcultarBusqueda()
      Else
        CargoFacade.ActualizarCargo(Cargo)
        Master.mensajes = "success;Cargo modificada con exito"
      End If
      MostrarLista()
    Catch ex As Exception
      Master.mensajes = "danger;" & ex.Message
    End Try
  End Sub

  Protected Sub Eliminar(sender As Object, e As EventArgs) Handles lkb_eliminar.Click
    Try
      CargoFacade.EliminarCargo(hdf_id.Value)
      Master.mensajes = "success;Cargo eliminada con exito"
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
    grd_Cargos.DataBind()
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

  Public Sub ObtenerCargo()
    Dim Cargo = CargoFacade.ConsultarCargoxId(hdf_id.Value)
    txt_nombres.Text = Cargo.Nombre
    txt_codigo.Text = Cargo.Codigo
  End Sub

  Public Function AsignarCargo() As Cargos
    Dim Cargo As New Cargos
    Try
      Cargo.CargoId = hdf_id.Value
    Catch ex As Exception

    End Try
    If txt_nombres.Text = "" Then
      Throw New Exception("Por favor ingrese un nombre")
    Else
      Cargo.Nombre = txt_nombres.Text
    End If
    Cargo.Codigo = txt_codigo.Text
    Return Cargo
  End Function

  Public Sub LimpiarCargo()
    hdf_id.Value = Nothing
    txt_nombres.Text = Nothing
    txt_codigo.Text = Nothing
    Master.mensajes = Nothing
    txt_nombres.Focus()
  End Sub

End Class