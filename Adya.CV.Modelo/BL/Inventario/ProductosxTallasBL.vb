Imports Adya.CV.Modelo.Dao.Inventario

Namespace BL.Inventario

    Friend Class ProductosxTallasBL

        Public Function ListarProductosxTallas() As List(Of ProductosxTallas)
            Try
                Dim dao As New ProductosxTallasDao
                Return dao.ListarProductosxTallas
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Function

        Public Function ConsultarProductoxTallaxId(ByVal ProductoxTallaid As Integer) As ProductosxTallas
            Try
                Dim dao As New ProductosxTallasDao
                Return dao.ConsultarProductoxTallaxId(ProductoxTallaid)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Function

        Public Sub GuardarProductoxTalla(ByVal ProductoxTalla As ProductosxTallas)
            Try
                Dim dao As New ProductosxTallasDao
                dao.GuardarProductoxTalla(ProductoxTalla)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Sub

        Public Sub ActualizarProductoxTalla(ByVal ProductoxTalla As ProductosxTallas)
            Try
                Dim dao As New ProductosxTallasDao
                dao.ActualizarProductoxTalla(ProductoxTalla)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Sub

        Public Sub EliminarProductoxTalla(ByVal ProductoxTallaId As Integer)
            Try
                Dim dao As New ProductosxTallasDao
                Dim ProductoxTalla = ConsultarProductoxTallaxId(ProductoxTallaId)
                dao.EliminarProductoxTalla(ProductoxTalla)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Sub

    End Class

End Namespace



