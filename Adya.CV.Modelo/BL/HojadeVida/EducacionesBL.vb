Imports Adya.CV.Modelo.Dao

Namespace BL

    Friend Class EducacionesBL

        Public Function ListarEducaciones() As List(Of Educaciones)
            Try
                Dim dao As New EducacionesDao
                Return dao.ListarEducaciones
            Catch ex As Exception
        Throw New Exception(ex.Message)
            End Try
        End Function

        Public Function ConsultarEducacionxId(ByVal Educacionid As Integer) As Educaciones
            Try
                Dim dao As New EducacionesDao
                Return dao.ConsultarEducacionxId(Educacionid)
            Catch ex As Exception
        Throw New Exception(ex.Message)
            End Try
        End Function

        Public Sub GuardarEducacion(ByVal Educacion As Educaciones)
            Try
                Dim dao As New EducacionesDao
                dao.GuardarEducacion(Educacion)
            Catch ex As Exception
        Throw New Exception(ex.Message)
            End Try
        End Sub

        Public Sub ActualizarEducacion(ByVal Educacion As Educaciones)
            Try
                Dim dao As New EducacionesDao
                dao.ActualizarEducacion(Educacion)
            Catch ex As Exception
        Throw New Exception(ex.Message)
            End Try
        End Sub

        Public Sub EliminarEducacion(ByVal EducacionId As Integer)
            Try
                Dim dao As New EducacionesDao
                Dim Educacion = ConsultarEducacionxId(EducacionId)
                dao.EliminarEducacion(Educacion)
            Catch ex As Exception
        Throw New Exception(ex.Message)
            End Try
        End Sub

    End Class

End Namespace


