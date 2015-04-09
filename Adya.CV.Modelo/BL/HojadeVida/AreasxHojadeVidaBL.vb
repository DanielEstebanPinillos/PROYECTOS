Imports Adya.CV.Modelo.Dao

Namespace BL

    Friend Class AreasxHojadeVidaBL

        Public Function ListarAreasxHojadeVida() As List(Of AreasxHojadeVida)
            Try
                Dim dao As New AreasxHojadeVidaDao
                Return dao.ListarAreasxHojadeVida
            Catch ex As Exception
        Throw New Exception(ex.Message)
            End Try
        End Function

        Public Function ConsultarAreaxHojadeVidaxId(ByVal AreaxHojadeVidaid As Integer) As AreasxHojadeVida
            Try
                Dim dao As New AreasxHojadeVidaDao
                Return dao.ConsultarAreaxHojadeVidaxId(AreaxHojadeVidaid)
            Catch ex As Exception
        Throw New Exception(ex.Message)
            End Try
        End Function

        Public Sub GuardarAreaxHojadeVida(ByVal AreaxHojadeVida As AreasxHojadeVida)
            Try
                Dim dao As New AreasxHojadeVidaDao
                dao.GuardarAreaxHojadeVida(AreaxHojadeVida)
            Catch ex As Exception
        Throw New Exception(ex.Message)
            End Try
        End Sub

        Public Sub ActualizarAreaxHojadeVida(ByVal AreaxHojadeVida As AreasxHojadeVida)
            Try
                Dim dao As New AreasxHojadeVidaDao
                dao.ActualizarAreaxHojadeVida(AreaxHojadeVida)
            Catch ex As Exception
        Throw New Exception(ex.Message)
            End Try
        End Sub

        Public Sub EliminarAreaxHojadeVida(ByVal AreaxHojadeVidaId As Integer)
            Try
                Dim dao As New AreasxHojadeVidaDao
                Dim AreaxHojadeVida = ConsultarAreaxHojadeVidaxId(AreaxHojadeVidaId)
                dao.EliminarAreaxHojadeVida(AreaxHojadeVida)
            Catch ex As Exception
        Throw New Exception(ex.Message)
            End Try
        End Sub

    End Class

End Namespace


