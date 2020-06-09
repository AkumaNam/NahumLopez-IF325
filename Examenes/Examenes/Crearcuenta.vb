Imports System.ComponentModel
Public Class Crearcuenta
    Public admin As String
    Public contra As String
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Dim opc As DialogResult
        opc = MessageBox.Show("Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If opc = DialogResult.Yes Then
            Me.Close()
            login.Close()
        End If
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        login.Show()
        Me.Hide()
    End Sub

    Private Sub BtnCrear_Click(sender As Object, e As EventArgs) Handles BtnCrear.Click
        Try
            If Me.ValidateChildren Then
                admin = txtusuario.Text
                contra = txtcontra.Text
                login.cont += 1

            Else
                MsgBox("Porfavor ingrese los datos correctamente")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    Private Sub txtusuario_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtusuario.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValid.SetError(sender, "")
        Else
            Me.ErrorValid.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtusuario_MouseHover(sender As Object, e As EventArgs) Handles txtusuario.MouseHover
        ToolTip1.SetToolTip(txtusuario, "Ingrese el Usuario")
        ToolTip1.ToolTipTitle = "Usuario"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtcontra_MouseHover(sender As Object, e As EventArgs) Handles txtcontra.MouseHover
        ToolTip1.SetToolTip(txtcontra, "Ingrese la contraseña")
        ToolTip1.ToolTipTitle = "Contraseña"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtcontra_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtcontra.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValid.SetError(sender, "")
        Else
            Me.ErrorValid.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub
End Class