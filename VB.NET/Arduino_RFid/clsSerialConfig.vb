Public Class clsSerialConfig

    Public Function Conectar() As Boolean
        Try
            If Form1.SerialPort1.IsOpen Then Form1.SerialPort1.Close()

            Form1.SerialPort1.PortName = Form1.cboPorta.Text
            Form1.SerialPort1.BaudRate = Form1.cboTaxa.Text
            Form1.SerialPort1.Parity = IO.Ports.Parity.None
            Form1.SerialPort1.StopBits = IO.Ports.StopBits.One
            Form1.SerialPort1.DataBits = 8
            Form1.SerialPort1.Open()

            If Form1.SerialPort1.IsOpen Then
                Conectar = True
            Else
                Conectar = False
            End If
        Catch ex As Exception
            Conectar = False
            MsgBox("Erro ao Conectar na Serial!" & vbCrLf & ex.Message)
        End Try

    End Function

    Public Function Desconectar() As Boolean
        Try
            If Form1.SerialPort1.IsOpen Then
                Form1.SerialPort1.Close()
                Desconectar = True
            Else
                Desconectar = False
            End If
        Catch ex As Exception
            Desconectar = False
            MsgBox("Erro ao Desconectar da Serial!" & vbCrLf & ex.Message)
        End Try

    End Function


    Public Function LerLinha() As String
        Dim msg As String = ""

        If Form1.SerialPort1.IsOpen Then
            Try
                msg = Form1.retornoLinha
            Catch ex As Exception
                msg = Nothing
            End Try
        Else
            msg = Nothing
        End If

        LerLinha = msg
    End Function

    Public Function LerTudo() As String
        Dim msg As String = ""

        Try
            msg = Form1.retornoSerial
        Catch ex As Exception
            msg = Nothing
        End Try

        LerTudo = msg
    End Function
End Class
