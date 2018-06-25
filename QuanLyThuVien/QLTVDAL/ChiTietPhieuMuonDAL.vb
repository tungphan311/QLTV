﻿Imports System.Configuration
Imports System.Data.SqlClient
Imports QLTVDTO
Imports Utility

Public Class ChiTietPhieuMuonDAL
    Private connectionString As String

    Public Sub New()
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub

    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function build_mactphieumuon(ByRef nextMactPhieuMuon As String) As Result
        nextMactPhieuMuon = String.Empty
        nextMactPhieuMuon = "CTPM"

        Dim query As String = String.Empty
        query &= "SELECT TOP 1 [machitietphieumuon] "
        query &= "FROM [tblChiTietPhieuMuon] "
        query &= "ORDER BY [machitietphieumuon] DESC "

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
                            msOnDB = reader("machitietphieumuon")
                        End While
                    End If
                    If (msOnDB <> Nothing And msOnDB.Length >= 8) Then
                        Dim v = msOnDB.Substring(4)
                        Dim convertDecimal = Convert.ToDecimal(v)
                        convertDecimal = convertDecimal + 1
                        Dim tmp = convertDecimal.ToString()
                        tmp = tmp.PadLeft(msOnDB.Length - 4, "0")
                        nextMactPhieuMuon = nextMactPhieuMuon + tmp
                        System.Console.WriteLine(nextMactPhieuMuon)
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

    Public Function insert(ctpm As ChiTietPhieuMuonDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [tblChiTietPhieuMuon] ([machitietphieumuon], [maphieumuonsach], [masach])"
        query &= "VALUES (@machitietphieumuon,@maphieumuonsach,@masach)"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@machitietphieumuon", ctpm.MaChiTietPhieuMuon)
                    .Parameters.AddWithValue("@maphieumuonsach", ctpm.MaPhieuMuonSach)
                    .Parameters.AddWithValue("@masach", ctpm.MaSach)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function selectALL(ByRef listCTPhieuMuon As List(Of ChiTietPhieuMuonDTO)) As Result

        Dim query As String = String.Empty
        query &= "SELECT [machitietphieumuon], [maphieumuonsach], [masach]"
        query &= "FROM [tblChiTietPhieuMuon]"


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
                        listCTPhieuMuon.Clear()
                        While reader.Read()
                            listCTPhieuMuon.Add(New ChiTietPhieuMuonDTO(reader("machitietphieumuon"), reader("maphieumuonsach"), reader("masach")))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
End Class