<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Datos
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
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.cbdepafiltro = New System.Windows.Forms.ComboBox()
        Me.LBHistorial = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.cbdepa = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtdesc = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.rbNeg = New System.Windows.Forms.RadioButton()
        Me.rbPos = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.mtxtEdad = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btningresar = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ErrorValid = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.cbEstado = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrorValid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(445, 276)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 0
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'cbdepafiltro
        '
        Me.cbdepafiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbdepafiltro.FormattingEnabled = True
        Me.cbdepafiltro.Items.AddRange(New Object() {"Todos", "Comayagua", "Francisco Morazán"})
        Me.cbdepafiltro.Location = New System.Drawing.Point(432, 12)
        Me.cbdepafiltro.Name = "cbdepafiltro"
        Me.cbdepafiltro.Size = New System.Drawing.Size(112, 21)
        Me.cbdepafiltro.TabIndex = 2
        '
        'LBHistorial
        '
        Me.LBHistorial.FormattingEnabled = True
        Me.LBHistorial.Location = New System.Drawing.Point(304, 13)
        Me.LBHistorial.Name = "LBHistorial"
        Me.LBHistorial.Size = New System.Drawing.Size(120, 290)
        Me.LBHistorial.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(432, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Activos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(432, 131)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Recuperados"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(432, 205)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Muertos"
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(435, 76)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 6
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(435, 147)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 7
        '
        'TextBox3
        '
        Me.TextBox3.Enabled = False
        Me.TextBox3.Location = New System.Drawing.Point(435, 222)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 8
        '
        'cbdepa
        '
        Me.cbdepa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbdepa.FormattingEnabled = True
        Me.cbdepa.Items.AddRange(New Object() {"Comayagua", "Francisco Morazán"})
        Me.cbdepa.Location = New System.Drawing.Point(6, 122)
        Me.cbdepa.Name = "cbdepa"
        Me.cbdepa.Size = New System.Drawing.Size(112, 21)
        Me.cbdepa.TabIndex = 9
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbEstado)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtdesc)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.rbNeg)
        Me.GroupBox1.Controls.Add(Me.rbPos)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.mtxtEdad)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cbdepa)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(274, 284)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingreso de datos"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(7, 197)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 13)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Estado"
        '
        'txtdesc
        '
        Me.txtdesc.Location = New System.Drawing.Point(10, 253)
        Me.txtdesc.Name = "txtdesc"
        Me.txtdesc.Size = New System.Drawing.Size(241, 20)
        Me.txtdesc.TabIndex = 19
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 238)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Descripción"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 159)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Resultado"
        '
        'rbNeg
        '
        Me.rbNeg.AutoSize = True
        Me.rbNeg.Location = New System.Drawing.Point(78, 175)
        Me.rbNeg.Name = "rbNeg"
        Me.rbNeg.Size = New System.Drawing.Size(68, 17)
        Me.rbNeg.TabIndex = 16
        Me.rbNeg.TabStop = True
        Me.rbNeg.Text = "Negativo"
        Me.rbNeg.UseVisualStyleBackColor = True
        '
        'rbPos
        '
        Me.rbPos.AutoSize = True
        Me.rbPos.Location = New System.Drawing.Point(10, 175)
        Me.rbPos.Name = "rbPos"
        Me.rbPos.Size = New System.Drawing.Size(62, 17)
        Me.rbPos.TabIndex = 15
        Me.rbPos.TabStop = True
        Me.rbPos.Text = "Positivo"
        Me.rbPos.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 106)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Departamento"
        '
        'mtxtEdad
        '
        Me.mtxtEdad.Location = New System.Drawing.Point(6, 80)
        Me.mtxtEdad.Mask = "000"
        Me.mtxtEdad.Name = "mtxtEdad"
        Me.mtxtEdad.Size = New System.Drawing.Size(100, 20)
        Me.mtxtEdad.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Edad"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(6, 36)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(100, 20)
        Me.txtNombre.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Nombre"
        '
        'btningresar
        '
        Me.btningresar.Location = New System.Drawing.Point(110, 315)
        Me.btningresar.Name = "btningresar"
        Me.btningresar.Size = New System.Drawing.Size(75, 23)
        Me.btningresar.TabIndex = 11
        Me.btningresar.Text = "Ingresar"
        Me.btningresar.UseVisualStyleBackColor = True
        '
        'ErrorValid
        '
        Me.ErrorValid.ContainerControl = Me
        '
        'cbEstado
        '
        Me.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEstado.FormattingEnabled = True
        Me.cbEstado.Items.AddRange(New Object() {"Activo", "Recuperado", "Muerto"})
        Me.cbEstado.Location = New System.Drawing.Point(10, 214)
        Me.cbEstado.Name = "cbEstado"
        Me.cbEstado.Size = New System.Drawing.Size(121, 21)
        Me.cbEstado.TabIndex = 21
        '
        'Datos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(554, 350)
        Me.ControlBox = False
        Me.Controls.Add(Me.btningresar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbdepafiltro)
        Me.Controls.Add(Me.LBHistorial)
        Me.Controls.Add(Me.btnSalir)
        Me.Name = "Datos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Datos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrorValid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSalir As Button
    Friend WithEvents cbdepafiltro As ComboBox
    Friend WithEvents LBHistorial As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents cbdepa As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtdesc As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents rbNeg As RadioButton
    Friend WithEvents rbPos As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents mtxtEdad As MaskedTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btningresar As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ErrorValid As ErrorProvider
    Friend WithEvents cbEstado As ComboBox
End Class
