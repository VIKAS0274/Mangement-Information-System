Imports System.Data.SqlClient
Imports System.Security.Cryptography.X509Certificates

Public Class Form1

    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter

    Dim dt As DataTable

    Dim str As String

    Dim food As String
    Dim num As Integer
    Dim price As Decimal

    Public Shared TotalPrice As Integer = 0
    Public Shared itemNo As Integer = 1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\SAHOO\Desktop\Visual Basic - Exps\25_FOOD_BILLING\Database1.mdf;Integrated Security=True")

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        num = txtQuantity.Text

        If chk1.Checked = True Then
            food = "Fried Rice"
            price = 100 * num
            TotalPrice = TotalPrice + 100
        ElseIf chk2.Checked = True Then
            food = "Grill"
            price = 300 * num
            TotalPrice = TotalPrice + 300
        ElseIf chk3.Checked = True Then
            food = "Chapati"
            price = 40 * num
            TotalPrice = TotalPrice + 40
        ElseIf chk4.Checked = True Then
            food = "Meals"
            price = 70 * num
            TotalPrice = TotalPrice + 70
        End If

        con.Open()
        DataGridBill.Visible = True

        str = "INSERT INTO FOOD VALUES (" & itemNo & ",'" & food & "'," & txtQuantity.Text & "," & price & ")"
        cmd = New SqlCommand(str, con)
        cmd.ExecuteNonQuery()
        itemNo = itemNo + 1
        cmd.Dispose()

        str = "SELECT * FROM FOOD"
        cmd = New SqlCommand(str, con)
        da = New SqlDataAdapter(cmd)
        dt = New DataTable
        da.Fill(dt)
        DataGridBill.DataSource = dt

        cmd.Dispose()
        con.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        con.Open()
        DataGridTotal.Visible = True

        str = "SELECT SUM(price) FROM FOOD"
        cmd = New SqlCommand(str, con)
        da = New SqlDataAdapter(cmd)
        dt = New DataTable
        da.Fill(dt)
        DataGridTotal.DataSource = dt

        cmd.Dispose()
        con.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        con.Open()

        str = "DELETE FROM FOOD WHERE Id = " & txtId.Text
        cmd = New SqlCommand(str, con)
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        str = "SELECT * FROM FOOD"
        cmd = New SqlCommand(str, con)
        da = New SqlDataAdapter(cmd)
        dt = New DataTable
        da.Fill(dt)
        DataGridBill.DataSource = dt

        cmd.Dispose()
        con.Close()


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        con.Open()

        str = "DELETE FROM FOOD"
        cmd = New SqlCommand(str, con)
        itemNo = 1
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        str = "SELECT * FROM FOOD"
        cmd = New SqlCommand(str, con)
        da = New SqlDataAdapter(cmd)
        dt = New DataTable
        da.Fill(dt)
        DataGridBill.DataSource = dt

        cmd.Dispose()
        con.Close()

    End Sub

End Class
