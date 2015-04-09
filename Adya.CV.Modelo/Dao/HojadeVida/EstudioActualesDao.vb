Namespace Dao

    Friend Class EstudioActualesDao

        Public Function ListarEstudioActuales() As List(Of EstudioActuales)
            Using bd As New CVEntities
                Dim query = From tbl In bd.EstudioActuales
                            Select tbl
                Return query.ToList
            End Using
        End Function

        Public Function ConsultarEstudioActualxId(ByVal EstudioActualid As Integer) As EstudioActuales
            Using bd As New CVEntities
                Dim query = From tbl In bd.EstudioActuales
                            Where tbl.Estudio = EstudioActualid
                            Select tbl
                Return query.FirstOrDefault
            End Using
        End Function

        Public Sub GuardarEstudioActual(ByVal EstudioActual As EstudioActuales)
            Using bd As New CVEntities
                bd.Entry(EstudioActual).State = EntityState.Added
                bd.SaveChanges()
            End Using
        End Sub

        Public Sub ActualizarEstudioActual(ByVal EstudioActual As EstudioActuales)
            Using bd As New CVEntities
                bd.Entry(EstudioActual).State = EntityState.Modified
                bd.SaveChanges()
            End Using
        End Sub

        Public Sub EliminarEstudioActual(ByVal EstudioActual As EstudioActuales)
            Using bd As New CVEntities
                bd.Entry(EstudioActual).State = EntityState.Deleted
                bd.SaveChanges()
            End Using
        End Sub

    End Class

End Namespace

