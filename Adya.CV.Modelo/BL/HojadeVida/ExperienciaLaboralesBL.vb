Imports Adya.CV.Modelo.Dao

Namespace BL

    Friend Class ExperienciaLaboralesBL

        Public Function ListarExperienciaLaborales() As List(Of ExperienciaLaborales)
            Try
                Dim dao As New ExperienciaLaboralesDao
                Return dao.ListarExperienciaLaborales
            Catch ex As Exception
        Throw New Exception(ex.Message)
            End Try
        End Function

        Public Function ConsultarExperienciaLaboralxId(ByVal ExperienciaLaboralid As Integer) As ExperienciaLaborales
            Try
                Dim dao As New ExperienciaLaboralesDao
                Return dao.ConsultarExperienciaLaboralxId(ExperienciaLaboralid)
            Catch ex As Exception
        Throw New Exception(ex.Message)
            End Try
        End Function

        Public Sub GuardarExperienciaLaboral(ByVal ExperienciaLaboral As ExperienciaLaborales)
            Try
                Dim dao As New ExperienciaLaboralesDao
                dao.GuardarExperienciaLaboral(ExperienciaLaboral)
            Catch ex As Exception
        Throw New Exception(ex.Message)
            End Try
        End Sub

        Public Sub ActualizarExperienciaLaboral(ByVal ExperienciaLaboral As ExperienciaLaborales)
            Try
                Dim dao As New ExperienciaLaboralesDao
                dao.ActualizarExperienciaLaboral(ExperienciaLaboral)
            Catch ex As Exception
        Throw New Exception(ex.Message)
            End Try
        End Sub

        Public Sub EliminarExperienciaLaboral(ByVal ExperienciaLaboralId As Integer)
            Try
                Dim dao As New ExperienciaLaboralesDao
                Dim ExperienciaLaboral = ConsultarExperienciaLaboralxId(ExperienciaLaboralId)
                dao.EliminarExperienciaLaboral(ExperienciaLaboral)
            Catch ex As Exception
        Throw New Exception(ex.Message)
            End Try
        End Sub

    End Class

End Namespace


