Namespace Dao

    Friend Class InformacionFamiliaresDao

        Public Function ListarInformacionFamiliares() As List(Of InformacionFamiliares)
            Using bd As New CVEntities
                Dim query = From tbl In bd.InformacionFamiliares
                            Select tbl
                Return query.ToList
            End Using
        End Function

        Public Function ConsultarInformacionFamiliarxId(ByVal InformacionFamiliarid As Integer) As InformacionFamiliares
            Using bd As New CVEntities
                Dim query = From tbl In bd.InformacionFamiliares
                            Where tbl.InformacionFamiliarId = InformacionFamiliarid
                            Select tbl
                Return query.FirstOrDefault
            End Using
        End Function

        Public Sub GuardarInformacionFamiliar(ByVal InformacionFamiliar As InformacionFamiliares)
            Using bd As New CVEntities
                bd.Entry(InformacionFamiliar).State = EntityState.Added
                bd.SaveChanges()
            End Using
        End Sub

        Public Sub ActualizarInformacionFamiliar(ByVal InformacionFamiliar As InformacionFamiliares)
            Using bd As New CVEntities
                bd.Entry(InformacionFamiliar).State = EntityState.Modified
                bd.SaveChanges()
            End Using
        End Sub

        Public Sub EliminarInformacionFamiliar(ByVal InformacionFamiliar As InformacionFamiliares)
            Using bd As New CVEntities
                bd.Entry(InformacionFamiliar).State = EntityState.Deleted
                bd.SaveChanges()
            End Using
        End Sub

    End Class

End Namespace


