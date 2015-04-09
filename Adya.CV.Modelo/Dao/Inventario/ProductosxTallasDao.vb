Namespace Dao.Inventario

    Friend Class ProductosxTallasDao

        Public Function ListarProductosxTallas() As List(Of ProductosxTallas)
            Using bd As New CVEntities
                Dim query = From tbl In bd.ProductosxTallas
                            Select tbl
                Return query.ToList
            End Using
        End Function

        Public Function ConsultarProductoxTallaxId(ByVal ProductoxTallaid As Integer) As ProductosxTallas
            Using bd As New CVEntities
                Dim query = From tbl In bd.ProductosxTallas
                            Where tbl.ProductoxTallaId = ProductoxTallaid
                            Select tbl
                Return query.FirstOrDefault
            End Using
        End Function

        Public Sub GuardarProductoxTalla(ByVal ProductoxTalla As ProductosxTallas)
            Using bd As New CVEntities
                bd.Entry(ProductoxTalla).State = EntityState.Added
                bd.SaveChanges()
            End Using
        End Sub

        Public Sub ActualizarProductoxTalla(ByVal ProductoxTalla As ProductosxTallas)
            Using bd As New CVEntities
                bd.Entry(ProductoxTalla).State = EntityState.Modified
                bd.SaveChanges()
            End Using
        End Sub

        Public Sub EliminarProductoxTalla(ByVal ProductoxTalla As ProductosxTallas)
            Using bd As New CVEntities
                bd.Entry(ProductoxTalla).State = EntityState.Deleted
                bd.SaveChanges()
            End Using
        End Sub

    End Class

End Namespace


