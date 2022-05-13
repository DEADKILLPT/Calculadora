<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblPeso = New System.Windows.Forms.Label()
        Me.txtPeso = New System.Windows.Forms.TextBox()
        Me.lblAltura = New System.Windows.Forms.Label()
        Me.TxtAltura = New System.Windows.Forms.TextBox()
        Me.lblIMC = New System.Windows.Forms.Label()
        Me.lblresultado = New System.Windows.Forms.Label()
        Me.btnLimpa = New System.Windows.Forms.Button()
        Me.btnCalcula = New System.Windows.Forms.Button()
        Me.btnVer = New System.Windows.Forms.Button()
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.lblAvaliacao = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblPeso
        '
        Me.lblPeso.AutoSize = True
        Me.lblPeso.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPeso.Location = New System.Drawing.Point(45, 82)
        Me.lblPeso.Name = "lblPeso"
        Me.lblPeso.Size = New System.Drawing.Size(90, 18)
        Me.lblPeso.TabIndex = 1
        Me.lblPeso.Text = "Peso (KG)"
        '
        'txtPeso
        '
        Me.txtPeso.Location = New System.Drawing.Point(170, 83)
        Me.txtPeso.Name = "txtPeso"
        Me.txtPeso.Size = New System.Drawing.Size(129, 20)
        Me.txtPeso.TabIndex = 3
        Me.txtPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblAltura
        '
        Me.lblAltura.AutoSize = True
        Me.lblAltura.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAltura.Location = New System.Drawing.Point(45, 144)
        Me.lblAltura.Name = "lblAltura"
        Me.lblAltura.Size = New System.Drawing.Size(92, 18)
        Me.lblAltura.TabIndex = 4
        Me.lblAltura.Text = "Altura (m)"
        '
        'TxtAltura
        '
        Me.TxtAltura.Location = New System.Drawing.Point(170, 142)
        Me.TxtAltura.Name = "TxtAltura"
        Me.TxtAltura.Size = New System.Drawing.Size(129, 20)
        Me.TxtAltura.TabIndex = 5
        Me.TxtAltura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblIMC
        '
        Me.lblIMC.AutoSize = True
        Me.lblIMC.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIMC.Location = New System.Drawing.Point(85, 204)
        Me.lblIMC.Name = "lblIMC"
        Me.lblIMC.Size = New System.Drawing.Size(38, 16)
        Me.lblIMC.TabIndex = 9
        Me.lblIMC.Text = "IMC:"
        '
        'lblresultado
        '
        Me.lblresultado.AutoSize = True
        Me.lblresultado.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblresultado.Location = New System.Drawing.Point(167, 204)
        Me.lblresultado.Name = "lblresultado"
        Me.lblresultado.Size = New System.Drawing.Size(14, 16)
        Me.lblresultado.TabIndex = 10
        Me.lblresultado.Text = "?"
        '
        'btnLimpa
        '
        Me.btnLimpa.Location = New System.Drawing.Point(12, 278)
        Me.btnLimpa.Name = "btnLimpa"
        Me.btnLimpa.Size = New System.Drawing.Size(57, 54)
        Me.btnLimpa.TabIndex = 11
        Me.btnLimpa.Text = "Limpa"
        Me.btnLimpa.UseVisualStyleBackColor = True
        '
        'btnCalcula
        '
        Me.btnCalcula.Location = New System.Drawing.Point(88, 278)
        Me.btnCalcula.Name = "btnCalcula"
        Me.btnCalcula.Size = New System.Drawing.Size(57, 54)
        Me.btnCalcula.TabIndex = 12
        Me.btnCalcula.Text = "Calcula"
        Me.btnCalcula.UseVisualStyleBackColor = True
        '
        'btnVer
        '
        Me.btnVer.Location = New System.Drawing.Point(170, 278)
        Me.btnVer.Name = "btnVer"
        Me.btnVer.Size = New System.Drawing.Size(57, 54)
        Me.btnVer.TabIndex = 13
        Me.btnVer.Text = "Ver..."
        Me.btnVer.UseVisualStyleBackColor = True
        '
        'btnFechar
        '
        Me.btnFechar.Location = New System.Drawing.Point(242, 278)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(57, 54)
        Me.btnFechar.TabIndex = 14
        Me.btnFechar.Text = "Fechar"
        Me.btnFechar.UseVisualStyleBackColor = True
        '
        'lblAvaliacao
        '
        Me.lblAvaliacao.AutoSize = True
        Me.lblAvaliacao.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvaliacao.Location = New System.Drawing.Point(52, 236)
        Me.lblAvaliacao.Name = "lblAvaliacao"
        Me.lblAvaliacao.Size = New System.Drawing.Size(17, 18)
        Me.lblAvaliacao.TabIndex = 15
        Me.lblAvaliacao.Text = "?"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(36, 338)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(230, 54)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Select Case"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WinFormsAppIMCPaulo2.My.Resources.Resources._254125647_585616032662314_8475384937046260734_n
        Me.PictureBox1.Location = New System.Drawing.Point(335, 82)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(150, 150)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(499, 410)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblAvaliacao)
        Me.Controls.Add(Me.btnFechar)
        Me.Controls.Add(Me.btnVer)
        Me.Controls.Add(Me.btnCalcula)
        Me.Controls.Add(Me.btnLimpa)
        Me.Controls.Add(Me.lblresultado)
        Me.Controls.Add(Me.lblIMC)
        Me.Controls.Add(Me.TxtAltura)
        Me.Controls.Add(Me.lblAltura)
        Me.Controls.Add(Me.txtPeso)
        Me.Controls.Add(Me.lblPeso)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPeso As Label
    Friend WithEvents txtPeso As TextBox
    Friend WithEvents lblAltura As Label
    Friend WithEvents TxtAltura As TextBox
    Friend WithEvents lblIMC As Label
    Friend WithEvents lblresultado As Label
    Friend WithEvents btnLimpa As Button
    Friend WithEvents btnCalcula As Button
    Friend WithEvents btnVer As Button
    Friend WithEvents btnFechar As Button
    Friend WithEvents lblAvaliacao As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
End Class
