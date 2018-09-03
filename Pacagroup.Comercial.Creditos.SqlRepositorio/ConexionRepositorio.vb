Imports System.Configuration

Public Class ConexionRepositorio
    Public Shared Function ObtenerCadenaConexion() As String
        Dim cadena As String

        cadena = ConfigurationManager.ConnectionStrings("CreditosDB").ConnectionString

        Return cadena
    End Function
End Class
