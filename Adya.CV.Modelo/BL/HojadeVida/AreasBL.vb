Imports Adya.CV.Modelo.Dao

Namespace BL

    Friend Class AreasBL

        Public Function ListarAreas() As List(Of Areas)
            Try
                Dim dao As New AreasDao
                Return dao.ListarAreas
            Catch ex As Exception
        Throw New Exception(ex.Message)
            End Try
        End Function

        Public Function ConsultarAreaxId(ByVal Areaid As Integer) As Areas
            Try
                Dim dao As New AreasDao
                Return dao.ConsultarAreaxId(Areaid)
            Catch ex As Exception
        Throw New Exception(ex.Message)
            End Try
        End Function

        Public Sub GuardarArea(ByVal Area As Areas)
            Try
                Dim dao As New AreasDao
                dao.GuardarArea(Area)
            Catch ex As Exception
        Throw New Exception(ex.Message)
            End Try
        End Sub

        Public Sub ActualizarArea(ByVal Area As Areas)
            Try
                Dim dao As New AreasDao
                dao.ActualizarArea(Area)
            Catch ex As Exception
        Throw New Exception(ex.Message)
            End Try
        End Sub

        Public Sub EliminarArea(ByVal AreaId As Integer)
            Try
                Dim dao As New AreasDao
                Dim Area = ConsultarAreaxId(AreaId)
                dao.EliminarArea(Area)
            Catch ex As Exception
        Throw New Exception(ex.Message)
            End Try
        End Sub

    End Class

End Namespace


