Imports Utility
Imports QLTVDTO
Imports System.Data.SqlClient
Imports System.Configuration

Public Class SachDAL
    Private connectionString As String

    Public Sub New()
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub

    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function get_masach(ByRef nextMaSach As String) As Result
        nextMaSach = String.Empty
        nextMaSach = "MS"

        Dim query As String = String.Empty
        query &= "select top 1 [masach] "
        query &= "from [tblSach] "
        query &= "order by [masach] desc "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    Dim msOnDB As String
                    msOnDB = Nothing
                    If reader.HasRows = True Then
                        While reader.Read()
                            msOnDB = reader("masach")
                        End While
                    End If
                    If (msOnDB <> Nothing And msOnDB.Length >= 8) Then
                        Dim v = msOnDB.Substring(2)
                        Dim convertDecimal = Convert.ToDecimal(v)
                        convertDecimal = convertDecimal + 1
                        Dim tmp = convertDecimal.ToString()
                        tmp = tmp.PadLeft(msOnDB.Length - 2, "0")
                        nextMaSach = nextMaSach + tmp
                        System.Console.WriteLine(nextMaSach)
                    End If
                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function insert(s As SachDTO) As Result
        Dim query As String = String.Empty
        query &= "insert into [tblSach] "
        query &= "values (@masach, @tenSach, @manhaxuatban, @ngaynhap, @matrangthai, @namxuatban, @trigia, @madocgiamuon)"

        Dim nextMaSach = 0
        Dim ms = "MS" + Convert.ToString(nextMaSach)
        Dim result As Result
        result = get_masach(ms)
        If (result.FlagResult = False) Then
            Return result
        End If
        s.MaSach = ms

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@masach", s.MaSach)
                    .Parameters.AddWithValue("@tensach", s.TenSach)
                    .Parameters.AddWithValue("@manhaxuatban", s.MaNhaXuatBan)
                    .Parameters.AddWithValue("@ngaynhap", s.NgayNhap)
                    .Parameters.AddWithValue("@matrangthai", s.MaTrangThai)
                    .Parameters.AddWithValue("@namxuatban", s.NamXuatBan)
                    .Parameters.AddWithValue("@trigia", s.TriGia)
                    .Parameters.AddWithValue("@madocgiamuon", s.MaDocGiaMuon)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()

                Catch ex As Exception
                    conn.Close()
                    Return New Result(False, "Thêm sách không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function update(s As SachDTO) As Result
        Dim query As String = String.Empty
        query &= "update [tblSach] set "
        query &= " [tensach] = @tensach "
        query &= " [manhaxuatban] = @manhaxuatban "
        query &= " [ngaynhap] = @ngaynhap "
        query &= " [matacgia] = @matacgia "
        query &= " [matheloai] = @matheloai "
        query &= " [matrangthai] = @matrangthai "
        query &= " [namxuatban] = @namxuatban "
        query &= " [trigia] = @trigia "
        query &= " [madocgiamuon] = @madocgiamuon"
        query &= "where "
        query &= " [masach] = @masach "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@masach", s.MaSach)
                    .Parameters.AddWithValue("@tensach", s.TenSach)
                    .Parameters.AddWithValue("@manhaxuatban", s.MaNhaXuatBan)
                    .Parameters.AddWithValue("@ngaynhap", s.NgayNhap)
                    .Parameters.AddWithValue("@matrangthai", s.MaTrangThai)
                    .Parameters.AddWithValue("@namxuatban", s.NamXuatBan)
                    .Parameters.AddWithValue("@trigia", s.TriGia)
                    .Parameters.AddWithValue("@madocgiamuon", s.MaDocGiaMuon)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()

                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    Return New Result(False, "Cập nhật sách thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function selectAll(ByRef listSach As List(Of SachDTO)) As Result

        Dim query As String = String.Empty
        query &= "select [masach], [tenSach], [manhaxuatban], [ngaynhap], [matacgia], [matheloai], [matrangthai], [namxuatban], [trigia], [madocgiamuon]"
        query &= " from [tblSach]"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listSach.Clear()
                        While reader.Read()
                            listSach.Add(New SachDTO(reader("masach"), reader("tensach"), reader("manhaxuatban"), reader("ngaynhap"), reader("matrangthai"), reader("namxuatban"), reader("trigia"), reader("madocgiamuon")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    Return New Result(False, "Lây tất cả sách không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function delete(strMaSach As String) As Result

        Dim query As String = String.Empty
        query &= " delete from [tblSach]"
        query &= " where"
        query &= " [masach] = @masach"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@masach", strMaSach)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    Return New Result(False, "Xoá sách không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function
End Class
