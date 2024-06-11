<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        GroupBox2 = New GroupBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        txtBookTitle = New TextBox()
        txtISBN = New TextBox()
        txtPrice = New TextBox()
        txtQuantity = New TextBox()
        txtSubtotal = New TextBox()
        txtSalesTax = New TextBox()
        txtTotalDue = New TextBox()
        BtnCompute = New Button()
        BtnExit = New Button()
        BtnReset = New Button()
        BtnTotals = New Button()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(txtTotalDue)
        GroupBox2.Controls.Add(txtSalesTax)
        GroupBox2.Controls.Add(txtSubtotal)
        GroupBox2.Controls.Add(txtQuantity)
        GroupBox2.Controls.Add(txtPrice)
        GroupBox2.Controls.Add(txtISBN)
        GroupBox2.Controls.Add(txtBookTitle)
        GroupBox2.Controls.Add(Label7)
        GroupBox2.Controls.Add(Label6)
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Controls.Add(Label2)
        GroupBox2.Controls.Add(Label1)
        GroupBox2.Location = New Point(35, 28)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(695, 341)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "TextBook Sale Information"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(24, 41)
        Label1.Name = "Label1"
        Label1.Size = New Size(76, 20)
        Label1.TabIndex = 0
        Label1.Text = "Book Title"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(24, 83)
        Label2.Name = "Label2"
        Label2.Size = New Size(118, 20)
        Label2.TabIndex = 1
        Label2.Text = "ISBN (Identifier):"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(24, 121)
        Label3.Name = "Label3"
        Label3.Size = New Size(44, 20)
        Label3.TabIndex = 2
        Label3.Text = "Price:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(24, 155)
        Label4.Name = "Label4"
        Label4.Size = New Size(68, 20)
        Label4.TabIndex = 3
        Label4.Text = "Quantity:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(24, 194)
        Label5.Name = "Label5"
        Label5.Size = New Size(68, 20)
        Label5.TabIndex = 4
        Label5.Text = "Subtotal:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(24, 231)
        Label6.Name = "Label6"
        Label6.Size = New Size(71, 20)
        Label6.TabIndex = 5
        Label6.Text = "Sales Tax:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(24, 278)
        Label7.Name = "Label7"
        Label7.Size = New Size(76, 20)
        Label7.TabIndex = 6
        Label7.Text = "Total Due:"
        ' 
        ' txtBookTitle
        ' 
        txtBookTitle.Location = New Point(252, 34)
        txtBookTitle.Name = "txtBookTitle"
        txtBookTitle.Size = New Size(294, 27)
        txtBookTitle.TabIndex = 7
        ' 
        ' txtISBN
        ' 
        txtISBN.Location = New Point(252, 76)
        txtISBN.Name = "txtISBN"
        txtISBN.Size = New Size(125, 27)
        txtISBN.TabIndex = 8
        ' 
        ' txtPrice
        ' 
        txtPrice.Location = New Point(252, 121)
        txtPrice.Name = "txtPrice"
        txtPrice.Size = New Size(125, 27)
        txtPrice.TabIndex = 9
        ' 
        ' txtQuantity
        ' 
        txtQuantity.Location = New Point(252, 155)
        txtQuantity.Name = "txtQuantity"
        txtQuantity.Size = New Size(125, 27)
        txtQuantity.TabIndex = 10
        ' 
        ' txtSubtotal
        ' 
        txtSubtotal.Location = New Point(252, 194)
        txtSubtotal.Name = "txtSubtotal"
        txtSubtotal.Size = New Size(125, 27)
        txtSubtotal.TabIndex = 11
        ' 
        ' txtSalesTax
        ' 
        txtSalesTax.Location = New Point(252, 234)
        txtSalesTax.Name = "txtSalesTax"
        txtSalesTax.Size = New Size(125, 27)
        txtSalesTax.TabIndex = 12
        ' 
        ' txtTotalDue
        ' 
        txtTotalDue.Location = New Point(252, 278)
        txtTotalDue.Name = "txtTotalDue"
        txtTotalDue.Size = New Size(125, 27)
        txtTotalDue.TabIndex = 13
        ' 
        ' BtnCompute
        ' 
        BtnCompute.Location = New Point(79, 403)
        BtnCompute.Name = "BtnCompute"
        BtnCompute.Size = New Size(94, 29)
        BtnCompute.TabIndex = 2
        BtnCompute.Text = "Compute"
        BtnCompute.UseVisualStyleBackColor = True
        ' 
        ' BtnExit
        ' 
        BtnExit.Location = New Point(597, 403)
        BtnExit.Name = "BtnExit"
        BtnExit.Size = New Size(94, 29)
        BtnExit.TabIndex = 3
        BtnExit.Text = "Exit"
        BtnExit.UseVisualStyleBackColor = True
        ' 
        ' BtnReset
        ' 
        BtnReset.Location = New Point(245, 403)
        BtnReset.Name = "BtnReset"
        BtnReset.Size = New Size(94, 29)
        BtnReset.TabIndex = 3
        BtnReset.Text = "Reset"
        BtnReset.UseVisualStyleBackColor = True
        ' 
        ' BtnTotals
        ' 
        BtnTotals.Location = New Point(407, 403)
        BtnTotals.Name = "BtnTotals"
        BtnTotals.Size = New Size(94, 29)
        BtnTotals.TabIndex = 4
        BtnTotals.Text = "Totals"
        BtnTotals.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(224), CByte(192))
        ClientSize = New Size(800, 510)
        Controls.Add(BtnTotals)
        Controls.Add(BtnReset)
        Controls.Add(BtnExit)
        Controls.Add(BtnCompute)
        Controls.Add(GroupBox2)
        Name = "Form1"
        Text = "Form1"
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTotalDue As TextBox
    Friend WithEvents txtSalesTax As TextBox
    Friend WithEvents txtSubtotal As TextBox
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtISBN As TextBox
    Friend WithEvents txtBookTitle As TextBox
    Friend WithEvents BtnCompute As Button
    Friend WithEvents BtnExit As Button
    Friend WithEvents BtnReset As Button
    Friend WithEvents BtnTotals As Button

End Class
