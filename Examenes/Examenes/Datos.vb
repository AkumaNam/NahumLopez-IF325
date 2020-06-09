Public Class Datos
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dim opc As DialogResult
        opc = MessageBox.Show("Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If opc = DialogResult.Yes Then
            Me.Close()
            login.Close()
            Crearcuenta.Close()
        End If
    End Sub

    Private Sub Datos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbdepafiltro.SelectedIndex = 0
    End Sub

    Private Sub txtNombre_MouseHover(sender As Object, e As EventArgs) Handles txtNombre.MouseHover
        ToolTip1.SetToolTip(txtNombre, "Ingrese el nombre del paciente")
        ToolTip1.ToolTipTitle = "Nombre"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub mtxtEdad_MouseHover(sender As Object, e As EventArgs) Handles mtxtEdad.MouseHover
        ToolTip1.SetToolTip(mtxtEdad, "Ingrese la edad del paciente")
        ToolTip1.ToolTipTitle = "Edad"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub cbdepa_MouseHover(sender As Object, e As EventArgs) Handles cbdepa.MouseHover
        ToolTip1.SetToolTip(cbdepa, "Escoja un departamento")
        ToolTip1.ToolTipTitle = "Departamentos"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub rbPos_MouseHover(sender As Object, e As EventArgs) Handles rbPos.MouseHover
        ToolTip1.SetToolTip(rbPos, "El paciente salio positivo")
        ToolTip1.ToolTipTitle = "Positivo"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub rbNeg_MouseHover(sender As Object, e As EventArgs) Handles rbNeg.MouseHover
        ToolTip1.SetToolTip(rbNeg, "El paciente salio negativo")
        ToolTip1.ToolTipTitle = "Negativo"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtdesc_TextChanged(sender As Object, e As EventArgs) Handles txtdesc.TextChanged
        ToolTip1.SetToolTip(txtdesc, "Una pequeña descripción del paciente")
        ToolTip1.ToolTipTitle = "Decripción"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtNombre_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtNombre.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValid.SetError(sender, "")
        Else
            Me.ErrorValid.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub mtxtEdad_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles mtxtEdad.Validating
        If DirectCast(sender, MaskedTextBox).Text.Length > 0 Then
            Me.ErrorValid.SetError(sender, "")
        Else
            Me.ErrorValid.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtdesc_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtdesc.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValid.SetError(sender, "")
        Else
            Me.ErrorValid.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub btningresar_Click(sender As Object, e As EventArgs) Handles btningresar.Click
        Try
            If Me.ValidateChildren And IsNumeric(txtNombre) = False And txtNombre.TextLength > 0 And mtxtEdad.TextLength > 0 Then
                LBHistorial.Items.Add(txtNombre.Text + cbEstado.Text)
            Else
                MsgBox("Por favor ingresar los datos requeridos", "Datos")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cbEstado_MouseHover(sender As Object, e As EventArgs) Handles cbEstado.MouseHover
        ToolTip1.SetToolTip(cbEstado, "El paciente esta Activo con el virus o se recupero del virus o se murio por el viruz")
        ToolTip1.ToolTipTitle = "Estado"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub cbdepa_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cbdepa.Validating
        If DirectCast(sender, ComboBox).Text.Length > 0 Then
            Me.ErrorValid.SetError(sender, "")
        Else
            Me.ErrorValid.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub cbEstado_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cbEstado.Validating
        If DirectCast(sender, ComboBox).Text.Length > 0 Then
            Me.ErrorValid.SetError(sender, "")
        Else
            Me.ErrorValid.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub rbPos_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles rbPos.Validating
        If DirectCast(sender, RadioButton).Text.Length > 0 Then
            Me.ErrorValid.SetError(sender, "")
        Else
            Me.ErrorValid.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub rbNeg_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles rbNeg.Validating
        If DirectCast(sender, RadioButton).Text.Length > 0 Then
            Me.ErrorValid.SetError(sender, "")
        Else
            Me.ErrorValid.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub
End Class