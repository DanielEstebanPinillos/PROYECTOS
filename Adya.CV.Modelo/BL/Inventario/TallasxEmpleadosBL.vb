Imports Adya.CV.Modelo.Dao.Inventario

Namespace BL.Inventario

    Friend Class TallasxEmpleadosBL

        Public Function ListarTallasxEmpleados() As List(Of TallasxEmpleados)
            Try
                Dim dao As New TallasxEmpleadosDao
                Return dao.ListarTallasxEmpleados
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Function

        Public Function ConsultarTallaxEmpleadoxId(ByVal TallaxEmpleadoid As Integer) As TallasxEmpleados
            Try
                Dim dao As New TallasxEmpleadosDao
                Return dao.ConsultarTallaxEmpleadoxId(TallaxEmpleadoid)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Function

        Public Sub GuardarTallaxEmpleado(ByVal TallaxEmpleado As TallasxEmpleados)
            Try
                Dim dao As New TallasxEmpleadosDao
                dao.GuardarTallaxEmpleado(TallaxEmpleado)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Sub

        Public Sub ActualizarTallaxEmpleado(ByVal TallaxEmpleado As TallasxEmpleados)
            Try
                Dim dao As New TallasxEmpleadosDao
                dao.ActualizarTallaxEmpleado(TallaxEmpleado)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Sub

        Public Sub EliminarTallaxEmpleado(ByVal TallaxEmpleadoId As Integer)
            Try
                Dim dao As New TallasxEmpleadosDao
                Dim TallaxEmpleado = ConsultarTallaxEmpleadoxId(TallaxEmpleadoId)
                dao.EliminarTallaxEmpleado(TallaxEmpleado)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Sub

    End Class

End Namespace



