Imports QLTVDTO
Imports QLTVBus
Imports Utility
Imports System.Drawing

Public Class ucNhanTraSach
    Dim dgBus As DocGiaBus
    Dim result As Result
    Dim ptsBus As PhieuTraSachBus
    Dim sachBus As SachBUS
    Dim ctptBus As ChiTietPhieuTraBus

    Private Sub ucNhanTraSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ptsBus = New PhieuTraSachBus()
        dgBus = New DocGiaBus()
        sachBus = New SachBUS()
        ctptBus = New ChiTietPhieuTraBus()

        'Load info doc gia
        Dim listDG As New List(Of DocGiaDTO)
        result = dgBus.selectAll(listDG)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách độc giả không thành công!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        'Lay ma so tu dong
        Dim nextMS = "0"
        result = ptsBus.build_maphieumuon(nextMS)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy tự động mã phiếu trả sách không thành công!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Dispose()
            Return
        End If
        lbMaPTS.Text = nextMS

        dtpNgayTra.Value = DateTime.Now
        clearInfo()
    End Sub

    ' Lay ma doc gia khi nguoi dung nhan enter
    Private Sub tbMaDocGia_KeyDown(sender As Object, e As KeyEventArgs) Handles tbMaDocGia.KeyDown

        If (e.KeyCode = Keys.Enter) Then
            If (tbMaDocGia.Text.Length < 1) Then
                MessageBox.Show("Vui lòng nhập vào mã thẻ độc giả!")
                tbMaDocGia.Focus()
                Return
            End If

            Dim isTrue As Boolean = True
            clearInfo()
            getInfo(tbMaDocGia.Text, isTrue)

            If isTrue = False Then
                MessageBox.Show("Độc giả không tồn tại. Xin vui lòng kiểm tra lại mã độc giả!")
                tbMaDocGia.Focus()
                Return
            End If
        End If
    End Sub

    Private Sub clearInfo()
        lbHoTen.Text = ""
        lbNgayLap.Text = ""
        lbTinhTrang.Text = ""

        For i As Integer = 0 To dgDSSachMuon.Rows.Count - 1
            dgDSSachMuon.Rows.Clear()
        Next

    End Sub

    Private Function getInfo(madocgia As String, ByRef isTrue As Boolean) As Result
        Dim tendocgia As String = String.Empty
        Dim ngaylapthe As New DateTime
        Dim listMaSach As New List(Of String)
        Dim listTenSach As New List(Of String)
        Dim listNgayMuon As New List(Of DateTime)
        Dim listSach As New List(Of SachDTO)

        ' Truy van du lieu tu database
        Dim result As New Result
        result = sachBus.findWithMaDG(madocgia, listMaSach)
        Dim res As New Result
        res = dgBus.findWithMaDG(madocgia, tendocgia, ngaylapthe)

        For i As Integer = 0 To listMaSach.Count - 1
            Dim res1 As New Result
            Dim tensach As String = String.Empty
            Dim ngaymuon As New DateTime
            res1 = sachBus.findDetailWithMaSach(listMaSach(i), tensach, ngaymuon)
            listTenSach.Add(tensach)
            listNgayMuon.Add(ngaymuon)
        Next

        ' Truyen gia tri vao GUI
        lbHoTen.Text = tendocgia
        lbNgayLap.Text = ngaylapthe.Day.ToString() + "/ " + ngaylapthe.Month.ToString() + "/ " + ngaylapthe.Year.ToString()

        If (tinhTrang(DateTime.Now, ngaylapthe) = True) Then
            lbTinhTrang.Text = "Thẻ khả dụng"
        End If
        If (tinhTrang(DateTime.Now, ngaylapthe) = False) Then
            lbTinhTrang.Text = "Thẻ hết hạn"
        End If

        For i As Integer = 0 To listMaSach.Count - 1
            Dim re As New Result
            Dim sach As New SachDTO
            re = sachBus.findTenSachFromMaSach(listMaSach(i), sach)
            listSach.Add(sach)
            Dim str As String()
            str = New String() {"", listMaSach(i), listTenSach(i), listNgayMuon(i), tinhTrangSach(listNgayMuon(i))}
            dgDSSachMuon.Rows.Add(str)
        Next

        cbMaSach.DataSource = New BindingSource(listSach, String.Empty)
        cbMaSach.DisplayMember = "tensach"
        cbMaSach.ValueMember = "masach"

        Return New Result(True)
    End Function

    Private Function tinhTrang(now As DateTime, ngaylap As DateTime) As Boolean
        If (now.Year < ngaylap.Year) Then
            Return False
        End If

        If (now.Year = ngaylap.Year) Then
            Dim time As Integer = now.Month - ngaylap.Month

            If (time > 6) Then
                Return False
            End If

            If (time = 6) Then
                If (now.Day <= ngaylap.Day) Then
                    Return True
                End If

                Return False
            End If

            Return True
        End If

        If (now.Year > ngaylap.Year) Then
            Dim time As Integer = now.Month + 12 - ngaylap.Month
            If (time > 6) Then
                Return False
            End If

            If (time = 6) Then
                If (now.Day <= ngaylap.Day) Then
                    Return True
                End If

                Return False
            End If

            Return True
        End If
    End Function

    Private Function tinhTrangSach(ngaylap As DateTime) As String
        Dim day As TimeSpan = DateTime.Now - ngaylap
        Dim days As Integer = day.TotalDays

        If (days > 4) Then
            Return "Quá hạn"
        End If

        Return "Đang mượn"
    End Function

    Private Sub dgDSSachMuon_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles dgDSSachMuon.RowPostPaint
        Using b As SolidBrush = New SolidBrush(dgDSSachMuon.RowHeadersDefaultCellStyle.ForeColor)
            e.Graphics.DrawString((e.RowIndex + 1).ToString(), dgDSSachMuon.DefaultCellStyle.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + 2)
        End Using
    End Sub

    Private Sub dgDanhSachSach_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles dgDanhSachSach.RowPostPaint
        Using b As SolidBrush = New SolidBrush(dgDanhSachSach.RowHeadersDefaultCellStyle.ForeColor)
            e.Graphics.DrawString((e.RowIndex + 1).ToString(), dgDanhSachSach.DefaultCellStyle.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + 2)
        End Using
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        getDetail(cbMaSach.SelectedValue.ToString())
    End Sub

    Private Function getDetail(maSach As String) As Result
        Dim tensach As String = String.Empty
        Dim listTheloai As New List(Of String)
        Dim listTacGia As New List(Of String)
        Dim sach As New SachDTO
        Dim tlsbus As New TheLoaiSachBUS
        Dim tgsbus As New TacGiaSachBUS

        Dim res As Result
        Dim res1 As Result
        Dim res2 As Result

        res = sachBus.findTenSachFromMaSach(maSach, sach)
        If (res.FlagResult = False) Then
            MessageBox.Show("Nạp tên sách không thành công!")
            Return New Result(False)
        End If
        tensach = sach.TenSach
        res1 = tlsbus.getTenTheLoai_ByMaSach(maSach, listTheloai)
        If res1.FlagResult = False Then
            MessageBox.Show("Nạp danh sách thể loại không thành công!")
            Return New Result(False)
        End If
        res2 = tgsbus.get_TenTacGia_ByMaSach(maSach, listTacGia)
        If res2.FlagResult = False Then
            MessageBox.Show("Nạp danh sách tác giả không thành công!")
            Return New Result(False)
        End If

        Dim theloai As String = String.Empty
        Dim tacgia As String = String.Empty

        For i As Integer = 0 To listTheloai.Count - 1
            theloai = theloai + listTheloai(i)
            If i < listTheloai.Count - 1 Then
                theloai = theloai + ", "
            End If
        Next

        For i As Integer = 0 To listTacGia.Count - 1
            tacgia = tacgia + listTacGia(i)
            If i < listTacGia.Count - 1 Then
                tacgia = tacgia + ", "
            End If
        Next
        dgDanhSachSach.Rows.Add("", maSach, tensach, theloai, tacgia)

        Return New Result(True)
    End Function

    Private Sub btnLuuVaThoat_Click(sender As Object, e As EventArgs) Handles btnLuuVaThoat.Click

        '1. Mapping data from GUI contro + insert to database:
        ' Xoa madocgiamuon cho sach duoc tra
        For i As Integer = 0 To dgDanhSachSach.Rows.Count - 1
            sachBus.traSachBangMaSach(dgDanhSachSach.Rows(i).Cells(1).Value)
        Next

        Dim pts As New PhieuTraSachDTO
        Dim ctpt As New ChiTietPhieuTraDTO()
        Dim res As New Result

        ' Insert Phieu Tra Sach
        pts.MaDocGia = tbMaDocGia.Text
        pts.NgayTra = dtpNgayTra.Value
        pts.MaPhieuTraSach = lbMaPTS.Text
        res = ptsBus.insert(pts)

        ' Insert Chi tiet phieu tra
        Dim nextMaCTPT = "0"
        For i As Integer = 0 To dgDanhSachSach.Rows.Count - 1
            Dim res1 As New Result
            Dim res2 As New Result

            res1 = ctptBus.build_mactphieutra(nextMaCTPT)
            ctpt.MaChiTietPhieuTra = nextMaCTPT
            ctpt.MaPhieuTraSach = lbMaPTS.Text
            ctpt.MaSach = dgDanhSachSach.Rows(i).Cells(1).Value
            res2 = ctptBus.insert(ctpt)
        Next

        '2. clear fpZone + call back ucThuVien
        Dim parent As ucNhanTraSach
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
