Imports Adya.CV.Modelo.Dao

Namespace BL

  Friend Class HojadeVidasBL

    Public Function ListarHojadeVidas() As List(Of HojadeVidas)
      Try
        Dim dao As New HojadeVidasDao
        Return dao.ListarHojadeVidas
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Function

    Public Function ConsultarHojadeVidaxId(ByVal HojadeVidaid As Integer) As HojadeVidas
      Try
        Dim dao As New HojadeVidasDao
        Return dao.ConsultarHojadeVidaxId(HojadeVidaid)
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Function

    Public Sub GuardarHojadeVida(ByVal HojadeVida As HojadeVidas)
      Try
        Dim dao As New HojadeVidasDao
        dao.GuardarHojadeVida(HojadeVida)
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Sub

    Public Sub ActualizarHojadeVida(ByVal HojadeVida As HojadeVidas)
      Try
        Dim dao As New HojadeVidasDao
        dao.ActualizarHojadeVida(HojadeVida)
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Sub

    Public Sub EliminarHojadeVida(ByVal HojadeVidaId As Integer)
      Try
        Dim dao As New HojadeVidasDao
        Dim HojadeVida = ConsultarHojadeVidaxId(HojadeVidaId)
        dao.EliminarHojadeVida(HojadeVida)
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Sub

  End Class

End Namespace



