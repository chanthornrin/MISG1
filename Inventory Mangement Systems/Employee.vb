Imports System.Data.SqlClient
Public Class Employee
    ' clear all data in textbox
    Sub Clear()
        txtFName.Clear()
        txtLname.Clear()
        txtfullname.Clear()
        txtphone.Clear()
        txtemail.Clear()
        txtAddress.Clear()
        txtemployeeid.Clear()
        txtFName.Focus()
        ComboBoxSex.Text = ""
        CboPosition.Text = ""



    End Sub
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
    ' Insert data to dataGridview
    Sub Loademployee()
        Dim i As Integer = 0
        DGVemployee.Rows.Clear()
        Cn.Open()
        Cm = New SqlCommand("Select * from employee", Cn)
        Dr = Cm.ExecuteReader
        While Dr.Read
            i += 1
            DGVemployee.Rows.Add(i, Dr.Item("id").ToString, Dr.Item("firstName").ToString, Dr.Item("lastName").ToString, Dr.Item("FullName").ToString, Dr.Item("gender").ToString, Dr.Item("dateOfBirth").ToString, Dr.Item("postion").ToString, Dr.Item("phonenumber").ToString, Dr.Item("email").ToString, Dr.Item("address").ToString)
        End While
        Dr.Close()
        Cn.Close()

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            If (MsgBox("Are you sure you want to Insert?", vbYesNo + vbQuestion) = vbYes) Then
                Cn.Open()
                Cm = New SqlCommand(" insert into employee (firstName,lastName,FullName,gender,dateOfBirth,postion,phonenumber,email,address, dateCreated) 
                    values('" & txtFName.Text & "' , '" & txtLname.Text & "', '" & txtfullname.Text & "', '" & ComboBoxSex.Text & "','" & Me.DOB.Text & "',
                    '" & CboPosition.Text & "','" & txtphone.Text & "','" & txtemail.Text & "','" & txtAddress.Text & "','" & Date.Now.ToString() & "')", Cn)
                Cm.ExecuteNonQuery()
                Cn.Close()
                MsgBox("Record has been insert successfully,", vbInformation)
                Loademployee()
                Clear()

            End If
        Catch ex As Exception
            Cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub Employee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Loademployee()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Try
            If (MsgBox("Are you sure you want to update this record?", vbYesNo + vbQuestion) = vbYes) Then
                Cn.Open()
                Cm = New SqlCommand("update employee set firstName ='" & txtFName.Text & "',lastName ='" & txtLname.Text & "',FullName ='" & txtfullname.Text & "',gender ='" & ComboBoxSex.Text & "'
                ,dateOfBirth ='" & Me.DOB.Text & "',postion ='" & CboPosition.Text & "',phonenumber ='" & txtphone.Text & "',email ='" & txtemail.Text & "',address ='" & txtAddress.Text & "',updateDated ='" & Date.Now.ToString() & "' where id like '" & txtemployeeid.Text & "'", Cn)
                Cm.ExecuteNonQuery()
                Cn.Close()
                MsgBox("Record has been successfully updated,", vbInformation)
                Loademployee()
                Clear()
            End If
        Catch ex As Exception
            Cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try



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

    Private Sub Label12_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub DGVemployee_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVemployee.CellContentClick
        Dim colName As String = DGVemployee.Columns(e.ColumnIndex).Name
        If colName = "Column9" Then

            txtemployeeid.Text = DGVemployee(1, e.RowIndex).Value.ToString()
            txtFName.Text = DGVemployee(2, e.RowIndex).Value.ToString()
            txtLname.Text = DGVemployee(3, e.RowIndex).Value.ToString()
            txtfullname.Text = DGVemployee(4, e.RowIndex).Value.ToString()
            ComboBoxSex.Text = DGVemployee(5, e.RowIndex).Value.ToString()
            DOB.Text = DGVemployee(6, e.RowIndex).Value.ToString()
            CboPosition.Text = DGVemployee(7, e.RowIndex).Value.ToString()
            txtphone.Text = DGVemployee(8, e.RowIndex).Value.ToString()
            txtemail.Text = DGVemployee(9, e.RowIndex).Value.ToString()
            txtAddress.Text = DGVemployee(10, e.RowIndex).Value.ToString()

        ElseIf colName = "Column10" Then
            If (MsgBox("Are you sure want to delete this record", vbYesNo + vbQuestion) = vbYes) Then
                Cn.Open()
                Cm = New SqlCommand("delete from employee where id like '" & txtemployeeid.Text & "'", Cn)
                Cm.ExecuteNonQuery()
                Cn.Close()
                MsgBox("Record has been successfully deleted", vbInformation)

                Loademployee()
                Clear()
            End If

        End If
    End Sub
End Class