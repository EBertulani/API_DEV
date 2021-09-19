# BACKEND

## conceitos (tecnicas) utilizados 

 - DDD (Domain Drive Design)
 - SOLID
 - Object calisthencs (partes)
 - ORM (Object Relational Mapper)

## separação por camadas

 - API
    - Utilizada para informar valores de entrada, saida e rotas da api;

 - APLICAÇÃO
    - Utilização para manipular valores de entrada para melhor atender o serviço solicitado
    - Utilização para manipular valores de saida para melhor atender o front-end, cliente e diminuir a quantidade de fecth de dados

    - **Profiles**
        - Pasta com os profiles de mapeamento do Automapper.
    - **Serviços**
        - Pasta com os serviços de aplicação e suas interfaces.

 - DATATRANSFER
    - Contexto para informar os objetos utilizados de modelo de entrada e saida (requests e responses)

    - **Requests**
        - Pasta para as classes de request.
    - **Responses**
        - Pasta para as classes de resposta.

 - DOMINIO
    - Serviços do contexto, verificando todas as regras de negocio e solicitando ao serviço do banco que faça as alterações necessarias;
    - Contexto para informar os objectos utilizados de modelo para as tabelas do banco de dados;

    - **Entidades**
        - Pasta responsável por armazenar as entidades e seus enumeradores.
    - **Serviços**
        - Pasta responsável por armazenar os serviços de domínio, os comandos e suas interfaces.
    - **Excecoes**
        - Pasta responsável por armazenar as exceções do contexto.
    - **Repositórios**
        - Pasta responsável por armazenar os repositórios, suas interfaces, as classes de filtros e classes de consulta.

 - INFRA
    - Serviçcos do banco de dados para configura-lo e manipula-lo de acordo com seu dominio;

    - **Repositorios**
        - Pasta responsável por armazenar as implementações dos repositórios.
    - **Mapeamentos**
        - Pasta responsável por armazenar as classes de mapeamento entre entidades e tabelas de banco de dados.
        
 - IOC 
    - Configuração da solução

**observação : para utlização de serviçõs, funções, classes entre outros, criar contexto UTILS dentro da camada para ser generico entre todos os contextos da camada.   Caso seja generico entre mais de 1 camada adicionar na camada de dominio ou a um pacote NUGET**

## bibliotecas sugeridas para uso

 - AutoMapper
 - FluentNhibernate
 - Dapper
 - Nhibernate
 - Swashbuckle.AspNetCore (Swagger)
 - Scrutor
 - MySql.Data
 - Biblioteca interna

## regras de codificação

 - Nome de funções
    - Primeira palavra deve ser um verbo no infinitivo
    - Devem seguir os seus devidos modificadores

 - Nome e tipagem de variaveis
    - Evitar o uso de tipagem explicita e o uso de (dinamic e object)
    - variaveis devem iniciar com letras minusculas e não devem ser abreviações não compreensiveis (ex: v, a, us)

 - Nomes de arquivos
    - a nomeclatura de arquivos devem seguir o seu contexto e a camada

 - Nomes de Propriedades e Entidades
    - Nome de Entidades devem ser no singular e suas propriedades devem iniciar com letras Maiusculas, utilizando sempre CamelCase para ambos

  - Tamanho de arquivos
    - Arquivos, exceto da camada de aplicação, devem conter no maximo 400 linhas

  - Condicionais
    - Evitar a utilização de ELSE

  - Identação
    - Evitar mais de 2 leveis de identação