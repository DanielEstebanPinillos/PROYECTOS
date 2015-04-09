Namespace Dao

    Friend Class ConocimientosDao

        Public Function ListarConocimientos() As List(Of Conocimientos)
            Using bd As New CVEntities
                Dim query = From tbl In bd.Conocimientos
                            Select tbl
                Return query.ToList
            End Using
        End Function

        Public Function ConsultarConocimientoxId(ByVal Conocimientoid As Integer) As Conocimientos
            Using bd As New CVEntities
                Dim query = From tbl In bd.Conocimientos
                            Where tbl.ConocimientoId = Conocimientoid
                            Select tbl
                Return query.FirstOrDefault
            End Using
        End Function

        Public Sub GuardarConocimiento(ByVal Conocimiento As Conocimientos)
            Using bd As New CVEntities
                bd.Entry(Conocimiento).State = EntityState.Added
                bd.SaveChanges()
            End Using
        End Sub

        Public Sub ActualizarConocimiento(ByVal Conocimiento As Conocimientos)
            Using bd As New CVEntities
                bd.Entry(Conocimiento).State = EntityState.Modified
                bd.SaveChanges()
            End Using
        End Sub

        Public Sub EliminarConocimiento(ByVal Conocimiento As Conocimientos)
            Using bd As New CVEntities
                bd.Entry(Conocimiento).State = EntityState.Deleted
                bd.SaveChanges()
            End Using
        End Sub

    End Class

End Namespace

