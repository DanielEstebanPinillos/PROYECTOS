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

Partial Public Class Tallas
    Public Property TallaId As Integer
    Public Property Nombre As String

    Public Overridable Property DetalleIngresos As ICollection(Of DetalleIngresos) = New HashSet(Of DetalleIngresos)
    Public Overridable Property ProductosxTallas As ICollection(Of ProductosxTallas) = New HashSet(Of ProductosxTallas)
    Public Overridable Property TallasxEmpleados As ICollection(Of TallasxEmpleados) = New HashSet(Of TallasxEmpleados)

End Class