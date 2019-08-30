Imports System.Net
Imports System.Net.Sockets
Imports System.Text

Public Class Form1
    Private Sub PC1_Rest_Button_Click(sender As Object, e As EventArgs) Handles PC1_Rest_Button.Click
        Dim tcpcc As New TcpClient(PC1_IP.Text, CInt(PC1_PORT.Text))

        Do Until tcpcc.Connected

            PC1_Rest_Button.Text = "等...."

        Loop

        PC1_Rest_Button.Text = "主機一"

        TextBox1.Text = WriteToPLC("PC1=RESTART", tcpcc)

        tcpcc.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles PC2_Rest_Button.Click
        Dim tcpcc As New TcpClient(PC2_IP.Text, CInt(PC2_PORT.Text))

        Do Until tcpcc.Connected

            PC2_Rest_Button.Text = "等...."

        Loop

        PC2_Rest_Button.Text = "主機二"

        TextBox1.Text = WriteToPLC("PC2=RESTART", tcpcc)
        tcpcc.Close()

    End Sub


    Public Function WriteToPLC(ByVal cmd As String, tcpc As TcpClient) As String 'TCP 讀寫核心

        Try

            Dim sendBuf As Byte() = Encoding.ASCII.GetBytes(Chr(2) & cmd & Chr(3))
            Dim Str As String = ""


            tcpc.GetStream.Write(sendBuf, 0, sendBuf.Length)
            System.Threading.Thread.Sleep(100)
            If tcpc.GetStream.DataAvailable = True Then
                ' Console.WriteLine("sleep>>")
                Dim rec_buf(tcpc.Available) As Byte
                tcpc.GetStream.Read(rec_buf, 0, rec_buf.Length)
                Str = Encoding.ASCII.GetString(rec_buf)
            End If

            Return Str


        Catch ex As Exception
            Return "Error"
        End Try



    End Function

End Class
