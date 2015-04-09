Imports Adya.CV.Modelo.Dao.Inventario

Namespace BL.Inventario

    Friend Class IngresosBL

        Public Function ListarIngresos() As List(Of Ingresos)
            Try
                Dim dao As New IngresosDao
                Return dao.ListarIngresos
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Function

        Public Function ConsultarIngresoxId(ByVal Ingresoid As Integer) As Ingresos
            Try
                Dim dao As New IngresosDao
                Return dao.ConsultarIngresoxId(Ingresoid)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Function

        Public Sub GuardarIngreso(ByVal Ingreso As Ingresos)
            Try
                Dim dao As New IngresosDao
                dao.GuardarIngreso(Ingreso)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Sub

        Public Sub ActualizarIngreso(ByVal Ingreso As Ingresos)
            Try
                Dim dao As New IngresosDao
                dao.ActualizarIngreso(Ingreso)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Sub

        Public Sub EliminarIngreso(ByVal IngresoId As Integer)
            Try
                Dim dao As New IngresosDao
                Dim Ingreso = ConsultarIngresoxId(IngresoId)
                dao.EliminarIngreso(Ingreso)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Sub

    End Class

End Namespace



