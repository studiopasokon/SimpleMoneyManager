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
Imports SimpleMoneyManager.Infrastructure.DataContext

''' <summary>
''' Test class that checks the internals of the <see cref="TextFileDataContext"/> entity.
''' </summary>
<TestClass()> Public Class TextFileDataContextTests

    Private _localPath As String
    Private _localDataFile As String

    <TestInitialize> Public Sub TestInit()
        _localPath = Directory.GetCurrentDirectory()
        _localDataFile = Path.Combine(_localPath, TextFileDataContext.DataFileName)
    End Sub

#Region "Constructor Tests"

    <DataTestMethod()>
    <DataRow(Nothing)>
    <DataRow("")>
    Public Sub Instantiate_ShouldThrowException_WhenEmptyDataPath(path As String)
        ' Arrange / Act.
        Dim instantiate As Action = Sub()
                                        Dim dataContext As New TextFileDataContext(path)
                                    End Sub

        ' Assert.
        Assert.ThrowsException(Of ArgumentNullException)(instantiate)
    End Sub

    <TestMethod> Public Sub Instantiate_ShouldThrowException_WhenNonExistingDataPath()
        ' Arrange.
        Const nonExistingPath As String = "c:\nonexisting"

        ' Act.
        Dim instantiate As Action = Sub()
                                        Dim dataContext As New TextFileDataContext(nonExistingPath)
                                    End Sub

        ' Assert.
        Assert.ThrowsException(Of DirectoryNotFoundException)(instantiate)
    End Sub

#End Region

#Region "Connect Tests"

    <TestMethod()> Public Sub LoadDataFile_ShouldGiveEmptyDataSet_WhenNoDataFile()
        ' Arrange.
        Dim dataContext As New TextFileDataContext(_localPath)

        ' Act.
        dataContext.Connect()

        ' Assert.
        Assert.IsNotNull(dataContext.FinancialYearDataSet)
        Assert.AreEqual(0, dataContext.FinancialYearDataSet.Count)
    End Sub

    <TestMethod()> Public Sub LoadDataFile_ShouldGiveEmptyDataSet_WhenEmptyFile()
        ' Arrange.
        File.Create(_localDataFile).Dispose()
        Dim dataContext As New TextFileDataContext(_localPath)

        ' Act.
        dataContext.Connect()

        ' Assert.
        Assert.IsNotNull(dataContext.FinancialYearDataSet)
        Assert.AreEqual(0, dataContext.FinancialYearDataSet.Count)
    End Sub

    <TestMethod()> Public Sub LoadDataFile_ShouldThrowException_WhenIncorrectHeader()
        ' Arrange.
        ' TODO: add writing some faulty data to the file.
        File.Create(_localDataFile).Dispose()
        Dim dataContext As New TextFileDataContext(_localPath)

        ' Act.
        Dim instantiate As Action = Sub() dataContext.Connect()

        ' Assert.
        ' TODO: catch proper exception.
        Assert.ThrowsException(Of Exception)(instantiate)
    End Sub

    <TestMethod()> Public Sub LoadDataFile_ShouldThrowException_WhenIncorrectTransactions()
        ' Arrange.
        ' TODO: add writing some faulty data to the file.
        File.Create(_localDataFile).Dispose()
        Dim dataContext As New TextFileDataContext(_localPath)

        ' Act.
        Dim instantiate As Action = Sub() dataContext.Connect()

        ' Assert.
        ' TODO: catch proper exception.
        Assert.ThrowsException(Of Exception)(instantiate)
    End Sub

    <TestMethod()> Public Sub LoadDataFile_ShouldCreateDataSet_WhenCorrectData()
        ' Arrange.
        ' TODO: add writing correct data to the file.
        File.Create(_localDataFile).Dispose()
        Dim dataContext As New TextFileDataContext(_localPath)

        ' Act.
        dataContext.Connect()

        ' Assert.
        ' TODO: check on data in the data set.
    End Sub

#End Region

End Class