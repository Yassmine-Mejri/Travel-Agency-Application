Imports System.IO
Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form4.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim fs As New FileStream("C:\Users\msi\Desktop\users.txt", FileMode.Open, FileAccess.Read)
        Dim sr As New StreamReader(fs)
        Dim t() As String
        Dim s As String
        Dim trouve As Integer = 0
        While sr.Peek > -1
            s = sr.ReadLine
            t = s.Split("#")
            If (String.Compare(t(0), TextBox1.Text) = 0 And String.Compare(t(1), TextBox9.Text) = 0) Then
                trouve = 1
            End If
        End While
        sr.Close()
        fs.Close()
        If (trouve = 1) Then

            Label2.Text = "Welcome " + t(2) + " " + t(3) + " to SKIies " + " "
            Label4.Text = "CIN:" + t(4) + " "
            Label5.Text = "age:" + t(6) + " "
            Label6.Text = "phone number:" + t(5) + " "
            Label8.Text = "nationality:" + t(7) + " "
            Label2.Show()
            Label4.Show()
            Label5.Show()
            Label6.Show()
            Label8.Show()
        Else
            MsgBox("incorrect")
            Form3.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        Dim chars As String = "abcdefghijklmnopqsrtuvwyz"
        Dim num As String = "1234567890"
        Dim symbols As String = "@gmail.com"
        If Not chars.Contains(e.KeyChar.ToString.ToLower) And Not num.Contains(e.KeyChar.ToString.ToLower) And Not symbols.Contains(e.KeyChar.ToString.ToLower) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("PLEASE ENTER A VALID EMAIL")
        End If
    End Sub

End Class