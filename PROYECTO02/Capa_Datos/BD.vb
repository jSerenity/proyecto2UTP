Imports System.Data.SqlClient

Public Class BD
    Dim connectionstring As String
    Public connection As SqlConnection
    Public Sub New()
        connectionstring = "Data Source=DESKTOP-H2N03CL\SQLEXPRESS;database=PROYECTO2;Integrated Security=SSPI;persist security info=True;"
        connection = New SqlConnection(connectionstring)
    End Sub
End Class
