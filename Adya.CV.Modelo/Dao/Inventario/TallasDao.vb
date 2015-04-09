Namespace Dao.Inventario

  Friend Class TallasDao

    Public Function ListarTallas() As List(Of Tallas)
      Using bd As New CVEntities
        Dim query = From tbl In bd.Tallas
                    Select tbl
        Return query.ToList
      End Using
    End Function

    Public Function ConsultarTallaxId(ByVal Tallaid As Integer) As Tallas
      Using bd As New CVEntities
        Dim query = From tbl In bd.Tallas
                    Where tbl.TallaId = Tallaid
                    Select tbl
        Return query.FirstOrDefault
      End Using
    End Function

    Public Sub GuardarTalla(ByVal Talla As Tallas)
      Using bd As New CVEntities
        bd.Entry(Talla).State = EntityState.Added
        bd.SaveChanges()
      End Using
    End Sub

    Public Sub ActualizarTalla(ByVal Talla As Tallas)
      Using bd As New CVEntities
        bd.Entry(Talla).State = EntityState.Modified
        bd.SaveChanges()
      End Using
    End Sub

    Public Sub EliminarTalla(ByVal Talla As Tallas)
      Using bd As New CVEntities
        bd.Entry(Talla).State = EntityState.Deleted
        bd.SaveChanges()
      End Using
    End Sub

  End Class

End Namespace


