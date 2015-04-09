Imports Adya.CV.Modelo.Dao

Namespace BL

    Friend Class SeguridadesSocialesBL

        Public Function ListarSeguridadesSociales() As List(Of SeguridadesSociales)
            Try
                Dim dao As New SeguridadesSocialesDao
                Return dao.ListarSeguridadesSociales
            Catch ex As Exception
        Throw New Exception(ex.Message)
            End Try
        End Function

        Public Function ConsultarSeguridadesSocialxId(ByVal SeguridadesSocialid As Integer) As SeguridadesSociales
            Try
                Dim dao As New SeguridadesSocialesDao
                Return dao.ConsultarSeguridadesSocialxId(SeguridadesSocialid)
            Catch ex As Exception
        Throw New Exception(ex.Message)
            End Try
        End Function

        Public Sub GuardarSeguridadesSocial(ByVal SeguridadesSocial As SeguridadesSociales)
            Try
                Dim dao As New SeguridadesSocialesDao
                dao.GuardarSeguridadesSocial(SeguridadesSocial)
            Catch ex As Exception
        Throw New Exception(ex.Message)
            End Try
        End Sub

        Public Sub ActualizarSeguridadesSocial(ByVal SeguridadesSocial As SeguridadesSociales)
            Try
                Dim dao As New SeguridadesSocialesDao
                dao.ActualizarSeguridadesSocial(SeguridadesSocial)
            Catch ex As Exception
        Throw New Exception(ex.Message)
            End Try
        End Sub

        Public Sub EliminarSeguridadesSocial(ByVal SeguridadesSocialId As Integer)
            Try
                Dim dao As New SeguridadesSocialesDao
                Dim SeguridadesSocial = ConsultarSeguridadesSocialxId(SeguridadesSocialId)
                dao.EliminarSeguridadesSocial(SeguridadesSocial)
            Catch ex As Exception
        Throw New Exception(ex.Message)
            End Try
        End Sub

    End Class

End Namespace


