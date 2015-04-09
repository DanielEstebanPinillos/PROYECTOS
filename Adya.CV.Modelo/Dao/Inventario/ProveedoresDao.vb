Namespace Dao.Inventario

    Friend Class ProveedoresDao

        Public Function ListarProveedores() As List(Of Proveedores)
            Using bd As New CVEntities
                Dim query = From tbl In bd.Proveedores
                            Select tbl
                Return query.ToList
            End Using
        End Function

        Public Function ConsultarProveedorxId(ByVal Proveedorid As Integer) As Proveedores
            Using bd As New CVEntities
                Dim query = From tbl In bd.Proveedores
                            Where tbl.ProveedorId = Proveedorid
                            Select tbl
                Return query.FirstOrDefault
            End Using
        End Function

        Public Sub GuardarProveedor(ByVal Proveedor As Proveedores)
            Using bd As New CVEntities
                bd.Entry(Proveedor).State = EntityState.Added
                bd.SaveChanges()
            End Using
        End Sub

        Public Sub ActualizarProveedor(ByVal Proveedor As Proveedores)
            Using bd As New CVEntities
                bd.Entry(Proveedor).State = EntityState.Modified
                bd.SaveChanges()
            End Using
        End Sub

        Public Sub EliminarProveedor(ByVal Proveedor As Proveedores)
            Using bd As New CVEntities
                bd.Entry(Proveedor).State = EntityState.Deleted
                bd.SaveChanges()
            End Using
        End Sub

    End Class

End Namespace


