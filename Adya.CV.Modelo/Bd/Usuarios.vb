'------------------------------------------------------------------------------
' <auto-generated>
'    This code was generated from a template.
'
'    Manual changes to this file may cause unexpected behavior in your application.
'    Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class Usuarios
    Public Property UsuarioId As Integer
    Public Property Usuario As String
    Public Property Contrasena As String
    Public Property Administrador As Boolean
    Public Property Nombre As String
    Public Property Apellido As String

    Public Overridable Property MenusxUsuario As ICollection(Of MenusxUsuario) = New HashSet(Of MenusxUsuario)

End Class