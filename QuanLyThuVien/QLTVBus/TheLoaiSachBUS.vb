﻿Imports QLTVDAL
Imports QLTVDTO
Imports Utility

Public Class TheLoaiSachBUS
    Private tlsDAL As TheLoaiSachDAL

    Public Sub New()
        tlsDAL = New TheLoaiSachDAL()
    End Sub

    Public Sub New(connectionString As String)
        tlsDAL = New TheLoaiSachDAL(connectionString)
    End Sub

    Public Function build_matgs(ByRef nextMaTGS As String) As Result
        Return tlsDAL.build_matls(nextMaTGS)
    End Function

    Public Function selectAll(ByRef listTLS As List(Of TheLoaiSachDTO)) As Result
        Return tlsDAL.selectALL(listTLS)
    End Function

    Public Function deleteAllByMaTheLoai(matheloai As String) As Result
        Return tlsDAL.deleteAllByMaTheLoai(matheloai)
    End Function
End Class
