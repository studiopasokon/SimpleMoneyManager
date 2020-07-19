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
        Me.TransactionDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TransactionDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TransactionAmountPayed = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TransactionAmountReceived = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EditButton = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.DeleteButton = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.MonthNameLabel = New System.Windows.Forms.Label()
        Me.AddTransactionButton = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TransactionDate, Me.TransactionDescription, Me.TransactionAmountPayed, Me.TransactionAmountReceived, Me.EditButton, Me.DeleteButton})
        Me.DataGridView1.Location = New System.Drawing.Point(5, 34)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(714, 216)
        Me.DataGridView1.TabIndex = 0
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
        'TransactionAmountPayed
        '
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.TransactionAmountPayed.DefaultCellStyle = DataGridViewCellStyle3
        Me.TransactionAmountPayed.HeaderText = "Amount Payed"
        Me.TransactionAmountPayed.MinimumWidth = 6
        Me.TransactionAmountPayed.Name = "TransactionAmountPayed"
        Me.TransactionAmountPayed.ReadOnly = True
        Me.TransactionAmountPayed.Width = 125
        '
        'TransactionAmountReceived
        '
        Me.TransactionAmountReceived.HeaderText = "Amount Received"
        Me.TransactionAmountReceived.MinimumWidth = 6
        Me.TransactionAmountReceived.Name = "TransactionAmountReceived"
        Me.TransactionAmountReceived.ReadOnly = True
        Me.TransactionAmountReceived.Width = 125
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
        'MonthNameLabel
        '
        Me.MonthNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MonthNameLabel.Location = New System.Drawing.Point(3, 0)
        Me.MonthNameLabel.Name = "MonthNameLabel"
        Me.MonthNameLabel.Size = New System.Drawing.Size(307, 31)
        Me.MonthNameLabel.TabIndex = 1
        Me.MonthNameLabel.Text = "MonthName"
        '
        'AddTransactionButton
        '
        Me.AddTransactionButton.Location = New System.Drawing.Point(596, 256)
        Me.AddTransactionButton.Name = "AddTransactionButton"
        Me.AddTransactionButton.Size = New System.Drawing.Size(123, 23)
        Me.AddTransactionButton.TabIndex = 2
        Me.AddTransactionButton.Text = "&Add Transaction"
        Me.AddTransactionButton.UseVisualStyleBackColor = True
        '
        'MonthListControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.AddTransactionButton)
        Me.Controls.Add(Me.MonthNameLabel)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "MonthListControl"
        Me.Size = New System.Drawing.Size(786, 291)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents MonthNameLabel As Label
    Friend WithEvents TransactionDate As DataGridViewTextBoxColumn
    Friend WithEvents TransactionDescription As DataGridViewTextBoxColumn
    Friend WithEvents TransactionAmountPayed As DataGridViewTextBoxColumn
    Friend WithEvents TransactionAmountReceived As DataGridViewTextBoxColumn
    Friend WithEvents EditButton As DataGridViewButtonColumn
    Friend WithEvents DeleteButton As DataGridViewButtonColumn
    Friend WithEvents AddTransactionButton As Button
End Class
