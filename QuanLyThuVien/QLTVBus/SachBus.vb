﻿Imports QLTVDAL
Imports QLTVDTO
Imports Utility

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

    Public Function get_masach(ByRef nextMaSach As String) As Result
        Return sDAL.get_masach(nextMaSach)
    End Function

    Public Function insert(sach As SachDTO) As Result
        Return sDAL.insert(sach)
    End Function

    Public Function update(s As SachDTO) As Result
        Return sDAL.update(s)
    End Function

    Public Function selectAll(ByRef listSach As List(Of SachDTO)) As Result
        Return sDAL.selectAll(listSach)
    End Function

    Public Function delete(strMaSach As String) As Result
        Return sDAL.delete(strMaSach)
    End Function

    Public Function selectAll_MaSach(masach As String, ByRef listSach As List(Of String)) As Result
        Return sDAL.selectAll_MaSach(masach, listSach)
    End Function

    Public Function selectAll_TenSach(tensach As String, ByRef listSach As List(Of String)) As Result
        Return sDAL.selectAll_TenSach(tensach, listSach)
    End Function

    Public Function selectAll_TrangThai(matrangthai As String, ByRef listSach As List(Of String)) As Result
        Return sDAL.selectAll_TrangThai(matrangthai, listSach)
    End Function

    Public Function get_TenSach_ByMaSach(masach As String, ByRef tensach As String) As Result
        Return sDAL.get_TenSach_ByMaSach(masach, tensach)
    End Function

    Public Function get_TrangThai_ByMaSach(masach As String, ByRef trangthai As String) As Result
        Return sDAL.get_TrangThai_ByMaSach(masach, trangthai)
    End Function
End Class
