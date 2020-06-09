Imports System.ComponentModel
Public Class Formula
    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Opc.Show()
        Me.Hide()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim a, b, c, raiz, res1, res2 As Int32
        a = Val(mtxta.Text)
        b = Val(mtxtb.Text)
        c = Val(mtxtc.Text)
        raiz = (Math.Pow(b, 2)) - (4 * a * c)
        Try
            If Me.ValidateChildren And raiz < 0 Then
                MsgBox("No se puede sacar una raíz negativa")
                clear()
            Else
                MsgBox("Calculado con exito")
                res1 = (-b + Math.Sqrt(raiz)) / (2 * a)
                res2 = (-b - Math.Sqrt(raiz)) / (2 * a)
                txtres1.Text = res1
                txtres2.Text = res2
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub mtxta_MouseHover(sender As Object, e As EventArgs) Handles mtxta.MouseHover
        ToolTip1.SetToolTip(mtxta, "Ingrese el valor de A")
        ToolTip1.ToolTipTitle = "A"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub mtxtb_MouseHover(sender As Object, e As EventArgs) Handles mtxtb.MouseHover
        ToolTip1.SetToolTip(mtxtb, "Ingrese el valor de B")
        ToolTip1.ToolTipTitle = "B"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub mtxtc_MouseHover(sender As Object, e As EventArgs) Handles mtxtc.MouseHover
        ToolTip1.SetToolTip(mtxtc, "Ingrese el valor de C")
        ToolTip1.ToolTipTitle = "C"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub mtxta_Validating(sender As Object, e As CancelEventArgs) Handles mtxta.Validating
        If DirectCast(sender, MaskedTextBox).Text.Length > 0 Then
            Me.ErrorProvider.SetError(sender, "")
        Else
            Me.ErrorProvider.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub mtxtb_Validating(sender As Object, e As CancelEventArgs) Handles mtxtb.Validating
        If DirectCast(sender, MaskedTextBox).Text.Length > 0 Then
            Me.ErrorProvider.SetError(sender, "")
        Else
            Me.ErrorProvider.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub mtxtc_Validating(sender As Object, e As CancelEventArgs) Handles mtxtc.Validating
        If DirectCast(sender, MaskedTextBox).Text.Length > 0 Then
            Me.ErrorProvider.SetError(sender, "")
        Else
            Me.ErrorProvider.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub
    Public Sub clear()
        mtxta.Clear()
        mtxtb.Clear()
        mtxtc.Clear()
        txtres1.ResetText()
        txtres2.ResetText()
    End Sub
End Class