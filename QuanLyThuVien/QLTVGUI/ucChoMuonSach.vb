Imports QLTVDTO
Imports QLTVBus
Imports Utility

Public Class ucChoMuonSach
    Private dgBus As DocGiaBus
    Private pmsBUS As PhieuMuonSachBus
    Private ctpmBUS As ChiTietPhieuMuonBus

    Private Sub ucChoMuonSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgBus = New DocGiaBus()
        pmsBUS = New PhieuMuonSachBus()
        ctpmBUS = New ChiTietPhieuMuonBus()
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

    End Sub

    Private Sub tbMaDocGia_KeyDown(sender As Object, e As KeyEventArgs) Handles tbMaDocGia.KeyDown
        If (e.KeyCode = Keys.Enter) Then

        End If
    End Sub
End Class
