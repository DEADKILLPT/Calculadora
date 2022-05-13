Public Class Form1
    Dim IMC, Peso, Altura As Single ' declarar variaveis como single
    Dim Avaliacao






    Private Sub lblresultado_Click(sender As Object, e As EventArgs) Handles lblresultado.Click



    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click

        Me.Close()

    End Sub

    Private Sub btnVer_Click(sender As Object, e As EventArgs) Handles btnVer.Click

        FormTabelaIMC.Show()
        FormTabelaIMC.LblValorIMC.Text = lblresultado.Text


    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblAvaliacao.Click




    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        PictureBox1.Show()

    End Sub

    Private Sub txtPeso_Validated(sender As Object, e As EventArgs) Handles txtPeso.Validated
        If IsNumeric(txtPeso.Text) And txtPeso.Text <> "" Then
            Peso = CSng(txtPeso.Text) 'receber o valor do peso e guardar na variável
            If Peso < 0 Or Peso > 500 Then
                MsgBox("Erro: o peso deve ser entre 1 a 500")
                txtPeso.ResetText()
            End If
        ElseIf txtPeso.Text <> "" Then
            MsgBox("Erro: Introduza um número de 1 a 500")
            txtPeso.ResetText()
        End If


    End Sub

    Private Sub TxtAltura_Validated(sender As Object, e As EventArgs) Handles TxtAltura.Validated

        If IsNumeric(TxtAltura.Text) And TxtAltura.Text <> "" Then
            Altura = CSng(TxtAltura.Text) 'receber o valor da altura e guardar na variável
            If Altura < 0 Or Altura > 2.5 Then
                MsgBox("Erro: A altura deve ser entre 0 a 2,50")
                TxtAltura.ResetText()
            End If
        ElseIf TxtAltura.Text <> "" Then
            MsgBox("Erro: Introduza um número de 0 a 2,5")
        TxtAltura.ResetText()
        End If

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Select Case IMC
            Case Is <= 18.5
                MsgBox("Abaixo de Peso")
            Case 18.5 To 25
                MsgBox("Peso Normal")
            Case 25.0 To 30
                MsgBox("Pré Obesidade")
            Case 30 To 35
                MsgBox("Obesidade Grau I")
            Case 35 To 40
                MsgBox("Obesidade Grau II")
            Case > 40
                MsgBox("Obesidade Grau III")

        End Select
    End Sub

    Private Sub btnCalcula_Click(sender As Object, e As EventArgs) Handles btnCalcula.Click
        'Guardar variaveis
        IMC = txtPeso.Text / TxtAltura.Text ^ 2
        Avaliacao = lblAvaliacao.Text
        ' resultado arredondado
        lblresultado.Text = Math.Round(IMC, 1)

        If IMC < 18.5 Then
            lblAvaliacao.Text = "Abaixo de Peso"
        ElseIf IMC >= 18.5 And IMC <= 25 Then
            lblAvaliacao.Text = "Peso Normal"
        ElseIf IMC > 25.0 And IMC <= 30 Then
            lblAvaliacao.Text = "Pré Obesidade"
        ElseIf IMC > 30 And IMC <= 35 Then
            lblAvaliacao.Text = "Obesidade Grau I"
        ElseIf IMC > 35 And IMC <= 40 Then
            lblAvaliacao.Text = "Obesidade Grau II"
        ElseIf IMC > 40 Then
            lblAvaliacao.Text = "Obesidade Grau III"
        End If

        If IMC >= 18.5 And IMC < 25 Then
            lblAvaliacao.ForeColor = Color.Green
        Else
            lblAvaliacao.ForeColor = Color.Red
        End If
    End Sub

    Private Sub btnLimpa_Click(sender As Object, e As EventArgs) Handles btnLimpa.Click

        txtPeso.Clear()
        TxtAltura.Clear()
        lblresultado.Text = "?"
        lblAvaliacao.Text = "?"
        If lblAvaliacao.Text = "?" Then
            lblAvaliacao.ForeColor = Color.Black
        End If

    End Sub
End Class
