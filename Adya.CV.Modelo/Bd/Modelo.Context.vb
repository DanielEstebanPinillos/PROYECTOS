﻿'------------------------------------------------------------------------------
' <auto-generated>
'    This code was generated from a template.
'
'    Manual changes to this file may cause unexpected behavior in your application.
'    Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure

Partial Public Class CVEntities
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=CVEntities")
    End Sub

    Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
        Throw New UnintentionalCodeFirstException()
    End Sub

    Public Property Actividades() As DbSet(Of Actividades)
    Public Property ActividadesxHojadeVida() As DbSet(Of ActividadesxHojadeVida)
    Public Property Areas() As DbSet(Of Areas)
    Public Property AreasxHojadeVida() As DbSet(Of AreasxHojadeVida)
    Public Property Cargos() As DbSet(Of Cargos)
    Public Property Ciudades() As DbSet(Of Ciudades)
    Public Property Conocimientos() As DbSet(Of Conocimientos)
    Public Property Educaciones() As DbSet(Of Educaciones)
    Public Property EstudioActuales() As DbSet(Of EstudioActuales)
    Public Property ExperienciaLaborales() As DbSet(Of ExperienciaLaborales)
    Public Property InformacionFamiliares() As DbSet(Of InformacionFamiliares)
    Public Property Nacionalidades() As DbSet(Of Nacionalidades)
    Public Property Profesiones() As DbSet(Of Profesiones)
    Public Property ReferenciaPersonales() As DbSet(Of ReferenciaPersonales)
    Public Property SeguridadesSociales() As DbSet(Of SeguridadesSociales)
    Public Property Usuarios() As DbSet(Of Usuarios)
    Public Property MenusxUsuario() As DbSet(Of MenusxUsuario)
    Public Property Menus() As DbSet(Of Menus)
    Public Property HojadeVidas() As DbSet(Of HojadeVidas)
    Public Property DetalleIngresos() As DbSet(Of DetalleIngresos)
    Public Property Empleados() As DbSet(Of Empleados)
    Public Property Ingresos() As DbSet(Of Ingresos)
    Public Property Productos() As DbSet(Of Productos)
    Public Property ProductosxEmpleados() As DbSet(Of ProductosxEmpleados)
    Public Property ProductosxTallas() As DbSet(Of ProductosxTallas)
    Public Property Proveedores() As DbSet(Of Proveedores)
    Public Property Tallas() As DbSet(Of Tallas)
    Public Property TallasxEmpleados() As DbSet(Of TallasxEmpleados)

End Class
