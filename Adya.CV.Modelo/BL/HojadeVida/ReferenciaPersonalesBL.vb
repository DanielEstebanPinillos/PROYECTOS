Imports Adya.CV.Modelo.Dao

Namespace BL

    Friend Class ReferenciaPersonalesBL

        Public Function ListarReferenciaPersonales() As List(Of ReferenciaPersonales)
            Try
                Dim dao As New ReferenciaPersonalesDao
                Return dao.ListarReferenciaPersonales
            Catch ex As Exception
        Throw New Exception(ex.Message)
            End Try
        End Function

        Public Function ConsultarReferenciaPersonalxId(ByVal ReferenciaPersonalid As Integer) As ReferenciaPersonales
            Try
                Dim dao As New ReferenciaPersonalesDao
                Return dao.ConsultarReferenciaPersonalxId(ReferenciaPersonalid)
            Catch ex As Exception
        Throw New Exception(ex.Message)
            End Try
        End Function

        Public Sub GuardarReferenciaPersonal(ByVal ReferenciaPersonal As ReferenciaPersonales)
            Try
                Dim dao As New ReferenciaPersonalesDao
                dao.GuardarReferenciaPersonal(ReferenciaPersonal)
            Catch ex As Exception
        Throw New Exception(ex.Message)
            End Try
        End Sub

        Public Sub ActualizarReferenciaPersonal(ByVal ReferenciaPersonal As ReferenciaPersonales)
            Try
                Dim dao As New ReferenciaPersonalesDao
                dao.ActualizarReferenciaPersonal(ReferenciaPersonal)
            Catch ex As Exception
        Throw New Exception(ex.Message)
            End Try
        End Sub

        Public Sub EliminarReferenciaPersonal(ByVal ReferenciaPersonalId As Integer)
            Try
                Dim dao As New ReferenciaPersonalesDao
                Dim ReferenciaPersonal = ConsultarReferenciaPersonalxId(ReferenciaPersonalId)
                dao.EliminarReferenciaPersonal(ReferenciaPersonal)
            Catch ex As Exception
        Throw New Exception(ex.Message)
            End Try
        End Sub

    End Class

End Namespace


