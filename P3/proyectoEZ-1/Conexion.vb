Imports System.Data.Sql
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Module Conexion

    Dim conexion As MySqlConnection
    Dim enunciado As MySqlCommand
    Dim respuesta As MySqlDataReader

    Sub abrir()
        Try

            conexion = New MySqlConnection("server=localhost; database=mercado_lider;Uid=root;Pwd=;")
            conexion.Open()
            MsgBox("conectado")
        Catch ex As Exception
            MsgBox("no se pudo conectar" + ex.ToString)
        End Try
    End Sub

    Function usuarioregistro(ByVal nombreusuario As String) As Boolean
        Dim resultado As Boolean = False
        Try
            enunciado = New MySqlCommand("SELECT * FROM usuarios where Email ='" & nombreusuario & "'", conexion)
            respuesta = enunciado.ExecuteReader

            If respuesta.Read Then
                resultado = True
            End If
            respuesta.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function

    Function contraseña(ByVal nombreusuario As String) As String
        Dim resultado As String = ""
        Try
            enunciado = New MySqlCommand("SELECT Pass FROM usuarios WHERE Email ='" & nombreusuario & "'", conexion)
            respuesta = enunciado.ExecuteReader

            If respuesta.Read Then
                resultado = respuesta.Item("Pass")
            End If
            respuesta.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function

    Function consultartipousuario(ByVal nombreusuario As String) As Integer
        Dim resultado As Integer
        Try
            enunciado = New MySqlCommand("SELECT ID_rol FROM usuarios WHERE Email ='" & nombreusuario & "'", conexion)
            respuesta = enunciado.ExecuteReader

            If respuesta.Read Then
                resultado = CInt(respuesta.Item("ID_rol"))
            End If
            respuesta.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function
End Module
