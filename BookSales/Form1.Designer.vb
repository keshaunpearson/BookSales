<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.DomainUpDown1 = New System.Windows.Forms.DomainUpDown()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PriceTextBox = New System.Windows.Forms.TextBox()
        Me.TitleTextBox = New System.Windows.Forms.TextBox()
        Me.QuantityTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DiscountedPriceTextBox = New System.Windows.Forms.TextBox()
        Me.DiscountTextBox = New System.Windows.Forms.TextBox()
        Me.ExtendedPriceTextBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.AverageDiscountTextBox = New System.Windows.Forms.TextBox()
        Me.DiscountAmountSumTextBox = New System.Windows.Forms.TextBox()
        Me.DiscountSumTextBox = New System.Windows.Forms.TextBox()
        Me.QuantitySumTextBox = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CalculateButton = New System.Windows.Forms.Button()
        Me.ClearSaleButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'DomainUpDown1
        '
        Me.DomainUpDown1.Location = New System.Drawing.Point(399, 212)
        Me.DomainUpDown1.Name = "DomainUpDown1"
        Me.DomainUpDown1.Size = New System.Drawing.Size(8, 31)
        Me.DomainUpDown1.TabIndex = 0
        Me.DomainUpDown1.Text = "DomainUpDown1"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PriceTextBox)
        Me.GroupBox1.Controls.Add(Me.TitleTextBox)
        Me.GroupBox1.Controls.Add(Me.QuantityTextBox)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(84, 121)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(634, 206)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'PriceTextBox
        '
        Me.PriceTextBox.Location = New System.Drawing.Point(145, 153)
        Me.PriceTextBox.Name = "PriceTextBox"
        Me.PriceTextBox.Size = New System.Drawing.Size(150, 31)
        Me.PriceTextBox.TabIndex = 5
        '
        'TitleTextBox
        '
        Me.TitleTextBox.Location = New System.Drawing.Point(145, 103)
        Me.TitleTextBox.Name = "TitleTextBox"
        Me.TitleTextBox.Size = New System.Drawing.Size(269, 31)
        Me.TitleTextBox.TabIndex = 4
        '
        'QuantityTextBox
        '
        Me.QuantityTextBox.Location = New System.Drawing.Point(145, 51)
        Me.QuantityTextBox.Name = "QuantityTextBox"
        Me.QuantityTextBox.Size = New System.Drawing.Size(150, 31)
        Me.QuantityTextBox.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(45, 159)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 25)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "&Price"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(45, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 25)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "&Title"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(45, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 25)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "&Quantity"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DiscountedPriceTextBox)
        Me.GroupBox2.Controls.Add(Me.DiscountTextBox)
        Me.GroupBox2.Controls.Add(Me.ExtendedPriceTextBox)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(84, 363)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(634, 182)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'DiscountedPriceTextBox
        '
        Me.DiscountedPriceTextBox.Location = New System.Drawing.Point(345, 136)
        Me.DiscountedPriceTextBox.Name = "DiscountedPriceTextBox"
        Me.DiscountedPriceTextBox.Size = New System.Drawing.Size(171, 31)
        Me.DiscountedPriceTextBox.TabIndex = 5
        '
        'DiscountTextBox
        '
        Me.DiscountTextBox.Location = New System.Drawing.Point(345, 90)
        Me.DiscountTextBox.Name = "DiscountTextBox"
        Me.DiscountTextBox.Size = New System.Drawing.Size(171, 31)
        Me.DiscountTextBox.TabIndex = 4
        '
        'ExtendedPriceTextBox
        '
        Me.ExtendedPriceTextBox.Location = New System.Drawing.Point(345, 30)
        Me.ExtendedPriceTextBox.Name = "ExtendedPriceTextBox"
        Me.ExtendedPriceTextBox.Size = New System.Drawing.Size(171, 31)
        Me.ExtendedPriceTextBox.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(185, 142)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(144, 25)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Discounted Price"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(185, 96)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(122, 25)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "15% Discount"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(185, 36)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(127, 25)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Extended Price"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.AverageDiscountTextBox)
        Me.GroupBox3.Controls.Add(Me.DiscountAmountSumTextBox)
        Me.GroupBox3.Controls.Add(Me.DiscountSumTextBox)
        Me.GroupBox3.Controls.Add(Me.QuantitySumTextBox)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Location = New System.Drawing.Point(84, 575)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(634, 240)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        '
        'AverageDiscountTextBox
        '
        Me.AverageDiscountTextBox.Location = New System.Drawing.Point(287, 191)
        Me.AverageDiscountTextBox.Name = "AverageDiscountTextBox"
        Me.AverageDiscountTextBox.Size = New System.Drawing.Size(229, 31)
        Me.AverageDiscountTextBox.TabIndex = 7
        '
        'DiscountAmountSumTextBox
        '
        Me.DiscountAmountSumTextBox.Location = New System.Drawing.Point(287, 143)
        Me.DiscountAmountSumTextBox.Name = "DiscountAmountSumTextBox"
        Me.DiscountAmountSumTextBox.Size = New System.Drawing.Size(229, 31)
        Me.DiscountAmountSumTextBox.TabIndex = 6
        '
        'DiscountSumTextBox
        '
        Me.DiscountSumTextBox.Location = New System.Drawing.Point(287, 95)
        Me.DiscountSumTextBox.Name = "DiscountSumTextBox"
        Me.DiscountSumTextBox.Size = New System.Drawing.Size(229, 31)
        Me.DiscountSumTextBox.TabIndex = 5
        '
        'QuantitySumTextBox
        '
        Me.QuantitySumTextBox.Location = New System.Drawing.Point(287, 44)
        Me.QuantitySumTextBox.Name = "QuantitySumTextBox"
        Me.QuantitySumTextBox.Size = New System.Drawing.Size(229, 31)
        Me.QuantitySumTextBox.TabIndex = 4
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(45, 197)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(152, 25)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Average Discount"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(45, 149)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(222, 25)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Total Discounted Amounts"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(45, 101)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(181, 25)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Total Discounts Given"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(45, 50)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(195, 25)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Total Number of Books"
        '
        'CalculateButton
        '
        Me.CalculateButton.Location = New System.Drawing.Point(84, 855)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(117, 57)
        Me.CalculateButton.TabIndex = 5
        Me.CalculateButton.Text = "&Calculate"
        Me.CalculateButton.UseVisualStyleBackColor = True
        '
        'ClearSaleButton
        '
        Me.ClearSaleButton.Location = New System.Drawing.Point(259, 855)
        Me.ClearSaleButton.Name = "ClearSaleButton"
        Me.ClearSaleButton.Size = New System.Drawing.Size(120, 57)
        Me.ClearSaleButton.TabIndex = 6
        Me.ClearSaleButton.Text = "Clear &Sale"
        Me.ClearSaleButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(407, 855)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(121, 57)
        Me.ExitButton.TabIndex = 7
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(315, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 25)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Book Sales"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(563, 827)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(172, 25)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "by KeShaun Pearson"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(747, 936)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ClearSaleButton)
        Me.Controls.Add(Me.CalculateButton)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DomainUpDown1)
        Me.Name = "Form1"
        Me.Text = "R 'n R Book Sales "
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DomainUpDown1 As DomainUpDown
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents CalculateButton As Button
    Friend WithEvents ClearSaleButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents HelpProvider1 As HelpProvider
    Friend WithEvents PriceTextBox As TextBox
    Friend WithEvents TitleTextBox As TextBox
    Friend WithEvents QuantityTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DiscountedPriceTextBox As TextBox
    Friend WithEvents DiscountTextBox As TextBox
    Friend WithEvents ExtendedPriceTextBox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents AverageDiscountTextBox As TextBox
    Friend WithEvents DiscountAmountSumTextBox As TextBox
    Friend WithEvents DiscountSumTextBox As TextBox
    Friend WithEvents QuantitySumTextBox As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label12 As Label
End Class
