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
        Me.txtNum1 = New System.Windows.Forms.TextBox()
        Me.txtNum2 = New System.Windows.Forms.TextBox()
        Me.lblNum1 = New System.Windows.Forms.Label()
        Me.lblNum2 = New System.Windows.Forms.Label()
        Me.btnAddition = New System.Windows.Forms.Button()
        Me.btnDivision = New System.Windows.Forms.Button()
        Me.btnMultiplication = New System.Windows.Forms.Button()
        Me.btnSubtraction = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtAnswer = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtNum1
        '
        Me.txtNum1.Location = New System.Drawing.Point(58, 67)
        Me.txtNum1.Name = "txtNum1"
        Me.txtNum1.Size = New System.Drawing.Size(57, 23)
        Me.txtNum1.TabIndex = 0
        '
        'txtNum2
        '
        Me.txtNum2.Location = New System.Drawing.Point(183, 67)
        Me.txtNum2.Name = "txtNum2"
        Me.txtNum2.Size = New System.Drawing.Size(57, 23)
        Me.txtNum2.TabIndex = 1
        '
        'lblNum1
        '
        Me.lblNum1.AutoSize = True
        Me.lblNum1.Location = New System.Drawing.Point(11, 70)
        Me.lblNum1.Name = "lblNum1"
        Me.lblNum1.Size = New System.Drawing.Size(43, 15)
        Me.lblNum1.TabIndex = 2
        Me.lblNum1.Text = "Num 1"
        '
        'lblNum2
        '
        Me.lblNum2.AutoSize = True
        Me.lblNum2.Location = New System.Drawing.Point(136, 70)
        Me.lblNum2.Name = "lblNum2"
        Me.lblNum2.Size = New System.Drawing.Size(43, 15)
        Me.lblNum2.TabIndex = 3
        Me.lblNum2.Text = "Num 2"
        '
        'btnAddition
        '
        Me.btnAddition.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAddition.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnAddition.Location = New System.Drawing.Point(27, 174)
        Me.btnAddition.Name = "btnAddition"
        Me.btnAddition.Size = New System.Drawing.Size(88, 45)
        Me.btnAddition.TabIndex = 4
        Me.btnAddition.Text = "+"
        Me.btnAddition.UseVisualStyleBackColor = False
        '
        'btnDivision
        '
        Me.btnDivision.BackColor = System.Drawing.Color.Yellow
        Me.btnDivision.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnDivision.Location = New System.Drawing.Point(27, 276)
        Me.btnDivision.Name = "btnDivision"
        Me.btnDivision.Size = New System.Drawing.Size(88, 45)
        Me.btnDivision.TabIndex = 5
        Me.btnDivision.Text = "/"
        Me.btnDivision.UseVisualStyleBackColor = False
        '
        'btnMultiplication
        '
        Me.btnMultiplication.BackColor = System.Drawing.Color.Red
        Me.btnMultiplication.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnMultiplication.Location = New System.Drawing.Point(152, 276)
        Me.btnMultiplication.Name = "btnMultiplication"
        Me.btnMultiplication.Size = New System.Drawing.Size(88, 45)
        Me.btnMultiplication.TabIndex = 7
        Me.btnMultiplication.Text = "*"
        Me.btnMultiplication.UseVisualStyleBackColor = False
        '
        'btnSubtraction
        '
        Me.btnSubtraction.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSubtraction.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnSubtraction.Location = New System.Drawing.Point(152, 174)
        Me.btnSubtraction.Name = "btnSubtraction"
        Me.btnSubtraction.Size = New System.Drawing.Size(88, 45)
        Me.btnSubtraction.TabIndex = 8
        Me.btnSubtraction.Text = "-"
        Me.btnSubtraction.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(7, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(261, 24)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "SIMPLEX    CALCULATOR"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(94, 337)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtAnswer
        '
        Me.txtAnswer.Location = New System.Drawing.Point(104, 108)
        Me.txtAnswer.Multiline = True
        Me.txtAnswer.Name = "txtAnswer"
        Me.txtAnswer.Size = New System.Drawing.Size(85, 42)
        Me.txtAnswer.TabIndex = 11
        Me.txtAnswer.Text = "ANSWER"
        Me.txtAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Fuchsia
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(91, 225)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 45)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "%"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(270, 372)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtAnswer)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSubtraction)
        Me.Controls.Add(Me.btnMultiplication)
        Me.Controls.Add(Me.btnDivision)
        Me.Controls.Add(Me.btnAddition)
        Me.Controls.Add(Me.lblNum2)
        Me.Controls.Add(Me.lblNum1)
        Me.Controls.Add(Me.txtNum2)
        Me.Controls.Add(Me.txtNum1)
        Me.Name = "Form1"
        Me.Text = "SimplexCalculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNum1 As TextBox
    Friend WithEvents txtNum2 As TextBox
    Friend WithEvents lblNum1 As Label
    Friend WithEvents lblNum2 As Label
    Friend WithEvents btnAddition As Button
    Friend WithEvents btnDivision As Button
    Friend WithEvents btnMultiplication As Button
    Friend WithEvents btnSubtraction As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents txtAnswer As TextBox
    Friend WithEvents Button1 As Button
End Class
