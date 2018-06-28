﻿Imports QLTVDTO
Imports QLTVBus
Imports Utility
Imports System.Drawing
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

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

    Private Sub btnLuu_Click(sender As Object, e As EventArgs) Handles btnLuu.Click
        Try
            Dim path As String
            Dim myFont As String = "C:\Windows\Fonts\Calibri.ttf"

            'open folder browser
            Using fbd As New FolderBrowserDialog()
                Dim rs As New DialogResult()
                rs = fbd.ShowDialog

                If rs = DialogResult.OK And Not String.IsNullOrWhiteSpace(fbd.SelectedPath) Then
                    path = fbd.SelectedPath.ToString() + "\" + lbMaPTS.Text + ".pdf"
                Else
                    Return
                End If
            End Using

            'dinh dang file
            Dim doc As Document = New iTextSharp.text.Document(PageSize.LETTER, 30, 30, 50, 50)
            Dim wrtr As PdfWriter = PdfWriter.GetInstance(doc, New FileStream(path, FileMode.Create))

            ' mo file
            doc.Open()
            doc.NewPage()

            'font chu, mau sac
            Dim bfR As BaseFont = BaseFont.CreateFont(myFont, BaseFont.IDENTITY_H, BaseFont.EMBEDDED)
            Dim clrBlack As BaseColor = New BaseColor(0, 0, 0)

            Dim fntTitle As iTextSharp.text.Font = New iTextSharp.text.Font(bfR, 16, iTextSharp.text.Font.BOLD, clrBlack)
            Dim fntID As iTextSharp.text.Font = New iTextSharp.text.Font(bfR, 14, iTextSharp.text.Font.NORMAL, New BaseColor(255, 0, 0))
            Dim fntHead As iTextSharp.text.Font = New iTextSharp.text.Font(bfR, 13, iTextSharp.text.Font.BOLD, clrBlack)
            Dim fntHead2 As iTextSharp.text.Font = New iTextSharp.text.Font(bfR, 12, iTextSharp.text.Font.ITALIC, clrBlack)
            Dim fntNormal As iTextSharp.text.Font = New iTextSharp.text.Font(bfR, 16, iTextSharp.text.Font.NORMAL, clrBlack)

            ' title
            Dim title As New Paragraph(New Chunk("PHIẾU TRẢ SÁCH", fntTitle))
            title.Alignment = Element.ALIGN_CENTER
            title.SpacingAfter = 10.0F
            doc.Add(title)

            ' ma phieu tra
            Dim s As String = String.Empty

            s = "Mã phiếu trả: " + lbMaPTS.Text
            Dim mapt As New Paragraph(s, fntID)
            mapt.Alignment = Element.ALIGN_CENTER
            mapt.SpacingAfter = 20.0F
            doc.Add(mapt)

            ' ngay tra
            s = String.Empty
            s = "Ngày trả: " + dtpNgayTra.Value.Day.ToString() + "/" + dtpNgayTra.Value.Month.ToString() + "/" + dtpNgayTra.Value.Year.ToString()
            Dim ngaytra As New Paragraph(s, fntID)
            ngaytra.Alignment = Element.ALIGN_CENTER
            ngaytra.SpacingAfter = 20.0F
            doc.Add(ngaytra)

            ' thong tin doc gia
            s = "Thông tin độc giả:"
            Dim thongtin As New Paragraph(s, fntHead)
            thongtin.Alignment = Element.ALIGN_LEFT
            thongtin.SpacingAfter = 10.0F
            doc.Add(thongtin)

            '' ho ten
            s = "Họ tên: " + lbHoTen.Text
            Dim hoten As New Paragraph(s, fntNormal)
            hoten.Alignment = Element.ALIGN_LEFT
            hoten.SpacingAfter = 5.0F
            doc.Add(hoten)

            '' ngay lap the
            s = "Ngày lập thẻ: " + lbNgayLap.Text
            Dim ngaylap As New Paragraph(s, fntNormal)
            ngaylap.Alignment = Element.ALIGN_LEFT
            ngaylap.SpacingAfter = 5.0F
            doc.Add(ngaylap)

            '' sach dang muon
            s = "Sách đang mượn: "
            Dim sachdangmuon As New Paragraph(s, fntNormal)
            sachdangmuon.Alignment = Element.ALIGN_LEFT
            sachdangmuon.SpacingAfter = 20.0F
            doc.Add(sachdangmuon)

            '' danh sach sach dang muon
            Dim pdftable As New PdfPTable(dgDSSachMuon.Columns.Count)
            pdftable.TotalWidth = 550.0F
            pdftable.LockedWidth = True

            '' set width for columns
            Dim widths(0 To dgDSSachMuon.Columns.Count - 1) As Single
            For i As Integer = 0 To dgDSSachMuon.Columns.Count - 1
                widths(i) = 1.0F * (dgDSSachMuon.Columns(i).Width / pdftable.TotalWidth)
            Next

            pdftable.SetWidths(widths)
            pdftable.HorizontalAlignment = 0

            ' header on datagrid
            Dim pdfcell As PdfPCell = New PdfPCell
            For i As Integer = 0 To dgDSSachMuon.Columns.Count - 1
                pdfcell = New PdfPCell(New Phrase(New Chunk(dgDSSachMuon.Columns(i).HeaderText, fntHead2)))
                pdfcell.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                pdftable.AddCell(pdfcell)
            Next

            ' rows on datagrid
            For i As Integer = 0 To dgDSSachMuon.Rows.Count - 1
                For j As Integer = 0 To dgDSSachMuon.Columns.Count - 1
                    pdfcell = New PdfPCell(New Phrase(dgDSSachMuon(j, i).Value.ToString(), fntNormal))
                    pdftable.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                    pdftable.AddCell(pdfcell)
                Next
            Next
            doc.Add(pdftable)
            '-----------------------------------------------------
            ' thong tin phieu tra
            '' sach tra
            s = "Sách trả: "
            Dim sachmuon As New Paragraph(s, fntHead)
            sachmuon.Alignment = Element.ALIGN_LEFT
            sachmuon.SpacingBefore = 30.0F
            sachmuon.SpacingAfter = 20.0F
            doc.Add(sachmuon)

            '' danh sach sach tra
            Dim pdftable2 As New PdfPTable(dgDanhSachSach.Columns.Count)
            pdftable2.TotalWidth = 550.0F
            pdftable2.LockedWidth = True

            '' set width for columns
            Dim widths2(0 To dgDanhSachSach.Columns.Count - 1) As Single
            For i As Integer = 0 To dgDanhSachSach.Columns.Count - 1
                widths2(i) = 1.0F * (dgDanhSachSach.Columns(i).Width / pdftable2.TotalWidth)
            Next

            pdftable2.SetWidths(widths)
            pdftable2.HorizontalAlignment = 0

            ' header on datagrid
            Dim pdfcell2 As PdfPCell = New PdfPCell
            For i As Integer = 0 To dgDanhSachSach.Columns.Count - 1
                pdfcell2 = New PdfPCell(New Phrase(New Chunk(dgDanhSachSach.Columns(i).HeaderText, fntHead2)))
                pdfcell2.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                pdftable2.AddCell(pdfcell2)
            Next

            ' rows on datagrid
            For i As Integer = 0 To dgDanhSachSach.Rows.Count - 1
                For j As Integer = 0 To dgDanhSachSach.Columns.Count - 1
                    pdfcell2 = New PdfPCell(New Phrase(dgDanhSachSach(j, i).Value.ToString(), fntNormal))
                    pdftable2.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                    pdftable2.AddCell(pdfcell2)
                Next
            Next

            doc.Add(pdftable2)
            '----------------------------------------------
            ' close
            doc.Close()

            MessageBox.Show("Xuất phiếu trả sách " + lbMaPTS.Text + " thành công!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        Catch ex As Exception
            MessageBox.Show("Xuất phiếu trả sách " + lbMaPTS.Text + " thất bại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
