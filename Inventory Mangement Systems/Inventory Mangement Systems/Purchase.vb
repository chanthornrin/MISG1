Imports System.Data.SqlClient

Public Class Purchase
    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub
    Sub createPurches(purchaseId As Int32, supplierId As Int32, emp As Int32, shipping As Int32, total As Double)
        Cn.Open()
        Cm = New SqlCommand(" insert into Tbl_Purches (Pur_ID, Sup_ID, Emp_ID, Ship_ID, Pur_Date, Total) values('" & purchaseId & "',
                                    '" & supplierId & "','" & emp & "','" & shipping & "','" & Date.Now() & "','" & total & "')", Cn)
        Cm.ExecuteNonQuery()

        Cn.Close()
    End Sub

    Sub LoadRecord()
        Dim i As Integer = 0
        DataGridView1.Rows.Clear()
        Cn.Open()
        Cm = New SqlCommand("select Tbl_Pur_Detail.Pur_ID,Tbl_Pur_Detail.Pro_ID,Tbl_Pur_Detail.Qty,Tbl_Pur_Detail.Price,Tbl_Pur_Detail.Total,
                             Tbl_Purches.Sup_ID,Tbl_Purches.Ship_ID,Tbl_Purches.Emp_ID 
                             from Tbl_Pur_Detail INNER JOIN Tbl_Purches ON Tbl_Pur_Detail.Pur_ID=Tbl_Purches.Pur_ID ", Cn)
        Dr = Cm.ExecuteReader
        While Dr.Read
            i += 1
            DataGridView1.Rows.Add(i, Dr(0).ToString, Dr(1).ToString, Dr(2).ToString,
                                   Dr(3).ToString, Dr(4).ToString, Dr(5).ToString, Dr(6).ToString, Dr(7).ToString)
        End While
        Dr.Close()
        Cn.Close()
    End Sub
    Sub createPuchaseDetail(purchaseId As Int32, productId As String, qty As Int32, price As Int32)
        Dim proQty As Integer = Convert.ToInt16(qty)
        Dim proPrice As Integer = Convert.ToInt16(price)
        Cn.Open()
        Cm = New SqlCommand(" insert into Tbl_Pur_Detail (Pur_ID, Pro_ID,Qty,Price,Total) values('" & purchaseId & "',
                                    '" & Convert.ToInt16(productId) & "','" & proQty & "','" & proPrice & "','" & (proPrice * proQty) & "')", Cn)
        Cm.ExecuteNonQuery()

        Cn.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim purchaseId As Integer = Convert.ToInt32(txtpur.Text)
        Dim supplier As Integer = Convert.ToInt32(txtsuppier.Text)
        Dim proId = txtProductId.Text
        Dim qty As Integer = Convert.ToInt32(txtqty.Text)
        Dim price As Integer = Convert.ToInt32(txtprice.Text)
        Dim emp As Integer = Convert.ToInt32(cbemployee.Text)
        Dim total As Double = Convert.ToDouble(txtto.Text)

        Try
            If (MsgBox("Are you sure you want to Insert?", vbYesNo + vbQuestion) = vbYes) Then
                Cn.Open()
                Cm = New SqlCommand("Select * from Tbl_Purches where Pur_ID= '" & purchaseId & "'", Cn)
                Dr = Cm.ExecuteReader
                Dim puchase As String = Nothing
                While (Dr.Read)
                    puchase = Dr("Pur_ID").ToString
                    cbemployee.Text = puchase
                End While
                Dr.Close()
                Cn.Close()

                If (puchase = Nothing) Then
                    createPurches(purchaseId, supplier, emp, supplier, total)
                    createPuchaseDetail(purchaseId, proId, qty, price)
                    LoadRecord()
                End If

                createPuchaseDetail(purchaseId, proId, qty, price)
                LoadRecord()

                MsgBox("Record has been insert successfully,", vbInformation)


                ' clear()



            End If
        Catch ex As Exception
            Cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub txtTotal_Click(sender As Object, e As EventArgs) Handles txtTotal.Click

    End Sub

    Private Sub Purchase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadRecord()
    End Sub
End Class