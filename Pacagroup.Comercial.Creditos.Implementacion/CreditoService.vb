Imports Pacagroup.Comercial.Creditos.Contrato
Imports Pacagroup.Comercial.Creditos.Dominio

Public Class CreditoService
    Implements ICreditoService

    Public Function ListarCredito() As List(Of Credito) Implements ICreditoService.ListarCredito
        Throw New NotImplementedException()
    End Function

    Public Function RegistrarCredito(credito As Credito) As Credito Implements ICreditoService.RegistrarCredito
        Throw New NotImplementedException()
    End Function

    Public Function ActualizarCredito(credito As Credito) As Credito Implements ICreditoService.ActualizarCredito
        Throw New NotImplementedException()
    End Function

    Public Function EliminarCredito(idCredito As String) As Boolean Implements ICreditoService.EliminarCredito
        Throw New NotImplementedException()
    End Function

    Public Function ObtenerCredito(idCredito As String) As Credito Implements ICreditoService.ObtenerCredito
        Throw New NotImplementedException()
    End Function
End Class
