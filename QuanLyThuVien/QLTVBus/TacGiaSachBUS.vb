Imports QLTVDAL
Imports QLTVDTO
Imports Utility

Public Class TacGiaSachBUS
    Private tgsDAL As TacGiaSachDAL

    Public Sub New()
        tgsDAL = New TacGiaSachDAL()
    End Sub

    Public Sub New(connectionString As String)
        tgsDAL = New TacGiaSachDAL(connectionString)
    End Sub

    Public Function build_matgs(ByRef nextMaTGS As String) As Result
        Return tgsDAL.build_matgs(nextMaTGS)
    End Function

    Public Function selectAll(ByRef lisTGS As List(Of TacGiaSachDTO)) As Result
        Return tgsDAL.selectALL(lisTGS)
    End Function
End Class
