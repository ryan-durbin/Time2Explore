<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Time2Explore
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cpsLabel = New System.Windows.Forms.Label()
        Me.cpsTextBox = New System.Windows.Forms.TextBox()
        Me.listBoxBuildings = New System.Windows.Forms.ListBox()
        Me.listBoxResources = New System.Windows.Forms.ListBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.purchasePlusOne = New System.Windows.Forms.Button()
        Me.purchaseMinusOne = New System.Windows.Forms.Button()
        Me.purchasePlusTen = New System.Windows.Forms.Button()
        Me.purchaseMinusTen = New System.Windows.Forms.Button()
        Me.purchasePlusAll = New System.Windows.Forms.Button()
        Me.purchaseMinusAll = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(591, 32)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(121, 28)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Pause"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cpsLabel
        '
        Me.cpsLabel.AutoSize = True
        Me.cpsLabel.Location = New System.Drawing.Point(587, 64)
        Me.cpsLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.cpsLabel.Name = "cpsLabel"
        Me.cpsLabel.Size = New System.Drawing.Size(124, 17)
        Me.cpsLabel.TabIndex = 1
        Me.cpsLabel.Text = "Cycles per second"
        '
        'cpsTextBox
        '
        Me.cpsTextBox.Enabled = False
        Me.cpsTextBox.Location = New System.Drawing.Point(591, 84)
        Me.cpsTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.cpsTextBox.Name = "cpsTextBox"
        Me.cpsTextBox.Size = New System.Drawing.Size(120, 22)
        Me.cpsTextBox.TabIndex = 2
        Me.cpsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'listBoxBuildings
        '
        Me.listBoxBuildings.FormattingEnabled = True
        Me.listBoxBuildings.ItemHeight = 16
        Me.listBoxBuildings.Location = New System.Drawing.Point(16, 32)
        Me.listBoxBuildings.Margin = New System.Windows.Forms.Padding(4)
        Me.listBoxBuildings.MultiColumn = True
        Me.listBoxBuildings.Name = "listBoxBuildings"
        Me.listBoxBuildings.Size = New System.Drawing.Size(309, 484)
        Me.listBoxBuildings.TabIndex = 3
        '
        'listBoxResources
        '
        Me.listBoxResources.FormattingEnabled = True
        Me.listBoxResources.ItemHeight = 16
        Me.listBoxResources.Location = New System.Drawing.Point(335, 32)
        Me.listBoxResources.Margin = New System.Windows.Forms.Padding(4)
        Me.listBoxResources.Name = "listBoxResources"
        Me.listBoxResources.Size = New System.Drawing.Size(247, 484)
        Me.listBoxResources.TabIndex = 4
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(16, 524)
        Me.RichTextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(527, 89)
        Me.RichTextBox1.TabIndex = 5
        Me.RichTextBox1.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 521)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Details"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(624, 185)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Label2"
        '
        'purchasePlusOne
        '
        Me.purchasePlusOne.Location = New System.Drawing.Point(549, 535)
        Me.purchasePlusOne.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.purchasePlusOne.Name = "purchasePlusOne"
        Me.purchasePlusOne.Size = New System.Drawing.Size(40, 30)
        Me.purchasePlusOne.TabIndex = 8
        Me.purchasePlusOne.Text = "+1"
        Me.purchasePlusOne.UseVisualStyleBackColor = True
        '
        'purchaseMinusOne
        '
        Me.purchaseMinusOne.Location = New System.Drawing.Point(549, 571)
        Me.purchaseMinusOne.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.purchaseMinusOne.Name = "purchaseMinusOne"
        Me.purchaseMinusOne.Size = New System.Drawing.Size(40, 30)
        Me.purchaseMinusOne.TabIndex = 9
        Me.purchaseMinusOne.Text = "-1"
        Me.purchaseMinusOne.UseVisualStyleBackColor = True
        '
        'purchasePlusTen
        '
        Me.purchasePlusTen.Location = New System.Drawing.Point(599, 535)
        Me.purchasePlusTen.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.purchasePlusTen.Name = "purchasePlusTen"
        Me.purchasePlusTen.Size = New System.Drawing.Size(40, 30)
        Me.purchasePlusTen.TabIndex = 10
        Me.purchasePlusTen.Text = "+10"
        Me.purchasePlusTen.UseVisualStyleBackColor = True
        '
        'purchaseMinusTen
        '
        Me.purchaseMinusTen.Location = New System.Drawing.Point(599, 571)
        Me.purchaseMinusTen.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.purchaseMinusTen.Name = "purchaseMinusTen"
        Me.purchaseMinusTen.Size = New System.Drawing.Size(40, 30)
        Me.purchaseMinusTen.TabIndex = 11
        Me.purchaseMinusTen.Text = "-10"
        Me.purchaseMinusTen.UseVisualStyleBackColor = True
        '
        'purchasePlusAll
        '
        Me.purchasePlusAll.Location = New System.Drawing.Point(648, 535)
        Me.purchasePlusAll.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.purchasePlusAll.Name = "purchasePlusAll"
        Me.purchasePlusAll.Size = New System.Drawing.Size(61, 30)
        Me.purchasePlusAll.TabIndex = 12
        Me.purchasePlusAll.Text = "+MAX"
        Me.purchasePlusAll.UseVisualStyleBackColor = True
        '
        'purchaseMinusAll
        '
        Me.purchaseMinusAll.Location = New System.Drawing.Point(648, 571)
        Me.purchaseMinusAll.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.purchaseMinusAll.Name = "purchaseMinusAll"
        Me.purchaseMinusAll.Size = New System.Drawing.Size(61, 30)
        Me.purchaseMinusAll.TabIndex = 13
        Me.purchaseMinusAll.Text = "-ALL"
        Me.purchaseMinusAll.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(624, 219)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 17)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Label3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(624, 295)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 17)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Label4"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(624, 312)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 17)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Label5"
        '
        'Time2Explore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(727, 629)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.purchaseMinusAll)
        Me.Controls.Add(Me.purchasePlusAll)
        Me.Controls.Add(Me.purchaseMinusTen)
        Me.Controls.Add(Me.purchasePlusTen)
        Me.Controls.Add(Me.purchaseMinusOne)
        Me.Controls.Add(Me.purchasePlusOne)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.listBoxResources)
        Me.Controls.Add(Me.listBoxBuildings)
        Me.Controls.Add(Me.cpsTextBox)
        Me.Controls.Add(Me.cpsLabel)
        Me.Controls.Add(Me.Button1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Time2Explore"
        Me.Text = "Time2Explore"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cpsLabel As System.Windows.Forms.Label
    Friend WithEvents cpsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents listBoxBuildings As System.Windows.Forms.ListBox
    Friend WithEvents listBoxResources As System.Windows.Forms.ListBox
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents purchasePlusOne As System.Windows.Forms.Button
    Friend WithEvents purchaseMinusOne As System.Windows.Forms.Button
    Friend WithEvents purchasePlusTen As System.Windows.Forms.Button
    Friend WithEvents purchaseMinusTen As System.Windows.Forms.Button
    Friend WithEvents purchasePlusAll As System.Windows.Forms.Button
    Friend WithEvents purchaseMinusAll As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label

End Class
