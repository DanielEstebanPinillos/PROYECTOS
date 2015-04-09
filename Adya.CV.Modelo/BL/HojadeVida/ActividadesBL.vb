Imports Adya.CV.Modelo.Dao

Namespace BL

  Friend Class ActividadesBL

    Public Function ListarActividades() As List(Of Actividades)
      Try
        Dim dao As New ActividadesDao
        Return dao.ListarActividades
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Function

    Public Function ConsultarActividadxId(ByVal Actividadid As Integer) As Actividades
      Try
        Dim dao As New ActividadesDao
        Return dao.ConsultarActividadxId(Actividadid)
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Function

    Public Sub GuardarActividad(ByVal Actividad As Actividades)
      Try
        Dim dao As New ActividadesDao
        dao.GuardarActividad(Actividad)
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Sub

    Public Sub ActualizarActividad(ByVal Actividad As Actividades)
      Try
        Dim dao As New ActividadesDao
        dao.ActualizarActividad(Actividad)
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Sub

    Public Sub EliminarActividad(ByVal ActividadId As Integer)
      Try
        Dim dao As New ActividadesDao
        Dim Actividad = ConsultarActividadxId(ActividadId)
        dao.EliminarActividad(Actividad)
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Sub

  End Class

End Namespace


