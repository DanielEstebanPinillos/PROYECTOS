Imports Adya.CV.Modelo.Dao

Namespace BL

  Friend Class MenusBL

    Public Function ListarMenus() As List(Of Menus)
      Try
        Dim dao As New MenusDao
        Return dao.ListarMenus
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Function

    Public Function ConsultarMenuxId(ByVal Menuid As Integer) As Menus
      Try
        Dim dao As New MenusDao
        Return dao.ConsultarMenuxId(Menuid)
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Function

    Public Sub GuardarMenu(ByVal Menu As Menus)
      Try
        Dim dao As New MenusDao
        dao.GuardarMenu(Menu)
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Sub

    Public Sub ActualizarMenu(ByVal Menu As Menus)
      Try
        Dim dao As New MenusDao
        dao.ActualizarMenu(Menu)
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Sub

    Public Sub EliminarMenu(ByVal MenuId As Integer)
      Try
        Dim dao As New MenusDao
        Dim Menu = ConsultarMenuxId(MenuId)
        dao.EliminarMenu(Menu)
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Sub

    Public Function ConsultarMenuxNombre(ByVal nombre As String) As Menus
      Try
        Dim dao As New MenusDao
        Return dao.ConsultarMenuxNombre(nombre)
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Function

  End Class

End Namespace


