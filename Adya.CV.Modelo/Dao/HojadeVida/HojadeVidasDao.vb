Namespace Dao

  Friend Class HojadeVidasDao

    Public Function ListarHojadeVidas() As List(Of HojadeVidas)
      Using bd As New CVEntities
        Dim query = From tbl In bd.HojadeVidas
                Select tbl
        Return query.ToList
      End Using
    End Function

    Public Function ConsultarHojadeVidaxId(ByVal HojaDeVidaId As Integer) As HojadeVidas
      Using bd As New CVEntities
        Dim query = From tbl In bd.HojadeVidas
                    Where tbl.HojadeVidaId = HojaDeVidaId
                    Select tbl
        Return query.FirstOrDefault
      End Using
    End Function

    Public Sub GuardarHojadeVida(ByVal HojaDeVida As HojadeVidas)
      Using bd As New CVEntities
        bd.Entry(HojaDeVida).State = EntityState.Added
        bd.SaveChanges()
      End Using
    End Sub

    Public Sub ActualizarHojadeVida(ByVal HojaDeVida As HojadeVidas)
      Using bd As New CVEntities
        bd.Entry(HojaDeVida).State = EntityState.Modified
        bd.SaveChanges()
      End Using
    End Sub

    Public Sub EliminarHojadeVida(ByVal HojaDeVida As HojadeVidas)
      Using bd As New CVEntities
        bd.Entry(HojaDeVida).State = EntityState.Deleted
        bd.SaveChanges()
      End Using
    End Sub

  End Class

End Namespace


