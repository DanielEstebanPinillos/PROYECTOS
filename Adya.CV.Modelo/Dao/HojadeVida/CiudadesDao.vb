Namespace Dao

    Friend Class CiudadesDao

        Public Function ListarCiudades() As List(Of Ciudades)
            Using bd As New CVEntities
                Dim query = From tbl In bd.Ciudades
                            Select tbl
                Return query.ToList
            End Using
        End Function

        Public Function ConsultarCiudadxId(ByVal Ciudadid As Integer) As Ciudades
            Using bd As New CVEntities
                Dim query = From tbl In bd.Ciudades
                            Where tbl.CiudadId = Ciudadid
                            Select tbl
                Return query.FirstOrDefault
            End Using
        End Function

        Public Sub GuardarCiudad(ByVal Ciudad As Ciudades)
            Using bd As New CVEntities
                bd.Entry(Ciudad).State = EntityState.Added
                bd.SaveChanges()
            End Using
        End Sub

        Public Sub ActualizarCiudad(ByVal Ciudad As Ciudades)
            Using bd As New CVEntities
                bd.Entry(Ciudad).State = EntityState.Modified
                bd.SaveChanges()
            End Using
        End Sub

        Public Sub EliminarCiudad(ByVal Ciudad As Ciudades)
            Using bd As New CVEntities
                bd.Entry(Ciudad).State = EntityState.Deleted
                bd.SaveChanges()
            End Using
        End Sub

    End Class

End Namespace

