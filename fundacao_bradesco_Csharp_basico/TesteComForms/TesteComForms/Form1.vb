Public Class Form1
    Private Sub btnSoma_Click(sender As Object, e As EventArgs) Handles btnSoma.Click
        'Declarar variaveis
        Dim num1, num2, soma As Integer

        'Atribuir valores
        num1 = txtNum1.Text
        num2 = txtNum2.Text

        'Processamento
        soma = (num1 + num2)

        'Saida
        lblExibir.Text = soma
    End Sub
End Class
