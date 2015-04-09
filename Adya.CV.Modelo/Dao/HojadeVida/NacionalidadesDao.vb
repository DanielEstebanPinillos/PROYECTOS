Namespace Dao

    Friend Class NacionalidadesDao

        Public Function ListarNacionalidades() As List(Of Nacionalidades)
            Using bd As New CVEntities
                Dim query = From tbl In bd.Nacionalidades
                            Select tbl
                Return query.ToList
            End Using
        End Function

        Public Function ConsultarNacionalidadxId(ByVal Nacionalidadid As Integer) As Nacionalidades
            Using bd As New CVEntities
                Dim query = From tbl In bd.Nacionalidades
                            Where tbl.NacionalidadId = Nacionalidadid
                            Select tbl
                Return query.FirstOrDefault
            End Using
        End Function

        Public Sub GuardarNacionalidad(ByVal Nacionalidad As Nacionalidades)
            Using bd As New CVEntities
                bd.Entry(Nacionalidad).State = EntityState.Added
                bd.SaveChanges()
            End Using
        End Sub

        Public Sub ActualizarNacionalidad(ByVal Nacionalidad As Nacionalidades)
            Using bd As New CVEntities
                bd.Entry(Nacionalidad).State = EntityState.Modified
                bd.SaveChanges()
            End Using
        End Sub

        Public Sub EliminarNacionalidad(ByVal Nacionalidad As Nacionalidades)
            Using bd As New CVEntities
                bd.Entry(Nacionalidad).State = EntityState.Deleted
                bd.SaveChanges()
            End Using
        End Sub

    End Class

End Namespace

