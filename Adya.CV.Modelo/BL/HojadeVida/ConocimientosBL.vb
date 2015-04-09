Imports Adya.CV.Modelo.Dao

Namespace BL

    Friend Class ConocimientosBL

        Public Function ListarConocimientos() As List(Of Conocimientos)
            Try
                Dim dao As New ConocimientosDao
                Return dao.ListarConocimientos
            Catch ex As Exception
        Throw New Exception(ex.Message)
            End Try
        End Function

        Public Function ConsultarConocimientoxId(ByVal Conocimientoid As Integer) As Conocimientos
            Try
                Dim dao As New ConocimientosDao
                Return dao.ConsultarConocimientoxId(Conocimientoid)
            Catch ex As Exception
        Throw New Exception(ex.Message)
            End Try
        End Function

        Public Sub GuardarConocimiento(ByVal Conocimiento As Conocimientos)
            Try
                Dim dao As New ConocimientosDao
                dao.GuardarConocimiento(Conocimiento)
            Catch ex As Exception
        Throw New Exception(ex.Message)
            End Try
        End Sub

        Public Sub ActualizarConocimiento(ByVal Conocimiento As Conocimientos)
            Try
                Dim dao As New ConocimientosDao
                dao.ActualizarConocimiento(Conocimiento)
            Catch ex As Exception
        Throw New Exception(ex.Message)
            End Try
        End Sub

        Public Sub EliminarConocimiento(ByVal ConocimientoId As Integer)
            Try
                Dim dao As New ConocimientosDao
                Dim Conocimiento = ConsultarConocimientoxId(ConocimientoId)
                dao.EliminarConocimiento(Conocimiento)
            Catch ex As Exception
        Throw New Exception(ex.Message)
            End Try
        End Sub

    End Class

End Namespace


