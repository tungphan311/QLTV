Imports QLTVDTO
Imports QLTVBus
Imports Utility

Public Class ucThuVien
    Dim dgBus As DocGiaBus

    Private Sub ucThuVien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim result As Result
        dgBus = New DocGiaBus()

        Dim listDocGia As List(Of DocGiaDTO)
        listDocGia = New List(Of DocGiaDTO)
        result = dgBus.selectAll(listDocGia)

        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách độc giả thất bại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        lbSoDocGia.Text = listDocGia.Count.ToString()


    End Sub
End Class
