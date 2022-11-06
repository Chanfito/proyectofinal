Imports Dapper
Imports System.Data.SqlClient

Public Class DataBase
    Private Const connectionString As String = "Data Source=CHANFU2-PC;Initial Catalog=PROGRA_II;Integrated Security=True;Trusted_Connection=Yes;"

    Public Shared Function Query(Of T)(ByVal queryToExecute As String, ByVal Optional parameters As Object = Nothing) As List(Of T)
        Try

            Using conn As SqlConnection = New SqlConnection(connectionString)
                Return conn.Query(Of T)(queryToExecute, parameters).ToList()
            End Using

        Catch ex As Exception
            Return New List(Of T)()
        End Try
    End Function

    Public Shared Function QueryFirstOrDefault(Of T)(ByVal queryToExecute As String, ByVal Optional parameters As Object = Nothing) As T
        Dim defaultValue As T = CType(Nothing, T)
        Try

            Using conn As SqlConnection = New SqlConnection(connectionString)
                Return conn.QueryFirstOrDefault(Of T)(queryToExecute, parameters)
            End Using

        Catch ex As Exception
            Return defaultValue
        End Try
    End Function

    Public Shared Sub Execute(ByVal queryToExecute As String, ByVal Optional parameters As Object = Nothing)
        Try

            Using conn As SqlConnection = New SqlConnection(connectionString)
                conn.Execute(queryToExecute, parameters)
            End Using

        Catch ex As Exception
            Console.WriteLine(ex)
        End Try
    End Sub

End Class