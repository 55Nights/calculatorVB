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
        Me.num1 = New System.Windows.Forms.TextBox()
        Me.num2 = New System.Windows.Forms.TextBox()
        Me.num3 = New System.Windows.Forms.TextBox()
        Me.addition = New System.Windows.Forms.Label()
        Me.product = New System.Windows.Forms.Label()
        Me.Average = New System.Windows.Forms.Label()
        Me.ans = New System.Windows.Forms.Label()
        Me.del = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.answer = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.boldBtn = New System.Windows.Forms.Button()
        Me.italBtn = New System.Windows.Forms.Button()
        Me.extBtn = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'num1
        '
        Me.num1.Location = New System.Drawing.Point(132, 110)
        Me.num1.Name = "num1"
        Me.num1.Size = New System.Drawing.Size(153, 20)
        Me.num1.TabIndex = 0
        '
        'num2
        '
        Me.num2.Location = New System.Drawing.Point(132, 74)
        Me.num2.Name = "num2"
        Me.num2.Size = New System.Drawing.Size(153, 20)
        Me.num2.TabIndex = 1
        '
        'num3
        '
        Me.num3.Location = New System.Drawing.Point(132, 32)
        Me.num3.Name = "num3"
        Me.num3.Size = New System.Drawing.Size(153, 20)
        Me.num3.TabIndex = 2
        '
        'addition
        '
        Me.addition.AutoSize = True
        Me.addition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.addition.Location = New System.Drawing.Point(6, 30)
        Me.addition.Name = "addition"
        Me.addition.Size = New System.Drawing.Size(15, 15)
        Me.addition.TabIndex = 3
        Me.addition.Text = "+"
        '
        'product
        '
        Me.product.AutoSize = True
        Me.product.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.product.Location = New System.Drawing.Point(68, 30)
        Me.product.Name = "product"
        Me.product.Size = New System.Drawing.Size(14, 15)
        Me.product.TabIndex = 4
        Me.product.Text = "x"
        '
        'Average
        '
        Me.Average.AutoSize = True
        Me.Average.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Average.Location = New System.Drawing.Point(132, 30)
        Me.Average.Name = "Average"
        Me.Average.Size = New System.Drawing.Size(48, 15)
        Me.Average.TabIndex = 5
        Me.Average.Text = "average"
        '
        'ans
        '
        Me.ans.AutoSize = True
        Me.ans.Location = New System.Drawing.Point(6, 70)
        Me.ans.Name = "ans"
        Me.ans.Size = New System.Drawing.Size(41, 13)
        Me.ans.TabIndex = 8
        Me.ans.Text = "answer"
        '
        'del
        '
        Me.del.AutoSize = True
        Me.del.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.del.Location = New System.Drawing.Point(245, 30)
        Me.del.Name = "del"
        Me.del.Size = New System.Drawing.Size(40, 15)
        Me.del.TabIndex = 9
        Me.del.Text = "Delete"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.num3)
        Me.GroupBox1.Controls.Add(Me.num2)
        Me.GroupBox1.Controls.Add(Me.num1)
        Me.GroupBox1.Location = New System.Drawing.Point(51, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(332, 154)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Operands"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(50, 117)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Number 3"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(50, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Number 2"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(50, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Number 1"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.answer)
        Me.GroupBox2.Controls.Add(Me.addition)
        Me.GroupBox2.Controls.Add(Me.del)
        Me.GroupBox2.Controls.Add(Me.product)
        Me.GroupBox2.Controls.Add(Me.Average)
        Me.GroupBox2.Controls.Add(Me.ans)
        Me.GroupBox2.Location = New System.Drawing.Point(51, 172)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(332, 114)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "operations"
        '
        'answer
        '
        Me.answer.Location = New System.Drawing.Point(72, 65)
        Me.answer.Name = "answer"
        Me.answer.ReadOnly = True
        Me.answer.Size = New System.Drawing.Size(213, 20)
        Me.answer.TabIndex = 9
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.boldBtn)
        Me.GroupBox3.Controls.Add(Me.italBtn)
        Me.GroupBox3.Location = New System.Drawing.Point(49, 292)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(334, 74)
        Me.GroupBox3.TabIndex = 13
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "actions"
        '
        'boldBtn
        '
        Me.boldBtn.Location = New System.Drawing.Point(11, 33)
        Me.boldBtn.Name = "boldBtn"
        Me.boldBtn.Size = New System.Drawing.Size(75, 23)
        Me.boldBtn.TabIndex = 10
        Me.boldBtn.Text = "Bold"
        Me.boldBtn.UseVisualStyleBackColor = True
        '
        'italBtn
        '
        Me.italBtn.Location = New System.Drawing.Point(116, 33)
        Me.italBtn.Name = "italBtn"
        Me.italBtn.Size = New System.Drawing.Size(75, 23)
        Me.italBtn.TabIndex = 9
        Me.italBtn.Text = "Italics"
        Me.italBtn.UseVisualStyleBackColor = True
        '
        'extBtn
        '
        Me.extBtn.BackColor = System.Drawing.Color.IndianRed
        Me.extBtn.Location = New System.Drawing.Point(165, 382)
        Me.extBtn.Name = "extBtn"
        Me.extBtn.Size = New System.Drawing.Size(91, 42)
        Me.extBtn.TabIndex = 8
        Me.extBtn.Text = "Exit"
        Me.extBtn.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.extBtn)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents num1 As TextBox
    Friend WithEvents num2 As TextBox
    Friend WithEvents num3 As TextBox
    Friend WithEvents addition As Label
    Friend WithEvents product As Label
    Friend WithEvents Average As Label
    Friend WithEvents ans As Label
    Friend WithEvents del As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents answer As TextBox
    Friend WithEvents boldBtn As Button
    Friend WithEvents italBtn As Button
    Friend WithEvents extBtn As Button
End Class
