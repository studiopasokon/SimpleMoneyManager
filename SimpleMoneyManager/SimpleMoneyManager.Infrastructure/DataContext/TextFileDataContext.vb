﻿Option Compare Binary
Option Explicit On
Option Infer On
Option Strict On

Imports SimpleMoneyManager.Domain.Entities
Imports SimpleMoneyManager.Domain.Interfaces

Namespace DataContext

    ''' <summary>
    ''' Data context implementation on top of text files.
    ''' </summary>
    Public Class TextFileDataContext : Implements IDataContext

#Region "Construction"

        ''' <summary>
        ''' Data context construction.
        ''' </summary>
        Public Sub TextFileDataContext()
            ' TODO: instantiate the different repositories.
        End Sub

#End Region

#Region "Properties"

        ''' <inheritdoc />
        Public Property FinancialYearDataSet As IRepository(Of FinancialYear) Implements IDataContext.FinancialYearDataSet

        ''' <inheritdoc />
        Public Property TransactionDataSet As IRepository(Of Transaction) Implements IDataContext.TransactionDataSet

#End Region

#Region "Procedures"

        ''' <inheritdoc />
        Public Sub Connect() Implements IDataContext.Connect
            ' TODO: implement loading the data files.
            Throw New NotImplementedException()
        End Sub

        ''' <inheritdoc />
        Public Sub Commit() Implements IDataContext.Commit
            ' TODO: implement backing up the old data files and saving the modified data.

            Throw New NotImplementedException()
        End Sub

#End Region

    End Class

End Namespace