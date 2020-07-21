Public Class Form1
    Private Const A = 2, B = 2, C = 3

    Private Sub txtAnswers_TextChanged(sender As Object, e As EventArgs) Handles txtAnswers.TextChanged

    End Sub



    'Функция-обработчик нажатия клавиши Enter
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) _
                                           As Boolean

        If msg.WParam.ToInt32() = CInt(Keys.Enter) Then
            Dim x As Double = txtX.Text
            Dim z As Double = txtZ.Text

            'ToDo Write your code here bro focus!!! допустим ты что-то накодил вооот так видишь изменения появились

            Dim answer1 As Double = ((A + B) / ((2 * A) - B)) * (A + C) * Math.Pow(Math.Sin(x), 2) + z     'first equation
            Dim answer2 As Double = Math.Pow(x, A * C) + Math.Exp(B) + Math.Sqrt((A * x) + B)    'second equation
            Dim answer3 As Double = (A + B * x - C * Math.Pow(x, 2)) / (Math.Cos(x) + Math.Exp(Math.Sqrt(x))) + Math.Pow(x, A - B)
            Dim answer4 As Double = Math.Log10(B) * Math.Pow(Math.Cos(x), 5) * Math.Sqrt((A * C) / Math.Pow(x, 4))
            Dim answer5 As Double = (x * A / B) * Math.Sqrt(Math.Pow(x, C)) * 1 / (Math.Pow(A, x) + 1)
            Dim answer6 As Double = Math.Pow(A, 1 / x) + C * Math.Sqrt(Math.Sin(x) + x)
            Dim answer7 As Double = Math.Pow((Math.Pow(x, B) + A / C * Math.Log10(Math.Abs(A - 2 * C))), -A)
            Dim answer8 As Double = Math.Tan(A / B) + Math.Exp(x) - (1 + x) / Math.Pow(Math.Sin(x), 2)
            Dim answer9 As Double = Math.Pow(B, x) + (A / Math.Pow(x, C)) + Math.Sqrt(Math.Abs(A - x))
            Dim answer10 As Double = -2 * Math.Sqrt(Math.Pow(A, x) + 4 * x * x / (A * A + B - C))
            Dim answer11 As Double = (A * Math.Exp(Math.Sin(x)) + Math.Log10(B + C)) / (Math.Sin(x + B))
            Dim answer12 As Double = Math.Sqrt(Math.Pow(Math.Sin(x * x + A), 2) + C)
            Dim answer13 As Double = 3.85 * x * x * Math.Log10(Math.Abs(A - Math.Pow(B, x + C)))
            Dim answer14 As Double = Math.Pow(x, 4) / (1 + (Math.Pow(x, B) / (1 + Math.Pow(x, C))))
            Dim ans1 As String = answer2.ToString()



            Return True
        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function


End Class
