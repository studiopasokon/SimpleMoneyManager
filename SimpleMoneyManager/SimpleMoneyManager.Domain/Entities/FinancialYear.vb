' Copyright 2020 Andy Peeters (studiopasokon)
'
' This file is part of SimpleMoneyManager.
'
' SimpleMoneyManager is free software: you can redistribute it and/or modify
' it under the terms Of the GNU General Public License as published by
' the Free Software Foundation, either version 3 of the License, or
' (at your option) any later version.
'
' SimpleMoneyManager is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY; without even the implied warranty of
' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
' GNU General Public License for more details.
'
' You should have received a copy of the GNU General Public License
' along with SimpleMoneyManager. If not, see http://www.gnu.org/licenses/.

Option Compare Binary
Option Explicit On
Option Infer On
Option Strict On

Namespace Entities

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

            If Transactions?.Count <> other.Transactions?.Count Then
                Return False
            ElseIf Not Transactions?.All(Function(ByVal tr) CBool(other.Transactions?.Contains(tr))) Then
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