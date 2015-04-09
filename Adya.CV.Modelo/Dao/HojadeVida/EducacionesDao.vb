Namespace Dao

    Friend Class EducacionesDao

        Public Function ListarEducaciones() As List(Of Educaciones)
            Using bd As New CVEntities
                Dim query = From tbl In bd.Educaciones
                            Select tbl
                Return query.ToList
            End Using
        End Function

        Public Function ConsultarEducacionxId(ByVal Educacionid As Integer) As Educaciones
            Using bd As New CVEntities
                Dim query = From tbl In bd.Educaciones
                            Where tbl.EducacionId = Educacionid
                            Select tbl
                Return query.FirstOrDefault
            End Using
        End Function

        Public Sub GuardarEducacion(ByVal Educacion As Educaciones)
            Using bd As New CVEntities
                bd.Entry(Educacion).State = EntityState.Added
                bd.SaveChanges()
            End Using
        End Sub

        Public Sub ActualizarEducacion(ByVal Educacion As Educaciones)
            Using bd As New CVEntities
                bd.Entry(Educacion).State = EntityState.Modified
                bd.SaveChanges()
            End Using
        End Sub

        Public Sub EliminarEducacion(ByVal Educacion As Educaciones)
            Using bd As New CVEntities
                bd.Entry(Educacion).State = EntityState.Deleted
                bd.SaveChanges()
            End Using
        End Sub

    End Class

End Namespace

