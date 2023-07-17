Imports System.Data.SqlClient

Public Class Form1

    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter

    Dim dt As DataTable
    Dim str As String

    Dim name_ As String
    Dim id As String
    Dim id2 As String
    Dim leaves As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\SAHOO\Desktop\Visual Basic - Exps\22_SECURITY_MANAGEMENT\Database1.mdf;Integrated Security=True")
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtId.Text = "" Or txtName.Text = "" Then
            MsgBox("Enter All Details")
        Else
            name_ = txtName.Text
            id = txtId.Text

            con.Open()
            str = "INSERT INTO SECURITY(securityId, name) VALUES ('" & id & "','" & name_ & "')"
            cmd = New SqlCommand(str, con)
            cmd.ExecuteNonQuery()

            MsgBox("Data Added Successfully")

            txtId.Clear()
            txtName.Clear()

            cmd.Dispose()
            con.Close()

        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If txtId2.Text = "" Or txtLeaves.Text = "" Then
            MsgBox("Enter All Details")
        Else
            leaves = txtLeaves.Text
            id2 = txtId2.Text

            Dim l As Integer

            con.Open()
            str = "UPDATE SECURITY SET leaves = " & leaves & " WHERE securityId = '" & id2 & "'"
            cmd = New SqlCommand(str, con)
            cmd.ExecuteNonQuery()
            MsgBox("Data Updated Successfully")

            txtId2.Clear()
            txtLeaves.Clear()

            cmd.Dispose()
            con.Close()

        End If
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        Form2.Show()
    End Sub
End Class
