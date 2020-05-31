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
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtISV = New System.Windows.Forms.TextBox()
        Me.txtDes2 = New System.Windows.Forms.TextBox()
        Me.txtSub = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbISV = New System.Windows.Forms.ComboBox()
        Me.cbDes = New System.Windows.Forms.ComboBox()
        Me.chbxISV = New System.Windows.Forms.CheckBox()
        Me.chbxDes = New System.Windows.Forms.CheckBox()
        Me.txtCant = New System.Windows.Forms.TextBox()
        Me.txtpunit = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(221, 384)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 19
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(124, 212)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevo.TabIndex = 18
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(18, 212)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 17
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtTotal)
        Me.GroupBox2.Controls.Add(Me.txtISV)
        Me.GroupBox2.Controls.Add(Me.txtDes2)
        Me.GroupBox2.Controls.Add(Me.txtSub)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 241)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(206, 166)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detalle Factura"
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(87, 127)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtTotal.TabIndex = 13
        '
        'txtISV
        '
        Me.txtISV.Location = New System.Drawing.Point(87, 96)
        Me.txtISV.Name = "txtISV"
        Me.txtISV.ReadOnly = True
        Me.txtISV.Size = New System.Drawing.Size(100, 20)
        Me.txtISV.TabIndex = 12
        '
        'txtDes2
        '
        Me.txtDes2.Location = New System.Drawing.Point(87, 62)
        Me.txtDes2.Name = "txtDes2"
        Me.txtDes2.ReadOnly = True
        Me.txtDes2.Size = New System.Drawing.Size(100, 20)
        Me.txtDes2.TabIndex = 11
        '
        'txtSub
        '
        Me.txtSub.Location = New System.Drawing.Point(87, 28)
        Me.txtSub.Name = "txtSub"
        Me.txtSub.ReadOnly = True
        Me.txtSub.Size = New System.Drawing.Size(100, 20)
        Me.txtSub.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(28, 129)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 15)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Total"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(19, 101)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 15)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "ISV 15%"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(19, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 15)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Descuento"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 15)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Subtotal"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbISV)
        Me.GroupBox1.Controls.Add(Me.cbDes)
        Me.GroupBox1.Controls.Add(Me.chbxISV)
        Me.GroupBox1.Controls.Add(Me.chbxDes)
        Me.GroupBox1.Controls.Add(Me.txtCant)
        Me.GroupBox1.Controls.Add(Me.txtpunit)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(206, 194)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Requeridos"
        '
        'cbISV
        '
        Me.cbISV.FormattingEnabled = True
        Me.cbISV.Items.AddRange(New Object() {" ", "17%", "15%"})
        Me.cbISV.Location = New System.Drawing.Point(22, 164)
        Me.cbISV.Name = "cbISV"
        Me.cbISV.Size = New System.Drawing.Size(121, 21)
        Me.cbISV.TabIndex = 7
        '
        'cbDes
        '
        Me.cbDes.FormattingEnabled = True
        Me.cbDes.Items.AddRange(New Object() {" ", "Tercera Edad", "Estudiante", "Universitario", "Niños menores de 4", "Veteranos", "Promoción"})
        Me.cbDes.Location = New System.Drawing.Point(22, 114)
        Me.cbDes.Name = "cbDes"
        Me.cbDes.Size = New System.Drawing.Size(121, 21)
        Me.cbDes.TabIndex = 5
        '
        'chbxISV
        '
        Me.chbxISV.AutoSize = True
        Me.chbxISV.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbxISV.Location = New System.Drawing.Point(22, 141)
        Me.chbxISV.Name = "chbxISV"
        Me.chbxISV.Size = New System.Drawing.Size(83, 19)
        Me.chbxISV.TabIndex = 6
        Me.chbxISV.Text = "Aplicar ISV"
        Me.chbxISV.UseVisualStyleBackColor = True
        '
        'chbxDes
        '
        Me.chbxDes.AutoSize = True
        Me.chbxDes.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbxDes.Location = New System.Drawing.Point(22, 91)
        Me.chbxDes.Name = "chbxDes"
        Me.chbxDes.Size = New System.Drawing.Size(116, 19)
        Me.chbxDes.TabIndex = 4
        Me.chbxDes.Text = "Aplicar Descuento"
        Me.chbxDes.UseVisualStyleBackColor = True
        '
        'txtCant
        '
        Me.txtCant.Location = New System.Drawing.Point(87, 55)
        Me.txtCant.Name = "txtCant"
        Me.txtCant.Size = New System.Drawing.Size(100, 20)
        Me.txtCant.TabIndex = 3
        '
        'txtpunit
        '
        Me.txtpunit.Location = New System.Drawing.Point(87, 26)
        Me.txtpunit.Name = "txtpunit"
        Me.txtpunit.Size = New System.Drawing.Size(100, 20)
        Me.txtpunit.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Cantidad"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "P. Unitario"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(309, 423)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSalir As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnCalcular As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents txtISV As TextBox
    Friend WithEvents txtDes2 As TextBox
    Friend WithEvents txtSub As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbISV As ComboBox
    Friend WithEvents cbDes As ComboBox
    Friend WithEvents chbxISV As CheckBox
    Friend WithEvents chbxDes As CheckBox
    Friend WithEvents txtCant As TextBox
    Friend WithEvents txtpunit As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
