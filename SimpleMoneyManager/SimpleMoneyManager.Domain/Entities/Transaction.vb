Option Compare Binary
Option Explicit On
Option Infer On
Option Strict On

''' <summary>
''' Entity class describing a single transaction, either a payment or a receipt of money.
''' </summary>
Public Class Transaction
    ''' <summary>
    ''' Date and time on which the transaction took place.
    ''' </summary>
    Public Property TransactionDate As DateTime

    ''' <summary>
    ''' Some text describing the transaction.
    ''' </summary>
    Public Property Description As String

    ''' <summary>
    ''' The amount of money involved in the transaction.
    ''' </summary>
    ''' <returns></returns>
    Public Property Amount As Decimal

    ''' <summary>
    ''' Type stating whether the transaction involved a payment or a receipt of money.
    ''' </summary>
    Public Property TransferType As TransactionType

    ' TODO: add Equals implementation.
End Class
