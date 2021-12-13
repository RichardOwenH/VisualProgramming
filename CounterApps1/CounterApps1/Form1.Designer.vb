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
        Me.btncounter = New System.Windows.Forms.Button()
        Me.lblcounter = New System.Windows.Forms.Label()
        Me.btnreset = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btncounter
        '
        Me.btncounter.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncounter.Location = New System.Drawing.Point(155, 267)
        Me.btncounter.Name = "btncounter"
        Me.btncounter.Size = New System.Drawing.Size(75, 23)
        Me.btncounter.TabIndex = 0
        Me.btncounter.Text = "Counter"
        Me.btncounter.UseVisualStyleBackColor = True
        '
        'lblcounter
        '
        Me.lblcounter.AutoSize = True
        Me.lblcounter.BackColor = System.Drawing.Color.Transparent
        Me.lblcounter.Font = New System.Drawing.Font("Oswald Stencil", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcounter.ForeColor = System.Drawing.Color.White
        Me.lblcounter.Location = New System.Drawing.Point(273, 138)
        Me.lblcounter.Name = "lblcounter"
        Me.lblcounter.Size = New System.Drawing.Size(74, 91)
        Me.lblcounter.TabIndex = 1
        Me.lblcounter.Text = "0"
        Me.lblcounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnreset
        '
        Me.btnreset.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreset.Location = New System.Drawing.Point(379, 267)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(75, 23)
        Me.btnreset.TabIndex = 2
        Me.btnreset.Text = "Reset"
        Me.btnreset.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Montserrat", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.Location = New System.Drawing.Point(149, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(305, 35)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Counter Application"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(155, 95)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(290, 10)
        Me.Button1.TabIndex = 4
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(83, 27)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(445, 10)
        Me.Button2.TabIndex = 5
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(83, 315)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(445, 10)
        Me.Button3.TabIndex = 6
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(97, 12)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(10, 326)
        Me.Button4.TabIndex = 7
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(502, 12)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(10, 326)
        Me.Button5.TabIndex = 8
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(618, 352)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnreset)
        Me.Controls.Add(Me.lblcounter)
        Me.Controls.Add(Me.btncounter)
        Me.Name = "Form1"
        Me.Text = "Counter Apps"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btncounter As Button
    Friend WithEvents lblcounter As Label
    Friend WithEvents btnreset As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
End Class
