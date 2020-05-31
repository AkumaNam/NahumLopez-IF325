Public Class Form1
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim val1 As Double
        Dim val2 As Double
        Dim resp As Double
        Dim Desisv As Double
        btnNuevo.Enabled = True
        If txtpunit.Text = "" Then
            MsgBox("Por favor ingrese el precio de la unidad", vbInformation)
            btnNuevo.Enabled = False
        ElseIf Not IsNumeric(txtpunit.Text) Then
            MsgBox("Por favor escriba un valor Númerico en el precio de unidad", vbInformation)
            btnNuevo.Enabled = False
        End If
        If txtCant.Text = "" Then
            MsgBox("Por favor ingrese la cantidad de unidades", vbInformation)
            btnNuevo.Enabled = False
        ElseIf Not IsNumeric(txtCant.Text) Then
            MsgBox("Por favor escriba un valor Númerico en cantidad", vbInformation)
            btnNuevo.Enabled = False
        End If
        val1 = Val(txtpunit.Text)
        val2 = Val(txtCant.Text)
        If chbxDes.Checked = True Then
            If cbDes.SelectedItem = "Tercera Edad" Then
                Desisv = (val1 * val2) * 0.5
                resp = val1 * val2
                txtDes2.Text = Desisv
                txtSub.Text = resp
                txtTotal.Text = resp - Desisv
            ElseIf cbDes.SelectedItem = "Estudiante" Then
                Desisv = (val1 * val2) * 0.08
                resp = val1 * val2
                txtDes2.Text = Desisv
                txtSub.Text = resp
                txtTotal.Text = resp - Desisv
            ElseIf cbDes.SelectedItem = "Universitario" Then
                Desisv = (val1 * val2) * 0.1
                resp = val1 * val2
                txtDes2.Text = Desisv
                txtSub.Text = resp
                txtTotal.Text = resp - Desisv
            ElseIf cbDes.SelectedItem = "Niños menores de 4" Then
                Desisv = (val1 * val2) * 0.8
                resp = val1 * val2
                txtDes2.Text = Desisv
                txtSub.Text = resp
                txtTotal.Text = resp - Desisv
            ElseIf cbDes.SelectedItem = "Veteranos" Then
                Desisv = (val1 * val2) * 0.15
                resp = val1 * val2
                txtDes2.Text = Desisv
                txtSub.Text = resp
                txtTotal.Text = resp - Desisv
            ElseIf cbDes.SelectedItem = "Promoción" Then
                Desisv = (val1 * val2) * 0.2
                resp = val1 * val2
                txtDes2.Text = Desisv
                txtSub.Text = resp
                txtTotal.Text = resp - Desisv
            ElseIf txtpunit.Text = "" Or txtCant.Text = "" Or cbDes.SelectedItem = "" Then
                MsgBox("Por favor escoga un Descuento", vbInformation)
            ElseIf chbxDes.CheckState = False And chbxISV.CheckState = False Then
                resp = val1 * val2
                txtSub.Text = resp
                txtTotal.Text = resp
            End If
        End If
        If chbxISV.Checked = True Then
            If cbISV.SelectedItem = "17%" Then
                Desisv = (val1 * val2) * 0.17
                resp = val1 * val2
                txtISV.Text = Desisv
                txtTotal.Text = resp + Desisv
                txtSub.Text = resp
            ElseIf cbISV.SelectedItem = "15%" Then
                Desisv = (val1 * val2) * 0.15
                resp = val1 * val2
                txtISV.Text = Desisv
                txtTotal.Text = resp + Desisv
                txtSub.Text = resp
            ElseIf txtpunit.Text = "" Or txtCant.Text = "" Or cbISV.SelectedItem = "" Then
                MsgBox("Por favor escoga un ISV", vbInformation)
            ElseIf chbxDes.CheckState = False And chbxISV.CheckState = False Then
                resp = val1 * val2
                txtSub.Text = resp
                txtTotal.Text = resp
            End If
        End If
        If chbxDes.CheckState = False And chbxISV.CheckState = False Then
            resp = val1 * val2
            txtSub.Text = resp
            txtTotal.Text = resp
        End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtCant.ResetText()
        txtDes2.ResetText()
        txtISV.ResetText()
        txtpunit.ResetText()
        txtSub.ResetText()
        txtTotal.ResetText()
        chbxDes.Checked = False
        chbxISV.Checked = False
        btnNuevo.Enabled = False
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()

    End Sub

    Private Sub chbxDes_CheckedChanged(sender As Object, e As EventArgs) Handles chbxDes.CheckedChanged
        If chbxDes.Checked = False Then
            cbDes.Enabled = False
            chbxISV.Enabled = True
            cbDes.SelectedItem = " "
            txtDes2.ResetText()

        Else
            cbDes.Enabled = True
            cbISV.Enabled = False
            cbISV.SelectedItem = " "
            chbxISV.Enabled = False
        End If
        If chbxISV.Checked = False Then
            cbISV.Enabled = False
            chbxDes.Enabled = True
            cbISV.SelectedItem = " "
            txtISV.ResetText()

        Else
            cbISV.Enabled = True
            cbDes.Enabled = False
            cbDes.SelectedItem = " "
            chbxDes.Enabled = False
        End If
    End Sub

    Private Sub chbxISV_CheckedChanged(sender As Object, e As EventArgs) Handles chbxISV.CheckedChanged
        If chbxISV.Checked = False Then
            cbISV.Enabled = False
            chbxDes.Enabled = True
            cbISV.SelectedItem = " "
            txtISV.ResetText()
        Else
            cbISV.Enabled = True
            cbDes.Enabled = False
            cbDes.SelectedItem = " "
            chbxDes.Enabled = False
        End If
        If chbxDes.Checked = False Then
            cbDes.Enabled = False
            chbxISV.Enabled = True
            cbDes.SelectedItem = " "
            txtDes2.ResetText()
        Else
            cbDes.Enabled = True
            cbISV.Enabled = False
            cbISV.SelectedItem = " "
            chbxISV.Enabled = False
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbISV.Enabled = False
        cbDes.Enabled = False
        btnNuevo.Enabled = False
    End Sub
End Class
