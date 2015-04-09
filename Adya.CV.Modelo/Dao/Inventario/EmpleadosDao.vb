Namespace Dao.Inventario

    Friend Class EmpleadosDao

        Public Function ListarEmpleados() As List(Of Empleados)
            Using bd As New CVEntities
                Dim query = From tbl In bd.Empleados
                            Select tbl
                Return query.ToList
            End Using
        End Function

        Public Function ConsultarEmpleadoxId(ByVal Empleadoid As Integer) As Empleados
            Using bd As New CVEntities
                Dim query = From tbl In bd.Empleados
                            Where tbl.EmpleadoId = Empleadoid
                            Select tbl
                Return query.FirstOrDefault
            End Using
        End Function

        Public Sub GuardarEmpleado(ByVal Empleado As Empleados)
            Using bd As New CVEntities
                bd.Entry(Empleado).State = EntityState.Added
                bd.SaveChanges()
            End Using
        End Sub

        Public Sub ActualizarEmpleado(ByVal Empleado As Empleados)
            Using bd As New CVEntities
                bd.Entry(Empleado).State = EntityState.Modified
                bd.SaveChanges()
            End Using
        End Sub

        Public Sub EliminarEmpleado(ByVal Empleado As Empleados)
            Using bd As New CVEntities
                bd.Entry(Empleado).State = EntityState.Deleted
                bd.SaveChanges()
            End Using
        End Sub

    End Class

End Namespace


