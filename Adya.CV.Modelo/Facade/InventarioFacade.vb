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

  End Class

End Namespace


