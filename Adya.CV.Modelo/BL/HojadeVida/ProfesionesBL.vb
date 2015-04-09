Imports Adya.CV.Modelo.Dao

Namespace BL

    Friend Class ProfesionesBL

        Public Function ListarProfesiones() As List(Of Profesiones)
            Try
                Dim dao As New ProfesionesDao
                Return dao.ListarProfesiones
            Catch ex As Exception
        Throw New Exception(ex.Message)
            End Try
        End Function

        Public Function ConsultarProfesionxId(ByVal Profesionid As Integer) As Profesiones
            Try
                Dim dao As New ProfesionesDao
                Return dao.ConsultarProfesionxId(Profesionid)
            Catch ex As Exception
        Throw New Exception(ex.Message)
            End Try
        End Function

        Public Sub GuardarProfesion(ByVal Profesion As Profesiones)
            Try
                Dim dao As New ProfesionesDao
                dao.GuardarProfesion(Profesion)
            Catch ex As Exception
        Throw New Exception(ex.Message)
            End Try
        End Sub

        Public Sub ActualizarProfesion(ByVal Profesion As Profesiones)
            Try
                Dim dao As New ProfesionesDao
                dao.ActualizarProfesion(Profesion)
            Catch ex As Exception
        Throw New Exception(ex.Message)
            End Try
        End Sub

        Public Sub EliminarProfesion(ByVal ProfesionId As Integer)
            Try
                Dim dao As New ProfesionesDao
                Dim Profesion = ConsultarProfesionxId(ProfesionId)
                dao.EliminarProfesion(Profesion)
            Catch ex As Exception
        Throw New Exception(ex.Message)
            End Try
        End Sub

    End Class

End Namespace


