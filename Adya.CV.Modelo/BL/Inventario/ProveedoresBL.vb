Imports Adya.CV.Modelo.Dao.Inventario

Namespace BL.Inventario

    Friend Class ProveedoresBL

        Public Function ListarProveedores() As List(Of Proveedores)
            Try
                Dim dao As New ProveedoresDao
                Return dao.ListarProveedores
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Function

        Public Function ConsultarProveedorxId(ByVal Proveedorid As Integer) As Proveedores
            Try
                Dim dao As New ProveedoresDao
                Return dao.ConsultarProveedorxId(Proveedorid)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Function

        Public Sub GuardarProveedor(ByVal Proveedor As Proveedores)
            Try
                Dim dao As New ProveedoresDao
                dao.GuardarProveedor(Proveedor)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Sub

        Public Sub ActualizarProveedor(ByVal Proveedor As Proveedores)
            Try
                Dim dao As New ProveedoresDao
                dao.ActualizarProveedor(Proveedor)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Sub

        Public Sub EliminarProveedor(ByVal ProveedorId As Integer)
            Try
                Dim dao As New ProveedoresDao
                Dim Proveedor = ConsultarProveedorxId(ProveedorId)
                dao.EliminarProveedor(Proveedor)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Sub

    End Class

End Namespace



