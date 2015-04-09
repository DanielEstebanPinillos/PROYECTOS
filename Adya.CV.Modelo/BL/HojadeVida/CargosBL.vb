Imports Adya.CV.Modelo.Dao

Namespace BL

    Friend Class CargosBL

        Public Function ListarCargos() As List(Of Cargos)
            Try
                Dim dao As New CargosDao
                Return dao.ListarCargos
            Catch ex As Exception
        Throw New Exception(ex.Message)
            End Try
        End Function

        Public Function ConsultarCargoxId(ByVal Cargoid As Integer) As Cargos
            Try
                Dim dao As New CargosDao
                Return dao.ConsultarCargoxId(Cargoid)
            Catch ex As Exception
        Throw New Exception(ex.Message)
            End Try
        End Function

        Public Sub GuardarCargo(ByVal Cargo As Cargos)
            Try
                Dim dao As New CargosDao
                dao.GuardarCargo(Cargo)
            Catch ex As Exception
        Throw New Exception(ex.Message)
            End Try
        End Sub

        Public Sub ActualizarCargo(ByVal Cargo As Cargos)
            Try
                Dim dao As New CargosDao
                dao.ActualizarCargo(Cargo)
            Catch ex As Exception
        Throw New Exception(ex.Message)
            End Try
        End Sub

        Public Sub EliminarCargo(ByVal CargoId As Integer)
            Try
                Dim dao As New CargosDao
                Dim Cargo = ConsultarCargoxId(CargoId)
                dao.EliminarCargo(Cargo)
            Catch ex As Exception
        Throw New Exception(ex.Message)
            End Try
        End Sub

    End Class

End Namespace


