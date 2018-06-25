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

    Public Function build_mactphieumuon(ByRef nextMactPhieuMuon As String) As Result
        Return ctpmDAL.build_mactphieumuon(nextMactPhieuMuon)
    End Function

    Public Function insert(ctpm As ChiTietPhieuMuonDTO) As Result
        Return ctpmDAL.insert(ctpm)
    End Function

    Public Function selectALL(ByRef listCTPhieuMuon As List(Of ChiTietPhieuMuonDTO)) As Result
        Return ctpmDAL.selectALL(listCTPhieuMuon)
    End Function

End Class
