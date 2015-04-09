Imports Adya.CV.Modelo.Dao

Namespace BL

  Friend Class MenusxUsuarioBL

    Public Function ListarMenusxUsuario() As List(Of MenusxUsuario)
      Try
        Dim dao As New MenusxUsuarioDao
        Return dao.ListarMenusxUsuario
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Function

    Public Function ConsultarMenuxUsuarioxId(ByVal MenuxUsuarioid As Integer) As MenusxUsuario
      Try
        Dim dao As New MenusxUsuarioDao
        Return dao.ConsultarMenuxUsuarioxId(MenuxUsuarioid)
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Function

    Public Sub GuardarMenuxUsuario(ByVal MenuxUsuario As MenusxUsuario)
      Try
        Dim dao As New MenusxUsuarioDao
        dao.GuardarMenuxUsuario(MenuxUsuario)
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Sub

    Public Sub ActualizarMenuxUsuario(ByVal MenuxUsuario As MenusxUsuario)
      Try
        Dim dao As New MenusxUsuarioDao
        dao.ActualizarMenuxUsuario(MenuxUsuario)
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Sub

    Public Sub EliminarMenuxUsuario(ByVal MenuxUsuarioId As Integer)
      Try
        Dim dao As New MenusxUsuarioDao
        Dim MenuxUsuario = ConsultarMenuxUsuarioxId(MenuxUsuarioId)
        dao.EliminarMenuxUsuario(MenuxUsuario)
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Sub

    Public Function ListarMenusxUsuarioXUsuarioId(ByVal usuarioId As Integer) As List(Of MenusxUsuario)
      Try
        Dim dao As New MenusxUsuarioDao
        Return dao.ListarMenusxUsuarioXUsuarioId(usuarioId)
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Function

    Public Sub ConsultarMenuxUsuarioxUsuarioIdyMenuId(ByVal usuarioId As Integer, ByVal menuId As String)
      Try
        Dim dao As New MenusxUsuarioDao
        dao.ConsultarMenuxUsuarioxUsuarioIdyMenuId(usuarioId, menuId)
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Sub

    Public Function AutorizacionMenu(ByVal usuarioId As Integer) As List(Of MenusxUsuario)
      Try
        Dim dao As New MenusxUsuarioDao
        Return dao.AutorizacionMenu(usuarioId)
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Function

  End Class

End Namespace



