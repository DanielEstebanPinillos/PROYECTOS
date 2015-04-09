Imports Adya.CV.Modelo.HojadeVidaFacade

Public Class IndexView
  Inherits System.Web.UI.Page

  Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    Try
      If Me.Request.QueryString("a") = "no" Then
        Master.mensajes = "danger;El usuario no esta autorizado para visualizar esta informacion. Por favor comuniquerse con el administrador"
      End If
    Catch ex As Exception
      Master.mensajes = Nothing
    End Try
  End Sub

End Class