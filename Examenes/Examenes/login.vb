Public Class login
    Public cont As Int16
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Crearcuenta.Show()
        Me.Hide()
    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Dim opc As DialogResult
        opc = MessageBox.Show("Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If opc = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub Label3_MouseHover(sender As Object, e As EventArgs) Handles Label3.MouseHover
        If cont > 0 Then
            Label3.Enabled = False
        End If
    End Sub

    Private Sub TextBox1_MouseHover(sender As Object, e As EventArgs) Handles TextBox1.MouseHover
        ToolTip1.SetToolTip(TextBox1, "Ingrese el Usuario")
        ToolTip1.ToolTipTitle = "Usuario"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub TextBox2_MouseHover(sender As Object, e As EventArgs) Handles TextBox2.MouseHover
        ToolTip1.SetToolTip(TextBox2, "Ingrese la contraseña")
        ToolTip1.ToolTipTitle = "Contraseña"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub TextBox1_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextBox1.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValid.SetError(sender, "")
        Else
            Me.ErrorValid.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub TextBox2_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextBox2.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValid.SetError(sender, "")
        Else
            Me.ErrorValid.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click
        Try
            If Me.ValidateChildren And TextBox1.Text = Crearcuenta.admin And TextBox2.Text = Crearcuenta.contra Then
                Datos.Show()
                Me.Hide()
            Else
                MsgBox("Datos Erroneos")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub
End Class
