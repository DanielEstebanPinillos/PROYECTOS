Namespace Dao.Inventario

    Friend Class ProductosxEmpleadosDao

        Public Function ListarProductosxEmpleados() As List(Of ProductosxEmpleados)
            Using bd As New CVEntities
                Dim query = From tbl In bd.ProductosxEmpleados
                            Select tbl
                Return query.ToList
            End Using
        End Function

        Public Function ConsultarProductoxEmpleadoxId(ByVal ProductoxEmpleadoid As Integer) As ProductosxEmpleados
            Using bd As New CVEntities
                Dim query = From tbl In bd.ProductosxEmpleados
                            Where tbl.ProductoxEmpleadoId = ProductoxEmpleadoid
                            Select tbl
                Return query.FirstOrDefault
            End Using
        End Function

        Public Sub GuardarProductoxEmpleado(ByVal ProductoxEmpleado As ProductosxEmpleados)
            Using bd As New CVEntities
                bd.Entry(ProductoxEmpleado).State = EntityState.Added
                bd.SaveChanges()
            End Using
        End Sub

        Public Sub ActualizarProductoxEmpleado(ByVal ProductoxEmpleado As ProductosxEmpleados)
            Using bd As New CVEntities
                bd.Entry(ProductoxEmpleado).State = EntityState.Modified
                bd.SaveChanges()
            End Using
        End Sub

        Public Sub EliminarProductoxEmpleado(ByVal ProductoxEmpleado As ProductosxEmpleados)
            Using bd As New CVEntities
                bd.Entry(ProductoxEmpleado).State = EntityState.Deleted
                bd.SaveChanges()
            End Using
        End Sub

    End Class

End Namespace


