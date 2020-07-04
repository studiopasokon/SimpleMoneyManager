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

Imports SimpleMoneyManager.Domain.Entities
Imports SimpleMoneyManager.Domain.ValueTypes


''' <summary>
''' Test class that checks the internals of the <see cref="Transaction"/> entity.
''' </summary>
<TestClass()> Public Class TransactionTests

#Region "Equals tests"

    <TestMethod()> Public Sub Transactions_ShouldBeEqual_WhenSameObject()
        ' Arrange.
        Dim transaction As New Transaction()
        With transaction
            .Amount = 100
            .Description = "Test transaction"
            .TransactionDate = Date.Now
            .TransferType = TransactionType.Receipt
        End With

        ' Act.
        Dim equalResult = transaction.Equals(transaction)

        ' Assert.
        Assert.IsTrue(equalResult)
    End Sub

    <TestMethod()> Public Sub Transactions_ShouldBeEqual_WhenSimilarObjects()
        ' Arrange.
        Dim transaction1 As New Transaction()
        With transaction1
            .Amount = 100
            .Description = "Test transaction"
            .TransactionDate = Date.Now
            .TransferType = TransactionType.Receipt
        End With

        Dim transaction2 As New Transaction()
        With transaction2
            .Amount = 100
            .Description = "Test transaction"
            .TransactionDate = Date.Now
            .TransferType = TransactionType.Receipt
        End With

        ' Act.
        Dim equalResult = transaction1.Equals(transaction2)

        ' Assert.
        Assert.IsTrue(equalResult)
    End Sub

    <TestMethod()> Public Sub Transactions_ShouldBeNotEqual_WhenOneObjectIsNothing()
        ' Arrange.
        Dim transaction1 As New Transaction()
        With transaction1
            .Amount = 100
            .Description = "Test transaction"
            .TransactionDate = Date.Now
            .TransferType = TransactionType.Receipt
        End With

        ' Act.
        Dim equalResult = transaction1.Equals(Nothing)

        ' Assert.
        Assert.IsFalse(equalResult)
    End Sub

    <TestMethod()> Public Sub Transactions_ShouldBeNotEqual_WhenObjectsAreDifferent()
        ' Arrange.
        Dim transaction1 As New Transaction()
        With transaction1
            .Amount = 100
            .Description = "Test transaction"
            .TransactionDate = Date.Now
            .TransferType = TransactionType.Receipt
        End With

        Dim transaction2 As New Transaction()
        With transaction2
            .Amount = 200
            .Description = "Test transaction"
            .TransactionDate = Date.Now
            .TransferType = TransactionType.Payment
        End With

        ' Act.
        Dim equalResult = transaction1.Equals(transaction2)

        ' Assert.
        Assert.IsFalse(equalResult)
    End Sub

    <TestMethod()> Public Sub Transaction_ShouldBeNotEqual_WhenObjectOfWrongType()
        ' Arrange.
        Dim transaction As New Transaction()
        With transaction
            .Amount = 100
            .Description = "Test transaction"
            .TransactionDate = Date.Now
            .TransferType = TransactionType.Receipt
        End With

        ' Act.
        Dim equalResult = transaction.Equals("compare string")

        ' Assert.
        Assert.IsFalse(equalResult)
    End Sub

#End Region

#Region "Operator = tests"

    <TestMethod()> Public Sub Transactions_Operator_ShouldBeEqual_WhenSameObject()
        ' Arrange.
        Dim transaction As New Transaction()
        With transaction
            .Amount = 100
            .Description = "Test transaction"
            .TransactionDate = Date.Now
            .TransferType = TransactionType.Receipt
        End With

        ' Act.
        Dim equalResult = transaction = transaction

        ' Assert.
        Assert.IsTrue(equalResult)
    End Sub

    <TestMethod()> Public Sub Transactions_Operator_ShouldBeEqual_WhenSimilarObjects()
        ' Arrange.
        Dim transaction1 As New Transaction()
        With transaction1
            .Amount = 100
            .Description = "Test transaction"
            .TransactionDate = Date.Now
            .TransferType = TransactionType.Receipt
        End With

        Dim transaction2 As New Transaction()
        With transaction2
            .Amount = 100
            .Description = "Test transaction"
            .TransactionDate = Date.Now
            .TransferType = TransactionType.Receipt
        End With

        ' Act.
        Dim equalResult = transaction1 = transaction2

        ' Assert.
        Assert.IsTrue(equalResult)
    End Sub

    <TestMethod()> Public Sub Transactions_Operator_ShouldBeNotEqual_WhenOneObjectIsNothing()
        ' Arrange.
        Dim transaction1 As New Transaction()
        With transaction1
            .Amount = 100
            .Description = "Test transaction"
            .TransactionDate = Date.Now
            .TransferType = TransactionType.Receipt
        End With

        ' Act.
        Dim equalResult = transaction1 = Nothing

        ' Assert.
        Assert.IsFalse(equalResult)
    End Sub

    <TestMethod()> Public Sub Transactions_Operator_ShouldBeNotEqual_WhenObjectsAreDifferent()
        ' Arrange.
        Dim transaction1 As New Transaction()
        With transaction1
            .Amount = 100
            .Description = "Test transaction"
            .TransactionDate = Date.Now
            .TransferType = TransactionType.Receipt
        End With

        Dim transaction2 As New Transaction()
        With transaction2
            .Amount = 200
            .Description = "Test transaction"
            .TransactionDate = Date.Now
            .TransferType = TransactionType.Payment
        End With

        ' Act.
        Dim equalResult = transaction1 = transaction2

        ' Assert.
        Assert.IsFalse(equalResult)
    End Sub

#End Region

#Region "Operator <> tests"

    <TestMethod()> Public Sub Transactions_Operator_ShouldNotBeDifferent_WhenSameObject()
        ' Arrange.
        Dim transaction As New Transaction()
        With transaction
            .Amount = 100
            .Description = "Test transaction"
            .TransactionDate = Date.Now
            .TransferType = TransactionType.Receipt
        End With

        ' Act.
        Dim equalResult = transaction <> transaction

        ' Assert.
        Assert.IsFalse(equalResult)
    End Sub

    <TestMethod()> Public Sub Transactions_Operator_ShouldNotBeDifferent_WhenSimilarObjects()
        ' Arrange.
        Dim transaction1 As New Transaction()
        With transaction1
            .Amount = 100
            .Description = "Test transaction"
            .TransactionDate = Date.Now
            .TransferType = TransactionType.Receipt
        End With

        Dim transaction2 As New Transaction()
        With transaction2
            .Amount = 100
            .Description = "Test transaction"
            .TransactionDate = Date.Now
            .TransferType = TransactionType.Receipt
        End With

        ' Act.
        Dim equalResult = transaction1 <> transaction2

        ' Assert.
        Assert.IsFalse(equalResult)
    End Sub

    <TestMethod()> Public Sub Transactions_Operator_ShouldBeDifferent_WhenOneObjectIsNothing()
        ' Arrange.
        Dim transaction1 As New Transaction()
        With transaction1
            .Amount = 100
            .Description = "Test transaction"
            .TransactionDate = Date.Now
            .TransferType = TransactionType.Receipt
        End With

        ' Act.
        Dim equalResult = transaction1 <> Nothing

        ' Assert.
        Assert.IsTrue(equalResult)
    End Sub

    <TestMethod()> Public Sub Transactions_Operator_ShouldBeDifferent_WhenObjectsAreDifferent()
        ' Arrange.
        Dim transaction1 As New Transaction()
        With transaction1
            .Amount = 100
            .Description = "Test transaction"
            .TransactionDate = Date.Now
            .TransferType = TransactionType.Receipt
        End With

        Dim transaction2 As New Transaction()
        With transaction2
            .Amount = 200
            .Description = "Test transaction"
            .TransactionDate = Date.Now
            .TransferType = TransactionType.Payment
        End With

        ' Act.
        Dim equalResult = transaction1 <> transaction2

        ' Assert.
        Assert.IsTrue(equalResult)
    End Sub

#End Region

End Class