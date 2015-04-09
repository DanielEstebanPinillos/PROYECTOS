Imports Adya.CV.Modelo.Dao.Inventario

Namespace BL.Inventario

    Friend Class DetalleIngresosBL

        Public Function ListarDetalleIngresos() As List(Of DetalleIngresos)
            Try
                Dim dao As New DetalleIngresosDao
                Return dao.ListarDetalleIngresos
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Function

        Public Function ConsultarDetalleIngresoxId(ByVal DetalleIngresoid As Integer) As DetalleIngresos
            Try
                Dim dao As New DetalleIngresosDao
                Return dao.ConsultarDetalleIngresoxId(DetalleIngresoid)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Function

        Public Sub GuardarDetalleIngreso(ByVal DetalleIngreso As DetalleIngresos)
            Try
                Dim dao As New DetalleIngresosDao
                dao.GuardarDetalleIngreso(DetalleIngreso)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Sub

        Public Sub ActualizarDetalleIngreso(ByVal DetalleIngreso As DetalleIngresos)
            Try
                Dim dao As New DetalleIngresosDao
                dao.ActualizarDetalleIngreso(DetalleIngreso)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Sub

        Public Sub EliminarDetalleIngreso(ByVal DetalleIngresoId As Integer)
            Try
                Dim dao As New DetalleIngresosDao
                Dim DetalleIngreso = ConsultarDetalleIngresoxId(DetalleIngresoId)
                dao.EliminarDetalleIngreso(DetalleIngreso)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Sub

    End Class

End Namespace



