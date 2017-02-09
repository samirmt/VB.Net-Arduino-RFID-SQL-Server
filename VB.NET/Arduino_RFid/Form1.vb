Public Class Form1
    Dim myport As Array
    Dim dao As New clsAcessaDados
    Dim pessoa As New clsPessoa
    Dim serial As New clsSerialConfig
    Public retornoSerial, retornoLinha As String
    Dim serialBuffer, serialLinha As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnSalvar.Enabled = False
        CarregarTaxaEPortas()
    End Sub
    Private Sub SerialPort1_DataReceived(sender As Object, e As IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        Try
            If SerialPort1.IsOpen Then
                serialLinha = serialLinha & SerialPort1.ReadExisting() 'imp
                If InStr(1, serialLinha, vbCr) > 0 _
                  Or InStr(1, serialLinha, vbLf) > 0 Then
                    serialBuffer = serialLinha
                    serialLinha = ""
                    Me.BeginInvoke(New EventHandler(AddressOf doProcess)) 'imp
                Else
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            MsgBox("Erro ao ler a Serial" & vbCrLf & ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub doProcess()
        Debug.Print(serialBuffer)
        retornoSerial += serialBuffer
        retornoLinha = serialBuffer
    End Sub

    Private Sub btnConectar_Click(sender As Object, e As EventArgs) Handles btnConectar.Click
        If serial.Conectar Then
            btnConectar.Enabled = False
            btnDesconectar.Enabled = True
            cboPorta.Enabled = False
            cboTaxa.Enabled = False
            tmrGravarPessoa.Enabled = True
        End If
    End Sub

    Private Sub btnDesconectar_Click(sender As Object, e As EventArgs) Handles btnDesconectar.Click
        If serial.Desconectar Then
            Limpar()
            btnConectar.Enabled = True
            btnDesconectar.Enabled = False
            cboPorta.Enabled = True
            cboTaxa.Enabled = True
            tmrGravarPessoa.Enabled = False
            tmrBuscarPessoa.Enabled = False
        End If
    End Sub

    Private Sub tmrControle_Tick(sender As Object, e As EventArgs) Handles tmrGravarPessoa.Tick
        If txtNome.Text = "" Then
            lblStatus.Text = "Preencha o NOME!"
        ElseIf txtEmail.Text = "" Then
            lblStatus.Text = "Preencha o EMAIL!"
        ElseIf txtTag.Text = "" Then
            btnSalvar.Enabled = False
            lblStatus.Text = "Aproxime a TAG do leitor!"
            txtTag.Text = LerTag()
        Else
            lblStatus.Text = "Pronto para SALVAR!"
            btnSalvar.Enabled = True
        End If

        CentralizarLabel()
    End Sub

    Private Sub CarregarTaxaEPortas()
        'Carrega as Portas COM detectadas
        myport = IO.Ports.SerialPort.GetPortNames
        For i = 0 To UBound(myport)
            cboPorta.Items.Add(myport(i))
        Next

        'Carrega as Taxas da Porta Serial
        cboTaxa.Items.Add(9600)
        cboTaxa.Items.Add(19200)
        cboTaxa.Items.Add(38400)
        cboTaxa.Items.Add(57600)
        cboTaxa.Items.Add(115200)

        cboPorta.SelectedIndex = 0
        cboTaxa.SelectedIndex = 0

    End Sub

    Private Function LerTag() As String
        Dim tag As String = ""
        tag = serial.LerLinha

        If Not IsNothing(tag) Then
            tag = tag.Trim

            If Len(tag) < 7 Then
                LerTag = ""
            Else
                LerTag = tag
            End If
        End If

    End Function

    Private Sub CentralizarLabel()
        lblStatus.Left = ((GroupBox3.Width / 2) - (lblStatus.Width / 2))
        lblStatus.Top = ((GroupBox3.Height / 2) - (lblStatus.Height / 2))
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        pessoa.nome = txtNome.Text
        pessoa.email = txtEmail.Text
        pessoa.tag = txtTag.Text

        If dao.SalvarPessoa(pessoa) Then
            MsgBox("Pessoa foi salva com sucesso!", MsgBoxStyle.Information)
            Limpar()
        Else
            MsgBox("Ocorreu um erro ao gravar a Pessoa!", MsgBoxStyle.Information)
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnLer.Click
        Limpar()
        btnSalvar.Enabled = False
        tmrGravarPessoa.Enabled = False

        tmrBuscarPessoa.Enabled = True
    End Sub

    Private Sub tmrBuscarPessoa_Tick(sender As Object, e As EventArgs) Handles tmrBuscarPessoa.Tick
        Dim tag As String = ""

        tag = LerTag()
        lblStatus.Text = "Aproxime a TAG do leitor!"

        If tag <> "" Then
            Dim pessoa As New clsPessoa
            pessoa = dao.BuscarPessoa(tag)

            If Not IsNothing(pessoa) Then
                txtNome1.Text = pessoa.nome
                txtEmail1.Text = pessoa.email
                lblStatus.Text = "Pessoa encontrada!"
                tmrBuscarPessoa.Enabled = False
            Else
                tmrBuscarPessoa.Enabled = False
                MsgBox("Pessoa não encontrada!", MsgBoxStyle.Information)
            End If
        End If


    End Sub

    Private Sub Limpar()
        txtNome.Text = ""
        txtEmail.Text = ""
        txtTag.Text = ""
    End Sub
End Class
