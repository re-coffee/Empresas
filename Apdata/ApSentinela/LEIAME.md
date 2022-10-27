## **ApSentinela v1.0**
Informações           |Descrição
----------------------|-------------------------------
Linguagem             |C# .net Core App 3.1
Saída                 |Executável (exe) 
Tipo                  |Standalone
Runtime Destino       |Win-x64

# Descrição
O aplicativo tem como objetivo varrer todas as tarefas agendadas no windows e retornar no banco as que tiveram retorno diferente de sucesso.

# Como utilizar
Para utilizar, basta executar o .exe como administrador.

# Precauções
o aplicativo não funcionará caso:
 - O nome do banco/instância esteja incorreto/inacessível;
 - O usuário que executa não tenha autenticação no sql pelo windows.
 - O servidor onde é executado não tenha powershell com as autorizações necessárias e não consiga acessar o banco de saída.
