

Public Class FrmFoodStore
    Dim products As New List(Of Product)()
    Dim trollys As New List(Of Trolly)()
    Public Class Product
        Public Property Nama As String
        Public Property Harga As Decimal
    End Class

    Public Class Trolly
        Public Property Nama As String
        Public Property Qnty As Decimal
        Public Property Harga As Decimal
        Public Property Total As Decimal
    End Class

    Private Sub FrmFoodStore_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddProduct()
        ShowProduct()
        lblBonus.Visible = False
    End Sub

    Sub AddProduct()
        products.Add(New Product() With {.Nama = "Burger", .Harga = 40000})
        products.Add(New Product() With {.Nama = "Pizza", .Harga = 80000})
        products.Add(New Product() With {.Nama = "Boba", .Harga = 20000})
        products.Add(New Product() With {.Nama = "Kentang Goreng", .Harga = 25000})
        products.Add(New Product() With {.Nama = "Cappucino Dingin", .Harga = 15000})
        products.Add(New Product() With {.Nama = "Cappucino Panas", .Harga = 15000})
        products.Add(New Product() With {.Nama = "Black Coffe", .Harga = 10000})
    End Sub

    Sub AddTrollyList(nama As String, qnty As Decimal, harga As Decimal)
        Dim adaProduk As Boolean = trollys.Any(Function(trollys) trollys.Nama = nama)

        If adaProduk Then
            trollys.ForEach(Sub(product)
                                If product.Nama = nama Then
                                    product.Qnty = product.Qnty + 1
                                    product.Total = product.Qnty * product.Harga
                                End If
                            End Sub)
        Else
            trollys.Add(New Trolly() With {.Nama = nama, .Qnty = qnty, .Harga = harga, .Total = qnty * harga})
        End If

    End Sub

    Sub ShowTrolly()
        Dim total As Decimal = 0
        dgvTrolly.Rows.Clear()
        For Each trolly As Trolly In trollys
            dgvTrolly.Rows.Add(trolly.Nama, trolly.Qnty, trolly.Harga.ToString("C"), trolly.Total.ToString("C"))
            total += trolly.Total
        Next
        lblTotal.Text = "TOTAL : " + total.ToString("C")
        If total > 450000 AndAlso total <= 1000000 Then
            Timer1.Start()
            lblBonus.Text = "Bonus Member Card"
        ElseIf total < 450000 AndAlso total >= 350000 Then
            Timer1.Start()
            lblBonus.Text = "Bonus Lunc Box"
        ElseIf total < 350000 AndAlso total >= 250000 Then
            Timer1.Start()
            lblBonus.Text = "Bonus Tumbler"
        ElseIf total < 250000 AndAlso total >= 150000 Then
            Timer1.Start()
            lblBonus.Text = "Bonus Masker dan Hand Sanitizer"
        End If
    End Sub
    Sub ShowProduct()
        Dim buttonColumn As New DataGridViewButtonColumn()
        buttonColumn.Name = "Action"
        buttonColumn.HeaderText = "Action"
        buttonColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        buttonColumn.Text = "Add To Trolly"
        buttonColumn.UseColumnTextForButtonValue = True
        dgvDaftarProduct.Columns.Add(buttonColumn)
        For Each product As Product In products
            dgvDaftarProduct.Rows.Add(product.Nama, product.Harga.ToString("C"))
        Next
    End Sub

    Private Sub dgvDaftarProduct_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs)
        dgvDaftarProduct.Rows(e.RowIndex).HeaderCell.Value = CStr(e.RowIndex + 1)
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs)
        trollys.Clear()
        ShowTrolly()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblBonus.Visible = Not lblBonus.Visible
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs)
        Dim subtotal As String = lblTotal.Text.ToString.Replace("Rp", "").Replace(".", "").Replace("TOTAL :", "")
        Dim total As Decimal = Convert.ToDecimal(subtotal)
        If total <= 0 Then
            MessageBox.Show("Total Belanjaan Harus Lebih Besar Dari 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If txtBayar.Text = "" Then
                MessageBox.Show("Total Bayar Tidak Boleh Kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf txtBayar.Text < total Then
                MessageBox.Show("Total Bayar Tidak Cukup", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("Transaksi Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If


    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs)
        Dim result As DialogResult = MessageBox.Show("Apakah Anda ingin menutup aplikasi?", "Konfirmasi", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            End
        ElseIf result = DialogResult.No Then
            e = CancelButton
        End If
    End Sub

    Private Sub dgvDaftarProduct_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        If e.ColumnIndex = dgvDaftarProduct.Columns("Action").Index AndAlso e.RowIndex >= 0 Then
            Dim namaProduk As String = dgvDaftarProduct.Rows(e.RowIndex).Cells("Product_Name").Value.ToString()
            Dim hargaProduk As Decimal = Decimal.Parse(dgvDaftarProduct.Rows(e.RowIndex).Cells("Harga").Value.ToString().Replace("Rp", "").Replace(".", ""))

            AddTrollyList(namaProduk, 1, hargaProduk)
            ShowTrolly()
        End If
    End Sub

    Private Sub dgvTrolly_CellFormatting_1(sender As Object, e As DataGridViewCellFormattingEventArgs)
        dgvTrolly.Rows(e.RowIndex).HeaderCell.Value = CStr(e.RowIndex + 1)
    End Sub
End Class
