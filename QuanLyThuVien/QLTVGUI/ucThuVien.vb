Imports QLTVDTO
Imports QLTVBus
Imports Utility

Public Class ucThuVien
    Dim dgBus As DocGiaBus
    Dim pmsBus As PhieuMuonSachBus
    Dim sachBus As SachBUS

    Private Sub ucThuVien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim result As Result
        dgBus = New DocGiaBus()
        pmsBus = New PhieuMuonSachBus()
        sachBus = New SachBUS()

        ' Hien thi so dau sach
        Dim listSach As List(Of SachDTO)
        listSach = New List(Of SachDTO)
        result = sachBus.selectAll(listSach)

        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách đầu sách thất bại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        lbSoDauSach.Text = listSach.Count.ToString()

        ' Hien thi so doc gia
        Dim listDocGia As List(Of DocGiaDTO)
        listDocGia = New List(Of DocGiaDTO)
        result = dgBus.selectAll(listDocGia)

        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách độc giả thất bại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        lbSoDocGia.Text = listDocGia.Count.ToString()

        ' Hien thi so luot muon
        Dim listPhieuMuon As List(Of PhieuMuonSachDTO)
        listPhieuMuon = New List(Of PhieuMuonSachDTO)
        result = pmsBus.selectALL(listPhieuMuon)

        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách phiếu mượn thất bại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        lbSoLuotMuon.Text = listPhieuMuon.Count.ToString()
    End Sub
End Class
