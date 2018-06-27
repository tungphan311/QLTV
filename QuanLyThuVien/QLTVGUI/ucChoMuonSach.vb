Imports QLTVDTO
Imports QLTVBus
Imports Utility
Imports System.Drawing
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Public Class ucChoMuonSach
    Private dgBus As DocGiaBus
    Private pmsBUS As PhieuMuonSachBus
    Private ctpmBUS As ChiTietPhieuMuonBus
    Private sachBUS As SachBUS

    Private Sub ucChoMuonSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgBus = New DocGiaBus()
        pmsBUS = New PhieuMuonSachBus()
        ctpmBUS = New ChiTietPhieuMuonBus()
        sachBUS = New SachBUS()
        Dim result As Result

        'Load info doc gia
        Dim listDG = New List(Of DocGiaDTO)
        result = dgBus.selectAll(listDG)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách độc giả không thành công!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        'Lay ma so tu dong
        Dim nextMS = "0"
        result = pmsBUS.build_maphieumuon(nextMS)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy tự động mã phiếu mượn sách không thành công!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Dispose()
            Return
        End If
        lbMaPMS.Text = nextMS

        dtpNgayMuon.Value = DateTime.Now
    End Sub

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

    Private Function getInfo(madocgia As String, ByRef isTrue As Boolean) As Result
        Dim tendocgia As String = String.Empty
        Dim ngaylapthe As New DateTime
        Dim listMaSach As New List(Of String)
        Dim listTenSach As New List(Of String)
        Dim listNgayMuon As New List(Of DateTime)

        Dim result As New Result
        result = dgBus.findWithMaDG(madocgia, tendocgia, ngaylapthe, listMaSach, listTenSach, listNgayMuon)

        If (result.FlagResult = False) Then
            MessageBox.Show("Nạp thông tin độc giả không thành công")
            Return New Result(False)
        End If

        If (tendocgia.Length < 1) Then
            isTrue = False
        End If

        lbHoTen.Text = tendocgia
        lbNgayLap.Text = ngaylapthe.Day.ToString() + "/ " + ngaylapthe.Month.ToString() + "/ " + ngaylapthe.Year.ToString()

        If (tinhTrang(DateTime.Now, ngaylapthe) = True) Then
            lbTinhTrang.Text = "Thẻ khả dụng"
        End If
        If (tinhTrang(DateTime.Now, ngaylapthe) = False) Then
            lbTinhTrang.Text = "Thẻ hết hạn"
        End If

        For i As Integer = 0 To listMaSach.Count - 1
            Dim str As String()
            str = New String() {"", listMaSach(i), listTenSach(i), listNgayMuon(i), tinhTrangSach(listNgayMuon(i))}
            dgDSSachMuon.Rows.Add(str)
        Next


        Return New Result(True)
    End Function

    Private Sub dgDSSachMuon_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles dgDSSachMuon.RowPostPaint
        Using b As SolidBrush = New SolidBrush(dgDSSachMuon.RowHeadersDefaultCellStyle.ForeColor)
            e.Graphics.DrawString((e.RowIndex + 1).ToString(), dgDSSachMuon.DefaultCellStyle.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + 2)
        End Using
    End Sub

    Private Sub clearInfo()
        lbHoTen.Text = ""
        lbNgayLap.Text = ""
        lbTinhTrang.Text = ""

        For i As Integer = 0 To dgDSSachMuon.Rows.Count - 1
            dgDSSachMuon.Rows.Clear()
        Next

    End Sub

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

    Public Function getSachInfo(ByRef maSach As String) As Result
        Dim tenSach As String = String.Empty
        Dim listTG As New List(Of String)
        Dim listTL As New List(Of String)

        Dim result1 As New Result
        Dim result2 As New Result

        result1 = sachBUS.findWithMaSachTacGia(maSach, tenSach, listTG)
        result2 = sachBUS.findWithMaSachTheLoai(maSach, listTL)

        If (result1.FlagResult = False) Then
            MessageBox.Show("Nạp thông tin độc giả không thành công")
            Return New Result(False)
        End If
        If (result2.FlagResult = False) Then
            MessageBox.Show("Nạp thông tin độc giả không thành công")
            Return New Result(False)
        End If

        Dim tacgia As String = String.Empty
        Dim theloai As String = String.Empty

        For i As Integer = 0 To listTG.Count - 2
            tacgia = tacgia + listTG(i) + ", "
        Next
        tacgia = tacgia + listTG(listTG.Count - 1)

        For i As Integer = 0 To listTL.Count - 2
            theloai = theloai + listTL(i) + ", "
        Next
        theloai = theloai + listTL(listTL.Count - 1)


        Dim str As String()
        str = New String() {"", maSach, tenSach, theloai, tacgia}
        dgDanhSachSach.Rows.Add(str)

        Return New Result(True)
    End Function

    Private Sub btnThemMaSach_Click(sender As Object, e As EventArgs) Handles btnThemMaSach.Click

        If (tbMaSach.Text.Length < 1) Then
            MessageBox.Show("Vui lòng nhập vào mã sách!")
            tbMaSach.Focus()
            Return
        End If

        getSachInfo(tbMaSach.Text)

    End Sub

    Private Sub dgDanhSachSach_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles dgDanhSachSach.RowPostPaint
        Using b As SolidBrush = New SolidBrush(dgDanhSachSach.RowHeadersDefaultCellStyle.ForeColor)
            e.Graphics.DrawString((e.RowIndex + 1).ToString(), dgDanhSachSach.DefaultCellStyle.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + 2)
        End Using
    End Sub

    Private Sub btnLuuVaThoat_Click(sender As Object, e As EventArgs) Handles btnLuuVaThoat.Click
        If (dgDSSachMuon.Rows.Count + dgDanhSachSach.Rows.Count > 5) Then
            MessageBox.Show("Quý khách không được mướn quá 5 cuốn sách trong 4 ngày!")
            Return
        End If

        Dim pms As PhieuMuonSachDTO
        pms = New PhieuMuonSachDTO()

        Dim ctpm As ChiTietPhieuMuonDTO
        ctpm = New ChiTietPhieuMuonDTO()

        'Lay ma so tu dong
        Dim nextMaCTPM = "0"
        Dim result As Result

        '1. mapping data from gui + insert to db
        pms.MaDocGia = tbMaDocGia.Text
        pms.MaPhieuMuonSach = lbMaPMS.Text
        pms.NgayMuon = New DateTime(dtpNgayMuon.Value.Year, dtpNgayMuon.Value.Month, dtpNgayMuon.Value.Day)
        result = pmsBUS.insert(pms)

        For i As Integer = 0 To dgDanhSachSach.Rows.Count - 1
            Dim res As Result
            Dim result1 As Result
            res = ctpmBUS.build_mactpm(nextMaCTPM)
            ctpm.MaChiTietPhieuMuon = nextMaCTPM
            ctpm.MaPhieuMuonSach = lbMaPMS.Text
            ctpm.MaSach = dgDanhSachSach.Rows(i).Cells(1).Value
            result1 = ctpmBUS.insert(ctpm)
        Next

        '2. clear fpZone + call back ucThuVien
        Dim parent As ucChoMuonSach
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

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Dim parent As ucChoMuonSach
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

    Private Sub btnXuatPhieuMuon_Click(sender As Object, e As EventArgs) Handles btnXuatPhieuMuon.Click
        Dim doc As New Document()
        Dim path As String = Environment.CurrentDirectory
        PdfWriter.GetInstance(doc, New FileStream(path + "/" + lbMaPMS.Text + ".pdf", FileMode.Create))
        doc.Open()
        doc.Add(New Paragraph("Mã độc giả: " + tbMaDocGia.Text))
        doc.Close()

    End Sub

End Class
