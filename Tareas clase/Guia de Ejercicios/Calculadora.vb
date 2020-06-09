Public Class Calculadora
    Private Sub btnreniciar_Click(sender As Object, e As EventArgs) Handles btnreniciar.Click
        txtpantalla.Clear()
        habilitar()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LBHistorial.ResetText()
    End Sub
    Dim n1, n2 As Double
    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        txtpantalla.Text = txtpantalla.Text + "1"
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        txtpantalla.Text = txtpantalla.Text + "2"
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        txtpantalla.Text = txtpantalla.Text + "3"
    End Sub

    Private Sub Btn4_Click(sender As Object, e As EventArgs) Handles Btn4.Click
        txtpantalla.Text = txtpantalla.Text + "4"
    End Sub

    Private Sub Btn5_Click(sender As Object, e As EventArgs) Handles Btn5.Click
        txtpantalla.Text = txtpantalla.Text + "5"
    End Sub

    Private Sub Btn6_Click(sender As Object, e As EventArgs) Handles Btn6.Click
        txtpantalla.Text = txtpantalla.Text + "6"
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        txtpantalla.Text = txtpantalla.Text + "7"
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        txtpantalla.Text = txtpantalla.Text + "8"
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        txtpantalla.Text = txtpantalla.Text + "9"
    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        txtpantalla.Text = txtpantalla.Text + "0"
    End Sub

    Private Sub btnsum_Click(sender As Object, e As EventArgs) Handles btnsum.Click
        n1 = Convert.ToDouble(txtpantalla.Text)
        operador = "+"
        txtpantalla.Clear()
        habilitar()
    End Sub

    Private Sub btnmenos_Click(sender As Object, e As EventArgs) Handles btnmenos.Click
        n1 = Convert.ToDouble(txtpantalla.Text)
        operador = "-"
        txtpantalla.Clear()
        habilitar()
    End Sub

    Private Sub btnmulti_Click(sender As Object, e As EventArgs) Handles btnmulti.Click
        n1 = Convert.ToDouble(txtpantalla.Text)
        operador = "*"
        txtpantalla.Clear()
        habilitar()
    End Sub

    Private Sub btndivi_Click(sender As Object, e As EventArgs) Handles btndivi.Click
        n1 = Convert.ToDouble(txtpantalla.Text)
        operador = "/"
        txtpantalla.Clear()
        habilitar()
    End Sub

    Private Sub Btnigual_Click(sender As Object, e As EventArgs) Handles Btnigual.Click
        n2 = Convert.ToDouble(txtpantalla.Text)
        If operador = "+" Then
            txtpantalla.Text = n1 + n2
            LBHistorial.Items.Add(txtpantalla.Text)
        ElseIf operador = "-" Then
            txtpantalla.Text = n1 - n2
            LBHistorial.Items.Add(txtpantalla.Text)
        ElseIf operador = "*" Then
            txtpantalla.Text = n1 * n2
            LBHistorial.Items.Add(txtpantalla.Text)
        ElseIf operador = "/" And n2 = 0 Then
            txtpantalla.Text = "MATH ERROR"
            Forzar()
            btnsum.Enabled = False
            btndivi.Enabled = False
            btnmulti.Enabled = False
            btnmenos.Enabled = False
            btnpunto.Enabled = False
            Btnigual.Enabled = False
        Else
            txtpantalla.Text = n1 / n2
            LBHistorial.Items.Add(txtpantalla.Text)
        End If
        Forzar()

    End Sub

    Private Sub txtpantalla_TextChanged(sender As Object, e As EventArgs) Handles txtpantalla.TextChanged

    End Sub

    Private Sub btnpunto_Click(sender As Object, e As EventArgs) Handles btnpunto.Click
        txtpantalla.Text = txtpantalla.Text + "."
    End Sub

    Public Sub habilitar()
        btn0.Enabled = True
        btn1.Enabled = True
        btn2.Enabled = True
        btn3.Enabled = True
        Btn4.Enabled = True
        Btn5.Enabled = True
        Btn6.Enabled = True
        btn7.Enabled = True
        btn8.Enabled = True
        btn9.Enabled = True
        btnsum.Enabled = True
        btnpunto.Enabled = True
        btnmenos.Enabled = True
        btnmulti.Enabled = True
        btndivi.Enabled = True
        Btnigual.Enabled = True
    End Sub

    Public Sub Forzar()
        btn0.Enabled = False
        btn1.Enabled = False
        btn2.Enabled = False
        btn3.Enabled = False
        Btn4.Enabled = False
        Btn5.Enabled = False
        Btn6.Enabled = False
        btn7.Enabled = False
        btn8.Enabled = False
        btn9.Enabled = False
        btnpunto.Enabled = False
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Opc.Show()
        Me.Hide()
    End Sub

    Private Sub btnreihist_Click(sender As Object, e As EventArgs) Handles btnreihist.Click
        LBHistorial.Items.Clear()
    End Sub

    Dim operador As String
End Class