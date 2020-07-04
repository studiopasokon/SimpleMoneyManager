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

#Region "Constructor Tests"

    <DataTestMethod()>
    <DataRow(Nothing)>
    <DataRow("")>
    Public Sub LoadDataFile_ShouldThrowException_WhenEmptyDataPath(path As String)
        ' Arrange / Act.
        Dim instantiate As Action = Sub()
                                        Dim dataContext As New TextFileDataContext(path)
                                    End Sub

        ' Assert.
        Assert.ThrowsException(Of ArgumentNullException)(instantiate)
    End Sub

    <TestMethod> Public Sub LoadDataFile_ShouldThrowException_WhenNonExistingDataPath()
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

    <TestMethod()> Public Sub LoadDataFile_ShouldGiveEmptyDataSet_WhenNoDataFile()
        ' TODO: code test.
        ' Arrange.
        'Dim dataContext As New TextFileDataContext(path)

        ' Act.
        'DataContext.Connect()

        ' Assert.
        'Assert.IsNotNull(dataContext.FinancialYearDataSet)
        'Assert.AreEqual(0, dataContext.FinancialYearDataSet.Count)
        Assert.Fail()
    End Sub

    <TestMethod()> Public Sub LoadDataFile_ShouldGiveEmptyDataSet_WhenEmptyFile()
        ' TODO: code test.
        ' Arrange.
        'Dim dataContext As New TextFileDataContext(path)

        ' Act.
        'DataContext.Connect()

        ' Assert.
        'Assert.IsNotNull(dataContext.FinancialYearDataSet)
        'Assert.AreEqual(0, dataContext.FinancialYearDataSet.Count)
        Assert.Fail()
    End Sub

    <TestMethod()> Public Sub LoadDataFile_ShouldThrowException_WhenIncorrectHeader()
        ' TODO: code test.
        ' Arrange.
        ' Act.
        ' Assert.
        Assert.Fail()
    End Sub

    <TestMethod()> Public Sub LoadDataFile_ShouldThrowException_WhenIncorrectTransactions()
        ' TODO: code test.
        ' Arrange.
        ' Act.
        ' Assert.
        Assert.Fail()
    End Sub

    <TestMethod()> Public Sub LoadDataFile_ShouldCreateDataSet_WhenCorrectData()
        ' TODO: code test.
        ' Arrange.
        ' Act.
        ' Assert.
        Assert.Fail()
    End Sub

End Class