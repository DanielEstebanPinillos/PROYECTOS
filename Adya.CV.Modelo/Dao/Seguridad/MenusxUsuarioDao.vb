Namespace Dao

  Friend Class MenusxUsuarioDao

    Public Function ListarMenusxUsuario() As List(Of MenusxUsuario)
      Using bd As New CVEntities
        Dim query = From tbl In bd.MenusxUsuario
                    Select tbl
        Return query.ToList
      End Using
    End Function

    Public Function ConsultarMenuxUsuarioxId(ByVal MenuxUsuarioid As Integer) As MenusxUsuario
      Using bd As New CVEntities
        Dim query = From tbl In bd.MenusxUsuario
                    Where tbl.MenuxUsuarioId = MenuxUsuarioid
                    Select tbl
        Return query.FirstOrDefault
      End Using
    End Function

    Public Sub GuardarMenuxUsuario(ByVal MenuxUsuario As MenusxUsuario)
      Using bd As New CVEntities
        bd.Entry(MenuxUsuario).State = EntityState.Added
        bd.SaveChanges()
      End Using
    End Sub

    Public Sub ActualizarMenuxUsuario(ByVal MenuxUsuario As MenusxUsuario)
      Using bd As New CVEntities
        bd.Entry(MenuxUsuario).State = EntityState.Modified
        bd.SaveChanges()
      End Using
    End Sub

    Public Sub EliminarMenuxUsuario(ByVal MenuxUsuario As MenusxUsuario)
      Using bd As New CVEntities
        bd.Entry(MenuxUsuario).State = EntityState.Deleted
        bd.SaveChanges()
      End Using
    End Sub

    Public Function ListarMenusxUsuarioXUsuarioId(ByVal usuarioId As Integer) As List(Of MenusxUsuario)
      Using bd As New CVEntities
        Dim query = From tbl In bd.MenusxUsuario.Include("Menus")
          Where tbl.UsuarioFk = usuarioId
          Select tbl
        Return query.ToList
      End Using
    End Function

    Public Function ConsultarMenuxUsuarioxUsuarioIdyMenuId(ByVal usuarioId As Integer, ByVal menuId As String) As MenusxUsuario
      Using bd As New CVEntities
        Dim query = From tbl In bd.MenusxUsuario
                    Where tbl.UsuarioFk = usuarioId And tbl.MenuFk = menuId
                    Select tbl
        Return query.FirstOrDefault
      End Using
    End Function

    Public Function AutorizacionMenu(ByVal usuarioId As Integer) As List(Of MenusxUsuario)
      Using bd As New CVEntities
        Dim query = From tbl In bd.MenusxUsuario.Include("Menus")
                    Where tbl.UsuarioFk = usuarioId And tbl.Valor = True
                    Select tbl
        Return query.ToList
      End Using
    End Function

  End Class

End Namespace
