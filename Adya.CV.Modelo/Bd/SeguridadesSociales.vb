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

Partial Public Class SeguridadesSociales
    Public Property SeguridadSocialId As Integer
    Public Property HojadeVidaFk As Integer
    Public Property Eps As Boolean
    Public Property NombreEPS As String
    Public Property FechaEPS As Nullable(Of Date)
    Public Property TipoAfilidado As Nullable(Of Boolean)
    Public Property Pensiones As Boolean
    Public Property NombrePEN As String
    Public Property FechaPEN As Nullable(Of Date)
    Public Property Cesantias As Boolean
    Public Property NombreCES As String
    Public Property FechaCES As Nullable(Of Date)
    Public Property Valor As Boolean

    Public Overridable Property HojadeVidas As HojadeVidas

End Class