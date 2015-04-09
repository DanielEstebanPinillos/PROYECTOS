Imports System.ComponentModel
Imports Adya.CV.Modelo.BL.Inventario


Namespace Facade.InventarioFacade

  <DataObject(True)>
  Public Class InventarioFacade

#Region "Tallas"

    Public Function ListarTallas() As List(Of Tallas)
      Try
        Dim bl As New TallasBL
        Return bl.ListarTallas
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Function

    Public Function ConsultarTallaxId(ByVal Tallaid As Integer) As Tallas
      Try
        Dim bl As New TallasBL
        Return bl.ConsultarTallaxId(Tallaid)
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Function

    Public Sub GuardarTalla(ByVal Talla As Tallas)
      Try
        Dim bl As New TallasBL
        bl.GuardarTalla(Talla)
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Sub

    Public Sub ActualizarTalla(ByVal Talla As Tallas)
      Try
        Dim bl As New TallasBL
        bl.ActualizarTalla(Talla)
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Sub

    Public Sub EliminarTalla(ByVal TallaId As Integer)
      Try
        Dim bl As New TallasBL
        bl.EliminarTalla(TallaId)
      Catch ex As Exception
        Throw New Exception(ex.Message)
      End Try
    End Sub

#End Region

#Region "Proveedores"

        Public Function ListarProveedores() As List(Of Proveedores)
            Try
                Dim bl As New ProveedoresBL
                Return bl.ListarProveedores
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Function

        Public Function ConsultarProveedorxId(ByVal Proveedorid As Integer) As Proveedores
            Try
                Dim bl As New ProveedoresBL
                Return bl.ConsultarProveedorxId(Proveedorid)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Function

        Public Sub GuardarProveedor(ByVal Proveedor As Proveedores)
            Try
                Dim bl As New ProveedoresBL
                bl.GuardarProveedor(Proveedor)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Sub

        Public Sub ActualizarProveedor(ByVal Proveedor As Proveedores)
            Try
                Dim bl As New ProveedoresBL
                bl.ActualizarProveedor(Proveedor)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Sub

        Public Sub EliminarProveedor(ByVal ProveedorId As Integer)
            Try
                Dim bl As New ProveedoresBL
                bl.EliminarProveedor(ProveedorId)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Sub

#End Region

#Region "Productos"

        Public Function ListarProductos() As List(Of Productos)
            Try
                Dim bl As New ProductosBL
                Return bl.ListarProductos
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Function

        Public Function ConsultarProductoxId(ByVal Productoid As Integer) As Productos
            Try
                Dim bl As New ProductosBL
                Return bl.ConsultarProductoxId(Productoid)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Function

        Public Sub GuardarProducto(ByVal Producto As Productos)
            Try
                Dim bl As New ProductosBL
                bl.GuardarProducto(Producto)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Sub

        Public Sub ActualizarProducto(ByVal Producto As Productos)
            Try
                Dim bl As New ProductosBL
                bl.ActualizarProducto(Producto)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Sub

        Public Sub EliminarProducto(ByVal ProductoId As Integer)
            Try
                Dim bl As New ProductosBL
                bl.EliminarProducto(ProductoId)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Sub

#End Region

#Region "Ingresos"

        Public Function ListarIngresos() As List(Of Ingresos)
            Try
                Dim bl As New IngresosBL
                Return bl.ListarIngresos
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Function

        Public Function ConsultarIngresoxId(ByVal Ingresoid As Integer) As Ingresos
            Try
                Dim bl As New IngresosBL
                Return bl.ConsultarIngresoxId(Ingresoid)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Function

        Public Sub GuardarIngreso(ByVal Ingreso As Ingresos)
            Try
                Dim bl As New IngresosBL
                bl.GuardarIngreso(Ingreso)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Sub

        Public Sub ActualizarIngreso(ByVal Ingreso As Ingresos)
            Try
                Dim bl As New IngresosBL
                bl.ActualizarIngreso(Ingreso)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Sub

        Public Sub EliminarIngreso(ByVal IngresoId As Integer)
            Try
                Dim bl As New IngresosBL
                bl.EliminarIngreso(IngresoId)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Sub

#End Region

#Region "Empleados"

        Public Function ListarEmpleados() As List(Of Empleados)
            Try
                Dim bl As New EmpleadosBL
                Return bl.ListarEmpleados
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Function

        Public Function ConsultarEmpleadoxId(ByVal Empleadoid As Integer) As Empleados
            Try
                Dim bl As New EmpleadosBL
                Return bl.ConsultarEmpleadoxId(Empleadoid)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Function

        Public Sub GuardarEmpleado(ByVal Empleado As Empleados)
            Try
                Dim bl As New EmpleadosBL
                bl.GuardarEmpleado(Empleado)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Sub

        Public Sub ActualizarEmpleado(ByVal Empleado As Empleados)
            Try
                Dim bl As New EmpleadosBL
                bl.ActualizarEmpleado(Empleado)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Sub

        Public Sub EliminarEmpleado(ByVal EmpleadoId As Integer)
            Try
                Dim bl As New EmpleadosBL
                bl.EliminarEmpleado(EmpleadoId)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Sub

#End Region

