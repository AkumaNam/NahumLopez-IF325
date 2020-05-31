Public Class Form1
    Private Sub btncalc_Click(sender As Object, e As EventArgs) Handles btncalc.Click
        Dim valor1 As Double
        Dim valor2 As Double
        Dim resp As Double
        If txtvalor1.Text = "" Or Not IsNumeric(txtvalor1.Text) Then
            MsgBox("Por favor escriba un valor Númerico en valor 1", vbInformation)
        End If
        If txtvalor2.Text = "" Or Not IsNumeric(txtvalor2.Text) Then
            MsgBox("Por favor escriba un valor Númerico en valor 2", vbInformation)
        End If
        If chbxresta.Checked = False And chckbxdiv.Checked = False And ckbxmulti.Checked = False And ckbxpow.Checked = False And ckbxraiz.Checked = False And ckbxsuma.Checked = False Then
            MsgBox("Por favor escoja una opción", vbInformation)
        End If

        valor1 = Val(txtvalor1.Text)
        valor2 = Val(txtvalor2.Text)

        If ckbxsuma.Checked Then
            resp = valor1 + valor2
            txtsuma.Text = resp
        End If

        If chbxresta.Checked Then
            resp = valor1 - valor2
            txtresta.Text = resp
        End If

        If ckbxmulti.Checked Then
            resp = valor1 * valor2
            txtmulti.Text = resp
        End If

        If chckbxdiv.Checked Then
            If valor2 = 0 Then
                txtdiv.Text = "MATH ERROR"
            Else
                resp = valor1 / valor2
                txtdiv.Text = resp
            End If
        End If

        If ckbxraiz.Checked Then
            resp = Math.Sqrt(valor1)
            txtraiz1.Text = resp
            resp = Math.Sqrt(valor2)
            txtraiz2.Text = resp
        End If


        If ckbxpow.Checked Then
            If txtnumpow.Text = "" Or Not IsNumeric(txtnumpow.Text) Then
                MsgBox("Por favor escriba un valor númerico para la potencia", vbInformation)
            End If
            If txtnumpow.Text = "" Then

            Else
                resp = valor1 ^ Val(txtnumpow.Text)
                txtpow1.Text = resp
                resp = valor2 ^ Val(txtnumpow.Text)
                txtpow2.Text = resp
            End If

        End If

        If ckbxsuma.Checked = False Then
            txtsuma.ResetText()
        End If

        If chbxresta.Checked = False Then
            txtresta.ResetText()
        End If

        If ckbxmulti.Checked = False Then
            txtmulti.ResetText()
        End If

        If chckbxdiv.Checked = False Then
            txtdiv.ResetText()
        End If

        If ckbxraiz.Checked = False Then
            txtraiz1.ResetText()
            txtraiz2.ResetText()
        End If


        If ckbxpow.Checked = False Then
            txtpow2.ResetText()
            txtpow1.ResetText()
            txtnumpow.ResetText()
        End If
    End Sub

    Private Sub Limpiar_Click(sender As Object, e As EventArgs) Handles Limpiar.Click
        txtdiv.ResetText()
        txtmulti.ResetText()
        txtnumpow.ResetText()
        txtpow1.ResetText()
        txtpow2.ResetText()
        txtraiz1.ResetText()
        txtraiz2.ResetText()
        txtresta.ResetText()
        txtsuma.ResetText()
        txtvalor1.ResetText()
        txtvalor2.ResetText()
        chbxresta.Checked = False
        chckbxdiv.Checked = False
        ckbxmulti.Checked = False
        ckbxpow.Checked = False
        ckbxraiz.Checked = False
        ckbxsuma.Checked = False
    End Sub
End Class
