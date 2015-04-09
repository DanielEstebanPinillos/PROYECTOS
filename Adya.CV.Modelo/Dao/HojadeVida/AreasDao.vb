Namespace Dao

    Friend Class AreasDao

        Public Function ListarAreas() As List(Of Areas)
            Using bd As New CVEntities
                Dim query = From tbl In bd.Areas
                            Select tbl
                Return query.ToList
            End Using
        End Function

        Public Function ConsultarAreaxId(ByVal Areaid As Integer) As Areas
            Using bd As New CVEntities
                Dim query = From tbl In bd.Areas
                            Where tbl.AreaId = Areaid
                            Select tbl
                Return query.FirstOrDefault
            End Using
        End Function

        Public Sub GuardarArea(ByVal Area As Areas)
            Using bd As New CVEntities
                bd.Entry(Area).State = EntityState.Added
                bd.SaveChanges()
            End Using
        End Sub

        Public Sub ActualizarArea(ByVal Area As Areas)
            Using bd As New CVEntities
                bd.Entry(Area).State = EntityState.Modified
                bd.SaveChanges()
            End Using
        End Sub

        Public Sub EliminarArea(ByVal Area As Areas)
            Using bd As New CVEntities
                bd.Entry(Area).State = EntityState.Deleted
                bd.SaveChanges()
            End Using
        End Sub

    End Class

End Namespace

