Namespace Dao.Inventario

    Friend Class TallasxEmpleadosDao

        Public Function ListarTallasxEmpleados() As List(Of TallasxEmpleados)
            Using bd As New CVEntities
                Dim query = From tbl In bd.TallasxEmpleados
                            Select tbl
                Return query.ToList
            End Using
        End Function

        Public Function ConsultarTallaxEmpleadoxId(ByVal TallaxEmpleadoid As Integer) As TallasxEmpleados
            Using bd As New CVEntities
                Dim query = From tbl In bd.TallasxEmpleados
                            Where tbl.TallaxEmpleadoId = TallaxEmpleadoid
                            Select tbl
                Return query.FirstOrDefault
            End Using
        End Function

        Public Sub GuardarTallaxEmpleado(ByVal TallaxEmpleado As TallasxEmpleados)
            Using bd As New CVEntities
                bd.Entry(TallaxEmpleado).State = EntityState.Added
                bd.SaveChanges()
            End Using
        End Sub

        Public Sub ActualizarTallaxEmpleado(ByVal TallaxEmpleado As TallasxEmpleados)
            Using bd As New CVEntities
                bd.Entry(TallaxEmpleado).State = EntityState.Modified
                bd.SaveChanges()
            End Using
        End Sub

        Public Sub EliminarTallaxEmpleado(ByVal TallaxEmpleado As TallasxEmpleados)
            Using bd As New CVEntities
                bd.Entry(TallaxEmpleado).State = EntityState.Deleted
                bd.SaveChanges()
            End Using
        End Sub

    End Class

End Namespace


