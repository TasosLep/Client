Imports System.Text
Imports System.Net.Sockets

Public Class Client

    Dim clientSocket As New System.Net.Sockets.TcpClient()
    Dim serverStream As NetworkStream
    Dim readData As String
    Dim infiniteCounter As Integer

    Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As Integer) As Short


    Private Sub ButtonSend_Click(sender As Object, e As EventArgs) Handles ButtonSend.Click

        Dim outStream As Byte() = System.Text.Encoding.ASCII.GetBytes(TextBoxClient.Text + "$")
        serverStream.Write(outStream, 0, outStream.Length)
        serverStream.Flush()
        TextBoxClient.Text = ""
    End Sub

    Private Sub msg()

        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf msg))
        Else
            TextBoxChat.Text = TextBoxChat.Text + Environment.NewLine + " >> " + readData
        End If

        'auto scroll the bar
        TextBoxChat.SelectionStart = TextBoxChat.Text.Length
        TextBoxChat.ScrollToCaret()

    End Sub

    Private Sub ButtonConnect_Click(sender As Object, e As EventArgs) Handles ButtonConnect.Click

        readData = "Conected to Chat Server ..."
        msg()
        clientSocket.Connect("192.168.1.8", 6666)
        'Label1.Text = "Client Socket Program - Server Connected ..."
        serverStream = clientSocket.GetStream()

        Dim outStream As Byte() = System.Text.Encoding.ASCII.GetBytes(TextBoxName.Text + "$")
        serverStream.Write(outStream, 0, outStream.Length)
        serverStream.Flush()

        Dim ctThread As Threading.Thread = New Threading.Thread(AddressOf getMessage)
        ctThread.Start()

        
    End Sub

    Private Sub getMessage()

        For infiniteCounter = 1 To 2
            infiniteCounter = 1
            serverStream = clientSocket.GetStream()
            Dim buffSize As Integer
            Dim inStream(10024) As Byte
            buffSize = inStream.Length
            'buffSize = clientSocket.ReceiveBufferSize
            serverStream.Read(inStream, 0, buffSize)
            Dim returndata As String = System.Text.Encoding.ASCII.GetString(inStream)
            readData = "" + returndata
            msg()
        Next
    End Sub


    Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click

        'Close Application
        Me.Close()

    End Sub

    Private Sub TextBoxName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBoxClient.KeyDown

        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True

        End If

    End Sub

    Private Sub TextBoxClient_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBoxName.KeyDown

        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            sendByEnter()

        End If

    End Sub

    Private Sub sendByEnter()

        Dim text As Boolean = TextBoxClient.Text.Trim.Length
        Dim outStream As Byte() = System.Text.Encoding.ASCII.GetBytes(TextBoxClient.Text + "$")
        If text Then
            serverStream.Write(outStream, 0, outStream.Length)
            serverStream.Flush()
            TextBoxClient.Text = ""
        End If

    End Sub

    Private Sub ButtonViewUpdates_Click(sender As Object, e As EventArgs) Handles ButtonViewUpdates.Click

        Me.Hide()
        UpdatesForm.Show()

    End Sub
End Class
