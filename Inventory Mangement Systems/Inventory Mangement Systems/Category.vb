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
        Cm = New SqlCommand("Select * from Category", Cn)
        Dr = Cm.ExecuteReader
        While Dr.Read
            i += 1
            DataGridViewCategory.Rows.Add(Dr.Item("Cat_ID").ToString, i, Dr.Item("Cat_Name").ToString, Dr.Item("Brand").ToString)
        End While
        Dr.Close()
        Cn.Close()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If (MsgBox("Are you sure you want to Insert?", vbYesNo + vbQuestion) = vbYes) Then
                Cn.Open()
                Cm = New SqlCommand(" insert into Category (Cat_Name,Brand) values('" & txtcatname.Text & "','" & txtcatbrand.Text & "')", Cn)
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
End Class
