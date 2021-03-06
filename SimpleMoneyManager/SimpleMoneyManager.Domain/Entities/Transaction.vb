﻿' Copyright 2020 Andy Peeters (studiopasokon)
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

Imports SimpleMoneyManager.Domain.ValueTypes

Namespace Entities

    ''' <summary>
    ''' Entity class describing a single transaction, either a payment or a receipt of money.
    ''' </summary>
    Public Class Transaction : Implements IEquatable(Of Transaction)

#Region "Properties"

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

#End Region

#Region "IEquatable"

        ''' <inheritdoc/>
        Public Overloads Function Equals(other As Transaction) As Boolean Implements IEquatable(Of Transaction).Equals
            If other Is Nothing Then Return False

            If (TransactionDate <> other.TransactionDate) _
                Or (Description <> other.Description) _
                Or (Amount <> other.Amount) _
                Or (TransferType <> other.TransferType) Then

                Return False
            Else
                Return True
            End If
        End Function

        ''' <inheritdoc/>
        Public Overrides Function Equals(other As Object) As Boolean
            If other Is Nothing Then Return False

            Dim compareObj As Transaction = TryCast(other, Transaction)
            If compareObj Is Nothing Then
                Return False
            Else
                Return Equals(compareObj)
            End If
        End Function

        ''' <inheritdoc/>
        Public Overrides Function GetHashCode() As Integer

            Dim hashCode As Integer = 17

            hashCode = (hashCode * 23) Xor TransactionDate.GetHashCode()
            hashCode = (hashCode * 23) Xor Description.GetHashCode()
            hashCode = (hashCode * 23) Xor Amount.GetHashCode()
            hashCode = (hashCode * 23) Xor TransferType.GetHashCode()

            Return hashCode
        End Function

        ''' <inheritdoc/>
        Public Shared Operator =(transaction1 As Transaction, transaction2 As Transaction) As Boolean
            If transaction1 Is Nothing OrElse transaction2 Is Nothing Then
                Return Equals(transaction1, transaction2)
            End If

            Return transaction1.Equals(transaction2)
        End Operator

        ''' <inheritdoc/>
        Public Shared Operator <>(transaction1 As Transaction, transaction2 As Transaction) As Boolean
            If transaction1 Is Nothing OrElse transaction2 Is Nothing Then
                Return Not Equals(transaction1, transaction2)
            End If

            Return Not transaction1.Equals(transaction2)
        End Operator

#End Region

    End Class

End Namespace