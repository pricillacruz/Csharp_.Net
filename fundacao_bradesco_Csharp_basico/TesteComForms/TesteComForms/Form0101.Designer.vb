<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnSoma = New System.Windows.Forms.Button()
        Me.txtNum1 = New System.Windows.Forms.TextBox()
        Me.txtNum2 = New System.Windows.Forms.TextBox()
        Me.lblNum1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblExibir = New System.Windows.Forms.Label()
        Me.btnDivisao = New System.Windows.Forms.Button()
        Me.btnMultiplicacao = New System.Windows.Forms.Button()
        Me.btnSubtrair = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnSoma
        '
        Me.btnSoma.Location = New System.Drawing.Point(15, 166)
        Me.btnSoma.Name = "btnSoma"
        Me.btnSoma.Size = New System.Drawing.Size(75, 23)
        Me.btnSoma.TabIndex = 3
        Me.btnSoma.Text = "Somar"
        Me.btnSoma.UseVisualStyleBackColor = True
        '
        'txtNum1
        '
        Me.txtNum1.Location = New System.Drawing.Point(119, 32)
        Me.txtNum1.Name = "txtNum1"
        Me.txtNum1.Size = New System.Drawing.Size(100, 20)
        Me.txtNum1.TabIndex = 1
        '
        'txtNum2
        '
        Me.txtNum2.Location = New System.Drawing.Point(119, 80)
        Me.txtNum2.Name = "txtNum2"
        Me.txtNum2.Size = New System.Drawing.Size(100, 20)
        Me.txtNum2.TabIndex = 2
        '
        'lblNum1
        '
        Me.lblNum1.AutoSize = True
        Me.lblNum1.Location = New System.Drawing.Point(12, 35)
        Me.lblNum1.Name = "lblNum1"
        Me.lblNum1.Size = New System.Drawing.Size(75, 13)
        Me.lblNum1.TabIndex = 3
        Me.lblNum1.Text = "Digite o 1º nº: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Label2"
        '
        'lblExibir
        '
        Me.lblExibir.AutoSize = True
        Me.lblExibir.Location = New System.Drawing.Point(12, 123)
        Me.lblExibir.Name = "lblExibir"
        Me.lblExibir.Size = New System.Drawing.Size(10, 13)
        Me.lblExibir.TabIndex = 5
        Me.lblExibir.Text = "."
        '
        'btnDivisao
        '
        Me.btnDivisao.Location = New System.Drawing.Point(15, 214)
        Me.btnDivisao.Name = "btnDivisao"
        Me.btnDivisao.Size = New System.Drawing.Size(75, 23)
        Me.btnDivisao.TabIndex = 5
        Me.btnDivisao.Text = "Dividir"
        Me.btnDivisao.UseVisualStyleBackColor = True
        '
        'btnMultiplicacao
        '
        Me.btnMultiplicacao.Location = New System.Drawing.Point(144, 166)
        Me.btnMultiplicacao.Name = "btnMultiplicacao"
        Me.btnMultiplicacao.Size = New System.Drawing.Size(75, 23)
        Me.btnMultiplicacao.TabIndex = 4
        Me.btnMultiplicacao.Text = "Multiplicar"
        Me.btnMultiplicacao.UseVisualStyleBackColor = True
        '
        'btnSubtrair
        '
        Me.btnSubtrair.Location = New System.Drawing.Point(144, 214)
        Me.btnSubtrair.Name = "btnSubtrair"
        Me.btnSubtrair.Size = New System.Drawing.Size(75, 23)
        Me.btnSubtrair.TabIndex = 6
        Me.btnSubtrair.Text = "Subtrair"
        Me.btnSubtrair.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(237, 291)
        Me.Controls.Add(Me.btnSubtrair)
        Me.Controls.Add(Me.btnMultiplicacao)
        Me.Controls.Add(Me.btnDivisao)
        Me.Controls.Add(Me.lblExibir)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblNum1)
        Me.Controls.Add(Me.txtNum2)
        Me.Controls.Add(Me.txtNum1)
        Me.Controls.Add(Me.btnSoma)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSoma As Button
    Friend WithEvents txtNum1 As TextBox
    Friend WithEvents txtNum2 As TextBox
    Friend WithEvents lblNum1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblExibir As Label
    Friend WithEvents btnDivisao As Button
    Friend WithEvents btnMultiplicacao As Button
    Friend WithEvents btnSubtrair As Button
End Class
