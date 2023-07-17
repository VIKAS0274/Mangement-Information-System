Imports System.Data.SqlClient

Public Class Form2

    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter

    Dim dt As DataTable
    Dim str As String

    Dim leaves As String

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\SAHOO\Desktop\Visual Basic - Exps\22_SECURITY_MANAGEMENT\Database1.mdf;Integrated Security=True")
    End Sub

    Private Sub btnViewAll_Click(sender As Object, e As EventArgs) Handles btnViewAll.Click
        con.Open()

        DataGridSecurity.Visible = True

        str = "SELECT * FROM SECURITY"
        cmd = New SqlCommand(str, con)
        cmd.ExecuteNonQuery()

        da = New SqlDataAdapter(cmd)
        dt = New DataTable
        da.Fill(dt)

        DataGridSecurity.DataSource = dt

        cmd.Dispose()
        con.Close()

    End Sub

    Private Sub btnLeaves_Click(sender As Object, e As EventArgs) Handles btnLeaves.Click
        con.Open()

        leaves = txtLeaves.Text

        DataGridSecurity.Visible = True

        str = "SELECT * FROM SECURITY WHERE leaves >= " & leaves
        cmd = New SqlCommand(str, con)
        cmd.ExecuteNonQuery()

        da = New SqlDataAdapter(cmd)
        dt = New DataTable
        da.Fill(dt)

        DataGridSecurity.DataSource = dt

        cmd.Dispose()
        con.Close()

    End Sub
End Class