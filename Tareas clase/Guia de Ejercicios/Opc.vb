Public Class Opc
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Calculadora.Show()
        Me.Hide()
    End Sub

    Private Sub btnFor_Click(sender As Object, e As EventArgs) Handles btnFor.Click
        Formula.Show()
        Me.Hide()
    End Sub

    Private Sub btnAlmac_Click(sender As Object, e As EventArgs) Handles btnAlmac.Click
        Almacenes.Show()
        Me.Hide()
    End Sub

    Private Sub btnNum_Click(sender As Object, e As EventArgs) Handles btnNum.Click
        Numero.Show()
        Me.Hide()
    End Sub

    Private Sub btndeduc_Click(sender As Object, e As EventArgs) Handles btndeduc.Click
        Deducciones.Show()
        Me.Hide()
    End Sub
End Class
