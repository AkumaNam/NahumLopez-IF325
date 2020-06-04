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
        Me.components = New System.ComponentModel.Container()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.BtnAñadir = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbTipo2 = New System.Windows.Forms.ComboBox()
        Me.cbTipo1 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.MaskedTextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Errorvalid = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.Errorvalid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(128, 297)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 8
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'BtnAñadir
        '
        Me.BtnAñadir.Location = New System.Drawing.Point(18, 297)
        Me.BtnAñadir.Name = "BtnAñadir"
        Me.BtnAñadir.Size = New System.Drawing.Size(75, 23)
        Me.BtnAñadir.TabIndex = 7
        Me.BtnAñadir.Text = "Añadir"
        Me.BtnAñadir.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbTipo2)
        Me.GroupBox1.Controls.Add(Me.cbTipo1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtNom)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtID)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(205, 268)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'cbTipo2
        '
        Me.cbTipo2.FormattingEnabled = True
        Me.cbTipo2.Items.AddRange(New Object() {"N/A", "Bicho", "Dragón", "Eléctrico", "Hada", "Lucha ", "Fuego", "Volador", "Fantasma", "Planta", "Tierra", "Hielo", "Normal", "Veneno", "Psíquico", "Roca", "Acero", "Agua"})
        Me.cbTipo2.Location = New System.Drawing.Point(6, 228)
        Me.cbTipo2.Name = "cbTipo2"
        Me.cbTipo2.Size = New System.Drawing.Size(121, 21)
        Me.cbTipo2.TabIndex = 8
        '
        'cbTipo1
        '
        Me.cbTipo1.FormattingEnabled = True
        Me.cbTipo1.Items.AddRange(New Object() {"Bicho", "Dragón", "Eléctrico", "Hada", "Lucha ", "Fuego", "Volador", "Fantasma", "Planta", "Tierra", "Hielo", "Normal", "Veneno", "Psíquico", "Roca", "Acero", "Agua"})
        Me.cbTipo1.Location = New System.Drawing.Point(6, 161)
        Me.cbTipo1.Name = "cbTipo1"
        Me.cbTipo1.Size = New System.Drawing.Size(121, 21)
        Me.cbTipo1.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 212)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Tipo 2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Tipo 1"
        '
        'txtNom
        '
        Me.txtNom.Location = New System.Drawing.Point(6, 97)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(100, 20)
        Me.txtNom.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ID"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(6, 32)
        Me.txtID.Mask = "000"
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(100, 20)
        Me.txtID.TabIndex = 0
        Me.txtID.ValidatingType = GetType(Integer)
        '
        'Errorvalid
        '
        Me.Errorvalid.ContainerControl = Me
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(228, 332)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.BtnAñadir)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pokemón"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Errorvalid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSalir As Button
    Friend WithEvents BtnAñadir As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbTipo2 As ComboBox
    Friend WithEvents cbTipo1 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNom As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtID As MaskedTextBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Errorvalid As ErrorProvider
End Class
