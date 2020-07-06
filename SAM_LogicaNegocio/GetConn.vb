Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Configuration
Imports System.Data.SqlClient
Imports SAM_Entidades
Imports SAM_AccesoDatos
Public Class GetConn
    Inherits AD_Coneccion
    Public Function VerifyConnection() As Boolean
        Dim Result As Boolean
        If AbrirConeccion().State = ConnectionState.Open Then
            Result = True
        Else : Result = False
        End If
        Return Result
    End Function
End Class
