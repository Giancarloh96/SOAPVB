Imports System.Runtime.Serialization

<DataContract()>
Public Class Cliente

    Private IdClienteField As Int32
    <DataMember()>
    Public Property IdCliente() As Int32
        Get
            Return IdClienteField
        End Get
        Set(ByVal value As Int32)
            IdClienteField = value
        End Set
    End Property

    Private NombreField As String
    <DataMember()>
    Public Property Nombre() As String
        Get
            Return NombreField
        End Get
        Set(ByVal value As String)
            NombreField = value
        End Set
    End Property

    Private ApellidoPaternoField As String
    <DataMember()>
    Public Property ApellidoPaterno() As String
        Get
            Return ApellidoPaternoField
        End Get
        Set(ByVal value As String)
            ApellidoPaternoField = value
        End Set
    End Property

    Private ApellidoMaternoField As String
    <DataMember()>
    Public Property ApellidoMaterno() As String
        Get
            Return ApellidoMaternoField
        End Get
        Set(ByVal value As String)
            ApellidoMaternoField = value
        End Set
    End Property

    Private TipoDocumentoField As String
    <DataMember()>
    Public Property TipoDocumento() As String
        Get
            Return TipoDocumentoField
        End Get
        Set(ByVal value As String)
            TipoDocumentoField = value
        End Set
    End Property

    Private NumeroDocumentoField As String
    <DataMember()>
    Public Property NumeroDocumento() As String
        Get
            Return NumeroDocumentoField
        End Get
        Set(ByVal value As String)
            NumeroDocumentoField = value
        End Set
    End Property

    Private SexoField As String
    <DataMember()>
    Public Property Sexo() As String
        Get
            Return SexoField
        End Get
        Set(ByVal value As String)
            SexoField = value
        End Set
    End Property

    Private FechaNacimientoField As String
    <DataMember()>
    Public Property FechaNacimiento() As DateTime
        Get
            Return FechaNacimientoField
        End Get
        Set(ByVal value As DateTime)
            FechaNacimientoField = value
        End Set
    End Property

    Private DireccionField As String
    <DataMember()>
    Public Property Direccion() As String
        Get
            Return DireccionField
        End Get
        Set(ByVal value As String)
            DireccionField = value
        End Set
    End Property

    Private CodigoPostalField As String
    <DataMember()>
    Public Property CodigoPostal() As String
        Get
            Return CodigoPostalField
        End Get
        Set(ByVal value As String)
            CodigoPostalField = value
        End Set
    End Property

    Private EstadoCivilField As String
    Public Property EstadoCivil() As String
        Get
            Return EstadoCivilField
        End Get
        Set(ByVal value As String)
            EstadoCivilField = value
        End Set
    End Property
End Class
