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
        Me.btnSomar = New System.Windows.Forms.Button()
        Me.txtNum1 = New System.Windows.Forms.TextBox()
        Me.txtNum2 = New System.Windows.Forms.TextBox()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblExibir = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnSomar
        '
        Me.btnSomar.Location = New System.Drawing.Point(177, 124)
        Me.btnSomar.Name = "btnSomar"
        Me.btnSomar.Size = New System.Drawing.Size(75, 23)
        Me.btnSomar.TabIndex = 3
        Me.btnSomar.Text = "Somar"
        Me.btnSomar.UseVisualStyleBackColor = True
        '
        'txtNum1
        '
        Me.txtNum1.Location = New System.Drawing.Point(152, 30)
        Me.txtNum1.Name = "txtNum1"
        Me.txtNum1.Size = New System.Drawing.Size(100, 20)
        Me.txtNum1.TabIndex = 1
        '
        'txtNum2
        '
        Me.txtNum2.Location = New System.Drawing.Point(152, 73)
        Me.txtNum2.Name = "txtNum2"
        Me.txtNum2.Size = New System.Drawing.Size(100, 20)
        Me.txtNum2.TabIndex = 2
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Location = New System.Drawing.Point(25, 30)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(97, 13)
        Me.lbl1.TabIndex = 3
        Me.lbl1.Text = "Digite o 1º numero:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Digite o 2º numero:"
        '
        'lblExibir
        '
        Me.lblExibir.AutoSize = True
        Me.lblExibir.Location = New System.Drawing.Point(25, 124)
        Me.lblExibir.Name = "lblExibir"
        Me.lblExibir.Size = New System.Drawing.Size(0, 13)
        Me.lblExibir.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(282, 176)
        Me.Controls.Add(Me.lblExibir)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.txtNum2)
        Me.Controls.Add(Me.txtNum1)
        Me.Controls.Add(Me.btnSomar)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSomar As Button
    Friend WithEvents txtNum1 As TextBox
    Friend WithEvents txtNum2 As TextBox
    Friend WithEvents lbl1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblExibir As Label
End Class
