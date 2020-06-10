Public Class Datos
    Dim dep(3, 18), total(3) As Int16
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
        cbdepa.SelectedIndex = 0
        cbEstado.SelectedIndex = 0
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
        ToolTip1.ToolTipTitle = "Descripción"
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
        Dim itemId, index As Int16
        Dim espacio As String
        espacio = " "
        Try
            If Me.ValidateChildren And IsNumeric(txtNombre) = False And txtNombre.TextLength > 0 And mtxtEdad.TextLength > 0 Then
                LBHistorial.Items.Add(txtNombre.Text + espacio + cbEstado.Text)
                itemId = cbEstado.SelectedIndex
                index = cbdepa.SelectedIndex
                totales(itemId)
                acumulador(itemId, index)
            Else
                MsgBox("Por favor ingresar los datos requeridos", "Datos")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        txtNombre.Clear()
        mtxtEdad.Clear()
        txtdesc.Clear()
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

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtRec.TextChanged

    End Sub

    Private Sub cbdepafiltro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbdepafiltro.SelectedIndexChanged
        Select Case cbdepafiltro.SelectedIndex
            Case 0
                txtActi.Text = total(0)
                txtRec.Text = total(1)
                txtMuer.Text = total(2)
            Case 1
                txtActi.Text = dep(0, 0)
                txtRec.Text = dep(0, 1)
                txtMuer.Text = dep(0, 2)
            Case 2
                txtActi.Text = dep(1, 0)
                txtRec.Text = dep(1, 1)
                txtMuer.Text = dep(1, 2)
            Case 3
                txtActi.Text = dep(2, 0)
                txtRec.Text = dep(2, 1)
                txtMuer.Text = dep(2, 2)
            Case 4
                txtActi.Text = dep(3, 0)
                txtRec.Text = dep(3, 1)
                txtMuer.Text = dep(3, 2)
            Case 5
                txtActi.Text = dep(4, 0)
                txtRec.Text = dep(4, 1)
                txtMuer.Text = dep(4, 2)
            Case 6
                txtActi.Text = dep(5, 0)
                txtRec.Text = dep(5, 1)
                txtMuer.Text = dep(5, 2)
            Case 7
                txtActi.Text = dep(6, 0)
                txtRec.Text = dep(6, 1)
                txtMuer.Text = dep(6, 2)
            Case 8
                txtActi.Text = dep(7, 0)
                txtRec.Text = dep(7, 1)
                txtMuer.Text = dep(7, 2)
            Case 9
                txtActi.Text = dep(8, 0)
                txtRec.Text = dep(8, 1)
                txtMuer.Text = dep(8, 2)
            Case 10
                txtActi.Text = dep(9, 0)
                txtRec.Text = dep(9, 1)
                txtMuer.Text = dep(9, 2)
            Case 11
                txtActi.Text = dep(10, 0)
                txtRec.Text = dep(10, 1)
                txtMuer.Text = dep(10, 2)
            Case 12
                txtActi.Text = dep(11, 0)
                txtRec.Text = dep(11, 1)
                txtMuer.Text = dep(11, 2)
            Case 13
                txtActi.Text = dep(12, 0)
                txtRec.Text = dep(12, 1)
                txtMuer.Text = dep(12, 2)
            Case 14
                txtActi.Text = dep(13, 0)
                txtRec.Text = dep(13, 1)
                txtMuer.Text = dep(13, 2)
            Case 15
                txtActi.Text = dep(14, 0)
                txtRec.Text = dep(14, 1)
                txtMuer.Text = dep(14, 2)
            Case 16
                txtActi.Text = dep(15, 0)
                txtRec.Text = dep(15, 1)
                txtMuer.Text = dep(15, 2)
            Case 17
                txtActi.Text = dep(16, 0)
                txtRec.Text = dep(16, 1)
                txtMuer.Text = dep(16, 2)
            Case 18
                txtActi.Text = dep(17, 0)
                txtRec.Text = dep(17, 1)
                txtMuer.Text = dep(17, 2)
        End Select
    End Sub
    Public Sub totales(ByVal itemID)
        Select Case itemID
            Case 0
                txtActi.Text = Val(txtActi.Text) + 1
                total(0) += 1
            Case 1
                txtRec.Text = Val(txtRec.Text) + 1
                total(1) += 1
            Case 2
                txtMuer.Text = Val(txtMuer.Text) + 1
                total(2) += 1
        End Select

    End Sub
    Public Sub acumulador(ByVal itemID, ByVal indexID)
        Select Case indexID
            Case 0
                If itemID = 0 Then
                    dep(0, 0) += 1
                ElseIf itemID = 1 Then
                    dep(0, 1) += 1
                Else
                    dep(0, 2) += 1
                End If
            Case 1
                If itemID = 0 Then
                    dep(1, 0) += 1
                ElseIf itemID = 1 Then
                    dep(1, 1) += 1
                Else
                    dep(1, 2) += 1
                End If
            Case 2
                If itemID = 0 Then
                    dep(2, 0) += 1
                ElseIf itemID = 1 Then
                    dep(2, 1) += 1
                Else
                    dep(2, 2) += 1
                End If
            Case 3
                If itemID = 0 Then
                    dep(3, 0) += 1
                ElseIf itemID = 1 Then
                    dep(3, 1) += 1
                Else
                    dep(3, 2) += 1
                End If
            Case 4
                If itemID = 0 Then
                    dep(4, 0) += 1
                ElseIf itemID = 1 Then
                    dep(4, 1) += 1
                Else
                    dep(4, 2) += 1
                End If
            Case 5
                If itemID = 0 Then
                    dep(5, 0) += 1
                ElseIf itemID = 1 Then
                    dep(5, 1) += 1
                Else
                    dep(5, 2) += 1
                End If
            Case 6
                If itemID = 0 Then
                    dep(6, 0) += 1
                ElseIf itemID = 1 Then
                    dep(6, 1) += 1
                Else
                    dep(6, 2) += 1
                End If
            Case 7
                If itemID = 0 Then
                    dep(7, 0) += 1
                ElseIf itemID = 1 Then
                    dep(7, 1) += 1
                Else
                    dep(7, 2) += 1
                End If
            Case 8
                If itemID = 0 Then
                    dep(8, 0) += 1
                ElseIf itemID = 1 Then
                    dep(8, 1) += 1
                Else
                    dep(8, 2) += 1
                End If
            Case 9
                If itemID = 0 Then
                    dep(9, 0) += 1
                ElseIf itemID = 1 Then
                    dep(9, 1) += 1
                Else
                    dep(9, 2) += 1
                End If
            Case 10
                If itemID = 0 Then
                    dep(10, 0) += 1
                ElseIf itemID = 1 Then
                    dep(10, 1) += 1
                Else
                    dep(10, 2) += 1
                End If
            Case 11
                If itemID = 0 Then
                    dep(11, 0) += 1
                ElseIf itemID = 1 Then
                    dep(11, 1) += 1
                Else
                    dep(11, 2) += 1
                End If
            Case 12
                If itemID = 0 Then
                    dep(12, 0) += 1
                ElseIf itemID = 1 Then
                    dep(12, 1) += 1
                Else
                    dep(12, 2) += 1
                End If
            Case 13
                If itemID = 0 Then
                    dep(13, 0) += 1
                ElseIf itemID = 1 Then
                    dep(13, 1) += 1
                Else
                    dep(13, 2) += 1
                End If
            Case 14
                If itemID = 0 Then
                    dep(14, 0) += 1
                ElseIf itemID = 1 Then
                    dep(14, 1) += 1
                Else
                    dep(15, 2) += 1
                End If
            Case 15
                If itemID = 0 Then
                    dep(15, 0) += 1
                ElseIf itemID = 1 Then
                    dep(15, 1) += 1
                Else
                    dep(15, 2) += 1
                End If
            Case 16
                If itemID = 0 Then
                    dep(16, 0) += 1
                ElseIf itemID = 1 Then
                    dep(16, 1) += 1
                Else
                    dep(16, 2) += 1
                End If
            Case 17
                If itemID = 0 Then
                    dep(17, 0) += 1
                ElseIf itemID = 1 Then
                    dep(17, 1) += 1
                Else
                    dep(17, 2) += 1
                End If
        End Select
    End Sub
End Class