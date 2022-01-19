Public Class Form1
    'declaring variaables'

    Dim n1, n2, n3 As Integer
    Dim av As Double
    'assigning variables '


    Private Sub addition_Click(sender As Object, e As EventArgs) Handles addition.Click
        n1 = num1.Text
        n2 = num2.Text
        n3 = num3.Text
        Dim sum As Integer
        sum = n1 + n2 + n3
        answer.Text = sum
    End Sub

    Private Sub product_Click(sender As Object, e As EventArgs) Handles product.Click
        n1 = num1.Text
        n2 = num2.Text
        n3 = num3.Text
        Dim multiplication As Integer
        multiplication = n1 * n2 * n3
        answer.Text = multiplication
    End Sub

    Private Sub Average_Click(sender As Object, e As EventArgs) Handles Average.Click
        Dim averg As Double
        averg = (n1 + n2 + n3) / 2
        answer.Text = averg
    End Sub

    Private Sub boldBtn_Click(sender As Object, e As EventArgs) Handles boldBtn.Click

    End Sub

    Private Sub del_Click(sender As Object, e As EventArgs) Handles del.Click
        num1.Clear()
        num2.Clear()
        num3.Clear()
        answer.Clear()


    End Sub

    Private Sub extBtn_Click(sender As Object, e As EventArgs) Handles extBtn.Click

    End Sub


End Class
