Imports System.Data
Imports System.Data.SqlClient

Public Class loginForm
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter

    Dim dt As DataTable
    Dim str As String
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click

        cmd = New SqlCommand("INSERT INTO [Table] VALUES (@0,@1)", con)
        cmd.Parameters.AddWithValue("@0", txtUserName.Text)
        cmd.Parameters.AddWithValue("@1", txtPassword.Text)

        cmd.ExecuteNonQuery()

        MsgBox("Data Added Successfully ! ")
        txtPassword.Clear()
        txtUserName.Clear()

    End Sub

    Private Sub loginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\SAHOO\Desktop\Visual Basic - Exps\20_LoginPage\EXPERIMENT20.mdf;Integrated Security=True")
        con.Open()

        MsgBox("Database Connection Successful")

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        str = "SELECT * FROM [Table] WHERE username='" & txtUserName.Text & "' AND password
                = '" & txtPassword.Text & "'"
        cmd = New SqlCommand(str, con)
        da = New SqlDataAdapter(cmd)
        dt = New DataTable

        da.Fill(dt)

        If (dt.Rows.Count > 0) Then
            MsgBox("Entry Accessed. ")
        Else
            MsgBox("Entry Denied . Consider To Register First .")
        End If


    End Sub
End Class
