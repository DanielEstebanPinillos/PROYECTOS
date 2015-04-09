Namespace Dao

  Friend Class ActividadesDao

    Public Function ListarActividades() As List(Of Actividades)
      Using bd As New CVEntities
        Dim query = From tbl In bd.Actividades
                    Select tbl
        Return query.ToList
      End Using
    End Function

    Public Function ConsultarActividadxId(ByVal Actividadid As Integer) As Actividades
      Using bd As New CVEntities
        Dim query = From tbl In bd.Actividades
                    Where tbl.ActividadId = Actividadid
                    Select tbl
        Return query.FirstOrDefault
      End Using
    End Function

    Public Sub GuardarActividad(ByVal Actividad As Actividades)
      Using bd As New CVEntities
        bd.Entry(Actividad).State = EntityState.Added
        bd.SaveChanges()
      End Using
    End Sub

    Public Sub ActualizarActividad(ByVal Actividad As Actividades)
      Using bd As New CVEntities
        bd.Entry(Actividad).State = EntityState.Modified
        bd.SaveChanges()
      End Using
    End Sub

    Public Sub EliminarActividad(ByVal Actividad As Actividades)
      Using bd As New CVEntities
        bd.Entry(Actividad).State = EntityState.Deleted
        bd.SaveChanges()
      End Using
    End Sub

  End Class

End Namespace

