Imports System.Data.SqlClient

Public Class Form1
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter

    Dim dt As DataTable
    Dim str As String

    Dim name_ As String
    Dim id As String
    Dim phone As String
    Dim address As String
    Dim aadhar As String
    Dim date_ As String

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If txtId.Text = "" Or txtName.Text = "" Or txtPhone.Text = "" Or txtAadhar.Text = "" Or txtAddress.Text = "" Or txtDate.Text = "" Then
            MsgBox("Enter All Details")
        Else
            name_ = txtName.Text
            id = txtId.Text

            con.Open()
            str = "INSERT INTO CUSTOMER VALUES ('" & id & "','" & name_ & "','" & txtPhone.Text & "','" _
                    & txtAddress.Text & "','" & txtAadhar.Text & "','" & txtDate.Text & "')"
            cmd = New SqlCommand(str, con)
            cmd.ExecuteNonQuery()

            MsgBox("Data Added Successfully")

            txtId.Clear()
            txtName.Clear()
            txtAadhar.Clear()
            txtAddress.Clear()
            txtDate.Clear()
            txtPhone.Clear()

            cmd.Dispose()
            con.Close()

        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\SAHOO\Desktop\Visual Basic - Exps\24_GASAGENCY\Database1.mdf;Integrated Security=True")
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If txtCustId.Text = "" Or txtNewAdd.Text = "" Then
            MsgBox("Enter All Details")
        Else

            con.Open()
            str = "UPDATE CUSTOMER SET address = '" & txtNewAdd.Text & "' WHERE Id = '" & txtCustId.Text & "'"
            cmd = New SqlCommand(str, con)
            cmd.ExecuteNonQuery()
            MsgBox("Data Updated Successfully")

            txtCustId.Clear()
            txtNewAdd.Clear()

            cmd.Dispose()
            con.Close()

        End If
    End Sub
End Class
