Imports Adya.CV.Modelo.HojadeVidaFacade
Imports Adya.CV.Modelo

Public Class UsuariosView
  Inherits System.Web.UI.Page

  Public Enum EnumModoPagina
    Insert
    Edit
  End Enum

  Public Property ModoPaginaUsuarios As EnumModoPagina
    Get
      Return ViewState("ModoPaginaUsuarios")
    End Get
    Set(ByVal value As EnumModoPagina)
      ViewState("ModoPaginaUsuarios") = value
    End Set
  End Property

  Dim UsuarioFacade As New Facades

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
        sds_usuarios.SelectParameters.Clear()
        sds_usuarios.SelectParameters.Add("campo", ddl_buscar.SelectedValue)
        sds_usuarios.SelectParameters.Add("texto", txt_bucar.Text)
        Master.mensajes = Nothing
      Catch ex As Exception
        Master.mensajes = "danger;" & ex.Message
      End Try
    End If
  End Sub

  Protected Sub Agregar(sender As Object, e As EventArgs) Handles lkb_agregar.Click
    ModoPaginaUsuarios = EnumModoPagina.Insert
    MostrarFormulario()
    LimpiarUsuario()
  End Sub

  Protected Sub Editar(sender As Object, e As EventArgs) Handles grd_usuarios.SelectedIndexChanged
    ModoPaginaUsuarios = EnumModoPagina.Edit
    MostrarFormulario()
    LimpiarUsuario()
    hdf_id.Value = grd_usuarios.SelectedValue
    ObtenerUsuario()
  End Sub

  Protected Sub Guardar(sender As Object, e As EventArgs) Handles lkb_guardar.Click
    Try
      Dim usuario = AsignarUsuario()
      Dim menuseleccionados = AsignarMenu()
      If ModoPaginaUsuarios = EnumModoPagina.Insert Then
        UsuarioFacade.GuardarUsuario(usuario, menuseleccionados)
        Master.mensajes = "success;Usuario creado con exito"
        OcultarBusqueda()
      Else
        UsuarioFacade.ActualizarUsuario(usuario, menuseleccionados)
        Master.mensajes = "success;Usuario modificado con exito"
      End If
      MostrarLista()
    Catch ex As Exception
      Master.mensajes = "danger;" & ex.Message
    End Try
  End Sub

  Protected Sub Eliminar(sender As Object, e As EventArgs) Handles lkb_eliminar.Click
    Try
      UsuarioFacade.EliminarUsuario(hdf_id.Value)
      Master.mensajes = "success;Usuario eliminado con exito"
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
    grd_usuarios.DataBind()
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

  Public Sub ObtenerUsuario()
    Dim usuario = UsuarioFacade.ConsultarUsuarioxId(hdf_id.Value)
    txt_nombres.Text = usuario.Nombre
    txt_apellidos.Text = usuario.Apellido
    txt_usuario.Text = usuario.Usuario
    rbl_administrador.SelectedValue = usuario.Administrador
    ObtenerMenu()
  End Sub

  Public Function AsignarUsuario() As Usuarios
    If txt_clave.Text <> txt_confirmaclave.Text Then
      Throw New Exception("Las claves no coinciden")
    End If
    Dim usuario As New Usuarios
    Try
      usuario.UsuarioId = hdf_id.Value
    Catch ex As Exception

    End Try

    If txt_nombres.Text = "" Then
      Throw New Exception("Por favor ingrese un nombre")
    Else
      usuario.Nombre = txt_nombres.Text
    End If

    If txt_apellidos.Text = "" Then
      Throw New Exception("Por favor ingrese un apellido")
    Else
      usuario.Apellido = txt_apellidos.Text
    End If

    If txt_usuario.Text = "" Then
      Throw New Exception("Por favor ingrese un usuario")
    Else
      usuario.Usuario = txt_usuario.Text
    End If

    If txt_clave.Text = "" Then
      Throw New Exception("Por favor ingrese una contraseña")
    Else
      usuario.Contrasena = FormsAuthentication.HashPasswordForStoringInConfigFile(txt_clave.Text, "md5")
    End If

    If rbl_administrador.SelectedValue = "" Then
      Throw New Exception("Por favor seleccione el campo administrador")
    Else
      usuario.Administrador = rbl_administrador.SelectedValue
    End If
    Return usuario
  End Function

  Public Sub LimpiarUsuario()
    hdf_id.Value = Nothing
    txt_nombres.Text = Nothing
    txt_apellidos.Text = Nothing
    txt_usuario.Text = Nothing
    rbl_administrador.SelectedValue = Nothing
    txt_clave.Text = Nothing
    txt_confirmaclave.Text = Nothing
    Master.mensajes = Nothing
    txt_nombres.Focus()
    LimpiarMenu()
  End Sub

  Public Function AsignarMenu() As List(Of Menu)
    Dim menuseleccionados As New List(Of Menu)
    Dim menus = UsuarioFacade.ListarMenus
    For i As Integer = 0 To menus.Count - 1
      Dim menu As New Menu
      Dim check = DirectCast(FindControl("ctl00$cph_contenido$" & menus.Item(i).Nombre), CheckBox)
      menu.Nombre = check.ID
      menu.Valor = check.Checked
      menuseleccionados.Add(menu)
    Next
    Return menuseleccionados
  End Function

  Public Sub ObtenerMenu()
    Dim menus = UsuarioFacade.ListarMenusxUsuarioXUsuarioId(hdf_id.Value)
    For i As Integer = 0 To menus.Count - 1
      Try
        DirectCast(FindControl("ctl00$cph_contenido$" & menus.Item(i).Menus.Nombre), CheckBox).Checked = menus.Item(i).Valor
      Catch ex As Exception

      End Try
    Next
  End Sub

  Public Sub LimpiarMenu()
    li_hojadevidas.Checked = False
    li_actividades.Checked = False
    li_areas.Checked = False
    li_cargos.Checked = False
    li_ciudades.Checked = False
    li_nacionalidades.Checked = False
    li_profesiones.Checked = False
    li_inventarios.Checked = False
    li_ingresos.Checked = False
    li_empleados.Checked = False
    li_proveedores.Checked = False
    li_tallas.Checked = False
    li_usuarios.Checked = False
  End Sub


End Class