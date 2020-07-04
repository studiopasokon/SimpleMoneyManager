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
