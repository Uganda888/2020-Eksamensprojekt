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
        Me.LbL_Kaffe = New System.Windows.Forms.Label()
        Me.Lbl_Te = New System.Windows.Forms.Label()
        Me.Lbl_Mælk = New System.Windows.Forms.Label()
        Me.Lbl_Sukker = New System.Windows.Forms.Label()
        Me.But_Bekræft = New System.Windows.Forms.Button()
        Me.But_Annuller = New System.Windows.Forms.Button()
        Me.But_Sukker = New System.Windows.Forms.Button()
        Me.But_Mælk = New System.Windows.Forms.Button()
        Me.But_Te = New System.Windows.Forms.Button()
        Me.But_Kaffe = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LbL_Kaffe
        '
        Me.LbL_Kaffe.BackColor = System.Drawing.SystemColors.Control
        Me.LbL_Kaffe.Font = New System.Drawing.Font("Snap ITC", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbL_Kaffe.Location = New System.Drawing.Point(61, 151)
        Me.LbL_Kaffe.Name = "LbL_Kaffe"
        Me.LbL_Kaffe.Size = New System.Drawing.Size(98, 25)
        Me.LbL_Kaffe.TabIndex = 4
        Me.LbL_Kaffe.Text = "Kaffe"
        Me.LbL_Kaffe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_Te
        '
        Me.Lbl_Te.BackColor = System.Drawing.SystemColors.Control
        Me.Lbl_Te.Font = New System.Drawing.Font("Snap ITC", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Te.Location = New System.Drawing.Point(61, 279)
        Me.Lbl_Te.Name = "Lbl_Te"
        Me.Lbl_Te.Size = New System.Drawing.Size(98, 25)
        Me.Lbl_Te.TabIndex = 5
        Me.Lbl_Te.Text = "Te"
        Me.Lbl_Te.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_Mælk
        '
        Me.Lbl_Mælk.BackColor = System.Drawing.SystemColors.Control
        Me.Lbl_Mælk.Font = New System.Drawing.Font("Snap ITC", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Mælk.Location = New System.Drawing.Point(165, 151)
        Me.Lbl_Mælk.Name = "Lbl_Mælk"
        Me.Lbl_Mælk.Size = New System.Drawing.Size(98, 25)
        Me.Lbl_Mælk.TabIndex = 6
        Me.Lbl_Mælk.Text = "Mælk"
        Me.Lbl_Mælk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_Sukker
        '
        Me.Lbl_Sukker.BackColor = System.Drawing.SystemColors.Control
        Me.Lbl_Sukker.Font = New System.Drawing.Font("Snap ITC", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Sukker.Location = New System.Drawing.Point(165, 279)
        Me.Lbl_Sukker.Name = "Lbl_Sukker"
        Me.Lbl_Sukker.Size = New System.Drawing.Size(98, 25)
        Me.Lbl_Sukker.TabIndex = 7
        Me.Lbl_Sukker.Text = "Sukker"
        Me.Lbl_Sukker.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'But_Bekræft
        '
        Me.But_Bekræft.Location = New System.Drawing.Point(61, 367)
        Me.But_Bekræft.Name = "But_Bekræft"
        Me.But_Bekræft.Size = New System.Drawing.Size(97, 42)
        Me.But_Bekræft.TabIndex = 10
        Me.But_Bekræft.Text = "Bekræft"
        Me.But_Bekræft.UseVisualStyleBackColor = True
        '
        'But_Annuller
        '
        Me.But_Annuller.Location = New System.Drawing.Point(170, 367)
        Me.But_Annuller.Name = "But_Annuller"
        Me.But_Annuller.Size = New System.Drawing.Size(97, 42)
        Me.But_Annuller.TabIndex = 11
        Me.But_Annuller.Text = "Anullér"
        Me.But_Annuller.UseVisualStyleBackColor = True
        '
        'But_Sukker
        '
        Me.But_Sukker.BackgroundImage = Global.Kaffeautomat2020.My.Resources.Resources.Sukker1
        Me.But_Sukker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.But_Sukker.Location = New System.Drawing.Point(165, 179)
        Me.But_Sukker.Name = "But_Sukker"
        Me.But_Sukker.Size = New System.Drawing.Size(98, 97)
        Me.But_Sukker.TabIndex = 3
        Me.But_Sukker.UseVisualStyleBackColor = True
        '
        'But_Mælk
        '
        Me.But_Mælk.BackgroundImage = Global.Kaffeautomat2020.My.Resources.Resources.Mælk1
        Me.But_Mælk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.But_Mælk.Location = New System.Drawing.Point(165, 51)
        Me.But_Mælk.Name = "But_Mælk"
        Me.But_Mælk.Size = New System.Drawing.Size(98, 97)
        Me.But_Mælk.TabIndex = 2
        Me.But_Mælk.UseVisualStyleBackColor = True
        '
        'But_Te
        '
        Me.But_Te.BackgroundImage = Global.Kaffeautomat2020.My.Resources.Resources.Tekop
        Me.But_Te.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.But_Te.Location = New System.Drawing.Point(61, 179)
        Me.But_Te.Name = "But_Te"
        Me.But_Te.Size = New System.Drawing.Size(98, 97)
        Me.But_Te.TabIndex = 1
        Me.But_Te.UseVisualStyleBackColor = True
        '
        'But_Kaffe
        '
        Me.But_Kaffe.BackgroundImage = Global.Kaffeautomat2020.My.Resources.Resources.Kaffekop
        Me.But_Kaffe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.But_Kaffe.Location = New System.Drawing.Point(61, 51)
        Me.But_Kaffe.Name = "But_Kaffe"
        Me.But_Kaffe.Size = New System.Drawing.Size(98, 97)
        Me.But_Kaffe.TabIndex = 0
        Me.But_Kaffe.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(269, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 33)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(269, 205)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 33)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(62, 330)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 13)
        Me.Label3.TabIndex = 14
        '
        'Form_Drik
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(342, 450)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.But_Annuller)
        Me.Controls.Add(Me.But_Bekræft)
        Me.Controls.Add(Me.Lbl_Sukker)
        Me.Controls.Add(Me.Lbl_Mælk)
        Me.Controls.Add(Me.Lbl_Te)
        Me.Controls.Add(Me.LbL_Kaffe)
        Me.Controls.Add(Me.But_Sukker)
        Me.Controls.Add(Me.But_Mælk)
        Me.Controls.Add(Me.But_Te)
        Me.Controls.Add(Me.But_Kaffe)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form_Drik"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents But_Kaffe As Button
    Friend WithEvents But_Te As Button
    Friend WithEvents But_Sukker As Button
    Friend WithEvents But_Mælk As Button
    Friend WithEvents LbL_Kaffe As Label
    Friend WithEvents Lbl_Te As Label
    Friend WithEvents Lbl_Mælk As Label
    Friend WithEvents Lbl_Sukker As Label
    Friend WithEvents But_Bekræft As Button
    Friend WithEvents But_Annuller As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
