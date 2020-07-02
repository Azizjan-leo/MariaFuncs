Public Class Form1
    Private Const A = 2, B = 2, C = 3

    'Функция-обработчик нажатия клавиши Enter
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) _
                                           As Boolean

        If msg.WParam.ToInt32() = CInt(Keys.Enter) Then
            Dim x As Double = txtX.Text
            Dim z As Double = txtZ.Text

            'ToDo Write your code here

            Dim answer1 As Double = ((A + B) / ((2 * A) - B)) * (A + C) * Math.Pow(Math.Sin(x), 2) + z

            txtAnswers.Text = answer1.ToString + Environment.NewLine
            Return True
        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function


End Class
