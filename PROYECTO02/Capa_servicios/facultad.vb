Imports System.Data
Imports System.Data.SqlClient
Imports Capa_Datos
Public Class facultad
    Dim DB As BD
    Dim command As SqlCommand
    Public Sub New()
        DB = New BD
    End Sub
    Public Function ListarFaculdates() As DataTable
        Dim dt As New DataTable

        Try
            DB.connection.Open()
            command = New SqlCommand("SP_Listar_Facultades", DB.connection)
            command.CommandType = CommandType.StoredProcedure
            Dim sqlAdapter As SqlDataAdapter = New SqlDataAdapter(command)
            sqlAdapter.Fill(dt)
            DB.connection.Close()
            Return dt

        Catch ex As Exception
            Console.WriteLine("error" + ex.ToString)
        Finally
            DB.connection.Close()
        End Try
    End Function
    Public Function BuscarCarreras(codigo As String) As DataTable
        Dim dt As New DataTable

        Try
            DB.connection.Open()
            Dim sql As String = "select a.cod_carrera,a.carrera from Carrera a inner join Facultad b
                                  on a.cod_facultad = b.codigo
                                  where a.cod_facultad=@codigo"
            command = New SqlCommand(sql, DB.connection)
            command.CommandType = CommandType.Text
            command.Parameters.AddWithValue("@codigo", codigo)
            Dim sqlAdapter As SqlDataAdapter = New SqlDataAdapter(command)
            sqlAdapter.Fill(dt)
            DB.connection.Close()
            Return dt

        Catch ex As Exception
            Console.WriteLine("error" + ex.ToString)
        Finally
            DB.connection.Close()
        End Try
    End Function
End Class
