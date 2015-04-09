Namespace Dao.Inventario

    Friend Class IngresosDao

        Public Function ListarIngresos() As List(Of Ingresos)
            Using bd As New CVEntities
                Dim query = From tbl In bd.Ingresos
                            Select tbl
                Return query.ToList
            End Using
        End Function

        Public Function ConsultarIngresoxId(ByVal Ingresoid As Integer) As Ingresos
            Using bd As New CVEntities
                Dim query = From tbl In bd.Ingresos
                            Where tbl.IngresoId = Ingresoid
                            Select tbl
                Return query.FirstOrDefault
            End Using
        End Function

        Public Sub GuardarIngreso(ByVal Ingreso As Ingresos)
            Using bd As New CVEntities
                bd.Entry(Ingreso).State = EntityState.Added
                bd.SaveChanges()
            End Using
        End Sub

        Public Sub ActualizarIngreso(ByVal Ingreso As Ingresos)
            Using bd As New CVEntities
                bd.Entry(Ingreso).State = EntityState.Modified
                bd.SaveChanges()
            End Using
        End Sub

        Public Sub EliminarIngreso(ByVal Ingreso As Ingresos)
            Using bd As New CVEntities
                bd.Entry(Ingreso).State = EntityState.Deleted
                bd.SaveChanges()
            End Using
        End Sub

    End Class

End Namespace


