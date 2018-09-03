Imports Pacagroup.Comercial.Creditos.Contrato
Imports Pacagroup.Comercial.Creditos.Dominio

Public Class ClienteService
    Implements IClienteService

    Public Function ObtenerCliente(numeroDocumento As String) As Cliente Implements IClienteService.ObtenerCliente
        Throw New NotImplementedException()
    End Function

    Public Function ListarCliente() As List(Of Cliente) Implements IClienteService.ListarCliente
        Throw New NotImplementedException()
    End Function
End Class
