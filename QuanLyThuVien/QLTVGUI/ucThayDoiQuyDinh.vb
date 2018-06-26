Imports QLTVDTO
Imports QLTVBus
Imports Utility

Public Class ucThayDoiQuyDinh
    Dim tsBus As New ThamSoBus()
    Dim result As New Result()

    Private Sub ucThayDoiQuyDinh_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim thamso As New ThamSoDTO
        result = tsBus.selectALL(thamso)

        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách quy định không thành công!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        nudTuoiToiThieu.Value = thamso.TuoiToiThieu
        nudTuoiToiDa.Value = thamso.TuoiToiDa
        nudThoiHanThe.Value = thamso.HanSuDung
        nudKhoangCachNam.Value = thamso.NamXuatBanToiThieu
        nudSachToiDa.Value = thamso.SoLuongSachMuonToiDa
        nudThoiGianToiDa.Value = thamso.ThoiGianMuonToiDa

    End Sub

    Private Sub nudTuoiToiThieu_Enter(sender As Object, e As EventArgs) Handles nudTuoiToiThieu.Enter
        Label2.ForeColor = Drawing.Color.Red
        btnLuuThayDoi.Enabled = True
    End Sub

    Private Sub nudTuoiToiDa_Enter(sender As Object, e As EventArgs) Handles nudTuoiToiDa.Enter
        Label3.ForeColor = Drawing.Color.Red
        btnLuuThayDoi.Enabled = True

    End Sub

    Private Sub nudThoiHanThe_Enter(sender As Object, e As EventArgs) Handles nudThoiHanThe.Enter
        Label4.ForeColor = Drawing.Color.Red
        btnLuuThayDoi.Enabled = True
    End Sub

    Private Sub nudKhoangCachNam_Enter(sender As Object, e As EventArgs) Handles nudKhoangCachNam.Enter
        Label5.ForeColor = Drawing.Color.Red
        btnLuuThayDoi.Enabled = True
    End Sub

    Private Sub dgDSTheLoai_Enter(sender As Object, e As EventArgs) Handles dgDSTheLoai.Enter
        Label6.ForeColor = Drawing.Color.Red
        btnLuuThayDoi.Enabled = True
    End Sub

    Private Sub nudSachToiDa_Enter(sender As Object, e As EventArgs) Handles nudSachToiDa.Enter
        Label7.ForeColor = Drawing.Color.Red
        btnLuuThayDoi.Enabled = True
    End Sub

    Private Sub nudThoiGianToiDa_Enter(sender As Object, e As EventArgs) Handles nudThoiGianToiDa.Enter
        Label8.ForeColor = Drawing.Color.Red
        btnLuuThayDoi.Enabled = True
    End Sub

    Private Sub btnLuuThayDoi_Click(sender As Object, e As EventArgs) Handles btnLuuThayDoi.Click
        Dim thamso As New ThamSoDTO

        thamso.TuoiToiThieu = Convert.ToInt32(nudTuoiToiThieu.Value)
        thamso.TuoiToiDa = Convert.ToInt32(nudTuoiToiDa.Value)
        thamso.HanSuDung = Convert.ToInt32(nudThoiHanThe.Value)
        thamso.NamXuatBanToiThieu = Convert.ToInt32(nudKhoangCachNam.Value)
        thamso.SoLuongSachMuonToiDa = Convert.ToInt32(nudSachToiDa.Value)
        thamso.ThoiGianMuonToiDa = Convert.ToInt32(nudThoiGianToiDa.Value)

        result = tsBus.update(thamso)

        If (result.FlagResult = False) Then
            MessageBox.Show("Cập nhật quy định không thành công!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        MessageBox.Show("Cập nhật quy định thành công!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Dim parent = New ucThayDoiQuyDinh
        parent = sender.Parent
        Dim grandpar = New FlowLayoutPanel
        grandpar = parent.Parent
        grandpar.Controls.Clear()
        Dim grgrpar = New frmHome
        grgrpar = grandpar.Parent
        grgrpar.btnThayDoiQuyDinh.selected = False
        Dim ucThuVien As New ucThuVien
        grandpar.Controls.Add(ucThuVien)
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Dim parent = New ucThayDoiQuyDinh
        parent = sender.Parent
        Dim grandpar = New FlowLayoutPanel
        grandpar = parent.Parent
        grandpar.Controls.Clear()
        Dim grgrpar = New frmHome
        grgrpar = grandpar.Parent
        grgrpar.btnThayDoiQuyDinh.selected = False
        Dim ucThuVien As New ucThuVien
        grandpar.Controls.Add(ucThuVien)
    End Sub
End Class
