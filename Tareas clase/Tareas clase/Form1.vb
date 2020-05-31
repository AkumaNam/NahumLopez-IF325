Public Class Form1

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim valor1 As Int16
        Dim valor2 As Int16
        Dim resp As Double

        valor1 = txtv1.Text
        valor2 = txtv2.Text

        resp = Valor1 + Valor2
        txtsuma.Text = resp

        resp = Valor1 * Valor2
        txtmulti.Text = resp
        If Valor2 = 0 Then
            txtdiv.Text = "MATH ERROR"
        Else
            resp = Valor1 / Valor2
            txtdiv.Text = resp
        End If


        resp = Valor1 - Valor2
        txtresta.Text = resp
    End Sub
End Class
