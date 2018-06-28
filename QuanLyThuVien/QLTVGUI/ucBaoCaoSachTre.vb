Imports QLTVDTO
Imports QLTVBus
Imports Utility
Imports System.Drawing

Public Class ucBaoCaoSachTre
    Dim tsBus As New ThamSoBus
    Dim sachBus As New SachBUS
    Dim thoigian As New DateTime
    Dim result As New Result

    Private Sub btnThongKe_Click(sender As Object, e As EventArgs) Handles btnThongKe.Click
        dgThongKe.Rows.Clear()

        Dim thamso As New ThamSoDTO
        result = tsBus.selectALL(thamso)

        If result.FlagResult = False Then
            MessageBox.Show("Lỗi truy xuất dữ liệu. Lập thống kê thất bại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            dtpNgay.Focus()
            Return
        End If

        Dim listten As New List(Of String)
        Dim listngay As New List(Of DateTime)
        thoigian = New DateTime(dtpNgay.Value.Year, dtpNgay.Value.Month, dtpNgay.Value.Day)

        If thoigian > Today Or thoigian.Year < 2000 Then
            MessageBox.Show("Thời gian không hợp lệ!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        result = sachBus.selectSachTre(thoigian, thamso.ThoiGianMuonToiDa, listten, listngay)

        If result.FlagResult = False Then
            MessageBox.Show("Lỗi truy xuất dữ liệu. Lập thống kê thất bại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            dtpNgay.Focus()
            Return
        End If

        showresult(listten, listngay)

    End Sub

    Private Sub showresult(listten As List(Of String), listngay As List(Of DateTime))

        If (listten.Count = 0) Then
            MessageBox.Show("Không có sách trả trễ vào ngày " + thoigian.Day.ToString() + "/" + thoigian.Month.ToString() + "/" + thoigian.Year.ToString() + ".", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        For i As Integer = 0 To listten.Count - 1
            Dim s As String()
            Dim thoigiantre = (thoigian - listngay.ElementAt(i)).TotalDays
            Console.WriteLine(thoigiantre)
            s = New String() {listten.ElementAt(i), listngay.ElementAt(i), thoigiantre.ToString()}
            dgThongKe.Rows.Add(s)
        Next
    End Sub

    Private Sub dgThongKe_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles dgThongKe.RowPostPaint
        Using b As SolidBrush = New SolidBrush(dgThongKe.RowHeadersDefaultCellStyle.ForeColor)
            e.Graphics.DrawString((e.RowIndex + 1).ToString(), dgThongKe.DefaultCellStyle.Font, b, e.RowBounds.Location.X + 12, e.RowBounds.Location.Y + 1)
        End Using
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Dim parent As ucBaoCaoSachTre
        parent = sender.Parent
        Dim grandpar = New ucBaoCao
        grandpar = parent.Parent
        Dim grgrpar = New FlowLayoutPanel
        grgrpar = grandpar.Parent
        grgrpar.Controls.Clear()
        Dim grgrgrpar = New frmHome
        grgrgrpar = grgrpar.Parent
        grgrgrpar.btnLapTheDocGia.selected = False
        Dim ucThuVien As New ucThuVien
        grgrpar.Controls.Add(ucThuVien)
    End Sub

    Private Sub ucBaoCaoSachTre_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpNgay.Value = Today
    End Sub
End Class
