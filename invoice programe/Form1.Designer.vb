<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.invoiceNum = New System.Windows.Forms.TextBox()
        Me.txtcustname = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtprice = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtquantity = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dgvinvoice = New System.Windows.Forms.DataGridView()
        Me.colitem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colqty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colprice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colsubtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.datetxt = New System.Windows.Forms.TextBox()
        Me.btnprint = New System.Windows.Forms.Button()
        Me.cbxitems = New System.Windows.Forms.ComboBox()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        CType(Me.dgvinvoice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Blue
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1227, 89)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "شاشة الفاتوره الرئيسيه"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Silver
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(16, 12)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 62)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "نافذه"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 102)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 39)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "رقم الفاتوره:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'invoiceNum
        '
        Me.invoiceNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.invoiceNum.ForeColor = System.Drawing.Color.Red
        Me.invoiceNum.Location = New System.Drawing.Point(121, 103)
        Me.invoiceNum.Margin = New System.Windows.Forms.Padding(4)
        Me.invoiceNum.Multiline = True
        Me.invoiceNum.Name = "invoiceNum"
        Me.invoiceNum.Size = New System.Drawing.Size(478, 39)
        Me.invoiceNum.TabIndex = 3
        Me.invoiceNum.Text = "000001"
        Me.invoiceNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtcustname
        '
        Me.txtcustname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcustname.Location = New System.Drawing.Point(430, 161)
        Me.txtcustname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtcustname.Multiline = True
        Me.txtcustname.Name = "txtcustname"
        Me.txtcustname.Size = New System.Drawing.Size(478, 38)
        Me.txtcustname.TabIndex = 5
        Me.txtcustname.Text = "غير معروف"
        Me.txtcustname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(334, 161)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 38)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "اسم العميل:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(619, 103)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 39)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "التاريخ:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(117, 203)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(959, 20)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "_________________________________________________________________________________" &
    "______________"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(4, 236)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(117, 38)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "اسم الصنف:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtprice
        '
        Me.txtprice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtprice.Location = New System.Drawing.Point(114, 282)
        Me.txtprice.Margin = New System.Windows.Forms.Padding(4)
        Me.txtprice.Multiline = True
        Me.txtprice.Name = "txtprice"
        Me.txtprice.Size = New System.Drawing.Size(261, 38)
        Me.txtprice.TabIndex = 12
        Me.txtprice.Text = "0"
        Me.txtprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(18, 282)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(98, 38)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "السعر:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtquantity
        '
        Me.txtquantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtquantity.Location = New System.Drawing.Point(483, 282)
        Me.txtquantity.Margin = New System.Windows.Forms.Padding(4)
        Me.txtquantity.Multiline = True
        Me.txtquantity.Name = "txtquantity"
        Me.txtquantity.Size = New System.Drawing.Size(273, 38)
        Me.txtquantity.TabIndex = 15
        Me.txtquantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(391, 282)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(98, 38)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "الكميه:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgvinvoice
        '
        Me.dgvinvoice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvinvoice.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvinvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvinvoice.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colitem, Me.colqty, Me.colprice, Me.colsubtotal})
        Me.dgvinvoice.Location = New System.Drawing.Point(18, 327)
        Me.dgvinvoice.Name = "dgvinvoice"
        Me.dgvinvoice.RowHeadersWidth = 51
        Me.dgvinvoice.RowTemplate.Height = 24
        Me.dgvinvoice.Size = New System.Drawing.Size(1183, 384)
        Me.dgvinvoice.TabIndex = 16
        '
        'colitem
        '
        Me.colitem.HeaderText = "الصنف"
        Me.colitem.MinimumWidth = 6
        Me.colitem.Name = "colitem"
        '
        'colqty
        '
        Me.colqty.HeaderText = "الكميه"
        Me.colqty.MinimumWidth = 6
        Me.colqty.Name = "colqty"
        '
        'colprice
        '
        Me.colprice.HeaderText = "سعر الوحده"
        Me.colprice.MinimumWidth = 6
        Me.colprice.Name = "colprice"
        '
        'colsubtotal
        '
        Me.colsubtotal.HeaderText = "الاجمالى الفرعى"
        Me.colsubtotal.MinimumWidth = 6
        Me.colsubtotal.Name = "colsubtotal"
        '
        'txttotal
        '
        Me.txttotal.BackColor = System.Drawing.Color.Blue
        Me.txttotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttotal.ForeColor = System.Drawing.Color.Yellow
        Me.txttotal.Location = New System.Drawing.Point(764, 282)
        Me.txttotal.Margin = New System.Windows.Forms.Padding(4)
        Me.txttotal.Multiline = True
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(186, 38)
        Me.txttotal.TabIndex = 18
        Me.txttotal.Text = "0"
        Me.txttotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(792, 240)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(139, 38)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "↑الاجمالى الكلى↓"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnadd
        '
        Me.btnadd.BackColor = System.Drawing.Color.MediumBlue
        Me.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnadd.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnadd.Location = New System.Drawing.Point(971, 253)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(119, 57)
        Me.btnadd.TabIndex = 19
        Me.btnadd.Text = "اضافه"
        Me.btnadd.UseVisualStyleBackColor = False
        '
        'datetxt
        '
        Me.datetxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datetxt.ForeColor = System.Drawing.Color.Navy
        Me.datetxt.Location = New System.Drawing.Point(698, 102)
        Me.datetxt.Margin = New System.Windows.Forms.Padding(4)
        Me.datetxt.Multiline = True
        Me.datetxt.Name = "datetxt"
        Me.datetxt.Size = New System.Drawing.Size(478, 39)
        Me.datetxt.TabIndex = 7
        Me.datetxt.Text = "2022/03/01"
        Me.datetxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnprint
        '
        Me.btnprint.BackColor = System.Drawing.Color.MediumBlue
        Me.btnprint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnprint.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnprint.Location = New System.Drawing.Point(1096, 253)
        Me.btnprint.Name = "btnprint"
        Me.btnprint.Size = New System.Drawing.Size(119, 57)
        Me.btnprint.TabIndex = 20
        Me.btnprint.Text = "طباعه"
        Me.btnprint.UseVisualStyleBackColor = False
        '
        'cbxitems
        '
        Me.cbxitems.FormattingEnabled = True
        Me.cbxitems.Location = New System.Drawing.Point(114, 240)
        Me.cbxitems.Name = "cbxitems"
        Me.cbxitems.Size = New System.Drawing.Size(674, 30)
        Me.cbxitems.TabIndex = 21
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1227, 723)
        Me.Controls.Add(Me.cbxitems)
        Me.Controls.Add(Me.btnprint)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dgvinvoice)
        Me.Controls.Add(Me.txtquantity)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtprice)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.datetxt)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtcustname)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.invoiceNum)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "شاشة الفاتوره - خالد السعيد عبد الفتاح"
        CType(Me.dgvinvoice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents invoiceNum As TextBox
    Friend WithEvents txtcustname As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtprice As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtquantity As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents dgvinvoice As DataGridView
    Friend WithEvents colitem As DataGridViewTextBoxColumn
    Friend WithEvents colqty As DataGridViewTextBoxColumn
    Friend WithEvents colprice As DataGridViewTextBoxColumn
    Friend WithEvents colsubtotal As DataGridViewTextBoxColumn
    Friend WithEvents txttotal As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnadd As Button
    Friend WithEvents datetxt As TextBox
    Friend WithEvents btnprint As Button
    Friend WithEvents cbxitems As ComboBox
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
End Class
