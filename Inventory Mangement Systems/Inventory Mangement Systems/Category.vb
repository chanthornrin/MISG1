Imports System.Data.SqlClient

Public Class Category

    Sub Clear()
        txtcatbrand.Clear()
        txtcatId.Clear()
        txtcatname.Clear()
        txtcatId.Focus()

    End Sub
    Sub LoadRecord()
        Dim i As Integer = 0
        DataGridViewCategory.Rows.Clear()
        Cn.Open()
        Cm = New SqlCommand("Select * from category", Cn)
        Dr = Cm.ExecuteReader
        While Dr.Read
            i += 1
            DataGridViewCategory.Rows.Add(Dr.Item("id").ToString, i, Dr.Item("name").ToString, Dr.Item("description").ToString, Dr.Item("date").ToString)
        End While
        Dr.Close()
        Cn.Close()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If (MsgBox("Are you sure you want to Insert?", vbYesNo + vbQuestion) = vbYes) Then
                Cn.Open()
                Cm = New SqlCommand(" insert into category (name,description,date) values('" & txtcatname.Text & "','" & txtcatbrand.Text & "','" & Date.Now() & "')", Cn)
                Cm.ExecuteNonQuery()
                Cn.Close()
                MsgBox("Record has been insert successfully,", vbInformation)
                LoadRecord()
                Clear()
            End If
        Catch ex As Exception
            Cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Category_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridViewCategory.DefaultCellStyle.Font = New Font("Arial", 10)
    End Sub
End Class
