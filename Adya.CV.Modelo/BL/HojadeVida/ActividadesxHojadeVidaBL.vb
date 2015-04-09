Imports Adya.CV.Modelo.Dao

Namespace BL

  Friend Class ActividadesxHojadeVidaBL

    Public Function ListarActividadesxHojadeVida() As List(Of ActividadesxHojadeVida)
      Try
        Dim dao As New ActividadesxHojadeVidaDao
        Return dao.ListarActividadesxHojadeVida
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Function

    Public Function ConsultarActividadxHojadeVidaxId(ByVal ActividadxHojadeVidaid As Integer) As ActividadesxHojadeVida
      Try
        Dim dao As New ActividadesxHojadeVidaDao
        Return dao.ConsultarActividadxHojadeVidaxId(ActividadxHojadeVidaid)
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Function

    Public Sub GuardarActividadxHojadeVida(ByVal ActividadxHojadeVida As ActividadesxHojadeVida)
      Try
        Dim dao As New ActividadesxHojadeVidaDao
        dao.GuardarActividadxHojadeVida(ActividadxHojadeVida)
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Sub

    Public Sub ActualizarActividadxHojadeVida(ByVal ActividadxHojadeVida As ActividadesxHojadeVida)
      Try
        Dim dao As New ActividadesxHojadeVidaDao
        dao.ActualizarActividadxHojadeVida(ActividadxHojadeVida)
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Sub

    Public Sub EliminarActividadxHojadeVida(ByVal ActividadxHojadeVidaId As Integer)
      Try
        Dim dao As New ActividadesxHojadeVidaDao
        Dim ActividadxHojadeVida = ConsultarActividadxHojadeVidaxId(ActividadxHojadeVidaId)
        dao.EliminarActividadxHojadeVida(ActividadxHojadeVida)
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Sub

  End Class

End Namespace


