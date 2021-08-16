Imports System.Data.SqlClient
Public Class Customer
    Sub LoadRecord()
        Dim i As Integer = 0
        DataGridView1.Rows.Clear()
        Cn.Open()
        Cm = New SqlCommand("Select *from customer ", Cn)
        Dr = Cm.ExecuteReader
        While Dr.Read
            i += 1
            DataGridView1.Rows.Add(Dr(0).ToString, Dr(1).ToString, Dr(2).ToString,
                                   Dr(5).ToString, Dr(3).ToString, Dr(4).ToString, Dr(6).ToString, Dr(7).ToString)
        End While
        Dr.Close()
        Cn.Close()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If (MsgBox("Are you sure you want to Insert?", vbYesNo + vbQuestion) = vbYes) Then
                Cn.Open()


                Cm = New SqlCommand(" insert into customer (firstName, lastName, email, phone,gender, address,dateCreated) values('" & txtCFName.Text & "' , '" & txtCLName.Text & "',
                                                           '" & txtCusEmail.Text & "','" & txtCPhone.Text & "','" & txtGender.Text & "','" & txtCAddress.Text & "','" & Date.Now & "')", Cn)
                Cm.ExecuteNonQuery()

                Cn.Close()
                MsgBox("Record has been insert successfully,", vbInformation)
                LoadRecord()
                'clear()

            End If
        Catch ex As Exception
            Cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadRecord()
    End Sub
End Class