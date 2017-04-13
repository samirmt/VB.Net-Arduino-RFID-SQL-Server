# VB.Net-Arduino-RFID-SQL-Server
Sistema para cadastro de TAG e busca da Pessoa pela TAG

Este projeto constitui em:

No VB.NET
Um projeto que faz todo o monitoramento que vem do Arduino via Serial
Cadastra no SQL Server os dados digitados junto com a tag do cartao rfid lido pelo arduino.
Consulta os dados via Tag lida pelo arduino.

No Arduino
um código que faz a leitura da tag e print na serial seu código hex.

No SQL Server
criar uma tabela para armazenar e consultar os dados.


o arquivo de conexão com o banco é este:
https://github.com/samirmt/VB.Net-Arduino-RFID-SQL-Server/blob/master/VB.NET/Arduino_RFid/App.config

Hardware:

1x Arduino
1x RFID RC522 Mifare (https://goo.gl/oOcnQJ) Fonte da imagem: Arduino e Cia.

pequena demostração:
https://www.youtube.com/watch?v=zmpo-N-FxpQ
