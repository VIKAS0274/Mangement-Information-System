Imports System.Data.SqlClient
Public Class Form1

    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter
    Dim dt As DataSet

    Dim str As String

    Dim id As String
    Dim age As Integer
    Dim name_ As String

    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click

        If txtId.Text.Length = 0 Or txtAge.Text.Length = 0 Or TxtName.Text.Length = 0 Then
            MsgBox("Enter All Details")
        Else
            id = txtId.Text
            age = txtAge.Text
            name_ = TxtName.Text

            If age >= 18 Then
                MsgBox("You are eligible to Vote. ")
            Else
                MsgBox("You are not eligible to Vote. ")
            End If
        End If

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        con.Open()

        If txtAge.Text.Length = 0 Or txtId.Text.Length = 0 Or TxtName.Text.Length = 0 Then
            MsgBox("Enter All Details")
        Else
            If CInt(txtAge.Text) >= 18 Then
                age = txtAge.Text
                str = "INSERT INTO VOTERS VALUES ('" & id & "','" & name_ & "','" & age & "' )"
                cmd = New SqlCommand(str, con)
                cmd.ExecuteNonQuery()

                MsgBox("Data Inserted Successfully")
            Else
                MsgBox("You are not eligible to vote")
            End If
        End If

            con.Close()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\SAHOO\Desktop\Visual Basic - Exps\19_VOTING\Database1.mdf;Integrated Security=True")
    End Sub
End Class
