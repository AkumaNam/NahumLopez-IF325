Imports System.ComponentModel
Public Class Form1
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dim opc As DialogResult
        opc = MessageBox.Show("Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If opc = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub BtnAñadir_Click(sender As Object, e As EventArgs) Handles BtnAñadir.Click
        Dim cadena As String
        cadena = txtID.Text
        Try
            If Me.ValidateChildren And txtNom.Text <> String.Empty And IsNumeric(txtNom.Text) = False And txtID.Text <> String.Empty And cadena.Length = 3 Then
                MessageBox.Show("Pokemón Ingresado", "Formulario Pokemón", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Revise los datos ingresados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        MessageBox.Show("El Pokemón agregado es el número " + txtID.Text + ", su nombre es " + txtNom.Text + " y sus tipos son " + cbTipo1.Text + " " + cbTipo2.Text, "Ingresado Correctamente")
    End Sub

    Private Sub txtNom_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtNom.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.Errorvalid.SetError(sender, "")
        Else
            Me.Errorvalid.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbTipo2.SelectedIndex = 0
        cbTipo1.SelectedIndex = 0
    End Sub

    Private Sub txtID_MouseHover(sender As Object, e As EventArgs) Handles txtID.MouseHover
        ToolTip1.SetToolTip(txtID, "Ingrese el ID")
        ToolTip1.ToolTipTitle = "ID"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtNom_MouseHover(sender As Object, e As EventArgs) Handles txtNom.MouseHover
        ToolTip1.SetToolTip(txtNom, "Ingrese el nombre")
        ToolTip1.ToolTipTitle = "Nombre"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub cbTipo1_MouseHover(sender As Object, e As EventArgs) Handles cbTipo1.MouseHover
        ToolTip1.SetToolTip(cbTipo1, "Ingrese el tipo primario")
        ToolTip1.ToolTipTitle = "Tipo Primario"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub cbTipo2_MouseHover(sender As Object, e As EventArgs) Handles cbTipo2.MouseHover
        ToolTip1.SetToolTip(cbTipo2, "Ingrese el tipo secundario")
        ToolTip1.ToolTipTitle = "Tipo Secundario"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtID_Validating(sender As Object, e As CancelEventArgs) Handles txtID.Validating
        If DirectCast(sender, MaskedTextBox).Text.Length > 0 Then
            Me.Errorvalid.SetError(sender, "")
        Else
            Me.Errorvalid.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub cbTipo1_Validating(sender As Object, e As CancelEventArgs) Handles cbTipo1.Validating
        If DirectCast(sender, ComboBox).Text.Length > 0 Then
            Me.Errorvalid.SetError(sender, "")
        Else
            Me.Errorvalid.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub
End Class
