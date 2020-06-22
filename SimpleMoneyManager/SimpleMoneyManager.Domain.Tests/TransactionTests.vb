Option Compare Binary
Option Explicit On
Option Infer On
Option Strict On

Imports SimpleMoneyManager.Domain.SimpleMoneyManager.Domain

Namespace SimpleMoneyManager.Domain.Tests

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

End Namespace