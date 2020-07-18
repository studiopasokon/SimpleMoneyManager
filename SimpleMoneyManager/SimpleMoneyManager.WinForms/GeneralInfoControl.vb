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
''' Control for handling the general information like year selection and total transaction amounts.
''' </summary>
Public Class GeneralInfoControl
    ''' <summary>
    ''' Adds a new year item to the drop down box.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub AddNewYearButton_Click(sender As Object, e As EventArgs) Handles AddNewYearButton.Click
        ' Get the new value from the user.
        Dim newYearValue = InputBox("Please enter the new year value to add.", "New Year Value", DateTime.Today.Year.ToString())
        newYearValue = newYearValue.Trim()

        ' Add it to the list.
        If IsNumeric(newYearValue) Then
            If Not SelectedYear.Items.Contains(newYearValue) Then
                SelectedYear.Items.Add(newYearValue)
            Else
                MessageBox.Show(Me, "This value is already present in the list", "Incorrect value", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else
                MessageBox.Show(Me, "No proper value entered", "Incorrect value", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class
