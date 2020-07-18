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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(183, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Total Amount:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(4, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(193, 31)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Spent Amount:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(4, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(232, 31)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Available Amount:"
        '
        'TotalAmountLabel
        '
        Me.TotalAmountLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TotalAmountLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalAmountLabel.Location = New System.Drawing.Point(256, 3)
        Me.TotalAmountLabel.Name = "TotalAmountLabel"
        Me.TotalAmountLabel.Size = New System.Drawing.Size(210, 31)
        Me.TotalAmountLabel.TabIndex = 3
        Me.TotalAmountLabel.Text = "$100.00"
        '
        'SpentAmountLabel
        '
        Me.SpentAmountLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SpentAmountLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SpentAmountLabel.Location = New System.Drawing.Point(256, 34)
        Me.SpentAmountLabel.Name = "SpentAmountLabel"
        Me.SpentAmountLabel.Size = New System.Drawing.Size(210, 31)
        Me.SpentAmountLabel.TabIndex = 4
        Me.SpentAmountLabel.Text = "$100.00"
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(256, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(210, 31)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "$100.00"
        '
        'GeneralInfoControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.SpentAmountLabel)
        Me.Controls.Add(Me.TotalAmountLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "GeneralInfoControl"
        Me.Size = New System.Drawing.Size(490, 124)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TotalAmountLabel As Label
    Friend WithEvents SpentAmountLabel As Label
    Friend WithEvents Label4 As Label
End Class
