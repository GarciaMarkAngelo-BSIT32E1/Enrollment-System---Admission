Imports System.Data.OleDb

Public Class frmLogin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Call Checker()
    End Sub

    Private Sub Checker() 'asks if disabled
        conn()
        sql = "Select * FROM tblUsers WHERE [Username] = [@Username] AND [AccountStatus] = 'Inactive'"
        cmd = New OleDbCommand(sql, cn)
        With cmd
            .Parameters.AddWithValue(("@Username"), txtUsername.Text)
            .ExecuteNonQuery()
        End With


        dr = cmd.ExecuteReader

        If dr.Read = True Then  'if disabled
            MsgBox("Account is inactive, please contact your IT Department")

            'sets strikes to 0
            sql = "Update tblUsers SET [Attempts] = 0  WHERE [Username] = [@Username]"
            cmd = New OleDbCommand(sql, cn)
            With cmd
                .Parameters.AddWithValue(("[Username]"), txtUsername.Text)
                .ExecuteNonQuery()
            End With
            Call conn()

        Else 'if not disabled

            Try



                Call conn()
                sql = "Select * FROM tblUsers WHERE [Username] = [@Username] AND [Password] = [@Password] AND [AccountStatus] = 'Active' AND [Role] = 'Admin'"
                cmd = New OleDbCommand(sql, cn)
                With cmd
                    .Parameters.AddWithValue(("[Username]"), txtUsername.Text)
                    .Parameters.AddWithValue(("[Password]"), txtPassword.Text)
                    .ExecuteNonQuery()
                End With

                dr = cmd.ExecuteReader
                If dr.Read = True Then  'if row was found
                    Me.Hide()
                    MsgBox("Login Success")
                    sql = "Update tblUsers SET [Attempts] = 0  WHERE [Username] = [@Username]"
                    cmd = New OleDbCommand(sql, cn)
                    With cmd
                        .Parameters.AddWithValue(("[Username]"), txtUsername.Text)
                        .ExecuteNonQuery()
                    End With
                    Call conn()
                    ' FrmAdmin.Show()

                Else

                    sql = "Select * FROM tblUsers WHERE [Username] = [@Username] AND [Password] = [@Password] AND [AccountStatus] = 'Active' AND [Role] = 'Admission'"
                    cmd = New OleDbCommand(sql, cn)
                    With cmd
                        .Parameters.AddWithValue(("[Username]"), txtUsername.Text)
                        .Parameters.AddWithValue(("[Password]"), txtPassword.Text)
                        .ExecuteNonQuery()
                    End With

                    dr = cmd.ExecuteReader
                    If dr.Read = True Then  'if row was found

                        Me.Hide()
                        'MsgBox("Login Success")
                        Form1.Show()
                        sql = "Update tblUsers SET [Attempts] = 0  WHERE [Username] = [@Username]"
                        cmd = New OleDbCommand(sql, cn)
                        With cmd
                            .Parameters.AddWithValue(("[Username]"), txtUsername.Text)
                            .ExecuteNonQuery()
                        End With
                        Call conn()

                    Else

                        sql = "Select * FROM tblUsers WHERE [Username] = [@Username] AND [Password] = [@Password] AND [AccountStatus] = 'Active' AND [Role] = 'Registrar'"
                        cmd = New OleDbCommand(sql, cn)
                        With cmd
                            .Parameters.AddWithValue(("[Username]"), txtUsername.Text)
                            .Parameters.AddWithValue(("[Password]"), txtPassword.Text)
                            .ExecuteNonQuery()
                        End With

                        dr = cmd.ExecuteReader
                        If dr.Read = True Then  'if row was found

                            Me.Hide()
                            MsgBox("Login Success")
                            ' Show Form here .Show()


                        Else
                            sql = "Select * FROM tblUsers WHERE [Username] = [@Username] AND [Password] = [@Password] AND [AccountStatus] = 'Active' AND [Role] = 'Finance'"
                            cmd = New OleDbCommand(sql, cn)
                            With cmd
                                .Parameters.AddWithValue(("[Username]"), txtUsername.Text)
                                .Parameters.AddWithValue(("[Password]"), txtPassword.Text)
                                .ExecuteNonQuery()
                            End With

                            dr = cmd.ExecuteReader
                            If dr.Read = True Then  'if row was found

                                Me.Hide()
                                MsgBox("Login Success")
                                'Show Form here .Show()
                            Else
                                sql = "Select * FROM tblUsers WHERE [Username] = [@Username] AND [Password] = [@Password] AND [AccountStatus] = 'Active' AND [Role] = 'Assessment'"
                                cmd = New OleDbCommand(sql, cn)
                                With cmd
                                    .Parameters.AddWithValue(("[Username]"), txtUsername.Text)
                                    .Parameters.AddWithValue(("[Password]"), txtPassword.Text)
                                    .ExecuteNonQuery()
                                End With

                                dr = cmd.ExecuteReader
                                If dr.Read = True Then  'if row was found

                                    Me.Hide()
                                    MsgBox("Login Success")
                                    'Show Form here .Show()

                                Else
                                    MsgBox("Incorrect Credentials")
                                    sql = "Update tblUsers SET [Attempts] = Attempts + 1  WHERE [Username] = [@Username]"
                                    cmd = New OleDbCommand(sql, cn)
                                    With cmd
                                        .Parameters.AddWithValue(("[Username]"), txtUsername.Text)
                                        .ExecuteNonQuery()
                                    End With
                                    Call conn()
                                End If
                            End If
                        End If
                    End If
                End If

            Catch ex As Exception

                MsgBox("Process was not Accepted")
            End Try

        End If
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.lblDateTime.Text = Now.ToLongDateString & " " & Now.ToLongTimeString
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class