Imports Adya.CV.Modelo.Dao

Namespace BL

    Friend Class NacionalidadesBL

        Public Function ListarNacionalidades() As List(Of Nacionalidades)
            Try
                Dim dao As New NacionalidadesDao
                Return dao.ListarNacionalidades
            Catch ex As Exception
        Throw New Exception(ex.Message)
            End Try
        End Function

        Public Function ConsultarNacionalidadxId(ByVal Nacionalidadid As Integer) As Nacionalidades
            Try
                Dim dao As New NacionalidadesDao
                Return dao.ConsultarNacionalidadxId(Nacionalidadid)
            Catch ex As Exception
        Throw New Exception(ex.Message)
            End Try
        End Function

        Public Sub GuardarNacionalidad(ByVal Nacionalidad As Nacionalidades)
            Try
                Dim dao As New NacionalidadesDao
                dao.GuardarNacionalidad(Nacionalidad)
            Catch ex As Exception
        Throw New Exception(ex.Message)
            End Try
        End Sub

        Public Sub ActualizarNacionalidad(ByVal Nacionalidad As Nacionalidades)
            Try
                Dim dao As New NacionalidadesDao
                dao.ActualizarNacionalidad(Nacionalidad)
            Catch ex As Exception
        Throw New Exception(ex.Message)
            End Try
        End Sub

        Public Sub EliminarNacionalidad(ByVal NacionalidadId As Integer)
            Try
                Dim dao As New NacionalidadesDao
                Dim Nacionalidad = ConsultarNacionalidadxId(NacionalidadId)
                dao.EliminarNacionalidad(Nacionalidad)
            Catch ex As Exception
        Throw New Exception(ex.Message)
            End Try
        End Sub

    End Class

End Namespace


