Public Class Form1
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnMultiplication.Click
        Dim Num1, Num2 As Integer
        Dim Solution As Integer

        Num1 = txtNum1.Text
        Num2 = txtNum2.Text

        Solution = Num1 * Num2
        txtAnswer.Text = Solution.ToString

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnAddition_Click(sender As Object, e As EventArgs) Handles btnAddition.Click
        Dim Num1, Num2 As Integer
        Dim Solution As Integer


        Num1 = txtNum1.Text
        Num2 = txtNum2.Text

        Solution = Num1 + Num2
        txtAnswer.Text = Solution.ToString

    End Sub

    Private Sub btnSubtraction_Click(sender As Object, e As EventArgs) Handles btnSubtraction.Click
        Dim Num1, Num2 As Integer
        Dim Solution As Integer

        Num1 = txtNum1.Text
        Num2 = txtNum2.Text

        Solution = Num1 - Num2
        txtAnswer.Text = Solution.ToString

    End Sub

    Private Sub btnDivision_Click(sender As Object, e As EventArgs) Handles btnDivision.Click
        Dim Num1, Num2 As Integer
        Dim Solution As Integer

        Num1 = txtNum1.Text
        Num2 = txtNum2.Text

        Solution = Num1 / Num2
        txtAnswer.Text = Solution.ToString


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        MsgBox("Are you sure you want to quit?")
        Me.Close()

    End Sub

    Private Sub txtAnswer_TextChanged(sender As Object, e As EventArgs) Handles txtAnswer.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Num1, Num2 As Integer
        Dim Solution As Integer

        Num1 = txtNum1.Text
        Num2 = txtNum2.Text

        Solution = Num1 Mod Num2
        txtAnswer.Text = Solution.ToString
    End Sub

End Class
