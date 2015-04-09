Imports System.Web
Imports System.Configuration

Namespace Session

  Public Class SessionManager

    Public Shared Property UserId As String
      Get
        Return Web.HttpContext.Current.Session("UserId")
      End Get
      Set(ByVal value As String)
        Web.HttpContext.Current.Session("UserId") = value
      End Set
    End Property

  End Class

End Namespace