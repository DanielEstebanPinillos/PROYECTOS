Namespace Dao

    Friend Class ReferenciaPersonalesDao

        Public Function ListarReferenciaPersonales() As List(Of ReferenciaPersonales)
            Using bd As New CVEntities
                Dim query = From tbl In bd.ReferenciaPersonales
                            Select tbl
                Return query.ToList
            End Using
        End Function

        Public Function ConsultarReferenciaPersonalxId(ByVal ReferenciaPersonalid As Integer) As ReferenciaPersonales
            Using bd As New CVEntities
                Dim query = From tbl In bd.ReferenciaPersonales
                            Where tbl.ReferenciaPersonalId = ReferenciaPersonalid
                            Select tbl
                Return query.FirstOrDefault
            End Using
        End Function

        Public Sub GuardarReferenciaPersonal(ByVal ReferenciaPersonal As ReferenciaPersonales)
            Using bd As New CVEntities
                bd.Entry(ReferenciaPersonal).State = EntityState.Added
                bd.SaveChanges()
            End Using
        End Sub

        Public Sub ActualizarReferenciaPersonal(ByVal ReferenciaPersonal As ReferenciaPersonales)
            Using bd As New CVEntities
                bd.Entry(ReferenciaPersonal).State = EntityState.Modified
                bd.SaveChanges()
            End Using
        End Sub

        Public Sub EliminarReferenciaPersonal(ByVal ReferenciaPersonal As ReferenciaPersonales)
            Using bd As New CVEntities
                bd.Entry(ReferenciaPersonal).State = EntityState.Deleted
                bd.SaveChanges()
            End Using
        End Sub

    End Class

End Namespace

