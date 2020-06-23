Option Compare Binary
Option Explicit On
Option Infer On
Option Strict On

Imports SimpleMoneyManager.Domain.SimpleMoneyManager.Domain

Namespace SimpleMoneyManager.Domain.Tests

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

        ' TODO: add tests for operator = and <>.

    End Class

End Namespace