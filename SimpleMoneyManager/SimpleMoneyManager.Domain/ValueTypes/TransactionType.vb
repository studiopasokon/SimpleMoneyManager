Option Compare Binary
Option Explicit On
Option Infer On
Option Strict On

Namespace ValueTypes

    ''' <summary>
    ''' Enumeration of all possible transaction (or transfer) types.
    ''' </summary>
    Public Enum TransactionType
        ''' <summary>
        ''' Paying money.
        ''' </summary>
        Payment

        ''' <summary>
        ''' Receiving money.
        ''' </summary>
        Receipt
    End Enum

End Namespace
