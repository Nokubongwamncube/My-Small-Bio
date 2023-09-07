Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Name As String
        Dim surname As String
        Dim YearIwasBorn As Integer
        Dim tribe As String
        Dim Gender As String
        Dim greeting As String

        Name = txtname.Text
        surname = txtsurname.Text
        YearIwasBorn = txtYear.Text
        Gender = txtgender.Text
        tribe = txtTribe.Text.ToLower

        If tribe = "white" Then


            greeting = "hello"

        ElseIf tribe = "isizulu" Then
            greeting = "sawubona"

        ElseIf tribe = "venda" Then
            greeting = "ndaa"

        End If

        MsgBox("my name " & Name & " " & surname & " " & " i was born in " & YearIwasBorn & " " & "i am a" & " " & tribe & " " & Gender)


























    End Sub
End Class
