Imports Adya.CV.Modelo.Dao

Namespace BL

    Friend Class InformacionFamiliaresBL

        Public Function ListarInformacionFamiliares() As List(Of InformacionFamiliares)
            Try
                Dim dao As New InformacionFamiliaresDao
                Return dao.ListarInformacionFamiliares
            Catch ex As Exception
        Throw New Exception(ex.Message)
            End Try
        End Function

        Public Function ConsultarInformacionFamiliarxId(ByVal InformacionFamiliarid As Integer) As InformacionFamiliares
            Try
                Dim dao As New InformacionFamiliaresDao
                Return dao.ConsultarInformacionFamiliarxId(InformacionFamiliarid)
            Catch ex As Exception
        Throw New Exception(ex.Message)
            End Try
        End Function

        Public Sub GuardarInformacionFamiliar(ByVal InformacionFamiliar As InformacionFamiliares)
            Try
                Dim dao As New InformacionFamiliaresDao
                dao.GuardarInformacionFamiliar(InformacionFamiliar)
            Catch ex As Exception
        Throw New Exception(ex.Message)
            End Try
        End Sub

        Public Sub ActualizarInformacionFamiliar(ByVal InformacionFamiliar As InformacionFamiliares)
            Try
                Dim dao As New InformacionFamiliaresDao
                dao.ActualizarInformacionFamiliar(InformacionFamiliar)
            Catch ex As Exception
        Throw New Exception(ex.Message)
            End Try
        End Sub

        Public Sub EliminarInformacionFamiliar(ByVal InformacionFamiliarId As Integer)
            Try
                Dim dao As New InformacionFamiliaresDao
                Dim InformacionFamiliar = ConsultarInformacionFamiliarxId(InformacionFamiliarId)
                dao.EliminarInformacionFamiliar(InformacionFamiliar)
            Catch ex As Exception
        Throw New Exception(ex.Message)
            End Try
        End Sub

    End Class

End Namespace


