Namespace Dao

  Friend Class ActividadesxHojadeVidaDao

    Public Function ListarActividadesxHojadeVida() As List(Of ActividadesxHojadeVida)
      Using bd As New CVEntities
        Dim query = From tbl In bd.ActividadesxHojadeVida
                    Select tbl
        Return query.ToList
      End Using
    End Function

    Public Function ConsultarActividadxHojadeVidaxId(ByVal ActividadxHojadeVidaid As Integer) As ActividadesxHojadeVida
      Using bd As New CVEntities
        Dim query = From tbl In bd.ActividadesxHojadeVida
                    Where tbl.ActividadxHojadeVida = ActividadxHojadeVidaid
                    Select tbl
        Return query.FirstOrDefault
      End Using
    End Function

    Public Sub GuardarActividadxHojadeVida(ByVal ActividadxHojadeVida As ActividadesxHojadeVida)
      Using bd As New CVEntities
        bd.Entry(ActividadxHojadeVida).State = EntityState.Added
        bd.SaveChanges()
      End Using
    End Sub

    Public Sub ActualizarActividadxHojadeVida(ByVal ActividadxHojadeVida As ActividadesxHojadeVida)
      Using bd As New CVEntities
        bd.Entry(ActividadxHojadeVida).State = EntityState.Modified
        bd.SaveChanges()
      End Using
    End Sub

    Public Sub EliminarActividadxHojadeVida(ByVal ActividadxHojadeVida As ActividadesxHojadeVida)
      Using bd As New CVEntities
        bd.Entry(ActividadxHojadeVida).State = EntityState.Deleted
        bd.SaveChanges()
      End Using
    End Sub

  End Class

End Namespace
