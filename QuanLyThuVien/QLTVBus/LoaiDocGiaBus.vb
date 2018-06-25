Imports QLTVDAL
Imports QLTVDTO
Imports Utility

Public Class LoaiDocGiaBus
    Private ldgDAL As LoaiDocGiaDAL

    Public Sub New()
        ldgDAL = New LoaiDocGiaDAL()
    End Sub
    Public Sub New(connectionString As String)
        ldgDAL = New LoaiDocGiaDAL(connectionString)
    End Sub

    Public Function selectAll(ByRef listLoaiDG As List(Of LoaiDocGiaDTO)) As Result
        Return ldgDAL.selectALL(listLoaiDG)
    End Function
End Class
