Namespace Dao

    Friend Class ProfesionesDao

        Public Function ListarProfesiones() As List(Of Profesiones)
            Using bd As New CVEntities
                Dim query = From tbl In bd.Profesiones
                            Select tbl
                Return query.ToList
            End Using
        End Function

        Public Function ConsultarProfesionxId(ByVal Profesionid As Integer) As Profesiones
            Using bd As New CVEntities
                Dim query = From tbl In bd.Profesiones
                            Where tbl.ProfesionId = Profesionid
                            Select tbl
                Return query.FirstOrDefault
            End Using
        End Function

        Public Sub GuardarProfesion(ByVal Profesion As Profesiones)
            Using bd As New CVEntities
                bd.Entry(Profesion).State = EntityState.Added
                bd.SaveChanges()
            End Using
        End Sub

        Public Sub ActualizarProfesion(ByVal Profesion As Profesiones)
            Using bd As New CVEntities
                bd.Entry(Profesion).State = EntityState.Modified
                bd.SaveChanges()
            End Using
        End Sub

        Public Sub EliminarProfesion(ByVal Profesion As Profesiones)
            Using bd As New CVEntities
                bd.Entry(Profesion).State = EntityState.Deleted
                bd.SaveChanges()
            End Using
        End Sub

    End Class

End Namespace

