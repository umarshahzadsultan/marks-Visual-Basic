Public Class Form1

    Dim en, bio, che, mat, isl, tot, av

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If (tot >= 50) Then TextBox8.Text = "A"
        If (tot <= 40) Then TextBox8.Text = "B"
        If (tot <= 30) Then TextBox8.Text = "C"
        If (tot <= 20) Then TextBox8.Text = "D"
        If (tot <= 10) Then TextBox8.Text = "F"
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        av = tot / 5
        TextBox7.Text = av
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        en = Val(TextBox1.Text)
        bio = Val(TextBox2.Text)
        che = Val(TextBox3.Text)
        mat = Val(TextBox4.Text)
        isl = Val(TextBox5.Text)
        tot = en + bio + che + mat + isl
        TextBox6.Text = tot


    End Sub
End Class
