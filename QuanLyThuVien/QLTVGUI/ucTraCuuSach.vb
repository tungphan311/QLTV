Imports QLTVDTO
Imports QLTVBus
Imports Utility
Imports System.Drawing

Public Class ucTraCuuSach
    Dim tlbus As New TheLoaiBUS
    Dim dstheloai As New List(Of TheLoaiDTO)
    Dim tgbus As New TacGiaBUS
    Dim dstacgia As New List(Of TacGiaDTO)
    Dim ttbus As New TrangThaiBUS
    Dim dstrangthai As New List(Of TrangThaiDTO)
    Dim sachbus As New SachBUS
    Dim tlsbus As New TheLoaiSachBUS
    Dim tgsbus As New TacGiaSachBUS
    Dim result As New Result

    Private Sub ucTraCuuSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Lay danh sach the loai, tac gia, trang thai, nha xuat ban
        '' The loai
        result = tlbus.selectAll(dstheloai)
        If result.FlagResult = False Then
            MessageBox.Show("Lấy danh sách thể loại không thành công!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If
        dstheloai.ElementAt(0).TenTheLoai = "(Tất cả)"
        cbTheLoai.DataSource = New BindingSource(dstheloai, String.Empty)
        cbTheLoai.DisplayMember = "tentheloai"
        cbTheLoai.ValueMember = "matheloai"

        '' Tac gia
        result = tgbus.selectAll(dstacgia)
        If result.FlagResult = False Then
            MessageBox.Show("Lấy danh sách tác giả không thành công!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If
        dstacgia.ElementAt(0).TenTacGia = "(Tất cả)"
        cbTacGia.DataSource = New BindingSource(dstacgia, String.Empty)
        cbTacGia.DisplayMember = "tentacgia"
        cbTacGia.ValueMember = "matacgia"

        '' Tinh trang
        result = ttbus.selectAll(dstrangthai)
        If result.FlagResult = False Then
            MessageBox.Show("Lấy danh sách trạng thái không thành công!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If
        dstrangthai.ElementAt(0).TenTrangThai = "(Tất cả)"
        cbTinhTrang.DataSource = New BindingSource(dstrangthai, String.Empty)
        cbTinhTrang.DisplayMember = "tentrangthai"
        cbTinhTrang.ValueMember = "matrangthai"
    End Sub

    Private Sub btnTraCuu_Click(sender As Object, e As EventArgs) Handles btnTraCuu.Click
        dgDanhSachSach.Rows.Clear()

        Dim ketqua As New List(Of String)
        Dim timkiem As New List(Of String)


        ' lay tat ca cac ma sach
        result = sachbus.selectAll_MaSach("%", ketqua)
        If result.FlagResult = False Then
            MessageBox.Show("Lấy danh sách sách không thành công!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        ' tim kiem theo ma sach
        If tbMaSach.Text.Length > 0 Then
            result = sachbus.selectAll_MaSach("%" + tbMaSach.Text + "%", timkiem)
            If result.FlagResult = False Then
                MessageBox.Show("Tìm kiếm theo mã sách không thành công!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                findCommon(ketqua, timkiem) ' giao 2 list
            End If
        End If

        ' tim kiem theo ten sach
        If tbTenSach.Text.Length > 0 Then
            result = sachbus.selectAll_TenSach("%" + tbTenSach.Text + "%", timkiem)
            If result.FlagResult = False Then
                MessageBox.Show("Tìm kiếm theo tên sách không thành công!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                findCommon(ketqua, timkiem)
            End If
        End If

        ' tim kiem theo the loai
        If cbTheLoai.SelectedIndex > 0 Then
            result = tlsbus.selectALL_MaTheLoai("%" + cbTheLoai.SelectedValue.ToString() + "%", timkiem)
            If result.FlagResult = False Then
                MessageBox.Show("Tìm kiếm theo thể loại không thành công!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                findCommon(ketqua, timkiem)
            End If
        End If

        ' tim kiem theo tac gia
        If cbTacGia.SelectedIndex > 0 Then
            result = tgsbus.selectALL_MaTacGia("%" + cbTacGia.SelectedValue.ToString() + "%", timkiem)
            If result.FlagResult = False Then
                MessageBox.Show("Tìm kiếm theo tác giả không thành công!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                findCommon(ketqua, timkiem)
            End If
        End If

        ' tim kiem theo trang thai
        If cbTinhTrang.SelectedIndex > 0 Then
            result = sachbus.selectAll_TrangThai("%" + cbTinhTrang.SelectedValue.ToString() + "%", timkiem)
            If result.FlagResult = False Then
                MessageBox.Show("Tìm kiếm theo trạng thái không thành công!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                findCommon(ketqua, timkiem)
            End If
        End If

        If (ketqua.Count > 0) Then
            If ketqua.ElementAt(0) = "S0000000" Then
                ketqua.RemoveAt(0)
            End If
            If ketqua.Count > 0 Then
                showResult(ketqua)
            End If
        Else
            MessageBox.Show("Không tìm thấy kết quả nào thoả mãn!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub findCommon(ketqua As List(Of String), timkiem As List(Of String))
        For i As Integer = ketqua.Count - 1 To 0 Step -1
            If timkiem.Contains(ketqua(i)) = False Then
                ketqua.RemoveAt(i)
            End If
        Next
    End Sub

    Private Sub showResult(ketqua As List(Of String))
        For i As Integer = 0 To ketqua.Count - 1
            Dim masach = ketqua.ElementAt(i)

            Dim tensach = ""
            result = sachbus.get_TenSach_ByMaSach(masach, tensach)
            If result.FlagResult = False Then
                MessageBox.Show("Tìm kiếm thông tin tên của mã sách " + masach + " không thành công!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            Dim trangthai = ""
            result = sachbus.get_TrangThai_ByMaSach(masach, trangthai)
            If result.FlagResult = False Then
                MessageBox.Show("Tìm kiếm thông tin trạng thái của mã sách " + masach + " không thành công!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            Dim listTheLoai As New List(Of String)
            Dim theloai = ""
            result = tlsbus.getTenTheLoai_ByMaSach(masach, listTheLoai)
            If result.FlagResult = False Then
                MessageBox.Show("Tìm kiếm thông tin thể loại của mã sách " + masach + " không thành công!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                For j As Integer = 0 To listTheLoai.Count - 1
                    theloai = theloai + listTheLoai.ElementAt(j)
                    If j < listTheLoai.Count - 1 Then
                        theloai = theloai + ", "
                    End If
                Next
            End If

            Dim listTacGia As New List(Of String)
            Dim tacgia = ""
            result = tgsbus.get_TenTacGia_ByMaSach(masach, listTacGia)
            If result.FlagResult = False Then
                MessageBox.Show("Tìm kiếm thông tin tác giả của mã sách " + masach + " không thành công!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                For j As Integer = 0 To listTacGia.Count - 1
                    tacgia = tacgia + listTacGia.ElementAt(j)
                    If j < listTacGia.Count - 1 Then
                        tacgia = tacgia + ", "
                    End If
                Next
            End If

            Dim s As String()
            s = New String() {masach, tensach, theloai, tacgia, trangthai}
            dgDanhSachSach.Rows.Add(s)
        Next

    End Sub

    Private Sub dgDanhSachSach_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles dgDanhSachSach.RowPostPaint
        Using b As SolidBrush = New SolidBrush(dgDanhSachSach.RowHeadersDefaultCellStyle.ForeColor)
            e.Graphics.DrawString((e.RowIndex + 1).ToString(), dgDanhSachSach.DefaultCellStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 2)
        End Using
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Dim parent As ucTraCuuSach
        parent = sender.Parent
        Dim grandpar = New FlowLayoutPanel
        grandpar = parent.Parent
        grandpar.Controls.Clear()
        Dim grgrpar = New frmHome
        grgrpar = grandpar.Parent
        grgrpar.btnLapTheDocGia.selected = False
        Dim ucThuVien As New ucThuVien
        grandpar.Controls.Add(ucThuVien)
    End Sub
End Class
