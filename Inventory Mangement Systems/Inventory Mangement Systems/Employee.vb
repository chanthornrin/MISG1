Imports System.Data.SqlClient
Public Class Employee
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
    Sub LoadRecord()
        Dim i As Integer = 0
        DataGridView1.Rows.Clear()
        Cn.Open()
        Cm = New SqlCommand("Select * from Tbl_Employee ", Cn)
        Dr = Cm.ExecuteReader
        While Dr.Read
            i += 1
            DataGridView1.Rows.Add(i, Dr(0).ToString, Dr(1).ToString, Dr(2).ToString,
                                   Dr(3).ToString, Dr(4).ToString, Dr(5).ToString, Dr(6).ToString, Dr(7).ToString)
        End While
        Dr.Close()
        Cn.Close()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If (MsgBox("Are you sure you want to Insert?", vbYesNo + vbQuestion) = vbYes) Then
                Cn.Open()


                Cm = New SqlCommand(" insert into Tbl_Employee (Employee_ID, First_name, Last_name,Gender, Email, Phone, Postion, Address) values('" & txtEmpID.Text & "',
                                    '" & txtFName.Text & "' , '" & txtLname.Text & "','" & txtGender.Text & "','" & txtEmail.Text & "','" & txtphone.Text & "','" & txtPos.Text & "','" & txtAddress.Text & "')", Cn)
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

    Private Sub Employee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadRecord()
    End Sub
End Class