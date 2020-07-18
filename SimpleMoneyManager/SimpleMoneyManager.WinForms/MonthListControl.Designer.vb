<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MonthListControl
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MonthNameLabel = New System.Windows.Forms.Label()
        Me.TransactionDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TransactionDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TransactionAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EditButton = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.DeleteButton = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TransactionDate, Me.TransactionDescription, Me.TransactionAmount, Me.EditButton, Me.DeleteButton})
        Me.DataGridView1.Location = New System.Drawing.Point(5, 34)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(716, 172)
        Me.DataGridView1.TabIndex = 0
        '
        'MonthNameLabel
        '
        Me.MonthNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MonthNameLabel.Location = New System.Drawing.Point(3, 0)
        Me.MonthNameLabel.Name = "MonthNameLabel"
        Me.MonthNameLabel.Size = New System.Drawing.Size(307, 31)
        Me.MonthNameLabel.TabIndex = 1
        Me.MonthNameLabel.Text = "MonthName"
        '
        'TransactionDate
        '
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TransactionDate.DefaultCellStyle = DataGridViewCellStyle1
        Me.TransactionDate.HeaderText = "Date"
        Me.TransactionDate.MinimumWidth = 6
        Me.TransactionDate.Name = "TransactionDate"
        Me.TransactionDate.ReadOnly = True
        Me.TransactionDate.Width = 125
        '
        'TransactionDescription
        '
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.TransactionDescription.DefaultCellStyle = DataGridViewCellStyle2
        Me.TransactionDescription.HeaderText = "Description"
        Me.TransactionDescription.MinimumWidth = 6
        Me.TransactionDescription.Name = "TransactionDescription"
        Me.TransactionDescription.ReadOnly = True
        Me.TransactionDescription.Width = 125
        '
        'TransactionAmount
        '
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.TransactionAmount.DefaultCellStyle = DataGridViewCellStyle3
        Me.TransactionAmount.HeaderText = "Amount"
        Me.TransactionAmount.MinimumWidth = 6
        Me.TransactionAmount.Name = "TransactionAmount"
        Me.TransactionAmount.ReadOnly = True
        Me.TransactionAmount.Width = 125
        '
        'EditButton
        '
        Me.EditButton.HeaderText = "Edit"
        Me.EditButton.MinimumWidth = 6
        Me.EditButton.Name = "EditButton"
        Me.EditButton.ReadOnly = True
        Me.EditButton.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.EditButton.Text = "Edit"
        Me.EditButton.Width = 50
        '
        'DeleteButton
        '
        Me.DeleteButton.HeaderText = "Delete"
        Me.DeleteButton.MinimumWidth = 6
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.ReadOnly = True
        Me.DeleteButton.Text = "Delete"
        Me.DeleteButton.Width = 50
        '
        'MonthListControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.MonthNameLabel)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "MonthListControl"
        Me.Size = New System.Drawing.Size(786, 213)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents MonthNameLabel As Label
    Friend WithEvents TransactionDate As DataGridViewTextBoxColumn
    Friend WithEvents TransactionDescription As DataGridViewTextBoxColumn
    Friend WithEvents TransactionAmount As DataGridViewTextBoxColumn
    Friend WithEvents EditButton As DataGridViewButtonColumn
    Friend WithEvents DeleteButton As DataGridViewButtonColumn
End Class
