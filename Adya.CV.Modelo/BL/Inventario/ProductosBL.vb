Imports Adya.CV.Modelo.Dao.Inventario

Namespace BL.Inventario

    Friend Class ProductosBL

        Public Function ListarProductos() As List(Of Productos)
            Try
                Dim dao As New ProductosDao
                Return dao.ListarProductos
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Function

        Public Function ConsultarProductoxId(ByVal Productoid As Integer) As Productos
            Try
                Dim dao As New ProductosDao
                Return dao.ConsultarProductoxId(Productoid)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Function

        Public Sub GuardarProducto(ByVal Producto As Productos)
            Try
                Dim dao As New ProductosDao
                dao.GuardarProducto(Producto)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Sub

        Public Sub ActualizarProducto(ByVal Producto As Productos)
            Try
                Dim dao As New ProductosDao
                dao.ActualizarProducto(Producto)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Sub

        Public Sub EliminarProducto(ByVal ProductoId As Integer)
            Try
                Dim dao As New ProductosDao
                Dim Producto = ConsultarProductoxId(ProductoId)
                dao.EliminarProducto(Producto)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Sub

    End Class

End Namespace



