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
        Me.txtresta = New System.Windows.Forms.TextBox()
        Me.txtdiv = New System.Windows.Forms.TextBox()
        Me.txtmulti = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtsuma = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.txtv2 = New System.Windows.Forms.TextBox()
        Me.txtv1 = New System.Windows.Forms.TextBox()
        Me.Valor2 = New System.Windows.Forms.Label()
        Me.Valor1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtresta
        '
        Me.txtresta.Location = New System.Drawing.Point(574, 222)
        Me.txtresta.Name = "txtresta"
        Me.txtresta.Size = New System.Drawing.Size(100, 20)
        Me.txtresta.TabIndex = 25
        '
        'txtdiv
        '
        Me.txtdiv.Location = New System.Drawing.Point(197, 336)
        Me.txtdiv.Name = "txtdiv"
        Me.txtdiv.Size = New System.Drawing.Size(100, 20)
        Me.txtdiv.TabIndex = 24
        '
        'txtmulti
        '
        Me.txtmulti.Location = New System.Drawing.Point(574, 332)
        Me.txtmulti.Name = "txtmulti"
        Me.txtmulti.Size = New System.Drawing.Size(100, 20)
        Me.txtmulti.TabIndex = 23
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(502, 225)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Resta"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(127, 339)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Division"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(470, 339)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Multiplicacion"
        '
        'txtsuma
        '
        Me.txtsuma.Location = New System.Drawing.Point(197, 218)
        Me.txtsuma.Name = "txtsuma"
        Me.txtsuma.Size = New System.Drawing.Size(100, 20)
        Me.txtsuma.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(127, 225)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Suma"
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(369, 168)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 17
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'txtv2
        '
        Me.txtv2.Location = New System.Drawing.Point(574, 95)
        Me.txtv2.Name = "txtv2"
        Me.txtv2.Size = New System.Drawing.Size(100, 20)
        Me.txtv2.TabIndex = 16
        '
        'txtv1
        '
        Me.txtv1.Location = New System.Drawing.Point(197, 95)
        Me.txtv1.Name = "txtv1"
        Me.txtv1.Size = New System.Drawing.Size(100, 20)
        Me.txtv1.TabIndex = 15
        '
        'Valor2
        '
        Me.Valor2.AutoSize = True
        Me.Valor2.Location = New System.Drawing.Point(504, 98)
        Me.Valor2.Name = "Valor2"
        Me.Valor2.Size = New System.Drawing.Size(37, 13)
        Me.Valor2.TabIndex = 14
        Me.Valor2.Text = "Valor2"
        '
        'Valor1
        '
        Me.Valor1.AutoSize = True
        Me.Valor1.Location = New System.Drawing.Point(127, 98)
        Me.Valor1.Name = "Valor1"
        Me.Valor1.Size = New System.Drawing.Size(37, 13)
        Me.Valor1.TabIndex = 13
        Me.Valor1.Text = "Valor1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtresta)
        Me.Controls.Add(Me.txtdiv)
        Me.Controls.Add(Me.txtmulti)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtsuma)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.txtv2)
        Me.Controls.Add(Me.txtv1)
        Me.Controls.Add(Me.Valor2)
        Me.Controls.Add(Me.Valor1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtresta As TextBox
    Friend WithEvents txtdiv As TextBox
    Friend WithEvents txtmulti As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtsuma As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCalcular As Button
    Friend WithEvents txtv2 As TextBox
    Friend WithEvents txtv1 As TextBox
    Friend WithEvents Valor2 As Label
    Friend WithEvents Valor1 As Label
End Class
