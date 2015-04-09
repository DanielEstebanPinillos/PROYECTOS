Imports Adya.CV.Modelo.HojadeVidaFacade
Imports Adya.CV.Modelo.Session

Public Class Login
  Inherits System.Web.UI.Page

  Dim Facades As New Facades

  Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

  End Sub

  Protected Sub btn_ingresar_Click(sender As Object, e As EventArgs) Handles btn_ingresar.Click
    Try
      Dim usuario = Facades.ConsultarUsuarioxUsuarioyContrasena(txt_usuario.Text, FormsAuthentication.HashPasswordForStoringInConfigFile(txt_contrasena.Text, "md5"))
      If usuario Is Nothing Then
        div_error.Visible = True
      Else
        SessionManager.UserId = usuario.UsuarioId
        FormsAuthentication.RedirectFromLoginPage(usuario.UsuarioId, False)
        Response.Redirect("IndexView.aspx", True)
      End If
    Catch ex As Exception

    End Try
  End Sub

  Protected Sub btn_cerrarerror_Click(sender As Object, e As EventArgs) Handles btn_cerrarerror.ServerClick
    div_error.Visible = False
  End Sub

End Class