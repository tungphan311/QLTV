Imports QLTVDAL
Imports QLTVDTO
Imports Utility

Public Class ChiTietPhieuMuonBus
    Private ctpmDAL As ChiTietPhieuMuonDAL

    Public Sub New()
        ctpmDAL = New ChiTietPhieuMuonDAL()
    End Sub
    Public Sub New(connectionString As String)
        ctpmDAL = New ChiTietPhieuMuonDAL(connectionString)
    End Sub

    Public Function build_mactpm(ByRef nextMaCTPM As String) As Result
        Return ctpmDAL.build_mactpm(nextMaCTPM)
    End Function

    Public Function insert(ctpm As ChiTietPhieuMuonDTO) As Result
        Return ctpmDAL.insert(ctpm)
    End Function
End Class
