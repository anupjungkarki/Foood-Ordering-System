<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.pin_number = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.log = New System.Windows.Forms.Button()
        Me.can = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'pin_number
        '
        Me.pin_number.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pin_number.Location = New System.Drawing.Point(562, 364)
        Me.pin_number.Name = "pin_number"
        Me.pin_number.Size = New System.Drawing.Size(289, 31)
        Me.pin_number.TabIndex = 12
        Me.pin_number.UseSystemPasswordChar = True
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Mohave", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.label2.Location = New System.Drawing.Point(655, 331)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(91, 26)
        Me.label2.TabIndex = 14
        Me.label2.Text = "ENTER PIN"
        '
        'log
        '
        Me.log.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.log.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.log.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.log.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.log.Location = New System.Drawing.Point(562, 401)
        Me.log.Name = "log"
        Me.log.Size = New System.Drawing.Size(125, 34)
        Me.log.TabIndex = 15
        Me.log.Text = "Login"
        Me.log.UseVisualStyleBackColor = False
        Me.log.UseWaitCursor = True
        '
        'can
        '
        Me.can.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.can.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.can.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.can.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.can.Location = New System.Drawing.Point(735, 402)
        Me.can.Name = "can"
        Me.can.Size = New System.Drawing.Size(116, 34)
        Me.can.TabIndex = 16
        Me.can.Text = "Cancel"
        Me.can.UseVisualStyleBackColor = False
        Me.can.UseWaitCursor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Mohave Bold", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(554, 282)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(317, 44)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "KITCHEN DEPARTMENT"
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1354, 733)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.can)
        Me.Controls.Add(Me.log)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.pin_number)
        Me.Name = "Form4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pin_number As System.Windows.Forms.TextBox
    Friend WithEvents label2 As System.Windows.Forms.Label
    Friend WithEvents log As System.Windows.Forms.Button
    Friend WithEvents can As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
