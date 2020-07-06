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

Imports System.IO
Imports SimpleMoneyManager.Domain.Interfaces

Namespace DataContext

    ''' <summary>
    ''' Data context implementation on top of text files.
    ''' </summary>
    Public Class TextFileDataContext : Implements IDataContext

#Region "Constants"

        Public Const DataFileName As String = "SimpleMoneyManager.dat"

#End Region

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
        ''' <exception cref="ArgumentNullException">When <paramref name="dataPath"/> is nothing, empty or whitespace.</exception>
        ''' <exception cref="DirectoryNotFoundException">When <paramref name="dataPath"/> does not exist on disk.</exception>
        Public Sub New(dataPath As String)
            ' Parameter sanity check.
            If String.IsNullOrWhiteSpace(dataPath) Then
                Throw New ArgumentNullException(NameOf(dataPath), "Data file storage path is mandatory")
            End If

            ' Checking for the existance of the path.
            If Not Directory.Exists(dataPath) Then
                Throw New DirectoryNotFoundException($"Data file path not found: {dataPath}")
            End If

            _dataPath = dataPath
            FinancialYearDataSet = New List(Of String())
        End Sub

#End Region

#Region "Properties"

        ''' <summary>
        ''' Contains all loaded financial data.
        ''' </summary>
        ''' <returns>A list containing all loaded financial data.</returns>
        Friend Property FinancialYearDataSet As List(Of String())

#End Region

#Region "API Procedures"

        ''' <inheritdoc />
        Public Sub Connect() Implements IDataContext.Connect
            ' Check whether the data file exists in the path, and load if it does.
            Dim fullPath As String = Path.Combine(_dataPath, DataFileName)
            If File.Exists(fullPath) Then
                Dim dataFileContents = File.ReadAllLines(fullPath, Text.Encoding.UTF8)

                ' Empty file must be ignored.
                If dataFileContents.Length = 0 Then
                    Return
                End If

                ' Check the header.
                If Not IsCorrectDataFileHeader(dataFileContents(0)) Then
                    Throw New InvalidDataException("Data file header doesn't have the correct format")
                End If

                ' Load the rest of the data, skipping the header.
                For Each dataLine In dataFileContents.Skip(1)
                    If Not LoadDataLine(dataLine) Then
                        ' Loading and parsing of the data line failed.
                        Throw New InvalidDataException("Faulty data was found in the data file")
                    End If
                Next
            End If
        End Sub

        ''' <inheritdoc />
        Public Sub Commit() Implements IDataContext.Commit
            ' TODO: implement backing up the old data files and saving the modified data.

            Throw New NotImplementedException()
        End Sub

#End Region

#Region "Suppport Procedures and Functions"

        ''' <summary>
        ''' Checks whether the given string is a correct header line.
        ''' </summary>
        ''' <param name="headerLine">The string to check.</param>
        ''' <returns>True if <paramref name="headerLine"/> contains a real header, otherwise False is returned.</returns>
        Private Function IsCorrectDataFileHeader(ByRef headerLine As String) As Boolean
            If Not headerLine = "SimpleMoneyManager_v1" Then
                Return False
            End If

            Return True
        End Function

        Private Function LoadDataLine(ByRef dataLine As String) As Boolean
            ' Split the line according format - year#date#description#amount#transactiontype
            Dim dataParts = dataLine.Split(New Char() {"#"c}, StringSplitOptions.RemoveEmptyEntries)

            ' If there are less or more parts, we may assume the line is missing data or extra data is added.
            If dataParts.Length <> 5 Then
                Return False
            End If

            ' For now, no extra checking is done, this can be added later.
            ' Just store the information in the data set.
            FinancialYearDataSet.Add(dataParts)
            Return True
        End Function

#End Region

    End Class

End Namespace
