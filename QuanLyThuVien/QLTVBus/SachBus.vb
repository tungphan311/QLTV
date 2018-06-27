Imports QLTVDAL
Imports QLTVDTO
Imports Utility
Imports System.Text.RegularExpressions

Public Class SachBUS
    Private sDAL As SachDAL

    Public Sub New()
        sDAL = New SachDAL()
    End Sub

    Public Sub New(connectionString As String)
        sDAL = New SachDAL(connectionString)
    End Sub

    Public Function isValidName(sach As SachDTO) As Boolean

        If (sach.TenSach.Length < 1) Then
            Return False
        End If

        Return True

    End Function

    Public Function isExpired(sach As SachDTO) As Boolean

        Dim nam As Integer
        nam = DateTime.Now.Year - sach.NamXuatBan
        If (nam > 8) Then
            Return False
        End If

        Return True
    End Function

    Public Function insert(sach As SachDTO) As Result

    End Function

    Public Function findWithMaSachTacGia(ByRef maSach As String, ByRef tenSach As String, listTG As List(Of String)) As Result
        Return sDAL.findWithMaSachTacGia(maSach, tenSach, listTG)
    End Function

    Public Function findWithMaSachTheLoai(ByRef maSach As String, listTL As List(Of String))
        Return sDAL.findWithMaSachTheLoai(maSach, listTL)
    End Function
End Class
