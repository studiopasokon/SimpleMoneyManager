Option Compare Binary
Option Explicit On
Option Infer On
Option Strict On

Namespace SimpleMoneyManager.Domain

    ''' <summary>
    ''' Entity class containing all transactions done within a single year.
    ''' Matches a calender year.
    ''' </summary>
    Public Class FinancialYear : Implements IEquatable(Of FinancialYear)

#Region "Properties"

        ''' <summary>
        ''' List of all transactions that occurred during the year.
        ''' </summary>
        Public Property Transactions As List(Of Transaction)

#End Region

#Region "IEquatable"

        ''' <inheritdoc/>
        Public Overloads Function Equals(other As FinancialYear) As Boolean Implements IEquatable(Of FinancialYear).Equals
            If other Is Nothing Then Return False

            If Transactions.Count <> other.Transactions.Count Then
                Return False
            ElseIf Not Transactions.All(Function(ByVal tr) other.Transactions.Contains(tr)) Then
                Return False
            Else
                Return True
            End If
        End Function

        ''' <inheritdoc/>
        Public Overrides Function Equals(other As Object) As Boolean
            If other Is Nothing Then Return False

            Dim compareObj As FinancialYear = TryCast(other, FinancialYear)
            If compareObj Is Nothing Then
                Return False
            Else
                Return Equals(compareObj)
            End If
        End Function

        ''' <inheritdoc/>
        Public Overrides Function GetHashCode() As Integer

            Dim hashCode As Integer = 29

            hashCode = (hashCode * 37) Xor Transactions.GetHashCode()

            Return hashCode
        End Function

        ''' <inheritdoc/>
        Public Shared Operator =(year1 As FinancialYear, year2 As FinancialYear) As Boolean
            If year1 Is Nothing OrElse year2 Is Nothing Then
                Return Equals(year1, year2)
            End If

            Return year1.Equals(year2)
        End Operator

        ''' <inheritdoc/>
        Public Shared Operator <>(year1 As FinancialYear, year2 As FinancialYear) As Boolean
            If year1 Is Nothing OrElse year2 Is Nothing Then
                Return Not Equals(year1, year2)
            End If

            Return Not year1.Equals(year2)
        End Operator

#End Region

    End Class

End Namespace