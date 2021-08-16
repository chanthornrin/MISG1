Imports System.Data.SqlClient

Public Class Product
    Sub loandCategory()
        cbcategory.Items.Clear()
        Cn.Open()
        Cm = New SqlCommand("Select * from category", Cn)
        Dr = Cm.ExecuteReader
        While (Dr.Read)
            cbcategory.Items.Add(Dr("name").ToString)
        End While
        Dr.Close()
        Cn.Close()

    End Sub

    Sub loandEmployee()
        cbEmployee.Items.Clear()
        Cn.Open()
        Cm = New SqlCommand("Select * from employee", Cn)
        Dr = Cm.ExecuteReader
        While (Dr.Read)
            cbEmployee.Items.Add(Dr("firstName").ToString)
        End While
        Dr.Close()
        Cn.Close()

    End Sub


    Sub clear()
        txtname.Text = ""
        txtPrice.Text = ""
        txtQty.Text = ""
        txtSalePrice.Text = ""
        cbcategory.Text = ""
    End Sub

    Sub LoadRecord()
        Dim i As Integer = 0
        DataGridView1.Rows.Clear()
        Cn.Open()
        Cm = New SqlCommand("Select * from product ", Cn)
        Dr = Cm.ExecuteReader
        While Dr.Read
            i += 1
            DataGridView1.Rows.Add(i, Dr(0).ToString, Dr(1).ToString, Dr(3).ToString, Dr(4).ToString, Dr(5).ToString,
                                   Dr(6).ToString, Dr(9).ToString)
        End While
        Dr.Close()
        Cn.Close()
    End Sub

    Sub addProductToStock(productId As Integer, qty As Integer, price As Double, empId As Integer)
        Cn.Open()
        Cm = New SqlCommand("insert into stock(productId,stockQty,price,dateCreated,employeeId) values ('" & productId & "','" & qty & "',
                                                                                '" & price & "','" & Date.Now() & "','" & empId & "')", Cn)
        Dr = Cm.ExecuteReader
        Dr.Close()
        Cn.Close()

    End Sub

    Sub findProductBynName(productName As String, qty As Integer, price As Double, empId As Integer)
        Cn.Open()
        Cm = New SqlCommand("Select * from product where name= '" & productName & "'", Cn)
        Dr = Cm.ExecuteReader
        Dim productId As Integer
        While (Dr.Read)
            productId = Convert.ToInt16(Dr("proId").ToString)
        End While
        Dr.Close()
        Cn.Close()
        addProductToStock(productId, qty, price, empId)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If (MsgBox("Are you sure you want to Insert?", vbYesNo + vbQuestion) = vbYes) Then
                Cn.Open()
                Cm = New SqlCommand("Select * from category where name= '" & cbcategory.Text & "'", Cn)
                Dr = Cm.ExecuteReader
                Dim categoryId As String = ""
                While (Dr.Read)
                    categoryId = Dr("id").ToString
                End While
                Dr.Close()

                Cm = New SqlCommand("Select * from employee where firstName= '" & cbEmployee.Text & "'", Cn)
                Dr = Cm.ExecuteReader
                Dim empId As Integer
                While (Dr.Read)
                    empId = Convert.ToInt16(Dr("id").ToString)
                End While
                Dr.Close()

                Cm = New SqlCommand(" insert into product (name,qty, costPrice, salePrice,dateCreate,employeeId) values('" & txtname.Text & "','" & txtQty.Text & "','" & txtPrice.Text & "','" & txtSalePrice.Text & "',
                                                                                                                         '" & Date.Now() & "','" & empId & "')", Cn)
                Cm.ExecuteNonQuery()
                Cn.Close()
                MsgBox("Record has been insert successfully,", vbInformation)

                findProductBynName(txtname.Text, Convert.ToInt16(txtQty.Text), Convert.ToInt16(txtPrice.Text), empId)
                LoadRecord()
                clear()
            End If
        Catch ex As Exception
            Cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try


    End Sub

    Private Sub Product_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadRecord()
        loandCategory()
        loandEmployee()
        DataGridView1.DefaultCellStyle.Font = New Font("Arial", 10)
    End Sub

    Private Sub Topproduct_Paint(sender As Object, e As PaintEventArgs) Handles Topproduct.Paint

    End Sub
End Class