Imports System.Data.SqlClient
Imports System.ComponentModel

Public Class DataCls
    Implements IDisposable

    Public DA As SqlClient.SqlDataAdapter
    Public DT As DataTable
    Private CB As SqlClient.SqlCommandBuilder
    Public DatabaseName As String


    Public Sub New(ByVal sQuery As String, ByVal DBase As SqlClient.SqlConnection, Optional ByVal AllowUpdate As Boolean = False, Optional ByVal AllowInsert As Boolean = False, Optional ByVal AllowDelete As Boolean = False)
        'On Error GoTo ErrHandler  'Error needs to be passed back so the AddPrimaryKey works right
        DA = New SqlDataAdapter(sQuery, DBase)
        If AllowUpdate = True OrElse AllowInsert = True OrElse AllowDelete = True Then
            CB = New SqlClient.SqlCommandBuilder(DA)
        End If
        If AllowUpdate = True Then DA.UpdateCommand = CB.GetUpdateCommand
        If AllowInsert = True Then DA.InsertCommand = CB.GetInsertCommand
        If AllowDelete = True Then DA.DeleteCommand = CB.GetDeleteCommand
        DT = New DataTable()
        DT.Locale = System.Globalization.CultureInfo.InvariantCulture
        DA.Fill(DT)
        DatabaseName = DBase.Database.ToString
    End Sub

    Public Sub UpdateTable()
        On Error GoTo ErrHandler
        Me.DA.Update(Me.DT)
        Exit Sub
ErrHandler:
        SafelyDisplayError(Err)
        Resume Next
        Resume
    End Sub


    Public Sub AddRow(ByVal DR As DataRow)
        On Error GoTo ErrHandler
        Me.DT.Rows.Add(DR)
        UpdateTable()
        Exit Sub
ErrHandler:
        SafelyDisplayError(Err)
        Resume Next
        Resume
    End Sub

    Protected Overrides Sub Finalize()
        On Error Resume Next
        Dispose()
    End Sub

    Private disposedValue As Boolean = False        ' To detect redundant calls

    ' IDisposable
    Protected Overridable Sub Dispose(ByVal disposing As Boolean)
        If Not Me.disposedValue Then
            If disposing Then
                If Not CB Is Nothing Then CB.Dispose()
                If Not DA Is Nothing Then DA.Dispose()
                If Not DT Is Nothing Then DT.Dispose()
                CB = Nothing
                DA = Nothing
                DT = Nothing
            End If
        End If
        Me.disposedValue = True
    End Sub

#Region " IDisposable Support "
    ' This code added by Visual Basic to correctly implement the disposable pattern.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' Do not change this code.  Put cleanup code in Dispose(ByVal disposing As Boolean) above.
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub
#End Region

End Class


