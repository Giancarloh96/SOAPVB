Imports Pacagroup.Comercial.Creditos.Dominio

Public Interface IClienteRepositorio
    Function ObtenerCliente(ByVal numeroDocumento As String) As Cliente

    Function ListarCliente() As List(Of Cliente)
End Interface
