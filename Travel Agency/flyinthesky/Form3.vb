Imports System.IO
Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form4.Show()
        Me.Hide()
        Dim fs As New FileStream("C:\Users\msi\Desktop\users.txt", FileMode.Append, FileAccess.Write)
        Dim sw As New StreamWriter(fs)
        sw.WriteLine(TextBox2.Text + "#" + TextBox7.Text + "#" + TextBox6.Text + "#" + TextBox5.Text + "#" + TextBox1.Text + "#" + TextBox4.Text + "#" + TextBox3.Text + "#" + TextBox9.Text + "#" + TextBox10.Text)
        sw.Close()
        fs.Close()

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If Len(TextBox1.Text) > 7 Then
            MsgBox("STOP")
        End If
    End Sub

    Dim CIN() As Char = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"}
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Not CIN.Contains(e.KeyChar) And Not Asc(e.KeyChar) = 8 And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Space) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Dim datecheck As String
        Dim today As System.DateTime = System.DateTime.Now
        datecheck = DateTimePicker1.Text

        Dim yearnow As Integer = today.Year
        Dim yeardtp As Integer = DateTimePicker1.Value.Year
        Dim rightyear As Integer = DateTimePicker1.Value.Year
        Dim minimage As Integer = yeardtp - rightyear
        Dim currentage As Integer = yearnow - yeardtp
        TextBox3.Text = currentage.ToString
        TextBox3.Show()
    End Sub

    Private Sub TextBox6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox6.KeyPress
        Dim chars As String = "abcdefghijklmnopqrstuvwxyz"
        If Not chars.Contains(e.KeyChar.ToString.ToLower) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Space) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("PLEASE ENTER A CHARACTER")
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox5.KeyPress
        Dim chars As String = "abcdefghijklmnopqrstuvwxyz"
        If Not chars.Contains(e.KeyChar.ToString.ToLower) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Space) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("PLEASE ENTER A CHARACTER")

        End If
    End Sub

    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress
        Dim num As String = "1234567890"
        If Not num.Contains(e.KeyChar.ToString) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Space) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("PLEASE ENTER A NUMBER")
        End If
    End Sub

    Private Sub TextBox9_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox9.KeyPress
        Dim chars As String = "abcdefghijklmnopqrstuvwxyz"
        If Not chars.Contains(e.KeyChar.ToString.ToLower) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Space) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("PLEASE ENTER A CHARACTER")
        End If
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        Dim chars As String = "abcdefghijklmnopqsrtuvwyz"
        Dim num As String = "1234567890"
        Dim symbols As String = "@gmail.com"
        If Not chars.Contains(e.KeyChar.ToString.ToLower) And Not num.Contains(e.KeyChar.ToString.ToLower) And Not symbols.Contains(e.KeyChar.ToString.ToLower) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MsgBox("PLEASE ENTER A VALID EMAIL")
        End If
    End Sub
End Class