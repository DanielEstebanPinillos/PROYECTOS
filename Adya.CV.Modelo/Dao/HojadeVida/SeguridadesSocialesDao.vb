Namespace Dao

    Friend Class SeguridadesSocialesDao

        Public Function ListarSeguridadesSociales() As List(Of SeguridadesSociales)
            Using bd As New CVEntities
                Dim query = From tbl In bd.SeguridadesSociales
                            Select tbl
                Return query.ToList
            End Using
        End Function

        Public Function ConsultarSeguridadesSocialxId(ByVal SeguridadesSocialid As Integer) As SeguridadesSociales
            Using bd As New CVEntities
                Dim query = From tbl In bd.SeguridadesSociales
                            Where tbl.SeguridadSocialId = SeguridadesSocialid
                            Select tbl
                Return query.FirstOrDefault
            End Using
        End Function

        Public Sub GuardarSeguridadesSocial(ByVal SeguridadesSocial As SeguridadesSociales)
            Using bd As New CVEntities
                bd.Entry(SeguridadesSocial).State = EntityState.Added
                bd.SaveChanges()
            End Using
        End Sub

        Public Sub ActualizarSeguridadesSocial(ByVal SeguridadesSocial As SeguridadesSociales)
            Using bd As New CVEntities
                bd.Entry(SeguridadesSocial).State = EntityState.Modified
                bd.SaveChanges()
            End Using
        End Sub

        Public Sub EliminarSeguridadesSocial(ByVal SeguridadesSocial As SeguridadesSociales)
            Using bd As New CVEntities
                bd.Entry(SeguridadesSocial).State = EntityState.Deleted
                bd.SaveChanges()
            End Using
        End Sub

    End Class

End Namespace

