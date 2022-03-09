<h1 align="center"> 
	:gear: Liberador de versão - SUAT
</h1>

<p align="center">
  <a href="#interrobang">Liberador</a>&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;
  <a href="#rocket-tecnologias">Tecnologias usadas</a>&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;
  <a href="#interrobang-como-usar">Como usar</a>&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;
  <a href="#key-licença">Licença</a>
</p>

<br>
<br>

## :interrobang: O que é o Automatizador? **(Em desenvolvimento)**

Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. 

## :rocket: Tecnologias: **(Em desenvolvimento)**

Este projeto foi desenvolvido com as seguintes tecnologias:

### Backend:
- [.NET][dotnet]
- [Express][express]
- [PostgreSQL][postgresql]


## :fork_and_knife: Gif - Funcionamento do Automatizador: 
<div align="center">
  <img src=".github/public-session-foodfy.gif" alt="Automatizador" height="450px">
</div>


## :construction_worker: Como usar: **(Em desenvolvimento)**

Para clonar e executar essa aplicação você vai precisar do [Git][git-install] instalado em seu computador:  

### :electric_plug: Instalar dependências

```bash
# Clone este repositório:
$ git clone https://github.com/gr-adn-tecnologia/automatizadosuatrodovias.git

# Entre no repositório:
$ cd Automatizador

# Instale as dependências:
$ npm install
```

### Após instalar as dependências, deve-se configurar o banco de dados

Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.

*Perceba que a versão que estou usando neste projeto, é a versão 13. Caso a sua versão instalada seja outra, atente-se ao número da versão na pasta acima. Troque o 13 pela versão do seu postgres.*

#### Windows:

1. Abra o Powershell como administrador, e navegue até a pasta de instalação:
```bash
$ cd "C:\Program Files\PostgreSQL\13\bin\"
```

2. Inicie o postgres com o comando abaixo:
```bash
$ .\pg_ctl.exe -D "C:\Program Files\PostgreSQL\13\data" start
```

3. Após o uso, o comando para desligá-lo é:
```bash
$ .\pg_ctl.exe -D "C:\Program Files\PostgreSQL\13\data" stop
```

#### Mac: 

1. Iniciar o postgres
```shell
pg_ctl -D /usr/local/var/postgres start
```

2. Desligar o postgresql
```shell
pg_ctl -D /usr/local/var/postgres stop
```

#### Linux:
[Documentação Oficial de Instalação do Postgres][postgres-linux]

### Utilizando o Postbird

Após ligar o Postgres, abra o Postbird e crie um banco de dados, de nome foodfy. *As informações de usuário e senha do postgres estão no arquivo src/config/db.js*. <br>
Quando conectado, crie um banco de dados com o nome de foodfy. Após isso, importe um arquivo .sql e utilize o que está na raiz deste repositório. <br>
Se não for possível realizar a importação, abra o arquivo sql e *copie toda a query* para a sessão de Query do Postbird e clique em Run Query<br>
Caso as tabelas tenham sido criadas, a importação ocorreu com sucesso.

### Executar a aplicação
```bash
# Entre no repositório:
$ cd Automatizador
```

```bash
# Inicie a aplicação:
$ npm start

## A aplicação estará rodando na porta 5000 (http://localhost:5000/)
```

```bash
# Popule o DB com dados falsos, utilizando o Faker.js
$ node seeds.js
```

## :key: Licença:

Lançado em 2021. Este projeto é privado.

Feito pela **Equipe de Concessões** da empresa [ADN.Tech][linkedin] :fire: 


[dotnet]: https://docs.microsoft.com/pt-br/dotnet/
[express]: https://expressjs.com/pt-br/
[postgresql]: https://www.enterprisedb.com/downloads/postgres-postgresql-downloads
[postgres-linux]: https://www.postgresql.org/download/linux/

[git]: https://git-scm.com
[git-install]: https://git-scm.com/downloads

[linkedin]: https://www.linkedin.com/company/adn-tecnologia/
