Imports System.Data.SqlClient

Public Class Form1
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter

    Dim dt As DataTable
    Dim str As String

    Dim id As String
    Dim name_ As String
    Dim Dept As String
    Dim basic_pay As Decimal
    Dim hra As Decimal
    Dim da_ As Decimal
    Dim net As Decimal
    Dim gross As Decimal
    Dim pf As Decimal

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\SAHOO\Desktop\Visual Basic - Exps\21_PAYROLL\Database1.mdf;Integrated Security=True")
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click

        Dim bonus As String
        bonus = "No"
        pf = 5000

        id = txtId.Text
        name_ = txtName.Text
        Dept = txtDept.Text
        basic_pay = txtBP.Text
        hra = txtHRA.Text
        da_ = txtDA.Text

        gross = basic_pay + hra + da_
        net = gross - pf

        If Dept = "CSE" Then
            net = net + 10000
            bonus = "Yes"
        End If

        MsgBox("Gross Salary : " & gross & vbNewLine & "Net Salary : " & net & vbNewLine & "Bonus : " & bonus)

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        con.Open()
        str = "INSERT INTO PAYROLL VALUES ('" & id & "','" & name_ & "','" & basic_pay & "','" & hra & "','" & da_ & "','" & gross & "','" & net & "','" & Dept & "')"
        cmd = New SqlCommand(str, con)
        cmd.ExecuteNonQuery()

        MsgBox("Data Added Successfully ! ")

        cmd.Dispose()
        con.Close()

    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click

        con.Open()
        DataGridPayroll.Visible = True

        str = "SELECT * FROM PAYROLL"
        cmd = New SqlCommand(str, con)
        cmd.ExecuteNonQuery()
        da = New SqlDataAdapter(cmd)
        dt = New DataTable

        da.Fill(dt)

        DataGridPayroll.DataSource = dt

        cmd.Dispose()
        con.Close()

        txtBP.Clear()
        txtDA.Clear()
        txtDept.Clear()
        txtHRA.Clear()
        txtId.Clear()
        txtName.Clear()


    End Sub
End Class
