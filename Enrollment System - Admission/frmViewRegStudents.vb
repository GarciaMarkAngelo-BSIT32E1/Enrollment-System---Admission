Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class frmViewRegStudents
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub reload()
        Call conn()
        da = New OleDbDataAdapter("Select * From tblApplicants", cn)
        dset = New DataSet
        da.Fill(dset, "tblApplicants")
        DGVApplicants.DataSource = dset.Tables("tblApplicants").DefaultView
    End Sub


    Private Sub frmViewRegStudents_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call reload()
    End Sub

    Private Sub txtSearch_OnValueChanged(sender As Object, e As EventArgs) Handles txtSearch.OnValueChanged
        SearchDatabase(txtSearch.Text)
    End Sub

    Private Sub SearchDatabase(searchText As String)
        Try
            conn() ' Establish the connection
            sql = "SELECT * FROM tblApplicants WHERE " &
                  "ApplicantID LIKE @searchText OR " &
                  "LName LIKE @searchText OR " &
                  "Fname LIKE @searchText OR " &
                  "MI LIKE @searchText OR " &
                  "Address LIKE @searchText OR " &
                  "Brgy LIKE @searchText OR " &
                  "City LIKE @searchText OR " &
                  "ContactNo LIKE @searchText OR " &
                  "Bdate LIKE @searchText OR " &
                  "Age LIKE @searchText OR " &
                  "GuardianName LIKE @searchText"

            cmd = New OleDbCommand(sql, cn)
            cmd.Parameters.AddWithValue("@searchText", "%" & searchText & "%")

            da = New OleDbDataAdapter(cmd)
            dset = New DataSet()
            da.Fill(dset, "SearchResults")

            DGVApplicants.DataSource = dset.Tables("SearchResults")
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            cn.Close()
        End Try
    End Sub

End Class