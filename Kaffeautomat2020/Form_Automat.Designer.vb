<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Automat
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
        Me.components = New System.ComponentModel.Container()
        Me.Lbl_Bæger = New System.Windows.Forms.Label()
        Me.Lbl_Opvarm = New System.Windows.Forms.Label()
        Me.Lbl_Te = New System.Windows.Forms.Label()
        Me.Lbl_Kaffe = New System.Windows.Forms.Label()
        Me.Lbl_Klar = New System.Windows.Forms.Label()
        Me.Lbl_Mælk = New System.Windows.Forms.Label()
        Me.Lbl_Vand = New System.Windows.Forms.Label()
        Me.Lbl_Sukker = New System.Windows.Forms.Label()
        Me.Lbl_Færdig = New System.Windows.Forms.Label()
        Me.Lbl_M = New System.Windows.Forms.Label()
        Me.Lbl_S = New System.Windows.Forms.Label()
        Me.Lbl_Vd = New System.Windows.Forms.Label()
        Me.Lbl_Td = New System.Windows.Forms.Label()
        Me.Lbl_Kd = New System.Windows.Forms.Label()
        Me.Lbl_Vo = New System.Windows.Forms.Label()
        Me.Lbl_Bp = New System.Windows.Forms.Label()
        Me.Lbl_Display = New System.Windows.Forms.Label()
        Me.Pbox_Automat = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.Pbox_Automat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Lbl_Bæger
        '
        Me.Lbl_Bæger.Location = New System.Drawing.Point(12, 388)
        Me.Lbl_Bæger.Name = "Lbl_Bæger"
        Me.Lbl_Bæger.Size = New System.Drawing.Size(100, 23)
        Me.Lbl_Bæger.TabIndex = 13
        Me.Lbl_Bæger.Text = "Bæger placeres"
        Me.Lbl_Bæger.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_Opvarm
        '
        Me.Lbl_Opvarm.Location = New System.Drawing.Point(12, 357)
        Me.Lbl_Opvarm.Name = "Lbl_Opvarm"
        Me.Lbl_Opvarm.Size = New System.Drawing.Size(100, 23)
        Me.Lbl_Opvarm.TabIndex = 14
        Me.Lbl_Opvarm.Text = "Vand opvarmes"
        Me.Lbl_Opvarm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_Te
        '
        Me.Lbl_Te.Location = New System.Drawing.Point(12, 295)
        Me.Lbl_Te.Name = "Lbl_Te"
        Me.Lbl_Te.Size = New System.Drawing.Size(100, 23)
        Me.Lbl_Te.TabIndex = 16
        Me.Lbl_Te.Text = "Te doseres"
        Me.Lbl_Te.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_Kaffe
        '
        Me.Lbl_Kaffe.Location = New System.Drawing.Point(12, 326)
        Me.Lbl_Kaffe.Name = "Lbl_Kaffe"
        Me.Lbl_Kaffe.Size = New System.Drawing.Size(100, 23)
        Me.Lbl_Kaffe.TabIndex = 15
        Me.Lbl_Kaffe.Text = "Kaffe doseres"
        Me.Lbl_Kaffe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_Klar
        '
        Me.Lbl_Klar.Location = New System.Drawing.Point(12, 171)
        Me.Lbl_Klar.Name = "Lbl_Klar"
        Me.Lbl_Klar.Size = New System.Drawing.Size(100, 23)
        Me.Lbl_Klar.TabIndex = 20
        Me.Lbl_Klar.Text = "Bestilling klar"
        Me.Lbl_Klar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_Mælk
        '
        Me.Lbl_Mælk.Location = New System.Drawing.Point(12, 202)
        Me.Lbl_Mælk.Name = "Lbl_Mælk"
        Me.Lbl_Mælk.Size = New System.Drawing.Size(100, 23)
        Me.Lbl_Mælk.TabIndex = 19
        Me.Lbl_Mælk.Text = "Mælk"
        Me.Lbl_Mælk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_Vand
        '
        Me.Lbl_Vand.Location = New System.Drawing.Point(12, 264)
        Me.Lbl_Vand.Name = "Lbl_Vand"
        Me.Lbl_Vand.Size = New System.Drawing.Size(100, 23)
        Me.Lbl_Vand.TabIndex = 18
        Me.Lbl_Vand.Text = "Vand doseres"
        Me.Lbl_Vand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_Sukker
        '
        Me.Lbl_Sukker.Location = New System.Drawing.Point(12, 233)
        Me.Lbl_Sukker.Name = "Lbl_Sukker"
        Me.Lbl_Sukker.Size = New System.Drawing.Size(100, 23)
        Me.Lbl_Sukker.TabIndex = 17
        Me.Lbl_Sukker.Text = "Sukker"
        Me.Lbl_Sukker.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_Færdig
        '
        Me.Lbl_Færdig.AutoEllipsis = True
        Me.Lbl_Færdig.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbl_Færdig.Location = New System.Drawing.Point(118, 171)
        Me.Lbl_Færdig.Name = "Lbl_Færdig"
        Me.Lbl_Færdig.Size = New System.Drawing.Size(23, 23)
        Me.Lbl_Færdig.TabIndex = 21
        '
        'Lbl_M
        '
        Me.Lbl_M.AutoEllipsis = True
        Me.Lbl_M.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbl_M.Location = New System.Drawing.Point(118, 202)
        Me.Lbl_M.Name = "Lbl_M"
        Me.Lbl_M.Size = New System.Drawing.Size(23, 23)
        Me.Lbl_M.TabIndex = 22
        '
        'Lbl_S
        '
        Me.Lbl_S.AutoEllipsis = True
        Me.Lbl_S.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbl_S.Location = New System.Drawing.Point(118, 233)
        Me.Lbl_S.Name = "Lbl_S"
        Me.Lbl_S.Size = New System.Drawing.Size(23, 23)
        Me.Lbl_S.TabIndex = 23
        '
        'Lbl_Vd
        '
        Me.Lbl_Vd.AutoEllipsis = True
        Me.Lbl_Vd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbl_Vd.Location = New System.Drawing.Point(118, 264)
        Me.Lbl_Vd.Name = "Lbl_Vd"
        Me.Lbl_Vd.Size = New System.Drawing.Size(23, 23)
        Me.Lbl_Vd.TabIndex = 24
        '
        'Lbl_Td
        '
        Me.Lbl_Td.AutoEllipsis = True
        Me.Lbl_Td.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbl_Td.Location = New System.Drawing.Point(118, 295)
        Me.Lbl_Td.Name = "Lbl_Td"
        Me.Lbl_Td.Size = New System.Drawing.Size(23, 23)
        Me.Lbl_Td.TabIndex = 25
        '
        'Lbl_Kd
        '
        Me.Lbl_Kd.AutoEllipsis = True
        Me.Lbl_Kd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbl_Kd.Location = New System.Drawing.Point(118, 326)
        Me.Lbl_Kd.Name = "Lbl_Kd"
        Me.Lbl_Kd.Size = New System.Drawing.Size(23, 23)
        Me.Lbl_Kd.TabIndex = 26
        '
        'Lbl_Vo
        '
        Me.Lbl_Vo.AutoEllipsis = True
        Me.Lbl_Vo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbl_Vo.Location = New System.Drawing.Point(118, 357)
        Me.Lbl_Vo.Name = "Lbl_Vo"
        Me.Lbl_Vo.Size = New System.Drawing.Size(23, 23)
        Me.Lbl_Vo.TabIndex = 27
        '
        'Lbl_Bp
        '
        Me.Lbl_Bp.AutoEllipsis = True
        Me.Lbl_Bp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbl_Bp.Location = New System.Drawing.Point(118, 388)
        Me.Lbl_Bp.Name = "Lbl_Bp"
        Me.Lbl_Bp.Size = New System.Drawing.Size(23, 23)
        Me.Lbl_Bp.TabIndex = 28
        '
        'Lbl_Display
        '
        Me.Lbl_Display.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Lbl_Display.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lbl_Display.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Display.Location = New System.Drawing.Point(15, 15)
        Me.Lbl_Display.Name = "Lbl_Display"
        Me.Lbl_Display.Size = New System.Drawing.Size(232, 144)
        Me.Lbl_Display.TabIndex = 29
        Me.Lbl_Display.Text = "Følg din bestilling!"
        Me.Lbl_Display.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Pbox_Automat
        '
        Me.Pbox_Automat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pbox_Automat.Image = Global.Kaffeautomat2020.My.Resources.Resources.Høj_kaffemaskine
        Me.Pbox_Automat.Location = New System.Drawing.Point(147, 220)
        Me.Pbox_Automat.Name = "Pbox_Automat"
        Me.Pbox_Automat.Size = New System.Drawing.Size(100, 191)
        Me.Pbox_Automat.TabIndex = 30
        Me.Pbox_Automat.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 333
        '
        'Form_Automat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(259, 450)
        Me.Controls.Add(Me.Pbox_Automat)
        Me.Controls.Add(Me.Lbl_Display)
        Me.Controls.Add(Me.Lbl_Bp)
        Me.Controls.Add(Me.Lbl_Vo)
        Me.Controls.Add(Me.Lbl_Kd)
        Me.Controls.Add(Me.Lbl_Td)
        Me.Controls.Add(Me.Lbl_Vd)
        Me.Controls.Add(Me.Lbl_S)
        Me.Controls.Add(Me.Lbl_M)
        Me.Controls.Add(Me.Lbl_Færdig)
        Me.Controls.Add(Me.Lbl_Klar)
        Me.Controls.Add(Me.Lbl_Mælk)
        Me.Controls.Add(Me.Lbl_Vand)
        Me.Controls.Add(Me.Lbl_Sukker)
        Me.Controls.Add(Me.Lbl_Te)
        Me.Controls.Add(Me.Lbl_Kaffe)
        Me.Controls.Add(Me.Lbl_Opvarm)
        Me.Controls.Add(Me.Lbl_Bæger)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form_Automat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form_Automat"
        CType(Me.Pbox_Automat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Lbl_Bæger As Label
    Friend WithEvents Lbl_Opvarm As Label
    Friend WithEvents Lbl_Te As Label
    Friend WithEvents Lbl_Kaffe As Label
    Friend WithEvents Lbl_Klar As Label
    Friend WithEvents Lbl_Mælk As Label
    Friend WithEvents Lbl_Vand As Label
    Friend WithEvents Lbl_Sukker As Label
    Friend WithEvents Lbl_Færdig As Label
    Friend WithEvents Lbl_M As Label
    Friend WithEvents Lbl_S As Label
    Friend WithEvents Lbl_Vd As Label
    Friend WithEvents Lbl_Td As Label
    Friend WithEvents Lbl_Kd As Label
    Friend WithEvents Lbl_Vo As Label
    Friend WithEvents Lbl_Bp As Label
    Friend WithEvents Lbl_Display As Label
    Friend WithEvents Pbox_Automat As PictureBox
    Friend WithEvents Timer1 As Timer
End Class
