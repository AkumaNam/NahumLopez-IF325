<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formula
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
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtres2 = New System.Windows.Forms.TextBox()
        Me.txtres1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.mtxtc = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.mtxtb = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.mtxta = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnRegresar
        '
        Me.btnRegresar.Location = New System.Drawing.Point(114, 243)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(75, 23)
        Me.btnRegresar.TabIndex = 37
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtres2)
        Me.GroupBox1.Controls.Add(Me.txtres1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.mtxtc)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.mtxtb)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.mtxta)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(198, 225)
        Me.GroupBox1.TabIndex = 38
        Me.GroupBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(99, 169)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Respuesta 2"
        '
        'txtres2
        '
        Me.txtres2.Enabled = False
        Me.txtres2.Location = New System.Drawing.Point(99, 186)
        Me.txtres2.Name = "txtres2"
        Me.txtres2.Size = New System.Drawing.Size(93, 20)
        Me.txtres2.TabIndex = 8
        '
        'txtres1
        '
        Me.txtres1.Enabled = False
        Me.txtres1.Location = New System.Drawing.Point(7, 186)
        Me.txtres1.Name = "txtres1"
        Me.txtres1.Size = New System.Drawing.Size(85, 20)
        Me.txtres1.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 169)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Respuesta 1"
        '
        'mtxtc
        '
        Me.mtxtc.Location = New System.Drawing.Point(45, 139)
        Me.mtxtc.Mask = "00000"
        Me.mtxtc.Name = "mtxtc"
        Me.mtxtc.Size = New System.Drawing.Size(100, 20)
        Me.mtxtc.TabIndex = 5
        Me.mtxtc.ValidatingType = GetType(Integer)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(75, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Valor C"
        '
        'mtxtb
        '
        Me.mtxtb.Location = New System.Drawing.Point(45, 86)
        Me.mtxtb.Mask = "00000"
        Me.mtxtb.Name = "mtxtb"
        Me.mtxtb.Size = New System.Drawing.Size(100, 20)
        Me.mtxtb.TabIndex = 3
        Me.mtxtb.ValidatingType = GetType(Integer)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(75, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Valor B"
        '
        'mtxta
        '
        Me.mtxta.Location = New System.Drawing.Point(45, 33)
        Me.mtxta.Mask = "00000"
        Me.mtxta.Name = "mtxta"
        Me.mtxta.Size = New System.Drawing.Size(100, 20)
        Me.mtxta.TabIndex = 1
        Me.mtxta.ValidatingType = GetType(Integer)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(75, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Valor A"
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(29, 243)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 23)
        Me.btnCalc.TabIndex = 39
        Me.btnCalc.Text = "Calcular"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'Formula
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(225, 271)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnRegresar)
        Me.Name = "Formula"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formula"
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnRegresar As Button
    Friend WithEvents ErrorProvider As ErrorProvider
    Friend WithEvents btnCalc As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtres2 As TextBox
    Friend WithEvents txtres1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents mtxtc As MaskedTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents mtxtb As MaskedTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents mtxta As MaskedTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ToolTip1 As ToolTip
End Class
