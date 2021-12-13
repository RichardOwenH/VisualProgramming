<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Stock
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
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCal = New System.Windows.Forms.Button()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblOutput
        '
        Me.lblOutput.AutoSize = True
        Me.lblOutput.Font = New System.Drawing.Font("Oswald", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutput.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblOutput.Location = New System.Drawing.Point(67, 54)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(102, 27)
        Me.lblOutput.TabIndex = 0
        Me.lblOutput.Text = "Stock Status"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Oswald", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(61, 125)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Amount in Stock"
        '
        'btnCal
        '
        Me.btnCal.Font = New System.Drawing.Font("Oswald", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCal.Location = New System.Drawing.Point(144, 197)
        Me.btnCal.Name = "btnCal"
        Me.btnCal.Size = New System.Drawing.Size(109, 44)
        Me.btnCal.TabIndex = 2
        Me.btnCal.Text = "Calculate"
        Me.btnCal.UseVisualStyleBackColor = True
        '
        'txtInput
        '
        Me.txtInput.Font = New System.Drawing.Font("Oswald", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInput.Location = New System.Drawing.Point(200, 123)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(134, 31)
        Me.txtInput.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(90, 278)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(344, 10)
        Me.Button1.TabIndex = 4
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(-52, 20)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(347, 10)
        Me.Button2.TabIndex = 5
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(55, 155)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(111, 8)
        Me.Button3.TabIndex = 6
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(68, 112)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(111, 8)
        Me.Button4.TabIndex = 7
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(251, 60)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(165, 23)
        Me.Button5.TabIndex = 8
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(-84, 210)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(165, 23)
        Me.Button6.TabIndex = 9
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(403, 308)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.btnCal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblOutput)
        Me.Name = "Form1"
        Me.Text = "In Stock"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblOutput As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCal As Button
    Friend WithEvents txtInput As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
End Class
