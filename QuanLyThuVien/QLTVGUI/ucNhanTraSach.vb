Imports QLTVDTO
Imports QLTVBus
Imports Utility
Imports System.Drawing
Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf

Public Class ucNhanTraSach
    Dim dgBus As DocGiaBus
    Dim result As Result
    Dim ptsBus As PhieuTraSachBus

    Private Sub ucNhanTraSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ptsBus = New PhieuTraSachBus()
        'Load info doc gia
        'Dim listDG = New List(Of DocGiaDTO)
        'result = dgBus.selectAll(listDG)
        'If (result.FlagResult = False) Then
        '    MessageBox.Show("Lấy danh sách độc giả không thành công!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    System.Console.WriteLine(result.SystemMessage)
        '    Return
        'End If

        'Lay ma so tu dong
        'Dim nextMS = "0"
        'result = ptsBus.build_maphieumuon(nextMS)
        'If (result.FlagResult = False) Then
        '    MessageBox.Show("Lấy tự động mã phiếu mượn sách không thành công!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    System.Console.WriteLine(result.SystemMessage)
        '    Me.Dispose()
        '    Return
        'End If
        'lbMaPhieuTra.Text = nextMS

        dtpNgayTra.Value = DateTime.Now

    End Sub

    Private Sub btnXuatPhieuTra_Click(sender As Object, e As EventArgs) Handles btnXuatPhieuTra.Click
        Try
            Dim path As String
            Dim myFont As String = "C:\Windows\Fonts\Calibri.ttf"

            ' open folder browser
            Using fbd As New FolderBrowserDialog()
                Dim rs As New DialogResult()
                rs = fbd.ShowDialog

                If rs = DialogResult.OK And Not String.IsNullOrWhiteSpace(fbd.SelectedPath) Then
                    path = fbd.SelectedPath.ToString() + "\" + lbMaPTS.Text + ".pdf"
                Else
                    Return
                End If
            End Using


            ' dinh dang file
            Dim doc As Document = New iTextSharp.text.Document(PageSize.LETTER, 30, 30, 50, 50)
            Dim wrtr As PdfWriter = PdfWriter.GetInstance(doc, New FileStream(path, FileMode.Create))

            ' mo file
            doc.Open()
            doc.NewPage()

            ' font chu, mau sac
            Dim bfR As BaseFont = BaseFont.CreateFont(myFont, BaseFont.IDENTITY_H, BaseFont.EMBEDDED)
            Dim clrBlack As BaseColor = New BaseColor(0, 0, 0)

            Dim fntTitle As iTextSharp.text.Font = New iTextSharp.text.Font(bfR, 16, iTextSharp.text.Font.BOLD, clrBlack)
            Dim fntID As iTextSharp.text.Font = New iTextSharp.text.Font(bfR, 14, iTextSharp.text.Font.NORMAL, New BaseColor(255, 0, 0))
            Dim fntHead As iTextSharp.text.Font = New iTextSharp.text.Font(bfR, 13, iTextSharp.text.Font.BOLD, clrBlack)
            Dim fntHead2 As iTextSharp.text.Font = New iTextSharp.text.Font(bfR, 12, iTextSharp.text.Font.ITALIC, clrBlack)
            Dim fntNormal As iTextSharp.text.Font = New iTextSharp.text.Font(bfR, 12, iTextSharp.text.Font.NORMAL, clrBlack)

            ' title
            Dim title As New Paragraph(New Chunk("PHIẾU TRẢ SÁCH", fntTitle))
            title.Alignment = Element.ALIGN_CENTER
            title.SpacingAfter = 50.0F
            doc.Add(title)

            ' ma phieu muon
            Dim s As String = Nothing

            s = "Mã phiếu trả: " + lbMaPTS.Text
            Dim mapt As New Paragraph(s, fntID)
            mapt.Alignment = Element.ALIGN_CENTER
            mapt.SpacingAfter = 10.0F
            doc.Add(mapt)

            ' ngay muon
            s = Nothing
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

            '''''

            ' header on datagrid
            Dim pdfcell As PdfPCell = New PdfPCell
            For i As Integer = 0 To dgDSSachMuon.Columns.Count - 1
                pdfcell = New PdfPCell(New Phrase(New Chunk(dgDSSachMuon.Columns(i).HeaderText, fntHead2)))
                pdfcell.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                pdftable.AddCell(pdfcell)
            Next


            ''''
            ' rows on datagrid
            For i As Integer = 0 To dgDSSachMuon.Rows.Count - 1
                For j As Integer = 0 To dgDSSachMuon.Columns.Count - 1
                    pdfcell = New PdfPCell(New Phrase(dgDSSachMuon(j, i).Value.ToString(), fntNormal))
                    pdftable.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                    pdftable.AddCell(pdfcell)
                Next
            Next

            ''''
            doc.Add(pdftable)

            ''''
            ' thong tin phieu tra
            '' sach tra
            s = "Sách trả: "
            Dim sachtra As New Paragraph(s, fntHead)
            sachtra.Alignment = Element.ALIGN_LEFT
            sachtra.SpacingBefore = 30.0F
            sachtra.SpacingAfter = 20.0F
            doc.Add(sachtra)

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

            '''''

            ' header on datagrid
            Dim pdfcell2 As PdfPCell = New PdfPCell
            For i As Integer = 0 To dgDanhSachSach.Columns.Count - 1
                pdfcell2 = New PdfPCell(New Phrase(New Chunk(dgDanhSachSach.Columns(i).HeaderText, fntHead2)))
                pdfcell2.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                pdftable2.AddCell(pdfcell2)
            Next


            ''''
            ' rows on datagrid
            For i As Integer = 0 To dgDanhSachSach.Rows.Count - 1
                For j As Integer = 0 To dgDanhSachSach.Columns.Count - 1
                    pdfcell2 = New PdfPCell(New Phrase(dgDanhSachSach(j, i).Value.ToString(), fntNormal))
                    pdftable2.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                    pdftable2.AddCell(pdfcell2)
                Next
            Next

            ''''
            doc.Add(pdftable2)



            ' close
            doc.Close()

            MessageBox.Show("Xuất phiếu trả sách " + lbMaPTS.Text + " thành công!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return

        Catch ex As Exception
            MessageBox.Show("Xuất phiếu trả sách " + lbMaPTS.Text + " thất bại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try
    End Sub
End Class
