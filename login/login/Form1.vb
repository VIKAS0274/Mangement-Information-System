Imports System.Data.SqlClient
Imports System.Windows

Public Class Form1
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim dt As DataTable
    Dim dr As SqlDataReader
    Dim da As New SqlDataAdapter
    Dim str As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LogindataDataSet.vk' table. You can move, or remove it, as needed.
        Me.VkTableAdapter.Fill(Me.LogindataDataSet.vk)
        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\vb\login\login\logindata.mdf;Integrated Security=True"


    End Sub

    Private Sub login_Click(sender As Object, e As EventArgs) Handles login.Click
        con.Open()
        str = "Select * from vk where username='" & TextBox1.Text & "' and password ='" & TextBox2.Text & "'"
        cmd = New SqlCommand(str, con)
        da = New SqlDataAdapter(cmd)
        dt = New DataTable
        da.Fill(dt)
        If (dt.Rows.Count > 0) Then
            MsgBox("Entry accessed")
            Form2.Show()
        Else
            MsgBox("Invalid Username & Password")
        End If
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        con.Close()

    End Sub
End Class
