Option Compare Binary
Option Explicit On
Option Infer On
Option Strict On

Imports SimpleMoneyManager.Domain.Entities

Namespace Interfaces

    ''' <summary>
    ''' Interface class defining access to all repositories, and data loading and saving.
    ''' </summary>
    Public Interface IDataContext

#Region "Repositories"

        ''' <summary>
        ''' Property referring to the <see cref="FinancialYear"/> repository data set.
        ''' </summary>
        ''' <returns>An active financial year repository.</returns>
        Property FinancialYearDataSet As IRepository(Of FinancialYear)

        ''' <summary>
        ''' Property referring to the <see cref="Transaction"/> repository data set.
        ''' </summary>
        ''' <returns>An active transaction repository.</returns>
        Property TransactionDataSet As IRepository(Of Transaction)

#End Region

#Region "Procedures"

        ''' <summary>
        ''' Connecting the data context to the actual data storage.
        ''' </summary>
        Sub Connect()

        ''' <summary>
        ''' Commiting or saving any data changes to the real data storage.
        ''' </summary>
        Sub Commit()

#End Region

    End Interface

End Namespace
