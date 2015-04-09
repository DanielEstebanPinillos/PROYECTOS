﻿Namespace Dao

  Friend Class UsuariosDao

    Public Function ListarUsuarios() As List(Of Usuarios)
      Using bd As New CVEntities
        Dim query = From tbl In bd.Usuarios
                    Select tbl
        Return query.ToList
      End Using
    End Function

    Public Function ConsultarUsuarioxId(ByVal usuarioid As Integer) As Usuarios
      Using bd As New CVEntities
        Dim query = From tbl In bd.Usuarios
                    Where tbl.UsuarioId = usuarioid
                    Select tbl
        Return query.FirstOrDefault
      End Using
    End Function

    Public Sub GuardarUsuario(ByVal usuario As Usuarios)
      Using bd As New CVEntities
        bd.Entry(usuario).State = EntityState.Added
        bd.SaveChanges()
      End Using
    End Sub

    Public Sub ActualizarUsuario(ByVal usuario As Usuarios)
      Using bd As New CVEntities
        bd.Entry(usuario).State = EntityState.Modified
        bd.SaveChanges()
      End Using
    End Sub

    Public Sub EliminarUsuario(ByVal usuario As Usuarios)
      Using bd As New CVEntities
        bd.Entry(usuario).State = EntityState.Deleted
        bd.SaveChanges()
      End Using
    End Sub

    Public Function ConsultarUsuarioxUsuarioyContrasena(ByVal usuario As String, ByVal contrasena As String) As Usuarios
      Using bd As New CVEntities
        Dim query = From tbl In bd.Usuarios
                    Where tbl.Usuario = usuario And tbl.Contrasena = contrasena
                    Select tbl
        Return query.FirstOrDefault
      End Using
    End Function

  End Class

End Namespace
