Imports Adya.CV.Modelo.Dao.Inventario

Namespace BL.Inventario

    Friend Class ProductosxEmpleadosBL

        Public Function ListarProductosxEmpleados() As List(Of ProductosxEmpleados)
            Try
                Dim dao As New ProductosxEmpleadosDao
                Return dao.ListarProductosxEmpleados
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Function

        Public Function ConsultarProductoxEmpleadoxId(ByVal ProductoxEmpleadoid As Integer) As ProductosxEmpleados
            Try
                Dim dao As New ProductosxEmpleadosDao
                Return dao.ConsultarProductoxEmpleadoxId(ProductoxEmpleadoid)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Function

        Public Sub GuardarProductoxEmpleado(ByVal ProductoxEmpleado As ProductosxEmpleados)
            Try
                Dim dao As New ProductosxEmpleadosDao
                dao.GuardarProductoxEmpleado(ProductoxEmpleado)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Sub

        Public Sub ActualizarProductoxEmpleado(ByVal ProductoxEmpleado As ProductosxEmpleados)
            Try
                Dim dao As New ProductosxEmpleadosDao
                dao.ActualizarProductoxEmpleado(ProductoxEmpleado)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Sub

        Public Sub EliminarProductoxEmpleado(ByVal ProductoxEmpleadoId As Integer)
            Try
                Dim dao As New ProductosxEmpleadosDao
                Dim ProductoxEmpleado = ConsultarProductoxEmpleadoxId(ProductoxEmpleadoId)
                dao.EliminarProductoxEmpleado(ProductoxEmpleado)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Sub

    End Class

End Namespace



