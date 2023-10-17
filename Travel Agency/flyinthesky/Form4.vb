Imports System.IO
Public Class Form4
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form5.Show()
        Me.Hide()
        Dim fs As New FileStream("C:\Users\msi\Desktop\tickets.txt", FileMode.Append, FileAccess.Write)
        Dim sw As New StreamWriter(fs)
        sw.WriteLine(DateTimePicker1.Text + "#" + TextBox2.Text + "#" + TextBox1.Text + "#" + ComboBox1.Text + "#" + TextBox3.Text + "#" + CheckedListBox1.Text + "#" + TextBox4.Text + "#" + TextBox5.Text)
        sw.Close()
        fs.Close()
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim fs As New FileStream("C:\Users\msi\Desktop\vols.txt", FileMode.Open, FileAccess.Read)
        Dim sr As New StreamReader(fs)
        Dim s As String
        Dim t() As String
        Dim trouve As Integer
        Dim P As Integer
        Dim prix As String
        ListBox1.Show()
        While sr.Peek > -1
            s = sr.ReadLine
            t = s.Split("#")
            trouve = 0
            If String.Compare(t(0), TextBox2.Text) = 0 Then
                trouve = trouve + 1
            End If
            If String.Compare(t(1), DateTimePicker1.Text) = 0 Then
                trouve = trouve + 1
            End If
            If String.Compare(t(3), TextBox1.Text) = 0 Then
                trouve = trouve + 1
            End If
            If trouve = 3 Then
                ListBox1.Items.Add(t(2))
                If ComboBox1.Text = "First" Then
                    P = Convert.ToInt32(t(4)) + 200
                ElseIf ComboBox1.Text = "Business" Then
                    P = Convert.ToInt32(t(4)) + 100
                Else
                    P = Convert.ToInt32(t(4))
                End If
                prix = P.ToString
            End If
        End While
        TextBox5.Text = prix
        sr.Close()
        fs.Close()
    End Sub

    Private Sub ListBox1_SelectedValueChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedValueChanged
        Button2.Show()
        Button1.Show()
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        Dim chars As String = "abcdefghijklmnopqrstuvwxyz"
        If Not chars.Contains(e.KeyChar.ToString.ToLower) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Space) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("PLEASE ENTER A CHARACTER")

        End If
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        Dim chars As String = "abcdefghijklmnopqsrtuvwyz"
        Dim num As String = "1234567890"
        If Not chars.Contains(e.KeyChar.ToString.ToLower) And Not num.Contains(e.KeyChar.ToString.ToLower) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MsgBox("PLEASE ENTER A VALID PASSPORT ")
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        Dim chars As String = "abcdefghijklmnopqrstuvwxyz"
        If Not chars.Contains(e.KeyChar.ToString.ToLower) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Space) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("PLEASE ENTER A CHARACTER")

        End If
    End Sub

    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress
        Dim NUMCARTE() As Char = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"}
        If Not NUMCARTE.Contains(e.KeyChar) And Not Asc(e.KeyChar) = 16 And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Space) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox2.Clear()
        TextBox1.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        ListBox1.ClearSelected()
    End Sub
End Class