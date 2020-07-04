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

Namespace EntityTests

    ''' <summary>
    ''' Test class that checks the internals of the <see cref="FinancialYear"/> entity.
    ''' </summary>
    <TestClass()> Public Class FinancialYearTests

#Region "Equals tests"

        <TestMethod()> Public Sub EmptyFinancialYears_ShouldBeEqual_WhenSameObjects()
            ' Arrange.
            Dim financialYear As New FinancialYear()
            With financialYear
                .Transactions = Nothing
            End With

            ' Act.
            Dim equalResult = financialYear.Equals(financialYear)

            ' Assert.
            Assert.IsTrue(equalResult)
        End Sub

        <TestMethod()> Public Sub EmptyFinancialYears_ShouldBeEqual_WhenSimilarObjects()
            ' Arrange.
            Dim financialYear1 As New FinancialYear()
            With financialYear1
                .Transactions = Nothing
            End With

            Dim financialYear2 As New FinancialYear()
            With financialYear2
                .Transactions = Nothing
            End With

            ' Act.
            Dim equalResult = financialYear1.Equals(financialYear2)

            ' Assert.
            Assert.IsTrue(equalResult)
        End Sub

        <TestMethod()> Public Sub EmptyFinancialYears_ShouldNotBeEqual_WhenOneObjectIsNothing()
            ' Arrange.
            Dim financialYear As New FinancialYear()
            With financialYear
                .Transactions = Nothing
            End With

            ' Act.
            Dim equalResult = financialYear.Equals(Nothing)

            ' Assert.
            Assert.IsFalse(equalResult)
        End Sub

        <TestMethod()> Public Sub FinancialYearsWithEmptyTransactionList_ShouldBeEqual_WhenSameObjects()
            ' Arrange.
            Dim financialYear As New FinancialYear()
            With financialYear
                .Transactions = New List(Of Transaction)
            End With

            ' Act.
            Dim equalResult = financialYear.Equals(financialYear)

            ' Assert.
            Assert.IsTrue(equalResult)
        End Sub

        <TestMethod()> Public Sub FinancialYearsWithEmptyTransactionList_ShouldBeEqual_WhenSimilarObjects()
            ' Arrange.
            Dim financialYear1 As New FinancialYear()
            With financialYear1
                .Transactions = New List(Of Transaction)
            End With

            Dim financialYear2 As New FinancialYear()
            With financialYear2
                .Transactions = New List(Of Transaction)
            End With

            ' Act.
            Dim equalResult = financialYear1.Equals(financialYear2)

            ' Assert.
            Assert.IsTrue(equalResult)
        End Sub

        <TestMethod()> Public Sub FinancialYearsWithUsedTransactionList_ShouldBeEqual_WhenSameObjects()
            ' Arrange.
            Dim transaction As New Transaction()
            With transaction
                .Amount = 100
                .Description = "Test transaction"
                .TransactionDate = Date.Now
                .TransferType = TransactionType.Receipt
            End With

            Dim financialYear As New FinancialYear()
            With financialYear
                .Transactions = New List(Of Transaction)
                With .Transactions
                    .Add(transaction)
                End With
            End With

            ' Act.
            Dim equalResult = financialYear.Equals(financialYear)

            ' Assert.
            Assert.IsTrue(equalResult)
        End Sub

        <TestMethod()> Public Sub FinancialYearsWithUsedTransactionList_ShouldBeEqual_WhenSimilarObjects()
            ' Arrange.
            Dim transaction1 As New Transaction()
            With transaction1
                .Amount = 100
                .Description = "Test transaction"
                .TransactionDate = Date.Now
                .TransferType = TransactionType.Receipt
            End With

            Dim financialYear1 As New FinancialYear()
            With financialYear1
                .Transactions = New List(Of Transaction)
                With .Transactions
                    .Add(transaction1)
                End With
            End With

            Dim transaction2 As New Transaction()
            With transaction2
                .Amount = 100
                .Description = "Test transaction"
                .TransactionDate = Date.Now
                .TransferType = TransactionType.Receipt
            End With

            Dim financialYear2 As New FinancialYear()
            With financialYear2
                .Transactions = New List(Of Transaction)
                With .Transactions
                    .Add(transaction2)
                End With
            End With

            ' Act.
            Dim equalResult = financialYear1.Equals(financialYear2)

            ' Assert.
            Assert.IsTrue(equalResult)
        End Sub

        <TestMethod()> Public Sub FinancialYearsWithUsedTransactionList_ShouldNotBeEqual_WhenObjectsAreDifferent()
            ' Arrange.
            Dim transaction1 As New Transaction()
            With transaction1
                .Amount = 100
                .Description = "Test transaction"
                .TransactionDate = Date.Now
                .TransferType = TransactionType.Receipt
            End With

            Dim financialYear1 As New FinancialYear()
            With financialYear1
                .Transactions = New List(Of Transaction)
                With .Transactions
                    .Add(transaction1)
                End With
            End With

            Dim transaction2 As New Transaction()
            With transaction2
                .Amount = 500
                .Description = "Another transaction"
                .TransactionDate = Date.Now
                .TransferType = TransactionType.Payment
            End With

            Dim financialYear2 As New FinancialYear()
            With financialYear2
                .Transactions = New List(Of Transaction)
                With .Transactions
                    .Add(transaction2)
                End With
            End With

            ' Act.
            Dim equalResult = financialYear1.Equals(financialYear2)

            ' Assert.
            Assert.IsFalse(equalResult)
        End Sub

        <TestMethod()> Public Sub FinancialYears_ShouldNotBeEqual_WhenObjectOfWrongType()
            ' Arrange.
            Dim financialYear As New FinancialYear()
            With financialYear
                .Transactions = Nothing
            End With

            ' Act.
            Dim equalResult = financialYear.Equals("compare string.")

            ' Assert.
            Assert.IsFalse(equalResult)
        End Sub

#End Region

#Region "Operator = tests"

        <TestMethod()> Public Sub EmptyFinancialYears_Operator_ShouldBeEqual_WhenSameObjects()
            ' Arrange.
            Dim financialYear As New FinancialYear()
            With financialYear
                .Transactions = Nothing
            End With

            ' Act.
            Dim equalResult = financialYear = financialYear

            ' Assert.
            Assert.IsTrue(equalResult)
        End Sub

        <TestMethod()> Public Sub EmptyFinancialYears_Operator_ShouldBeEqual_WhenSimilarObjects()
            ' Arrange.
            Dim financialYear1 As New FinancialYear()
            With financialYear1
                .Transactions = Nothing
            End With

            Dim financialYear2 As New FinancialYear()
            With financialYear2
                .Transactions = Nothing
            End With

            ' Act.
            Dim equalResult = financialYear1 = financialYear2

            ' Assert.
            Assert.IsTrue(equalResult)
        End Sub

        <TestMethod()> Public Sub EmptyFinancialYears_Operator_ShouldNotBeEqual_WhenOneObjectIsNothing()
            ' Arrange.
            Dim financialYear As New FinancialYear()
            With financialYear
                .Transactions = Nothing
            End With

            ' Act.
            Dim equalResult = financialYear = Nothing

            ' Assert.
            Assert.IsFalse(equalResult)
        End Sub

        <TestMethod()> Public Sub FinancialYearsWithEmptyTransactionList_Operator_ShouldBeEqual_WhenSameObjects()
            ' Arrange.
            Dim financialYear As New FinancialYear()
            With financialYear
                .Transactions = New List(Of Transaction)
            End With

            ' Act.
            Dim equalResult = financialYear = financialYear

            ' Assert.
            Assert.IsTrue(equalResult)
        End Sub

        <TestMethod()> Public Sub FinancialYearsWithEmptyTransactionList_Operator_ShouldBeEqual_WhenSimilarObjects()
            ' Arrange.
            Dim financialYear1 As New FinancialYear()
            With financialYear1
                .Transactions = New List(Of Transaction)
            End With

            Dim financialYear2 As New FinancialYear()
            With financialYear2
                .Transactions = New List(Of Transaction)
            End With

            ' Act.
            Dim equalResult = financialYear1 = financialYear2

            ' Assert.
            Assert.IsTrue(equalResult)
        End Sub

        <TestMethod()> Public Sub FinancialYearsWithUsedTransactionList_Operator_ShouldBeEqual_WhenSameObjects()
            ' Arrange.
            Dim transaction As New Transaction()
            With transaction
                .Amount = 100
                .Description = "Test transaction"
                .TransactionDate = Date.Now
                .TransferType = TransactionType.Receipt
            End With

            Dim financialYear As New FinancialYear()
            With financialYear
                .Transactions = New List(Of Transaction)
                With .Transactions
                    .Add(transaction)
                End With
            End With

            ' Act.
            Dim equalResult = financialYear = financialYear

            ' Assert.
            Assert.IsTrue(equalResult)
        End Sub

        <TestMethod()> Public Sub FinancialYearsWithUsedTransactionList_Operator_ShouldBeEqual_WhenSimilarObjects()
            ' Arrange.
            Dim transaction1 As New Transaction()
            With transaction1
                .Amount = 100
                .Description = "Test transaction"
                .TransactionDate = Date.Now
                .TransferType = TransactionType.Receipt
            End With

            Dim financialYear1 As New FinancialYear()
            With financialYear1
                .Transactions = New List(Of Transaction)
                With .Transactions
                    .Add(transaction1)
                End With
            End With

            Dim transaction2 As New Transaction()
            With transaction2
                .Amount = 100
                .Description = "Test transaction"
                .TransactionDate = Date.Now
                .TransferType = TransactionType.Receipt
            End With

            Dim financialYear2 As New FinancialYear()
            With financialYear2
                .Transactions = New List(Of Transaction)
                With .Transactions
                    .Add(transaction2)
                End With
            End With

            ' Act.
            Dim equalResult = financialYear1 = financialYear2

            ' Assert.
            Assert.IsTrue(equalResult)
        End Sub

        <TestMethod()> Public Sub FinancialYearsWithUsedTransactionList_Operator_ShouldNotBeEqual_WhenObjectsAreDifferent()
            ' Arrange.
            Dim transaction1 As New Transaction()
            With transaction1
                .Amount = 100
                .Description = "Test transaction"
                .TransactionDate = Date.Now
                .TransferType = TransactionType.Receipt
            End With

            Dim financialYear1 As New FinancialYear()
            With financialYear1
                .Transactions = New List(Of Transaction)
                With .Transactions
                    .Add(transaction1)
                End With
            End With

            Dim transaction2 As New Transaction()
            With transaction2
                .Amount = 500
                .Description = "Another transaction"
                .TransactionDate = Date.Now
                .TransferType = TransactionType.Payment
            End With

            Dim financialYear2 As New FinancialYear()
            With financialYear2
                .Transactions = New List(Of Transaction)
                With .Transactions
                    .Add(transaction2)
                End With
            End With

            ' Act.
            Dim equalResult = financialYear1 = financialYear2

            ' Assert.
            Assert.IsFalse(equalResult)
        End Sub

#End Region

#Region "Operator <> tests"

        <TestMethod()> Public Sub EmptyFinancialYears_Operator_ShouldNotBeDifferent_WhenSameObjects()
            ' Arrange.
            Dim financialYear As New FinancialYear()
            With financialYear
                .Transactions = Nothing
            End With

            ' Act.
            Dim equalResult = financialYear <> financialYear

            ' Assert.
            Assert.IsFalse(equalResult)
        End Sub

        <TestMethod()> Public Sub EmptyFinancialYears_Operator_ShouldNotBeDifferent_WhenSimilarObjects()
            ' Arrange.
            Dim financialYear1 As New FinancialYear()
            With financialYear1
                .Transactions = Nothing
            End With

            Dim financialYear2 As New FinancialYear()
            With financialYear2
                .Transactions = Nothing
            End With

            ' Act.
            Dim equalResult = financialYear1 <> financialYear2

            ' Assert.
            Assert.IsFalse(equalResult)
        End Sub

        <TestMethod()> Public Sub EmptyFinancialYears_Operator_ShouldBeDifferent_WhenOneObjectIsNothing()
            ' Arrange.
            Dim financialYear As New FinancialYear()
            With financialYear
                .Transactions = Nothing
            End With

            ' Act.
            Dim equalResult = financialYear <> Nothing

            ' Assert.
            Assert.IsTrue(equalResult)
        End Sub

        <TestMethod()> Public Sub FinancialYearsWithEmptyTransactionList_Operator_ShouldNotBeDifferent_WhenSameObjects()
            ' Arrange.
            Dim financialYear As New FinancialYear()
            With financialYear
                .Transactions = New List(Of Transaction)
            End With

            ' Act.
            Dim equalResult = financialYear <> financialYear

            ' Assert.
            Assert.IsFalse(equalResult)
        End Sub

        <TestMethod()> Public Sub FinancialYearsWithEmptyTransactionList_Operator_ShouldNotBeDifferent_WhenSimilarObjects()
            ' Arrange.
            Dim financialYear1 As New FinancialYear()
            With financialYear1
                .Transactions = New List(Of Transaction)
            End With

            Dim financialYear2 As New FinancialYear()
            With financialYear2
                .Transactions = New List(Of Transaction)
            End With

            ' Act.
            Dim equalResult = financialYear1 <> financialYear2

            ' Assert.
            Assert.IsFalse(equalResult)
        End Sub

        <TestMethod()> Public Sub FinancialYearsWithUsedTransactionList_Operator_ShouldNotBeDifferent_WhenSameObjects()
            ' Arrange.
            Dim transaction As New Transaction()
            With transaction
                .Amount = 100
                .Description = "Test transaction"
                .TransactionDate = Date.Now
                .TransferType = TransactionType.Receipt
            End With

            Dim financialYear As New FinancialYear()
            With financialYear
                .Transactions = New List(Of Transaction)
                With .Transactions
                    .Add(transaction)
                End With
            End With

            ' Act.
            Dim equalResult = financialYear <> financialYear

            ' Assert.
            Assert.IsFalse(equalResult)
        End Sub

        <TestMethod()> Public Sub FinancialYearsWithUsedTransactionList_Operator_ShouldNotBeDifferent_WhenSimilarObjects()
            ' Arrange.
            Dim transaction1 As New Transaction()
            With transaction1
                .Amount = 100
                .Description = "Test transaction"
                .TransactionDate = Date.Now
                .TransferType = TransactionType.Receipt
            End With

            Dim financialYear1 As New FinancialYear()
            With financialYear1
                .Transactions = New List(Of Transaction)
                With .Transactions
                    .Add(transaction1)
                End With
            End With

            Dim transaction2 As New Transaction()
            With transaction2
                .Amount = 100
                .Description = "Test transaction"
                .TransactionDate = Date.Now
                .TransferType = TransactionType.Receipt
            End With

            Dim financialYear2 As New FinancialYear()
            With financialYear2
                .Transactions = New List(Of Transaction)
                With .Transactions
                    .Add(transaction2)
                End With
            End With

            ' Act.
            Dim equalResult = financialYear1 <> financialYear2

            ' Assert.
            Assert.IsFalse(equalResult)
        End Sub

        <TestMethod()> Public Sub FinancialYearsWithUsedTransactionList_Operator_ShouldBeDifferent_WhenObjectsAreDifferent()
            ' Arrange.
            Dim transaction1 As New Transaction()
            With transaction1
                .Amount = 100
                .Description = "Test transaction"
                .TransactionDate = Date.Now
                .TransferType = TransactionType.Receipt
            End With

            Dim financialYear1 As New FinancialYear()
            With financialYear1
                .Transactions = New List(Of Transaction)
                With .Transactions
                    .Add(transaction1)
                End With
            End With

            Dim transaction2 As New Transaction()
            With transaction2
                .Amount = 500
                .Description = "Another transaction"
                .TransactionDate = Date.Now
                .TransferType = TransactionType.Payment
            End With

            Dim financialYear2 As New FinancialYear()
            With financialYear2
                .Transactions = New List(Of Transaction)
                With .Transactions
                    .Add(transaction2)
                End With
            End With

            ' Act.
            Dim equalResult = financialYear1 <> financialYear2

            ' Assert.
            Assert.IsTrue(equalResult)
        End Sub

#End Region

    End Class

End Namespace