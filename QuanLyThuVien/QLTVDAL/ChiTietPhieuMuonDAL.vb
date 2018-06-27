Imports System.Configuration
Imports System.Data.SqlClient
Imports QLTVDTO
Imports Utility

Public Class ChiTietPhieuMuonDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub

    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function build_mactpm(ByRef nextMaCTPM As String) As Result
        nextMaCTPM = String.Empty
        nextMaCTPM = "CTPM"

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
                        nextMaCTPM = nextMaCTPM + tmp
                        System.Console.WriteLine(nextMaCTPM)
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
        query &= " INSERT INTO [tblChiTietPhieuMuon]"
        query &= " VALUES (@machitietphieumuon, @maphieumuonsach, @masach)"

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
        Return New Result(True)
    End Function
End Class
