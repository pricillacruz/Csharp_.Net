Public Class Form1
    Private Sub btnSoma_Click(sender As Object, e As EventArgs) Handles btnSoma.Click
        'Declarar variaveis
        Dim num1, num2, soma As Double

        'Atribuir valores
        num1 = txtNum1.Text
        num2 = txtNum2.Text

        'Processamento
        soma = (num1 + num2)

        'Saida
        lblExibir.Text = soma
    End Sub

    Private Sub btnMultiplicacao_Click(sender As Object, e As EventArgs) Handles btnMultiplicacao.Click
        'Declarar variaveis
        Dim num1, num2, multiplicar As Double

        'Atribuir valores
        num1 = txtNum1.Text
        num2 = txtNum2.Text

        'Processamento
        multiplicar = (num1 * num2)

        'Saida
        lblExibir.Text = multiplicar
    End Sub

    Private Sub btnDivisao_Click(sender As Object, e As EventArgs) Handles btnDivisao.Click
        'Declarar variaveis
        Dim num1, num2, dividir As Double

        'Atribuir valores
        num1 = txtNum1.Text
        num2 = txtNum2.Text

        'Processamento
        dividir = (num1 / num2)

        'Saida
        lblExibir.Text = dividir
    End Sub

    Private Sub btnSubtrair_Click(sender As Object, e As EventArgs) Handles btnSubtrair.Click
        'Declarar variaveis
        Dim num1, num2, subtrair As Double

        'Atribuir valores
        num1 = txtNum1.Text
        num2 = txtNum2.Text

        'Processamento
        subtrair = (num1 - num2)

        'Saida
        lblExibir.Text = subtrair
    End Sub
End Class
