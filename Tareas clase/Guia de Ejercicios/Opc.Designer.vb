<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Opc
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
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnFor = New System.Windows.Forms.Button()
        Me.btnAlmac = New System.Windows.Forms.Button()
        Me.btnNum = New System.Windows.Forms.Button()
        Me.btndeduc = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(12, 37)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(98, 26)
        Me.btnCalc.TabIndex = 0
        Me.btnCalc.Text = "Calculadora"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnFor
        '
        Me.btnFor.Location = New System.Drawing.Point(116, 37)
        Me.btnFor.Name = "btnFor"
        Me.btnFor.Size = New System.Drawing.Size(98, 26)
        Me.btnFor.TabIndex = 1
        Me.btnFor.Text = "Formula x^2"
        Me.btnFor.UseVisualStyleBackColor = True
        '
        'btnAlmac
        '
        Me.btnAlmac.Location = New System.Drawing.Point(12, 91)
        Me.btnAlmac.Name = "btnAlmac"
        Me.btnAlmac.Size = New System.Drawing.Size(98, 26)
        Me.btnAlmac.TabIndex = 2
        Me.btnAlmac.Text = "Almacenes"
        Me.btnAlmac.UseVisualStyleBackColor = True
        '
        'btnNum
        '
        Me.btnNum.Location = New System.Drawing.Point(116, 91)
        Me.btnNum.Name = "btnNum"
        Me.btnNum.Size = New System.Drawing.Size(98, 26)
        Me.btnNum.TabIndex = 3
        Me.btnNum.Text = "Números"
        Me.btnNum.UseVisualStyleBackColor = True
        '
        'btndeduc
        '
        Me.btndeduc.Location = New System.Drawing.Point(65, 140)
        Me.btndeduc.Name = "btndeduc"
        Me.btndeduc.Size = New System.Drawing.Size(98, 26)
        Me.btndeduc.TabIndex = 4
        Me.btndeduc.Text = "Deducciones"
        Me.btndeduc.UseVisualStyleBackColor = True
        '
        'Opc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(226, 187)
        Me.Controls.Add(Me.btndeduc)
        Me.Controls.Add(Me.btnNum)
        Me.Controls.Add(Me.btnAlmac)
        Me.Controls.Add(Me.btnFor)
        Me.Controls.Add(Me.btnCalc)
        Me.Name = "Opc"
        Me.Text = "Menu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnCalc As Button
    Friend WithEvents btnFor As Button
    Friend WithEvents btnAlmac As Button
    Friend WithEvents btnNum As Button
    Friend WithEvents btndeduc As Button
End Class
