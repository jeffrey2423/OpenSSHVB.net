Imports System.Security
Imports System.Text
Imports Renci.SshNet
Imports Renci.SshNet.Common

Public Class Form1
    Private sshClient As Renci.SshNet.SshClient
    Private cmd As Renci.SshNet.SshCommand
    Private strCommand As String
    Private connInfo As ConnectionInfo

    Private Sub main(ByVal ip As String, ByVal port As Integer, ByVal user As String, ByVal pass As String, ByVal path As String, ByVal fileName As String)
        Try
            connInfo = New ConnectionInfo(ip, port, user, New AuthenticationMethod() {New PasswordAuthenticationMethod(user, pass)})
            sshClient = New Renci.SshNet.SshClient(connInfo)
            strCommand = path & "\" & fileName
            status.Text = strCommand
            Dim strBuscarProceso = "tasklist /FI ""IMAGENAME eq PDVUNOEE.exe"" | find /I /N ""PDVUNOEE.exe"" ||start " & strCommand

            Using sshClient
                btnConnect.Text = "Cargando"
                btnConnect.Enabled = False
                startConnection(sshClient)
                verSsh()
                ExecuteCommand(sshClient, strBuscarProceso, cmd)
                endConnection(sshClient)
                btnConnect.Text = "Iniciar POS"
                btnConnect.Enabled = True
            End Using

        Catch ex As Exception
            verSsh(ex.Message)
        End Try

    End Sub

    Private Sub endConnection(sshClient As SshClient)
        Try
            If sshClient.IsConnected Then
                sshClient.Disconnect()
            End If
        Catch ex As Exception
            verSsh(ex.Message)
        End Try
    End Sub

    Private Sub startConnection(sshClient As SshClient)
        Try
            If Not sshClient.IsConnected Then
                sshClient.Connect()
            End If
        Catch ex As Exception
            verSsh(ex.Message)
        End Try
    End Sub

    Private Function validarCampos() As Boolean
        validarCampos = True


    End Function



    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click

        main(ip.Text, port.Text, user.Text, pass.Text, path.Text, tpv.Text)

    End Sub

    Private Function ExecuteCommand(ByVal sshClient As SshClient, ByVal command As String, ByVal cmd As SshCommand)
        Try
            If Not sshClient.IsConnected Then sshClient.Connect()
            cmd = sshClient.CreateCommand("cmd /c " & command)
            cmd.Execute()
        Catch ex As Exception

        End Try
    End Function

    Private Sub verSsh(Optional masInfo As String = "")
        Try
            If Not sshClient Is Nothing Then
                If Not sshClient Is Nothing AndAlso sshClient.IsConnected Then
                    status.Text = "Se establecio conexion con: " & sshClient.ConnectionInfo.Host

                Else
                    status.Text = "No se pudo establecer conexion con " &
                                    sshClient.ConnectionInfo.Host &
                                    masInfo
                    btnConnect.Text = "Iniciar POS"
                    btnConnect.Enabled = True
                End If
            Else
                status.Text = "No se pudo establecer conexion con " &
                          ip.Text &
                          masInfo
                btnConnect.Text = "Iniciar POS"
                btnConnect.Enabled = True
            End If


        Catch ex As Exception
            status.Text = "No se pudo establecer conexion con " &
                ip.Text & " " & masInfo
            btnConnect.Text = "Iniciar POS"
            btnConnect.Enabled = True
        End Try

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ip.Text = "172.16.45.221"
        port.Text = "22"

        user.Text = "jeffrey.rios"
        pass.Text = "Siesa$2020"

        path.Text = "C:\Users\jeffrey.rios\Desktop\PDVUNOEE_TVP\TPV-NORMAL"
        tpv.Text = "PDVUNOEE-SQL-DEV"



        'main(ip.Text, port.Text, user.Text, pass.Text, path.Text, tpv.Text)
    End Sub
End Class
