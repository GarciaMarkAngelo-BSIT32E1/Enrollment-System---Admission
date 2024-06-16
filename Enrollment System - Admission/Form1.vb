Imports System.Data.OleDb

Public Class Form1
    Private Sub btnViewRegStudents_Click(sender As Object, e As EventArgs) Handles btnViewRegStudents.Click
        Me.Hide()
        frmViewRegStudents.Show()
        Call conn()
        da = New OleDbDataAdapter("Select * From tblApplicants", cn)
        dset = New DataSet
        da.Fill(dset, "tblApplicants")
        frmViewRegStudents.DGVApplicants.DataSource = dset.Tables("tblApplicants").DefaultView

    End Sub

    Private Sub btnStudentRegistration_Click(sender As Object, e As EventArgs) Handles btnStudentRegistration.Click
        Me.Hide()
        frmRegistration.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        frmLogin.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblDateTime.Text = Now.ToLongDateString & " " & Now.ToLongTimeString
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDateTime.Text = Now.ToLongDateString & " " & Now.ToLongTimeString
    End Sub
End Class
