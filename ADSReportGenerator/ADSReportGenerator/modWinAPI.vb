Imports System.Drawing
Module modWinAPI

    Private Delegate Function EnumChildWindowsProc(ByVal hwnd As IntPtr, ByVal lParam As Int32) As Int32
    Private Delegate Function EnumWindowsProc(ByVal hwnd As IntPtr, ByVal lParam As Int32) As Int32
    Private Declare Function GetWindowText Lib "user32" Alias "GetWindowTextA" (ByVal hwnd As Integer, ByVal lpString As String, ByVal cch As Integer) As Integer
    Private Declare Function EnumWindows Lib "user32" (ByVal lpEnumFunc As EnumWindowsProc, ByVal lParam As Integer) As Integer
    Private Declare Function EnumChildWindows Lib "user32" (ByVal hWndParent As Integer, ByVal lpEnumFunc As EnumChildWindowsProc, ByVal lParam As Integer) As Integer
    Private Declare Function GetClassName Lib "user32" Alias "GetClassNameA" (ByVal hwnd As Integer, ByVal lpClassName As String, ByVal nMaxCount As Integer) As Integer
    Public AAOSHandle As Long = 0

    Public Function EnumerateWindows(ByVal lParam As Integer) As Boolean
        Dim RetVal As Integer
        AAOSHandle = 0
        RetVal = EnumWindows(AddressOf EnumHostProc, lParam)
        If AAOSHandle = 0 Then
            Return False
        End If
        Return True
    End Function

    Public Function EnumerateChildWindows(ByVal ParentWindowHandle As IntPtr, ByVal lParam As Integer) As Boolean
        Dim RetVal As Integer
        RetVal = EnumChildWindows(ParentWindowHandle, AddressOf EnumChildProc, lParam)
        Return RetVal
    End Function

    Public Function EnumHostProc(ByVal lhWnd As IntPtr, ByVal lParam As Integer) As Integer
        Dim RetVal As Long
        Dim WinClassBuf As New String(vbNullChar, 255)
        Dim WinTitleBuf As New String(vbNullChar, 255)
        Dim WinClass As String
        Dim WinTitle As String

        EnumHostProc = True
        RetVal = GetWindowText(lhWnd, WinTitleBuf, 255)
        WinTitle = StripNulls(WinTitleBuf)
        RetVal = GetClassName(lhWnd, WinClassBuf, 255)
        WinClass = StripNulls(WinClassBuf)

        If lParam = 1 Then  'we are looking for main AAOS window handle

            'Debug.Print(WinTitle)
            If (WinTitle Like "Openings Studio*" And WinClass Like "SunAwtFrame*") Then
                AAOSHandle = lhWnd
                EnumChildWindows(lhWnd, AddressOf EnumChildProc, 0)
                EnumHostProc = False
            End If
        End If



    End Function

    Public Function StripNulls(ByVal OriginalStr As String) As String
        If (InStr(OriginalStr, Chr(0)) > 0) Then
            OriginalStr = Left(OriginalStr, InStr(OriginalStr, Chr(0)) - 1)
        End If
        StripNulls = OriginalStr
    End Function

    Public Function EnumChildProc(ByVal hwnd As IntPtr, ByVal lParam As Integer) As Integer
        Dim WinClassBuf As New String(vbNullChar, 255)
        Dim WinTitleBuf As New String(vbNullChar, 255)
        Dim WinClass As String, WinTitle As String
        Dim WinWidth As Long = 0
        Dim WinHeight As Long = 0
        Dim ParentHwnd As Long = 0
        Dim ParentTitle As String = ""
        Dim RetVal As Long

        EnumChildProc = True
        RetVal = GetClassName(hwnd, WinClassBuf, 255)
        WinClass = Mid(WinClassBuf, 1, InStr(WinClassBuf, vbNullChar) - 1) ' remove extra Nulls & spaces
        RetVal = GetWindowText(hwnd, WinTitleBuf, 255)
        WinTitle = StripNulls(WinTitleBuf)

    End Function

End Module
