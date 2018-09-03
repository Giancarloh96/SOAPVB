Imports System.ServiceModel
Imports Pacagroup.Comercial.Creditos.Dominio

<ServiceContract()>
Public Interface ICreditoService

    <OperationContract()>
    Function ListarCredito() As List(Of Credito)

    <OperationContract()>
    Function RegistrarCredito(ByVal credito As Credito) As Credito

    <OperationContract()>
    Function ActualizarCredito(ByVal credito As Credito) As Credito

    <OperationContract()>
    Function EliminarCredito(ByVal idCredito As String) As Boolean

    <OperationContract()>
    Function ObtenerCredito(ByVal idCredito As String) As Credito
End Interface
