Imports Adya.CV.Modelo.Dao.Inventario

Namespace BL.Inventario

  Friend Class TallasBL

    Public Function ListarTallas() As List(Of Tallas)
      Try
        Dim dao As New TallasDao
        Return dao.ListarTallas
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Function

    Public Function ConsultarTallaxId(ByVal Tallaid As Integer) As Tallas
      Try
        Dim dao As New TallasDao
        Return dao.ConsultarTallaxId(Tallaid)
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Function

    Public Sub GuardarTalla(ByVal Talla As Tallas)
      Try
        Dim dao As New TallasDao
        dao.GuardarTalla(Talla)
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Sub

    Public Sub ActualizarTalla(ByVal Talla As Tallas)
      Try
        Dim dao As New TallasDao
        dao.ActualizarTalla(Talla)
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Sub

    Public Sub EliminarTalla(ByVal TallaId As Integer)
      Try
        Dim dao As New TallasDao
        Dim Talla = ConsultarTallaxId(TallaId)
        dao.EliminarTalla(Talla)
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Sub

  End Class

End Namespace



