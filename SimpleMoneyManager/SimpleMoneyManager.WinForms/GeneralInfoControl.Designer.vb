<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GeneralInfoControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TotalAmountLabel = New System.Windows.Forms.Label()
        Me.SpentAmountLabel = New System.Windows.Forms.Label()
        Me.AvailableAmountLabel = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SelectedYear = New System.Windows.Forms.ComboBox()
        Me.AddNewYearButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Total Amount:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(5, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Spent Amount:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(5, 171)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Available Amount:"
        '
        'TotalAmountLabel
        '
        Me.TotalAmountLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TotalAmountLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalAmountLabel.Location = New System.Drawing.Point(148, 92)
        Me.TotalAmountLabel.Name = "TotalAmountLabel"
        Me.TotalAmountLabel.Size = New System.Drawing.Size(167, 31)
        Me.TotalAmountLabel.TabIndex = 3
        Me.TotalAmountLabel.Text = "$100.00"
        '
        'SpentAmountLabel
        '
        Me.SpentAmountLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SpentAmountLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SpentAmountLabel.Location = New System.Drawing.Point(148, 123)
        Me.SpentAmountLabel.Name = "SpentAmountLabel"
        Me.SpentAmountLabel.Size = New System.Drawing.Size(167, 31)
        Me.SpentAmountLabel.TabIndex = 4
        Me.SpentAmountLabel.Text = "$100.00"
        '
        'AvailableAmountLabel
        '
        Me.AvailableAmountLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.AvailableAmountLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AvailableAmountLabel.Location = New System.Drawing.Point(148, 170)
        Me.AvailableAmountLabel.Name = "AvailableAmountLabel"
        Me.AvailableAmountLabel.Size = New System.Drawing.Size(167, 31)
        Me.AvailableAmountLabel.TabIndex = 5
        Me.AvailableAmountLabel.Text = "$100.00"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(5, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 17)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Selected Year:"
        '
        'SelectedYear
        '
        Me.SelectedYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SelectedYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SelectedYear.FormattingEnabled = True
        Me.SelectedYear.Location = New System.Drawing.Point(148, 7)
        Me.SelectedYear.Name = "SelectedYear"
        Me.SelectedYear.Size = New System.Drawing.Size(167, 24)
        Me.SelectedYear.Sorted = True
        Me.SelectedYear.TabIndex = 7
        '
        'AddNewYearButton
        '
        Me.AddNewYearButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddNewYearButton.Location = New System.Drawing.Point(331, 7)
        Me.AddNewYearButton.Name = "AddNewYearButton"
        Me.AddNewYearButton.Size = New System.Drawing.Size(66, 29)
        Me.AddNewYearButton.TabIndex = 8
        Me.AddNewYearButton.Text = "&Add"
        Me.AddNewYearButton.UseVisualStyleBackColor = True
        '
        'GeneralInfoControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.AddNewYearButton)
        Me.Controls.Add(Me.SelectedYear)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.AvailableAmountLabel)
        Me.Controls.Add(Me.SpentAmountLabel)
        Me.Controls.Add(Me.TotalAmountLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "GeneralInfoControl"
        Me.Size = New System.Drawing.Size(416, 212)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TotalAmountLabel As Label
    Friend WithEvents SpentAmountLabel As Label
    Friend WithEvents AvailableAmountLabel As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents SelectedYear As ComboBox
    Friend WithEvents AddNewYearButton As Button
End Class