#Region "ProductosxEmpleados"

        Public Function ListarProductosxEmpleados() As List(Of ProductosxEmpleados)
            Try
                Dim bl As New ProductosxEmpleadosBL
                Return bl.ListarProductosxEmpleados
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Function

        Public Function ConsultarProductoxEmpleadoxId(ByVal ProductoxEmpleadoid As Integer) As ProductosxEmpleados
            Try
                Dim bl As New ProductosxEmpleadosBL
                Return bl.ConsultarProductoxEmpleadoxId(ProductoxEmpleadoid)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Function

        Public Sub GuardarProductoxEmpleado(ByVal ProductoxEmpleado As ProductosxEmpleados)
            Try
                Dim bl As New ProductosxEmpleadosBL
                bl.GuardarProductoxEmpleado(ProductoxEmpleado)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Sub

        Public Sub ActualizarProductoxEmpleado(ByVal ProductoxEmpleado As ProductosxEmpleados)
            Try
                Dim bl As New ProductosxEmpleadosBL
                bl.ActualizarProductoxEmpleado(ProductoxEmpleado)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Sub

        Public Sub EliminarProductoxEmpleado(ByVal ProductoxEmpleadoId As Integer)
            Try
                Dim bl As New ProductosxEmpleadosBL
                bl.EliminarProductoxEmpleado(ProductoxEmpleadoId)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Sub

#End Region

#Region "DetalleIngresos"

        Public Function ListarDetalleIngresos() As List(Of DetalleIngresos)
            Try
                Dim bl As New DetalleIngresosBL
                Return bl.ListarDetalleIngresos
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Function

        Public Function ConsultarDetalleIngresoxId(ByVal DetalleIngresoid As Integer) As DetalleIngresos
            Try
                Dim bl As New DetalleIngresosBL
                Return bl.ConsultarDetalleIngresoxId(DetalleIngresoid)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Function

        Public Sub GuardarDetalleIngreso(ByVal DetalleIngreso As DetalleIngresos)
            Try
                Dim bl As New DetalleIngresosBL
                bl.GuardarDetalleIngreso(DetalleIngreso)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Sub

        Public Sub ActualizarDetalleIngreso(ByVal DetalleIngreso As DetalleIngresos)
            Try
                Dim bl As New DetalleIngresosBL
                bl.ActualizarDetalleIngreso(DetalleIngreso)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Sub

        Public Sub EliminarDetalleIngreso(ByVal DetalleIngresoId As Integer)
            Try
                Dim bl As New DetalleIngresosBL
                bl.EliminarDetalleIngreso(DetalleIngresoId)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Sub

#End Region

#Region "ProductosxTallas"

        Public Function ListarProductosxTallas() As List(Of ProductosxTallas)
            Try
                Dim bl As New ProductosxTallasBL
                Return bl.ListarProductosxTallas
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Function

        Public Function ConsultarProductoxTallaxId(ByVal ProductoxTallaid As Integer) As ProductosxTallas
            Try
                Dim bl As New ProductosxTallasBL
                Return bl.ConsultarProductoxTallaxId(ProductoxTallaid)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Function

        Public Sub GuardarProductoxTalla(ByVal ProductoxTalla As ProductosxTallas)
            Try
                Dim bl As New ProductosxTallasBL
                bl.GuardarProductoxTalla(ProductoxTalla)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Sub

        Public Sub ActualizarProductoxTalla(ByVal ProductoxTalla As ProductosxTallas)
            Try
                Dim bl As New ProductosxTallasBL
                bl.ActualizarProductoxTalla(ProductoxTalla)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Sub

        Public Sub EliminarProductoxTalla(ByVal ProductoxTallaId As Integer)
            Try
                Dim bl As New ProductosxTallasBL
                bl.EliminarProductoxTalla(ProductoxTallaId)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Sub

#End Region

#Region "TallasxEmpleados"

        Public Function ListarTallasxEmpleados() As List(Of TallasxEmpleados)
            Try
                Dim bl As New TallasxEmpleadosBL
                Return bl.ListarTallasxEmpleados
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Function

        Public Function ConsultarTallaxEmpleadoxId(ByVal TallaxEmpleadoid As Integer) As TallasxEmpleados
            Try
                Dim bl As New TallasxEmpleadosBL
                Return bl.ConsultarTallaxEmpleadoxId(TallaxEmpleadoid)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Function

        Public Sub GuardarTallaxEmpleado(ByVal TallaxEmpleado As TallasxEmpleados)
            Try
                Dim bl As New TallasxEmpleadosBL
                bl.GuardarTallaxEmpleado(TallaxEmpleado)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Sub

        Public Sub ActualizarTallaxEmpleado(ByVal TallaxEmpleado As TallasxEmpleados)
            Try
                Dim bl As New TallasxEmpleadosBL
                bl.ActualizarTallaxEmpleado(TallaxEmpleado)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Sub

        Public Sub EliminarTallaxEmpleado(ByVal TallaxEmpleadoId As Integer)
            Try
                Dim bl As New TallasxEmpleadosBL
                bl.EliminarTallaxEmpleado(TallaxEmpleadoId)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Sub

#End Region



  End Class

End Namespace


