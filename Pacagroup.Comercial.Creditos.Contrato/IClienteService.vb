Imports System.ServiceModel
Imports Pacagroup.Comercial.Creditos.Dominio

<ServiceContract()>
Public Interface IClienteService

    <OperationContract()>
    Function ObtenerCliente(ByVal numeroDocumento As String) As Cliente

    <OperationContract()>
    Function ListarCliente() As List(Of Cliente)
End Interface
