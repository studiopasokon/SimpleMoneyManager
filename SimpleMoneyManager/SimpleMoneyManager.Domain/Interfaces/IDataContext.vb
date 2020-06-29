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
