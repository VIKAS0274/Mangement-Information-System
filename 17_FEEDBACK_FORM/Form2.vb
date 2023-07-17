Imports System.Data.SqlClient

Public Class Form2

    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter

    Dim dt As DataTable
    Dim str As String

    Private Sub btnViewDate_Click(sender As Object, e As EventArgs) Handles btnViewDate.Click
        con.Open()

        DataGridFEEDBACK.Visible = True

        str = "SELECT * FROM FEEDBACK WHERE date = '" & txtDate.Text & "' "
        cmd = New SqlCommand(str, con)
        cmd.ExecuteNonQuery()
        da = New SqlDataAdapter(cmd)
        dt = New DataTable

        da.Fill(dt)

        DataGridFEEDBACK.DataSource = dt

        cmd.Dispose()
        con.Close()


    End Sub

    Private Sub btnViewAll_Click(sender As Object, e As EventArgs) Handles btnViewAll.Click
        con.Open()

        DataGridFEEDBACK.Visible = True
        str = "SELECT * FROM FEEDBACK"
        cmd = New SqlCommand(str, con)
        cmd.ExecuteNonQuery()
        da = New SqlDataAdapter(cmd)
        dt = New DataTable

        da.Fill(dt)

        DataGridFEEDBACK.DataSource = dt

        cmd.Dispose()
        con.Close()


    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\SAHOO\Desktop\Visual Basic - Exps\17_FeedbackForm\Database1.mdf;Integrated Security=True")

    End Sub
End Class