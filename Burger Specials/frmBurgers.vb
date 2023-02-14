Public Class frmBurgers
    Private Sub btnSelectMeal_Click(sender As Object, e As EventArgs) Handles btnSelectMeal.Click
        btnExit.Enabled = True
        btnPrime.Enabled = False
        btnVeggie.Enabled = False
        btnSelectMeal.Enabled = False
        lblInstructions.Visible = False
        lblConfirmation.Visible = True
    End Sub

    Private Sub btnPrime_Click(sender As Object, e As EventArgs) Handles btnPrime.Click
        picPrime.Visible = True
        picVeggie.Visible = False
        btnSelectMeal.Enabled = True
    End Sub

    Private Sub btnVeggie_Click(sender As Object, e As EventArgs) Handles btnVeggie.Click
        picVeggie.Visible = True
        picPrime.Visible = False
        btnSelectMeal.Enabled = True
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
