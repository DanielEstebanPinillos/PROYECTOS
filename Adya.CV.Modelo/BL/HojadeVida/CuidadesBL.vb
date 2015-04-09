Imports Adya.CV.Modelo.Dao

Namespace BL

    Friend Class CiudadesBL

        Public Function ListarCiudades() As List(Of Ciudades)
            Try
                Dim dao As New CiudadesDao
                Return dao.ListarCiudades
            Catch ex As Exception
        Throw New Exception(ex.Message)
            End Try
        End Function

        Public Function ConsultarCiudadxId(ByVal Ciudadid As Integer) As Ciudades
            Try
                Dim dao As New CiudadesDao
                Return dao.ConsultarCiudadxId(Ciudadid)
            Catch ex As Exception
        Throw New Exception(ex.Message)
            End Try
        End Function

        Public Sub GuardarCiudad(ByVal Ciudad As Ciudades)
            Try
                Dim dao As New CiudadesDao
                dao.GuardarCiudad(Ciudad)
            Catch ex As Exception
        Throw New Exception(ex.Message)
            End Try
        End Sub

        Public Sub ActualizarCiudad(ByVal Ciudad As Ciudades)
            Try
                Dim dao As New CiudadesDao
                dao.ActualizarCiudad(Ciudad)
            Catch ex As Exception
        Throw New Exception(ex.Message)
            End Try
        End Sub

        Public Sub EliminarCiudad(ByVal CiudadId As Integer)
            Try
                Dim dao As New CiudadesDao
                Dim Ciudad = ConsultarCiudadxId(CiudadId)
                dao.EliminarCiudad(Ciudad)
            Catch ex As Exception
        Throw New Exception(ex.Message)
            End Try
        End Sub

    End Class

End Namespace


