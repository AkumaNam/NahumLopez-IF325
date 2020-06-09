<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calculadora
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
        Me.btnpunto = New System.Windows.Forms.Button()
        Me.btndivi = New System.Windows.Forms.Button()
        Me.btnmulti = New System.Windows.Forms.Button()
        Me.btnmenos = New System.Windows.Forms.Button()
        Me.btnsum = New System.Windows.Forms.Button()
        Me.btnreniciar = New System.Windows.Forms.Button()
        Me.Btnigual = New System.Windows.Forms.Button()
        Me.btn0 = New System.Windows.Forms.Button()
        Me.btn9 = New System.Windows.Forms.Button()
        Me.btn8 = New System.Windows.Forms.Button()
        Me.btn7 = New System.Windows.Forms.Button()
        Me.Btn6 = New System.Windows.Forms.Button()
        Me.Btn5 = New System.Windows.Forms.Button()
        Me.Btn4 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.txtpantalla = New System.Windows.Forms.TextBox()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.LBHistorial = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnreihist = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnpunto
        '
        Me.btnpunto.Location = New System.Drawing.Point(13, 155)
        Me.btnpunto.Name = "btnpunto"
        Me.btnpunto.Size = New System.Drawing.Size(34, 26)
        Me.btnpunto.TabIndex = 35
        Me.btnpunto.Text = "."
        Me.btnpunto.UseVisualStyleBackColor = True
        '
        'btndivi
        '
        Me.btndivi.Location = New System.Drawing.Point(133, 155)
        Me.btndivi.Name = "btndivi"
        Me.btndivi.Size = New System.Drawing.Size(34, 26)
        Me.btndivi.TabIndex = 34
        Me.btndivi.Text = "/"
        Me.btndivi.UseVisualStyleBackColor = True
        '
        'btnmulti
        '
        Me.btnmulti.Location = New System.Drawing.Point(133, 123)
        Me.btnmulti.Name = "btnmulti"
        Me.btnmulti.Size = New System.Drawing.Size(34, 26)
        Me.btnmulti.TabIndex = 33
        Me.btnmulti.Text = "*"
        Me.btnmulti.UseVisualStyleBackColor = True
        '
        'btnmenos
        '
        Me.btnmenos.Location = New System.Drawing.Point(133, 91)
        Me.btnmenos.Name = "btnmenos"
        Me.btnmenos.Size = New System.Drawing.Size(34, 26)
        Me.btnmenos.TabIndex = 32
        Me.btnmenos.Text = "-"
        Me.btnmenos.UseVisualStyleBackColor = True
        '
        'btnsum
        '
        Me.btnsum.Location = New System.Drawing.Point(133, 59)
        Me.btnsum.Name = "btnsum"
        Me.btnsum.Size = New System.Drawing.Size(34, 26)
        Me.btnsum.TabIndex = 31
        Me.btnsum.Text = "+"
        Me.btnsum.UseVisualStyleBackColor = True
        '
        'btnreniciar
        '
        Me.btnreniciar.Location = New System.Drawing.Point(92, 187)
        Me.btnreniciar.Name = "btnreniciar"
        Me.btnreniciar.Size = New System.Drawing.Size(75, 23)
        Me.btnreniciar.TabIndex = 30
        Me.btnreniciar.Text = "Reniciar"
        Me.btnreniciar.UseVisualStyleBackColor = True
        '
        'Btnigual
        '
        Me.Btnigual.Location = New System.Drawing.Point(93, 155)
        Me.Btnigual.Name = "Btnigual"
        Me.Btnigual.Size = New System.Drawing.Size(34, 26)
        Me.Btnigual.TabIndex = 29
        Me.Btnigual.Text = "="
        Me.Btnigual.UseVisualStyleBackColor = True
        '
        'btn0
        '
        Me.btn0.Location = New System.Drawing.Point(53, 155)
        Me.btn0.Name = "btn0"
        Me.btn0.Size = New System.Drawing.Size(34, 26)
        Me.btn0.TabIndex = 28
        Me.btn0.Text = "0"
        Me.btn0.UseVisualStyleBackColor = True
        '
        'btn9
        '
        Me.btn9.Location = New System.Drawing.Point(93, 122)
        Me.btn9.Name = "btn9"
        Me.btn9.Size = New System.Drawing.Size(34, 26)
        Me.btn9.TabIndex = 27
        Me.btn9.Text = "9"
        Me.btn9.UseVisualStyleBackColor = True
        '
        'btn8
        '
        Me.btn8.Location = New System.Drawing.Point(53, 123)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(34, 26)
        Me.btn8.TabIndex = 26
        Me.btn8.Text = "8"
        Me.btn8.UseVisualStyleBackColor = True
        '
        'btn7
        '
        Me.btn7.Location = New System.Drawing.Point(13, 123)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(34, 26)
        Me.btn7.TabIndex = 25
        Me.btn7.Text = "7"
        Me.btn7.UseVisualStyleBackColor = True
        '
        'Btn6
        '
        Me.Btn6.Location = New System.Drawing.Point(93, 91)
        Me.Btn6.Name = "Btn6"
        Me.Btn6.Size = New System.Drawing.Size(34, 26)
        Me.Btn6.TabIndex = 24
        Me.Btn6.Text = "6"
        Me.Btn6.UseVisualStyleBackColor = True
        '
        'Btn5
        '
        Me.Btn5.Location = New System.Drawing.Point(53, 91)
        Me.Btn5.Name = "Btn5"
        Me.Btn5.Size = New System.Drawing.Size(34, 26)
        Me.Btn5.TabIndex = 23
        Me.Btn5.Text = "5"
        Me.Btn5.UseVisualStyleBackColor = True
        '
        'Btn4
        '
        Me.Btn4.Location = New System.Drawing.Point(13, 91)
        Me.Btn4.Name = "Btn4"
        Me.Btn4.Size = New System.Drawing.Size(34, 26)
        Me.Btn4.TabIndex = 22
        Me.Btn4.Text = "4"
        Me.Btn4.UseVisualStyleBackColor = True
        '
        'btn3
        '
        Me.btn3.Location = New System.Drawing.Point(93, 59)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(34, 26)
        Me.btn3.TabIndex = 21
        Me.btn3.Text = "3"
        Me.btn3.UseVisualStyleBackColor = True
        '
        'btn2
        '
        Me.btn2.Location = New System.Drawing.Point(53, 59)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(34, 26)
        Me.btn2.TabIndex = 20
        Me.btn2.Text = "2"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'btn1
        '
        Me.btn1.Location = New System.Drawing.Point(13, 59)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(34, 26)
        Me.btn1.TabIndex = 19
        Me.btn1.Text = "1"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'txtpantalla
        '
        Me.txtpantalla.Enabled = False
        Me.txtpantalla.Location = New System.Drawing.Point(13, 13)
        Me.txtpantalla.Name = "txtpantalla"
        Me.txtpantalla.Size = New System.Drawing.Size(154, 20)
        Me.txtpantalla.TabIndex = 18
        '
        'btnRegresar
        '
        Me.btnRegresar.Location = New System.Drawing.Point(12, 187)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(75, 23)
        Me.btnRegresar.TabIndex = 36
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'LBHistorial
        '
        Me.LBHistorial.FormattingEnabled = True
        Me.LBHistorial.Location = New System.Drawing.Point(186, 39)
        Me.LBHistorial.Name = "LBHistorial"
        Me.LBHistorial.Size = New System.Drawing.Size(133, 147)
        Me.LBHistorial.TabIndex = 37
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(183, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Historial"
        '
        'btnreihist
        '
        Me.btnreihist.Location = New System.Drawing.Point(202, 192)
        Me.btnreihist.Name = "btnreihist"
        Me.btnreihist.Size = New System.Drawing.Size(104, 23)
        Me.btnreihist.TabIndex = 39
        Me.btnreihist.Text = "Reiniciar Historial"
        Me.btnreihist.UseVisualStyleBackColor = True
        '
        'Calculadora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(331, 225)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnreihist)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LBHistorial)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.btnpunto)
        Me.Controls.Add(Me.btndivi)
        Me.Controls.Add(Me.btnmulti)
        Me.Controls.Add(Me.btnmenos)
        Me.Controls.Add(Me.btnsum)
        Me.Controls.Add(Me.btnreniciar)
        Me.Controls.Add(Me.Btnigual)
        Me.Controls.Add(Me.btn0)
        Me.Controls.Add(Me.btn9)
        Me.Controls.Add(Me.btn8)
        Me.Controls.Add(Me.btn7)
        Me.Controls.Add(Me.Btn6)
        Me.Controls.Add(Me.Btn5)
        Me.Controls.Add(Me.Btn4)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.txtpantalla)
        Me.Name = "Calculadora"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calculadora"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnpunto As Button
    Friend WithEvents btndivi As Button
    Friend WithEvents btnmulti As Button
    Friend WithEvents btnmenos As Button
    Friend WithEvents btnsum As Button
    Friend WithEvents btnreniciar As Button
    Friend WithEvents Btnigual As Button
    Friend WithEvents btn0 As Button
    Friend WithEvents btn9 As Button
    Friend WithEvents btn8 As Button
    Friend WithEvents btn7 As Button
    Friend WithEvents Btn6 As Button
    Friend WithEvents Btn5 As Button
    Friend WithEvents Btn4 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn1 As Button
    Friend WithEvents txtpantalla As TextBox
    Friend WithEvents btnRegresar As Button
    Friend WithEvents LBHistorial As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnreihist As Button
End Class
