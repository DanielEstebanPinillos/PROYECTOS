Namespace Dao

    Friend Class AreasxHojadeVidaDao

        Public Function ListarAreasxHojadeVida() As List(Of AreasxHojadeVida)
            Using bd As New CVEntities
                Dim query = From tbl In bd.AreasxHojadeVida
                            Select tbl
                Return query.ToList
            End Using
        End Function

        Public Function ConsultarAreaxHojadeVidaxId(ByVal AreaxHojadeVidaid As Integer) As AreasxHojadeVida
            Using bd As New CVEntities
                Dim query = From tbl In bd.AreasxHojadeVida
                            Where tbl.AreaxHojadeVidaId = AreaxHojadeVidaid
                            Select tbl
                Return query.FirstOrDefault
            End Using
        End Function

        Public Sub GuardarAreaxHojadeVida(ByVal AreaxHojadeVida As AreasxHojadeVida)
            Using bd As New CVEntities
                bd.Entry(AreaxHojadeVida).State = EntityState.Added
                bd.SaveChanges()
            End Using
        End Sub

        Public Sub ActualizarAreaxHojadeVida(ByVal AreaxHojadeVida As AreasxHojadeVida)
            Using bd As New CVEntities
                bd.Entry(AreaxHojadeVida).State = EntityState.Modified
                bd.SaveChanges()
            End Using
        End Sub

        Public Sub EliminarAreaxHojadeVida(ByVal AreaxHojadeVida As AreasxHojadeVida)
            Using bd As New CVEntities
                bd.Entry(AreaxHojadeVida).State = EntityState.Deleted
                bd.SaveChanges()
            End Using
        End Sub

    End Class

End Namespace

