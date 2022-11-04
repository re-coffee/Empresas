## **CheckDescompassoAps v1.0**
Informações           |Descrição
----------------------|-------------------------------
Linguagem             |C# .net Core App 3.1
Saída                 |Executável (exe) 
Tipo                  |Standalone
Runtime Destino       |Win-x64
Parâmetro de execução |String NomeBanco

# Descrição
O aplicativo tem como objetivo ao receber parâmetros de banco realizar um select das instâncias instaladas em cada base e gerar um comparativo para as bases que possuem descompassos.

# Como utilizar
Para utilizar, basta colocar os parametros dos nomes dos bancos/instâncias desejadas,

exemplo de chamada:
>CheckDescompassoAps.exe BANCO1 BANCO2/INSTANCIA BANCO3 BANCO4

# Precauções
o aplicativo não funcionará caso:
 - O nome do banco/instância esteja incorreto/inacessível;
 - O usuário que executa não tenha autenticação no sql pelo windows.

⚠️**Atenção**: o arquivo comparativo é gerado na mesma pasta onde o .exe se encontra.
