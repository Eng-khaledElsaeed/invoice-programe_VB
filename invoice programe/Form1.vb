Public Class Form1
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        System.Diagnostics.Process.Start("https://ar.wikipedia.org/wiki/%D9%86%D8%A7%D9%81%D8%B0%D8%A9")
    End Sub

    Private Sub datetxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles datetxt.KeyPress, txttotal.KeyPress, txtprice.KeyPress
        e.Handled = True
    End Sub

    Private Sub datetxt_MouseDown(sender As Object, e As MouseEventArgs) Handles datetxt.MouseDown, txttotal.MouseDown, txtprice.MouseDown, txtquantity.MouseDown
        If e.Button = MouseButtons.Right Then
            sender.ContextMenu = New ContextMenu()
        End If
    End Sub
    Sub showprice()
        txtprice.Text = cbxitems.SelectedValue.ToString()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        datetxt.Text = Now.ToString("d") & "  /  " & Now.ToString("T")
        Dim itemsdata As New Dictionary(Of Integer, String)
        itemsdata.Add(100, "item1")
        itemsdata.Add(200, "item2")
        itemsdata.Add(300, "item3")
        itemsdata.Add(400, "item4")
        itemsdata.Add(500, "item5")
        itemsdata.Add(600, "item6")
        itemsdata.Add(700, "item7")
        itemsdata.Add(800, "item8")
        cbxitems.DataSource = New BindingSource(itemsdata, Nothing)
        cbxitems.DisplayMember = "value"
        cbxitems.ValueMember = "key"

        txtcustname.Focus()
        txtcustname.Select()
        txtcustname.SelectAll()
    End Sub

    Private Sub txtcustname_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcustname.KeyDown
        If e.KeyCode = Keys.Enter Then
            cbxitems.Focus()
        End If
    End Sub


    Private Sub txtproductnam_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            txtquantity.Focus()
            txtquantity.SelectAll()
        End If
    End Sub
    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        If cbxitems.SelectedIndex > -1 Then
            Dim item As String = cbxitems.Text
            Dim qty As Integer = txtquantity.Text
            Dim price As Integer = txtprice.Text
            Dim SubTotal As Integer = qty * price
            dgvinvoice.Rows.Add(item, qty, price, SubTotal)
            txttotal.Text = Val(txttotal.Text) + SubTotal
        Else
            MsgBox("sorry this item not found , select from our items!")
        End If

        If txtquantity.Text.Trim = 0 Or txtquantity.Text.Trim = "" Then
            txtquantity.Text = 1

        End If
    End Sub
    Private Sub txtquantity_KeyDown(sender As Object, e As KeyEventArgs) Handles txtquantity.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnadd.PerformClick()
            cbxitems.Focus()
        End If
    End Sub
    Private Sub txtquantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtquantity.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub


    Private Sub cbxitems_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxitems.SelectedIndexChanged
        showprice()
    End Sub

    Private Sub btnprint_Click(sender As Object, e As EventArgs) Handles btnprint.Click
        PrintPreviewDialog1.Size = Me.Size
        If PrintPreviewDialog1.ShowDialog = DialogResult.OK Then
            PrintDocument1.Print()
        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim margin As Single = 40
        Dim currentTop As Single = 0
        Dim fnt As New Font("consolas", 35, FontStyle.Bold)
        Dim strNo As String = "#NO " & invoiceNum.Text
        Dim strDate As String = "date : " & datetxt.Text
        Dim strName As String = "Customer Name: " & txtcustname.Text

        Dim fontsizeNo As SizeF = e.Graphics.MeasureString(strNo, fnt)
        Dim fontsizeDate As SizeF = e.Graphics.MeasureString(strDate, fnt)
        Dim fontsizeName As SizeF = e.Graphics.MeasureString(strName, fnt)


        e.Graphics.DrawString(strNo, fnt, Brushes.Red, (e.PageBounds.Width - fontsizeNo.Width) / 2, 0)
        e.Graphics.DrawString(strDate, fnt, Brushes.Blue, 0, 40)
        e.Graphics.DrawString(strName, fnt, Brushes.Red, 0, 100)
    End Sub
End Class
