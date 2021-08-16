Imports System.Data.SqlClient
Public Class Employee
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
    Sub LoadRecord()
        Dim i As Integer = 0
        DataGridView1.Rows.Clear()
        Cn.Open()
        Cm = New SqlCommand("Select * from employee ", Cn)
        Dr = Cm.ExecuteReader
        While Dr.Read
            i += 1
            DataGridView1.Rows.Add(Dr(0).ToString, Dr(1).ToString, Dr(2).ToString, Dr(3).ToString, Dr(4).ToString, Dr(5).ToString,
                                   Dr(6).ToString, Dr(7).ToString, Dr(8).ToString, Dr(9).ToString)
        End While
        Dr.Close()
        Cn.Close()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            If (MsgBox("Are you sure you want to Insert?", vbYesNo + vbQuestion) = vbYes) Then
                Cn.Open()
                Cm = New SqlCommand(" insert into employee (firstName, lastName,gender,dateOfBirth, numberPhone, address,position, dateCreated) values('" & txtFName.Text & "' , '" & txtLname.Text & "',
                                                           '" & ComboBoxSex.Text & "','" & Me.DateTimePicker1.Value & "','" & txtphone.Text & "','" & txtAddress.Text & "','" & ComboBoxPosition.Text & "','" & Date.Now & "')", Cn)
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtphone_TextChanged(sender As Object, e As EventArgs) Handles txtphone.TextChanged

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs)

    End Sub
End Class