Namespace Dao.Inventario

    Friend Class DetalleIngresosDao

        Public Function ListarDetalleIngresos() As List(Of DetalleIngresos)
            Using bd As New CVEntities
                Dim query = From tbl In bd.DetalleIngresos
                            Select tbl
                Return query.ToList
            End Using
        End Function

        Public Function ConsultarDetalleIngresoxId(ByVal DetalleIngresoid As Integer) As DetalleIngresos
            Using bd As New CVEntities
                Dim query = From tbl In bd.DetalleIngresos
                            Where tbl.DetalleIngresoId = DetalleIngresoid
                            Select tbl
                Return query.FirstOrDefault
            End Using
        End Function

        Public Sub GuardarDetalleIngreso(ByVal DetalleIngreso As DetalleIngresos)
            Using bd As New CVEntities
                bd.Entry(DetalleIngreso).State = EntityState.Added
                bd.SaveChanges()
            End Using
        End Sub

        Public Sub ActualizarDetalleIngreso(ByVal DetalleIngreso As DetalleIngresos)
            Using bd As New CVEntities
                bd.Entry(DetalleIngreso).State = EntityState.Modified
                bd.SaveChanges()
            End Using
        End Sub

        Public Sub EliminarDetalleIngreso(ByVal DetalleIngreso As DetalleIngresos)
            Using bd As New CVEntities
                bd.Entry(DetalleIngreso).State = EntityState.Deleted
                bd.SaveChanges()
            End Using
        End Sub

    End Class

End Namespace


