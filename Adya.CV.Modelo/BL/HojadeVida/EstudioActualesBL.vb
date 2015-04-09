Imports Adya.CV.Modelo.Dao

Namespace BL

    Friend Class EstudioActualesBL

        Public Function ListarEstudioActuales() As List(Of EstudioActuales)
            Try
                Dim dao As New EstudioActualesDao
                Return dao.ListarEstudioActuales
            Catch ex As Exception
        Throw New Exception(ex.Message)
            End Try
        End Function

        Public Function ConsultarEstudioActualxId(ByVal EstudioActualid As Integer) As EstudioActuales
            Try
                Dim dao As New EstudioActualesDao
                Return dao.ConsultarEstudioActualxId(EstudioActualid)
            Catch ex As Exception
        Throw New Exception(ex.Message)
            End Try
        End Function

        Public Sub GuardarEstudioActual(ByVal EstudioActual As EstudioActuales)
            Try
                Dim dao As New EstudioActualesDao
                dao.GuardarEstudioActual(EstudioActual)
            Catch ex As Exception
        Throw New Exception(ex.Message)
            End Try
        End Sub

        Public Sub ActualizarEstudioActual(ByVal EstudioActual As EstudioActuales)
            Try
                Dim dao As New EstudioActualesDao
                dao.ActualizarEstudioActual(EstudioActual)
            Catch ex As Exception
        Throw New Exception(ex.Message)
            End Try
        End Sub

        Public Sub EliminarEstudioActual(ByVal EstudioActualId As Integer)
            Try
                Dim dao As New EstudioActualesDao
                Dim EstudioActual = ConsultarEstudioActualxId(EstudioActualId)
                dao.EliminarEstudioActual(EstudioActual)
            Catch ex As Exception
        Throw New Exception(ex.Message)
            End Try
        End Sub

    End Class

End Namespace


