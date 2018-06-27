Imports QLTVDTO
Imports QLTVBus
Imports Utility
Imports System.Drawing

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

End Class
