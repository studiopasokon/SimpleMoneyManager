Option Compare Binary
Option Explicit On
Option Infer On
Option Strict On

''' <summary>
''' Entity class containing all transactions done within a single year.
''' Matches a calender year.
''' </summary>
Public Class FinancialYear
    ''' <summary>
    ''' List of all transactions that occurred during the year.
    ''' </summary>
    Public Property Transactions As List(Of Transaction)

    ' TODO: add Equals implementation.
End Class
