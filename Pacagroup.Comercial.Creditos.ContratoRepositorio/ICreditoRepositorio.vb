Imports Pacagroup.Comercial.Creditos.Dominio

Public Interface ICreditoRepositorio


    Function ListarCredito() As List(Of Credito)

    Function RegistrarCredito(ByVal credito As Credito) As Credito

    Function ActualizarCredito(ByVal credito As Credito) As Credito

    Function EliminarCredito(ByVal idCredito As String) As Boolean

    Function ObtenerCredito(ByVal idCredito As String) As Credito
End Interface
