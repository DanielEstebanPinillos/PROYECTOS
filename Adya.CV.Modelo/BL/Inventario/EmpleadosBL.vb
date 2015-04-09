Imports Adya.CV.Modelo.Dao.Inventario

Namespace BL.Inventario

    Friend Class EmpleadosBL

        Public Function ListarEmpleados() As List(Of Empleados)
            Try
                Dim dao As New EmpleadosDao
                Return dao.ListarEmpleados
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Function

        Public Function ConsultarEmpleadoxId(ByVal Empleadoid As Integer) As Empleados
            Try
                Dim dao As New EmpleadosDao
                Return dao.ConsultarEmpleadoxId(Empleadoid)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Function

        Public Sub GuardarEmpleado(ByVal Empleado As Empleados)
            Try
                Dim dao As New EmpleadosDao
                dao.GuardarEmpleado(Empleado)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Sub

        Public Sub ActualizarEmpleado(ByVal Empleado As Empleados)
            Try
                Dim dao As New EmpleadosDao
                dao.ActualizarEmpleado(Empleado)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Sub

        Public Sub EliminarEmpleado(ByVal EmpleadoId As Integer)
            Try
                Dim dao As New EmpleadosDao
                Dim Empleado = ConsultarEmpleadoxId(EmpleadoId)
                dao.EliminarEmpleado(Empleado)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Sub

    End Class

End Namespace



