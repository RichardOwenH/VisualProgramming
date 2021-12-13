<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Bank_Loan
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
        Me.txtSalary = New System.Windows.Forms.TextBox()
        Me.btnCal = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtYears = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtSalary
        '
        Me.txtSalary.Font = New System.Drawing.Font("Oswald", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSalary.ForeColor = System.Drawing.Color.SteelBlue
        Me.txtSalary.Location = New System.Drawing.Point(264, 114)
        Me.txtSalary.Name = "txtSalary"
        Me.txtSalary.Size = New System.Drawing.Size(134, 31)
        Me.txtSalary.TabIndex = 11
        '
        'btnCal
        '
        Me.btnCal.Font = New System.Drawing.Font("Oswald", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCal.ForeColor = System.Drawing.Color.DarkCyan
        Me.btnCal.Location = New System.Drawing.Point(289, 278)
        Me.btnCal.Name = "btnCal"
        Me.btnCal.Size = New System.Drawing.Size(109, 44)
        Me.btnCal.TabIndex = 10
        Me.btnCal.Text = "Calculate"
        Me.btnCal.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Oswald", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(97, 114)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 27)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Salary:"
        '
        'lblOutput
        '
        Me.lblOutput.AutoSize = True
        Me.lblOutput.Font = New System.Drawing.Font("Oswald", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutput.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblOutput.Location = New System.Drawing.Point(97, 222)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(131, 27)
        Me.lblOutput.TabIndex = 8
        Me.lblOutput.Text = "Applicant Status"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Oswald", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(97, 163)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 27)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Years On Job:"
        '
        'txtYears
        '
        Me.txtYears.Font = New System.Drawing.Font("Oswald", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtYears.ForeColor = System.Drawing.Color.SteelBlue
        Me.txtYears.Location = New System.Drawing.Point(264, 163)
        Me.txtYears.Name = "txtYears"
        Me.txtYears.Size = New System.Drawing.Size(134, 31)
        Me.txtYears.TabIndex = 13
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(102, 25)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(296, 10)
        Me.Button1.TabIndex = 17
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(102, 68)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(296, 10)
        Me.Button2.TabIndex = 16
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Oswald", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(180, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(149, 27)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Bank Loan Checker"
        '
        'Button13
        '
        Me.Button13.BackColor = System.Drawing.Color.SteelBlue
        Me.Button13.Location = New System.Drawing.Point(26, -26)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(32, 61)
        Me.Button13.TabIndex = 26
        Me.Button13.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.SteelBlue
        Me.Button3.Location = New System.Drawing.Point(490, -15)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(41, 61)
        Me.Button3.TabIndex = 27
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.SteelBlue
        Me.Button4.Location = New System.Drawing.Point(426, 335)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(36, 89)
        Me.Button4.TabIndex = 28
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.SteelBlue
        Me.Button5.Location = New System.Drawing.Point(54, 335)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(41, 61)
        Me.Button5.TabIndex = 29
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.SteelBlue
        Me.Button6.Location = New System.Drawing.Point(-19, 163)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(41, 92)
        Me.Button6.TabIndex = 30
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.SteelBlue
        Me.Button7.Location = New System.Drawing.Point(335, -31)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(41, 92)
        Me.Button7.TabIndex = 31
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.SteelBlue
        Me.Button8.Location = New System.Drawing.Point(155, 84)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(27, 62)
        Me.Button8.TabIndex = 32
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.SteelBlue
        Me.Button9.Location = New System.Drawing.Point(474, 134)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(41, 92)
        Me.Button9.TabIndex = 33
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.SteelBlue
        Me.Button10.Location = New System.Drawing.Point(185, 256)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(41, 92)
        Me.Button10.TabIndex = 34
        Me.Button10.UseVisualStyleBackColor = False
        '
        'Bank_Loan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(527, 381)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button13)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtYears)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSalary)
        Me.Controls.Add(Me.btnCal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.Button10)
        Me.Name = "Bank_Loan"
        Me.Text = "Bank_Loan"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSalary As TextBox
    Friend WithEvents btnCal As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblOutput As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtYears As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Button13 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button
End Class
