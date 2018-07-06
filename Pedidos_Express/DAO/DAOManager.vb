Imports System.Data.SqlClient

Public Class DAOManager

    Dim connection = My.Settings.conecctionString
    Dim reader As SqlDataReader

    Public Function chekLoginDAO(usr As String, pass As String) As String

        Dim cmd As New SqlCommand("select * from Usuario where Nombre_usuario = @usr and Contrasenna = @pass", connection)

    End Function


End Class
