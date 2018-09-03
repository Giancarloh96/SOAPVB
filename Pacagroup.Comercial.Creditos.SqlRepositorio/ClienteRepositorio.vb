Imports System.Data.SqlClient
Imports Pacagroup.Comercial.Creditos.ContratoRepositorio
Imports Pacagroup.Comercial.Creditos.Dominio

Public Class ClienteRepositorio
    Implements IClienteRepositorio

    Public Function ObtenerCliente(numeroDocumento As String) As Cliente Implements IClienteRepositorio.ObtenerCliente
        Using conexion As SqlConnection = New SqlConnection(ConexionRepositorio.ObtenerCadenaConexion())


        End Using
    End Function

    Public Function ListarCliente() As List(Of Cliente) Implements IClienteRepositorio.ListarCliente
        Throw New NotImplementedException()
    End Function
End Class
