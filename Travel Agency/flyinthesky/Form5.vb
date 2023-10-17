Imports System.IO
Public Class Form5
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("** Hope You Have A Pleasant Trip **")
        End
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim fs As New FileStream("C:\Users\msi\Desktop\users.txt", FileMode.Open, FileAccess.Read)
        Dim sr As New StreamReader(fs)
        Dim fs1 As New FileStream("C:\Users\msi\Desktop\tickets.txt", FileMode.Open, FileAccess.Read)
        Dim sr1 As New StreamReader(fs1)
        Dim t() As String
        Dim s As String
        Dim t1() As String
        Dim s1 As String
        Dim trouve As Integer = 0
        While sr.Peek > -1
            s = sr.ReadLine
            t = s.Split("#")
            While sr1.Peek > -1
                s1 = sr1.ReadLine
                t1 = s1.Split("#")
                If String.Compare(t(8), t1(4)) = 0 Then
                    trouve = 1
                End If
            End While
        End While
        sr1.Close()
        fs1.Close()
        sr.Close()
        fs.Close()
        If trouve = 1 Then
            Label2.Text = "Name: " + t(2) + " " + t(3) + " "
            Label3.Text = "CIN: " + t(4) + " "
            Label4.Text = "from: " + t1(1) + " "
            Label5.Text = "to: " + t1(2) + " "
            Label6.Text = "date: " + t1(0) + " "
            Label8.Text = "class:" + t1(3) + " "
            Label2.Show()
            Label3.Show()
            Label4.Show()
            Label5.Show()
            Label6.Show()
            Label8.Show()
        End If
    End Sub
End Class