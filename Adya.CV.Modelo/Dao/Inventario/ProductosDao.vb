Namespace Dao.Inventario

    Friend Class ProductosDao

        Public Function ListarProductos() As List(Of Productos)
            Using bd As New CVEntities
                Dim query = From tbl In bd.Productos
                            Select tbl
                Return query.ToList
            End Using
        End Function

        Public Function ConsultarProductoxId(ByVal Productoid As Integer) As Productos
            Using bd As New CVEntities
                Dim query = From tbl In bd.Productos
                            Where tbl.ProductoId = Productoid
                            Select tbl
                Return query.FirstOrDefault
            End Using
        End Function

        Public Sub GuardarProducto(ByVal Producto As Productos)
            Using bd As New CVEntities
                bd.Entry(Producto).State = EntityState.Added
                bd.SaveChanges()
            End Using
        End Sub

        Public Sub ActualizarProducto(ByVal Producto As Productos)
            Using bd As New CVEntities
                bd.Entry(Producto).State = EntityState.Modified
                bd.SaveChanges()
            End Using
        End Sub

        Public Sub EliminarProducto(ByVal Producto As Productos)
            Using bd As New CVEntities
                bd.Entry(Producto).State = EntityState.Deleted
                bd.SaveChanges()
            End Using
        End Sub

    End Class

End Namespace


