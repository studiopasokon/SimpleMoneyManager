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

Imports SimpleMoneyManager.Domain.Interfaces

Namespace DataContext

    ''' <summary>
    ''' Data context implementation on top of text files.
    ''' </summary>
    Public Class TextFileDataContext : Implements IDataContext

#Region "Fields"

        ''' <summary>
        ''' Contains path where all data files are stored.
        ''' </summary>
        Private _dataPath As String

#End Region

#Region "Construction"

        ''' <summary>
        ''' Data context construction.
        ''' </summary>
        ''' <param name="dataPath">Path where the data files can be found.</param>
        Public Sub New(dataPath As String)
            _dataPath = dataPath
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
