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

''' <summary>
''' Main application window.
''' </summary>
Public Class MainWindow

    Private generalInfo As GeneralInfoControl

    ''' <summary>
    ''' Handler closing the application.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    ''' <summary>
    ''' Change the input control for the proper month.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub MonthSelector_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles MonthSelector.AfterSelect
        SplitterMainWindow.Panel2.Controls.Clear()
        SplitterMainWindow.Panel2.Controls.Add(CType(e.Node.Tag, Control))
    End Sub

    ''' <summary>
    ''' Prepare all input controls for each month.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub MainWindow_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Setup the main information panel.
        MonthSelector.Nodes(0).Tag = New GeneralInfoControl()

        ' Prepare the panels for each month.
        For i As Integer = 1 To 12
            Dim selectedNode = MonthSelector.Nodes(i)
            selectedNode.Tag = New MonthListControl(selectedNode.Text)
        Next
    End Sub

End Class
