Namespace Dao

  Friend Class MenusDao

    Public Function ListarMenus() As List(Of Menus)
      Using bd As New CVEntities
        Dim query = From tbl In bd.Menus
                    Select tbl
        Return query.ToList
      End Using
    End Function

    Public Function ConsultarMenuxId(ByVal Menuid As Integer) As Menus
      Using bd As New CVEntities
        Dim query = From tbl In bd.Menus
                    Where tbl.MenuId = Menuid
                    Select tbl
        Return query.FirstOrDefault
      End Using
    End Function

    Public Sub GuardarMenu(ByVal Menu As Menus)
      Using bd As New CVEntities
        bd.Entry(Menu).State = EntityState.Added
        bd.SaveChanges()
      End Using
    End Sub

    Public Sub ActualizarMenu(ByVal Menu As Menus)
      Using bd As New CVEntities
        bd.Entry(Menu).State = EntityState.Modified
        bd.SaveChanges()
      End Using
    End Sub

    Public Sub EliminarMenu(ByVal Menu As Menus)
      Using bd As New CVEntities
        bd.Entry(Menu).State = EntityState.Deleted
        bd.SaveChanges()
      End Using
    End Sub

    Public Function ConsultarMenuxNombre(ByVal nombre As String) As Menus
      Using bd As New CVEntities
        Dim query = From tbl In bd.Menus
                    Where tbl.Nombre = nombre
                    Select tbl
        Return query.FirstOrDefault
      End Using
    End Function

  End Class

End Namespace


