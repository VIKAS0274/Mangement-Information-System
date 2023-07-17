Imports System.Data
Imports System.Data.SqlClient

Public Class Form1

    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter

    Dim ds As DataSet
    Dim str As String

    Dim name_ As String
    Dim regNo As String
    Dim date_ As String
    Dim feedback As String
    Dim year As String

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        name_ = txtName.Text
        regNo = txtRegNo.Text
        date_ = txtDate.Text
        year = lstBoxYear.SelectedItem


        If chkAvg.Checked = True Then
            feedback = "medium"
        ElseIf chkBad.Checked = True Then
            feedback = "bad"
        ElseIf chkGood.Checked = True Then
            feedback = "good"
        End If

        str = "INSERT INTO FEEDBACK VALUES ( '" & regNo & "', '" & name_ & "', '" & year & "', '" & feedback & "',' " & date_ & "' )"

        cmd = New SqlCommand(str, con)
        cmd.ExecuteNonQuery()

        MsgBox("Data Added Successfully")

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\SAHOO\Desktop\Visual Basic - Exps\17_FeedbackForm\Database1.mdf;Integrated Security=True")
        con.Open()

        MsgBox("Connection Successful ")

    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        Form2.Show()
    End Sub
End Class
