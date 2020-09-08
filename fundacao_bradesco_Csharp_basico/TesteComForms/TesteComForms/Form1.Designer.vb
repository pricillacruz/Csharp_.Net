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
        Me.SuspendLayout()
        '
        'btnSoma
        '
        Me.btnSoma.Location = New System.Drawing.Point(144, 134)
        Me.btnSoma.Name = "btnSoma"
        Me.btnSoma.Size = New System.Drawing.Size(75, 23)
        Me.btnSoma.TabIndex = 3
        Me.btnSoma.Text = "Soma"
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
        Me.lblExibir.Location = New System.Drawing.Point(12, 139)
        Me.lblExibir.Name = "lblExibir"
        Me.lblExibir.Size = New System.Drawing.Size(10, 13)
        Me.lblExibir.TabIndex = 5
        Me.lblExibir.Text = "."
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(237, 198)
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
End Class
