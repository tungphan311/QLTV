Imports QLTVDAL
Imports QLTVDTO
Imports Utility

Public Class DocGiaBus
    Private dgDAL As DocGiaDAL

    Public Function buildMaDocGia(ByRef nextMshs As Integer) As Result
        Return dgDAL.build_madocgia(nextMshs)
    End Function
End Class
