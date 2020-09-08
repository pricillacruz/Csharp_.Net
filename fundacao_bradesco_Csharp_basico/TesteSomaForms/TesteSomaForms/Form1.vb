Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSomar_Click(sender As Object, e As EventArgs) Handles btnSomar.Click

        'Declarar variaveis
        Dim num1, num2, soma As Integer

        'Atribuir valores
        num1 = txtNum1.Text
        num2 = txtNum2.Text

        'Processamento
        soma = num1 + num2

        'Saida
        soma = lblExibir.Text

    End Sub
End Class
