Namespace Dao

    Friend Class ExperienciaLaboralesDao

        Public Function ListarExperienciaLaborales() As List(Of ExperienciaLaborales)
            Using bd As New CVEntities
                Dim query = From tbl In bd.ExperienciaLaborales
                            Select tbl
                Return query.ToList
            End Using
        End Function

        Public Function ConsultarExperienciaLaboralxId(ByVal ExperienciaLaboralid As Integer) As ExperienciaLaborales
            Using bd As New CVEntities
                Dim query = From tbl In bd.ExperienciaLaborales
                            Where tbl.ExperienciaLaboralId = ExperienciaLaboralid
                            Select tbl
                Return query.FirstOrDefault
            End Using
        End Function

        Public Sub GuardarExperienciaLaboral(ByVal ExperienciaLaboral As ExperienciaLaborales)
            Using bd As New CVEntities
                bd.Entry(ExperienciaLaboral).State = EntityState.Added
                bd.SaveChanges()
            End Using
        End Sub

        Public Sub ActualizarExperienciaLaboral(ByVal ExperienciaLaboral As ExperienciaLaborales)
            Using bd As New CVEntities
                bd.Entry(ExperienciaLaboral).State = EntityState.Modified
                bd.SaveChanges()
            End Using
        End Sub

        Public Sub EliminarExperienciaLaboral(ByVal ExperienciaLaboral As ExperienciaLaborales)
            Using bd As New CVEntities
                bd.Entry(ExperienciaLaboral).State = EntityState.Deleted
                bd.SaveChanges()
            End Using
        End Sub

    End Class

End Namespace

