Imports System.Runtime.Serialization

<DataContract()>
Public Class Credito

    Private idCreditoField As Int32
    <DataMember()>
    Public Property idCredito() As Int32
        Get
            Return idCreditoField
        End Get
        Set(ByVal value As Int32)
            idCreditoField = value
        End Set
    End Property

    Private TipoCreditoField As Int32
    <DataMember()>
    Public Property TipoCredito() As Int32
        Get
            Return TipoCreditoField
        End Get
        Set(ByVal value As Int32)
            TipoCreditoField = value
        End Set
    End Property

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

    Private FechaField As DateTime
    <DataMember()>
    Public Property Fecha() As DateTime
        Get
            Return FechaField
        End Get
        Set(ByVal value As DateTime)
            FechaField = value
        End Set
    End Property

    Private MontoField As Decimal
    <DataMember()>
    Public Property Monto() As Decimal
        Get
            Return MontoField
        End Get
        Set(ByVal value As Decimal)
            MontoField = value
        End Set
    End Property

    Private DiaPagoField As DateTime
    <DataMember()>
    Public Property DiaPago() As DateTime
        Get
            Return DiaPagoField
        End Get
        Set(ByVal value As DateTime)
            DiaPagoField = value
        End Set
    End Property

    Private TasaField As Decimal
    <DataMember()>
    Public Property Tasa() As Decimal
        Get
            Return TasaField
        End Get
        Set(ByVal value As Decimal)
            TasaField = value
        End Set
    End Property

    Private ComisionField As Decimal
    Public Property Comision() As Decimal
        Get
            Return ComisionField
        End Get
        Set(ByVal value As Decimal)
            ComisionField = value
        End Set
    End Property
End Class
