Imports QLTVDAL
Imports QLTVDTO
Imports Utility

Public Class TheLoaiBUS
    Private tlDAL As TheLoaiDAL

    Public Sub New()
        tlDAL = New TheLoaiDAL()
    End Sub

    Public Sub New(connectionString As String)
        tlDAL = New TheLoaiDAL(connectionString)
    End Sub

    Public Function build_matgs(ByRef nextMaTGS As String) As Result
        Return tlDAL.build_matheloai(nextMaTGS)
    End Function

    Public Function selectAll(ByRef listTheLoai As List(Of TheLoaiDTO)) As Result
        Return tlDAL.selectALL(listTheLoai)
    End Function
End Class
