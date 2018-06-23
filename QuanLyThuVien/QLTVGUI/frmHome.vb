Imports System.Windows.Forms

Public Class frmHome
    Private Sub ibtnExit_Click(sender As Object, e As EventArgs) Handles ibtnExit.Click
        If MessageBox.Show("Bạn muốn tắt ứng dụng Quản lý thư viện?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub ibtnMinimize_Click(sender As Object, e As EventArgs) Handles ibtnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnLapTheDocGia_Click(sender As Object, e As EventArgs) Handles btnLapTheDocGia.Click
        fpnZone.Controls.Clear()
        Dim ucLapTheDocGia As New ucLapTheDocGia
        fpnZone.Controls.Add(ucLapTheDocGia)
    End Sub

    Private Sub btnTiepNhanSachMoi_Click(sender As Object, e As EventArgs) Handles btnTiepNhanSachMoi.Click
        fpnZone.Controls.Clear()
        Dim ucTiepNhanSachMoi As New ucTiepNhanSachMoi
        fpnZone.Controls.Add(ucTiepNhanSachMoi)
    End Sub

    Private Sub btnTraCuuSach_Click(sender As Object, e As EventArgs) Handles btnTraCuuSach.Click
        fpnZone.Controls.Clear()
        Dim ucTraCuuSach As New ucTraCuuSach
        fpnZone.Controls.Add(ucTraCuuSach)
    End Sub

    Private Sub btnChoMuonSach_Click(sender As Object, e As EventArgs) Handles btnChoMuonSach.Click
        fpnZone.Controls.Clear()
        Dim ucChoMuonSach As New ucChoMuonSach
        fpnZone.Controls.Add(ucChoMuonSach)
    End Sub

    Private Sub btnNhanTraSach_Click(sender As Object, e As EventArgs) Handles btnNhanTraSach.Click
        fpnZone.Controls.Clear()
        Dim ucNhanTraSach As New ucNhanTraSach
        fpnZone.Controls.Add(ucNhanTraSach)
    End Sub
End Class