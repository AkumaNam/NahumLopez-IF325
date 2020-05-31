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
        Me.Limpiar = New System.Windows.Forms.Button()
        Me.txtpow2 = New System.Windows.Forms.TextBox()
        Me.txtraiz2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtvalor2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtnumpow = New System.Windows.Forms.TextBox()
        Me.txtpow1 = New System.Windows.Forms.TextBox()
        Me.txtraiz1 = New System.Windows.Forms.TextBox()
        Me.txtdiv = New System.Windows.Forms.TextBox()
        Me.txtmulti = New System.Windows.Forms.TextBox()
        Me.txtresta = New System.Windows.Forms.TextBox()
        Me.txtsuma = New System.Windows.Forms.TextBox()
        Me.txtvalor1 = New System.Windows.Forms.TextBox()
        Me.btncalc = New System.Windows.Forms.Button()
        Me.ckbxpow = New System.Windows.Forms.CheckBox()
        Me.ckbxraiz = New System.Windows.Forms.CheckBox()
        Me.chckbxdiv = New System.Windows.Forms.CheckBox()
        Me.ckbxmulti = New System.Windows.Forms.CheckBox()
        Me.chbxresta = New System.Windows.Forms.CheckBox()
        Me.ckbxsuma = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Limpiar
        '
        Me.Limpiar.Location = New System.Drawing.Point(210, 278)
        Me.Limpiar.Name = "Limpiar"
        Me.Limpiar.Size = New System.Drawing.Size(75, 23)
        Me.Limpiar.TabIndex = 43
        Me.Limpiar.Text = "Limpiar"
        Me.Limpiar.UseVisualStyleBackColor = True
        '
        'txtpow2
        '
        Me.txtpow2.Location = New System.Drawing.Point(255, 228)
        Me.txtpow2.Name = "txtpow2"
        Me.txtpow2.ReadOnly = True
        Me.txtpow2.Size = New System.Drawing.Size(100, 20)
        Me.txtpow2.TabIndex = 42
        '
        'txtraiz2
        '
        Me.txtraiz2.Location = New System.Drawing.Point(255, 201)
        Me.txtraiz2.Name = "txtraiz2"
        Me.txtraiz2.ReadOnly = True
        Me.txtraiz2.Size = New System.Drawing.Size(100, 20)
        Me.txtraiz2.TabIndex = 41
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(198, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Valor 2"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(63, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Valor 1"
        '
        'txtvalor2
        '
        Me.txtvalor2.Location = New System.Drawing.Point(198, 46)
        Me.txtvalor2.Name = "txtvalor2"
        Me.txtvalor2.Size = New System.Drawing.Size(100, 20)
        Me.txtvalor2.TabIndex = 38
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 250)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Potencia"
        '
        'txtnumpow
        '
        Me.txtnumpow.Location = New System.Drawing.Point(33, 266)
        Me.txtnumpow.Name = "txtnumpow"
        Me.txtnumpow.Size = New System.Drawing.Size(28, 20)
        Me.txtnumpow.TabIndex = 36
        '
        'txtpow1
        '
        Me.txtpow1.Location = New System.Drawing.Point(138, 227)
        Me.txtpow1.Name = "txtpow1"
        Me.txtpow1.ReadOnly = True
        Me.txtpow1.Size = New System.Drawing.Size(100, 20)
        Me.txtpow1.TabIndex = 35
        '
        'txtraiz1
        '
        Me.txtraiz1.Location = New System.Drawing.Point(138, 201)
        Me.txtraiz1.Name = "txtraiz1"
        Me.txtraiz1.ReadOnly = True
        Me.txtraiz1.Size = New System.Drawing.Size(100, 20)
        Me.txtraiz1.TabIndex = 34
        '
        'txtdiv
        '
        Me.txtdiv.Location = New System.Drawing.Point(185, 175)
        Me.txtdiv.Name = "txtdiv"
        Me.txtdiv.ReadOnly = True
        Me.txtdiv.Size = New System.Drawing.Size(100, 20)
        Me.txtdiv.TabIndex = 33
        '
        'txtmulti
        '
        Me.txtmulti.Location = New System.Drawing.Point(185, 148)
        Me.txtmulti.Name = "txtmulti"
        Me.txtmulti.ReadOnly = True
        Me.txtmulti.Size = New System.Drawing.Size(100, 20)
        Me.txtmulti.TabIndex = 32
        '
        'txtresta
        '
        Me.txtresta.Location = New System.Drawing.Point(185, 121)
        Me.txtresta.Name = "txtresta"
        Me.txtresta.ReadOnly = True
        Me.txtresta.Size = New System.Drawing.Size(100, 20)
        Me.txtresta.TabIndex = 31
        '
        'txtsuma
        '
        Me.txtsuma.Location = New System.Drawing.Point(185, 94)
        Me.txtsuma.Name = "txtsuma"
        Me.txtsuma.ReadOnly = True
        Me.txtsuma.Size = New System.Drawing.Size(100, 20)
        Me.txtsuma.TabIndex = 30
        '
        'txtvalor1
        '
        Me.txtvalor1.Location = New System.Drawing.Point(66, 46)
        Me.txtvalor1.Name = "txtvalor1"
        Me.txtvalor1.Size = New System.Drawing.Size(100, 20)
        Me.txtvalor1.TabIndex = 29
        '
        'btncalc
        '
        Me.btncalc.Location = New System.Drawing.Point(113, 278)
        Me.btncalc.Name = "btncalc"
        Me.btncalc.Size = New System.Drawing.Size(75, 23)
        Me.btncalc.TabIndex = 28
        Me.btncalc.Text = "Calcular"
        Me.btncalc.UseVisualStyleBackColor = True
        '
        'ckbxpow
        '
        Me.ckbxpow.AutoSize = True
        Me.ckbxpow.Location = New System.Drawing.Point(33, 228)
        Me.ckbxpow.Name = "ckbxpow"
        Me.ckbxpow.Size = New System.Drawing.Size(68, 17)
        Me.ckbxpow.TabIndex = 27
        Me.ckbxpow.Text = "Potencia"
        Me.ckbxpow.UseVisualStyleBackColor = True
        '
        'ckbxraiz
        '
        Me.ckbxraiz.AutoSize = True
        Me.ckbxraiz.Location = New System.Drawing.Point(33, 204)
        Me.ckbxraiz.Name = "ckbxraiz"
        Me.ckbxraiz.Size = New System.Drawing.Size(98, 17)
        Me.ckbxraiz.TabIndex = 26
        Me.ckbxraiz.Text = "Raíz Cuadrada"
        Me.ckbxraiz.UseVisualStyleBackColor = True
        '
        'chckbxdiv
        '
        Me.chckbxdiv.AutoSize = True
        Me.chckbxdiv.Location = New System.Drawing.Point(80, 178)
        Me.chckbxdiv.Name = "chckbxdiv"
        Me.chckbxdiv.Size = New System.Drawing.Size(63, 17)
        Me.chckbxdiv.TabIndex = 25
        Me.chckbxdiv.Text = "División"
        Me.chckbxdiv.UseVisualStyleBackColor = True
        '
        'ckbxmulti
        '
        Me.ckbxmulti.AutoSize = True
        Me.ckbxmulti.Location = New System.Drawing.Point(80, 151)
        Me.ckbxmulti.Name = "ckbxmulti"
        Me.ckbxmulti.Size = New System.Drawing.Size(90, 17)
        Me.ckbxmulti.TabIndex = 24
        Me.ckbxmulti.Text = "Multiplicación"
        Me.ckbxmulti.UseVisualStyleBackColor = True
        '
        'chbxresta
        '
        Me.chbxresta.AutoSize = True
        Me.chbxresta.Location = New System.Drawing.Point(80, 124)
        Me.chbxresta.Name = "chbxresta"
        Me.chbxresta.Size = New System.Drawing.Size(54, 17)
        Me.chbxresta.TabIndex = 23
        Me.chbxresta.Text = "Resta"
        Me.chbxresta.UseVisualStyleBackColor = True
        '
        'ckbxsuma
        '
        Me.ckbxsuma.AutoSize = True
        Me.ckbxsuma.Location = New System.Drawing.Point(80, 97)
        Me.ckbxsuma.Name = "ckbxsuma"
        Me.ckbxsuma.Size = New System.Drawing.Size(53, 17)
        Me.ckbxsuma.TabIndex = 22
        Me.ckbxsuma.Text = "Suma"
        Me.ckbxsuma.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(375, 327)
        Me.Controls.Add(Me.Limpiar)
        Me.Controls.Add(Me.txtpow2)
        Me.Controls.Add(Me.txtraiz2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtvalor2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtnumpow)
        Me.Controls.Add(Me.txtpow1)
        Me.Controls.Add(Me.txtraiz1)
        Me.Controls.Add(Me.txtdiv)
        Me.Controls.Add(Me.txtmulti)
        Me.Controls.Add(Me.txtresta)
        Me.Controls.Add(Me.txtsuma)
        Me.Controls.Add(Me.txtvalor1)
        Me.Controls.Add(Me.btncalc)
        Me.Controls.Add(Me.ckbxpow)
        Me.Controls.Add(Me.ckbxraiz)
        Me.Controls.Add(Me.chckbxdiv)
        Me.Controls.Add(Me.ckbxmulti)
        Me.Controls.Add(Me.chbxresta)
        Me.Controls.Add(Me.ckbxsuma)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Limpiar As Button
    Friend WithEvents txtpow2 As TextBox
    Friend WithEvents txtraiz2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtvalor2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtnumpow As TextBox
    Friend WithEvents txtpow1 As TextBox
    Friend WithEvents txtraiz1 As TextBox
    Friend WithEvents txtdiv As TextBox
    Friend WithEvents txtmulti As TextBox
    Friend WithEvents txtresta As TextBox
    Friend WithEvents txtsuma As TextBox
    Friend WithEvents txtvalor1 As TextBox
    Friend WithEvents btncalc As Button
    Friend WithEvents ckbxpow As CheckBox
    Friend WithEvents ckbxraiz As CheckBox
    Friend WithEvents chckbxdiv As CheckBox
    Friend WithEvents ckbxmulti As CheckBox
    Friend WithEvents chbxresta As CheckBox
    Friend WithEvents ckbxsuma As CheckBox
End Class
