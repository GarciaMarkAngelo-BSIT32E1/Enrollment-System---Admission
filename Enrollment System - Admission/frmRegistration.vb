Imports System.Collections.Specialized.BitVector32
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Net
Imports System.Windows.Forms.AxHost
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip

Public Class frmRegistration
    Private Sub frmRegistration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call conn()
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        If txtApplicantID.Text = Nothing Or txtFirstName.Text = Nothing Or txtGuardianName.Text = Nothing Or txtAddress.Text = Nothing Or
        txtBarangay.Text = Nothing Or txtCity.Text = Nothing Or txtContact.Text = Nothing Or txtAge.Text = Nothing Or
        txtGuardianCN.Text = Nothing Or txtGuardianName.Text = Nothing Then
            MsgBox("credentials are missing")

        ElseIf Not cbBirthCert.Checked And Not cbGoodMoral.Checked And Not cbMedCert.Checked And Not cbPicture.Checked And Not cbTranscriptRec.Checked Then

            MsgBox("Must at least have one(1) requirement")
        Else


            uniquechecker()
            InsertData()
            MsgBox("Information Inserted", vbInformation)
        End If
    End Sub

    Private Sub InsertData()
        conn()
        sql = "INSERT INTO tblApplicants ([ApplicantID],[LName],[Fname],[MI],[Address], [Brgy], [City], [ContactNo], [Bdate], [Age] ,[GuardianName], [GContactNo], [GoodMoral], [MedCert], [BirthCert], [TranscriptOfRec], [2x2Pic], [Status]) " &
          "VALUES (@ApplicantID, @LN, @FN, @MI, @Address, @brgy, @city, @CN, @bdate, @Age, @GName, @GCN, @GM, @MC, @BC, @ToR, @2x2, @status)"

        cmd = New OleDbCommand(sql, cn)

        With cmd
            .Parameters.AddWithValue("@ApplicantID", txtApplicantID.Text)
            .Parameters.AddWithValue("@LN", txtLastName.Text)
            .Parameters.AddWithValue("@FN", txtFirstName.Text)
            .Parameters.AddWithValue("@MI", txtMI.Text)
            .Parameters.AddWithValue("@Address", txtAddress.Text)
            .Parameters.AddWithValue("@brgy", txtBarangay.Text)
            .Parameters.AddWithValue("@city", txtCity.Text)
            .Parameters.AddWithValue("@CN", txtContact.Text)
            .Parameters.AddWithValue("@bdate", txtBirthdate.Value.ToShortDateString)
            .Parameters.AddWithValue("@Age", txtAge.Text)
            .Parameters.AddWithValue("@GName", txtGuardianName.Text)
            .Parameters.AddWithValue("@GCN", txtGuardianCN.Text)
            .Parameters.AddWithValue("@GM", If(cbGoodMoral.Checked, "True", "False"))
            .Parameters.AddWithValue("@MC", If(cbMedCert.Checked, "True", "False"))
            .Parameters.AddWithValue("@BC", If(cbBirthCert.Checked, "True", "False"))
            .Parameters.AddWithValue("@ToR", If(cbTranscriptRec.Checked, "True", "False"))
            .Parameters.AddWithValue("@2x2", If(cbPicture.Checked, "True", "False"))
            .Parameters.AddWithValue("@status", "NotEnrolled")


            .ExecuteNonQuery()

        End With

    End Sub
    Private Sub uniquechecker()
        Try
            conn()
            Dim isUnique As Boolean = False

            While Not isUnique
                sql = "SELECT COUNT(*) FROM tblApplicants WHERE [ApplicantID] = @ApplicantID"
                cmd = New OleDbCommand(sql, cn)
                With cmd
                    .Parameters.AddWithValue("@ApplicantID", txtApplicantID.Text)
                End With

                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                If count = 0 Then
                    isUnique = True
                Else
                    txtApplicantID.Text = GenerateRandomApplicantID()
                End If
            End While

        Catch ex As Exception
            MessageBox.Show("Insert A new ApplicantID" & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try
    End Sub

    Private Function GenerateRandomApplicantID() As String

        Dim random As New Random()
        Return "A" & random.Next(10000, 99999).ToString()
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Show()
    End Sub
End Class