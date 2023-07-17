Imports System.Data.SqlClient


Public Class Form1

    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter

    Dim dt As DataTable
    Dim str As String

    Dim id As String
    Dim custName As String
    Dim addr As String
    Dim mtrVal As Decimal
    Dim cost As Decimal

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\SAHOO\Desktop\Visual Basic - Exps\18_ELECTRICITY_BILL\Database1.mdf;Integrated Security=True")
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        If txtId.Text = "" Or txtName.Text = "" Or txtMtr.Text = "" Or txtAddress.Text = "" Then
            MsgBox("Enter All Details")
        Else
            id = txtId.Text
            custName = txtName.Text
            addr = txtAddress.Text
            mtrVal = txtMtr.Text

            If mtrVal < 100 Then
                cost = mtrVal * 2
            ElseIf mtrVal >= 100 And mtrVal < 500 Then
                cost = mtrVal * 4
            ElseIf mtrVal >= 500 And mtrVal < 1000 Then
                cost = mtrVal * 6
            ElseIf mtrVal >= 1000 Then
                cost = mtrVal * 8
            End If

            MsgBox("Your Cost : " & cost)
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        con.Open()
        If txtId.Text = "" Or txtName.Text = "" Or txtMtr.Text = "" Or txtAddress.Text = "" Then
            MsgBox("Enter All Details")
        Else
            str = "INSERT INTO BILL VALUES ('" & id & "','" & custName & "','" & mtrVal & "','" & cost & "')"
            cmd = New SqlCommand(str, con)
            cmd.ExecuteNonQuery()

            MsgBox("Data Added Successfully ! ")

            txtAddress.Clear()
            txtId.Clear()
            txtMtr.Clear()
            txtName.Clear()

            cmd.Dispose()
            con.Close()

        End If



    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        con.Open()

        DataGridBill.Visible = True

        str = "SELECT * FROM BILL"
        cmd = New SqlCommand(str, con)
        da = New SqlDataAdapter(cmd)
        dt = New DataTable

        da.Fill(dt)

        DataGridBill.DataSource = dt
        cmd.Dispose()
        con.Close()

    End Sub
End Class
