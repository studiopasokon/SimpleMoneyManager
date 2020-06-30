Option Compare Binary
Option Explicit On
Option Infer On
Option Strict On

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
            ' TODO: set up the data context.
            Throw New NotImplementedException()
        End Sub

#End Region

#Region "Properties"

        ''' <summary>
        ''' Contains all loaded financial data.
        ''' </summary>
        ''' <returns>A list containing all loaded financial data.</returns>
        Friend Property FinancialYearDataSet As List(Of String)

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
