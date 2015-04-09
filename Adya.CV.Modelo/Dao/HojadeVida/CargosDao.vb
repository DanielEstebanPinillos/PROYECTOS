Namespace Dao

    Friend Class CargosDao

        Public Function ListarCargos() As List(Of Cargos)
            Using bd As New CVEntities
                Dim query = From tbl In bd.Cargos
                            Select tbl
                Return query.ToList
            End Using
        End Function

        Public Function ConsultarCargoxId(ByVal Cargoid As Integer) As Cargos
            Using bd As New CVEntities
                Dim query = From tbl In bd.Cargos
                            Where tbl.CargoId = Cargoid
                            Select tbl
                Return query.FirstOrDefault
            End Using
        End Function

        Public Sub GuardarCargo(ByVal Cargo As Cargos)
            Using bd As New CVEntities
                bd.Entry(Cargo).State = EntityState.Added
                bd.SaveChanges()
            End Using
        End Sub

        Public Sub ActualizarCargo(ByVal Cargo As Cargos)
            Using bd As New CVEntities
                bd.Entry(Cargo).State = EntityState.Modified
                bd.SaveChanges()
            End Using
        End Sub

        Public Sub EliminarCargo(ByVal Cargo As Cargos)
            Using bd As New CVEntities
                bd.Entry(Cargo).State = EntityState.Deleted
                bd.SaveChanges()
            End Using
        End Sub

    End Class

End Namespace

